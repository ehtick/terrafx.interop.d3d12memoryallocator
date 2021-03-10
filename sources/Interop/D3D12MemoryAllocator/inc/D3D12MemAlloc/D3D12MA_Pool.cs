// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12MemAlloc.h in D3D12MemoryAllocator commit 5457bcdaee73ee1f3fe6027bbabf959119f88b3d
// Original source is Copyright © Advanced Micro Devices, Inc. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using static TerraFX.Interop.D3D12MemAlloc;

namespace TerraFX.Interop
{
    /// <summary>
    /// Custom memory pool
    /// <para>
    /// Represents a separate set of heaps (memory blocks) that can be used to create
    /// <see cref="D3D12MA_Allocation"/>-s and resources in it. Usually there is no need to create custom
    /// pools - creating resources in default pool is sufficient.
    /// </para>
    /// <para>To create custom pool, fill <see cref="D3D12MA_POOL_DESC"/> and call <see cref="D3D12MA_Allocator.CreatePool"/>.</para>
    /// </summary>
    public unsafe struct D3D12MA_Pool : IDisposable
    {
        internal D3D12MA_PoolPimpl* m_Pimpl;

        /// <summary>
        /// Deletes pool object, frees D3D12 heaps (memory blocks) managed by it. Allocations and resources must already be released!
        /// <para>It doesn't delete allocations and resources created in this pool. They must be all released before calling this function!</para>
        /// </summary>
        public void Release()
        {
            if (Unsafe.IsNullRef(ref this))
            {
                return;
            }

            using var debugGlobalMutexLock = D3D12MA_DEBUG_GLOBAL_MUTEX_LOCK();
            D3D12MA_DELETE(m_Pimpl->GetAllocator()->GetAllocs(), ref this);
        }

        /// <summary>
        /// Returns copy of parameters of the pool.
        /// <para>These are the same parameters as passed to <see cref="D3D12MA_Allocator.CreatePool"/>.</para>
        /// </summary>
        public readonly D3D12MA_POOL_DESC GetDesc()
        {
            return *m_Pimpl->GetDesc();
        }

        /// <summary>
        /// Sets the minimum number of bytes that should always be allocated (reserved) in this pool.
        /// <para>See also: reserving_memory.</para>
        /// </summary>
        [return: NativeTypeName("HRESULT")]
        public int SetMinBytes([NativeTypeName("UINT64")] ulong minBytes)
        {
            return m_Pimpl->SetMinBytes(minBytes);
        }

        /// <summary>Retrieves statistics from the current state of this pool.</summary>
        public void CalculateStats(D3D12MA_StatInfo* pStats)
        {
            D3D12MA_ASSERT((D3D12MA_DEBUG_LEVEL > 0) && (pStats != null));
            using var debugGlobalMutexLock = D3D12MA_DEBUG_GLOBAL_MUTEX_LOCK();
            m_Pimpl->CalculateStats(pStats);
        }

        /// <summary>
        /// Associates a name with the pool. This name is for use in debug diagnostics and tools.
        /// <para>Internal copy of the string is made, so the memory pointed by the argument can be changed of freed immediately after this call.</para>
        /// </summary>
        /// <param name="Name">`Name` can be null.</param>
        public void SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            using var debugGlobalMutexLock = D3D12MA_DEBUG_GLOBAL_MUTEX_LOCK();
            m_Pimpl->SetName(Name);
        }

        /// <summary>
        /// Returns the name associated with the pool object.
        /// <para>Returned string points to an internal copy.</para>
        /// <para>If no name was associated with the allocation, returns <see langword="null"/>.</para>
        /// </summary>
        [return: NativeTypeName("LPCWSTR")]
        public ushort* GetName()
        {
            return m_Pimpl->GetName();
        }

        internal static void _ctor(ref D3D12MA_Pool pThis, ref D3D12MA_Allocator allocator, [NativeTypeName("const POOL_DESC&")] D3D12MA_POOL_DESC* desc)
        {
            pThis.m_Pimpl = D3D12MA_NEW<D3D12MA_PoolPimpl>(allocator.m_Pimpl->GetAllocs());
            D3D12MA_PoolPimpl._ctor(ref *pThis.m_Pimpl, allocator.m_Pimpl, desc);
        }

        void IDisposable.Dispose()
        {
            m_Pimpl->GetAllocator()->UnregisterPool(ref this, m_Pimpl->GetDesc()->HeapProperties.Type);
            D3D12MA_DELETE(m_Pimpl->GetAllocator()->GetAllocs(), m_Pimpl);
        }
    }
}

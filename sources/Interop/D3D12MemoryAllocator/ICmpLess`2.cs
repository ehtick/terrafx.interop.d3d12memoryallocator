// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.Windows.D3D12MA
{
    internal interface ICmpLess<T, U>
        where T : unmanaged
    {
        bool Invoke(T lhs, U rhs);
    }
}

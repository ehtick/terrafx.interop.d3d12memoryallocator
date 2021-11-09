// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12Sample.cpp in D3D12MemoryAllocator commit 5457bcdaee73ee1f3fe6027bbabf959119f88b3d
// Original source is Copyright © Advanced Micro Devices, Inc. All rights reserved. Licensed under the MIT License (MIT).

using System;

namespace TerraFX.Interop.Windows.D3D12MA.UnitTests
{
    internal static class VS
    {
        [NativeTypeName("BYTE[]")]
        public static ReadOnlySpan<byte> g_main => new byte[]
        {
             68,  88,  66,  67, 206,  13,
            137, 181, 114, 110, 131,  98,
             24, 137, 147, 240, 237, 245,
             81, 131,   1,   0,   0,   0,
            192,   3,   0,   0,   5,   0,
              0,   0,  52,   0,   0,   0,
             88,   1,   0,   0, 172,   1,
              0,   0,   4,   2,   0,   0,
             36,   3,   0,   0,  82,  68,
             69,  70,  28,   1,   0,   0,
              1,   0,   0,   0, 108,   0,
              0,   0,   1,   0,   0,   0,
             60,   0,   0,   0,   0,   5,
            254, 255,   0, 129,   0,   0,
            232,   0,   0,   0,  82,  68,
             49,  49,  60,   0,   0,   0,
             24,   0,   0,   0,  32,   0,
              0,   0,  40,   0,   0,   0,
             36,   0,   0,   0,  12,   0,
              0,   0,   0,   0,   0,   0,
             92,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   1,   0,   0,   0,
              1,   0,   0,   0,   1,   0,
              0,   0,  67, 111, 110, 115,
            116,  97, 110, 116,  66, 117,
            102, 102, 101, 114,  49,   0,
             92,   0,   0,   0,   1,   0,
              0,   0, 132,   0,   0,   0,
             64,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
            172,   0,   0,   0,   0,   0,
              0,   0,  64,   0,   0,   0,
              2,   0,   0,   0, 196,   0,
              0,   0,   0,   0,   0,   0,
            255, 255, 255, 255,   0,   0,
              0,   0, 255, 255, 255, 255,
              0,   0,   0,   0,  87, 111,
            114, 108, 100,  86, 105, 101,
            119,  80, 114, 111, 106,   0,
            102, 108, 111,  97, 116,  52,
            120,  52,   0, 171,   3,   0,
              3,   0,   4,   0,   4,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
            186,   0,   0,   0,  77, 105,
             99, 114, 111, 115, 111, 102,
            116,  32,  40,  82,  41,  32,
             72,  76,  83,  76,  32,  83,
            104,  97, 100, 101, 114,  32,
             67, 111, 109, 112, 105, 108,
            101, 114,  32,  49,  48,  46,
             48,  46,  49,  48,  48,  49,
             49,  46,  49,  54,  51,  56,
             52,   0,  73,  83,  71,  78,
             76,   0,   0,   0,   2,   0,
              0,   0,   8,   0,   0,   0,
             56,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              3,   0,   0,   0,   0,   0,
              0,   0,   7,   7,   0,   0,
             65,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              3,   0,   0,   0,   1,   0,
              0,   0,   3,   3,   0,   0,
             80,  79,  83,  73,  84,  73,
             79,  78,   0,  84,  69,  88,
             67,  79,  79,  82,  68,   0,
            171, 171,  79,  83,  71,  78,
             80,   0,   0,   0,   2,   0,
              0,   0,   8,   0,   0,   0,
             56,   0,   0,   0,   0,   0,
              0,   0,   1,   0,   0,   0,
              3,   0,   0,   0,   0,   0,
              0,   0,  15,   0,   0,   0,
             68,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              3,   0,   0,   0,   1,   0,
              0,   0,   3,  12,   0,   0,
             83,  86,  95,  80,  79,  83,
             73,  84,  73,  79,  78,   0,
             84,  69,  88,  67,  79,  79,
             82,  68,   0, 171, 171, 171,
             83,  72,  69,  88,  24,   1,
              0,   0,  80,   0,   1,   0,
             70,   0,   0,   0, 106,   8,
              0,   1,  89,   0,   0,   4,
             70, 142,  32,   0,   1,   0,
              0,   0,   4,   0,   0,   0,
             95,   0,   0,   3, 114,  16,
             16,   0,   0,   0,   0,   0,
             95,   0,   0,   3,  50,  16,
             16,   0,   1,   0,   0,   0,
            103,   0,   0,   4, 242,  32,
             16,   0,   0,   0,   0,   0,
              1,   0,   0,   0, 101,   0,
              0,   3,  50,  32,  16,   0,
              1,   0,   0,   0, 104,   0,
              0,   2,   1,   0,   0,   0,
             54,   0,   0,   5, 114,   0,
             16,   0,   0,   0,   0,   0,
             70,  18,  16,   0,   0,   0,
              0,   0,  54,   0,   0,   5,
            130,   0,  16,   0,   0,   0,
              0,   0,   1,  64,   0,   0,
              0,   0, 128,  63,  17,   0,
              0,   8,  18,  32,  16,   0,
              0,   0,   0,   0,  70,  14,
             16,   0,   0,   0,   0,   0,
             70, 142,  32,   0,   1,   0,
              0,   0,   0,   0,   0,   0,
             17,   0,   0,   8,  34,  32,
             16,   0,   0,   0,   0,   0,
             70,  14,  16,   0,   0,   0,
              0,   0,  70, 142,  32,   0,
              1,   0,   0,   0,   1,   0,
              0,   0,  17,   0,   0,   8,
             66,  32,  16,   0,   0,   0,
              0,   0,  70,  14,  16,   0,
              0,   0,   0,   0,  70, 142,
             32,   0,   1,   0,   0,   0,
              2,   0,   0,   0,  17,   0,
              0,   8, 130,  32,  16,   0,
              0,   0,   0,   0,  70,  14,
             16,   0,   0,   0,   0,   0,
             70, 142,  32,   0,   1,   0,
              0,   0,   3,   0,   0,   0,
             54,   0,   0,   5,  50,  32,
             16,   0,   1,   0,   0,   0,
             70,  16,  16,   0,   1,   0,
              0,   0,  62,   0,   0,   1,
             83,  84,  65,  84, 148,   0,
              0,   0,   8,   0,   0,   0,
              1,   0,   0,   0,   0,   0,
              0,   0,   4,   0,   0,   0,
              4,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              1,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              3,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0,
              0,   0,   0,   0,   0,   0
        };
    }
}

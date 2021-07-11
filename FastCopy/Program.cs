using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using FastCopyTest;

BenchmarkRunner.Run<BenchmarkCopy>();
// 
// 
// var arrSrc = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
// var arrDst = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

// unsafe
// {
//     fixed (int* src = arrSrc)
//     {
//         fixed (int* dst = arrDst)
//         {
//             // FastCopy.Copy(dst + 2, src + 3, 9);
//             MoveMemory(dst, src, 5);
//         }
//     }
// }
// 
// Console.WriteLine(string.Join(", ", arrDst));


[DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = false)]
static extern unsafe void MoveMemory(void* dst, void* src, ulong length);

public unsafe static class FastCopy
{
    public static void CopyAligned<T>(T* bDst, T* bSrc, int count) where T : unmanaged
        => CopyPlainAligned(bDst, bSrc, sizeof(T) * count);

    public static void CopyPlainAligned(void* bDst, void* bSrc, int count)
    {
        const int LOOP_UNROLL = 4;

        var dst = (byte*)bDst;
        var src = (byte*)bSrc;

        var blockCount = count - 32 * LOOP_UNROLL;

        int i;
        for (i = 0; i < blockCount; i += 32 * LOOP_UNROLL)
        {
            var s = src + i;
            var d = dst + i;
            var vec = Avx.LoadAlignedVector256(s);
            Avx.Store(d, vec);

            s += 32; d += 32;
            vec = Avx.LoadAlignedVector256(s);
            Avx.Store(d, vec);

            s += 32; d += 32;
            vec = Avx.LoadAlignedVector256(s);
            Avx.StoreAligned(d, vec);

            s += 32; d += 32;
            vec = Avx.LoadAlignedVector256(s);
            Avx.StoreAligned(d, vec);
        }

        var blockCount2 = count - 32;

        for (; i < blockCount2; i += 32)
        {
            var s = src + i;
            var d = dst + i;
            var vec = Avx.LoadAlignedVector256(s);
            Avx.StoreAligned(d, vec);
        }

        var blockCount3 = count - 16;

        for (; i < blockCount3; i += 16)
        {
            var vec = Avx.LoadAlignedVector128(src + i);
            Avx.StoreAligned(dst + i, vec);
        }

        for (; i < count; i++)
            dst[i] = src[i];
    }

    public static void CopyStraightForward<T>(T* bDst, T* bSrc, int count) where T : unmanaged
    {
        for (int i = 0; i < count; i++)
            bDst[i] = bSrc[i];
    }
}
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;


namespace FastCopyTest
{
    unsafe public class BenchmarkCopy
    {
        private int* arr1;
        private int* arr2;

        const int LENGTH = 10_000_000;

        [Params(1000, 10_000, 100_000, 1_000_000)]
        public int ToCopyLength { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            arr1 = (int*)NativeMemory.AlignedAlloc(LENGTH, 32);
            arr2 = (int*)NativeMemory.AlignedAlloc(LENGTH, 32);
        }

        [Benchmark]
        public void MyCopy()
        {
            FastCopy.CopyAligned(arr1, arr2, ToCopyLength);
        }

        [Benchmark]
        public void MemoryCopy()
        {
            Buffer.MemoryCopy(arr2, arr1, LENGTH, ToCopyLength * sizeof(int));
        }

        [Benchmark]
        public void Kernel32MoveMemory()
        {
            MoveMemory(arr2, arr1, (ulong)(ToCopyLength * sizeof(int)));
        }

        [Benchmark]
        public void Straightforward()
        {
            FastCopy.CopyStraightForward(arr2, arr1, ToCopyLength);
        }

        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = false)]
        static extern unsafe void MoveMemory(void* dst, void* src, ulong length);
    }
}

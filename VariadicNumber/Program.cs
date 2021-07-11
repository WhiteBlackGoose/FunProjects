// VariadicNumber a = 5;
// Console.WriteLine($"a = {a.ToString(true)} ; a / 2 = {a / 2}");
// VariadicNumber b = 5.0;
// Console.WriteLine($"b = {b.ToString(true)} ; b / 2 = {b / 2}");



// 
// Benchmarking results:
// a + (b + 1) / (a + 2) costs as much as 65 ns
// if both a and b are of the same type
//
//
// |                     Method |     Mean |    Error |   StdDev |
// |--------------------------- |---------:|---------:|---------:|
// |    VariadicNumberSumAllInt | 66.28 ns | 1.128 ns | 1.055 ns |
// |  VariadicNumberSumAllFloat | 63.65 ns | 1.131 ns | 2.040 ns |
// | VariadicNumberSumAllDouble | 71.22 ns | 0.797 ns | 0.706 ns |
// |           DynamicSumAllInt | 31.19 ns | 0.605 ns | 0.906 ns |
// |         DynamicSumAllFloat | 31.65 ns | 0.544 ns | 0.582 ns |
// |        DynamicSumAllDouble | 31.88 ns | 0.405 ns | 0.338 ns |
//

using BenchmarkDotNet.Running;

BenchmarkRunner.Run<BenchVariadicNumber>();
// new BenchVariadicNumber().DynamicSumAllDouble();

VariadicNumber a = 5;
Console.WriteLine($"a = {a.ToString(true)} ; a / 2 = {a / 2}");
VariadicNumber b = 5.0;
Console.WriteLine($"b = {b.ToString(true)} ; b / 2 = {b / 2}");



// 
// Benchmarking results:
// a + (b + 1) / (a + 2) costs as much as 65 ns
// if both a and b are of the same type
//


// using BenchmarkDotNet.Running;
// 
// BenchmarkRunner.Run<BenchVariadicNumber>();


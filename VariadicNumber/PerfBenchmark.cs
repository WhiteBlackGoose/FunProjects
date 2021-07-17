using BenchmarkDotNet.Attributes;
using HonkSharp.Fluency;
using System.Linq;

[MemoryDiagnoser]
public class BenchVariadicNumber
{
    const int OperationsPerInvoke = 10_000;

    public VariadicNumber[] numbersInt = new VariadicNumber[OperationsPerInvoke];
    public VariadicNumber[] numbersFloat = new VariadicNumber[OperationsPerInvoke];
    public VariadicNumber[] numbersDouble = new VariadicNumber[OperationsPerInvoke];
    public dynamic[] dynamicsInt = (0..(OperationsPerInvoke - 1)).Select(_ => (dynamic)0).ToArray();
    public dynamic[] dynamicsFloat = (0..(OperationsPerInvoke - 1)).Select(_ => (dynamic)0f).ToArray();
    public dynamic[] dynamicsDouble = (0..(OperationsPerInvoke - 1)).Select(_ => (dynamic)0d).ToArray();
    public double[] doubleDouble = (0..(OperationsPerInvoke - 1)).Select(_ => 0d).ToArray();
    private int currId = 0;

    // [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    // public void VariadicNumberSumAllInt()
    // {
    //     VariadicNumber a = 0;
    //     foreach (var el in numbersInt)
    //         a += (el + 1) / (a + 1);
    //     numbersInt[currId] = a;
    //     currId = (currId + 1) % OperationsPerInvoke;
    // }
    // 
    // [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    // public void VariadicNumberSumAllFloat()
    // {
    //     VariadicNumber a = 0f;
    //     foreach (var el in numbersFloat)
    //         a += (el + 1) / (a + 2);
    //     numbersFloat[currId] = a;
    //     currId = (currId + 1) % OperationsPerInvoke;
    // }

    [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    public void VariadicNumberSumAllDouble()
    {
        VariadicNumber a = 0d;
        foreach (var el in numbersDouble)
            a += (el + 1) / (a + 2);
        numbersDouble[currId] = a;
        currId = (currId + 1) % OperationsPerInvoke;
    }



    // [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    // public void DynamicSumAllInt()
    // {
    //     dynamic a = 0;
    //     foreach (var el in dynamicsInt)
    //         a += (el + 1) / (a + 1);
    //     dynamicsInt[currId] = a;
    //     currId = (currId + 1) % OperationsPerInvoke;
    // }
    // 
    // [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    // public void DynamicSumAllFloat()
    // {
    //     dynamic a = 0f;
    //     foreach (var el in dynamicsFloat)
    //         a += (el + 1) / (a + 2);
    //     dynamicsFloat[currId] = a;
    //     currId = (currId + 1) % OperationsPerInvoke;
    // }

    [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    public void DynamicSumAllDouble()
    {
        dynamic a = 0d;
        foreach (var el in dynamicsDouble)
            a += (el + 1) / (a + 2);
        dynamicsDouble[currId] = a;
        currId = (currId + 1) % OperationsPerInvoke;
    }

    [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    public void DoubleSumAllDouble()
    {
        double a = 0d;
        foreach (var el in doubleDouble)
            a += (el + 1) / (a + 2);
        doubleDouble[currId] = a;
        currId = (currId + 1) % OperationsPerInvoke;
    }
}
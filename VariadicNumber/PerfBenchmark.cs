using BenchmarkDotNet.Attributes;

public class BenchVariadicNumber
{
    const int OperationsPerInvoke = 300;

    public VariadicNumber[] numbersInt = new VariadicNumber[OperationsPerInvoke];
    public VariadicNumber[] numbersFloat = new VariadicNumber[OperationsPerInvoke];
    public VariadicNumber[] numbersDouble = new VariadicNumber[OperationsPerInvoke];
    private int currId = 0;

    [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    public void SumAllInt()
    {
        VariadicNumber a = 0;
        foreach (var el in numbersInt)
            a += (el + 1) / (a + 1);
        numbersInt[currId] = a;
        currId = (currId + 1) % OperationsPerInvoke;
    }

    [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    public void SumAllFloat()
    {
        VariadicNumber a = 0f;
        foreach (var el in numbersFloat)
            a += (el + 1) / (a + 2);
        numbersFloat[currId] = a;
        currId = (currId + 1) % OperationsPerInvoke;
    }

    [Benchmark(OperationsPerInvoke = OperationsPerInvoke)]
    public void SumAllDouble()
    {
        VariadicNumber a = 0d;
        foreach (var el in numbersDouble)
            a += (el + 1) / (a + 2);
        numbersDouble[currId] = a;
        currId = (currId + 1) % OperationsPerInvoke;
    }
}
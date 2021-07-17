using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


[StructLayout(LayoutKind.Explicit)]
public unsafe struct VariadicNumber
{
    [FieldOffset(0)]
    private int index;

    [FieldOffset(8)]
    private byte byteValue;
    [FieldOffset(8)]
    private sbyte sbyteValue;
    [FieldOffset(8)]
    private ushort ushortValue;
    [FieldOffset(8)]
    private short shortValue;
    [FieldOffset(8)]
    private uint uintValue;
    [FieldOffset(8)]
    private int intValue;
    [FieldOffset(8)]
    private ulong ulongValue;
    [FieldOffset(8)]
    private long longValue;
    [FieldOffset(8)]
    private float floatValue;
    [FieldOffset(8)]
    private double doubleValue;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(byte value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        byteValue = value;
        index = 0;
    }

    public static implicit operator VariadicNumber(byte value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(sbyte value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        sbyteValue = value;
        index = 1;
    }

    public static implicit operator VariadicNumber(sbyte value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(ushort value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        ushortValue = value;
        index = 2;
    }

    public static implicit operator VariadicNumber(ushort value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(short value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        shortValue = value;
        index = 3;
    }

    public static implicit operator VariadicNumber(short value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(uint value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        uintValue = value;
        index = 4;
    }

    public static implicit operator VariadicNumber(uint value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(int value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        intValue = value;
        index = 5;
    }

    public static implicit operator VariadicNumber(int value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(ulong value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        ulongValue = value;
        index = 6;
    }

    public static implicit operator VariadicNumber(ulong value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(long value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        longValue = value;
        index = 7;
    }

    public static implicit operator VariadicNumber(long value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(float value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        floatValue = value;
        index = 8;
    }

    public static implicit operator VariadicNumber(float value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VariadicNumber(double value)
    {
        Unsafe.SkipInit(out byteValue);
        Unsafe.SkipInit(out sbyteValue);
        Unsafe.SkipInit(out ushortValue);
        Unsafe.SkipInit(out shortValue);
        Unsafe.SkipInit(out uintValue);
        Unsafe.SkipInit(out intValue);
        Unsafe.SkipInit(out ulongValue);
        Unsafe.SkipInit(out longValue);
        Unsafe.SkipInit(out floatValue);
        Unsafe.SkipInit(out doubleValue);
        doubleValue = value;
        index = 9;
    }

    public static implicit operator VariadicNumber(double value) => new(value);


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static VariadicNumber operator +(VariadicNumber a, VariadicNumber b)
        => opAdd[a.index * 10 + b.index](a.longValue, b.longValue);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static VariadicNumber operator -(VariadicNumber a, VariadicNumber b)
        => opSubtract[a.index * 10 + b.index](a.longValue, b.longValue);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static VariadicNumber operator *(VariadicNumber a, VariadicNumber b)
        => opMultiply[a.index * 10 + b.index](a.longValue, b.longValue);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static VariadicNumber operator /(VariadicNumber a, VariadicNumber b)
        => opDivide[a.index * 10 + b.index](a.longValue, b.longValue);

    private static readonly delegate*<long, long, VariadicNumber>[] opAdd = new delegate*<long, long, VariadicNumber>[]
    {
        &OpAddbytebyte,
        &OpAddbytesbyte,
        &OpAddbyteushort,
        &OpAddbyteshort,
        &OpAddbyteuint,
        &OpAddbyteint,
        &OpAddbyteulong,
        &OpAddbytelong,
        &OpAddbytefloat,
        &OpAddbytedouble,
        &OpAddsbytebyte,
        &OpAddsbytesbyte,
        &OpAddsbyteushort,
        &OpAddsbyteshort,
        &OpAddsbyteuint,
        &OpAddsbyteint,
        &OpAddsbyteulong,
        &OpAddsbytelong,
        &OpAddsbytefloat,
        &OpAddsbytedouble,
        &OpAddushortbyte,
        &OpAddushortsbyte,
        &OpAddushortushort,
        &OpAddushortshort,
        &OpAddushortuint,
        &OpAddushortint,
        &OpAddushortulong,
        &OpAddushortlong,
        &OpAddushortfloat,
        &OpAddushortdouble,
        &OpAddshortbyte,
        &OpAddshortsbyte,
        &OpAddshortushort,
        &OpAddshortshort,
        &OpAddshortuint,
        &OpAddshortint,
        &OpAddshortulong,
        &OpAddshortlong,
        &OpAddshortfloat,
        &OpAddshortdouble,
        &OpAdduintbyte,
        &OpAdduintsbyte,
        &OpAdduintushort,
        &OpAdduintshort,
        &OpAdduintuint,
        &OpAdduintint,
        &OpAdduintulong,
        &OpAdduintlong,
        &OpAdduintfloat,
        &OpAdduintdouble,
        &OpAddintbyte,
        &OpAddintsbyte,
        &OpAddintushort,
        &OpAddintshort,
        &OpAddintuint,
        &OpAddintint,
        &OpAddintulong,
        &OpAddintlong,
        &OpAddintfloat,
        &OpAddintdouble,
        &OpAddulongbyte,
        &OpAddulongsbyte,
        &OpAddulongushort,
        &OpAddulongshort,
        &OpAddulonguint,
        &OpAddulongint,
        &OpAddulongulong,
        &OpAddulonglong,
        &OpAddulongfloat,
        &OpAddulongdouble,
        &OpAddlongbyte,
        &OpAddlongsbyte,
        &OpAddlongushort,
        &OpAddlongshort,
        &OpAddlonguint,
        &OpAddlongint,
        &OpAddlongulong,
        &OpAddlonglong,
        &OpAddlongfloat,
        &OpAddlongdouble,
        &OpAddfloatbyte,
        &OpAddfloatsbyte,
        &OpAddfloatushort,
        &OpAddfloatshort,
        &OpAddfloatuint,
        &OpAddfloatint,
        &OpAddfloatulong,
        &OpAddfloatlong,
        &OpAddfloatfloat,
        &OpAddfloatdouble,
        &OpAdddoublebyte,
        &OpAdddoublesbyte,
        &OpAdddoubleushort,
        &OpAdddoubleshort,
        &OpAdddoubleuint,
        &OpAdddoubleint,
        &OpAdddoubleulong,
        &OpAdddoublelong,
        &OpAdddoublefloat,
        &OpAdddoubledouble,
    };
    private static readonly delegate*<long, long, VariadicNumber>[] opSubtract = new delegate*<long, long, VariadicNumber>[]
    {
        &OpSubtractbytebyte,
        &OpSubtractbytesbyte,
        &OpSubtractbyteushort,
        &OpSubtractbyteshort,
        &OpSubtractbyteuint,
        &OpSubtractbyteint,
        &OpSubtractbyteulong,
        &OpSubtractbytelong,
        &OpSubtractbytefloat,
        &OpSubtractbytedouble,
        &OpSubtractsbytebyte,
        &OpSubtractsbytesbyte,
        &OpSubtractsbyteushort,
        &OpSubtractsbyteshort,
        &OpSubtractsbyteuint,
        &OpSubtractsbyteint,
        &OpSubtractsbyteulong,
        &OpSubtractsbytelong,
        &OpSubtractsbytefloat,
        &OpSubtractsbytedouble,
        &OpSubtractushortbyte,
        &OpSubtractushortsbyte,
        &OpSubtractushortushort,
        &OpSubtractushortshort,
        &OpSubtractushortuint,
        &OpSubtractushortint,
        &OpSubtractushortulong,
        &OpSubtractushortlong,
        &OpSubtractushortfloat,
        &OpSubtractushortdouble,
        &OpSubtractshortbyte,
        &OpSubtractshortsbyte,
        &OpSubtractshortushort,
        &OpSubtractshortshort,
        &OpSubtractshortuint,
        &OpSubtractshortint,
        &OpSubtractshortulong,
        &OpSubtractshortlong,
        &OpSubtractshortfloat,
        &OpSubtractshortdouble,
        &OpSubtractuintbyte,
        &OpSubtractuintsbyte,
        &OpSubtractuintushort,
        &OpSubtractuintshort,
        &OpSubtractuintuint,
        &OpSubtractuintint,
        &OpSubtractuintulong,
        &OpSubtractuintlong,
        &OpSubtractuintfloat,
        &OpSubtractuintdouble,
        &OpSubtractintbyte,
        &OpSubtractintsbyte,
        &OpSubtractintushort,
        &OpSubtractintshort,
        &OpSubtractintuint,
        &OpSubtractintint,
        &OpSubtractintulong,
        &OpSubtractintlong,
        &OpSubtractintfloat,
        &OpSubtractintdouble,
        &OpSubtractulongbyte,
        &OpSubtractulongsbyte,
        &OpSubtractulongushort,
        &OpSubtractulongshort,
        &OpSubtractulonguint,
        &OpSubtractulongint,
        &OpSubtractulongulong,
        &OpSubtractulonglong,
        &OpSubtractulongfloat,
        &OpSubtractulongdouble,
        &OpSubtractlongbyte,
        &OpSubtractlongsbyte,
        &OpSubtractlongushort,
        &OpSubtractlongshort,
        &OpSubtractlonguint,
        &OpSubtractlongint,
        &OpSubtractlongulong,
        &OpSubtractlonglong,
        &OpSubtractlongfloat,
        &OpSubtractlongdouble,
        &OpSubtractfloatbyte,
        &OpSubtractfloatsbyte,
        &OpSubtractfloatushort,
        &OpSubtractfloatshort,
        &OpSubtractfloatuint,
        &OpSubtractfloatint,
        &OpSubtractfloatulong,
        &OpSubtractfloatlong,
        &OpSubtractfloatfloat,
        &OpSubtractfloatdouble,
        &OpSubtractdoublebyte,
        &OpSubtractdoublesbyte,
        &OpSubtractdoubleushort,
        &OpSubtractdoubleshort,
        &OpSubtractdoubleuint,
        &OpSubtractdoubleint,
        &OpSubtractdoubleulong,
        &OpSubtractdoublelong,
        &OpSubtractdoublefloat,
        &OpSubtractdoubledouble,
    };
    private static readonly delegate*<long, long, VariadicNumber>[] opMultiply = new delegate*<long, long, VariadicNumber>[]
    {
        &OpMultiplybytebyte,
        &OpMultiplybytesbyte,
        &OpMultiplybyteushort,
        &OpMultiplybyteshort,
        &OpMultiplybyteuint,
        &OpMultiplybyteint,
        &OpMultiplybyteulong,
        &OpMultiplybytelong,
        &OpMultiplybytefloat,
        &OpMultiplybytedouble,
        &OpMultiplysbytebyte,
        &OpMultiplysbytesbyte,
        &OpMultiplysbyteushort,
        &OpMultiplysbyteshort,
        &OpMultiplysbyteuint,
        &OpMultiplysbyteint,
        &OpMultiplysbyteulong,
        &OpMultiplysbytelong,
        &OpMultiplysbytefloat,
        &OpMultiplysbytedouble,
        &OpMultiplyushortbyte,
        &OpMultiplyushortsbyte,
        &OpMultiplyushortushort,
        &OpMultiplyushortshort,
        &OpMultiplyushortuint,
        &OpMultiplyushortint,
        &OpMultiplyushortulong,
        &OpMultiplyushortlong,
        &OpMultiplyushortfloat,
        &OpMultiplyushortdouble,
        &OpMultiplyshortbyte,
        &OpMultiplyshortsbyte,
        &OpMultiplyshortushort,
        &OpMultiplyshortshort,
        &OpMultiplyshortuint,
        &OpMultiplyshortint,
        &OpMultiplyshortulong,
        &OpMultiplyshortlong,
        &OpMultiplyshortfloat,
        &OpMultiplyshortdouble,
        &OpMultiplyuintbyte,
        &OpMultiplyuintsbyte,
        &OpMultiplyuintushort,
        &OpMultiplyuintshort,
        &OpMultiplyuintuint,
        &OpMultiplyuintint,
        &OpMultiplyuintulong,
        &OpMultiplyuintlong,
        &OpMultiplyuintfloat,
        &OpMultiplyuintdouble,
        &OpMultiplyintbyte,
        &OpMultiplyintsbyte,
        &OpMultiplyintushort,
        &OpMultiplyintshort,
        &OpMultiplyintuint,
        &OpMultiplyintint,
        &OpMultiplyintulong,
        &OpMultiplyintlong,
        &OpMultiplyintfloat,
        &OpMultiplyintdouble,
        &OpMultiplyulongbyte,
        &OpMultiplyulongsbyte,
        &OpMultiplyulongushort,
        &OpMultiplyulongshort,
        &OpMultiplyulonguint,
        &OpMultiplyulongint,
        &OpMultiplyulongulong,
        &OpMultiplyulonglong,
        &OpMultiplyulongfloat,
        &OpMultiplyulongdouble,
        &OpMultiplylongbyte,
        &OpMultiplylongsbyte,
        &OpMultiplylongushort,
        &OpMultiplylongshort,
        &OpMultiplylonguint,
        &OpMultiplylongint,
        &OpMultiplylongulong,
        &OpMultiplylonglong,
        &OpMultiplylongfloat,
        &OpMultiplylongdouble,
        &OpMultiplyfloatbyte,
        &OpMultiplyfloatsbyte,
        &OpMultiplyfloatushort,
        &OpMultiplyfloatshort,
        &OpMultiplyfloatuint,
        &OpMultiplyfloatint,
        &OpMultiplyfloatulong,
        &OpMultiplyfloatlong,
        &OpMultiplyfloatfloat,
        &OpMultiplyfloatdouble,
        &OpMultiplydoublebyte,
        &OpMultiplydoublesbyte,
        &OpMultiplydoubleushort,
        &OpMultiplydoubleshort,
        &OpMultiplydoubleuint,
        &OpMultiplydoubleint,
        &OpMultiplydoubleulong,
        &OpMultiplydoublelong,
        &OpMultiplydoublefloat,
        &OpMultiplydoubledouble,
    };
    private static readonly delegate*<long, long, VariadicNumber>[] opDivide = new delegate*<long, long, VariadicNumber>[]
    {
        &OpDividebytebyte,
        &OpDividebytesbyte,
        &OpDividebyteushort,
        &OpDividebyteshort,
        &OpDividebyteuint,
        &OpDividebyteint,
        &OpDividebyteulong,
        &OpDividebytelong,
        &OpDividebytefloat,
        &OpDividebytedouble,
        &OpDividesbytebyte,
        &OpDividesbytesbyte,
        &OpDividesbyteushort,
        &OpDividesbyteshort,
        &OpDividesbyteuint,
        &OpDividesbyteint,
        &OpDividesbyteulong,
        &OpDividesbytelong,
        &OpDividesbytefloat,
        &OpDividesbytedouble,
        &OpDivideushortbyte,
        &OpDivideushortsbyte,
        &OpDivideushortushort,
        &OpDivideushortshort,
        &OpDivideushortuint,
        &OpDivideushortint,
        &OpDivideushortulong,
        &OpDivideushortlong,
        &OpDivideushortfloat,
        &OpDivideushortdouble,
        &OpDivideshortbyte,
        &OpDivideshortsbyte,
        &OpDivideshortushort,
        &OpDivideshortshort,
        &OpDivideshortuint,
        &OpDivideshortint,
        &OpDivideshortulong,
        &OpDivideshortlong,
        &OpDivideshortfloat,
        &OpDivideshortdouble,
        &OpDivideuintbyte,
        &OpDivideuintsbyte,
        &OpDivideuintushort,
        &OpDivideuintshort,
        &OpDivideuintuint,
        &OpDivideuintint,
        &OpDivideuintulong,
        &OpDivideuintlong,
        &OpDivideuintfloat,
        &OpDivideuintdouble,
        &OpDivideintbyte,
        &OpDivideintsbyte,
        &OpDivideintushort,
        &OpDivideintshort,
        &OpDivideintuint,
        &OpDivideintint,
        &OpDivideintulong,
        &OpDivideintlong,
        &OpDivideintfloat,
        &OpDivideintdouble,
        &OpDivideulongbyte,
        &OpDivideulongsbyte,
        &OpDivideulongushort,
        &OpDivideulongshort,
        &OpDivideulonguint,
        &OpDivideulongint,
        &OpDivideulongulong,
        &OpDivideulonglong,
        &OpDivideulongfloat,
        &OpDivideulongdouble,
        &OpDividelongbyte,
        &OpDividelongsbyte,
        &OpDividelongushort,
        &OpDividelongshort,
        &OpDividelonguint,
        &OpDividelongint,
        &OpDividelongulong,
        &OpDividelonglong,
        &OpDividelongfloat,
        &OpDividelongdouble,
        &OpDividefloatbyte,
        &OpDividefloatsbyte,
        &OpDividefloatushort,
        &OpDividefloatshort,
        &OpDividefloatuint,
        &OpDividefloatint,
        &OpDividefloatulong,
        &OpDividefloatlong,
        &OpDividefloatfloat,
        &OpDividefloatdouble,
        &OpDividedoublebyte,
        &OpDividedoublesbyte,
        &OpDividedoubleushort,
        &OpDividedoubleshort,
        &OpDividedoubleuint,
        &OpDividedoubleint,
        &OpDividedoubleulong,
        &OpDividedoublelong,
        &OpDividedoublefloat,
        &OpDividedoubledouble,
    };


    private static VariadicNumber OpAddbytebyte(long left, long right)
        => new((byte)((byte)Unsafe.As<long, byte>(ref left) + (byte)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAddbytesbyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, byte>(ref left) + (sbyte)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAddbyteushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, byte>(ref left) + (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAddbyteshort(long left, long right)
        => new((short)((short)Unsafe.As<long, byte>(ref left) + (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAddbyteuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, byte>(ref left) + (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAddbyteint(long left, long right)
        => new((int)((int)Unsafe.As<long, byte>(ref left) + (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAddbyteulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, byte>(ref left) + (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAddbytelong(long left, long right)
        => new((long)((long)Unsafe.As<long, byte>(ref left) + (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAddbytefloat(long left, long right)
        => new((float)((float)Unsafe.As<long, byte>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAddbytedouble(long left, long right)
        => new((double)((double)Unsafe.As<long, byte>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAddsbytebyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, sbyte>(ref left) + (sbyte)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAddsbytesbyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, sbyte>(ref left) + (sbyte)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAddsbyteushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, sbyte>(ref left) + (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAddsbyteshort(long left, long right)
        => new((short)((short)Unsafe.As<long, sbyte>(ref left) + (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAddsbyteuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, sbyte>(ref left) + (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAddsbyteint(long left, long right)
        => new((int)((int)Unsafe.As<long, sbyte>(ref left) + (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAddsbyteulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, sbyte>(ref left) + (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAddsbytelong(long left, long right)
        => new((long)((long)Unsafe.As<long, sbyte>(ref left) + (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAddsbytefloat(long left, long right)
        => new((float)((float)Unsafe.As<long, sbyte>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAddsbytedouble(long left, long right)
        => new((double)((double)Unsafe.As<long, sbyte>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAddushortbyte(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) + (ushort)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAddushortsbyte(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) + (ushort)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAddushortushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) + (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAddushortshort(long left, long right)
        => new((short)((short)Unsafe.As<long, ushort>(ref left) + (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAddushortuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, ushort>(ref left) + (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAddushortint(long left, long right)
        => new((int)((int)Unsafe.As<long, ushort>(ref left) + (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAddushortulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ushort>(ref left) + (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAddushortlong(long left, long right)
        => new((long)((long)Unsafe.As<long, ushort>(ref left) + (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAddushortfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, ushort>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAddushortdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, ushort>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAddshortbyte(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) + (short)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAddshortsbyte(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) + (short)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAddshortushort(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) + (short)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAddshortshort(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) + (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAddshortuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, short>(ref left) + (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAddshortint(long left, long right)
        => new((int)((int)Unsafe.As<long, short>(ref left) + (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAddshortulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, short>(ref left) + (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAddshortlong(long left, long right)
        => new((long)((long)Unsafe.As<long, short>(ref left) + (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAddshortfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, short>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAddshortdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, short>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAdduintbyte(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) + (uint)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAdduintsbyte(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) + (uint)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAdduintushort(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) + (uint)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAdduintshort(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) + (uint)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAdduintuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) + (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAdduintint(long left, long right)
        => new((int)((int)Unsafe.As<long, uint>(ref left) + (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAdduintulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, uint>(ref left) + (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAdduintlong(long left, long right)
        => new((long)((long)Unsafe.As<long, uint>(ref left) + (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAdduintfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, uint>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAdduintdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, uint>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAddintbyte(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) + (int)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAddintsbyte(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) + (int)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAddintushort(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) + (int)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAddintshort(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) + (int)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAddintuint(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) + (int)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAddintint(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) + (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAddintulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, int>(ref left) + (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAddintlong(long left, long right)
        => new((long)((long)Unsafe.As<long, int>(ref left) + (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAddintfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, int>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAddintdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, int>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAddulongbyte(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) + (ulong)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAddulongsbyte(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) + (ulong)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAddulongushort(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) + (ulong)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAddulongshort(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) + (ulong)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAddulonguint(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) + (ulong)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAddulongint(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) + (ulong)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAddulongulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) + (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAddulonglong(long left, long right)
        => new((long)((long)Unsafe.As<long, ulong>(ref left) + (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAddulongfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, ulong>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAddulongdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, ulong>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAddlongbyte(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) + (long)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAddlongsbyte(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) + (long)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAddlongushort(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) + (long)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAddlongshort(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) + (long)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAddlonguint(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) + (long)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAddlongint(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) + (long)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAddlongulong(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) + (long)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAddlonglong(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) + (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAddlongfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, long>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAddlongdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, long>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAddfloatbyte(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAddfloatsbyte(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAddfloatushort(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAddfloatshort(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAddfloatuint(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAddfloatint(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAddfloatulong(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAddfloatlong(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAddfloatfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) + (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAddfloatdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, float>(ref left) + (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpAdddoublebyte(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpAdddoublesbyte(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpAdddoubleushort(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpAdddoubleshort(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpAdddoubleuint(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpAdddoubleint(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpAdddoubleulong(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpAdddoublelong(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpAdddoublefloat(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpAdddoubledouble(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) + (double)Unsafe.As<long, double>(ref right)));


    private static VariadicNumber OpSubtractbytebyte(long left, long right)
        => new((byte)((byte)Unsafe.As<long, byte>(ref left) - (byte)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractbytesbyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, byte>(ref left) - (sbyte)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractbyteushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, byte>(ref left) - (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractbyteshort(long left, long right)
        => new((short)((short)Unsafe.As<long, byte>(ref left) - (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractbyteuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, byte>(ref left) - (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractbyteint(long left, long right)
        => new((int)((int)Unsafe.As<long, byte>(ref left) - (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractbyteulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, byte>(ref left) - (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractbytelong(long left, long right)
        => new((long)((long)Unsafe.As<long, byte>(ref left) - (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractbytefloat(long left, long right)
        => new((float)((float)Unsafe.As<long, byte>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractbytedouble(long left, long right)
        => new((double)((double)Unsafe.As<long, byte>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractsbytebyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, sbyte>(ref left) - (sbyte)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractsbytesbyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, sbyte>(ref left) - (sbyte)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractsbyteushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, sbyte>(ref left) - (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractsbyteshort(long left, long right)
        => new((short)((short)Unsafe.As<long, sbyte>(ref left) - (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractsbyteuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, sbyte>(ref left) - (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractsbyteint(long left, long right)
        => new((int)((int)Unsafe.As<long, sbyte>(ref left) - (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractsbyteulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, sbyte>(ref left) - (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractsbytelong(long left, long right)
        => new((long)((long)Unsafe.As<long, sbyte>(ref left) - (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractsbytefloat(long left, long right)
        => new((float)((float)Unsafe.As<long, sbyte>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractsbytedouble(long left, long right)
        => new((double)((double)Unsafe.As<long, sbyte>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractushortbyte(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) - (ushort)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractushortsbyte(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) - (ushort)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractushortushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) - (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractushortshort(long left, long right)
        => new((short)((short)Unsafe.As<long, ushort>(ref left) - (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractushortuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, ushort>(ref left) - (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractushortint(long left, long right)
        => new((int)((int)Unsafe.As<long, ushort>(ref left) - (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractushortulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ushort>(ref left) - (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractushortlong(long left, long right)
        => new((long)((long)Unsafe.As<long, ushort>(ref left) - (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractushortfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, ushort>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractushortdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, ushort>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractshortbyte(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) - (short)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractshortsbyte(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) - (short)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractshortushort(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) - (short)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractshortshort(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) - (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractshortuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, short>(ref left) - (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractshortint(long left, long right)
        => new((int)((int)Unsafe.As<long, short>(ref left) - (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractshortulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, short>(ref left) - (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractshortlong(long left, long right)
        => new((long)((long)Unsafe.As<long, short>(ref left) - (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractshortfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, short>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractshortdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, short>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractuintbyte(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) - (uint)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractuintsbyte(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) - (uint)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractuintushort(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) - (uint)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractuintshort(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) - (uint)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractuintuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) - (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractuintint(long left, long right)
        => new((int)((int)Unsafe.As<long, uint>(ref left) - (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractuintulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, uint>(ref left) - (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractuintlong(long left, long right)
        => new((long)((long)Unsafe.As<long, uint>(ref left) - (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractuintfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, uint>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractuintdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, uint>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractintbyte(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) - (int)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractintsbyte(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) - (int)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractintushort(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) - (int)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractintshort(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) - (int)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractintuint(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) - (int)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractintint(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) - (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractintulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, int>(ref left) - (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractintlong(long left, long right)
        => new((long)((long)Unsafe.As<long, int>(ref left) - (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractintfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, int>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractintdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, int>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractulongbyte(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) - (ulong)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractulongsbyte(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) - (ulong)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractulongushort(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) - (ulong)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractulongshort(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) - (ulong)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractulonguint(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) - (ulong)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractulongint(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) - (ulong)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractulongulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) - (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractulonglong(long left, long right)
        => new((long)((long)Unsafe.As<long, ulong>(ref left) - (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractulongfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, ulong>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractulongdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, ulong>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractlongbyte(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) - (long)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractlongsbyte(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) - (long)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractlongushort(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) - (long)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractlongshort(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) - (long)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractlonguint(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) - (long)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractlongint(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) - (long)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractlongulong(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) - (long)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractlonglong(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) - (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractlongfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, long>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractlongdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, long>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractfloatbyte(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractfloatsbyte(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractfloatushort(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractfloatshort(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractfloatuint(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractfloatint(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractfloatulong(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractfloatlong(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractfloatfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) - (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractfloatdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, float>(ref left) - (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpSubtractdoublebyte(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpSubtractdoublesbyte(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpSubtractdoubleushort(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpSubtractdoubleshort(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpSubtractdoubleuint(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpSubtractdoubleint(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpSubtractdoubleulong(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpSubtractdoublelong(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpSubtractdoublefloat(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpSubtractdoubledouble(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) - (double)Unsafe.As<long, double>(ref right)));


    private static VariadicNumber OpMultiplybytebyte(long left, long right)
        => new((byte)((byte)Unsafe.As<long, byte>(ref left) * (byte)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplybytesbyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, byte>(ref left) * (sbyte)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplybyteushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, byte>(ref left) * (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplybyteshort(long left, long right)
        => new((short)((short)Unsafe.As<long, byte>(ref left) * (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplybyteuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, byte>(ref left) * (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplybyteint(long left, long right)
        => new((int)((int)Unsafe.As<long, byte>(ref left) * (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplybyteulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, byte>(ref left) * (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplybytelong(long left, long right)
        => new((long)((long)Unsafe.As<long, byte>(ref left) * (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplybytefloat(long left, long right)
        => new((float)((float)Unsafe.As<long, byte>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplybytedouble(long left, long right)
        => new((double)((double)Unsafe.As<long, byte>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplysbytebyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, sbyte>(ref left) * (sbyte)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplysbytesbyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, sbyte>(ref left) * (sbyte)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplysbyteushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, sbyte>(ref left) * (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplysbyteshort(long left, long right)
        => new((short)((short)Unsafe.As<long, sbyte>(ref left) * (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplysbyteuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, sbyte>(ref left) * (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplysbyteint(long left, long right)
        => new((int)((int)Unsafe.As<long, sbyte>(ref left) * (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplysbyteulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, sbyte>(ref left) * (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplysbytelong(long left, long right)
        => new((long)((long)Unsafe.As<long, sbyte>(ref left) * (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplysbytefloat(long left, long right)
        => new((float)((float)Unsafe.As<long, sbyte>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplysbytedouble(long left, long right)
        => new((double)((double)Unsafe.As<long, sbyte>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplyushortbyte(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) * (ushort)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplyushortsbyte(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) * (ushort)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplyushortushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) * (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplyushortshort(long left, long right)
        => new((short)((short)Unsafe.As<long, ushort>(ref left) * (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplyushortuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, ushort>(ref left) * (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplyushortint(long left, long right)
        => new((int)((int)Unsafe.As<long, ushort>(ref left) * (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplyushortulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ushort>(ref left) * (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplyushortlong(long left, long right)
        => new((long)((long)Unsafe.As<long, ushort>(ref left) * (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplyushortfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, ushort>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplyushortdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, ushort>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplyshortbyte(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) * (short)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplyshortsbyte(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) * (short)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplyshortushort(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) * (short)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplyshortshort(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) * (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplyshortuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, short>(ref left) * (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplyshortint(long left, long right)
        => new((int)((int)Unsafe.As<long, short>(ref left) * (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplyshortulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, short>(ref left) * (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplyshortlong(long left, long right)
        => new((long)((long)Unsafe.As<long, short>(ref left) * (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplyshortfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, short>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplyshortdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, short>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplyuintbyte(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) * (uint)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplyuintsbyte(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) * (uint)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplyuintushort(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) * (uint)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplyuintshort(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) * (uint)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplyuintuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) * (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplyuintint(long left, long right)
        => new((int)((int)Unsafe.As<long, uint>(ref left) * (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplyuintulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, uint>(ref left) * (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplyuintlong(long left, long right)
        => new((long)((long)Unsafe.As<long, uint>(ref left) * (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplyuintfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, uint>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplyuintdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, uint>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplyintbyte(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) * (int)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplyintsbyte(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) * (int)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplyintushort(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) * (int)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplyintshort(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) * (int)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplyintuint(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) * (int)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplyintint(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) * (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplyintulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, int>(ref left) * (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplyintlong(long left, long right)
        => new((long)((long)Unsafe.As<long, int>(ref left) * (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplyintfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, int>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplyintdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, int>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplyulongbyte(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) * (ulong)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplyulongsbyte(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) * (ulong)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplyulongushort(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) * (ulong)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplyulongshort(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) * (ulong)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplyulonguint(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) * (ulong)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplyulongint(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) * (ulong)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplyulongulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) * (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplyulonglong(long left, long right)
        => new((long)((long)Unsafe.As<long, ulong>(ref left) * (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplyulongfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, ulong>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplyulongdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, ulong>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplylongbyte(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) * (long)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplylongsbyte(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) * (long)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplylongushort(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) * (long)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplylongshort(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) * (long)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplylonguint(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) * (long)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplylongint(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) * (long)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplylongulong(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) * (long)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplylonglong(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) * (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplylongfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, long>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplylongdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, long>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplyfloatbyte(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplyfloatsbyte(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplyfloatushort(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplyfloatshort(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplyfloatuint(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplyfloatint(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplyfloatulong(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplyfloatlong(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplyfloatfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) * (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplyfloatdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, float>(ref left) * (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpMultiplydoublebyte(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpMultiplydoublesbyte(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpMultiplydoubleushort(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpMultiplydoubleshort(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpMultiplydoubleuint(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpMultiplydoubleint(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpMultiplydoubleulong(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpMultiplydoublelong(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpMultiplydoublefloat(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpMultiplydoubledouble(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) * (double)Unsafe.As<long, double>(ref right)));


    private static VariadicNumber OpDividebytebyte(long left, long right)
        => new((byte)((byte)Unsafe.As<long, byte>(ref left) / (byte)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDividebytesbyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, byte>(ref left) / (sbyte)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDividebyteushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, byte>(ref left) / (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDividebyteshort(long left, long right)
        => new((short)((short)Unsafe.As<long, byte>(ref left) / (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDividebyteuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, byte>(ref left) / (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDividebyteint(long left, long right)
        => new((int)((int)Unsafe.As<long, byte>(ref left) / (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDividebyteulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, byte>(ref left) / (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDividebytelong(long left, long right)
        => new((long)((long)Unsafe.As<long, byte>(ref left) / (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDividebytefloat(long left, long right)
        => new((float)((float)Unsafe.As<long, byte>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDividebytedouble(long left, long right)
        => new((double)((double)Unsafe.As<long, byte>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDividesbytebyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, sbyte>(ref left) / (sbyte)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDividesbytesbyte(long left, long right)
        => new((sbyte)((sbyte)Unsafe.As<long, sbyte>(ref left) / (sbyte)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDividesbyteushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, sbyte>(ref left) / (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDividesbyteshort(long left, long right)
        => new((short)((short)Unsafe.As<long, sbyte>(ref left) / (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDividesbyteuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, sbyte>(ref left) / (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDividesbyteint(long left, long right)
        => new((int)((int)Unsafe.As<long, sbyte>(ref left) / (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDividesbyteulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, sbyte>(ref left) / (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDividesbytelong(long left, long right)
        => new((long)((long)Unsafe.As<long, sbyte>(ref left) / (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDividesbytefloat(long left, long right)
        => new((float)((float)Unsafe.As<long, sbyte>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDividesbytedouble(long left, long right)
        => new((double)((double)Unsafe.As<long, sbyte>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDivideushortbyte(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) / (ushort)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDivideushortsbyte(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) / (ushort)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDivideushortushort(long left, long right)
        => new((ushort)((ushort)Unsafe.As<long, ushort>(ref left) / (ushort)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDivideushortshort(long left, long right)
        => new((short)((short)Unsafe.As<long, ushort>(ref left) / (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDivideushortuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, ushort>(ref left) / (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDivideushortint(long left, long right)
        => new((int)((int)Unsafe.As<long, ushort>(ref left) / (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDivideushortulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ushort>(ref left) / (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDivideushortlong(long left, long right)
        => new((long)((long)Unsafe.As<long, ushort>(ref left) / (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDivideushortfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, ushort>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDivideushortdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, ushort>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDivideshortbyte(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) / (short)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDivideshortsbyte(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) / (short)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDivideshortushort(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) / (short)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDivideshortshort(long left, long right)
        => new((short)((short)Unsafe.As<long, short>(ref left) / (short)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDivideshortuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, short>(ref left) / (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDivideshortint(long left, long right)
        => new((int)((int)Unsafe.As<long, short>(ref left) / (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDivideshortulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, short>(ref left) / (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDivideshortlong(long left, long right)
        => new((long)((long)Unsafe.As<long, short>(ref left) / (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDivideshortfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, short>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDivideshortdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, short>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDivideuintbyte(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) / (uint)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDivideuintsbyte(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) / (uint)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDivideuintushort(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) / (uint)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDivideuintshort(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) / (uint)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDivideuintuint(long left, long right)
        => new((uint)((uint)Unsafe.As<long, uint>(ref left) / (uint)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDivideuintint(long left, long right)
        => new((int)((int)Unsafe.As<long, uint>(ref left) / (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDivideuintulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, uint>(ref left) / (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDivideuintlong(long left, long right)
        => new((long)((long)Unsafe.As<long, uint>(ref left) / (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDivideuintfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, uint>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDivideuintdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, uint>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDivideintbyte(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) / (int)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDivideintsbyte(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) / (int)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDivideintushort(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) / (int)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDivideintshort(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) / (int)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDivideintuint(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) / (int)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDivideintint(long left, long right)
        => new((int)((int)Unsafe.As<long, int>(ref left) / (int)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDivideintulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, int>(ref left) / (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDivideintlong(long left, long right)
        => new((long)((long)Unsafe.As<long, int>(ref left) / (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDivideintfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, int>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDivideintdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, int>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDivideulongbyte(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) / (ulong)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDivideulongsbyte(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) / (ulong)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDivideulongushort(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) / (ulong)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDivideulongshort(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) / (ulong)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDivideulonguint(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) / (ulong)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDivideulongint(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) / (ulong)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDivideulongulong(long left, long right)
        => new((ulong)((ulong)Unsafe.As<long, ulong>(ref left) / (ulong)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDivideulonglong(long left, long right)
        => new((long)((long)Unsafe.As<long, ulong>(ref left) / (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDivideulongfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, ulong>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDivideulongdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, ulong>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDividelongbyte(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) / (long)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDividelongsbyte(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) / (long)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDividelongushort(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) / (long)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDividelongshort(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) / (long)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDividelonguint(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) / (long)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDividelongint(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) / (long)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDividelongulong(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) / (long)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDividelonglong(long left, long right)
        => new((long)((long)Unsafe.As<long, long>(ref left) / (long)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDividelongfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, long>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDividelongdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, long>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDividefloatbyte(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDividefloatsbyte(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDividefloatushort(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDividefloatshort(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDividefloatuint(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDividefloatint(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDividefloatulong(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDividefloatlong(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDividefloatfloat(long left, long right)
        => new((float)((float)Unsafe.As<long, float>(ref left) / (float)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDividefloatdouble(long left, long right)
        => new((double)((double)Unsafe.As<long, float>(ref left) / (double)Unsafe.As<long, double>(ref right)));
    private static VariadicNumber OpDividedoublebyte(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, byte>(ref right)));
    private static VariadicNumber OpDividedoublesbyte(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, sbyte>(ref right)));
    private static VariadicNumber OpDividedoubleushort(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, ushort>(ref right)));
    private static VariadicNumber OpDividedoubleshort(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, short>(ref right)));
    private static VariadicNumber OpDividedoubleuint(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, uint>(ref right)));
    private static VariadicNumber OpDividedoubleint(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, int>(ref right)));
    private static VariadicNumber OpDividedoubleulong(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, ulong>(ref right)));
    private static VariadicNumber OpDividedoublelong(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, long>(ref right)));
    private static VariadicNumber OpDividedoublefloat(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, float>(ref right)));
    private static VariadicNumber OpDividedoubledouble(long left, long right)
        => new((double)((double)Unsafe.As<long, double>(ref left) / (double)Unsafe.As<long, double>(ref right)));



    public override string ToString()
        => index switch
        {
            0 => byteValue.ToString(),
            1 => sbyteValue.ToString(),
            2 => ushortValue.ToString(),
            3 => shortValue.ToString(),
            4 => uintValue.ToString(),
            5 => intValue.ToString(),
            6 => ulongValue.ToString(),
            7 => longValue.ToString(),
            8 => floatValue.ToString(),
            _ => doubleValue.ToString()
        };

    public string ToString(bool includeType)
        => !includeType ? ToString() :
        index switch
        {
            0 => "byte: " + byteValue.ToString(),
            1 => "sbyte: " + sbyteValue.ToString(),
            2 => "ushort: " + ushortValue.ToString(),
            3 => "short: " + shortValue.ToString(),
            4 => "uint: " + uintValue.ToString(),
            5 => "int: " + intValue.ToString(),
            6 => "ulong: " + ulongValue.ToString(),
            7 => "long: " + longValue.ToString(),
            8 => "float: " + floatValue.ToString(),
            _ => "double: " + doubleValue.ToString()
        };


    public static bool TryParse(string s, out VariadicNumber res)
    {
        res = default;
        if (byte.TryParse(s, out var byteValue))
        {
            res = new(byteValue);
            return true;
        }
        if (sbyte.TryParse(s, out var sbyteValue))
        {
            res = new(sbyteValue);
            return true;
        }
        if (ushort.TryParse(s, out var ushortValue))
        {
            res = new(ushortValue);
            return true;
        }
        if (short.TryParse(s, out var shortValue))
        {
            res = new(shortValue);
            return true;
        }
        if (uint.TryParse(s, out var uintValue))
        {
            res = new(uintValue);
            return true;
        }
        if (int.TryParse(s, out var intValue))
        {
            res = new(intValue);
            return true;
        }
        if (ulong.TryParse(s, out var ulongValue))
        {
            res = new(ulongValue);
            return true;
        }
        if (long.TryParse(s, out var longValue))
        {
            res = new(longValue);
            return true;
        }
        if (float.TryParse(s, out var floatValue))
        {
            res = new(floatValue);
            return true;
        }
        if (double.TryParse(s, out var doubleValue))
        {
            res = new(doubleValue);
            return true;
        }
        return false;
    }

    public static VariadicNumber Parse(string s)
        => TryParse(s, out var res) ? res : throw new();
}

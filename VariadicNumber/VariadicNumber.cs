using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


[StructLayout(LayoutKind.Explicit)]
public struct VariadicNumber
{
    [FieldOffset(0)]
    private int index;

    [FieldOffset(4)]
    private byte byteValue;
    [FieldOffset(4)]
    private sbyte sbyteValue;
    [FieldOffset(4)]
    private ushort ushortValue;
    [FieldOffset(4)]
    private short shortValue;
    [FieldOffset(4)]
    private uint uintValue;
    [FieldOffset(4)]
    private int intValue;
    [FieldOffset(4)]
    private ulong ulongValue;
    [FieldOffset(4)]
    private long longValue;
    [FieldOffset(4)]
    private float floatValue;
    [FieldOffset(4)]
    private double doubleValue;

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
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


    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
    public static VariadicNumber operator +(VariadicNumber a, VariadicNumber b)
        => (a.index * 10 + b.index) switch
        {
            0 => new((byte)a.byteValue + (byte)b.byteValue),
            1 => new((sbyte)a.byteValue + (sbyte)b.sbyteValue),
            2 => new((ushort)a.byteValue + (ushort)b.ushortValue),
            3 => new((short)a.byteValue + (short)b.shortValue),
            4 => new((uint)a.byteValue + (uint)b.uintValue),
            5 => new((int)a.byteValue + (int)b.intValue),
            6 => new((ulong)a.byteValue + (ulong)b.ulongValue),
            7 => new((long)a.byteValue + (long)b.longValue),
            8 => new((float)a.byteValue + (float)b.floatValue),
            9 => new((double)a.byteValue + (double)b.doubleValue),
            10 => new((sbyte)a.sbyteValue + (sbyte)b.byteValue),
            11 => new((sbyte)a.sbyteValue + (sbyte)b.sbyteValue),
            12 => new((ushort)a.sbyteValue + (ushort)b.ushortValue),
            13 => new((short)a.sbyteValue + (short)b.shortValue),
            14 => new((uint)a.sbyteValue + (uint)b.uintValue),
            15 => new((int)a.sbyteValue + (int)b.intValue),
            16 => new((ulong)a.sbyteValue + (ulong)b.ulongValue),
            17 => new((long)a.sbyteValue + (long)b.longValue),
            18 => new((float)a.sbyteValue + (float)b.floatValue),
            19 => new((double)a.sbyteValue + (double)b.doubleValue),
            20 => new((ushort)a.ushortValue + (ushort)b.byteValue),
            21 => new((ushort)a.ushortValue + (ushort)b.sbyteValue),
            22 => new((ushort)a.ushortValue + (ushort)b.ushortValue),
            23 => new((short)a.ushortValue + (short)b.shortValue),
            24 => new((uint)a.ushortValue + (uint)b.uintValue),
            25 => new((int)a.ushortValue + (int)b.intValue),
            26 => new((ulong)a.ushortValue + (ulong)b.ulongValue),
            27 => new((long)a.ushortValue + (long)b.longValue),
            28 => new((float)a.ushortValue + (float)b.floatValue),
            29 => new((double)a.ushortValue + (double)b.doubleValue),
            30 => new((short)a.shortValue + (short)b.byteValue),
            31 => new((short)a.shortValue + (short)b.sbyteValue),
            32 => new((short)a.shortValue + (short)b.ushortValue),
            33 => new((short)a.shortValue + (short)b.shortValue),
            34 => new((uint)a.shortValue + (uint)b.uintValue),
            35 => new((int)a.shortValue + (int)b.intValue),
            36 => new((ulong)a.shortValue + (ulong)b.ulongValue),
            37 => new((long)a.shortValue + (long)b.longValue),
            38 => new((float)a.shortValue + (float)b.floatValue),
            39 => new((double)a.shortValue + (double)b.doubleValue),
            40 => new((uint)a.uintValue + (uint)b.byteValue),
            41 => new((uint)a.uintValue + (uint)b.sbyteValue),
            42 => new((uint)a.uintValue + (uint)b.ushortValue),
            43 => new((uint)a.uintValue + (uint)b.shortValue),
            44 => new((uint)a.uintValue + (uint)b.uintValue),
            45 => new((int)a.uintValue + (int)b.intValue),
            46 => new((ulong)a.uintValue + (ulong)b.ulongValue),
            47 => new((long)a.uintValue + (long)b.longValue),
            48 => new((float)a.uintValue + (float)b.floatValue),
            49 => new((double)a.uintValue + (double)b.doubleValue),
            50 => new((int)a.intValue + (int)b.byteValue),
            51 => new((int)a.intValue + (int)b.sbyteValue),
            52 => new((int)a.intValue + (int)b.ushortValue),
            53 => new((int)a.intValue + (int)b.shortValue),
            54 => new((int)a.intValue + (int)b.uintValue),
            55 => new((int)a.intValue + (int)b.intValue),
            56 => new((ulong)a.intValue + (ulong)b.ulongValue),
            57 => new((long)a.intValue + (long)b.longValue),
            58 => new((float)a.intValue + (float)b.floatValue),
            59 => new((double)a.intValue + (double)b.doubleValue),
            60 => new((ulong)a.ulongValue + (ulong)b.byteValue),
            61 => new((ulong)a.ulongValue + (ulong)b.sbyteValue),
            62 => new((ulong)a.ulongValue + (ulong)b.ushortValue),
            63 => new((ulong)a.ulongValue + (ulong)b.shortValue),
            64 => new((ulong)a.ulongValue + (ulong)b.uintValue),
            65 => new((ulong)a.ulongValue + (ulong)b.intValue),
            66 => new((ulong)a.ulongValue + (ulong)b.ulongValue),
            67 => new((long)a.ulongValue + (long)b.longValue),
            68 => new((float)a.ulongValue + (float)b.floatValue),
            69 => new((double)a.ulongValue + (double)b.doubleValue),
            70 => new((long)a.longValue + (long)b.byteValue),
            71 => new((long)a.longValue + (long)b.sbyteValue),
            72 => new((long)a.longValue + (long)b.ushortValue),
            73 => new((long)a.longValue + (long)b.shortValue),
            74 => new((long)a.longValue + (long)b.uintValue),
            75 => new((long)a.longValue + (long)b.intValue),
            76 => new((long)a.longValue + (long)b.ulongValue),
            77 => new((long)a.longValue + (long)b.longValue),
            78 => new((float)a.longValue + (float)b.floatValue),
            79 => new((double)a.longValue + (double)b.doubleValue),
            80 => new((float)a.floatValue + (float)b.byteValue),
            81 => new((float)a.floatValue + (float)b.sbyteValue),
            82 => new((float)a.floatValue + (float)b.ushortValue),
            83 => new((float)a.floatValue + (float)b.shortValue),
            84 => new((float)a.floatValue + (float)b.uintValue),
            85 => new((float)a.floatValue + (float)b.intValue),
            86 => new((float)a.floatValue + (float)b.ulongValue),
            87 => new((float)a.floatValue + (float)b.longValue),
            88 => new((float)a.floatValue + (float)b.floatValue),
            89 => new((double)a.floatValue + (double)b.doubleValue),
            90 => new((double)a.doubleValue + (double)b.byteValue),
            91 => new((double)a.doubleValue + (double)b.sbyteValue),
            92 => new((double)a.doubleValue + (double)b.ushortValue),
            93 => new((double)a.doubleValue + (double)b.shortValue),
            94 => new((double)a.doubleValue + (double)b.uintValue),
            95 => new((double)a.doubleValue + (double)b.intValue),
            96 => new((double)a.doubleValue + (double)b.ulongValue),
            97 => new((double)a.doubleValue + (double)b.longValue),
            98 => new((double)a.doubleValue + (double)b.floatValue),
            _ => new((double)a.doubleValue + (double)b.doubleValue)
        };
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
    public static VariadicNumber operator -(VariadicNumber a, VariadicNumber b)
        => (a.index * 10 + b.index) switch
        {
            0 => new((byte)a.byteValue - (byte)b.byteValue),
            1 => new((sbyte)a.byteValue - (sbyte)b.sbyteValue),
            2 => new((ushort)a.byteValue - (ushort)b.ushortValue),
            3 => new((short)a.byteValue - (short)b.shortValue),
            4 => new((uint)a.byteValue - (uint)b.uintValue),
            5 => new((int)a.byteValue - (int)b.intValue),
            6 => new((ulong)a.byteValue - (ulong)b.ulongValue),
            7 => new((long)a.byteValue - (long)b.longValue),
            8 => new((float)a.byteValue - (float)b.floatValue),
            9 => new((double)a.byteValue - (double)b.doubleValue),
            10 => new((sbyte)a.sbyteValue - (sbyte)b.byteValue),
            11 => new((sbyte)a.sbyteValue - (sbyte)b.sbyteValue),
            12 => new((ushort)a.sbyteValue - (ushort)b.ushortValue),
            13 => new((short)a.sbyteValue - (short)b.shortValue),
            14 => new((uint)a.sbyteValue - (uint)b.uintValue),
            15 => new((int)a.sbyteValue - (int)b.intValue),
            16 => new((ulong)a.sbyteValue - (ulong)b.ulongValue),
            17 => new((long)a.sbyteValue - (long)b.longValue),
            18 => new((float)a.sbyteValue - (float)b.floatValue),
            19 => new((double)a.sbyteValue - (double)b.doubleValue),
            20 => new((ushort)a.ushortValue - (ushort)b.byteValue),
            21 => new((ushort)a.ushortValue - (ushort)b.sbyteValue),
            22 => new((ushort)a.ushortValue - (ushort)b.ushortValue),
            23 => new((short)a.ushortValue - (short)b.shortValue),
            24 => new((uint)a.ushortValue - (uint)b.uintValue),
            25 => new((int)a.ushortValue - (int)b.intValue),
            26 => new((ulong)a.ushortValue - (ulong)b.ulongValue),
            27 => new((long)a.ushortValue - (long)b.longValue),
            28 => new((float)a.ushortValue - (float)b.floatValue),
            29 => new((double)a.ushortValue - (double)b.doubleValue),
            30 => new((short)a.shortValue - (short)b.byteValue),
            31 => new((short)a.shortValue - (short)b.sbyteValue),
            32 => new((short)a.shortValue - (short)b.ushortValue),
            33 => new((short)a.shortValue - (short)b.shortValue),
            34 => new((uint)a.shortValue - (uint)b.uintValue),
            35 => new((int)a.shortValue - (int)b.intValue),
            36 => new((ulong)a.shortValue - (ulong)b.ulongValue),
            37 => new((long)a.shortValue - (long)b.longValue),
            38 => new((float)a.shortValue - (float)b.floatValue),
            39 => new((double)a.shortValue - (double)b.doubleValue),
            40 => new((uint)a.uintValue - (uint)b.byteValue),
            41 => new((uint)a.uintValue - (uint)b.sbyteValue),
            42 => new((uint)a.uintValue - (uint)b.ushortValue),
            43 => new((uint)a.uintValue - (uint)b.shortValue),
            44 => new((uint)a.uintValue - (uint)b.uintValue),
            45 => new((int)a.uintValue - (int)b.intValue),
            46 => new((ulong)a.uintValue - (ulong)b.ulongValue),
            47 => new((long)a.uintValue - (long)b.longValue),
            48 => new((float)a.uintValue - (float)b.floatValue),
            49 => new((double)a.uintValue - (double)b.doubleValue),
            50 => new((int)a.intValue - (int)b.byteValue),
            51 => new((int)a.intValue - (int)b.sbyteValue),
            52 => new((int)a.intValue - (int)b.ushortValue),
            53 => new((int)a.intValue - (int)b.shortValue),
            54 => new((int)a.intValue - (int)b.uintValue),
            55 => new((int)a.intValue - (int)b.intValue),
            56 => new((ulong)a.intValue - (ulong)b.ulongValue),
            57 => new((long)a.intValue - (long)b.longValue),
            58 => new((float)a.intValue - (float)b.floatValue),
            59 => new((double)a.intValue - (double)b.doubleValue),
            60 => new((ulong)a.ulongValue - (ulong)b.byteValue),
            61 => new((ulong)a.ulongValue - (ulong)b.sbyteValue),
            62 => new((ulong)a.ulongValue - (ulong)b.ushortValue),
            63 => new((ulong)a.ulongValue - (ulong)b.shortValue),
            64 => new((ulong)a.ulongValue - (ulong)b.uintValue),
            65 => new((ulong)a.ulongValue - (ulong)b.intValue),
            66 => new((ulong)a.ulongValue - (ulong)b.ulongValue),
            67 => new((long)a.ulongValue - (long)b.longValue),
            68 => new((float)a.ulongValue - (float)b.floatValue),
            69 => new((double)a.ulongValue - (double)b.doubleValue),
            70 => new((long)a.longValue - (long)b.byteValue),
            71 => new((long)a.longValue - (long)b.sbyteValue),
            72 => new((long)a.longValue - (long)b.ushortValue),
            73 => new((long)a.longValue - (long)b.shortValue),
            74 => new((long)a.longValue - (long)b.uintValue),
            75 => new((long)a.longValue - (long)b.intValue),
            76 => new((long)a.longValue - (long)b.ulongValue),
            77 => new((long)a.longValue - (long)b.longValue),
            78 => new((float)a.longValue - (float)b.floatValue),
            79 => new((double)a.longValue - (double)b.doubleValue),
            80 => new((float)a.floatValue - (float)b.byteValue),
            81 => new((float)a.floatValue - (float)b.sbyteValue),
            82 => new((float)a.floatValue - (float)b.ushortValue),
            83 => new((float)a.floatValue - (float)b.shortValue),
            84 => new((float)a.floatValue - (float)b.uintValue),
            85 => new((float)a.floatValue - (float)b.intValue),
            86 => new((float)a.floatValue - (float)b.ulongValue),
            87 => new((float)a.floatValue - (float)b.longValue),
            88 => new((float)a.floatValue - (float)b.floatValue),
            89 => new((double)a.floatValue - (double)b.doubleValue),
            90 => new((double)a.doubleValue - (double)b.byteValue),
            91 => new((double)a.doubleValue - (double)b.sbyteValue),
            92 => new((double)a.doubleValue - (double)b.ushortValue),
            93 => new((double)a.doubleValue - (double)b.shortValue),
            94 => new((double)a.doubleValue - (double)b.uintValue),
            95 => new((double)a.doubleValue - (double)b.intValue),
            96 => new((double)a.doubleValue - (double)b.ulongValue),
            97 => new((double)a.doubleValue - (double)b.longValue),
            98 => new((double)a.doubleValue - (double)b.floatValue),
            _ => new((double)a.doubleValue - (double)b.doubleValue)
        };
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
    public static VariadicNumber operator *(VariadicNumber a, VariadicNumber b)
        => (a.index * 10 + b.index) switch
        {
            0 => new((byte)a.byteValue * (byte)b.byteValue),
            1 => new((sbyte)a.byteValue * (sbyte)b.sbyteValue),
            2 => new((ushort)a.byteValue * (ushort)b.ushortValue),
            3 => new((short)a.byteValue * (short)b.shortValue),
            4 => new((uint)a.byteValue * (uint)b.uintValue),
            5 => new((int)a.byteValue * (int)b.intValue),
            6 => new((ulong)a.byteValue * (ulong)b.ulongValue),
            7 => new((long)a.byteValue * (long)b.longValue),
            8 => new((float)a.byteValue * (float)b.floatValue),
            9 => new((double)a.byteValue * (double)b.doubleValue),
            10 => new((sbyte)a.sbyteValue * (sbyte)b.byteValue),
            11 => new((sbyte)a.sbyteValue * (sbyte)b.sbyteValue),
            12 => new((ushort)a.sbyteValue * (ushort)b.ushortValue),
            13 => new((short)a.sbyteValue * (short)b.shortValue),
            14 => new((uint)a.sbyteValue * (uint)b.uintValue),
            15 => new((int)a.sbyteValue * (int)b.intValue),
            16 => new((ulong)a.sbyteValue * (ulong)b.ulongValue),
            17 => new((long)a.sbyteValue * (long)b.longValue),
            18 => new((float)a.sbyteValue * (float)b.floatValue),
            19 => new((double)a.sbyteValue * (double)b.doubleValue),
            20 => new((ushort)a.ushortValue * (ushort)b.byteValue),
            21 => new((ushort)a.ushortValue * (ushort)b.sbyteValue),
            22 => new((ushort)a.ushortValue * (ushort)b.ushortValue),
            23 => new((short)a.ushortValue * (short)b.shortValue),
            24 => new((uint)a.ushortValue * (uint)b.uintValue),
            25 => new((int)a.ushortValue * (int)b.intValue),
            26 => new((ulong)a.ushortValue * (ulong)b.ulongValue),
            27 => new((long)a.ushortValue * (long)b.longValue),
            28 => new((float)a.ushortValue * (float)b.floatValue),
            29 => new((double)a.ushortValue * (double)b.doubleValue),
            30 => new((short)a.shortValue * (short)b.byteValue),
            31 => new((short)a.shortValue * (short)b.sbyteValue),
            32 => new((short)a.shortValue * (short)b.ushortValue),
            33 => new((short)a.shortValue * (short)b.shortValue),
            34 => new((uint)a.shortValue * (uint)b.uintValue),
            35 => new((int)a.shortValue * (int)b.intValue),
            36 => new((ulong)a.shortValue * (ulong)b.ulongValue),
            37 => new((long)a.shortValue * (long)b.longValue),
            38 => new((float)a.shortValue * (float)b.floatValue),
            39 => new((double)a.shortValue * (double)b.doubleValue),
            40 => new((uint)a.uintValue * (uint)b.byteValue),
            41 => new((uint)a.uintValue * (uint)b.sbyteValue),
            42 => new((uint)a.uintValue * (uint)b.ushortValue),
            43 => new((uint)a.uintValue * (uint)b.shortValue),
            44 => new((uint)a.uintValue * (uint)b.uintValue),
            45 => new((int)a.uintValue * (int)b.intValue),
            46 => new((ulong)a.uintValue * (ulong)b.ulongValue),
            47 => new((long)a.uintValue * (long)b.longValue),
            48 => new((float)a.uintValue * (float)b.floatValue),
            49 => new((double)a.uintValue * (double)b.doubleValue),
            50 => new((int)a.intValue * (int)b.byteValue),
            51 => new((int)a.intValue * (int)b.sbyteValue),
            52 => new((int)a.intValue * (int)b.ushortValue),
            53 => new((int)a.intValue * (int)b.shortValue),
            54 => new((int)a.intValue * (int)b.uintValue),
            55 => new((int)a.intValue * (int)b.intValue),
            56 => new((ulong)a.intValue * (ulong)b.ulongValue),
            57 => new((long)a.intValue * (long)b.longValue),
            58 => new((float)a.intValue * (float)b.floatValue),
            59 => new((double)a.intValue * (double)b.doubleValue),
            60 => new((ulong)a.ulongValue * (ulong)b.byteValue),
            61 => new((ulong)a.ulongValue * (ulong)b.sbyteValue),
            62 => new((ulong)a.ulongValue * (ulong)b.ushortValue),
            63 => new((ulong)a.ulongValue * (ulong)b.shortValue),
            64 => new((ulong)a.ulongValue * (ulong)b.uintValue),
            65 => new((ulong)a.ulongValue * (ulong)b.intValue),
            66 => new((ulong)a.ulongValue * (ulong)b.ulongValue),
            67 => new((long)a.ulongValue * (long)b.longValue),
            68 => new((float)a.ulongValue * (float)b.floatValue),
            69 => new((double)a.ulongValue * (double)b.doubleValue),
            70 => new((long)a.longValue * (long)b.byteValue),
            71 => new((long)a.longValue * (long)b.sbyteValue),
            72 => new((long)a.longValue * (long)b.ushortValue),
            73 => new((long)a.longValue * (long)b.shortValue),
            74 => new((long)a.longValue * (long)b.uintValue),
            75 => new((long)a.longValue * (long)b.intValue),
            76 => new((long)a.longValue * (long)b.ulongValue),
            77 => new((long)a.longValue * (long)b.longValue),
            78 => new((float)a.longValue * (float)b.floatValue),
            79 => new((double)a.longValue * (double)b.doubleValue),
            80 => new((float)a.floatValue * (float)b.byteValue),
            81 => new((float)a.floatValue * (float)b.sbyteValue),
            82 => new((float)a.floatValue * (float)b.ushortValue),
            83 => new((float)a.floatValue * (float)b.shortValue),
            84 => new((float)a.floatValue * (float)b.uintValue),
            85 => new((float)a.floatValue * (float)b.intValue),
            86 => new((float)a.floatValue * (float)b.ulongValue),
            87 => new((float)a.floatValue * (float)b.longValue),
            88 => new((float)a.floatValue * (float)b.floatValue),
            89 => new((double)a.floatValue * (double)b.doubleValue),
            90 => new((double)a.doubleValue * (double)b.byteValue),
            91 => new((double)a.doubleValue * (double)b.sbyteValue),
            92 => new((double)a.doubleValue * (double)b.ushortValue),
            93 => new((double)a.doubleValue * (double)b.shortValue),
            94 => new((double)a.doubleValue * (double)b.uintValue),
            95 => new((double)a.doubleValue * (double)b.intValue),
            96 => new((double)a.doubleValue * (double)b.ulongValue),
            97 => new((double)a.doubleValue * (double)b.longValue),
            98 => new((double)a.doubleValue * (double)b.floatValue),
            _ => new((double)a.doubleValue * (double)b.doubleValue)
        };
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]
    public static VariadicNumber operator /(VariadicNumber a, VariadicNumber b)
        => (a.index * 10 + b.index) switch
        {
            0 => new((byte)a.byteValue / (byte)b.byteValue),
            1 => new((sbyte)a.byteValue / (sbyte)b.sbyteValue),
            2 => new((ushort)a.byteValue / (ushort)b.ushortValue),
            3 => new((short)a.byteValue / (short)b.shortValue),
            4 => new((uint)a.byteValue / (uint)b.uintValue),
            5 => new((int)a.byteValue / (int)b.intValue),
            6 => new((ulong)a.byteValue / (ulong)b.ulongValue),
            7 => new((long)a.byteValue / (long)b.longValue),
            8 => new((float)a.byteValue / (float)b.floatValue),
            9 => new((double)a.byteValue / (double)b.doubleValue),
            10 => new((sbyte)a.sbyteValue / (sbyte)b.byteValue),
            11 => new((sbyte)a.sbyteValue / (sbyte)b.sbyteValue),
            12 => new((ushort)a.sbyteValue / (ushort)b.ushortValue),
            13 => new((short)a.sbyteValue / (short)b.shortValue),
            14 => new((uint)a.sbyteValue / (uint)b.uintValue),
            15 => new((int)a.sbyteValue / (int)b.intValue),
            16 => new((ulong)a.sbyteValue / (ulong)b.ulongValue),
            17 => new((long)a.sbyteValue / (long)b.longValue),
            18 => new((float)a.sbyteValue / (float)b.floatValue),
            19 => new((double)a.sbyteValue / (double)b.doubleValue),
            20 => new((ushort)a.ushortValue / (ushort)b.byteValue),
            21 => new((ushort)a.ushortValue / (ushort)b.sbyteValue),
            22 => new((ushort)a.ushortValue / (ushort)b.ushortValue),
            23 => new((short)a.ushortValue / (short)b.shortValue),
            24 => new((uint)a.ushortValue / (uint)b.uintValue),
            25 => new((int)a.ushortValue / (int)b.intValue),
            26 => new((ulong)a.ushortValue / (ulong)b.ulongValue),
            27 => new((long)a.ushortValue / (long)b.longValue),
            28 => new((float)a.ushortValue / (float)b.floatValue),
            29 => new((double)a.ushortValue / (double)b.doubleValue),
            30 => new((short)a.shortValue / (short)b.byteValue),
            31 => new((short)a.shortValue / (short)b.sbyteValue),
            32 => new((short)a.shortValue / (short)b.ushortValue),
            33 => new((short)a.shortValue / (short)b.shortValue),
            34 => new((uint)a.shortValue / (uint)b.uintValue),
            35 => new((int)a.shortValue / (int)b.intValue),
            36 => new((ulong)a.shortValue / (ulong)b.ulongValue),
            37 => new((long)a.shortValue / (long)b.longValue),
            38 => new((float)a.shortValue / (float)b.floatValue),
            39 => new((double)a.shortValue / (double)b.doubleValue),
            40 => new((uint)a.uintValue / (uint)b.byteValue),
            41 => new((uint)a.uintValue / (uint)b.sbyteValue),
            42 => new((uint)a.uintValue / (uint)b.ushortValue),
            43 => new((uint)a.uintValue / (uint)b.shortValue),
            44 => new((uint)a.uintValue / (uint)b.uintValue),
            45 => new((int)a.uintValue / (int)b.intValue),
            46 => new((ulong)a.uintValue / (ulong)b.ulongValue),
            47 => new((long)a.uintValue / (long)b.longValue),
            48 => new((float)a.uintValue / (float)b.floatValue),
            49 => new((double)a.uintValue / (double)b.doubleValue),
            50 => new((int)a.intValue / (int)b.byteValue),
            51 => new((int)a.intValue / (int)b.sbyteValue),
            52 => new((int)a.intValue / (int)b.ushortValue),
            53 => new((int)a.intValue / (int)b.shortValue),
            54 => new((int)a.intValue / (int)b.uintValue),
            55 => new((int)a.intValue / (int)b.intValue),
            56 => new((ulong)a.intValue / (ulong)b.ulongValue),
            57 => new((long)a.intValue / (long)b.longValue),
            58 => new((float)a.intValue / (float)b.floatValue),
            59 => new((double)a.intValue / (double)b.doubleValue),
            60 => new((ulong)a.ulongValue / (ulong)b.byteValue),
            61 => new((ulong)a.ulongValue / (ulong)b.sbyteValue),
            62 => new((ulong)a.ulongValue / (ulong)b.ushortValue),
            63 => new((ulong)a.ulongValue / (ulong)b.shortValue),
            64 => new((ulong)a.ulongValue / (ulong)b.uintValue),
            65 => new((ulong)a.ulongValue / (ulong)b.intValue),
            66 => new((ulong)a.ulongValue / (ulong)b.ulongValue),
            67 => new((long)a.ulongValue / (long)b.longValue),
            68 => new((float)a.ulongValue / (float)b.floatValue),
            69 => new((double)a.ulongValue / (double)b.doubleValue),
            70 => new((long)a.longValue / (long)b.byteValue),
            71 => new((long)a.longValue / (long)b.sbyteValue),
            72 => new((long)a.longValue / (long)b.ushortValue),
            73 => new((long)a.longValue / (long)b.shortValue),
            74 => new((long)a.longValue / (long)b.uintValue),
            75 => new((long)a.longValue / (long)b.intValue),
            76 => new((long)a.longValue / (long)b.ulongValue),
            77 => new((long)a.longValue / (long)b.longValue),
            78 => new((float)a.longValue / (float)b.floatValue),
            79 => new((double)a.longValue / (double)b.doubleValue),
            80 => new((float)a.floatValue / (float)b.byteValue),
            81 => new((float)a.floatValue / (float)b.sbyteValue),
            82 => new((float)a.floatValue / (float)b.ushortValue),
            83 => new((float)a.floatValue / (float)b.shortValue),
            84 => new((float)a.floatValue / (float)b.uintValue),
            85 => new((float)a.floatValue / (float)b.intValue),
            86 => new((float)a.floatValue / (float)b.ulongValue),
            87 => new((float)a.floatValue / (float)b.longValue),
            88 => new((float)a.floatValue / (float)b.floatValue),
            89 => new((double)a.floatValue / (double)b.doubleValue),
            90 => new((double)a.doubleValue / (double)b.byteValue),
            91 => new((double)a.doubleValue / (double)b.sbyteValue),
            92 => new((double)a.doubleValue / (double)b.ushortValue),
            93 => new((double)a.doubleValue / (double)b.shortValue),
            94 => new((double)a.doubleValue / (double)b.uintValue),
            95 => new((double)a.doubleValue / (double)b.intValue),
            96 => new((double)a.doubleValue / (double)b.ulongValue),
            97 => new((double)a.doubleValue / (double)b.longValue),
            98 => new((double)a.doubleValue / (double)b.floatValue),
            _ => new((double)a.doubleValue / (double)b.doubleValue)
        };


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

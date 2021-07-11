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


    public static VariadicNumber operator +(VariadicNumber a, VariadicNumber b)
        => (a.index, b.index) switch
        {
            (0, 0) => new((byte)a.byteValue + (byte)b.byteValue),
            (0, 1) => new((sbyte)a.byteValue + (sbyte)b.sbyteValue),
            (0, 2) => new((ushort)a.byteValue + (ushort)b.ushortValue),
            (0, 3) => new((short)a.byteValue + (short)b.shortValue),
            (0, 4) => new((uint)a.byteValue + (uint)b.uintValue),
            (0, 5) => new((int)a.byteValue + (int)b.intValue),
            (0, 6) => new((ulong)a.byteValue + (ulong)b.ulongValue),
            (0, 7) => new((long)a.byteValue + (long)b.longValue),
            (0, 8) => new((float)a.byteValue + (float)b.floatValue),
            (0, 9) => new((double)a.byteValue + (double)b.doubleValue),
            (1, 0) => new((sbyte)a.sbyteValue + (sbyte)b.byteValue),
            (1, 1) => new((sbyte)a.sbyteValue + (sbyte)b.sbyteValue),
            (1, 2) => new((ushort)a.sbyteValue + (ushort)b.ushortValue),
            (1, 3) => new((short)a.sbyteValue + (short)b.shortValue),
            (1, 4) => new((uint)a.sbyteValue + (uint)b.uintValue),
            (1, 5) => new((int)a.sbyteValue + (int)b.intValue),
            (1, 6) => new((ulong)a.sbyteValue + (ulong)b.ulongValue),
            (1, 7) => new((long)a.sbyteValue + (long)b.longValue),
            (1, 8) => new((float)a.sbyteValue + (float)b.floatValue),
            (1, 9) => new((double)a.sbyteValue + (double)b.doubleValue),
            (2, 0) => new((ushort)a.ushortValue + (ushort)b.byteValue),
            (2, 1) => new((ushort)a.ushortValue + (ushort)b.sbyteValue),
            (2, 2) => new((ushort)a.ushortValue + (ushort)b.ushortValue),
            (2, 3) => new((short)a.ushortValue + (short)b.shortValue),
            (2, 4) => new((uint)a.ushortValue + (uint)b.uintValue),
            (2, 5) => new((int)a.ushortValue + (int)b.intValue),
            (2, 6) => new((ulong)a.ushortValue + (ulong)b.ulongValue),
            (2, 7) => new((long)a.ushortValue + (long)b.longValue),
            (2, 8) => new((float)a.ushortValue + (float)b.floatValue),
            (2, 9) => new((double)a.ushortValue + (double)b.doubleValue),
            (3, 0) => new((short)a.shortValue + (short)b.byteValue),
            (3, 1) => new((short)a.shortValue + (short)b.sbyteValue),
            (3, 2) => new((short)a.shortValue + (short)b.ushortValue),
            (3, 3) => new((short)a.shortValue + (short)b.shortValue),
            (3, 4) => new((uint)a.shortValue + (uint)b.uintValue),
            (3, 5) => new((int)a.shortValue + (int)b.intValue),
            (3, 6) => new((ulong)a.shortValue + (ulong)b.ulongValue),
            (3, 7) => new((long)a.shortValue + (long)b.longValue),
            (3, 8) => new((float)a.shortValue + (float)b.floatValue),
            (3, 9) => new((double)a.shortValue + (double)b.doubleValue),
            (4, 0) => new((uint)a.uintValue + (uint)b.byteValue),
            (4, 1) => new((uint)a.uintValue + (uint)b.sbyteValue),
            (4, 2) => new((uint)a.uintValue + (uint)b.ushortValue),
            (4, 3) => new((uint)a.uintValue + (uint)b.shortValue),
            (4, 4) => new((uint)a.uintValue + (uint)b.uintValue),
            (4, 5) => new((int)a.uintValue + (int)b.intValue),
            (4, 6) => new((ulong)a.uintValue + (ulong)b.ulongValue),
            (4, 7) => new((long)a.uintValue + (long)b.longValue),
            (4, 8) => new((float)a.uintValue + (float)b.floatValue),
            (4, 9) => new((double)a.uintValue + (double)b.doubleValue),
            (5, 0) => new((int)a.intValue + (int)b.byteValue),
            (5, 1) => new((int)a.intValue + (int)b.sbyteValue),
            (5, 2) => new((int)a.intValue + (int)b.ushortValue),
            (5, 3) => new((int)a.intValue + (int)b.shortValue),
            (5, 4) => new((int)a.intValue + (int)b.uintValue),
            (5, 5) => new((int)a.intValue + (int)b.intValue),
            (5, 6) => new((ulong)a.intValue + (ulong)b.ulongValue),
            (5, 7) => new((long)a.intValue + (long)b.longValue),
            (5, 8) => new((float)a.intValue + (float)b.floatValue),
            (5, 9) => new((double)a.intValue + (double)b.doubleValue),
            (6, 0) => new((ulong)a.ulongValue + (ulong)b.byteValue),
            (6, 1) => new((ulong)a.ulongValue + (ulong)b.sbyteValue),
            (6, 2) => new((ulong)a.ulongValue + (ulong)b.ushortValue),
            (6, 3) => new((ulong)a.ulongValue + (ulong)b.shortValue),
            (6, 4) => new((ulong)a.ulongValue + (ulong)b.uintValue),
            (6, 5) => new((ulong)a.ulongValue + (ulong)b.intValue),
            (6, 6) => new((ulong)a.ulongValue + (ulong)b.ulongValue),
            (6, 7) => new((long)a.ulongValue + (long)b.longValue),
            (6, 8) => new((float)a.ulongValue + (float)b.floatValue),
            (6, 9) => new((double)a.ulongValue + (double)b.doubleValue),
            (7, 0) => new((long)a.longValue + (long)b.byteValue),
            (7, 1) => new((long)a.longValue + (long)b.sbyteValue),
            (7, 2) => new((long)a.longValue + (long)b.ushortValue),
            (7, 3) => new((long)a.longValue + (long)b.shortValue),
            (7, 4) => new((long)a.longValue + (long)b.uintValue),
            (7, 5) => new((long)a.longValue + (long)b.intValue),
            (7, 6) => new((long)a.longValue + (long)b.ulongValue),
            (7, 7) => new((long)a.longValue + (long)b.longValue),
            (7, 8) => new((float)a.longValue + (float)b.floatValue),
            (7, 9) => new((double)a.longValue + (double)b.doubleValue),
            (8, 0) => new((float)a.floatValue + (float)b.byteValue),
            (8, 1) => new((float)a.floatValue + (float)b.sbyteValue),
            (8, 2) => new((float)a.floatValue + (float)b.ushortValue),
            (8, 3) => new((float)a.floatValue + (float)b.shortValue),
            (8, 4) => new((float)a.floatValue + (float)b.uintValue),
            (8, 5) => new((float)a.floatValue + (float)b.intValue),
            (8, 6) => new((float)a.floatValue + (float)b.ulongValue),
            (8, 7) => new((float)a.floatValue + (float)b.longValue),
            (8, 8) => new((float)a.floatValue + (float)b.floatValue),
            (8, 9) => new((double)a.floatValue + (double)b.doubleValue),
            (9, 0) => new((double)a.doubleValue + (double)b.byteValue),
            (9, 1) => new((double)a.doubleValue + (double)b.sbyteValue),
            (9, 2) => new((double)a.doubleValue + (double)b.ushortValue),
            (9, 3) => new((double)a.doubleValue + (double)b.shortValue),
            (9, 4) => new((double)a.doubleValue + (double)b.uintValue),
            (9, 5) => new((double)a.doubleValue + (double)b.intValue),
            (9, 6) => new((double)a.doubleValue + (double)b.ulongValue),
            (9, 7) => new((double)a.doubleValue + (double)b.longValue),
            (9, 8) => new((double)a.doubleValue + (double)b.floatValue),
            _ => new((double)a.doubleValue + (double)b.doubleValue)
        };
    public static VariadicNumber operator -(VariadicNumber a, VariadicNumber b)
        => (a.index, b.index) switch
        {
            (0, 0) => new((byte)a.byteValue - (byte)b.byteValue),
            (0, 1) => new((sbyte)a.byteValue - (sbyte)b.sbyteValue),
            (0, 2) => new((ushort)a.byteValue - (ushort)b.ushortValue),
            (0, 3) => new((short)a.byteValue - (short)b.shortValue),
            (0, 4) => new((uint)a.byteValue - (uint)b.uintValue),
            (0, 5) => new((int)a.byteValue - (int)b.intValue),
            (0, 6) => new((ulong)a.byteValue - (ulong)b.ulongValue),
            (0, 7) => new((long)a.byteValue - (long)b.longValue),
            (0, 8) => new((float)a.byteValue - (float)b.floatValue),
            (0, 9) => new((double)a.byteValue - (double)b.doubleValue),
            (1, 0) => new((sbyte)a.sbyteValue - (sbyte)b.byteValue),
            (1, 1) => new((sbyte)a.sbyteValue - (sbyte)b.sbyteValue),
            (1, 2) => new((ushort)a.sbyteValue - (ushort)b.ushortValue),
            (1, 3) => new((short)a.sbyteValue - (short)b.shortValue),
            (1, 4) => new((uint)a.sbyteValue - (uint)b.uintValue),
            (1, 5) => new((int)a.sbyteValue - (int)b.intValue),
            (1, 6) => new((ulong)a.sbyteValue - (ulong)b.ulongValue),
            (1, 7) => new((long)a.sbyteValue - (long)b.longValue),
            (1, 8) => new((float)a.sbyteValue - (float)b.floatValue),
            (1, 9) => new((double)a.sbyteValue - (double)b.doubleValue),
            (2, 0) => new((ushort)a.ushortValue - (ushort)b.byteValue),
            (2, 1) => new((ushort)a.ushortValue - (ushort)b.sbyteValue),
            (2, 2) => new((ushort)a.ushortValue - (ushort)b.ushortValue),
            (2, 3) => new((short)a.ushortValue - (short)b.shortValue),
            (2, 4) => new((uint)a.ushortValue - (uint)b.uintValue),
            (2, 5) => new((int)a.ushortValue - (int)b.intValue),
            (2, 6) => new((ulong)a.ushortValue - (ulong)b.ulongValue),
            (2, 7) => new((long)a.ushortValue - (long)b.longValue),
            (2, 8) => new((float)a.ushortValue - (float)b.floatValue),
            (2, 9) => new((double)a.ushortValue - (double)b.doubleValue),
            (3, 0) => new((short)a.shortValue - (short)b.byteValue),
            (3, 1) => new((short)a.shortValue - (short)b.sbyteValue),
            (3, 2) => new((short)a.shortValue - (short)b.ushortValue),
            (3, 3) => new((short)a.shortValue - (short)b.shortValue),
            (3, 4) => new((uint)a.shortValue - (uint)b.uintValue),
            (3, 5) => new((int)a.shortValue - (int)b.intValue),
            (3, 6) => new((ulong)a.shortValue - (ulong)b.ulongValue),
            (3, 7) => new((long)a.shortValue - (long)b.longValue),
            (3, 8) => new((float)a.shortValue - (float)b.floatValue),
            (3, 9) => new((double)a.shortValue - (double)b.doubleValue),
            (4, 0) => new((uint)a.uintValue - (uint)b.byteValue),
            (4, 1) => new((uint)a.uintValue - (uint)b.sbyteValue),
            (4, 2) => new((uint)a.uintValue - (uint)b.ushortValue),
            (4, 3) => new((uint)a.uintValue - (uint)b.shortValue),
            (4, 4) => new((uint)a.uintValue - (uint)b.uintValue),
            (4, 5) => new((int)a.uintValue - (int)b.intValue),
            (4, 6) => new((ulong)a.uintValue - (ulong)b.ulongValue),
            (4, 7) => new((long)a.uintValue - (long)b.longValue),
            (4, 8) => new((float)a.uintValue - (float)b.floatValue),
            (4, 9) => new((double)a.uintValue - (double)b.doubleValue),
            (5, 0) => new((int)a.intValue - (int)b.byteValue),
            (5, 1) => new((int)a.intValue - (int)b.sbyteValue),
            (5, 2) => new((int)a.intValue - (int)b.ushortValue),
            (5, 3) => new((int)a.intValue - (int)b.shortValue),
            (5, 4) => new((int)a.intValue - (int)b.uintValue),
            (5, 5) => new((int)a.intValue - (int)b.intValue),
            (5, 6) => new((ulong)a.intValue - (ulong)b.ulongValue),
            (5, 7) => new((long)a.intValue - (long)b.longValue),
            (5, 8) => new((float)a.intValue - (float)b.floatValue),
            (5, 9) => new((double)a.intValue - (double)b.doubleValue),
            (6, 0) => new((ulong)a.ulongValue - (ulong)b.byteValue),
            (6, 1) => new((ulong)a.ulongValue - (ulong)b.sbyteValue),
            (6, 2) => new((ulong)a.ulongValue - (ulong)b.ushortValue),
            (6, 3) => new((ulong)a.ulongValue - (ulong)b.shortValue),
            (6, 4) => new((ulong)a.ulongValue - (ulong)b.uintValue),
            (6, 5) => new((ulong)a.ulongValue - (ulong)b.intValue),
            (6, 6) => new((ulong)a.ulongValue - (ulong)b.ulongValue),
            (6, 7) => new((long)a.ulongValue - (long)b.longValue),
            (6, 8) => new((float)a.ulongValue - (float)b.floatValue),
            (6, 9) => new((double)a.ulongValue - (double)b.doubleValue),
            (7, 0) => new((long)a.longValue - (long)b.byteValue),
            (7, 1) => new((long)a.longValue - (long)b.sbyteValue),
            (7, 2) => new((long)a.longValue - (long)b.ushortValue),
            (7, 3) => new((long)a.longValue - (long)b.shortValue),
            (7, 4) => new((long)a.longValue - (long)b.uintValue),
            (7, 5) => new((long)a.longValue - (long)b.intValue),
            (7, 6) => new((long)a.longValue - (long)b.ulongValue),
            (7, 7) => new((long)a.longValue - (long)b.longValue),
            (7, 8) => new((float)a.longValue - (float)b.floatValue),
            (7, 9) => new((double)a.longValue - (double)b.doubleValue),
            (8, 0) => new((float)a.floatValue - (float)b.byteValue),
            (8, 1) => new((float)a.floatValue - (float)b.sbyteValue),
            (8, 2) => new((float)a.floatValue - (float)b.ushortValue),
            (8, 3) => new((float)a.floatValue - (float)b.shortValue),
            (8, 4) => new((float)a.floatValue - (float)b.uintValue),
            (8, 5) => new((float)a.floatValue - (float)b.intValue),
            (8, 6) => new((float)a.floatValue - (float)b.ulongValue),
            (8, 7) => new((float)a.floatValue - (float)b.longValue),
            (8, 8) => new((float)a.floatValue - (float)b.floatValue),
            (8, 9) => new((double)a.floatValue - (double)b.doubleValue),
            (9, 0) => new((double)a.doubleValue - (double)b.byteValue),
            (9, 1) => new((double)a.doubleValue - (double)b.sbyteValue),
            (9, 2) => new((double)a.doubleValue - (double)b.ushortValue),
            (9, 3) => new((double)a.doubleValue - (double)b.shortValue),
            (9, 4) => new((double)a.doubleValue - (double)b.uintValue),
            (9, 5) => new((double)a.doubleValue - (double)b.intValue),
            (9, 6) => new((double)a.doubleValue - (double)b.ulongValue),
            (9, 7) => new((double)a.doubleValue - (double)b.longValue),
            (9, 8) => new((double)a.doubleValue - (double)b.floatValue),
            _ => new((double)a.doubleValue - (double)b.doubleValue)
        };
    public static VariadicNumber operator *(VariadicNumber a, VariadicNumber b)
        => (a.index, b.index) switch
        {
            (0, 0) => new((byte)a.byteValue * (byte)b.byteValue),
            (0, 1) => new((sbyte)a.byteValue * (sbyte)b.sbyteValue),
            (0, 2) => new((ushort)a.byteValue * (ushort)b.ushortValue),
            (0, 3) => new((short)a.byteValue * (short)b.shortValue),
            (0, 4) => new((uint)a.byteValue * (uint)b.uintValue),
            (0, 5) => new((int)a.byteValue * (int)b.intValue),
            (0, 6) => new((ulong)a.byteValue * (ulong)b.ulongValue),
            (0, 7) => new((long)a.byteValue * (long)b.longValue),
            (0, 8) => new((float)a.byteValue * (float)b.floatValue),
            (0, 9) => new((double)a.byteValue * (double)b.doubleValue),
            (1, 0) => new((sbyte)a.sbyteValue * (sbyte)b.byteValue),
            (1, 1) => new((sbyte)a.sbyteValue * (sbyte)b.sbyteValue),
            (1, 2) => new((ushort)a.sbyteValue * (ushort)b.ushortValue),
            (1, 3) => new((short)a.sbyteValue * (short)b.shortValue),
            (1, 4) => new((uint)a.sbyteValue * (uint)b.uintValue),
            (1, 5) => new((int)a.sbyteValue * (int)b.intValue),
            (1, 6) => new((ulong)a.sbyteValue * (ulong)b.ulongValue),
            (1, 7) => new((long)a.sbyteValue * (long)b.longValue),
            (1, 8) => new((float)a.sbyteValue * (float)b.floatValue),
            (1, 9) => new((double)a.sbyteValue * (double)b.doubleValue),
            (2, 0) => new((ushort)a.ushortValue * (ushort)b.byteValue),
            (2, 1) => new((ushort)a.ushortValue * (ushort)b.sbyteValue),
            (2, 2) => new((ushort)a.ushortValue * (ushort)b.ushortValue),
            (2, 3) => new((short)a.ushortValue * (short)b.shortValue),
            (2, 4) => new((uint)a.ushortValue * (uint)b.uintValue),
            (2, 5) => new((int)a.ushortValue * (int)b.intValue),
            (2, 6) => new((ulong)a.ushortValue * (ulong)b.ulongValue),
            (2, 7) => new((long)a.ushortValue * (long)b.longValue),
            (2, 8) => new((float)a.ushortValue * (float)b.floatValue),
            (2, 9) => new((double)a.ushortValue * (double)b.doubleValue),
            (3, 0) => new((short)a.shortValue * (short)b.byteValue),
            (3, 1) => new((short)a.shortValue * (short)b.sbyteValue),
            (3, 2) => new((short)a.shortValue * (short)b.ushortValue),
            (3, 3) => new((short)a.shortValue * (short)b.shortValue),
            (3, 4) => new((uint)a.shortValue * (uint)b.uintValue),
            (3, 5) => new((int)a.shortValue * (int)b.intValue),
            (3, 6) => new((ulong)a.shortValue * (ulong)b.ulongValue),
            (3, 7) => new((long)a.shortValue * (long)b.longValue),
            (3, 8) => new((float)a.shortValue * (float)b.floatValue),
            (3, 9) => new((double)a.shortValue * (double)b.doubleValue),
            (4, 0) => new((uint)a.uintValue * (uint)b.byteValue),
            (4, 1) => new((uint)a.uintValue * (uint)b.sbyteValue),
            (4, 2) => new((uint)a.uintValue * (uint)b.ushortValue),
            (4, 3) => new((uint)a.uintValue * (uint)b.shortValue),
            (4, 4) => new((uint)a.uintValue * (uint)b.uintValue),
            (4, 5) => new((int)a.uintValue * (int)b.intValue),
            (4, 6) => new((ulong)a.uintValue * (ulong)b.ulongValue),
            (4, 7) => new((long)a.uintValue * (long)b.longValue),
            (4, 8) => new((float)a.uintValue * (float)b.floatValue),
            (4, 9) => new((double)a.uintValue * (double)b.doubleValue),
            (5, 0) => new((int)a.intValue * (int)b.byteValue),
            (5, 1) => new((int)a.intValue * (int)b.sbyteValue),
            (5, 2) => new((int)a.intValue * (int)b.ushortValue),
            (5, 3) => new((int)a.intValue * (int)b.shortValue),
            (5, 4) => new((int)a.intValue * (int)b.uintValue),
            (5, 5) => new((int)a.intValue * (int)b.intValue),
            (5, 6) => new((ulong)a.intValue * (ulong)b.ulongValue),
            (5, 7) => new((long)a.intValue * (long)b.longValue),
            (5, 8) => new((float)a.intValue * (float)b.floatValue),
            (5, 9) => new((double)a.intValue * (double)b.doubleValue),
            (6, 0) => new((ulong)a.ulongValue * (ulong)b.byteValue),
            (6, 1) => new((ulong)a.ulongValue * (ulong)b.sbyteValue),
            (6, 2) => new((ulong)a.ulongValue * (ulong)b.ushortValue),
            (6, 3) => new((ulong)a.ulongValue * (ulong)b.shortValue),
            (6, 4) => new((ulong)a.ulongValue * (ulong)b.uintValue),
            (6, 5) => new((ulong)a.ulongValue * (ulong)b.intValue),
            (6, 6) => new((ulong)a.ulongValue * (ulong)b.ulongValue),
            (6, 7) => new((long)a.ulongValue * (long)b.longValue),
            (6, 8) => new((float)a.ulongValue * (float)b.floatValue),
            (6, 9) => new((double)a.ulongValue * (double)b.doubleValue),
            (7, 0) => new((long)a.longValue * (long)b.byteValue),
            (7, 1) => new((long)a.longValue * (long)b.sbyteValue),
            (7, 2) => new((long)a.longValue * (long)b.ushortValue),
            (7, 3) => new((long)a.longValue * (long)b.shortValue),
            (7, 4) => new((long)a.longValue * (long)b.uintValue),
            (7, 5) => new((long)a.longValue * (long)b.intValue),
            (7, 6) => new((long)a.longValue * (long)b.ulongValue),
            (7, 7) => new((long)a.longValue * (long)b.longValue),
            (7, 8) => new((float)a.longValue * (float)b.floatValue),
            (7, 9) => new((double)a.longValue * (double)b.doubleValue),
            (8, 0) => new((float)a.floatValue * (float)b.byteValue),
            (8, 1) => new((float)a.floatValue * (float)b.sbyteValue),
            (8, 2) => new((float)a.floatValue * (float)b.ushortValue),
            (8, 3) => new((float)a.floatValue * (float)b.shortValue),
            (8, 4) => new((float)a.floatValue * (float)b.uintValue),
            (8, 5) => new((float)a.floatValue * (float)b.intValue),
            (8, 6) => new((float)a.floatValue * (float)b.ulongValue),
            (8, 7) => new((float)a.floatValue * (float)b.longValue),
            (8, 8) => new((float)a.floatValue * (float)b.floatValue),
            (8, 9) => new((double)a.floatValue * (double)b.doubleValue),
            (9, 0) => new((double)a.doubleValue * (double)b.byteValue),
            (9, 1) => new((double)a.doubleValue * (double)b.sbyteValue),
            (9, 2) => new((double)a.doubleValue * (double)b.ushortValue),
            (9, 3) => new((double)a.doubleValue * (double)b.shortValue),
            (9, 4) => new((double)a.doubleValue * (double)b.uintValue),
            (9, 5) => new((double)a.doubleValue * (double)b.intValue),
            (9, 6) => new((double)a.doubleValue * (double)b.ulongValue),
            (9, 7) => new((double)a.doubleValue * (double)b.longValue),
            (9, 8) => new((double)a.doubleValue * (double)b.floatValue),
            _ => new((double)a.doubleValue * (double)b.doubleValue)
        };
    public static VariadicNumber operator /(VariadicNumber a, VariadicNumber b)
        => (a.index, b.index) switch
        {
            (0, 0) => new((byte)a.byteValue / (byte)b.byteValue),
            (0, 1) => new((sbyte)a.byteValue / (sbyte)b.sbyteValue),
            (0, 2) => new((ushort)a.byteValue / (ushort)b.ushortValue),
            (0, 3) => new((short)a.byteValue / (short)b.shortValue),
            (0, 4) => new((uint)a.byteValue / (uint)b.uintValue),
            (0, 5) => new((int)a.byteValue / (int)b.intValue),
            (0, 6) => new((ulong)a.byteValue / (ulong)b.ulongValue),
            (0, 7) => new((long)a.byteValue / (long)b.longValue),
            (0, 8) => new((float)a.byteValue / (float)b.floatValue),
            (0, 9) => new((double)a.byteValue / (double)b.doubleValue),
            (1, 0) => new((sbyte)a.sbyteValue / (sbyte)b.byteValue),
            (1, 1) => new((sbyte)a.sbyteValue / (sbyte)b.sbyteValue),
            (1, 2) => new((ushort)a.sbyteValue / (ushort)b.ushortValue),
            (1, 3) => new((short)a.sbyteValue / (short)b.shortValue),
            (1, 4) => new((uint)a.sbyteValue / (uint)b.uintValue),
            (1, 5) => new((int)a.sbyteValue / (int)b.intValue),
            (1, 6) => new((ulong)a.sbyteValue / (ulong)b.ulongValue),
            (1, 7) => new((long)a.sbyteValue / (long)b.longValue),
            (1, 8) => new((float)a.sbyteValue / (float)b.floatValue),
            (1, 9) => new((double)a.sbyteValue / (double)b.doubleValue),
            (2, 0) => new((ushort)a.ushortValue / (ushort)b.byteValue),
            (2, 1) => new((ushort)a.ushortValue / (ushort)b.sbyteValue),
            (2, 2) => new((ushort)a.ushortValue / (ushort)b.ushortValue),
            (2, 3) => new((short)a.ushortValue / (short)b.shortValue),
            (2, 4) => new((uint)a.ushortValue / (uint)b.uintValue),
            (2, 5) => new((int)a.ushortValue / (int)b.intValue),
            (2, 6) => new((ulong)a.ushortValue / (ulong)b.ulongValue),
            (2, 7) => new((long)a.ushortValue / (long)b.longValue),
            (2, 8) => new((float)a.ushortValue / (float)b.floatValue),
            (2, 9) => new((double)a.ushortValue / (double)b.doubleValue),
            (3, 0) => new((short)a.shortValue / (short)b.byteValue),
            (3, 1) => new((short)a.shortValue / (short)b.sbyteValue),
            (3, 2) => new((short)a.shortValue / (short)b.ushortValue),
            (3, 3) => new((short)a.shortValue / (short)b.shortValue),
            (3, 4) => new((uint)a.shortValue / (uint)b.uintValue),
            (3, 5) => new((int)a.shortValue / (int)b.intValue),
            (3, 6) => new((ulong)a.shortValue / (ulong)b.ulongValue),
            (3, 7) => new((long)a.shortValue / (long)b.longValue),
            (3, 8) => new((float)a.shortValue / (float)b.floatValue),
            (3, 9) => new((double)a.shortValue / (double)b.doubleValue),
            (4, 0) => new((uint)a.uintValue / (uint)b.byteValue),
            (4, 1) => new((uint)a.uintValue / (uint)b.sbyteValue),
            (4, 2) => new((uint)a.uintValue / (uint)b.ushortValue),
            (4, 3) => new((uint)a.uintValue / (uint)b.shortValue),
            (4, 4) => new((uint)a.uintValue / (uint)b.uintValue),
            (4, 5) => new((int)a.uintValue / (int)b.intValue),
            (4, 6) => new((ulong)a.uintValue / (ulong)b.ulongValue),
            (4, 7) => new((long)a.uintValue / (long)b.longValue),
            (4, 8) => new((float)a.uintValue / (float)b.floatValue),
            (4, 9) => new((double)a.uintValue / (double)b.doubleValue),
            (5, 0) => new((int)a.intValue / (int)b.byteValue),
            (5, 1) => new((int)a.intValue / (int)b.sbyteValue),
            (5, 2) => new((int)a.intValue / (int)b.ushortValue),
            (5, 3) => new((int)a.intValue / (int)b.shortValue),
            (5, 4) => new((int)a.intValue / (int)b.uintValue),
            (5, 5) => new((int)a.intValue / (int)b.intValue),
            (5, 6) => new((ulong)a.intValue / (ulong)b.ulongValue),
            (5, 7) => new((long)a.intValue / (long)b.longValue),
            (5, 8) => new((float)a.intValue / (float)b.floatValue),
            (5, 9) => new((double)a.intValue / (double)b.doubleValue),
            (6, 0) => new((ulong)a.ulongValue / (ulong)b.byteValue),
            (6, 1) => new((ulong)a.ulongValue / (ulong)b.sbyteValue),
            (6, 2) => new((ulong)a.ulongValue / (ulong)b.ushortValue),
            (6, 3) => new((ulong)a.ulongValue / (ulong)b.shortValue),
            (6, 4) => new((ulong)a.ulongValue / (ulong)b.uintValue),
            (6, 5) => new((ulong)a.ulongValue / (ulong)b.intValue),
            (6, 6) => new((ulong)a.ulongValue / (ulong)b.ulongValue),
            (6, 7) => new((long)a.ulongValue / (long)b.longValue),
            (6, 8) => new((float)a.ulongValue / (float)b.floatValue),
            (6, 9) => new((double)a.ulongValue / (double)b.doubleValue),
            (7, 0) => new((long)a.longValue / (long)b.byteValue),
            (7, 1) => new((long)a.longValue / (long)b.sbyteValue),
            (7, 2) => new((long)a.longValue / (long)b.ushortValue),
            (7, 3) => new((long)a.longValue / (long)b.shortValue),
            (7, 4) => new((long)a.longValue / (long)b.uintValue),
            (7, 5) => new((long)a.longValue / (long)b.intValue),
            (7, 6) => new((long)a.longValue / (long)b.ulongValue),
            (7, 7) => new((long)a.longValue / (long)b.longValue),
            (7, 8) => new((float)a.longValue / (float)b.floatValue),
            (7, 9) => new((double)a.longValue / (double)b.doubleValue),
            (8, 0) => new((float)a.floatValue / (float)b.byteValue),
            (8, 1) => new((float)a.floatValue / (float)b.sbyteValue),
            (8, 2) => new((float)a.floatValue / (float)b.ushortValue),
            (8, 3) => new((float)a.floatValue / (float)b.shortValue),
            (8, 4) => new((float)a.floatValue / (float)b.uintValue),
            (8, 5) => new((float)a.floatValue / (float)b.intValue),
            (8, 6) => new((float)a.floatValue / (float)b.ulongValue),
            (8, 7) => new((float)a.floatValue / (float)b.longValue),
            (8, 8) => new((float)a.floatValue / (float)b.floatValue),
            (8, 9) => new((double)a.floatValue / (double)b.doubleValue),
            (9, 0) => new((double)a.doubleValue / (double)b.byteValue),
            (9, 1) => new((double)a.doubleValue / (double)b.sbyteValue),
            (9, 2) => new((double)a.doubleValue / (double)b.ushortValue),
            (9, 3) => new((double)a.doubleValue / (double)b.shortValue),
            (9, 4) => new((double)a.doubleValue / (double)b.uintValue),
            (9, 5) => new((double)a.doubleValue / (double)b.intValue),
            (9, 6) => new((double)a.doubleValue / (double)b.ulongValue),
            (9, 7) => new((double)a.doubleValue / (double)b.longValue),
            (9, 8) => new((double)a.doubleValue / (double)b.floatValue),
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

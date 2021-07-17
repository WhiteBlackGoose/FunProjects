
using System;



public struct uint64_t
{
    internal UInt64 value;
    public uint64_t(UInt64 value)
        => this.value = value;

    public static implicit operator bool(uint64_t a) => a.value != 0;

    public static implicit operator uint64_t(UInt64 a) => new(a);
    public static implicit operator UInt64(uint64_t a) => a.value;

    public static uint64_t operator +(uint64_t a, uint64_t b)
        => new((UInt64)(a.value + b.value));
    public static uint64_t operator -(uint64_t a, uint64_t b)
        => new((UInt64)(a.value - b.value));
    public static uint64_t operator *(uint64_t a, uint64_t b)
        => new((UInt64)(a.value * b.value));
    public static uint64_t operator /(uint64_t a, uint64_t b)
        => new((UInt64)(a.value / b.value));
    public static uint64_t operator |(uint64_t a, uint64_t b)
        => new((UInt64)(a.value | b.value));
    public static uint64_t operator &(uint64_t a, uint64_t b)
        => new((UInt64)(a.value & b.value));
    public static uint64_t operator ^(uint64_t a, uint64_t b)
        => new((UInt64)(a.value ^ b.value));

    public static uint64_t operator <<(uint64_t a, int b)
        => new((UInt64)(a.value << b));
    public static uint64_t operator >>(uint64_t a, int b)
        => new((UInt64)(a.value >> b));

    public static bool operator <(uint64_t a, uint64_t b)
        => a.value < b.value;
    public static bool operator >(uint64_t a, uint64_t b)
        => a.value > b.value;
    public static bool operator >=(uint64_t a, uint64_t b)
        => a.value >= b.value;
    public static bool operator <=(uint64_t a, uint64_t b)
        => a.value <= b.value;
    public static bool operator ==(uint64_t a, uint64_t b)
        => a.value == b.value;
    public static bool operator !=(uint64_t a, uint64_t b)
        => a.value != b.value;


    public static uint64_t operator ~(uint64_t a)
        => new((UInt64)(~a.value));

    public static implicit operator uint64_t(int8_t other)
        => new((UInt64)other.value);
    public static implicit operator uint64_t(uint8_t other)
        => new((UInt64)other.value);
    public static implicit operator uint64_t(int16_t other)
        => new((UInt64)other.value);
    public static implicit operator uint64_t(uint16_t other)
        => new((UInt64)other.value);
    public static implicit operator uint64_t(int32_t other)
        => new((UInt64)other.value);
    public static implicit operator uint64_t(uint32_t other)
        => new((UInt64)other.value);
    public static implicit operator uint64_t(int64_t other)
        => new((UInt64)other.value);


}


public struct int64_t
{
    internal Int64 value;
    public int64_t(Int64 value)
        => this.value = value;

    public static implicit operator bool(int64_t a) => a.value != 0;

    public static implicit operator int64_t(Int64 a) => new(a);
    public static implicit operator Int64(int64_t a) => a.value;

    public static int64_t operator +(int64_t a, int64_t b)
        => new((Int64)(a.value + b.value));
    public static int64_t operator -(int64_t a, int64_t b)
        => new((Int64)(a.value - b.value));
    public static int64_t operator *(int64_t a, int64_t b)
        => new((Int64)(a.value * b.value));
    public static int64_t operator /(int64_t a, int64_t b)
        => new((Int64)(a.value / b.value));
    public static int64_t operator |(int64_t a, int64_t b)
        => new((Int64)(a.value | b.value));
    public static int64_t operator &(int64_t a, int64_t b)
        => new((Int64)(a.value & b.value));
    public static int64_t operator ^(int64_t a, int64_t b)
        => new((Int64)(a.value ^ b.value));

    public static int64_t operator <<(int64_t a, int b)
        => new((Int64)(a.value << b));
    public static int64_t operator >>(int64_t a, int b)
        => new((Int64)(a.value >> b));

    public static bool operator <(int64_t a, int64_t b)
        => a.value < b.value;
    public static bool operator >(int64_t a, int64_t b)
        => a.value > b.value;
    public static bool operator >=(int64_t a, int64_t b)
        => a.value >= b.value;
    public static bool operator <=(int64_t a, int64_t b)
        => a.value <= b.value;
    public static bool operator ==(int64_t a, int64_t b)
        => a.value == b.value;
    public static bool operator !=(int64_t a, int64_t b)
        => a.value != b.value;

    public static int64_t operator -(int64_t a)
        => new((Int64)(-a.value));

    public static int64_t operator ~(int64_t a)
        => new((Int64)(~a.value));

    public static implicit operator int64_t(int8_t other)
        => new((Int64)other.value);
    public static implicit operator int64_t(uint8_t other)
        => new((Int64)other.value);
    public static implicit operator int64_t(int16_t other)
        => new((Int64)other.value);
    public static implicit operator int64_t(uint16_t other)
        => new((Int64)other.value);
    public static implicit operator int64_t(int32_t other)
        => new((Int64)other.value);
    public static implicit operator int64_t(uint32_t other)
        => new((Int64)other.value);

    public static explicit operator int64_t(uint64_t other)
        => new((Int64)other.value);

}


public struct uint32_t
{
    internal UInt32 value;
    public uint32_t(UInt32 value)
        => this.value = value;

    public static implicit operator bool(uint32_t a) => a.value != 0;

    public static implicit operator uint32_t(UInt32 a) => new(a);
    public static implicit operator UInt32(uint32_t a) => a.value;

    public static uint32_t operator +(uint32_t a, uint32_t b)
        => new((UInt32)(a.value + b.value));
    public static uint32_t operator -(uint32_t a, uint32_t b)
        => new((UInt32)(a.value - b.value));
    public static uint32_t operator *(uint32_t a, uint32_t b)
        => new((UInt32)(a.value * b.value));
    public static uint32_t operator /(uint32_t a, uint32_t b)
        => new((UInt32)(a.value / b.value));
    public static uint32_t operator |(uint32_t a, uint32_t b)
        => new((UInt32)(a.value | b.value));
    public static uint32_t operator &(uint32_t a, uint32_t b)
        => new((UInt32)(a.value & b.value));
    public static uint32_t operator ^(uint32_t a, uint32_t b)
        => new((UInt32)(a.value ^ b.value));

    public static uint32_t operator <<(uint32_t a, int b)
        => new((UInt32)(a.value << b));
    public static uint32_t operator >>(uint32_t a, int b)
        => new((UInt32)(a.value >> b));

    public static bool operator <(uint32_t a, uint32_t b)
        => a.value < b.value;
    public static bool operator >(uint32_t a, uint32_t b)
        => a.value > b.value;
    public static bool operator >=(uint32_t a, uint32_t b)
        => a.value >= b.value;
    public static bool operator <=(uint32_t a, uint32_t b)
        => a.value <= b.value;
    public static bool operator ==(uint32_t a, uint32_t b)
        => a.value == b.value;
    public static bool operator !=(uint32_t a, uint32_t b)
        => a.value != b.value;


    public static uint32_t operator ~(uint32_t a)
        => new((UInt32)(~a.value));

    public static implicit operator uint32_t(int8_t other)
        => new((UInt32)other.value);
    public static implicit operator uint32_t(uint8_t other)
        => new((UInt32)other.value);
    public static implicit operator uint32_t(int16_t other)
        => new((UInt32)other.value);
    public static implicit operator uint32_t(uint16_t other)
        => new((UInt32)other.value);
    public static implicit operator uint32_t(int32_t other)
        => new((UInt32)other.value);

    public static explicit operator uint32_t(uint64_t other)
        => new((UInt32)other.value);
    public static explicit operator uint32_t(int64_t other)
        => new((UInt32)other.value);

}


public struct int32_t
{
    internal Int32 value;
    public int32_t(Int32 value)
        => this.value = value;

    public static implicit operator bool(int32_t a) => a.value != 0;

    public static implicit operator int32_t(Int32 a) => new(a);
    public static implicit operator Int32(int32_t a) => a.value;

    public static int32_t operator +(int32_t a, int32_t b)
        => new((Int32)(a.value + b.value));
    public static int32_t operator -(int32_t a, int32_t b)
        => new((Int32)(a.value - b.value));
    public static int32_t operator *(int32_t a, int32_t b)
        => new((Int32)(a.value * b.value));
    public static int32_t operator /(int32_t a, int32_t b)
        => new((Int32)(a.value / b.value));
    public static int32_t operator |(int32_t a, int32_t b)
        => new((Int32)(a.value | b.value));
    public static int32_t operator &(int32_t a, int32_t b)
        => new((Int32)(a.value & b.value));
    public static int32_t operator ^(int32_t a, int32_t b)
        => new((Int32)(a.value ^ b.value));

    public static int32_t operator <<(int32_t a, int b)
        => new((Int32)(a.value << b));
    public static int32_t operator >>(int32_t a, int b)
        => new((Int32)(a.value >> b));

    public static bool operator <(int32_t a, int32_t b)
        => a.value < b.value;
    public static bool operator >(int32_t a, int32_t b)
        => a.value > b.value;
    public static bool operator >=(int32_t a, int32_t b)
        => a.value >= b.value;
    public static bool operator <=(int32_t a, int32_t b)
        => a.value <= b.value;
    public static bool operator ==(int32_t a, int32_t b)
        => a.value == b.value;
    public static bool operator !=(int32_t a, int32_t b)
        => a.value != b.value;

    public static int32_t operator -(int32_t a)
        => new((Int32)(-a.value));

    public static int32_t operator ~(int32_t a)
        => new((Int32)(~a.value));

    public static implicit operator int32_t(int8_t other)
        => new((Int32)other.value);
    public static implicit operator int32_t(uint8_t other)
        => new((Int32)other.value);
    public static implicit operator int32_t(int16_t other)
        => new((Int32)other.value);
    public static implicit operator int32_t(uint16_t other)
        => new((Int32)other.value);

    public static explicit operator int32_t(uint64_t other)
        => new((Int32)other.value);
    public static explicit operator int32_t(int64_t other)
        => new((Int32)other.value);
    public static explicit operator int32_t(uint32_t other)
        => new((Int32)other.value);

}


public struct uint16_t
{
    internal UInt16 value;
    public uint16_t(UInt16 value)
        => this.value = value;

    public static implicit operator bool(uint16_t a) => a.value != 0;

    public static implicit operator uint16_t(UInt16 a) => new(a);
    public static implicit operator UInt16(uint16_t a) => a.value;

    public static uint16_t operator +(uint16_t a, uint16_t b)
        => new((UInt16)(a.value + b.value));
    public static uint16_t operator -(uint16_t a, uint16_t b)
        => new((UInt16)(a.value - b.value));
    public static uint16_t operator *(uint16_t a, uint16_t b)
        => new((UInt16)(a.value * b.value));
    public static uint16_t operator /(uint16_t a, uint16_t b)
        => new((UInt16)(a.value / b.value));
    public static uint16_t operator |(uint16_t a, uint16_t b)
        => new((UInt16)(a.value | b.value));
    public static uint16_t operator &(uint16_t a, uint16_t b)
        => new((UInt16)(a.value & b.value));
    public static uint16_t operator ^(uint16_t a, uint16_t b)
        => new((UInt16)(a.value ^ b.value));

    public static uint16_t operator <<(uint16_t a, int b)
        => new((UInt16)(a.value << b));
    public static uint16_t operator >>(uint16_t a, int b)
        => new((UInt16)(a.value >> b));

    public static bool operator <(uint16_t a, uint16_t b)
        => a.value < b.value;
    public static bool operator >(uint16_t a, uint16_t b)
        => a.value > b.value;
    public static bool operator >=(uint16_t a, uint16_t b)
        => a.value >= b.value;
    public static bool operator <=(uint16_t a, uint16_t b)
        => a.value <= b.value;
    public static bool operator ==(uint16_t a, uint16_t b)
        => a.value == b.value;
    public static bool operator !=(uint16_t a, uint16_t b)
        => a.value != b.value;


    public static uint16_t operator ~(uint16_t a)
        => new((UInt16)(~a.value));

    public static implicit operator uint16_t(int8_t other)
        => new((UInt16)other.value);
    public static implicit operator uint16_t(uint8_t other)
        => new((UInt16)other.value);
    public static implicit operator uint16_t(int16_t other)
        => new((UInt16)other.value);

    public static explicit operator uint16_t(uint64_t other)
        => new((UInt16)other.value);
    public static explicit operator uint16_t(int64_t other)
        => new((UInt16)other.value);
    public static explicit operator uint16_t(uint32_t other)
        => new((UInt16)other.value);
    public static explicit operator uint16_t(int32_t other)
        => new((UInt16)other.value);

}


public struct int16_t
{
    internal Int16 value;
    public int16_t(Int16 value)
        => this.value = value;

    public static implicit operator bool(int16_t a) => a.value != 0;

    public static implicit operator int16_t(Int16 a) => new(a);
    public static implicit operator Int16(int16_t a) => a.value;

    public static int16_t operator +(int16_t a, int16_t b)
        => new((Int16)(a.value + b.value));
    public static int16_t operator -(int16_t a, int16_t b)
        => new((Int16)(a.value - b.value));
    public static int16_t operator *(int16_t a, int16_t b)
        => new((Int16)(a.value * b.value));
    public static int16_t operator /(int16_t a, int16_t b)
        => new((Int16)(a.value / b.value));
    public static int16_t operator |(int16_t a, int16_t b)
        => new((Int16)(a.value | b.value));
    public static int16_t operator &(int16_t a, int16_t b)
        => new((Int16)(a.value & b.value));
    public static int16_t operator ^(int16_t a, int16_t b)
        => new((Int16)(a.value ^ b.value));

    public static int16_t operator <<(int16_t a, int b)
        => new((Int16)(a.value << b));
    public static int16_t operator >>(int16_t a, int b)
        => new((Int16)(a.value >> b));

    public static bool operator <(int16_t a, int16_t b)
        => a.value < b.value;
    public static bool operator >(int16_t a, int16_t b)
        => a.value > b.value;
    public static bool operator >=(int16_t a, int16_t b)
        => a.value >= b.value;
    public static bool operator <=(int16_t a, int16_t b)
        => a.value <= b.value;
    public static bool operator ==(int16_t a, int16_t b)
        => a.value == b.value;
    public static bool operator !=(int16_t a, int16_t b)
        => a.value != b.value;

    public static int16_t operator -(int16_t a)
        => new((Int16)(-a.value));

    public static int16_t operator ~(int16_t a)
        => new((Int16)(~a.value));

    public static implicit operator int16_t(int8_t other)
        => new((Int16)other.value);
    public static implicit operator int16_t(uint8_t other)
        => new((Int16)other.value);

    public static explicit operator int16_t(uint64_t other)
        => new((Int16)other.value);
    public static explicit operator int16_t(int64_t other)
        => new((Int16)other.value);
    public static explicit operator int16_t(uint32_t other)
        => new((Int16)other.value);
    public static explicit operator int16_t(int32_t other)
        => new((Int16)other.value);
    public static explicit operator int16_t(uint16_t other)
        => new((Int16)other.value);

}


public struct uint8_t
{
    internal byte value;
    public uint8_t(byte value)
        => this.value = value;

    public static implicit operator bool(uint8_t a) => a.value != 0;

    public static implicit operator uint8_t(byte a) => new(a);
    public static implicit operator byte(uint8_t a) => a.value;

    public static uint8_t operator +(uint8_t a, uint8_t b)
        => new((byte)(a.value + b.value));
    public static uint8_t operator -(uint8_t a, uint8_t b)
        => new((byte)(a.value - b.value));
    public static uint8_t operator *(uint8_t a, uint8_t b)
        => new((byte)(a.value * b.value));
    public static uint8_t operator /(uint8_t a, uint8_t b)
        => new((byte)(a.value / b.value));
    public static uint8_t operator |(uint8_t a, uint8_t b)
        => new((byte)(a.value | b.value));
    public static uint8_t operator &(uint8_t a, uint8_t b)
        => new((byte)(a.value & b.value));
    public static uint8_t operator ^(uint8_t a, uint8_t b)
        => new((byte)(a.value ^ b.value));

    public static uint8_t operator <<(uint8_t a, int b)
        => new((byte)(a.value << b));
    public static uint8_t operator >>(uint8_t a, int b)
        => new((byte)(a.value >> b));

    public static bool operator <(uint8_t a, uint8_t b)
        => a.value < b.value;
    public static bool operator >(uint8_t a, uint8_t b)
        => a.value > b.value;
    public static bool operator >=(uint8_t a, uint8_t b)
        => a.value >= b.value;
    public static bool operator <=(uint8_t a, uint8_t b)
        => a.value <= b.value;
    public static bool operator ==(uint8_t a, uint8_t b)
        => a.value == b.value;
    public static bool operator !=(uint8_t a, uint8_t b)
        => a.value != b.value;


    public static uint8_t operator ~(uint8_t a)
        => new((byte)(~a.value));

    public static implicit operator uint8_t(int8_t other)
        => new((byte)other.value);

    public static explicit operator uint8_t(uint64_t other)
        => new((byte)other.value);
    public static explicit operator uint8_t(int64_t other)
        => new((byte)other.value);
    public static explicit operator uint8_t(uint32_t other)
        => new((byte)other.value);
    public static explicit operator uint8_t(int32_t other)
        => new((byte)other.value);
    public static explicit operator uint8_t(uint16_t other)
        => new((byte)other.value);
    public static explicit operator uint8_t(int16_t other)
        => new((byte)other.value);

}


public struct int8_t
{
    internal sbyte value;
    public int8_t(sbyte value)
        => this.value = value;

    public static implicit operator bool(int8_t a) => a.value != 0;

    public static implicit operator int8_t(sbyte a) => new(a);
    public static implicit operator sbyte(int8_t a) => a.value;

    public static int8_t operator +(int8_t a, int8_t b)
        => new((sbyte)(a.value + b.value));
    public static int8_t operator -(int8_t a, int8_t b)
        => new((sbyte)(a.value - b.value));
    public static int8_t operator *(int8_t a, int8_t b)
        => new((sbyte)(a.value * b.value));
    public static int8_t operator /(int8_t a, int8_t b)
        => new((sbyte)(a.value / b.value));
    public static int8_t operator |(int8_t a, int8_t b)
        => new((sbyte)(a.value | b.value));
    public static int8_t operator &(int8_t a, int8_t b)
        => new((sbyte)(a.value & b.value));
    public static int8_t operator ^(int8_t a, int8_t b)
        => new((sbyte)(a.value ^ b.value));

    public static int8_t operator <<(int8_t a, int b)
        => new((sbyte)(a.value << b));
    public static int8_t operator >>(int8_t a, int b)
        => new((sbyte)(a.value >> b));

    public static bool operator <(int8_t a, int8_t b)
        => a.value < b.value;
    public static bool operator >(int8_t a, int8_t b)
        => a.value > b.value;
    public static bool operator >=(int8_t a, int8_t b)
        => a.value >= b.value;
    public static bool operator <=(int8_t a, int8_t b)
        => a.value <= b.value;
    public static bool operator ==(int8_t a, int8_t b)
        => a.value == b.value;
    public static bool operator !=(int8_t a, int8_t b)
        => a.value != b.value;

    public static int8_t operator -(int8_t a)
        => new((sbyte)(-a.value));

    public static int8_t operator ~(int8_t a)
        => new((sbyte)(~a.value));


    public static explicit operator int8_t(uint64_t other)
        => new((sbyte)other.value);
    public static explicit operator int8_t(int64_t other)
        => new((sbyte)other.value);
    public static explicit operator int8_t(uint32_t other)
        => new((sbyte)other.value);
    public static explicit operator int8_t(int32_t other)
        => new((sbyte)other.value);
    public static explicit operator int8_t(uint16_t other)
        => new((sbyte)other.value);
    public static explicit operator int8_t(int16_t other)
        => new((sbyte)other.value);
    public static explicit operator int8_t(uint8_t other)
        => new((sbyte)other.value);

}


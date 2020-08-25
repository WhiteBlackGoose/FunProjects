using System;

namespace OperatorsForGeneric
{

    public static class Addition
    {
        private static class InnerStorage<T>
        {
            public static Func<T, T, T> reflectionOperator = (T a, T b) =>
            {
                var mi = typeof(T).GetMethod("op_Addition", new[] {typeof(T), typeof(T)});
                if (mi is null)
                    throw new ArgumentException($"There is no operator '+' for type {typeof(T).Name} ");
                reflectionOperator = (Func<T, T, T>) mi.CreateDelegate(typeof(Func<T, T, T>));
                return reflectionOperator(a, b);
            };
        }

        public static T Do<T>(T a, T b)
        {
            if (typeof(T) == typeof(Int16))
                return (T)(object)((Int16)(object)a + (Int16)(object)b);
            else if (typeof(T) == typeof(Int32))
                return (T)(object)((Int32)(object)a + (Int32)(object)b);
            else if (typeof(T) == typeof(Int64))
                return (T)(object)((Int64)(object)a + (Int64)(object)b);
            else if (typeof(T) == typeof(UInt16))
                return (T)(object)((UInt16)(object)a + (UInt16)(object)b);
            else if (typeof(T) == typeof(UInt32))
                return (T)(object)((UInt32)(object)a + (UInt32)(object)b);
            else if (typeof(T) == typeof(UInt64))
                return (T)(object)((UInt64)(object)a + (UInt64)(object)b);
            else if (typeof(T) == typeof(Single))
                return (T)(object)((Single)(object)a + (Single)(object)b);
            else if (typeof(T) == typeof(Double))
                return (T)(object)((Double)(object)a + (Double)(object)b);
            else if (typeof(T) == typeof(String))
                return (T)(object)String.Concat((string)(object)a, (string)(object)b);
            else
                return InnerStorage<T>.reflectionOperator(a, b);
        }
    }

    public static class Subtraction
    {
        private static class InnerStorage<T>
        {
            public static Func<T, T, T> reflectionOperator = (T a, T b) =>
            {
                var mi = typeof(T).GetMethod("op_Subtraction", new[] {typeof(T), typeof(T)});
                if (mi is null)
                    throw new ArgumentException($"There is no operator '-' for type {typeof(T).Name} ");
                reflectionOperator = (Func<T, T, T>) mi.CreateDelegate(typeof(Func<T, T, T>));
                return reflectionOperator(a, b);
            };
        }

        public static T Do<T>(T a, T b)
        {
            if (typeof(T) == typeof(Int16))
                return (T)(object)((Int16)(object)a - (Int16)(object)b);
            else if (typeof(T) == typeof(Int32))
                return (T)(object)((Int32)(object)a - (Int32)(object)b);
            else if (typeof(T) == typeof(Int64))
                return (T)(object)((Int64)(object)a - (Int64)(object)b);
            else if (typeof(T) == typeof(UInt16))
                return (T)(object)((UInt16)(object)a - (UInt16)(object)b);
            else if (typeof(T) == typeof(UInt32))
                return (T)(object)((UInt32)(object)a - (UInt32)(object)b);
            else if (typeof(T) == typeof(UInt64))
                return (T)(object)((UInt64)(object)a - (UInt64)(object)b);
            else if (typeof(T) == typeof(Single))
                return (T)(object)((Single)(object)a - (Single)(object)b);
            else if (typeof(T) == typeof(Double))
                return (T)(object)((Double)(object)a - (Double)(object)b);
            else
                return InnerStorage<T>.reflectionOperator(a, b);
        }
    }

    public static class Multiplication
    {
        private static class InnerStorage<T>
        {
            public static Func<T, T, T> reflectionOperator = (T a, T b) =>
            {
                var mi = typeof(T).GetMethod("op_Multiplication", new[] {typeof(T), typeof(T)});
                if (mi is null)
                    throw new ArgumentException($"There is no operator '*' for type {typeof(T).Name} ");
                reflectionOperator = (Func<T, T, T>) mi.CreateDelegate(typeof(Func<T, T, T>));
                return reflectionOperator(a, b);
            };
        }

        public static T Do<T>(T a, T b)
        {
            if (typeof(T) == typeof(Int16))
                return (T)(object)((Int16)(object)a * (Int16)(object)b);
            else if (typeof(T) == typeof(Int32))
                return (T)(object)((Int32)(object)a * (Int32)(object)b);
            else if (typeof(T) == typeof(Int64))
                return (T)(object)((Int64)(object)a * (Int64)(object)b);
            else if (typeof(T) == typeof(UInt16))
                return (T)(object)((UInt16)(object)a * (UInt16)(object)b);
            else if (typeof(T) == typeof(UInt32))
                return (T)(object)((UInt32)(object)a * (UInt32)(object)b);
            else if (typeof(T) == typeof(UInt64))
                return (T)(object)((UInt64)(object)a * (UInt64)(object)b);
            else if (typeof(T) == typeof(Single))
                return (T)(object)((Single)(object)a * (Single)(object)b);
            else if (typeof(T) == typeof(Double))
                return (T)(object)((Double)(object)a * (Double)(object)b);
            else
                return InnerStorage<T>.reflectionOperator(a, b);
        }
    }

    public static class Division
    {
        private static class InnerStorage<T>
        {
            public static Func<T, T, T> reflectionOperator = (T a, T b) =>
            {
                var mi = typeof(T).GetMethod("op_Division", new[] {typeof(T), typeof(T)});
                if (mi is null)
                    throw new ArgumentException($"There is no operator '/' for type {typeof(T).Name} ");
                reflectionOperator = (Func<T, T, T>) mi.CreateDelegate(typeof(Func<T, T, T>));
                return reflectionOperator(a, b);
            };
        }

        public static T Do<T>(T a, T b)
        {
            if (typeof(T) == typeof(Int16))
                return (T)(object)((Int16)(object)a / (Int16)(object)b);
            else if (typeof(T) == typeof(Int32))
                return (T)(object)((Int32)(object)a / (Int32)(object)b);
            else if (typeof(T) == typeof(Int64))
                return (T)(object)((Int64)(object)a / (Int64)(object)b);
            else if (typeof(T) == typeof(UInt16))
                return (T)(object)((UInt16)(object)a / (UInt16)(object)b);
            else if (typeof(T) == typeof(UInt32))
                return (T)(object)((UInt32)(object)a / (UInt32)(object)b);
            else if (typeof(T) == typeof(UInt64))
                return (T)(object)((UInt64)(object)a / (UInt64)(object)b);
            else if (typeof(T) == typeof(Single))
                return (T)(object)((Single)(object)a / (Single)(object)b);
            else if (typeof(T) == typeof(Double))
                return (T)(object)((Double)(object)a / (Double)(object)b);
            else
                return InnerStorage<T>.reflectionOperator(a, b);
        }
    }
}
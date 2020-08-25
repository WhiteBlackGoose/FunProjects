using System;
using System.IO;
using System.Numerics;
using System.Text;
using OperatorsForGeneric;

namespace OperatorsForGenericGenerator
{
    class Program
    {
        static void RegenerateSources()
        {
            var types = new[]
            {
                typeof(Int16), typeof(Int32), typeof(Int64),
                typeof(UInt16), typeof(UInt32), typeof(UInt64),
                typeof(Single), typeof(Double)
            };
            var generated = SourceGenerator.Generate(types);
            File.WriteAllText("../../../../OperatorsForGeneric/GenericArithmetic.cs", generated);
        }

        public class JustAddableType
        {
            private string state;
            protected JustAddableType(string state)
                => this.state = state;

            public static JustAddableType operator +(JustAddableType a, JustAddableType b)
                => new JustAddableType($"{a} + {b}");

            public override string ToString() => state;

            public static implicit operator JustAddableType(string a)
                => new JustAddableType(a);

        }

        static void Main(string[] _)
        {
            var a = Addition.Do(4, 5);
            var b = Addition.Do("a", "bd");
            var c = Addition.Do(new Complex(4, 5), new Complex(-1, 5));
            var d = Addition.Do((JustAddableType)"x", (JustAddableType)"2");
            Console.WriteLine(a + " " + b + " " + c + " " + d.ToString());
        }
    }
}

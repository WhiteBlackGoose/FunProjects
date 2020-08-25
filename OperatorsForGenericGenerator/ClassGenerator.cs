using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsForGenericGenerator
{
    public static class ClassGenerator
    {
        public static void Generate(StringBuilder sb, Type[] types, string className, string op, Func<(string intent, string alreadyIf), string> callback, string intent)
        {
            sb.Append($"{intent}public static class {className}\n");
            sb.Append($"{intent}{{\n");
            sb.Append($"{intent}    private static class InnerStorage<T>\n");
            sb.Append($"{intent}    {{\n");
            sb.Append($"{intent}        public static Func<T, T, T> reflectionOperator = (T a, T b) =>\n");
            sb.Append($"{intent}        {{\n");
            sb.Append($"{intent}            var mi = typeof(T).GetMethod(\"op_{className}\", new[] {{typeof(T), typeof(T)}});\n");
            sb.Append($"{intent}            if (mi is null)\n");
            sb.Append($"{intent}                throw new ArgumentException($\"There is no operator '{op}' for type {{typeof(T).Name}} \");\n");
            sb.Append($"{intent}            reflectionOperator = (Func<T, T, T>) mi.CreateDelegate(typeof(Func<T, T, T>));\n");
            sb.Append($"{intent}            return reflectionOperator(a, b);\n");
            sb.Append($"{intent}        }};\n");
            sb.Append($"{intent}    }}\n");
            sb.Append("\n");
            IfGenerator.Generate(sb, types, op, ("a", "b"), callback, intent + "    ");
            sb.Append($"{intent}}}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsForGenericGenerator
{
    /// <summary>Some documentation for SourceGenerator</summary>
    public static class SourceGenerator
    {
        /// <summary>Some documentation for SourceGenerator's method</summary>
        public static string Generate(Type[] types)
        {
            var sb = new StringBuilder();
            sb.Append("using System;\n\n");
            sb.Append("namespace OperatorsForGeneric\n");
            sb.Append("{\n\n");
            ClassGenerator.Generate(sb,
                types,
                "Addition",
                "+",
                ((string intent, string alreadyIf) ar) =>
                    ar.alreadyIf +
                    $"{ar.intent}else if (typeof(T) == typeof(String))\n" +
                    $"{ar.intent}    return (T)(object)String.Concat((string)(object)a, (string)(object)b);\n",
                "    "
            );

            var innerIntent = "    ";

            sb.Append("\n\n");
            ClassGenerator.Generate(sb,
                types,
                "Subtraction",
                "-",
                ((string intent, string alreadyIf) ar) => ar.alreadyIf,
                innerIntent
            );
            sb.Append("\n\n");
            ClassGenerator.Generate(sb,
                types,
                "Multiplication",
                "*",
                ((string intent, string alreadyIf) ar) => ar.alreadyIf,
                innerIntent
            );
            sb.Append("\n\n");
            ClassGenerator.Generate(sb,
                types,
                "Division",
                "/",
                ((string intent, string alreadyIf) ar) => ar.alreadyIf,
                innerIntent
            );
            sb.Append("\n}");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsForGenericGenerator
{
    public static class IfGenerator
    {
        public static void Generate(StringBuilder sb,
            Type[] types, string op, (string arg1, string arg2) args, 
            Func<(string intent, string alreadyIf), string> callback, string intent)
        {
            var spag = new TypeofSpaghettiGenerator(types);
            var gen = spag.Generate(intent + "    ", op, args);
            var res = callback((intent: intent + "    ", alreadyIf: gen));
            sb.Append($"{intent}public static T Do<T>(T {args.arg1}, T {args.arg2})\n{intent}{{\n");
            sb.Append(res);
            sb.Append($"{intent}    else\n" +
                      $"{intent}        return InnerStorage<T>.reflectionOperator(a, b);\n");
            sb.Append($"{intent}}}\n");
        }
    }
}

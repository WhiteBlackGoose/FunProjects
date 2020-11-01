using System;
using System.Text;

namespace OperatorsForGenericGenerator
{
    /// <summary>Some documentation for TypeofSpaghettiGenerator</summary>
    public sealed class TypeofSpaghettiGenerator
    {
        private readonly Type[] types;

        public TypeofSpaghettiGenerator(Type[] types)
        {
            this.types = types;
        }

        private void GenerateIf((StringBuilder sb, string intent) strInfo, Type type, string op, (string arg1, string arg2) args)
        {
            var (sb, intent) = strInfo;
            sb.Append($"if (typeof(T) == typeof({type.Name}))\n");
            var interType = "";
            if (type == typeof(Byte) || type == typeof(SByte))
                interType = $"(object)({type.Name})(Int32)"; // as arithmetic operations with bytes return int
            sb.Append(intent); sb.Append($"    return (T){interType}(object)(({type.Name})(object){args.arg1} {op} ({type.Name})(object){args.arg2});\n");
        }

        /// <summary>Some documentation for TypeofSpaghettiGenerator's method</summary>
        public string Generate(string intent, string op, (string arg1, string arg2) args)
        {
            var sb = new StringBuilder();
            sb.Append(intent);
            GenerateIf((sb, intent), types[0], op, args);
            for (int i = 1; i < types.Length; i++)
            {
                sb.Append(intent);
                sb.Append("else ");
                GenerateIf((sb, intent), types[i], op, args);
            }
            return sb.ToString();
        }
    }
}

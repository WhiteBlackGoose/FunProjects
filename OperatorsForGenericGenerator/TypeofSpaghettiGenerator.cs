using System;
using System.Text;

namespace OperatorsForGenericGenerator
{
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
            sb.Append(intent); sb.Append($"    return (T)(object)(({type.Name})(object){args.arg1} {op} ({type.Name})(object){args.arg2});\n");

        }

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

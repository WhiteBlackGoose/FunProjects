import time

MAX_STACK_LEN = 32


def add_line(to_add, tabs = 0):
    return "\n" + "    " * (tabs + 1) + to_add


def gen_struct(curr_len):
    res = add_line("public unsafe struct FastString" + str(curr_len) + " : IFastString")
    res += add_line("{")
    if curr_len > 0:
        res += add_line("internal fixed char letters[" + str(curr_len) + "];", 1)
    for i in range(MAX_STACK_LEN + 1):
        fut_len = curr_len + i
        fa1 = "FastString" + str(i)
        fa2 = "FastString" + str(curr_len)
        impl = "operator+(" + fa1 + " a, " + fa2 + " b)"
        if fut_len > MAX_STACK_LEN:
            res += add_line("public static FastStringInf" + " " + impl, 1)
        else:
            res += add_line("public static FastString" + str(i + curr_len) + " " + impl, 1)
        line = ""
        line += "=> "
        line += "Factory.Construct("
        toConnect = []
        for j in range(i):
            toConnect.append("a[" + str(j) + "]")
        for j in range(curr_len):
            toConnect.append("b[" + str(j) + "]")
        line += ", ".join(toConnect)
        res += add_line(line + ");", 2)

    res += add_line("public override string ToString()", 1)
    if curr_len > 0:
        res += add_line("{", 1)
        res += add_line("var res = \"\";", 2)
        res += add_line("for (int i = 0; i < " + str(curr_len) + "; i++)", 2)
        res += add_line("res += letters[i];", 3)
        res += add_line("return res;", 2)
        res += add_line("}", 1)
    else:
        res += add_line("=> \"\";", 2)

    if curr_len > 0:
        res += add_line("public char this[int id] => letters[id];", 1)
    else:
        res += add_line("public char this[int id] => throw new IndexOutOfRangeException();", 1)
    res += add_line("public int Length => " + str(curr_len) + ";", 1)
    res += add_line("}")
    return res


def gen_factory():
    res = add_line("public static class Factory")
    res += add_line("{")
    for i in range(MAX_STACK_LEN + 1):
        line = "public static unsafe FastString" + str(i) + " Construct("
        toConnect = []
        for j in range(i):
            toConnect.append("char s" + str(j))
        args = ", ".join(toConnect)
        line += args + ")"
        res += add_line(line, 1)
        res += add_line("{", 1)
        res += add_line("var res = new FastString" + str(i) + "();", 2)
        for j in range(i):
            res += add_line("res.letters[" + str(j) + "] = s" + str(j) + ";", 2)
        res += add_line("return res;", 2)
        res += add_line("}", 1)
    line = "public static FastStringInf Construct("
    toConnect = []
    for j in range(MAX_STACK_LEN + 1):
        toConnect.append("char s" + str(j))
    toConnect.append("params char[] ss")
    args = ", ".join(toConnect)
    line += args + ")"
    res += add_line(line, 1)
    res += add_line("{", 1)
    res += add_line("var res = new FastStringInf();", 2)
    res += add_line("res.letters = new char[" + str(MAX_STACK_LEN) + " + ss.Length + 1];", 2)
    for j in range(MAX_STACK_LEN + 1):
        res += add_line("res.letters[" + str(j) + "] = s" + str(j) + ";", 2)
    res += add_line("for (int i = 0; i < ss.Length; i++)", 2)
    res += add_line("res.letters[i + 1 + " + str(MAX_STACK_LEN) + "] = ss[i];", 3)
    res += add_line("return res;", 2)
    res += add_line("}", 1)
    res += add_line("}")
    return res


def gen_interface():
    d = '''
    public interface IFastString
    {
        char this[int id] { get; }
        int Length { get; }
    }
    '''
    return d


def gen_FastStringInf():
    d = '''
    public struct FastStringInf : IFastString
    {
        internal char[] letters;
        public static FastStringInf operator +(FastStringInf a, FastStringInf b)
        {
            var res = new FastStringInf();
            res.letters = new char[a.letters.Length + b.letters.Length];
            for (int i = 0; i < a.letters.Length; i++)
                res.letters[i] = a.letters[i];
            for (int i = 0; i < b.letters.Length; i++)
                res.letters[i + a.letters.Length] = b.letters[i];
            return res;
        }
        public char this[int id] => letters[id];
        public int Length => letters.Length;
        public override string ToString()
            => string.Join("", letters);
    }
    '''
    return d


full_code = "/*\n"
full_code += "  Version as of " + str(time.strftime("%c")) + "\n"
full_code += "*/\n\n"
full_code += "using System;\n\n\nnamespace FunStackStrings\n{"

full_code += gen_interface()
full_code += "\n" + gen_factory()
for i in range(MAX_STACK_LEN + 1):
    full_code += "\n" + gen_struct(i)
full_code += "\n" + gen_FastStringInf()

full_code += "\n}"

path = "./Impl.cs"
f = open(path, "wt")
f.write(full_code)
f.close()

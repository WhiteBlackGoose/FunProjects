# Fun projects

Fun stuff you can do in different programming languages.

## 1. Strings on stack

Complaining about strings being allocated on heap? We got a solution! Check FunStackStrings project, we
implemented strings on stack in C# without templates.

```cs
var hello = Factory.Construct('h', 'e', 'l', 'l', 'o');
var space = Factory.Construct(' ');
var world = Factory.Construct('w', 'o', 'r', 'l', 'd');
var user = Factory.Construct('u', 's', 'e', 'r');
var s = hello + space + world;
var f = s + space + hello + space + user;
Console.WriteLine(s);
Console.WriteLine(f);
Console.WriteLine(s + s + f);
Console.WriteLine($"Since f's type is {f.GetType().Name} its length is {f.Length}");
```

Output:

```
hello world
hello world hello user
hello worldhello worldhello world hello user
Since f's type is FastString22 its length is 22
```

You can set any maximum length of strings allocated on stack in the `code_generator.py` file and then
re-run it. For now it supports up to 32 letters on stack. Crazy!


## 2. Operators for Generic type

Fed up with C# that can't into templates? We got a solution! Use `Addition.Do` of two operands to invoke the
'+' operator!

```cs
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
```

Output:

```
9 abd (3, 10) x + 2
```

Subtraction, Division, and Multiplication are available as well.

## 3. Variadic number

```cs
VariadicNumber a = 5;
Console.WriteLine($"a = {a.ToString(true)} ; a / 2 = {a / 2}");
VariadicNumber b = 5.0;
Console.WriteLine($"b = {b.ToString(true)} ; b / 2 = {b / 2}");
```
Output:
```
a = int: 5 ; a / 2 = 2
b = double: 5 ; b / 2 = 2.5
```

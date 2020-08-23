# Fun projects

Fun stuff you can do in different programming languages.

### 1. Strings on stack

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
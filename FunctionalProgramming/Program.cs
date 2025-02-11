﻿
Operation mySum = Functions.Sum;
//Console.WriteLine(mySum(2, 3));
mySum = Functions.Mul;
//Console.WriteLine(mySum(2, 3));

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("hola mundo"); ;
//Functions.Some("Irene", "García", cw);


#region Action

string hi = "Hola";
Action<string> showMessage = Console.WriteLine;
Action<string, string> showMessage2 = (a, b) => {
    Console.WriteLine($"{hi} {a} {b}");
};
Action<string, string, string> showMessage3 = (a, b, c) => Console.WriteLine($"{a} {b} {c}");

/*
showMessage2("Irene", "García");
showMessage3("Irene", "García", "Dev");
Functions.SomeAction("Irene", "García", (a) =>
{
    Console.WriteLine("Soy una expresión lambda " + a);
});

Functions.SomeAction("Irene", "García", showMessage);
*/

#endregion


#region Func

Func<int> numberRandom = () => new Random().Next(0, 100);
Func<int, int> numberRandomLimit = (limit) => new Random().Next(0, limit);
Console.WriteLine(numberRandom());
Console.WriteLine(numberRandomLimit(10000));

#endregion


#region Predicate

Predicate<string> hasSpaceOrA = (word) => word.Contains(" ") || word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceOrA("beer"));
Console.WriteLine(hasSpaceOrA("hue co"));

var words = new List<string>()
{
    "beer", "patito", "sandia", "hola mundo", "c#"
};
var wordsNew = words.FindAll(hasSpaceOrA);
foreach(var word in wordsNew) Console.WriteLine(word);

var wordsNew2 = words.FindAll((w)=>!hasSpaceOrA((w)));

#endregion


// Las regiones solo ayudan a programar, como para ocultar código delimitar zonas
#region Delegados
delegate int Operation(int a, int b);
public delegate void Show(string message);
public delegate void Show2(string message, string message2);

#endregion

public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int num1, int num2) => num1 * num2;
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());
    
    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }

    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }
}
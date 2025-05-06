using System.Drawing;
using Pastel;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Calculator {

    public static int Add(int a, int b) {
        return a + b;
    }

    static void Main(string[] args) {
        Console.WriteLine("Hello, World!".Pastel(Color.Blue));

        int result = Add(5, 10);
        Console.WriteLine($"The result is: {result}".Pastel(Color.Green));
        Console.WriteLine("Press any key to exit...".Pastel(Color.Red));
        Console.ReadKey();
    }
}

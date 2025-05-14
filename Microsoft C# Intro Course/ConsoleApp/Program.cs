using System.Drawing;
using Pastel;
using System.Text.Json;
using System.Text.Json.Serialization;

// public class Calculator {

//     public static int Add(int a, int b) {
//         return a + b;
//     }

//     static void Main(string[] args) {
//         Console.WriteLine("Hello, World!".Pastel(Color.Blue));

//         int result = Add(5, 10);
//         Console.WriteLine($"The result is: {result}".Pastel(Color.Green));
//         Console.WriteLine("Press any key to exit...".Pastel(Color.Red));
//         Console.ReadKey();
//     }
// }

// public class NumberDisplay {
//     public static void DisplayNumbers() {
//         for (int i = 1;i <= 10; i++) {
//             Console.WriteLine(i.ToString().Pastel(Color.Yellow));
//         }
//     }

//     static void Main(string[] args) {
//         DisplayNumbers();
//         Console.WriteLine("Press any key to exit...".Pastel(Color.Red));
//         Console.ReadKey();
//     }
// }

// public class UserInput {
//     static void Greetings() {
//         Console.WriteLine("Enter your name: ".Pastel(Color.Blue));
//         string name = Console.ReadLine();
//         Console.WriteLine($"Hello, {name}!".Pastel(Color.Green));
//     }
// }


// public class ToDoList {
//     public static string[] tasks = new string[10];
    
//     public static int taskCount = 0;

//     public static void AddTask(string task) {
//         Console.WriteLine("Enter a new task:");
//         tasks[taskCount] = Console.ReadLine();
//         taskCount++;
//     }

//     public static void TaskCompleted() {
//         Console.WriteLine("Task completed: ".Pastel(Color.Blue));
//         string task = Console.ReadLine();
//         taskCount--;
//     }

//         public static void ViewTasks()
//     {
//         for (int i = 0; i < taskCount; i++)
//         {
//             Console.WriteLine((i + 1) + ". " + tasks[i]);
//         }
//     }

//         public static void CompleteTask()
//     {
//         Console.WriteLine("Enter the number of the task to mark as complete:");
//         int taskNumber = int.Parse(Console.ReadLine()) - 1;

//         if (taskNumber >= 0 && taskNumber < taskCount)
//         {
//             tasks[taskNumber] = tasks[taskNumber] + " (Completed)";
//             Console.WriteLine("Task marked as complete.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid task number.");
//         }
//     }
// }

// public class Database
// {
//     private static Database instance;
//     private static readonly object lockObject = new object();

//     // Private constructor prevents instantiation from other classes
//     private Database() { }

//     public static Database GetInstance()
//     {
//         if (instance == null)
//         {
//             lock (lockObject)
//             {
//                 if (instance == null)
//                 {
//                     instance = new Database();
//                 }
//             }
//         }
//         return instance;
//     }

//     public void Connect()
//     {
//         Console.WriteLine("Database connected.");
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Database db1 = Database.GetInstance();
//         Database db2 = Database.GetInstance();

//         db1.Connect();
//         Console.WriteLine(object.ReferenceEquals(db1, db2)); // Outputs: True
//     }
// }

// Target interface
// public interface ITarget
// {
//     void Request();
// }

// // Adaptee class
// public class Adaptee
// {
//     public void SpecificRequest()
//     {
//         Console.WriteLine("Specific request is called.");
//     }
// }

// // Adapter class
// public class Adapter : ITarget
// {
//     private Adaptee adaptee;

//     public Adapter(Adaptee adaptee)
//     {
//         this.adaptee = adaptee;
//     }

//     public void Request()
//     {
//         // Convert the interface of Adaptee to the Target interface
//         adaptee.SpecificRequest();
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Adaptee adaptee = new Adaptee();
//         ITarget target = new Adapter(adaptee);

//         target.Request(); // Outputs: Specific request is called.
//     }
// }

// public abstract class Animal
// {
//     public abstract void Speak();
// }

// public class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Woof!");
//     }
// }

// public class Cat : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Meow!");
//     }
// }

// public class AnimalFactory
// {
//     public static Animal CreateAnimal(string type)
//     {
//         if (type == "Dog")
//         {
//             return new Dog();
//         }
//         else if (type == "Cat")
//         {
//             return new Cat();
//         }
//         else
//         {
//             throw new ArgumentException("Invalid animal type");
//         }
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Animal dog = AnimalFactory.CreateAnimal("Dog");
//         dog.Speak(); // Outputs: Woof!

//         Animal cat = AnimalFactory.CreateAnimal("Cat");
//         cat.Speak(); // Outputs: Meow!
//     }
// }
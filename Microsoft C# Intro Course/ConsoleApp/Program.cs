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

// public interface IObserver
// {
//     void Update(string message);
// }

// public class ConcreteObserver : IObserver
// {
//     private string name;

//     public ConcreteObserver(string name)
//     {
//         this.name = name;
//     }

//     public void Update(string message)
//     {
//         Console.WriteLine($"{name} received message: {message}");
//     }
// }

// public class Subject
// {
//     private List<IObserver> observers = new List<IObserver>();

//     public void Attach(IObserver observer)
//     {
//         observers.Add(observer);
//     }

//     public void Detach(IObserver observer)
//     {
//         observers.Remove(observer);
//     }

//     public void Notify(string message)
//     {
//         foreach (var observer in observers)
//         {
//             observer.Update(message);
//         }
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Subject subject = new Subject();

//         IObserver observer1 = new ConcreteObserver("Observer 1");
//         IObserver observer2 = new ConcreteObserver("Observer 2");

//         subject.Attach(observer1);
//         subject.Attach(observer2);

//         subject.Notify("Hello, Observers!"); // Outputs: "Observer 1 received message: Hello, Observers!"
//                                             //          "Observer 2 received message: Hello, Observers!"
//     }
// }


// public class Person
// {
//     // Define the Name property
//     public string Name { get; set; }

//     // Define the Age property
//     public int Age { get; set; }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create the first Person object
//         Person friend = new Person();
//         friend.Name = "John Doe";
//         friend.Age = 30;

//         // Create the second Person object
//         Person colleague = new Person();
//         colleague.Name = "Jane Smith";
//         colleague.Age = 25;
//     }
// }


// public class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     // Define the Greet method
//     public void Greet()
//     {
//         Console.WriteLine("Hello, my name is " + Name);
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create the first Person object
//         Person friend = new Person();
//         friend.Name = "John Doe";
//         friend.Age = 30;

//         // Create the second Person object
//         Person colleague = new Person();
//         colleague.Name = "Jane Smith";
//         colleague.Age = 25;

//         // Call the Greet method on each object
//         friend.Greet(); // Output: Hello, my name is John Doe
//         colleague.Greet(); // Output: Hello, my name is Jane Smith
//     }
// }



// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create the first Person object
//         Person friend = new Person();
//         friend.Name = "John Doe";
//         friend.Age = 30;

//         // Create the second Person object
//         Person colleague = new Person();
//         colleague.Name = "Jane Smith";
//         colleague.Age = 25;

//         // Create the third Person object
//         Person newPerson = new Person();
//         newPerson.Name = "Mike Johnson";
//         newPerson.Age = 35;

//         // Call the Greet method on each object
//         friend.Greet(); // Output: Hello, my name is John Doe
//         colleague.Greet(); // Output: Hello, my name is Jane Smith
//         newPerson.Greet(); // Output: Hello, my name is Mike Johnson
//     }
// }

// public class Program {
//     public async Task DownloadDataAsync()
//     {
//         Console.WriteLine("Downloading data...");
//         await Task.Delay(3000);
//         Console.WriteLine("Download complete.");
//     }
// }

// public class Program
// {
//     public virtual async Task DownloadDataAsync()
//     {
//         Console.WriteLine("Downloading data...");
//         await Task.Delay(3000);
//         Console.WriteLine("Download complete.");
//     }
//     public virtual async Task Main(string[] args)
//     {
//         Program program = new Program();
//         await program.DownloadDataAsync();
//     }
// }


// public class Program
// {
//     public async Task DownloadDataAsync()
//     {
//         Console.WriteLine("Downloading data...");
//         await Task.Delay(3000);
//         Console.WriteLine("Download complete.");
//     }
//     public async Task DownloadDataAsync2()
//     {
//         Console.WriteLine("Downloading data...");
//         await Task.Delay(2000);
//         Console.WriteLine("Download complete.");
//     }

//     public virtual async Task Main(string[] args)
//     {
//         Program program = new Program();
//         Task task1 = program.DownloadDataAsync();
//         Task task2 = program.DownloadDataAsync2();
//         await Task.WhenAll(task1, task2);
//         Console.WriteLine("All downloads complete.");
//     }
// }

// public class Program
// {
	
//     public async Task DownloadDataAsync()
//     {
//         try
//         {
//             Console.WriteLine("Download started...");
//             throw new InvalidOperationException("Simulated download error.");
//             await Task.Delay(3000);
//             Console.WriteLine("Download completed.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("An error occurred: " + ex.Message);
//         }
//     }

//     public async Task DownloadDataAsync2()
//     {
//         Console.WriteLine("Download 2 started...");
//         await Task.Delay(2000);
//         Console.WriteLine("Download 2 completed.");
//     }

//     public static async Task Main(string[] args)
//     {
//         Program program = new Program();
//         Task task1 = program.DownloadDataAsync();
//         Task task2 = program.DownloadDataAsync2();
//         await Task.WhenAll(task1, task2);
//         Console.WriteLine("All downloads completed.");
//     }
// }
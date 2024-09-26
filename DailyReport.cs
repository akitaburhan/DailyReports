using System;

class Program
{
    static void Main()
    {
        // Print the header information for the Daily Report
        Console.WriteLine("Academy of Learning Career College");  // Printing the name of the institution
        Console.WriteLine("Student Daily Report.");  // Printing the report title

        // Asking for and saving user input data
        Console.Write("What is your name? ");
        string name = Console.ReadLine();  // Asking the student's name and storing it in the 'name' variable

        Console.Write("What course are you on? ");
        string course = Console.ReadLine();  // Asking which course the student is on and storing it in 'course' variable

        Console.Write("What page number are you on? ");
        int pageNumber = int.Parse(Console.ReadLine());  // Asking for the current page number and converting it to an integer

        Console.Write("Do you need help with anything? Please answer 'true' or 'false': ");
        bool needHelp = bool.Parse(Console.ReadLine());  // Asking if help is needed and storing it as a boolean

        // Asking about any positive experiences
        Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
        string positiveExperience = Console.ReadLine();

        // Asking for any other feedback
        Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
        string feedback = Console.ReadLine();

        // Asking how many hours the student studied
        Console.Write("How many hours did you study today? ");
        double hoursStudied = double.Parse(Console.ReadLine());  // Storing the study hours as a double

        // Thanking the student and ending the program
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");  // Program end message
    }
}
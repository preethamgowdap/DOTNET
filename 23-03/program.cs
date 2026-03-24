using System;

 public class UnderageException : Exception
    {
        public UnderageException(String message) : base(message)
         {

          }
    }
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckAge(age);
        }
        catch (UnderageException ex)
        {
            Console.WriteLine($"Access Denied: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("Validation check complete.");
        }
    }

    static void CheckAge(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            throw new UnderageException("You must be 18 or older to proceed.");
        }
    }
}

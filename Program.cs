namespace Variables_and_Data_Types;

class Program
{
    static void Main(string[] args)
    {
       int thisyear = DateTime.Now.Year;
       int age;
       int birthyear;

       Console.WriteLine("Please enter your birthyear");
       birthyear = Convert.ToInt32(Console.ReadLine());
       age = thisyear - birthyear;
       Console.WriteLine("Your age: " + age);

       if (age <= 18) {
        Console.WriteLine("You are not of legal age");
       }
       else{
        Console.WriteLine("You are legal age");
       }
    }
}

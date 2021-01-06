using Simple_OfficeEchosystem.Models;
using System;

namespace Simple_OfficeEchosystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            Docter docter = new Docter();

            Console.WriteLine("enter name of patient:");
            patient.Setname(Console.ReadLine());
            Console.WriteLine("enter family of patient:");
            patient.Setfamily(Console.ReadLine());
            Console.WriteLine("enter your date of birth");
            patient.Setdateofbirth(int.Parse(Console.ReadLine()));
            Console.WriteLine("say what is your problem");
            patient.Setsickness(Console.ReadLine());


            Console.WriteLine("what docter do you want - write that fullname:");
            docter.Setname(Console.ReadLine());

            Console.WriteLine("What is That major:");
            docter.Setmajor(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(patient.Getname()+" have "+patient.Getsickness()+"  and that have "+patient.GetAge()+" years old" );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(patient.Getname()+" visited by Dr."+docter.Getname()+" this docter have "+docter.Getmajor()+" sience.\n");
            Console.ResetColor();
        }


    }
}

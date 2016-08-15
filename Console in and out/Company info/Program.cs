using System;

namespace Company_info
{
    class Program
    {
        static void Main(string[] args)
        {
            string teler = Console.ReadLine();
            string adress = Console.ReadLine();
            string pnumber = Console.ReadLine();
            string fnumber = Console.ReadLine();
            string web =Console.ReadLine();            
            string mfn =Console.ReadLine();
            string mln = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            string mphone = Console.ReadLine();

            

            Console.WriteLine(teler);
            Console.WriteLine("Address: " + adress);
            Console.WriteLine("Tel. " + pnumber);
            if (fnumber == String.Empty)
            {
                fnumber = "Fax: (no fax)";
                Console.WriteLine(fnumber);
            }
            else
            {
                Console.WriteLine("Fax: {0}", fnumber);
            }
            Console.WriteLine("Web site: " + web);
            Console.WriteLine("Manager: "+mfn+" "+mln+" (age: "+age+", tel. "+mphone+")");
            

            
        }
    }
}

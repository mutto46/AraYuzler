using AraYuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraYuzler
{
    interface IOku
    {
        void Oku();
    }
   
    public class Kitap : IOku
    {
        public void Oku()
        {
            Console.WriteLine("Kitap:Okundu");
        }
    }
    public class Dergi : IOku
    {
        public void Oku()
        {
            Console.WriteLine("Dergi:Okundu");
        }
    }
    public class Ansiklopedi : IOku
    {
        public void Oku()
        {
            Console.WriteLine("Ansiklopedi:Okundu");
        }
    }

}

    internal class Program
    {
        static void Main(string[] args)
        {
        Kitap kitap = new Kitap();
        kitap.Oku();
        Dergi dergi = new Dergi();
        dergi.Oku();
        Ansiklopedi ansiklopedi = new Ansiklopedi();
        ansiklopedi.Oku();

            
        }
    }


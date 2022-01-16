using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Name = "Кошка";
            Console.WriteLine("Введите Кошка или Собака");
            Name = Console.ReadLine();
            Animal say = new Animal(Name);
            Console.WriteLine(say.Say());
            Main(args);
        }

        abstract public class AbstractAnimal
        {
            public abstract string Name { set; get; }
            public string say { set; get; }
            public abstract string Say();
        }

        public class Animal : AbstractAnimal
        {
            public override string Name { set; get; }
            public Animal(string name)
            {
                this.Name = name;
            }
            public override string Say()
            {
                if (Name == "Кошка")
                {
                    say = "Мяу";
                }
                else
                {
                    say = "Гав";
                }
                return string.Format("{0}", say);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat Murka = new Cat();
            Murka.ShowInfo();            
            Console.WriteLine();
            Dog Rex = new Dog();
            Rex.ShowInfo();
            Console.ReadKey();
        }



    }
        abstract class Animal
        {
        

        public abstract string animalName { get; set; }        
        
        
        public abstract string Say();
        
        public virtual void ShowInfo()
        {
           
            
        }
        public Animal ()

        {
            
        }
        }
    class Cat : Animal

    {
        public string catName = "кошка";
        public override string animalName

        {
            get { return catName; }
            set { catName = value; }

        }
        public Cat ()
        {
            
        }
        public string CatSay ="Мяу";
        
        public override string Say()
        {
            return CatSay;
        }
        public override void ShowInfo()
        {
            Console.WriteLine(animalName);
            Console.WriteLine(Say());
        }
    }

    class Dog : Animal

    {
        private string dogName = "собака";
        public override string animalName

        {
            get { return dogName; }
            set { dogName = value; }

        }
        public Dog()
        {
           
        }
        public string DogSay = "Гав";

        public override string Say()
        {
            return DogSay;
        }
        public override void ShowInfo()
        {
            Console.WriteLine(animalName);
            Console.WriteLine(Say());
        }
    }







}

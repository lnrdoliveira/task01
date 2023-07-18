using System;
using System.Globalization;
using task01;

class Program{
    static void Main(String[] args){
        Person firstPerson, secondPerson;
        firstPerson = new Person();
        secondPerson = new Person();

        System.Console.WriteLine("Infos about first person: ");
        System.Console.Write("Name: ");
        firstPerson.Name = Console.ReadLine();
        System.Console.Write("Age: ");
        firstPerson.Age = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Infos about second person: ");
        System.Console.Write("Name: ");
        secondPerson.Name = Console.ReadLine();
        System.Console.Write("Age: ");
        secondPerson.Age = int.Parse(Console.ReadLine());

        if(firstPerson.Age > secondPerson.Age){
            System.Console.WriteLine("Older person: "+firstPerson.Name);
        }
        else if(secondPerson.Age > firstPerson.Age){
            System.Console.WriteLine("Older person: "+secondPerson.Name);
        }
        else {
            System.Console.WriteLine("Both people are the same age.");
        }
    }
}
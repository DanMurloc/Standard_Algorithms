using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Algorithms
{
    //Фабричный патерн

    /*
     Когда надо применять паттерн
        Когда заранее неизвестно, объекты каких типов необходимо создавать
        Когда система должна быть независимой от процесса создания новых объектов и расширяемой: в нее можно легко вводить новые классы, объекты которых система должна создавать.
        Когда создание новых объектов необходимо делегировать из базового класса классам наследникам
    */

    abstract class Product
    { }

    class ConcreteProductA : Product
    { }

    class ConcreteProductB : Product
    { }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }

    // абстрактный класс строительной компании
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public House Create();
    }
    // строит панельные дома
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
    // строит деревянные дома
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House
    { }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}

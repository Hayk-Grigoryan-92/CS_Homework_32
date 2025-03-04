using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 9
            //ItemManager<double> itemManager = new ItemManager<double>();
            //itemManager.AddItem(1.5);
            //itemManager.AddItem(2.3);
            //itemManager.AddItem(4.1);
            //itemManager.RemoveItem(2.3);
            //Console.WriteLine(itemManager.Count());

        }
    }
    //-------   1   --------------------
    interface IAnimal
    {
        void MakeSound();
        void Move();
    }

    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Make Dog sound");
        }
        public void Move()
        {
            Console.WriteLine("Dog is moving");
        }
    }

    class Bird : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Make Bird sound");
        }
        public void Move()
        {
            Console.WriteLine("Bird is flying");
        }
    }
    //---------     2   --------------------

    interface ISwimmer
    {
        void Swim();
    }

    interface IFlyer
    {
        void Fly();
    }

    class Duck : ISwimmer, IFlyer
    {
        public void Swim()
        {
            Console.WriteLine("Duck is swimming");
        }
        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }
    }

    //--------      3   -----------------------

    interface IContainer<T>
    {
        void Add(T item);
        T GetItem(int index);
    }

    class MyList<T> : IContainer<T>
    {
        List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }

        public T GetItem(int index)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == index)
                {
                    return list[i];
                }
            }
            return default(T);
        }
    }

    //-------   4   -----------------------------

    interface IShape
    {
        double CalculateArrea();
        void Display();
    }

    class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArrea()
        {
            return Math.PI * Radius * Radius;
        }

        public void Display()
        {
            Console.WriteLine($"Your Circle arrea is : {CalculateArrea()}");
        }
    }

    class Rectangle : IShape
    {
        private double _width;
        public double Widtth { get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }

        private double _heght;
        public double Height
        {
            get
            {
                return _heght;
            }
            set
            {
                if (value > 0)
                {
                    _heght = value;
                }
            }
        }

        public Rectangle(double width, double heght)
        {
            Widtth = width;
            Height = heght;
        }

        public double CalculateArrea()
        {
            return Widtth * Height;
        }

        public void Display()
        {
            Console.WriteLine($"Your Recatngle arrea is : {CalculateArrea()}");
        }
    }

    //-------   5   --------------------

    interface IComparer<T>
    {
        int Compare(T item1, T item2);
    }

    class NumberComparer : IComparer<int>
    {
        public int Compare(int item1, int item2)
        {
            if (item1 > item2) return 1;
            if (item1 < item2) return -1;
            return 0;
        }
    }

    class StringComparer : IComparer<string>
    {
        public int Compare(string item1, string item2)
        {
            if (item1.Length > item2.Length) return 1;
            if (item1.Length < item2.Length) return -1;
            return 0;
        }
    }

    //----------    6   ---------------------

    interface IWorker
    {
        void Work();
        void TakeBreak();
    }

    class HumanWorker : IWorker
    {
        public void TakeBreak()
        {
            Console.WriteLine("Human is resting");
        }

        public void Work()
        {
            Console.WriteLine("Human is working hard");
        }
    }

    class RobotWorker : IWorker
    {
        public void TakeBreak()
        {
            Console.WriteLine("Robot does not need a break");
        }

        public void Work()
        {
            Console.WriteLine("Robot is processing data");
        }
    }
    //--------      7   ------------------------

    interface IProcessor<T>
    {
        T Process(T data);
    }

    class StringProcessor : IProcessor<string>
    {
        public string Process(string data)
        {
            return data.ToUpper();
        }
    }

    class NumberProcessor : IProcessor<int>
    {
        public int Process(int data)
        {
            return data * 2;
        }
    }

    //----------    8   ---------------------

    interface IFilter
    {
        string ApplyFilter(string text);
    }

    class UppercaseFilter : IFilter
    {
        public string ApplyFilter(string text)
        {
            return text.ToUpper();
        }
    }

    class ReverseFilter : IFilter
    {
        public string ApplyFilter(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    //-------       9   ----------------

    interface IManager<T>
    {
        void AddItem(T item);
        void RemoveItem(T item);

        int Count();
    }

    class ItemManager<T> : IManager<T>
    {

        List<T> List = new List<T>();
        public void AddItem(T item)
        {
            List.Add(item);
        }

        public int Count()
        {
            return List.Count;
        }

        public void RemoveItem(T item)
        {
            List.Remove(item);
        }
    }
    //-----------   10  ----------------
    interface ICharacter
    {
        void Attack();
        void Defend();
    }

    class Warrior : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Warrior swings sword");
        }

        public void Defend()
        {
            Console.WriteLine("Warrior raises shield");
        }
    }

    class Mage : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Mage casts fireball");
        }

        public void Defend()
        {
            Console.WriteLine("Mage creates magic barrier");
        }
    }
}

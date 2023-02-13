using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    #region Четвертое Задание 
    abstract class Figyra
    {
        virtual public int Square() { return 0; }
    }
    class Rectangle : Figyra
    {
        public int IIIirina { get; set; }
        public int Visota { get; set; }
        public Rectangle(int irina, int visota)
        {
            IIIirina = irina;
            Visota = visota;
        }
        public Rectangle() : this(0, 0) { }
        public override int Square()
        {
            return IIIirina * Visota;
        }
    }
    class Circle : Figyra
    {
        public int Radiys { get; set; }
        public Circle(int Radius)
        {
            Radiys = Radius;
        }
        public Circle() : this(0) { }
        public override int Square()
        {
            return Radiys * 3;
        }
    }

    class RightTriangle : Figyra
    {
        public int IIIirina { get; set; }
        public int Visota { get; set; }
        public RightTriangle(int irina, int visota)
        {
            IIIirina = irina;
            Visota = visota;
        }
        public RightTriangle() : this(0, 0) { }
        public override int Square()
        {
            return ((IIIirina * Visota) / 2);
        }
    }
    class Trapeze : Figyra
    {
        public int IIIirina_Verh { get; set; }
        public int IIIirina_Vniz { get; set; }
        public int Razmer { get; set; }
        public Trapeze(int irina_Verh, int irina_Vniz, int razmer)
        {
            IIIirina_Verh = irina_Verh;
            IIIirina_Vniz = irina_Vniz;
            Razmer = razmer;
        }
        public Trapeze() : this(0, 0, 0) { }
        public override int Square()
        {
            int buf = IIIirina_Vniz - IIIirina_Verh;
            if (buf < 0)
                buf *= -1;
            buf /= 2;
            buf = Convert.ToInt32(Math.Sqrt(Math.Pow(5, 2) - Math.Pow(buf, 2)));
            return (IIIirina_Vniz + IIIirina_Verh) / 2 * buf;
        }
    }











    #endregion 

    #region Третье Задание.
    class Zver
    {
        public string ImyaZverya { get; set; }
        public int Vozrast { get; set; }
        public int Skorost { get; set; }
        public Zver(string imyazverya, int vozrast, int skorost)
        {
            ImyaZverya = imyazverya;
            Vozrast = vozrast;
            Skorost = skorost;
        }
        public Zver() : this("", 0, 0) { }
        public void Print()
        {
            Console.WriteLine($" Животное  {ImyaZverya}\n Возраст  {Vozrast}\n Скорость  {Skorost}");
        }
    }

    class Tigr: Zver
    {
        public int Razmer { get; set; }
        public Tigr (int razmer, int vozrast, int skorost) : base("Tiger", vozrast, skorost)
        {
            Razmer = razmer;
        }
        public Tigr() : this(0, 0, 0) { }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Razmer: {Razmer} sm");
        }
    }
    class Crocodil : Zver
    {
        public int Dlina { get; set; }
        public Crocodil(int dlina, int vozrast, int skorost) : base("Crocodil", vozrast, skorost)
        {
            Dlina = dlina;
        }
        public Crocodil() : this(0, 0, 0) { }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($" Dlina {Dlina} cm");
        }
    }
    class Kengoro : Zver
    {
        public int Prijok { get; set; }
        public Kengoro(int prijok, int vozrast, int skorost) : base("Kengoro", vozrast, skorost)
        {
            Prijok = prijok;
        }
        public Kengoro() : this(0, 0, 0) { }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($" Prijok {Prijok} cm");
        }
    }
}

    #endregion

    #region Второе задание 
    class Pass
    {
        public string Polnoe_FIO { get; set; }
        public string Den_Rojdenie { get; set; }
        public string Nationalnost { get; set; }
        public string ID { get; set; }
        public Pass(string polnoe_FIO, string den_Rojdenie, string nationalist, string iD)
        {
            Polnoe_FIO = polnoe_FIO;
            Den_Rojdenie = den_Rojdenie;
            Nationalnost = nationalist;
            ID = iD;
        }
        public Pass() : this("", "", "", "") { }
        public void Print()
        {
            Console.WriteLine($" Полное ФИО : {Polnoe_FIO}\n День рождения {Den_Rojdenie}\n Национальность   {Nationalnost}\nID Картка {ID}");
        }
    }
    class ZagranPass : Pass
    {
        public string Vvod_Daty { get; set; }
        public string Vivod_Daty { get; set; }
        public string Tip { get; set; }
        public ZagranPass(string vod_Daty, string vivod_Daty, string tip,
            string polnoe_FIO, string den_Rojdenie, string nationalist, string iD) : base(polnoe_FIO, polnoe_FIO, nationalist, iD)
        {
            Vvod_Daty = vod_Daty;
            Vivod_Daty = vivod_Daty;
            Tip = tip;
        }
        public ZagranPass() : this("", "", "", "", "", "", "") { }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($" Vvod daty  {Vvod_Daty}\n vivod daty {Vivod_Daty}\n Tip {Tip}");
        }
    }
    #endregion

    #region Первое задание 
    class Human
    {
        public string Imya { get; set; }
        public int Vozrast { get; set; }
        public Human(string say_my_name, int age)
        {
            Imya = say_my_name;
            Vozrast = age;
        }
        public Human() : this("", 0)
        { }

        public Human(string imya) : this(imya, 0)
        { }
        public void Show()
        {
            Console.WriteLine($" Name  {Imya}\n Age {Vozrast}");
        }
    }

    class Builder : Human
    {
        public string companiya{ get; set; }
        public Builder(string company, string name, int age) : base(name, age)
        {
            companiya = company;
        }
        public Builder() : this("", "", 0)
        { }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($" Company {companiya}");
        }

    }

    class Sailor : Human
    {
        public string Imya_Koroblya { get; set; }
        public Sailor(string imya, string name, int age) : base(name, age)
        {
            Imya_Koroblya = imya;
        }
        public Sailor() : this("", "", 0)
        { }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($" Name ship {Imya_Koroblya}");
        }
    }

    class Pilot : Human
    {
        public int Distance { get; set; }
        public Pilot(int distance, string name, int age) : base(name, age)
        {
            Distance = distance;
        }
        public Pilot() : this(0, "", 0) { }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($" Distance Kilometr {Distance} км");
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
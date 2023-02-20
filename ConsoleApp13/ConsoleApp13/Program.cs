using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    delegate void Del();
    class Card
    {
        public event Del ev;
        public int number { get; set; }
        public string FIO { get; set; }
        public int deadline { get; set; }
        public int PIN { get; set; }
        public int limit { get; set; }
        public int sum { get; set; }

        public void show()
        {
            Console.WriteLine($"Номер карты: {number}\n ФИО: {FIO}\n Срок действия карты: {deadline}\n PIN: {PIN}\n Кредитный лимит: {limit}\n Сумма денег: {sum}\n");
        }
        public override string ToString()
        {
            return $"Номер карты: {number}\n ФИО: {FIO}\n Срок действия карты: {deadline}\n PIN: {PIN}\n Кредитный лимит: {limit}\n Сумма денег: {sum}\n";
        }

        public void Refill()
        {
            Console.WriteLine("\nпополнения счета");
            ev.Invoke();
        }
        public void event1()
        {
            Console.WriteLine("Введите номер карты для поплнения счета: ");
            number = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            Console.WriteLine("Введите сумму для поплнения счета: ");
            s = Convert.ToInt32(Console.ReadLine());
        }


        public void consumption()
        {
            Console.WriteLine("\nРасход денег со счета");
            ev.Invoke();
        }
        public void event2()
        {
            Console.WriteLine("Введите PIN: ");
            PIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рассходы: ");
            int r = 0;
            r = Convert.ToInt32(Console.ReadLine());
        }


        public void start()
        {
            Console.WriteLine("\nСтарт использования кредитных денег ");
            ev.Invoke();
        }
        public void event3()
        {
            Console.WriteLine("Введите PIN: ");
            PIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите желаемую сумму: ");
            int q = 0;
            q = Convert.ToInt32(Console.ReadLine());
        }


        public void achievement()
        {
            Console.WriteLine("\nДостижение заданной суммы денег ");
            ev.Invoke();
        }
        public void event4()
        {
            Console.WriteLine("Введите номер карты для поплнения счета: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите желаемую сумму: ");
            int u = 0;
            u = Convert.ToInt32(Console.ReadLine());
        }


        public void newpin()
        {
            Console.WriteLine("\nСмена пин-кода ");
            ev.Invoke();
        }
        public void event5()
        {
            Console.WriteLine("Введите PIN: ");
            PIN = Convert.ToInt32(Console.ReadLine());
            int ne = 0;
            Console.WriteLine("Введите новый PIN: ");
            ne = Convert.ToInt32(Console.ReadLine());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Card s = new Card();

            s.ev += new Del(s.event1);
            s.Refill();
            s.ev -= s.event1;

            s.ev += new Del(s.event2);
            s.consumption();
            s.ev -= s.event2;

            s.ev += new Del(s.event3);
            s.start();
            s.ev -= s.event3;

            s.ev += new Del(s.event4);
            s.achievement();
            s.ev -= s.event4;

            s.ev += new Del(s.event5);
            s.newpin();
            s.ev -= s.event5;

            s.show();
        }
    }

}

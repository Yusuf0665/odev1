using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
//uygulama1
Console.WriteLine(48 / 6 / 4);//2
Console.WriteLine(24 / 3 * 2);//16
Console.WriteLine(22 + 5 - 1 + 4);//30
Console.WriteLine((7 + 4) * 2 - 1 + 8 / 2);//25
Console.WriteLine((5 - 1) * 2 - 1 + 7^2 / 2);//15??
*/

/*
//uygulama2
//x=20,y=13,z=42
int x, y, z;
x = 20;
y = 13;
z = 42;
Console.WriteLine(23 == 55 && 76 > 45 && 5 < 12);//F
Console.WriteLine(23 >= 23 && 45 != 18);//T
Console.WriteLine(x > y && z == y && z < x);//F
Console.WriteLine(x != z || y <= z);//T
*/


/*
//uygulama3 == Girilen iki sayinin biri birine tam bölünüp bölünemedigini bulan programi yaziniz.
namespace IkiSayininBolunmesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; // “a”, “b”, “c” tanımlanması
            // “a” ve “b”nin değerlerinin girilmesi
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            // Büyük sayının a'ya alınması
            if (a < b)
            {
                c = a; // “a”nın değerinin “c”de saklanması
                a = b; // “b”nin değeri “a”ya atanması
                b = c; // “c”de Saklanan değerinin “b”ye aktarılması
            }
            // Sonucun yazdırılması
            if (a % b == 0)
                Console.WriteLine("bolunebilir");
            else Console.WriteLine("bolunmez");
            Console.ReadLine();
        }
    }
}
*/



/*
//uygulama4 == gg.aa.yyyy formatinda girilen tarih bilgisinden hangi ayda oldugumuzu gösteren programi yaziniz.
DateTime tarih;
tarih  = DateTime.Now;
Console.WriteLine(tarih.ToString());

int ay = DateTime.Now.Month;
Console.WriteLine(ay.ToString());
*/


/*
//uygulama5 == ikinci dereceden denklem köklerini bulan programı yazınız.
namespace İkinciDereceDenklem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta,x, x1, x2;

            Console.Write("a değerini giriniz:");
            a = int.Parse(Console.ReadLine());

            Console.Write("b değerini giriniz:");
            b = int.Parse(Console.ReadLine());

            Console.Write("c değerini giriniz:");
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                Console.Write("Kökler eşit");
                x = (((-1) * b )/ (2 * a));
                Console.WriteLine(" ve değeri: x={0}", x);

            }
            else if (delta < 0)
            {
                Console.WriteLine("Kökler reel değil");
            }
            else
            {
                x1 = ((-1) * b - Math.Sqrt(delta)) / (2 * a);
                x2 = ((-1) * b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
        }
    }
}
*/


/*
//uygulama6 == Girilen bir derece değerini radyan ve gradyan değerine çeviren program.
namespace dmg
{

    class Program
    {

        static void Main(string[] args)
        {

            int d;
            double r, g;
            double pi = 3.14;

            Console.WriteLine("Açıyı giriniz = ");
            d = Convert.ToInt32(Console.ReadLine());

            r = Convert.ToDouble((d * pi) / 180);
            g = Convert.ToDouble(d * 200) / 180;

            Console.WriteLine("Radyan = " + r);
            Console.WriteLine("Grad = " + g);
            Console.ReadKey();

        }

    }

}
*/
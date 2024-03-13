using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Buoi3
{
    public class bt1
    {
        public void bai1()
        {
            Console.WriteLine("Nhap vao thang va nam can kiem tra");
            Console.Write("Thang: ");
            int thang =  int.Parse(Console.ReadLine());
            Console.Write("Nam: ");
            int nam = int.Parse(Console.ReadLine());
            int SoNgay = DateTime.DaysInMonth(nam, thang);
            Console.WriteLine("Thang {0} nam {1} co {2} ngay.", thang, nam, SoNgay);
        }
    }

    public class bt2
    {
        public void bai2()
        {
            Console.WriteLine("Vui long nhap vao ngay thang nam (dd/MM/yyyy: ");
            String ngay = Console.ReadLine();

            DateTime parsedDate;

            if (DateTime.TryParseExact(ngay,"dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine("Chuoi nhap vao co dinh dang ngay thang nam (dd/MM/yyyy) hop le.");

            }
            else
            {
                Console.WriteLine("Chuoi nhap vao co dinh dang khong hop le.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bt1 bt1 = new bt1();
            bt2 bt2 = new bt2();
            bt1.bai1();
            bt2.bai2();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelasKaryawan
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            string nama, nip, status;
            int masa, tunjangannikah = 0, gaji, kenaikangaji = 0, gajiakhir;

            Console.WriteLine("\t\t\tMenghitung Gaji Karyawan\t\t\t");
            Console.WriteLine("\t\t\t________________________\t\t\t");
            Console.WriteLine(" ");
            Console.Write("Masukan Nama                    : ");
            nama = Console.ReadLine();
            Console.Write("Masukan Nip                     : ");
            nip = Console.ReadLine();
            Console.Write("Masukan Gaji Pokok              : ");
            gaji = int.Parse(Console.ReadLine());
            {
                kenaikangaji = 10 * gaji / 100;
            }

            gajiakhir = gaji + kenaikangaji;

            Console.WriteLine("==================================");
            Console.WriteLine("Nama                 : "+nama);
            Console.WriteLine("Gaji Pokok           : " + gaji);
            Console.WriteLine("Gaji Bersih          : " + gajiakhir);
            Console.Read();
        }
    }
}
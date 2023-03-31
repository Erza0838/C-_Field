// See https://aka.ms/new-console-template for more information
using System;

namespace CarProperty
{   
    class CarField
    {      
        // kumpulan property yang berisi banyak field
        string carModel;
        string doorCount = "4";
        string carColor = "Merah";
        string carBrand = "Toyota";
        string CarHornSound = "Klakson berbunyi";
        string outYear = "2020";

        static void Main(string[] args)
        { 
            // Jalankan method  mobil
            CarProfile("80 km/jam");
        }

        // Bagian method pada mobil
        static void CarProfile(string carSpeed)
        {   
            // Membuat object baru
            CarField carObject = new CarField();

            // Array untuk menyimpan field dari property object
            string[,] carProfile = { {carObject.carModel  = "SUV", carObject.doorCount, carObject.carColor}, {carObject.carBrand, carObject.CarHornSound, carObject.outYear}};

            // Menampilkan value dari property ke console
            Console.WriteLine("Mobil dengan model " + carProfile[0, 0] + " berjalan dengan kecepatan " + carSpeed);
            // Console.WriteLine(carObject.CarHornSound + " : tintintin");
            // Console.WriteLine("Mobil saya berwarna " + carObject.carColor + " merek " + carObject.carBrand + " model " + carObject.carModel + " keluaran tahun " + carObject.outYear + " dengan jumlah pintu sebanyak   " + carObject.doorCount);
        }
    }
}
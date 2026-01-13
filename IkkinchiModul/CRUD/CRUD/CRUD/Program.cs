using CRUD.Models;

namespace CRUD;

internal class Program
{

    static List<Car> Cars = new List<Car>();
    static void Main(string[] args)
    {
        DataSeed();


        //Console.WriteLine("Barcha mashinalar:");
        //foreach (var car in Cars)
        //{
        //    Console.WriteLine($"ID: {car.CarId} | Name: {car.CarName} | Brand: {car.CarBrand} | Speed: {car.CarSpeed} km/soat| Created : {car.Created} ");
        //}



        //     var expensiveCars = GetCarsAbovePrice(100000000);

        //    foreach (var car in expensiveCars)
        //    {
        //        Console.WriteLine($"{car.CarName} - {car.CarPrice} so'm|  Created : {car.Created}");
        //    }



        //    var maxCar = GetMaxPricedCar();
        //    Console.WriteLine($"Eng qimmat mashina: {maxCar.CarName} - {maxCar.CarPrice} so'm");


        //    var fastestCar = GetFastestCar();
        //    Console.WriteLine($"Eng tez mashina: {fastestCar.CarName} - {fastestCar.CarSpeed} km/soat");









    }




    static Car GetFastestCar()
    {
        Car fastest = Cars[0];
        foreach (var car in Cars)
        {
            if (car.CarSpeed > fastest.CarSpeed)
            {
                fastest = car;
            }
        }
        return fastest;
    }



    static List<Car> GetCarsAbovePrice(decimal minPrice)
    {
        var expensiveCars = new List<Car>();

        foreach (var car in Cars)
        {

            if (car.CarPrice > minPrice)
            {
                expensiveCars.Add(car);
            }
        }

        return expensiveCars;
    }

    static Car GetMaxPricedCar()
    {
        Car car = Cars[0];
        foreach (var b in Cars)
        {
            if (car.CarPrice < b.CarPrice)
            {
                car = b;
            }
        }
        return car;

    }

    static void DataSeed()
    {

       Schools.Add(new School()
        {
            SchoolId = Guid.NewGuid(),
            SchoolName = "STEM Innovation School",
            SchoolDescription = "TEM Innovation School — ilm-fan, texnologiya, muhandislik va matematika sohalarida innovatsion ta’lim beruvchi maktab. O‘quvchilar kreativ fikrlash va amaliy ko‘nikmalarni rivojlantiradi.",
            Capacity = 500,
            Rooms = 22,
            Points = 44,
            Number = 76,
            CurrentStudents = 200,
            Created = DateTime.UtcNow,
            UpdatedAt = null,


        });
        Schools.Add(new School()
        {
            SchoolId = Guid.NewGuid(),
            SchoolName = "STEM Innovation School",
            SchoolDescription = "TEM Innovation School — ilm-fan, texnologiya, muhandislik va matematika sohalarida innovatsion ta’lim beruvchi maktab. O‘quvchilar kreativ fikrlash va amaliy ko‘nikmalarni rivojlantiradi.",
            Capacity = 500,
            Rooms = 22,
            Points = 44,
            Number = 76,
            CurrentStudents = 200,
            Created = DateTime.UtcNow,
            UpdatedAt = null,


        });
        Schools.Add(new School()
        {
            SchoolId = Guid.NewGuid(),
            SchoolName = "STEM Innovation School",
            SchoolDescription = "TEM Innovation School — ilm-fan, texnologiya, muhandislik va matematika sohalarida innovatsion ta’lim beruvchi maktab. O‘quvchilar kreativ fikrlash va amaliy ko‘nikmalarni rivojlantiradi.",
            Capacity = 500,
            Rooms = 22,
            Points = 44,
            Number = 76,
            CurrentStudents = 200,
            Created = DateTime.UtcNow,
            UpdatedAt = null,


        });








        //Cars.Add(new Car()
        //{
        //    CarId = Guid.NewGuid(),
        //    CarName = "cobalt",
        //    CarDescription = "Qulay, tejamkor va kundalik foydalanish uchun mos avtomobil",
        //    CarColor = "White",
        //    CarSpeed = 220,
        //    CarBrand = "Chevrolet",
        //    CarPrice = 120000000,
        //    Created = DateTime.UtcNow,
        //    UpdatedAd = null,


        //});
        //Cars.Add(new Car()
        //{
        //    CarId = Guid.NewGuid(),
        //    CarName = "KIA",
        //    CarDescription = "KIA — zamonaviy dizayn, ishonchlilik va qulaylikni birlashtirgan Janubiy Koreya avtomobil brendi.",
        //    CarColor = "Black",
        //    CarSpeed = 250,
        //    CarBrand = "KIA",
        //    CarPrice = 330000000,
        //    Created = DateTime.UtcNow,
        //    UpdatedAd = null,

        //});
        //Cars.Add(new Car()
        //{
        //    CarId = Guid.NewGuid(),
        //    CarName = "Mercedes-Benz",
        //    CarDescription = "Mercedes-Benz — hashamatli, yuqori sifatli va ilg‘or texnologiyaga ega Germaniya avtomobil brendi",
        //    CarColor = "Black",
        //    CarSpeed = 280,
        //    CarBrand = "Mercedes-Benz",
        //    CarPrice = 450000000,
        //    Created = DateTime.UtcNow,
        //    UpdatedAd = null,


        //});


    }

}
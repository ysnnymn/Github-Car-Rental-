using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        Brand brand = new Brand { BrandName = "BMW" };
        Brand brand1 = new Brand { BrandName = "Toyota" };
        Brand brand2 = new Brand { BrandName = "Fiat" };
        Brand brand3 = new Brand { BrandName = "Renault" };
        Brand brand4 = new Brand { BrandName = "Hyundai" };
        Brand brand5 = new Brand { BrandName = "as" };

        Color color = new Color { ColorName = "Beyaz" };
        Color color1 = new Color { ColorName = "Siyah" };
        Color color2 = new Color { ColorName = "Gri" };
        Color color3 = new Color { ColorName = "Mavi" };
        Color color4 = new Color { ColorName = "Kırmızı" };
        Color color5 = new Color { ColorName = "Yeşil" };
        Color color6 = new Color { ColorName = "dad" };

        Car car = new Car { BrandId = 2, ColorId = 1, Description = "5.20", ModelYear = 2018, DailyPrice = 3500 };
        Car car1 = new Car { BrandId = 3, ColorId = 2, Description = "Corolla", ModelYear = 2015, DailyPrice = 2800 };
        Car car2 = new Car { BrandId = 4, ColorId = 3, Description = "Egea", ModelYear = 2023, DailyPrice = 4000 };
        Car car3 = new Car { BrandId = 1, ColorId = 4, Description = "Megane", ModelYear = 2012, DailyPrice = 1800 };
        Car car4 = new Car { BrandId = 6, ColorId = 5, Description = "İx35", ModelYear = 2014, DailyPrice = 2650 };
        Car car5 = new Car { BrandId = 6, ColorId = 1, Description = "Accent", ModelYear = 2010, DailyPrice = 1000 };

        User user = new User { FirstName = "Yasin", LastName = "Yaman", Email = "yasinyaman985@gmail.com", Password = "Yasinyaman.43" };
        User user1 = new User { FirstName = "Salihcan", LastName = "Özdemir", Email = "salih@gmail.com", Password = "salih123" };
        User user2 = new User { FirstName = "Ahmet", LastName = "Özbey", Email = "Özbey43@gmail.com", Password = "özzbyy3" };
        User user3 = new User { FirstName = "çınarr" };


        Customer customer = new Customer { UserId = 17, CompanyName = "Özbey Lojisitik" };
        Customer customer1 = new Customer { UserId = 16, CompanyName = null };

        Rental rental = new Rental { CarId = 11, CustomerId = 5, RentDate = new DateTime(2023, 11, 5), ReturnDate = new DateTime(2023, 11, 8) };
        Rental rental1 = new Rental { CarId = 12, CustomerId = 6, RentDate = DateTime.Now, ReturnDate = new DateTime(2023, 11, 19) };

        Rental rental2 = new Rental { CarId = 11, CustomerId = 5, RentDate = DateTime.Now, ReturnDate = null };

        // RentalTest();
        // CustomerTest();
        // UserTest();
       // CarTest();
        //ColorTest();
        // BrandTest();


        //BrandManager brandManager = new BrandManager(new EfBrandDal());
        //var result=brandManager.GetAll();

        //foreach (var item in result.Data)
        //{
        //    Console.WriteLine(item.BrandName);
        //}

        //CarManager carManager = new CarManager(new EfCarDal());
        //var result = carManager.Add(new Car { Id = 7, Description = "dfsfs" });
        //if (result.Success)
        //{
        //    Console.WriteLine(result.Message);
        //};


        //Brand brand6 = new Brand { BrandName = "dsada" };
        //BrandManager brandManager = new BrandManager(new EfBrandDal());
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        rentalManager.Add(rental2);



        //brandManager.Add(brand6);
        //var result = brandManager.GetAll();
        //if (result.Success)
        //{
        //    foreach (var item in result.Data)
        //    {
        //        Console.WriteLine(item.BrandName);
        //    }
        //}
        //CarManager carManager = new CarManager(new EfCarDal());

        //carManager.Add(car5);
        






    }


    private static void RentalTest()
    {
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //rentalManager.Add(rental);
        //var result = rentalManager.Add(rental1);
        //if (result.Success==true)
        //{
        //    Console.WriteLine(result.Message);
        //}

        //var result = rentalManager.Add(rental2);
        //if (result.Success == true)
        //{
        //    Console.WriteLine(result.Message);
        //}
        //else
        //{
        //    Console.WriteLine(result.Message);
        //}

        var result = rentalManager.GetRentalDetails();
        if (result.Success==true)
        {
            Console.WriteLine(result.Message);
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CarName);
            }
        }
    }

    private static void CustomerTest()
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //customerManager.Add(customer1);
        //var result=customerManager.Add(customer);
        //if (result.Success==true)
        //{
        //    Console.WriteLine(result.Message);
        //}

        var result = customerManager.GetCustomerDetails();
        if (result.Success == true)
        {
            Console.WriteLine(result.Message);
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + item.CompanyName);
            }
        }
    }

    private static void UserTest()
    {
        UserManager userManager = new UserManager(new EfUserDal());
        //userManager.Add(user);
        //userManager.Add(user1);
        //userManager.Add(user2);
        //var result=userManager.Delete(new User { Id=18});
        //if (result.Success==true)
        //{
        //    Console.WriteLine(result.Message);
        //}

        //var result = userManager.GetByUserId(15);
        //if (result.Success==true)
        //{
        //    Console.WriteLine(result.Message);
        //    Console.WriteLine(result.Data.FirstName);
        //}
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        //carManager.Add(car);
        //carManager.Add(car1);
        //carManager.Add(car2);
        //carManager.Add(car3);
        //carManager.Add(car4);
        //var result=carManager.Delete(new Car { Id=22});
        //if (result.Success==true)
        //{
        //    Console.WriteLine(result.Message);
        //}

        //var result = carManager.CarDetailDto();
        //if (result.Success==true)
        //{
        //    foreach (var item in result.Data)
        //    {
        //        Console.WriteLine(item.BrandName+item.CarName+item.ColorName+item.BrandName);
        //    }
        //}
    }

    private static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        //colorManager.Add(color);
        //colorManager.Add(color1);
        //colorManager.Add(color2);
        //colorManager.Add(color3);
        //colorManager.Add(color4);
        //colorManager.Add(color5);
        //var result=colorManager.Delete(new Color { Id=7, });
        //if (result.Success==true)
        //{
        //    Console.WriteLine(result.Message);
        //}

        //var result = colorManager.GetByColorId(1);
        //if (result.Success==true)
        //{
        //    Console.WriteLine(result.Message);
        //    Console.WriteLine(result.Data.ColorName);
        //}
    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        //brandManager.Add(brand);
        //brandManager.Add(brand1);
        //brandManager.Add(brand2);
        //brandManager.Add(brand3);
        //brandManager.Add(brand4);

        //var result= brandManager.Delete(new Brand { Id=15,});
        // if (result.Success==true)
        // {
        //     Console.WriteLine(result.Message);
        // }

        //var result = brandManager.GetByBrandId(1);





        //if (result.Success==true)
        //{
        //    Console.WriteLine(result.Message);
        //    Console.WriteLine(result.Data.BrandName);
        //}
    }
}
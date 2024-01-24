using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal:ICarDal
	{
        List<Car> _cars;
		public InMemoryCarDal()
		{
            _cars = new List<Car>()
            { new Car{ Id=1, BrandId=1, ColorId=1, ModelYear=2000, DailyPrice=3000, Description="Fiat Egea"},
            new Car { Id=2, BrandId=2, ColorId=1, ModelYear=1988, DailyPrice=500, Description="Sahin S"},
            new Car{ Id=3, BrandId=3, ColorId=1, ModelYear=2012, DailyPrice=40000, Description="Bmw 5.20"}
            };
		}

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
            
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {

            return _cars.Where(c => c.Id == CarId).ToList();


        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}


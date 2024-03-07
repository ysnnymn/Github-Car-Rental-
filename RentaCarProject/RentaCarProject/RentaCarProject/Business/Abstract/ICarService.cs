using System;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICarService
	{
		IDataResult<List<Car>> GetAll();
		IDataResult<Car> GetByCarId(int carId);
		IDataResult<List<Car>> GetCarsByBrandId(int brandId);
		IDataResult<List<Car>> GetCarsByColorId(int colorId);
		IDataResult<List<CarDetailDto>> CarDetailDto();
		IResult Add(Car car);
		IResult Delete(Car car);
		IResult Update(Car car);
	}
}


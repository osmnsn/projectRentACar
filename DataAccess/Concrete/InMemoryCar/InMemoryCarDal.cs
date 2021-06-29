using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryCar
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();

        }

        public void Uptade(Car car)
        {

            Car carToUptade = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
            carToUptade.ModelYear = car.ModelYear;
        }
    }
}

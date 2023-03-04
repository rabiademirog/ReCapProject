using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1,ColorId=1,ModelYear=2022,DailyPrice=600,Description="Benzin" },
                new Car{Id=2, BrandId=1,ColorId=2,ModelYear=2018,DailyPrice=400,Description="Benzin" },
                new Car{Id=3, BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=300,Description="Dizel" },
                new Car{Id=4, BrandId=2,ColorId=1,ModelYear=2020,DailyPrice=500,Description="Dizel" },
                new Car{Id=5, BrandId=2,ColorId=2,ModelYear=2008,DailyPrice=100,Description="Benzin" }

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
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

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();

        }
    }
}

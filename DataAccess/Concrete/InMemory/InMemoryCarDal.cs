﻿using DataAccess.Abstract;
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

            //_cars = new List<Car>
            //{
            //    new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=735.00,Description="Günlük",ModelYear=2020},
            //    new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=95.00,Description="Haftalık",ModelYear=2010},
            //    new Car{Id=3,BrandId=3,ColorId=1,DailyPrice=175.00,Description="Aylık",ModelYear=2000},
            //    new Car{Id=4,BrandId=4,ColorId=5,DailyPrice=75.00,Description="Günlük",ModelYear=2005},
            //    new Car{Id=5,BrandId=5,ColorId=4,DailyPrice=72.00,Description="Günlük",ModelYear=2007},
            //    new Car{Id=6,BrandId=6,ColorId=2,DailyPrice=135.00,Description="Günlük",ModelYear=2011},
            //    new Car{Id=7,BrandId=7,ColorId=1,DailyPrice=335.00,Description="Günlük",ModelYear=2022},
            //    new Car{Id=8,BrandId=8,ColorId=1,DailyPrice=935.00,Description="Günlük",ModelYear=2015}
            //};

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

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
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
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarName = car.CarName; 
        }
    }
}

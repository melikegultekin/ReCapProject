using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            // İş Kodları
            return _carDal.GetAll();
        }

        public List<Car> GetCarByBrandId(int id)
        {
            return _carDal.GetAll(c =>c.CarBrandId==id);
        }

        public List<Car> GetCarByColorId(int id)
        {
            return _carDal.GetAll(c =>c.CarColorId==id);

        }
    }
}

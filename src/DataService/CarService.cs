using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DataService;
using DAL;
using System.Linq;

namespace DataService
{
    public class CarsService
    {
        private UnitOfWork _unitOfWork;

        public CarsService(DbContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        public List<CarDto> GetAllCars()
        {
            List<CarDto> returnlist = new List<CarDto>();

            var allCars = _unitOfWork.Cars.GetAll();

            foreach (var car in allCars)
            {
                returnlist.Add(CarToCarDto(car));
            }

            return returnlist;
        }
        private CarDto CarToCarDto(Car car)
        {

            var photos = _unitOfWork.Photos.GetPhotosByCarId(car.CarId);
            var carSalonName = _unitOfWork.CarSalon.GetAll().First(x => x.Cars.Contains(car)).Name;
            var wheelstype = _unitOfWork.Transmitions.GetAll().First(x => x.TransmitionId == car.TransmitionId).DriveWheels.Type;
            var colorcode = _unitOfWork.Color.GetAll().First(x => x.ColorId == car.ColorId).ColorCode;
            var colortype = _unitOfWork.Color.GetAll().First(x => x.ColorId == car.ColorId).ColorType.Type;
            var bodytype = _unitOfWork.Bodies.GetAll().First(x => x.BodyId == car.BodyId).Type;
            return new CarDto(car.CarId, car.ManufacturerName, car.ModelName, carSalonName, car.CarSalonId, wheelstype, car.Price, photos, colortype, colorcode, bodytype, car.CarClass);
        }
    }

    public static class Convert
    {

    }
}

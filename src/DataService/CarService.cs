using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DataService;
using DALF;
using System.Linq;

namespace DataService
{
    public class CarsService
    {
        private UnitOfWork _unitOfWork;

        public CarsService(CarDbContext context)
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

           
            return new CarDto(car.CarId, car.ManufacturerName, car.ModelName, car.CarSalon.Name, car.CarSalonId, car.Transmition.DriveWheels.Type, car.Price, car.CarPhoto.Photos.Select(x=>x.PhotoURL), car.Color.ColorType.Type, car.Color.ColorCode, car.Body.Type, car.CarClass);
        }
    }

    public static class Convert
    {

    }
}

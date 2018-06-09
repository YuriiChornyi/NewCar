using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DALF;
using System.Linq;
using Service;

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

        public CarDto GetCarById(int id)
        {
            Car car = _unitOfWork.Cars.Get(id);
            if (car == null)
            {
                return null;
            }

            return CarToCarDto(car);
        }
        private CarDto CarToCarDto(Car car)
        {
            var res = _unitOfWork.CarPhotos.GetAll().Where(x => x.CarId == car.CarId).Select(x => x.Photos);
            List<string> photos=new List<string>();
            foreach (var photo in res)
            {
                photos.Add(photo.PhotoURL);
            }

            var gearBoxId=car.Transmition.GearBoxID;
            var gearBoxType = _unitOfWork.GearBoxes.Get(gearBoxId).Type;
            return new CarDto(car.CarId, car.ManufacturerName, car.ModelName, car.CarSalon.Name, car.CarSalonId, car.Transmition.DriveWheels.Type, car.Price, photos, car.Color.ColorType.Type, car.Color.ColorCode, car.Body.Type, car.CarClass,car.Engine.FuelType,car.Engine.Value, gearBoxType);
        }

        private Car CarDtoToCar(CarDto carDto)
        {

            return new Car();
        }
    }
}

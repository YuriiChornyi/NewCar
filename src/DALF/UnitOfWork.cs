namespace DALF
{
    using System;
#pragma warning disable S3881 // "IDisposable" should be implemented correctly
    public class UnitOfWork : IDisposable
#pragma warning restore S3881 // "IDisposable" should be implemented correctly
    {
        private readonly CarDbContext _carDb;

        public UnitOfWork(CarDbContext context)
        {
            _carDb = context;
        }
        private BodyRepository _bodyRepository;
        private CarRepository _carRepository;
        private CarSalonRepository _carSalonRepository;
        private ColorRepository _colorRepository;
        private ColorTypeRepository _colorTypeRepository;
        private CompleteSetRepository _completeSetRepository;
        private DriveWheelsRepository _driveWheelsRepository;
        private EngineRepository _engineRepository;
        private GearBoxRepository _gearBoxRepository;
        private PhotoRepository _photoRepository;
        private TransmitionRepository _transmitionRepository;
        private CarPhotoRepository _carPhotoRepository;

        public CarRepository Cars
        {
            get
            {
                if (_carRepository == null)
                    _carRepository = new CarRepository(_carDb);
                return _carRepository;
            }
        }
        public BodyRepository Bodies
        {
            get
            {
                if (_bodyRepository == null)
                    _bodyRepository = new BodyRepository(_carDb);
                return _bodyRepository;
            }
        }
        public CarSalonRepository CarSalon
        {
            get
            {
                if (_carSalonRepository == null)
                    _carSalonRepository = new CarSalonRepository(_carDb);
                return _carSalonRepository;
            }
        }
        public ColorRepository Color
        {
            get
            {
                if (_colorRepository == null)
                    _colorRepository = new ColorRepository(_carDb);
                return _colorRepository;
            }
        }
        public ColorTypeRepository ColorType
        {
            get
            {
                if (_colorTypeRepository == null)
                    _colorTypeRepository = new ColorTypeRepository(_carDb);
                return _colorTypeRepository;
            }
        }
        public CompleteSetRepository CompleteSet
        {
            get
            {
                if (_completeSetRepository == null)
                    _completeSetRepository = new CompleteSetRepository(_carDb);
                return _completeSetRepository;
            }
        }
        public DriveWheelsRepository DriveWheels
        {
            get
            {
                if (_driveWheelsRepository == null)
                    _driveWheelsRepository = new DriveWheelsRepository(_carDb);
                return _driveWheelsRepository;
            }
        }
        public EngineRepository Engines
        {
            get
            {
                if (_engineRepository == null)
                    _engineRepository = new EngineRepository(_carDb);
                return _engineRepository;
            }
        }
        public GearBoxRepository GearBoxes
        {
            get
            {
                if (_gearBoxRepository == null)
                    _gearBoxRepository = new GearBoxRepository(_carDb);
                return _gearBoxRepository;
            }
        }
        public PhotoRepository Photos
        {
            get
            {
                if (_photoRepository == null)
                    _photoRepository = new PhotoRepository(_carDb);
                return _photoRepository;
            }
        }
        public TransmitionRepository Transmitions
        {
            get
            {
                if (_transmitionRepository == null)
                    _transmitionRepository = new TransmitionRepository(_carDb);
                return _transmitionRepository;
            }
        }

        public CarPhotoRepository CarPhotos
        {
            get
            {
                if (_carPhotoRepository == null)
                    _carPhotoRepository = new CarPhotoRepository(_carDb);
                return _carPhotoRepository;
            }
        }

        public void Commit()
        {
            _carDb.SaveChanges();
        }

        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _carDb.Dispose();
                }
                this._disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

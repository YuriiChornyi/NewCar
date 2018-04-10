namespace DAL
{
    using Microsoft.EntityFrameworkCore;
    using System;
    public class UnitOfWork : IDisposable
    {
        private DbContext _db;

        public UnitOfWork(DbContext context)
        {
            _db = context;
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

        public CarRepository Cars
        {
            get
            {
                if (_carRepository == null)
                    _carRepository = new CarRepository(_db);
                return _carRepository;
            }
        }
        public BodyRepository Bodies
        {
            get
            {
                if (_bodyRepository == null)
                    _bodyRepository = new BodyRepository(_db);
                return _bodyRepository;
            }
        }
        public CarSalonRepository CarSalon
        {
            get
            {
                if (_carSalonRepository == null)
                    _carSalonRepository = new CarSalonRepository(_db);
                return _carSalonRepository;
            }
        }
        public ColorRepository Color
        {
            get
            {
                if (_colorRepository == null)
                    _colorRepository = new ColorRepository(_db);
                return _colorRepository;
            }
        }
        public ColorTypeRepository ColorType
        {
            get
            {
                if (_colorTypeRepository == null)
                    _colorTypeRepository = new ColorTypeRepository(_db);
                return _colorTypeRepository;
            }
        }
        public CompleteSetRepository CompleteSet
        {
            get
            {
                if (_completeSetRepository == null)
                    _completeSetRepository = new CompleteSetRepository(_db);
                return _completeSetRepository;
            }
        }
        public DriveWheelsRepository DriveWheels
        {
            get
            {
                if (_driveWheelsRepository == null)
                    _driveWheelsRepository = new DriveWheelsRepository(_db);
                return _driveWheelsRepository;
            }
        }
        public EngineRepository Engines
        {
            get
            {
                if (_engineRepository == null)
                    _engineRepository = new EngineRepository(_db);
                return _engineRepository;
            }
        }
        public GearBoxRepository GearBoxes
        {
            get
            {
                if (_gearBoxRepository == null)
                    _gearBoxRepository = new GearBoxRepository(_db);
                return _gearBoxRepository;
            }
        }
        public PhotoRepository Photos
        {
            get
            {
                if (_photoRepository == null)
                    _photoRepository = new PhotoRepository(_db);
                return _photoRepository;
            }
        }
        public TransmitionRepository Transmitions
        {
            get
            {
                if (_transmitionRepository == null)
                    _transmitionRepository = new TransmitionRepository(_db);
                return _transmitionRepository;
            }
        }
        
        public void Commit()
        {
            _db.SaveChanges();
        }

        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
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

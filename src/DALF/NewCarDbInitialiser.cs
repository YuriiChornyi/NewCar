﻿namespace DALF
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    public class NewCarDbInitialiser : DropCreateDatabaseIfModelChanges<CarDbContext>
    {
        private CarDbContext _context;
        protected override void Seed(CarDbContext context)
        {
            base.Seed(context);
            _context = context;

            SeedBody();
            SeedCarSalon();
            SeedColorType();
            SeedColors();
            SeedDriveWheels();
            SeedGearBoxes();
            SeedTransmition();
            SeedEngines();
            SeedCompleateSets();
            SeedCars();
            SeedPhotos();
            SeedCarPhoto();
        }

        private void SeedBody()
        {
            var bodies = new[]
            {
                new Body{Type="Sedan"},
                new Body{Type="Coupe"},
                new Body{Type="Vagon"},
                new Body{Type="GT"},
                new Body{Type="Premium sedan"},
            };
            if (!_context.Bodies.Any())
            {
                foreach (Body s in bodies)
                {
                    _context.Bodies.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedCarSalon()
        {
            var carSalons = new[]
            {
                new CarSalon{City = "Lviv",Email = "shop.porsche@porsche.ua",Name = "Porsche Center Lviv",PhoneNumber = "+38(032)2560356",Site = "http://lviv.porsche.ua/lviv"},
                new CarSalon{City = "Lviv",Email = "office@mercedes-benz.lviv.ua",Name = "Mercedes-Benz",PhoneNumber = "+38(032)2512023",Site = "http://mercedes-benz.lviv.ua/"}
            };
            if (!_context.CarSalons.Any())
            {
                foreach (CarSalon s in carSalons)
                {
                    _context.CarSalons.Add(s);
                }
                _context.SaveChanges();
            }
            return;
        }
        private void SeedColorType()
        {
            var colorType = new[]
            {
                new ColorType{Type = "Solid"},
                new ColorType{Type = "Metallic"},
                new ColorType{Type = "Pearlescent"},
                new ColorType{Type = "Matte finishes"},
                new ColorType{Type = "Special"}
            };
            if (!_context.ColorTypes.Any())
            {
                foreach (ColorType s in colorType)
                {
                    _context.ColorTypes.Add(s);
                }
                _context.SaveChanges();
            }
        }
        private void SeedColors()
        {
            var color = new[]
            {
                new Color{ColorCode = "#FF3333",ColorTypeId = 1},
                new Color{ColorCode = "#990033",ColorTypeId= 2},
                new Color{ColorCode = "#0033CC",ColorTypeId = 2},
                new Color{ColorCode = "#330000",ColorTypeId = 3},
                new Color{ColorCode = "#666666",ColorTypeId = 4}
            };
            if (!_context.Colors.Any())
            {
                foreach (Color s in color)
                {
                    _context.Colors.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedDriveWheels()
        {
            var driveWheels = new[]
            {
                new DriveWheels{Type = "AWD"},
                new DriveWheels{Type = "RWD"},
                new DriveWheels{Type = "FWD"}
            };
            if (!_context.DriveWheelses.Any())
            {
                foreach (DriveWheels s in driveWheels)
                {
                    _context.DriveWheelses.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedGearBoxes()
        {
            var gearBoxes = new[]
            {
                new GearBox{Type = "Manual"},
                new GearBox{Type = "Automatic"},
                new GearBox{Type = "Robotic"}
            };
            if (!_context.GearBoxs.Any())
            {
                foreach (GearBox s in gearBoxes)
                {
                    _context.GearBoxs.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedTransmition()
        {
            var transmitions = new[]
            {
                new Transmition{DriveWheelsId = 1,GearBoxID = 2},
                new Transmition{DriveWheelsId = 2,GearBoxID = 2},
                new Transmition{DriveWheelsId = 3,GearBoxID = 1}
            };
            if (!_context.Transmitions.Any())
            {
                foreach (Transmition s in transmitions)
                {
                    _context.Transmitions.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedEngines()
        {
            var engines = new[]
            {
                new Engine{FuelType = "Fuel",Value = 2.5f,ValueByHundred = 10.8f},
                new Engine{FuelType = "Disel",Value = 3.0f,ValueByHundred = 6.1f},
                new Engine{FuelType = "Disel",Value = 1.6f,ValueByHundred = 4.9f}
            };
            if (!_context.Engines.Any())
            {
                foreach (Engine s in engines)
                {
                    _context.Engines.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedCompleateSets()
        {
            var compleateSet = new[]
            {
                new CompleteSet{Description = "Спортивна вихлопна система\r\nНабір першоі допомоги\r\nАвтоматична КПП PDK, 7 ст., з двома зчепленнями\r\nПідігрів передніх сидінь\r\nЦентри коліс з кольоровим гербом PORSCHE\r\nКруіз-контроль\r\n20-дюймові легкосплавні колеса \"RS Spyder Design\"\r\nЗміна дорожнього просвіту на передній осі\r\nБагатофункціональне кермо з підігрівом\r\nПрибрати надпис моделі з заду\r\nЗовнішні дзеркала Sport Design\r\nВентиляція сидінь\r\nТонована верхня частина лобового скла\r\nСітка для дрібничок в зоні ніг пасажира\r\nПакет для курця\r\nСвітлодіодні фари вкл.PDLS Plus\r\nДистанційне керування воротами. (Home Link®)\r\nКомфортне освітлення\r\nСистема допомоги при паркуванні з сенсорами ззаду та спереду та камерою заднього виду\r\nЗсувний/відкидний люк прозорий даху з електроприводом\r\nПідсилювач керма Plus\r\nКилимки салону\r\nСистема об’ємного звучання BOSE®\r\nПакет Connect Plus\r\nСпортивні сидіння Plus, електропривід 14 налаштуваннь, пам’ять\r\nПакет Sport Chrono Plus\r\nТиснення гербу Порше на підголівниках\r\nАвтоматичне затемнення внутрішніх та зовнішніх дзеркал + датчик дощу\r\nШкіряний двокольоровий інтер’єр",Photo = "http://lviv.porsche.ua/images/doc/1/2/12cc11b-5e5f059-10-3.jpg"},
                new CompleteSet{Description = "Неповторимость - высшая форма индивидуальности. Поэтому благодаря продуманным пакетам оснащения новый S-класс можно оснастить с учётом личных потребностей его владельца. Для ещё большего комфорта, ещё большей безопасности, ещё большего престижа, ещё большей динамики. Что ещё нужно человеку?\r\n\r\nсмешанный расход топлива: 11,9-2,8 л/100 км, смешанные выбросы CO2: 279-65 г/км. [ 1 ]\r\n\r\nНаличие оснащения зависит от моторизации и выбранной конфигурации. Эти данные вы найдете в соответствующей информации по оснащению.",Photo = "https://shanesautos.files.wordpress.com/2015/10/2.jpg"}
            };
            if (!_context.CompleteSets.Any())
            {
                foreach (CompleteSet s in compleateSet)
                {
                    _context.CompleteSets.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedCars()
        {
            var cars = new[]
            {
                new Car{ CarId = 1,CarSalonId = 1,BodyId= 4,EngineId = 1,ManufacturerName = "Porsche",ModelName = "911 Carrera 4S",ProductionTime = new  DateTime(2016,8,10),CompleteSetId = 1,ColorId = 3,TransmitionId = 1,Price = 5600186f,CarClass="Sport Gt"},
                new Car{CarId = 2,CarSalonId = 2,BodyId = 5,EngineId = 2,ManufacturerName = "Mercedes-Benz",ModelName = "S-Calss W220",ProductionTime = new  DateTime(2018,1,1),CompleteSetId = 2,ColorId = 3,TransmitionId = 2,Price = 4888950f,CarClass = "Premium"}
            };
            if (!_context.Cars.Any())
            {
                foreach (Car s in cars)
                {
                    _context.Cars.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedPhotos()
        {
            var photos = new[]
            {
                new Photo{PhotoId = 1,PhotoURL = "http://lviv.porsche.ua/images/doc/c/e/ceaee3a-959bdf7-cayman1.jpg"},
                new Photo{PhotoId = 2,PhotoURL = "http://lviv.porsche.ua/images/doc/0/8/08b81de-51a119f-10-2.jpg"},
                new Photo{PhotoId = 3,PhotoURL = "https://upload.wikimedia.org/wikipedia/commons/7/77/2013_Porsche_911_Carrera_4S_%28991%29_%288824948364%29.jpg"},
                new Photo{PhotoId = 4,PhotoURL = "http://mercedes-benz.autoua.net/media/catalog/2/5/p1586425-1421158104.jpg"},
                new Photo{PhotoId = 5,PhotoURL = "http://i.infocar.ua/i/12/5232/700x350.jpg"},
                new Photo{PhotoId = 6,PhotoURL = "http://amgroom.ru/upload/catalog_add/autoresize/780x0/88.jpg"},

            };
            if (!_context.Photos.Any())
            {
                foreach (Photo s in photos)
                {
                    _context.Photos.Add(s);
                }
                _context.SaveChanges();
            }
        }

        private void SeedCarPhoto()
        {
            var carPhotos = new[]
            {
                new CarPhoto {CarId = 1, PhotoId = 1},
                new CarPhoto {CarId = 1, PhotoId = 2},
                new CarPhoto {CarId = 1, PhotoId = 3},
                new CarPhoto {CarId = 2, PhotoId = 4},
                new CarPhoto {CarId = 2, PhotoId = 5},
                new CarPhoto {CarId = 2, PhotoId = 6}
            };
            if (!_context.CarPhotos.Any())
            {
                foreach (CarPhoto s in carPhotos)
                {
                    _context.CarPhotos.Add(s);
                }
                _context.SaveChanges();
            }
        }
    }
}

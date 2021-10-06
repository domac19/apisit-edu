using System;
using System.Collections.Generic;

namespace linqExample
{
   public class Cars
   {
        public IEnumerable<CarInfo> GetCarInfos()
        {
            return new List<CarInfo>
            {
                new CarInfo { Name = "Alfa", Type = "Sport", Value = 200000, Yearold = 2017},
                new CarInfo { Name = "Seat", Type = "Limusine", Value = 100000, Yearold = 2015},
                new CarInfo { Name = "Renault", Type = "SUV", Value = 301020, Yearold = 2018},
                new CarInfo { Name = "Peugneot", Type = "Caravan", Value = 250100, Yearold = 2016},
                new CarInfo { Name = "Toyota", Type = "Coupe", Value = 72300, Yearold = 2019}
            };
        }      
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Domain.Entities.Base;

namespace AloTaxi.Domain.Entities.User.Car
{
    public class DriverCar : BaseEntity
    {
        #region props

        public bool IsDriverOwnsCar { get; set; }

        #endregion

        #region rels

        public string? DriverId { get; set; }
        public Driver? Driver { get; set; }

        public long? CarId { get; set; }
        public Car? Car { get; set; }

        #endregion
    }
}

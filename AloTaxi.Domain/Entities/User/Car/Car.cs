using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Domain.Entities.Base;

namespace AloTaxi.Domain.Entities.User.Car
{
    public class Car : BaseEntity
    {
        #region props

        [DisplayName("شماره پلاک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [StringLength(8, ErrorMessage = "{0} باید {1} کاراکتر داشته باشد")]
        public string CarNo { get; set; } = string.Empty;

        [DisplayName("نام خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("سال ساخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CreateAtYear { get; set; }

        #endregion

        #region relations

        public long? ColorId { get; set; }
        public CarColor? Color  { get; set; }

        public ICollection<DriverCar> DriverCars { get; set; } = new List<DriverCar>();

        #endregion
    }
}

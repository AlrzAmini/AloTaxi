using AloTaxi.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Domain.Entities.User.Car;

namespace AloTaxi.Domain.Entities.User
{
    public class Driver : UserBaseEntity
    {
        #region props

        [MaxLength(10, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        [RegularExpression("^(?!(\\d)\\1{9})\\d{10}$", ErrorMessage = "کد ملی وارد شده نامعتبر است")]
        public string NationalCode { get; set; } = string.Empty;

        // گواهینامه
        public object Creditenional { get; set; }

        // todo : use fluent api for annotate data

        [DisplayName("شماره تلفن دوم")]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "موبایل وارد شده نامعتبر است")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string? SecondPhoneNumber { get; set; }

        #endregion

        #region rels

        public ICollection<DriverCar> DriverCars { get; set; } = new List<DriverCar>();

        #endregion
    }
}

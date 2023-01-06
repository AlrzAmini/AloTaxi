using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloTaxi.Domain.Entities.Base
{
    /// <summary>
    /// UserBaseEntity is separated from BaseEntity because user info is
    /// deference with another entities
    /// </summary>
    public abstract class UserBaseEntity
    {
        #region props

        [Key]
        [MaxLength(50)]
        public string UserId { get; set; } = Guid.NewGuid().ToString();

        [DisplayName("نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string FirstName { get; set; } = string.Empty;

        [DisplayName("نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "شماره موبایل")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "موبایل وارد شده معتبر نمی باشد")]
        public string PhoneNumber { get; set; } = string.Empty;

        [DisplayName("رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string Password { get; set; } = string.Empty;

        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }


        #endregion

        #region methods

        protected string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        #endregion
    }
}

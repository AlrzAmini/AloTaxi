

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AloTaxi.Domain.Entities.Base;

namespace AloTaxi.Domain.Entities.User
{
    public class Address : BaseEntity
    {
        #region prpeties

        [DisplayName("استان")]
        [MaxLength(250, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string Province { get; set; } = string.Empty;

        [DisplayName("شهر")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string City { get; set; } = string.Empty;

        [DisplayName("خیابان")]
        [MaxLength(250, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string Street { get; set; } = string.Empty;

        [DisplayName("جزییات")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیش از {1} کاراکتر داشته باشد")]
        public string Details { get; set; } = string.Empty;

        #endregion

        #region relations

        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        #endregion
    }
}

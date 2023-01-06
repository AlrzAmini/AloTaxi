using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Domain.Entities.Base;

namespace AloTaxi.Domain.Entities.User
{
    public class Customer : UserBaseEntity
    {


        #region relations

        public ICollection<Address> Address { get; set; } = new List<Address>();

        #endregion
    }
} 

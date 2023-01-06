using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Domain.Entities.Base;

namespace AloTaxi.Domain.Entities.User
{
    public class Manager : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
    }
}

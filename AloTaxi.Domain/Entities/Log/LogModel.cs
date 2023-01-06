using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Domain.Entities.Base;

namespace AloTaxi.Domain.Entities.Log
{
    public class LogModel : BaseEntity
    {
        [MaxLength(1000)]
        public string? Message { get; set; }

        [Required]
        public LogLevel Level { get; set; }
    }

    public enum LogLevel
    {
        High,
        Medium,
        Low
    }
}

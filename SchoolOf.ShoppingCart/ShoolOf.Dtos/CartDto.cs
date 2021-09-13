using SchoolOf.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoolOf.Dtos
{
    class CartDto
    {
        public long Id { get; set; }
        [EnumDataType(typeof(Status))]
        public Status Status { get; set; }
    }
}

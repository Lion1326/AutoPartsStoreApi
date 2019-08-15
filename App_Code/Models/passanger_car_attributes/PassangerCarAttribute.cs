using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsStore
{
    [Table ("passanger_car_attributes")]
    public class PassangerCarAttribute
    {
        [Key]
        public Int64 passangercarid { get; set; }
        public string attributegroupL { get; set; }
        public string attributetype { get; set; }
        public string displaytitle { get; set; }
        public string displayvalue { get; set; }
    }
}
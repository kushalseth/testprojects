using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompressedAPI
{
    public class DataModel
    {
        [Key]
        public int Id { get; set; }
        public string CompressedData { get; set; }
        public string UnCompressedData { get; set; }
    }
}

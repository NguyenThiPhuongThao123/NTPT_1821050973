using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTPT_1821050973.Models
{
    [Table("Sinhviens")]
    public class Sinhvien
    {
        [Key]
        public string Masv { get; set; }
        public string Hoten { get; set; }
        [AllowHtml]
        public string Diachi { get; set; }
    }
}
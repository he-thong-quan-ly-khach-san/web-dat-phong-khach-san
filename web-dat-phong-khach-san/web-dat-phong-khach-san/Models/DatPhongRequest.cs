using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_dat_phong_khach_san.Models
{
    public class DatPhongRequest
    {
        
        public string Name { get; set; }
        public DateTime NgayDen { get; set; }
        public DateTime NgayDi {  get; set; }
        public string SoDienThoai { get; set; }

    }
}
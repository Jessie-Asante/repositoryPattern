using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositoryPattern.Entity.Models
{
    public class TblUser
    {
        public int usaIDpk { get; set; }
        public string usaFName { get; set; }
        public string usaLName { get; set; }
        public DateTime usaDoB { get; set; }
        public string usaAddress { get; set; }
    }
}

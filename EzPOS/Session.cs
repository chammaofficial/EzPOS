using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS
{
    public static class Session
    {
        public static User LoginUser { get; set; }
        public static Branch LoginBranch { get; set; }
    }
}

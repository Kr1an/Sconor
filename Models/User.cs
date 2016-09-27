using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Sconor.Models
{
    public class User
    {
		public Int32 UserId { get; set; }
		public String Name { get; set; }
		public String Nickname { get; set; }
	}
}

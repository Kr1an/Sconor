using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Sconor.Models
{
	public class Page
	{
		public Int32 PageId { get; set; }
		public String Title { get; set; }
		public String htmlString { get; set; }
	}
}

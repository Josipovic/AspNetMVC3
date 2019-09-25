using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNet3Vjezba2.Models
{
    public class KontaktContext:DbContext
    {
        public DbSet<KontaktPodaci> Podaci { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNet3Vjezba2.Models
{
    public class FormaContext:DbContext
    {
        public  DbSet<FormaPodaci>Settings { get; set; }
    }
}
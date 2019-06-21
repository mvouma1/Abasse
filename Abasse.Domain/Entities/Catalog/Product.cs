using Abasse.Domain.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abasse.Domain.Entities.Catalog
{
   public class Product : BaseEntity
    {
        public string NAme { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
}

﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}

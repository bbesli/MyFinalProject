﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProdutName { get; set; }
        public string  CategoryName{ get; set; }
        public short UnitsInStock { get; set; }

    }
}

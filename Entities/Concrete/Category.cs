﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        //Çıplak Class Kalmasın: ÇCK

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}

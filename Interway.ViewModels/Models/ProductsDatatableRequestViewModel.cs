﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterwayAPI.ViewModels.Models
{
    public class ProductsDatatableRequestViewModel : DatatableRequestViewModel
    {
        public int? CategoryId { get; set; }
    }
}

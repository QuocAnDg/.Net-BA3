using System;
using System.Collections.Generic;

namespace Exam2023Janvier.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}

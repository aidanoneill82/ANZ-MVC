using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Anz.Web.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [Range(0, 10000000)]
        public float Amount { get; set; }
        public double Interest { get; set; }
        public int CustomerId { get; set; }
    }
}
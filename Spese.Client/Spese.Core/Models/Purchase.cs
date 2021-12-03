using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spese.Core.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PDate { get; set; }
        public string Description { get; set; }
        public decimal PAmount { get; set; }
        public bool Approved { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return $"{Id} date: {PDate}, {Description}, amount purchase : {PAmount}, approved : {Approved}";
        }
    }
}

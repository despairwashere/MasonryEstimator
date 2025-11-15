using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasonryEstimator.Core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string? ClientName { get; set; }
        public string? Location { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

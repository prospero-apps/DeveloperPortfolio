using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperPortfolio.Models.Dtos
{
    public class LinkDto
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public string DisplayText { get; set; }
        public string Icon { get; set; }
        public int ProjectId { get; set; }
    }
}

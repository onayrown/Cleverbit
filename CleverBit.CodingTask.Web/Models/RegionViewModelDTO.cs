using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CleverBit.CodingTask.Web.Models
{
    public class RegionViewModelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SelectListItem> Regions { get; internal set; }
    }
}

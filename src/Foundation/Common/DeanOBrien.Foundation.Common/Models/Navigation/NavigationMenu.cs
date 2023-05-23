using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Foundation.Common.Models.Navigation
{
    [SitecoreType(TemplateId = "{95E3F0E2-5A71-4807-9B18-16E4D5A01511}", AutoMap = true)]
    public class NavigationMenu
    {
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<NavigationMenuSection> Sections { get; set; }
    }
}
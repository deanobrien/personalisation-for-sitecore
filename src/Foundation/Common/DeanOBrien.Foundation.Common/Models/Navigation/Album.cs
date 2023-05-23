using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Glass.Mapper.Sc.Configuration;

namespace DeanOBrien.Foundation.Common.Models.Navigation
{
    [SitecoreType(TemplateId = "{D97F501C-659B-44F3-BEAB-F31EC4E10BE9}", AutoMap = true)]
    public class Album
    {
        [SitecoreField(FieldName = "Navigation Items", Setting = SitecoreFieldSettings.InferType)]
        public virtual IEnumerable<NavigationItem> NavigationItems { get; set; }

    }
}
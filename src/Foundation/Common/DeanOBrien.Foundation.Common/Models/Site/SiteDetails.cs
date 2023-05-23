using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Foundation.Common.Models.Site
{
    [SitecoreType]
    public class SiteDetails
    {
        [SitecoreField(FieldName = "Site Name")]
        public virtual string SiteName { get; set; }
        [SitecoreField(FieldName = "Logo")]
        public virtual Image Logo { get; set; }
    }
}
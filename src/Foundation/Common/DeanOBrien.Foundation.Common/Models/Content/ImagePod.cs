using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Glass.Mapper.Sc.Configuration;

namespace DeanOBrien.Foundation.Common.Models.Content
{
    [SitecoreType(AutoMap = true)]
    public class ImagePod
    {
        [SitecoreField(FieldName = "Main Image")]
        public virtual Image MainImage { get; set; }

    }
}
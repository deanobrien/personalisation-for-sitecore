using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Foundation.Common.Models.Content
{
    [SitecoreType]
    public class Jumbotron
    {
        [SitecoreField(FieldName = "Title")]
        public virtual string Title { get; set; }
        [SitecoreField(FieldName = "Lead Content")]
        public virtual string LeadContent { get; set; }


        [SitecoreField(FieldName = "Call To Action One")]
        public virtual Link CallToActionOne { get; set; }
        [SitecoreField(FieldName = "Call To Action Two")]
        public virtual Link CallToActionTwo { get; set; }
        [SitecoreField(FieldName = "Call To Action Three")]
        public virtual Link CallToActionThree { get; set; }


        [SitecoreField(FieldName = "Main Image")]
        public virtual Image MainImage { get; set; }
    }
}
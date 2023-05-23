using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Foundation.Common.Models.Content.Paramaters
{
    [SitecoreType(TemplateId = "{8E3B6368-F247-4E19-83C6-9340CB835E84}", AutoMap = true)]
    public class JumbotronParameters
    {
        [SitecoreField(FieldName = "Display Site Name")]
        public virtual bool DisplaySiteName { get; set; }
        [SitecoreField(FieldName = "Show Text")]
        public virtual bool ShowText { get; set; }
        [SitecoreField(FieldName = "Show Image")]
        public virtual bool ShowImage { get; set; }
        [SitecoreField(FieldName = "Show Calls To Action")]
        public virtual bool ShowCallsToAction { get; set; }
        [SitecoreField(FieldName = "Dark Background")]
        public virtual bool DarkBackground { get; set; }
    }
}
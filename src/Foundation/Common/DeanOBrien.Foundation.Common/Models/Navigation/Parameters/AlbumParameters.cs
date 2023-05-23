using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Foundation.Common.Models.Navigation.Paramaters
{
    [SitecoreType(TemplateId = "{387BF1FE-AE1E-4044-8AC0-296DD43BCDAC}", AutoMap = true)]
    public class AlbumParameters
    {
        [SitecoreField(FieldName = "Landscape")]
        public virtual bool Landscape { get; set; }
        [SitecoreField(FieldName = "Show Images")]
        public virtual bool ShowImages { get; set; }
        [SitecoreField(FieldName = "Enable Links")]
        public virtual bool EnableLinks { get; set; }
        [SitecoreField(FieldName = "Truncate Description At Word")]
        public virtual string TruncateDescriptionAtWord { get; set; }
        [SitecoreField(FieldName = "Only Select Navigatable Items")]
        public virtual bool OnlySelectNavigatableItems { get; set; }
        [SitecoreField(FieldName = "Only Show With Image")]
        public virtual bool OnlyShowWithImage { get; set; }
        [SitecoreField(FieldName = "Columns")]
        public virtual string Columns { get; set; }
    }
}
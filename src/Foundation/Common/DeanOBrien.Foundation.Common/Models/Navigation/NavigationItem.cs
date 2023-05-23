using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Foundation.Common.Models.Navigation
{
    [SitecoreType(AutoMap = true)]
    public class NavigationItem
    {
        [SitecoreId]
        public virtual ID ID { get; set; }
        [SitecoreField(FieldName = "Title")]
        public virtual string Title { get; set; }
        [SitecoreField(FieldName = "Description")]
        public virtual string ItemDescription { get; set; }
        [SitecoreField(FieldName = "Navigation Title")]
        public virtual string NavigationTitle { get; set; }
        [SitecoreField(FieldName = "Navigation Description")]
        public virtual string NavigationDescription { get; set; }
        [SitecoreField(FieldName = "Navigation Image")]
        public virtual Image NavigationImage { get; set; }
        [SitecoreInfo(SitecoreInfoType.FullPath)]
        public virtual string FullPath { get; set; }
        public string Url
        {
            get
            {
                return $"{this.FullPath.ToLower().Replace(Sitecore.Context.Site.StartPath.ToLower(), "").Replace(" ", "-")}/";
            }
        }
        public bool HasSubItems()
        {
            return false;
        }
        public bool IsActive(ID activeID)
        {
            return activeID == ID;
        }
    }
}
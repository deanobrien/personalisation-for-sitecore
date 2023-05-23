using DeanOBrien.Foundation.Common.Models.Content;
using DeanOBrien.Foundation.Common.Models.Content.Paramaters;
using DeanOBrien.Foundation.Common.Models.Site;
using Glass.Mapper.Sc.Fields;
using System;

namespace DeanOBrien.Feature.Content.ViewModels
{
    public class JumbotronViewModel
    {
        public SiteDetails Site { get; set; }
        public JumbotronParameters Parameters { get; set; }
        public Jumbotron Jumbotron { get; set; }
        public Jumbotron DataSource { get; set; }


        public virtual string Title 
        { 
            get
            {
                if (DataSource != null && !string.IsNullOrWhiteSpace(DataSource.Title)) return DataSource.Title;
                return Jumbotron.Title;
            } 
        }
        public virtual string LeadContent
        {
            get
            {
                if (DataSource != null && !string.IsNullOrWhiteSpace(DataSource.LeadContent)) return DataSource.LeadContent;
                return Jumbotron.LeadContent;
            }
        }
        public virtual Link CallToActionOne
        {
            get
            {
                if (DataSource!=null && DataSource.CallToActionOne != null) return DataSource.CallToActionOne;
                return Jumbotron.CallToActionOne;
            }
        }
        public virtual Link CallToActionTwo
        {
            get
            {
                if (DataSource != null && DataSource.CallToActionTwo != null) return DataSource.CallToActionTwo;
                return Jumbotron.CallToActionTwo;
            }
        }
        public virtual Link CallToActionThree
        {
            get
            {
                if (DataSource != null && DataSource.CallToActionThree != null) return DataSource.CallToActionThree;
                return Jumbotron.CallToActionThree;
            }
        }
        public virtual Image MainImage
        {
            get
            {
                if (DataSource != null && DataSource.MainImage !=null) return DataSource.MainImage;
                return Jumbotron.MainImage;
            }
        }




        public bool HasCallToActionOne
        {
            get
            {
                if (CallToActionOne != null && !String.IsNullOrEmpty(CallToActionOne.Text) && !string.IsNullOrWhiteSpace(CallToActionOne.Url))
                {
                    return true;
                }
                return false;
            }
        }
        public bool HasCallToActionTwo
        {
            get
            {
                if (CallToActionTwo != null && !String.IsNullOrEmpty(CallToActionTwo.Text) && !string.IsNullOrWhiteSpace(CallToActionTwo.Url))
                {
                    return true;
                }
                return false;
            }
        }
        public bool HasCallToActionThree
        {
            get
            {
                if (CallToActionThree != null && !String.IsNullOrEmpty(CallToActionThree.Text) && !string.IsNullOrWhiteSpace(CallToActionThree.Url))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
using DeanOBrien.Foundation.Common.Models.Content;
using DeanOBrien.Foundation.Common.Models.Site;

namespace DeanOBrien.Feature.Content.ViewModels
{
    public class ImageViewModel
    {
        public SiteDetails Site { get; set; }
        public ImagePod Image { get; set; }
    }
}
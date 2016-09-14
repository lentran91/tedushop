using System.Collections.Generic;

namespace TeduShop.Web.Models
{
    public class PostViewModel : ViewModelBase
    {

       
        public int ID { get; set; }

     
        public string Name { set; get; }

     
        public string Alias { set; get; }

       
        public int CategoryID { set; get; }

        public string Description { set; get; }

        public string Image { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

      
        public virtual PostCategoryViewModel PostCategory { set; get; }

        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }
    }
}
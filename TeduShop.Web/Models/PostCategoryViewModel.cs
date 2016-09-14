using System.Collections.Generic;

namespace TeduShop.Web.Models
{
    public class PostCategoryViewModel : ViewModelBase
    {

      
        public int ID { get; set; }

     
        public string Name { set; get; }

     
        public string Alias { set; get; }
        

        public int? ParentId { set; get; }
        public int? DisplayOrder { set; get; }

        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<PostViewModel> Posts { get; set; }
    }
}
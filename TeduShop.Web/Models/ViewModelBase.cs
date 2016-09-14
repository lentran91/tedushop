using System;

namespace TeduShop.Web.Models
{
    public class ViewModelBase
    {
        public DateTime? CreateDate { get; set; }
        
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }

    
        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public string Description { get; set; }
   
        public bool Status { get; set; }
    }
}
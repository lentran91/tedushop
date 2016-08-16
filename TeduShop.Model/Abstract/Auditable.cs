using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        public DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}

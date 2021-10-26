using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
        [Required]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string WherehouseId { get; set; }
    }
}

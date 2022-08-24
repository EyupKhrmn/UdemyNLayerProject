using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;

namespace UdemyNlayerProject.CORE.Model
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool IsDeleted { get; set; } 

        #region İlişki sütunları

        public ICollection<Product> Products { get; set; }

        #endregion
    }
}
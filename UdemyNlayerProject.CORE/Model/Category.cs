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
        public int Id { get; set; } //Hhhh
        public string Name { get; set; }
        public bool IsDeleted { get; set; } //dfknvlkdsvlks

        #region İlişki sütunları

        public ICollection<Product> Products { get; set; }

        #endregion
    }
}
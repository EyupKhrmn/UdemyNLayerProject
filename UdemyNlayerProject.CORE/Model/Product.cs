namespace UdemyNlayerProject.CORE.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public string InnerBarcode { get; set; }


        #region İlişki sütunları

        public virtual Category Category { get; set; }

        #endregion
    }
}
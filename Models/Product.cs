using System;

namespace ProductCatalog.Models
{
    public class Product
    {
        private DateTime _createDate;
        private DateTime _lastUpdateDate;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate
        {
            get { return this._createDate; }
            private set
            {
                this._createDate = DateTime.Now;
            }
        }
        public DateTime LastUpdateDate
        {
            get { return this._lastUpdateDate; }
            private set
            {
                this._lastUpdateDate = DateTime.Now;
            }
        }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
namespace cb_perform_test.Models
{
    using System;

    /// <summary>The product detail size mini web model.</summary>
    [Serializable]
    public class ProductDetailSizeMiniWebModel
    {
        /// <summary>Gets or sets the id.</summary>
        public Guid Id { get; set; }

        /// <summary>Gets or sets the quantity.</summary>
        public int Quantity { get; set; }

        /// <summary>Gets or sets the size.</summary>
       
        public string Size { get; set; }
    }
}

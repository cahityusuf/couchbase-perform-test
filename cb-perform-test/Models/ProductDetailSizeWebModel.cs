namespace cb_perform_test.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>The product detail size web model.</summary>
    [Serializable]
    public class ProductDetailSizeWebModel
    {
        /// <summary>The product detail sizes.</summary>
        private List<ProductDetailSizeListWebModel> productDetailSizes;

        /// <summary>Gets or sets the detail sizes.</summary>
        public List<ProductDetailSizeMiniWebModel> DetailSizes { get; set; }

        /// <summary>Gets or sets the product detail sizes.</summary>
        public List<ProductDetailSizeListWebModel> ProductDetailSizes
        {
            get
            {
                return this.productDetailSizes ?? (this.productDetailSizes = new List<ProductDetailSizeListWebModel>());
            }

            set
            {
                this.productDetailSizes = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether product size display.</summary>
        public bool ProductSizeDisplay { get; set; }

        /// <summary>Gets or sets a value indicating whether product size show divided.</summary>
        public bool ProductSizeShowDivided { get; set; }
    }
}

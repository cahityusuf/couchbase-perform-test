namespace cb_perform_test.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="ProductDetailVariantSizeIdWebModel" />
    /// </summary>
    [Serializable]
    public class ProductDetailVariantSizeIdWebModel
    {
        /// <summary>
        /// Gets or sets the SizeId
        /// </summary>
        public Guid SizeId { get; set; }

        /// <summary>
        /// Gets or sets the ProductVariantMatrixId
        /// </summary>
        public Guid ProductVariantMatrixId { get; set; }

        /// <summary>
        /// Gets or sets the StoreStockQty
        /// </summary>
        public int StoreStockQty { get; set; }

        /// <summary>
        /// Gets or sets the StockQuantity
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the DcStockQty
        /// </summary>
        public int DcStockQty { get; set; }
    }
}

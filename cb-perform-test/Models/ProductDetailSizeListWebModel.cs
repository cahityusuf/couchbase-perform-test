namespace cb_perform_test.Models
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>The product detail size list web model.</summary>
    [Serializable]
    public class ProductDetailSizeListWebModel
    {
        /// <summary>Gets or sets the product variant matrix stock quantity.</summary>
        public int ProductVariantMatrixStockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the product variant matrix cross border quantity.
        /// </summary>
        public int ProductVariantMatrixCrossBorderQuantity { get; set; }

        /// <summary>
        /// Gets or sets the product variant matrix stock message.
        /// </summary>
        public string ProductVariantMatrixStockMessage { get; set; }

        /// <summary>Gets or sets the product variant ecommerce stock qty.</summary>
        public int ProductVariantMatrixDcStockQty { get; set; }

        /// <summary>Gets or sets the product variant store stock qty.</summary>
        public int ProductVariantMatrixStoreStockQty { get; set; }

        /// <summary>Gets or sets the product variant size display order.</summary>
        public int ProductVariantSizeDisplayOrder { get; set; }

        /// <summary>Gets or sets a value indicating whether is domestic production.</summary>
        public bool IsDomesticProduction { get; set; }

        /// <summary>Gets or sets the product variant size id.</summary>
        public Guid ProductVariantSizeId { get; set; }

        /// <summary>Gets or sets the product variant size name.</summary>
        public string ProductVariantSizeName { get; set; }

        /// <summary>Gets or sets the sub lenght.</summary>
        public string ProductVariantSubLenght { get; set; }

        /// <summary>Gets or sets the sub size.</summary>
        public string ProductVariantSubSize { get; set; }

        /// <summary>Gets or sets the product variant matrix id.</summary>
        public Guid ProductVariantMatrixId { get; set; }

        /// <summary>Gets or sets the barcode.</summary>
        public string Barcode { get; set; }

        /// <summary>Gets or sets the product variant matrix ındex.</summary>
        public int ProductVariantMatrixIndex { get; set; }

        /// <summary>Gets or sets the product variant matrix ındex.</summary>
        public List<ProductVariantMatrixMeasurementWebModel> ProductVariantMatrixMeasurement { get; set; }

        /// <summary> Gets or sets the measurement name </summary>
        public string MeasurementName { get; set; }

        /// <summary> Gets or sets the measurement value. </summary>
        public decimal? MeasurementValue { get; set; }
    }
}

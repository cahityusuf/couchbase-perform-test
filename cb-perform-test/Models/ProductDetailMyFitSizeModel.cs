namespace cb_perform_test.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="ProductDetailMyFitSizeModel" />
    /// </summary>
    [Serializable]
    public class ProductDetailMyFitSizeModel
    {
        /// <summary>
        /// Gets or sets the ProductVariantMatrixId
        /// </summary>
        public Guid ProductVariantMatrixId { get; set; }

        /// <summary>
        /// Gets or sets the CustomerFitDataId
        /// </summary>
        public Guid CustomerFitDataId { get; set; }

        /// <summary>
        /// Gets or sets the SizeViewName
        /// </summary>
        public string SizeViewName { get; set; }
    }
}

namespace cb_perform_test.Models
{
    using Microsoft.VisualBasic;
    using System;

    /// <summary>
    /// Defines the <see cref="ProductIconDataModel" />.
    /// </summary>
    [Serializable]
    public class ProductIconDataModel : BaseDataModel
    {
        /// <summary>
        /// Gets or sets the LongCode.
        /// </summary>
        public string LongCode { get; set; }

        /// <summary>
        /// Gets or sets the ImagePath.
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets the EcomIconDefinition.
        /// </summary>
        public string EcomIconDefinition { get; set; }

        /// <summary>
        /// Gets or sets the ProductIconType.
        /// </summary>
        public Guid ProductIconType { get; set; }

        /// <summary>
        /// Gets or sets the ProductVariantId.
        /// </summary>
        public Guid ProductVariantId { get; set; }
    }
}

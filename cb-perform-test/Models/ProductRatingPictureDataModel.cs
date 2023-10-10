namespace cb_perform_test.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="ProductRatingPictureDataModel" />.
    /// </summary>
    [Serializable]
    public class ProductRatingPictureDataModel : BaseDataModel
    {
        /// <summary> Gets or sets the Product Variant id. </summary>
        public Guid ProductVariantRatingsId { get; set; }

        /// <summary> Gets or sets the Picture. </summary>
        public string Picture { get; set; }

        /// <summary> Gets or sets the Status id. </summary>
        public Guid StatusId { get; set; }
    }
}

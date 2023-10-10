namespace cb_perform_test.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="ProductRatingDataModel" />.
    /// </summary>
    [Serializable]
    public class ProductRatingDataModel
    {
        /// <summary>
        /// Gets or sets the RatingValue.
        /// </summary>
        public decimal RatingValue { get; set; }

        /// <summary>
        /// Gets or sets the RatingCount.
        /// </summary>
        public decimal RatingCount { get; set; }

        /// <summary>
        /// Gets or sets the CommentCount.
        /// </summary>
        public int CommentCount { get; set; }

        /// <summary>
        /// Gets or sets the Percentage.
        /// </summary>
        public decimal Percentage { get; set; }
    }
}

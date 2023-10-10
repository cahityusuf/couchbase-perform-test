namespace cb_perform_test.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ProductDetailRatingDataModel" />
    /// </summary>
    [Serializable]
    public class ProductDetailRatingDataModel
    {
        /// <summary>
        /// Gets or sets the AverateRating
        /// </summary>
        public decimal AverateRating { get; set; }

        /// <summary>
        /// Gets or sets the TotalRatingCount
        /// </summary>
        public decimal TotalRatingCount { get; set; }

        /// <summary>
        /// Gets or sets the TotalCommentCount
        /// </summary>
        public int TotalCommentCount { get; set; }

        /// <summary>
        /// Gets or sets the ProductRatingDataModelList
        /// </summary>
        public List<ProductRatingDataModel> ProductRatingDataModelList { get; set; }

        /// <summary>
        /// Gets or sets the ProductRatingDataModelList
        /// </summary>
        public List<ProductCommentDataModel> ProductCommentDataModelList { get; set; }

        /// <summary>
        /// Gets or sets the AveragePatterm
        /// </summary>
        public decimal AveragePattern { get; set; }

        /// <summary>
        /// Gets or sets the CommentsFlat
        /// </summary>
        public string CommentsFlat { get; set; }

        /// <summary>
        /// Gets or sets the CommentModel
        /// </summary>
        public List<ProductRatingCommentFlatDataModel> CommentDataModel { get; set; }
    }
}

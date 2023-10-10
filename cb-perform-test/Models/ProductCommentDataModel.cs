namespace cb_perform_test.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;

    /// <summary>
    /// Defines the <see cref="ProductCommentDataModel" />.
    /// </summary>
    [Serializable]
    public class ProductCommentDataModel
    {
        #region Private Properties

        /// <summary>The product rating picture models.</summary>
        private ICollection<ProductRatingPictureDataModel> productRatingPictureModel;

        #endregion

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the Rating.
        /// </summary>
        public decimal Rating { get; set; }

        /// <summary>
        /// Gets the CustomerFirstName.
        /// </summary>
        public string CustomerFirstName
        {
            get { return string.IsNullOrEmpty(CustomerFirstNameFull) ? "e***" : string.Format("{0}***", CustomerFirstNameFull.Substring(0, 1)); }
        }

        /// <summary>
        /// Gets or sets the CustomerFirstNameFull.
        /// </summary>
        public string CustomerFirstNameFull { get; set; }

        /// <summary>
        /// Gets the CustomerLastName.
        /// </summary>
        public string CustomerLastName
        {
            get { return string.IsNullOrEmpty(CustomerLastNameFull) ? "c***" : string.Format("{0}***", CustomerLastNameFull.Substring(0, 1)); }
        }

        /// <summary>
        /// Gets or sets the CustomerLastNameFull.
        /// </summary>
        public string CustomerLastNameFull { get; set; }

        /// <summary>
        /// Gets or sets the CommentDateTime.
        /// </summary>
        public DateTime CommentDateTime { get; set; }

        /// <summary>
        /// Gets the CommentDateTimeString.
        /// </summary>
        public string CommentDateTimeString
        {
            get { return CommentDateTime.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture); }
        }

        /// <summary>
        /// Gets or sets the LikeCount.
        /// </summary>
        public int LikeCount { get; set; }

        /// <summary>
        /// Gets or sets the UnLikeCount
        /// </summary>
        public int? UnLikeCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the IsUsernameVisible
        /// </summary>
        public bool? IsUsernameVisible { get; set; }

        /// <summary>
        /// Gets or sets the DisplayOrder
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the IsBought
        /// </summary>
        public bool? IsBought { get; set; }

        /// <summary>
        /// Gets or sets the PictureNames
        /// </summary>
        public string PictureNames { get; set; }

        /// <summary>
        /// Gets or sets the TotalCommentCount
        /// </summary>
        public int TotalCommentCount { get; set; }

        /// <summary>
        /// Gets or sets the TotalCommentCountWithPicture
        /// </summary>
        public int TotalCommentCountWithPicture { get; set; }

        /// <summary>Gets or sets the shop by region mappings.</summary>
        public virtual ICollection<ProductRatingPictureDataModel> ProductRatingPictures
        {
            get
            {
                return this.productRatingPictureModel ?? (this.productRatingPictureModel = new Collection<ProductRatingPictureDataModel>());
            }

            set
            {
                this.productRatingPictureModel = value;
            }
        }
    }
}

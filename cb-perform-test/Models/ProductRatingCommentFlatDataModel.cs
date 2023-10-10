namespace cb_perform_test.Models
{
    #region
    using System;
    #endregion

    /// <summary>
    /// Defines the ProductRatingCommentFlatDataModel
    /// </summary>
    [Serializable]
    public class ProductRatingCommentFlatDataModel
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the Rating
        /// </summary>
        public int Ratings { get; set; }

        /// <summary>
        /// Gets or sets the Firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Pattern
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets the CommentDateTime
        /// </summary>
        public string CommentDateTime { get; set; }
    }
}

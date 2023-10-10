using System;

namespace cb_perform_test.Models
{
    #region

    using System;

    #endregion

    /// <summary>
    /// The index stamp image v2 position
    /// </summary>
    [Serializable]
    public class IndexStampImageV2Position
    {
        /// <summary>
        /// Gets or sets the stamp image vertical margin
        /// </summary>
        public int StampImageVerticalMargin { get; set; }

        /// <summary>
        /// Gets or sets the stamp image horizontal margin
        /// </summary>
        public int StampImageHorizontalMargin { get; set; }

        /// <summary>
        /// Gets or sets the stamp image vertical alignment type id.
        /// </summary>
        public Guid StampImageVerticalAlignmentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the stamp image horizontal alignment type id.
        /// </summary>
        public Guid StampImageHorizontalAlignmentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the stamp platform type id.
        /// </summary>
        public Guid StampPlatformTypeId { get; set; }

        /// <summary>
        /// Gets or sets the stamp section type id.
        /// </summary>
        public Guid StampSectionTypeId { get; set; }

        /// <summary>Gets or sets the start date.</summary>
        public DateTime? StartDate { get; set; }

        /// <summary>Gets or sets the end date.</summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is category redirect
        /// </summary>
        public bool IsCategoryRedirect { get; set; }

        /// <summary>
        /// Gets or sets the Display order
        /// </summary>
        public int? DisplayOrder { get; set; }
    }
}

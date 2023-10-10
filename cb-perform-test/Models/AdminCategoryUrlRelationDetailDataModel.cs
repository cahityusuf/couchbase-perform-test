namespace cb_perform_test.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="AdminCategoryUrlRelationDetailDataModel" />.
    /// </summary>
    [Serializable]
    public class AdminCategoryUrlRelationDetailDataModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ImagePath.
        /// </summary>
        public string ImagePath { get; set; }
    }
}

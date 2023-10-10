namespace cb_perform_test.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="AdminCategoryUrlRelationCategoryDataModel" />.
    /// </summary>
    [Serializable]
    public class AdminCategoryUrlRelationCategoryDataModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the ParentId.
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ParentNameList.
        /// </summary>
        public string ParentNameList { get; set; }
    }
}

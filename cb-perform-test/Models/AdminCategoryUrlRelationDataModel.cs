using System;

namespace cb_perform_test.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AdminCategoryUrlRelationDataModel" />.
    /// </summary>
    [Serializable]
    public class AdminCategoryUrlRelationDataModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the RegionId.
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Gets or sets the CategoryId.
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Status.
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Gets or sets the CategoryDataModel.
        /// </summary>
        public AdminCategoryUrlRelationCategoryDataModel CategoryDataModel { get; set; }

        /// <summary>
        /// Gets or sets the DetailList.
        /// </summary>
        public List<AdminCategoryUrlRelationDetailDataModel> DetailList { get; set; }
    }
}

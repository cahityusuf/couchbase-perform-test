namespace cb_perform_test.Models
{
    #region

    using System;

    #endregion

    /// <summary>The category size table mapping data model.</summary>
    [Serializable]
    public class CategorySizeTableMappingDataModel : BaseDataModel
    {
        /// <summary>Gets or sets the category ıd.</summary>
        public Guid CategoryId { get; set; }

        /// <summary>Gets or sets the type ıd.</summary>
        public Guid TypeId { get; set; }
    }
}

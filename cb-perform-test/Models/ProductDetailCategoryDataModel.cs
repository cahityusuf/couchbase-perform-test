namespace cb_perform_test.Models
{
    #region

    using System;

    #endregion

    /// <summary>The product detail category data model.</summary>
    [Serializable]
    public class ProductDetailCategoryDataModel
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the category ındex.
        /// </summary>
        public int CategoryIndex { get; set; }

        /// <summary>
        /// Gets or sets the category level.
        /// </summary>
        public int CategoryLevel { get; set; }

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>Gets or sets the gtm name</summary>
        public string CategoryGtmName { get; set; }

        /// <summary>
        /// Gets or sets the category seo name.
        /// </summary>
        public string CategorySeoName { get; set; }

        /// <summary>Gets or sets the ıd.</summary>
        public Guid Id { get; set; }

        /// <summary>Gets or sets a value indicating whether ıs active.</summary>
        public bool IsActive { get; set; }

        /// <summary>Gets or sets the category lvl 1 </summary>
        public string CategoryLv1 { get; set; }

        /// <summary>Gets or sets the category lvl 2 </summary>
        public string CategoryLv2 { get; set; }

        /// <summary>Gets or sets the category lvl 3 </summary>
        public string CategoryLv3 { get; set; }

        #endregion
    }
}

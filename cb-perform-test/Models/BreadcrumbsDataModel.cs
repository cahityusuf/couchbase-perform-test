using System;

namespace cb_perform_test.Models
{
    using System;

    /// <summary>
    /// The breadcrumbs data model.
    /// </summary>
    [Serializable]
    public class BreadcrumbsDataModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the seo name.
        /// </summary>
        public string GtmName { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ıs url.
        /// </summary>
        public bool IsUrl { get; set; }
    }
}

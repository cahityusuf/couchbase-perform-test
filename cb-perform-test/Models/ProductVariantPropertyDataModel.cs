namespace cb_perform_test.Models
{
    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ProductVariantPropertyDataModel" />.
    /// </summary>
    [Serializable]
    public class ProductVariantPropertyDataModel
    {
        /// <summary>
        /// Gets or sets the AttributeName.
        /// </summary>
        
        public string AttributeName { get; set; }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the ProductWebNameAttributeId.
        /// </summary>
        public Guid ProductWebNameAttributeId { get; set; }

        /// <summary>
        /// Gets or sets ProductVariantId.
        /// </summary>
        public Guid ProductVariantId { get; set; }

        /// <summary>
        /// Gets or sets the ProductWebNameAttributeTagId.
        /// </summary>
        public Guid ProductWebNameAttributeTagId { get; set; }

        /// <summary>
        /// Gets or sets the TagName.
        /// </summary>
        

        /// <summary>
        /// Gets or sets the ProductWebNameAttributeTagRegionIds.
        /// </summary>
        public List<int> ProductWebNameAttributeTagRegionIds { get; set; }
    }
}

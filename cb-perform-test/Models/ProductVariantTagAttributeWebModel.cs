namespace cb_perform_test.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>The product detail picture mobile web model.</summary>
    [Serializable]
    public class ProductVariantTagAttributeWebModel
    {
        /// <summary> Gets or sets the product variant id</summary>
        public Guid ProductVariantId { get; set; }

        /// <summary> Gets or sets the Attribute Name </summary>
        public string AttributeName { get; set; }

        /// <summary> Gets or sets the Tag Name</summary>
        public string TagName { get; set; }

        /// <summary> Gets or sets the density</summary>
        public double Density { get; set; }

        /// <summary> Gets or sets the Tag Translation</summary>
        public List<WideEyesTagTranslation> TagTranslations { get; set; }
    }
}

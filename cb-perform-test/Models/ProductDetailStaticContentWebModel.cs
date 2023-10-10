namespace cb_perform_test.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>The product detail static content mobile web model.</summary>
    [Serializable]
    public class ProductDetailStaticContentWebModel
    {
        /// <summary>The product detail static content items.</summary>
        private ICollection<ProductDetailStaticContentItemWebModel> productDetailStaticContentItems;

        /// <summary>Gets or sets the name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the product detail static content items.</summary>
        public ICollection<ProductDetailStaticContentItemWebModel> ProductDetailStaticContentItems
        {
            get
            {
                return this.productDetailStaticContentItems ?? (this.productDetailStaticContentItems = new Collection<ProductDetailStaticContentItemWebModel>());
            }

            set
            {
                this.productDetailStaticContentItems = value;
            }
        }
    }
}

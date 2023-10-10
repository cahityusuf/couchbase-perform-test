namespace cb_perform_test.Models
{
    using System;

    /// <summary>The product detail product color web model.</summary>
    [Serializable]
    public class ProductDetailProductColorWebModel
    {
        /// <summary>Gets or sets the ıd.</summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the product variant id.
        /// </summary>
        public Guid ProductVariantId { get; set; }

        /// <summary>Gets or sets the product seo name.</summary>
        public string ProductSeoName { get; set; }

        /// <summary>Gets or sets the product variant seo name.</summary>
        public string ProductVariantSeoName { get; set; }

        /// <summary>
        /// Gets or sets the product variant color name.
        /// </summary>
        public string ProductVariantColorName { get; set; }

        /// <summary>
        /// Gets or sets the product variant ındex.
        /// </summary>
        public int? ProductVariantIndex { get; set; }

        /// <summary>Gets or sets the product variant parent color name.</summary>
        public string ProductVariantParentColorName { get; set; }

        /// <summary>
        /// Gets or sets the product variant picture name.
        /// </summary>
        public string ProductVariantPictureName { get; set; }

        /// <summary>
        /// Gets or sets the product variant picture name for big size.
        /// </summary>
        public string ProductVariantPictureNameBigSize { get; set; }
    }
}

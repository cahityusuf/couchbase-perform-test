namespace cb_perform_test.Models
{
    public enum StampSectionTypeEnum
    {
        /// <summary>
        /// The parent
        /// </summary>
        [GuidEnum("BE3F2D45-BBE8-4779-B14D-226A69CE2AFB")]
        Parent = 30000,

        /// <summary>
        /// The catalog
        /// </summary>
        [GuidEnum("73126B61-4100-43F3-B490-7E1AE2E8F465")]
        Catalog = 30010,

        /// <summary>
        /// The shopping cart
        /// </summary>
        [GuidEnum("CF4F46E0-0E55-4B49-838F-D9599DD41355")]
        ShoppingCart = 30020,

        /// <summary>
        /// The product detail
        /// </summary>
        [GuidEnum("BA0AD649-355B-41ED-9887-99136FBAEE4C")]
        ProductDetail = 30030,

        /// <summary>
        /// The product detail description
        /// </summary>
        [GuidEnum("F7F31866-D676-4000-B30A-7EBF4D560145")]
        ProductDetailDescription = 30040,

        /// <summary>
        /// The product detail info
        /// </summary>
        [GuidEnum("0D7A933D-EB0C-447F-A9F4-A9284C5DCF93")]
        ProductDetailInfo = 30050
    }
}

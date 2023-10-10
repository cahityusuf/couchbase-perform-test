namespace cb_perform_test.Models
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    #endregion

    /// <summary>The product detail web model.</summary>
    [Serializable]
    public class ProductDetailWebModel
    {
        /// <summary>The attributes.</summary>
        private List<GenericAttributeMiniWebModel> attributes;

        /// <summary>The breadcrumbs.</summary>
        private IEnumerable<BreadcrumbsDataModel> breadcrumbs;

        /// <summary>The customer product variant marks</summary>
        private IEnumerable<CustomerProductVariantMarkInfoDataModel> customerProductVariantMarks;

        /// <summary>The fashion models.</summary>
        private IEnumerable<FashionModelDataModel> fashionModels;

        /// <summary>The product detail pictures.</summary>
        private ICollection<ProductDetailPictureWebModel> productDetailPictures;

        /// <summary>The product detail categories.</summary>
        private ICollection<ProductDetailCategoryDataModel> productDetailCategories;

        /// <summary>The product detail product colors.</summary>
        private IEnumerable<ProductDetailProductColorWebModel> productDetailProductColors;

        /// <summary>The product detail size.</summary>
        private ProductDetailSizeWebModel productDetailSize;

        /// <summary>The product detail static contents.</summary>
        private ICollection<ProductDetailStaticContentWebModel> productDetailStaticContents;

        /// <summary>The stamp images.</summary>
        private IEnumerable<IndexStampImage> stampImages;

        /// <summary>The stamp images v2</summary>
        private IEnumerable<IndexStampImageV2> stampImagesV2;

        /// <summary>The stamp images v2 of under picture</summary>
        private IEnumerable<IndexStampImageV2> stampImagesV2OfUnderPicture;

        /// <summary>
        /// Gets or sets the product detail categories.
        /// </summary>
        public ICollection<ProductDetailCategoryDataModel> ProductDetailCategories
        {
            get
            {
                return productDetailCategories ?? (productDetailCategories = new Collection<ProductDetailCategoryDataModel>());
            }

            set
            {
                productDetailCategories = value;
            }
        }

        /// <summary>Gets or sets the breadcrumbs.</summary>
        public IEnumerable<BreadcrumbsDataModel> Breadcrumbs
        {
            get
            {
                return breadcrumbs ?? (breadcrumbs = new List<BreadcrumbsDataModel>());
            }

            set
            {
                breadcrumbs = value;
            }
        }

        /// <summary>Gets or sets product detail product colors.</summary>
        public IEnumerable<ProductDetailProductColorWebModel> ProductDetailProductColors
        {
            get
            {
                return productDetailProductColors ?? (productDetailProductColors = new List<ProductDetailProductColorWebModel>());
            }

            set
            {
                productDetailProductColors = value;
            }
        }

        /// <summary>Gets or sets the product detail size.</summary>
        public ProductDetailSizeWebModel ProductDetailSize
        {
            get
            {
                return productDetailSize ?? (productDetailSize = new ProductDetailSizeWebModel());
            }

            set
            {
                productDetailSize = value;
            }
        }

        /// <summary>Gets or sets the product detail static contents.</summary>
        public ICollection<ProductDetailStaticContentWebModel> ProductDetailStaticContents
        {
            get
            {
                return productDetailStaticContents ?? (productDetailStaticContents = new Collection<ProductDetailStaticContentWebModel>());
            }

            set
            {
                productDetailStaticContents = value;
            }
        }

        /// <summary>Gets or sets the stams images.</summary>
        public IEnumerable<IndexStampImage> StampImages
        {
            get
            {
                return stampImages ?? (stampImages = new List<IndexStampImage>());
            }

            set
            {
                stampImages = value;
            }
        }

        /// <summary>Gets or sets the stams images v2.</summary>
        public IEnumerable<IndexStampImageV2> StampImagesV2
        {
            get
            {
                return stampImagesV2 ?? (stampImagesV2 = new List<IndexStampImageV2>());
            }

            set
            {
                stampImagesV2 = value;
            }
        }

        /// <summary>Gets or sets the stams images v2 of under picture.</summary>
        public IEnumerable<IndexStampImageV2> StampImagesV2OfUnderPicture
        {
            get
            {
                return stampImagesV2OfUnderPicture ?? (stampImagesV2OfUnderPicture = new List<IndexStampImageV2>());
            }

            set
            {
                stampImagesV2OfUnderPicture = value;
            }
        }

        /// <summary>Gets or sets the stams images v2.</summary>
        public IEnumerable<StampImageV2ViewDataModel> StampImagesV2ViewModel { get; set; }

        /// <summary>Gets or sets the product attributes.</summary>
        public List<GenericAttributeMiniWebModel> ProductAttributes
        {
            get
            {
                return attributes ?? (attributes = new List<GenericAttributeMiniWebModel>());
            }

            set
            {
                attributes = value;
            }
        }

        /// <summary>Gets or sets the product detail pictures.</summary>
        public ICollection<ProductDetailPictureWebModel> ProductDetailPictures
        {
            get
            {
                return productDetailPictures ?? (productDetailPictures = new Collection<ProductDetailPictureWebModel>());
            }

            set
            {
                productDetailPictures = value;
            }
        }

        /// <summary>Gets or sets the fashion models.</summary>
        public IEnumerable<FashionModelDataModel> FashionModels
        {
            get
            {
                return fashionModels ?? (fashionModels = new List<FashionModelDataModel>());
            }

            set
            {
                fashionModels = value;
            }
        }

        /// <summary>Gets or sets the customer product variant marks</summary>
        public IEnumerable<CustomerProductVariantMarkInfoDataModel> CustomerProductVariantMarks
        {
            get
            {
                return customerProductVariantMarks ?? (customerProductVariantMarks = new List<CustomerProductVariantMarkInfoDataModel>());
            }

            set
            {
                customerProductVariantMarks = value;
            }
        }

        /// <summary>Gets or sets the category url relations</summary>
        public AdminCategoryUrlRelationDataModel CategoryUrlRelation { get; set; }

        /// <summary>Gets or sets the category erp description.</summary>
        public string CategoryErpDescription { get; set; }

        /// <summary>Gets or sets the composition description.</summary>
        public string CompositionDescription { get; set; }

        /// <summary>Gets or sets the product category id.</summary>
        public Guid ProductCategoryId { get; set; }

        /// <summary>Gets or sets the product category name.</summary>
        public string ProductCategoryName { get; set; }

        /// <summary>Gets or sets the gtm name</summary>
        public string CategoryGtmName { get; set; }

        /// <summary>Gets or sets the id.</summary>
        public Guid Id { get; set; }

        /// <summary>Gets or sets the product full description.</summary>
        public string ProductFullDescription { get; set; }

        /// <summary>Gets or sets the product full description 2.</summary>
        public string ProductFullDescription2 { get; set; }

        /// <summary>Gets or sets the Return Change Description.</summary>
        public string ReturnChangeDescription { get; set; }

        /// <summary>Gets or sets the product long code.</summary>
        public string ProductLongCode { get; set; }

        /// <summary>Gets or sets the product variant magento ındex.</summary>
        public int? ProductVariantMagentoIndex { get; set; }

        /// <summary>Gets or sets the product ıd.</summary>
        public Guid ProductId { get; set; }

        /// <summary>Gets or sets the product seo name.</summary>
        public string ProductSeoName { get; set; }

        /// <summary>Gets or sets the product variant seo name.</summary>
        public string ProductVariantSeoName { get; set; }

        /// <summary>Gets or sets the product name.</summary>
        public string ProductName { get; set; }

        /// <summary>Gets or sets the gtm name</summary>
        public string ProductGtmName { get; set; }

        /// <summary>Gets or sets the product variant color id.</summary>
        public Guid ProductVariantColorId { get; set; }

        /// <summary>Gets or sets the product variant color ıd.</summary>
        public Guid ProductVariantParentColorId { get; set; }

        /// <summary>Gets or sets the product variant description.</summary>
        public string ProductVariantDescription { get; set; }

        /// <summary>Gets or sets the product variant name.</summary>
        public string ProductVariantName { get; set; }

        /// <summary>Gets or sets the size charts.</summary>
        public string SizeChart { get; set; }

        /// <summary>Gets or sets the product detail static content header image.</summary>
        public string ProductDetailStaticContentHeaderImage { get; set; }

        /// <summary>Gets or sets the product variant color name.</summary>
        public string ProductVariantColorName { get; set; }

        /// <summary>Gets or sets the product variant color name.</summary>
        public string ProductVariantParentColorName { get; set; }

        /// <summary>Gets or sets the product variant color seo name.</summary>
        public string ProductVariantColorSeoName { get; set; }

        /// <summary>Gets or sets the color name as english</summary>
        public string ColorGtmName { get; set; }

        /// <summary>Gets or sets the meta title.</summary>
        public string MetaTitle { get; set; }

        /// <summary>Gets or sets the product gender.</summary>
        public string ProductGender { get; set; }

        /// <summary>Gets or sets the product variant ıd.</summary>
        public Guid ProductVariantId { get; set; }

        /// <summary>Gets or sets the product gender id.</summary>
        public Guid ProductGenderId { get; set; }

        /// <summary>Gets or sets the product variant index.</summary>
        public object ProductVariantIndex { get; set; }

        /// <summary>Gets or sets the meta description.</summary>
        public string MetaDescription { get; set; }

        /// <summary>Gets or sets the meta keywords.</summary>
        public string MetaKeywords { get; set; }

        /// <summary>Gets or sets the product installment price incl tax.</summary>
        public decimal? ProductInstallmentPriceInclTax { get; set; }

        /// <summary>Gets or sets the product price incl tax.</summary>
        public decimal? ProductPriceInclTax { get; set; }

        /// <summary>Gets or sets the product variant discounted installment price incl tax.</summary>
        public decimal? ProductVariantDiscountedInstallmentPriceInclTax { get; set; }

        /// <summary>Gets or sets the product variant discounted price ıncl tax.</summary>
        public decimal? ProductVariantDiscountedPriceInclTax { get; set; }

        /// <summary>Gets or sets the product color and category url.</summary>
        public string ProductColorAndCategoryUrl { get; set; }

        /// <summary>Gets or sets the product color and category name.</summary>
        public string ProductColorAndCategoryName { get; set; }

        /// <summary>Gets or sets the sample size name resource.</summary>
        public DynamicString SampleSizeNameResource { get; set; }

        /// <summary>Gets or sets the sample big size name resource.</summary>
        public DynamicString SampleBigSizeNameResource { get; set; }

        /// <summary>Gets or sets the merch sub group</summary>
        public MerchSubGroupDataModel MerchSubGroup { get; set; }

        /// <summary>Gets or sets the last category.</summary>
        public ProductDetailCategoryDataModel LastCategory { get; set; }

        /// <summary>Gets or sets the product season name.</summary>
        public string ProductSeasonName { get; set; }

        /// <summary>Gets or sets the product variant shop bies.</summary>
        public ICollection<ShopByOutletDataModel> ProductVariantShopBies { get; set; }

        /// <summary>Gets or sets the product classification.</summary>
        public ICollection<KeyValuePair<Guid, int>> ProductClassification { get; set; }

        /// <summary>Gets or sets the my fit data list id.</summary>
        public Guid MyFitDataListId { get; set; }

        /// <summary>Gets or sets the my fit customer fit data id.</summary>
        public Guid MyFitCustomerFitDataId { get; set; }

        /// <summary>Gets or sets the my fit product variant matrix size id list.</summary>
        public List<ProductDetailVariantSizeIdWebModel> MyFitProductVariantMatrixSizeIdList { get; set; }

        /// <summary>Gets or sets the my fit size model.</summary>
        public ProductDetailMyFitSizeModel MyFitSizeModel { get; set; }

        /// <summary> Gets or sets a value indicating whether PortalDiscountBadgeEnable. </summary>
        public bool PortalDiscountBadgeEnable { get; set; }

        /// <summary>Gets or sets the category size table mapping.</summary>
        public CategorySizeTableMappingDataModel CategorySizeTableMapping { get; set; }

        /// <summary>Gets or sets the currency</summary>
        public decimal CurrencyRate { get; set; }

        /// <summary>Gets or sets the CurrencyUsdRate</summary>
        public decimal CurrencyUsdRate { get; set; }

        /// <summary>Gets or sets the product main code.</summary>
        public string ProductMainCode { get; set; }

        /// <summary>Gets or sets the Wide Eyes Tags.</summary>
        public List<ProductVariantTagAttributeWebModel> WideEyesTags { get; set; }

        /// <summary>Gets or sets the product detail rating.</summary>
        public ProductDetailRatingDataModel ProductDetailRating { get; set; }

        /// <summary>Gets or sets the Product Variant Property Datas.</summary>
        public List<ProductVariantPropertyDataModel> ProductVariantPropertyDatas { get; set; }

        /// <summary>Gets or sets the campaign badge.</summary>
        public CampaignBadgeDataModel CampaignBadge { get; set; }

        /// <summary>Gets or sets the product supplier id.</summary>
        public Guid ProductSupplierId { get; set; }

        /// <summary>Gets or sets the estimated delivery text.</summary>
        public string EstimatedDeliveryText { get; set; }

        /// <summary>
        /// Gets or sets the product code..
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary> Gets or sets the out of stock text </summary>
        public string OutOfStockText { get; set; }

        /// <summary> Gets or sets the product category gender</summary>
        public Guid ProductCategoryGender { get; set; }

        /// <summary>Gets or sets the Product Benefit Icons.</summary>
        public List<ProductIconDataModel> ProductBenefitIcons { get; set; }

        /// <summary>Gets or sets the Product Washing Icons.</summary>
        public List<ProductIconDataModel> ProductWashingIcons { get; set; }

        /// <summary>
        /// Gets or sets the product code..
        /// </summary>
        public List<ProductVariantMatrixMeasurementWebModel> ProductVariantMatrixMeasurement { get; set; }

        /// <summary>Gets or sets the shelf life.</summary>
        public int ShelfLife { get; set; }

        /// <summary>Gets or sets the TotalProductStock.</summary>
        public int TotalProductStock { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is big size product
        /// </summary>
        public bool? IsBigSizeProduct { get; set; }

        /// <summary>Gets or sets the DeadlineTime.</summary>
        public DateTime? DeadlineTime { get; set; }

        /// <summary>Gets or sets the DeadlineTimeQuantity.</summary>
        public decimal? DeadlineTimeQuantity { get; set; }

        /// <summary>Gets or sets the DeadlineTimeBadgeUrl.</summary>
        public string DeadlineTimeBadgeUrl { get; set; }
    }
}
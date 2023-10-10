namespace cb_perform_test.Models
{
    using System;

    /// <summary>The merch sub group data model.</summary>
    [Serializable]
    public class MerchSubGroupDataModel : BaseDataModel
    {
        /// <summary>Gets or sets the name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the merch sub group ıd.</summary>
        public int MerchSubGroupId { get; set; }

        /// <summary>Gets or sets the type key.</summary>
        public string TypeKey { get; set; }

        /// <summary>Gets or sets the description.</summary>
        public string Description { get; set; }

        /// <summary>Gets or sets the merch alt grup id.</summary>
        public int? MerchAltGrupId { get; set; }
    }
}

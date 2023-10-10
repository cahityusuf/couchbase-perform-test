namespace cb_perform_test.Models
{
    #region

    using System;

    #endregion

    /// <summary>The shop by outlet data model.</summary>
    [Serializable]
    public class ShopByOutletDataModel
    {
        /// <summary>Gets or sets the ıd.</summary>
        public Guid Id { get; set; }

        /// <summary>Gets or sets a value indicating whether ıs out let.</summary>
        public bool IsOutLet { get; set; }

        /// <summary>Gets or sets the out of stock text.</summary>
        public string OutOfStockText { get; set; }

        /// <summary>Gets or sets a value indicating whether ıs big size.</summary>
        public bool IsBigSize { get; set; }
    }
}

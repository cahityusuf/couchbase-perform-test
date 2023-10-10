using System;

namespace cb_perform_test.Models
{
    #region

    using System;

    #endregion

    /// <summary>The fashion model data model.</summary>
    [Serializable]
    public class FashionModelDataModel : BaseNonGuidDataModel
    {
        #region Public Properties

        /// <summary>Gets or sets the bust.</summary>
        public int Bust { get; set; }

        /// <summary>Gets or sets the fasion model erp id.</summary>
        public int FasionModelErpId { get; set; }

        /// <summary>Gets or sets the first name.</summary>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the height.</summary>
        public decimal? Height { get; set; }

        /// <summary>Gets or sets the hips.</summary>
        public int? Hips { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        public string LastName { get; set; }

        /// <summary>Gets or sets the middle name.</summary>
        public string MiddleName { get; set; }

        /// <summary>Gets or sets the waist.</summary>
        public int? Waist { get; set; }

        /// <summary>Gets or sets the ProductId.</summary>
        public int ProductId { get; set; }

        /// <summary> Gets or sets a value indicating whether ıs big size. </summary>
        public bool BigSize { get; set; }

        #endregion
    }
}

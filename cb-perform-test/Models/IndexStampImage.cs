namespace cb_perform_test.Models
{
    #region

    using System;

    #endregion

    /// <summary>The ındex stamp ımage.</summary>
    [Serializable]
    public class IndexStampImage
    {
        /// <summary>Gets or sets the height.</summary>
        public int Height { get; set; }

        /// <summary>Gets or sets the ımage path.</summary>
        public string ImagePath { get; set; }

        /// <summary>Gets or sets the left.</summary>
        public int Left { get; set; }

        /// <summary>Gets or sets the left.</summary>
        public int LeftUnmodified { get; set; }

        /// <summary>Gets or sets the regin display number.</summary>
        public int ReginDisplayNumber { get; set; }

        /// <summary>Gets or sets the region ıd.</summary>
        public Guid RegionId { get; set; }

        /// <summary>Gets or sets the stamp def ıd.</summary>
        public Guid StampDefId { get; set; }

        /// <summary>Gets or sets the top.</summary>
        public int Top { get; set; }

        /// <summary>Gets or sets the top unmodified.</summary>
        public int TopUnmodified { get; set; }

        /// <summary>Gets or sets the width.</summary>
        public int Width { get; set; }
    }
}

using System;

namespace cb_perform_test.Models
{
    using System;

    /// <summary>The product detail picture mobile web model.</summary>
    [Serializable]
    public class ProductDetailPictureWebModel
    {
        /// <summary> Gets or sets the product picture name. </summary>
        public string ProductPictureName { get; set; }

        /// <summary> Gets or sets the product picture order. </summary>
        public int? ProductPictureOrder { get; set; }

        /// <summary>
        /// Gets or sets the Video path name.
        /// </summary>
        public string VideoPathName { get; set; }

        /// <summary>
        /// Gets or sets the is Auidble.
        /// </summary>
        public bool? IsAudible { get; set; }
    }
}

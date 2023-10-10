namespace cb_perform_test.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>The product detail picture mobile web model.</summary>
    [Serializable]
    public class WideEyesTagTranslation
    {
        /// <summary> Gets or sets the Attribute Name </summary>
        public string Language { get; set; }

        /// <summary> Gets or sets the Attribute Name </summary>
        public List<string> Tags { get; set; }
    }
}

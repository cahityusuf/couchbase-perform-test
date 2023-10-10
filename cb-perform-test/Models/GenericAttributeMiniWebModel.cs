namespace cb_perform_test.Models
{
    using System;

    /// <summary>The generic attribute mini web model.</summary>
    [Serializable]
    public class GenericAttributeMiniWebModel
    {
        /// <summary> Gets or sets the attribute id. </summary>
        public int AttributeIndex { get; set; }

        /// <summary> Gets or sets the attribute name. </summary>
        public string AttributeName { get; set; }

        /// <summary> Gets or sets the ıd. </summary>
        public Guid Id { get; set; }
    }
}

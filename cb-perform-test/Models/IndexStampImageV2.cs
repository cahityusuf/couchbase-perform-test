using System;
using System.Collections.Generic;

namespace cb_perform_test.Models
{
    /// <summary>
    /// The stamp image v2
    /// </summary>
    [Serializable]
    public class IndexStampImageV2
    {
        /// <summary>
        /// The stamp image positions
        /// </summary>
        private IEnumerable<IndexStampImageV2Position> stampImagePositions;

        /// <summary>
        /// Gets or sets the stamp image id
        /// </summary>
        public Guid StampImageId { get; set; }

        /// <summary>
        /// Gets or sets the shop by index
        /// </summary>
        public int? ShopByIndex { get; set; }

        /// <summary>
        /// Gets or sets the stamp image path
        /// </summary>
        public string StampImagePath { get; set; }

        /// <summary>
        /// Gets or sets the language index.
        /// </summary>
        public int? LanguageIndex { get; set; }

        /// <summary>
        /// Gets or sets the index stamp image positions
        /// </summary>
        public IEnumerable<IndexStampImageV2Position> StampImagePositions
        {
            get
            {
                return this.stampImagePositions ?? (this.stampImagePositions = new List<IndexStampImageV2Position>());
            }

            set
            {
                this.stampImagePositions = value;
            }
        }

        /// <summary>
        /// Gets or sets the Display order
        /// </summary>
        public int? DisplayOrder { get; set; }
    }
}

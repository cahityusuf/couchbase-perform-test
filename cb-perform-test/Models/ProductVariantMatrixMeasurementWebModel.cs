using System;

namespace cb_perform_test.Models
{
    using System;

    /// <summary>The affiliate product size model.</summary>
    [Serializable]
    public class ProductVariantMatrixMeasurementWebModel
    {
        /// <summary>
        /// Gets or sets the measurement name
        /// </summary>
        public string MeasurementName { get; set; }

        /// <summary>
        /// Gets or sets the measurement value
        /// </summary>
        public decimal MeasurementValue { get; set; }

        /// <summary>
        /// Gets or sets the product variant matrix index.
        /// </summary>
        public int ProductVariantMatrixIndex { get; set; }
    }
}

using System;

namespace cb_perform_test.Models
{
    /// <summary>
    /// The customer product variant mark info data model
    /// </summary>
    public class CustomerProductVariantMarkInfoDataModel
    {
        /// <summary>
        /// Gets or sets the product variant id.
        /// </summary>
        public Guid ProductVariantId { get; set; }

        /// <summary>
        /// Gets or sets the product variant matrix id.
        /// </summary>
        public Guid ProductVariantMatrixId { get; set; }

        /// <summary>
        /// Gets or sets the mark type id
        /// </summary>
        public Guid MarkTypeId { get; set; }

        /// <summary>
        /// Gets or sets the customer id.
        /// </summary>
        public Guid CustomerId { get; set; }
    }
}

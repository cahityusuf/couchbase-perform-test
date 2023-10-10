namespace cb_perform_test.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="CampaignBadgeDataModel" />.
    /// </summary>
    [Serializable]
    public class CampaignBadgeDataModel
    {
        /// <summary>
        /// Gets or sets the CampaignId.
        /// </summary>
        public Guid CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the CampaignDescription
        /// </summary>
        public string CampaignDescription { get; set; }

        /// <summary>
        /// Gets or sets the CalculationTypeId.
        /// </summary>
        public Guid CalculationTypeId { get; set; }

        /// <summary>
        /// Gets or sets the DiscountAmount.
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets the StartDate
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the EndDate
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}

namespace cb_perform_test.Models
{
    using Newtonsoft.Json;
    using System;

    /// <summary>The base non guid data model.</summary>
    [Serializable]
    public class BaseNonGuidDataModel
    {
        /// <summary> Gets or sets the id. </summary>
        public int Id { get; set; }

        /// <summary> Gets or sets a value indicating whether ıs active. </summary>
        public bool IsActive { get; set; }

        /// <summary> Gets or sets a value indicating whether ıs deleted. </summary>
        public bool IsDeleted { get; set; }

        /// <summary> Gets or sets the created user ıd. </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary> Gets or sets the created date time. </summary>
        public DateTime CreatedDateTime { get; set; }

        /// <summary> Gets or sets the updated user ıd. </summary>
        public Guid? UpdatedUserId { get; set; }

        /// <summary> Gets or sets the updated date time. </summary>
        public DateTime? UpdatedDateTime { get; set; }

        /// <summary>Gets or sets the entity state.</summary>
        [JsonIgnore]
        public DeFactoEntityStateEnum EntityState { get; set; }
    }
}

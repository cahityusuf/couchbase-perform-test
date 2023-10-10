namespace cb_perform_test.Models
{
    #region

    using System;

    #endregion

    /// <summary>The dynamic string.</summary>
    [Serializable]
    public class DynamicString
    {
        #region Constructors and Destructors

        /// <summary>Initializes a new instance of the <see cref="DynamicString"/> class.</summary>
        public DynamicString()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="DynamicString"/> class.</summary>
        /// <param name="id">The id.</param>
        /// <param name="defaultValue">The default value.</param>
        public DynamicString(Guid id, string defaultValue = "")
        {
            this.Id = id;
            this.Value = defaultValue;
        }

        #endregion

        #region Public Properties

        /// <summary>Gets or sets the ıd.</summary>
        public Guid Id { get; set; }

        /// <summary>Gets or sets the value.</summary>
        public string Value { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>The to string.</summary>
        /// <returns>The <see cref="string"/>.</returns>
        public override string ToString()
        {
            return this.Value;
        }

        #endregion
    }
}

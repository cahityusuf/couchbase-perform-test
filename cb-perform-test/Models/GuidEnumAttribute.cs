namespace cb_perform_test.Models
{
    using System;

    /// <summary>The guid enum attribute.</summary>
    public class GuidEnumAttribute : Attribute
    {
        /// <summary> Initializes a new instance of the <see cref="GuidEnumAttribute"/> class. </summary>
        /// <param name="s"> The s. </param>
        public GuidEnumAttribute(string s)
        {
            this.Guid = Guid.Parse(s);
        }

        /// <summary> Gets the guid. </summary>
        public Guid Guid { get; private set; }
    }
}

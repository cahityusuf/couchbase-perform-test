using System;
using System.Collections.Generic;

namespace cb_perform_test.Models
{
    /// <summary>
    /// The stamp image v2 view data model
    /// </summary>
    public class StampImageV2ViewDataModel
    {
        /// <summary>
        /// Gets or sets the stamp image path
        /// </summary>
        public string StampImagePath { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment style
        /// </summary>
        public string VerticalAlignmentStyle { get; set; }

        /// <summary>
        /// Gets or sets the horizontal alignment style
        /// </summary>
        public string HorizontalAlignmentStyle { get; set; }

        /// <summary>
        /// Gets or sets the horizontal alignment class name
        /// </summary>
        public string HorizontalAlignmentClassName { get; set; }

        /// <summary>
        /// Gets or sets the style as json
        /// </summary>
        public string StyleAsJon { get; set; }

        /// <summary>
        /// Gets or sets the stamp section type
        /// </summary>
        public StampSectionTypeEnum StampSectionType { get; set; }
    }
}

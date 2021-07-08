using System;
using System.Collections.Generic;
using System.Text;

namespace DataRec.Models
{
    public class ColumnHeader
    {
        /// <summary>
        /// The text of the column header.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The width of the column header.
        /// </summary>
        public string Width { get; set; }
        
        /// <summary>
        /// Contructor.
        /// </summary>
        /// <param name="text">The text contained in the column header. </param>
        /// <param name="width">The width of the column header as a percentage. </param>
        public ColumnHeader(string text, string width)
        {
            Text = text;
            Width = width;
        }
    }
}

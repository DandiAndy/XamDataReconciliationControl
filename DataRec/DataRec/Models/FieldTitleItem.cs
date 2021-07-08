using System;
using System.Collections.Generic;
using System.Text;

namespace DataRec.Models
{
    public class FieldTitleItem : IReconcileItem
    {
        public string Text { get; }
        public string Width { get; }

        public FieldTitleItem(string text, string width)
        {
            Text = text;
            Width = width;
        }
    }
}

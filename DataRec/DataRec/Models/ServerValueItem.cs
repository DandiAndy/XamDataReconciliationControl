using System;
using System.Collections.Generic;
using System.Text;

namespace DataRec.Models
{
    public class ServerValueItem : ValueItem
    {
        private bool _isSelected;

        public override string Text { get; }

        public override string Width { get; }
        public override bool IsSelected
        {
            get => _isSelected;
            set => _isSelected = value;
        }

        public ServerValueItem(string text, string width)
        {
            Text = text;
            Width = width;
        }
    }
}

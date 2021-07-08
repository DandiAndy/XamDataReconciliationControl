using System;
using System.Collections.Generic;
using System.Text;

namespace DataRec.Models
{
    public abstract class ValueItem : IReconcileItem
    {
        public abstract string Text { get; }
        public abstract string Width { get; }
        public abstract bool IsSelected { get; set; }
    }
}

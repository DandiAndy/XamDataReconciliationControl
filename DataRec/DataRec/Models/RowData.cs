using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataRec.Models
{
    public class RowData
    {
        public ObservableCollection<IReconcileItem> ReconcileItemCollection { get; }
        public IReconcileItem Selection => ReconcileItemCollection.FirstOrDefault(ri => ri is ValueItem vi && vi.IsSelected);
        public RowData(IEnumerable<IReconcileItem> reconcileItemCollection)
        {
            ReconcileItemCollection = new ObservableCollection<IReconcileItem>(reconcileItemCollection);
        }
    }
}

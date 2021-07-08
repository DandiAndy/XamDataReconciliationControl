using DataRec.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataRec.Selectors
{
    public class ReconcileItemTypeSelector : DataTemplateSelector
    {
        public DataTemplate TitleTemplate { get; set; }
        public DataTemplate ValueSelectionTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (!(item is IReconcileItem reconcileItem))
            {
                throw new ArgumentException($"Object must be of type {nameof(IReconcileItem)}.");
            }

            switch(reconcileItem)
            {
                case FieldTitleItem _:
                    return TitleTemplate;
                case ServerValueItem _:
                case ClientValueItem _:
                    return ValueSelectionTemplate;
                default:
                    throw new ArgumentException($"Template for {nameof(IReconcileItem)} of type {reconcileItem.GetType()} has not been setup.");
            }
        }
    }
}

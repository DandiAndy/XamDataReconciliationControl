using DataRec.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataRec.ViewModels
{
    public class BaseDataReconciliationViewModel
    {
        private const string COLUMN_WIDTH = "33%";
        public ObservableCollection<ColumnHeader> ColumnHeaderCollection { get; set; }
        public ObservableCollection<RowData> RowDataCollection { get; set; }

        public BaseDataReconciliationViewModel()
        {
            GenerateSampleData();
        }

        private void GenerateSampleData()
        {
            ColumnHeaderCollection = new ObservableCollection<ColumnHeader>
            {
                new ColumnHeader("Field", COLUMN_WIDTH),
                new ColumnHeader("CAD", COLUMN_WIDTH),
                new ColumnHeader("ePCR", COLUMN_WIDTH)
            };

            RowDataCollection = new ObservableCollection<RowData> 
            { 
                new RowData(new List<IReconcileItem>
                { 
                    new FieldTitleItem("Item 1", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 2", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 3", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 4", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 5", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 6", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 7", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 8", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 9", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 10", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 11", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 12", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 13", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 14", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 15", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 16", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 17", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 18", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 19", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 20", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 21", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 22", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 23", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 24", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
                new RowData(new List<IReconcileItem>
                {
                    new FieldTitleItem("Item 25", COLUMN_WIDTH),
                    new ServerValueItem("Yes", COLUMN_WIDTH),
                    new ClientValueItem("No", COLUMN_WIDTH),
                }),
            };
        }
    }
}

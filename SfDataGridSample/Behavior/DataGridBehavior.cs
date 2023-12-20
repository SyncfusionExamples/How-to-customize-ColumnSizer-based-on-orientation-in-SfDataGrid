using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample.Behaviors
{
    public class DataGridBehavior : Behavior<SfDataGrid>
    {
        protected override void OnAttachedTo(SfDataGrid dataGrid)
        {
            dataGrid.SizeChanged += ScrollOwner_SizeChanged;
            base.OnAttachedTo(dataGrid);
        }        

        protected override void OnDetachingFrom(SfDataGrid dataGrid)
        {
            dataGrid.SizeChanged -= ScrollOwner_SizeChanged;
            base.OnDetachingFrom(dataGrid);
        }
        private void ScrollOwner_SizeChanged(object? sender, EventArgs e)
        {
            SfDataGrid dataGrid = (SfDataGrid)sender;

            if (dataGrid.Width > dataGrid.Height)
                dataGrid.ColumnWidthMode = ColumnWidthMode.Fill;
            else
                dataGrid.ColumnWidthMode = ColumnWidthMode.Auto;
        }
    }
}

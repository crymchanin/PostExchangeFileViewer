using System.ComponentModel;
using System.Windows.Forms;


namespace PostExchangeFileViewer {
    public class ListViewEx : ListView {

        public ListViewEx() {
            ListViewColumnSorter = new ListViewColumnSorter();
            ListViewItemSorter = this.ListViewColumnSorter;
        }

        [ReadOnly(true)]
        [Browsable(false)]
        public ListViewColumnSorter ListViewColumnSorter { get; set; }

        protected override void OnColumnClick(ColumnClickEventArgs e) {
            base.OnColumnClick(e);

            if (e.Column == ListViewColumnSorter.SortColumn) {
                if (ListViewColumnSorter.Order == SortOrder.Ascending) {
                    ListViewColumnSorter.Order = SortOrder.Descending;
                }
                else {
                    ListViewColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else {
                ListViewColumnSorter.SortColumn = e.Column;
                ListViewColumnSorter.Order = SortOrder.Ascending;
            }
            Sort();
        }
    }
}

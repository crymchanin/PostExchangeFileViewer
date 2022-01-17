using System;
using System.Collections;
using System.Windows.Forms;


namespace PostExchangeFileViewer {
    public class ListViewColumnSorter : IComparer {
        private CaseInsensitiveComparer ObjectCompare;

        private bool IsStringDateTime(string str) {
            DateTime dateTime;
            return DateTime.TryParse(str, out dateTime);
        }

        public ListViewColumnSorter() {
            SortColumn = 0;
            Order = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y) {
            int compareResult;
            ListViewItem listviewX, listviewY;
            string textX, textY;

            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            textX = listviewX.SubItems[SortColumn].Text;
            textY = listviewY.SubItems[SortColumn].Text;

            if (IsStringDateTime(textX) && IsStringDateTime(textY)) {
                DateTime dateX = Convert.ToDateTime(textX);
                DateTime dateY = Convert.ToDateTime(textY);

                compareResult = ObjectCompare.Compare(dateX, dateY);
            }
            else {
                compareResult = ObjectCompare.Compare(textX, textY);
            }

            if (Order == SortOrder.Ascending) {
                return compareResult;
            }
            else if (Order == SortOrder.Descending) {
                return (-compareResult);
            }
            else {
                return 0;
            }
        }

        public int SortColumn { set; get; }

        public SortOrder Order { set; get; }

    }
}
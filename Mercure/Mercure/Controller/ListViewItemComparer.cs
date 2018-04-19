﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Comparer
/// </summary>
namespace Mercure.Controller
{
    class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            if (this.col == 4 || this.col == 5)
            {
                returnVal = float.Parse(((ListViewItem)x).SubItems[col].Text)> float.Parse(((ListViewItem)y).SubItems[col].Text)?1:-1;

            }
            else {
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                    ((ListViewItem)y).SubItems[col].Text);
            }
            
            
            // Determine whether the sort order is descending.
            if (order == SortOrder.Descending)
                // Invert the value returned by String.Compare.
                returnVal *= -1;
            return returnVal;
        }
    }
}

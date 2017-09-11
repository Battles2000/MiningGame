using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game_v._1
{
    public partial class Element
    {

        public string name;
        public int stockPrice;
        public bool stockGood;
        public int ID;

        public Element()
        {

        }

        public void setStockGood(bool e)
        {
            stockGood = e;
        }

        public bool getStockGood()
        {
            return stockGood;
        }

        public void setID(int e)
        {
            ID = e;
        }

        public int getID()
        {
            return ID;
        }


    }
}

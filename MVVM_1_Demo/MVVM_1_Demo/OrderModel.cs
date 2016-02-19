using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_1_Demo
{
    public class OrderModel:INotifyPropertyChanged
    {
        private string orderID;
        public string OrderID
        {   get { return orderID; }
            set
            {
                if (orderID == value)
                    return;
                orderID = value;
                NotifyPropertyChanged("OrderID");
            }
        }

        private string orderName;
        public string OrderName
        {
            get { return orderName; }
            set
            {
                if (orderName == value)
                    return;
                orderName = value;
                NotifyPropertyChanged("OrderName");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null )
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        } 
    }
}

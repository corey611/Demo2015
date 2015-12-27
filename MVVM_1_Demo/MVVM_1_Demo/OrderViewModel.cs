using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace MVVM_1_Demo
{
    public class OrderViewModel
    {
        public string Title { get; set; }

        public ObservableCollection<OrderModel> OrderModels { get; set; }
        public int TitleIndex { get; set; }

        public OrderViewModel()
        {
            Title = "TestTitle";
            TitleIndex = 0;
            OrderModels = new ObservableCollection<OrderModel>();
            OrderModels.Add(new OrderModel() { OrderID = "OrderID_1", OrderName = "OrderName_1" });
            OrderModels.Add(new OrderModel() { OrderID = "OrderID_2", OrderName = "OrderName_2" });
            OrderModels.Add(new OrderModel() { OrderID = "OrderID_3", OrderName = "OrderName_3" });
        }

        public void AddData()
        {
            Task.Factory.StartNew(() =>
            {
                Task.Delay(6000);
                OrderModels.Add(new OrderModel() { OrderID = "OrderID_1", OrderName = "OrderName_1" });
                OrderModels.Add(new OrderModel() { OrderID = "OrderID_2", OrderName = "OrderName_2" });
                OrderModels.Add(new OrderModel() { OrderID = "OrderID_3", OrderName = "OrderName_3" });
            });
        }
    }
}

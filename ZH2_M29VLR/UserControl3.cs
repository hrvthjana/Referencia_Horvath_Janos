using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_M29VLR
{
    public partial class UserControl3 : UserControl
    {
        Models.MyContext context = new Models.MyContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PlotView diagram = new PlotView();
            diagram.Dock = DockStyle.Fill;
            var model = new PlotModel();
            BarSeries barSeries = new BarSeries();
            CategoryAxis categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            model.Series.Add(barSeries);
            model.Axes.Add(categoryAxis);
            if (radioCategory.Checked == true)
            {
                model.Title = "Total Sales - SubCategory";
                var diagramQeery = from x in context.OrderProducts
                                   join oc in context.OrderCustomers on x.OrderId equals oc.OrderId
                                   group x by x.Product.SubCategory into grouped
                                   select new
                                   {
                                       GroupedKey = grouped.Key,
                                       Total = (double)grouped.Sum(x => x.Sales)
                                   };

                foreach (var item in diagramQeery)
                {
                    barSeries.Items.Add(new BarItem { Value = item.Total });
                    categoryAxis.Labels.Add(item.GroupedKey);
                }
            }
            else if (radioState.Checked == true)
            {
                model.Title = "Total Sales - State";
                var diagramQeery = from x in context.OrderProducts
                                   join oc in context.OrderCustomers on x.OrderId equals oc.OrderId
                                   group x by oc.Customer.PostalCodeNavigation.State into grouped
                                   select new
                                   {
                                       GroupedKey = grouped.Key,
                                       Total = (double)grouped.Sum(x => x.Sales)
                                   };

                foreach (var item in diagramQeery)
                {
                    barSeries.Items.Add(new BarItem { Value = item.Total });
                    categoryAxis.Labels.Add(item.GroupedKey);
                }
            }
            else if (radioSegment.Checked == true)
            {
                model.Title = "Total Sales - Segment";
                var diagramQeery = from x in context.OrderProducts
                                   join oc in context.OrderCustomers on x.OrderId equals oc.OrderId
                                   group x by oc.Customer.Segment into grouped
                                   select new
                                   {
                                       GroupedKey = grouped.Key,
                                       Total = (double)grouped.Sum(x => x.Sales)
                                   };

                foreach (var item in diagramQeery)
                {
                    barSeries.Items.Add(new BarItem { Value = item.Total });
                    categoryAxis.Labels.Add(item.GroupedKey);
                }
            }
            else
            {
                model.Title = "Total Sales - Year";
                var diagramQeery = from x in context.OrderProducts
                                   join oc in context.OrderCustomers on x.OrderId equals oc.OrderId
                                   group x by x.Order.OrderDate.Year into grouped
                                   orderby grouped.Key
                                   select new
                                   {
                                       GroupedKey = grouped.Key,
                                       Total = (double)grouped.Sum(x => x.Sales)
                                   };

                foreach (var item in diagramQeery)
                {
                    barSeries.Items.Add(new BarItem { Value = item.Total });
                    categoryAxis.Labels.Add(item.GroupedKey.ToString());
                }
            }



            diagram.Model = model;
            panel1.Controls.Add(diagram);
        }
    }
}

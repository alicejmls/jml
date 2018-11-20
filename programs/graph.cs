using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace programs
{
    public partial class graph : Form
    {
        
        public graph()
        {
            InitializeComponent();
            // 设置曲线的样式
            Series series = chart1.Series[0];
            // 画样条曲线（Spline）
            series.ChartType = SeriesChartType.Spline;
            // 线宽2个像素
            series.BorderWidth = 2;
            // 线的颜色：红色
            series.Color = System.Drawing.Color.Red;
            // 图示上的文字
            series.LegendText = "演示曲线";
            // 准备数据 
            float[] values = { 95, 30, 20, 23, 60, 87, 42, 77, 92, 51, 29 };

            // 在chart中显示数据
            int x = 0;
            foreach (float v in values)
            {
                series.Points.AddXY(x, v);
                x++;
            }

            // 设置显示范围
            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 10;
            chartArea.AxisY.Minimum = 0d;
            chartArea.AxisY.Maximum = 100d;


        }

        private void graph_Load(object sender, EventArgs e)
        {

        }
    }
}

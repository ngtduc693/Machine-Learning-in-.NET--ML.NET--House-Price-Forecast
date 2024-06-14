using Lib;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDuDoan_Click(object sender, EventArgs e)
        {
           
            var sampleData = new HousePriceForecast.ModelInput()
            {
                Quận = cbQuan.SelectedItem.ToString(),
                Loại_Hình = cbLoaiHinh.SelectedItem.ToString(),
                Pháp_Lý = cbPhapLy.SelectedItem.ToString(),
                Diện_tích_sử_dụng = (float)numDienTich.Value,
            };

            var result = HousePriceForecast.Predict(sampleData);
            lblGiaDuKien.Text = $"{result.Score}";

        }
    }
}

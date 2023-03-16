using Domen.Application;

namespace UI
{
    public partial class UploadExcel : Form
    {
        private readonly ExcelService _excelService;
        public UploadExcel()
        {
            InitializeComponent();
            _excelService = new ExcelService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;

            openFileDialog1.Filter = "Excel Worksheets|*.xlsx";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;

                var finished = _excelService.ConvertExcelToWord(path);

                if (finished)
                {
                    label1.Visible = true;
                    button2.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var result = _excelService.SaveToFile(saveFileDialog1.FileName);

                label3.Text = result;
                label3.Visible = true;
            }
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

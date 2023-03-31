using Domen.Application;
using Domen.Domain;

namespace UI
{
    public partial class UploadExcel : Form
    {
        private readonly ExcelService _excelService;
        private IEnumerable<GroupInformation> _groupInformationList;

        public UploadExcel()
        {
            InitializeComponent();
            _excelService = new ExcelService();
            _groupInformationList = new List<GroupInformation>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;

            openFileDialog1.Filter = "Excel Worksheets|*.xlsx";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;

                _groupInformationList = _excelService.ConvertToGroupInformation(path);

                if (!_groupInformationList.Any())
                {
                    label1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var converted = _excelService.ConvertToWordDocument(_groupInformationList);

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

        private void button3_Click(object sender, EventArgs e)
        {
            var converted = _excelService.ConvertToDocs(_groupInformationList);
        }
    }
}

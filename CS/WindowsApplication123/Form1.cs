using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace WindowsApplication123 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			XtraReport report = new XtraReport1();
			report.ShowPreviewDialog();
		}
	}
}
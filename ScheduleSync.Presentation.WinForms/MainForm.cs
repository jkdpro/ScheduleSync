using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleSync.Presentation.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openStopsTestButton_Click(object sender, EventArgs e)
        {
            using (StopListTestForm form = new StopListTestForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}

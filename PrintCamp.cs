using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CampData
{

    class PrintCamp
    {
        private Excel.Application exApp;
        private Excel.Workbook wkbk;
        private Excel.Worksheet wksht;

        public PrintCamp()
        {
            string appPath = Application.StartupPath;
            exApp = new Excel.Application();
            wkbk = exApp.Workbooks.Open(appPath + "\\printingTemplate.xlsx");
            //exApp.Visible = true;
            //.WriteLine(appPath);
            //DialogResult dialogResult = MessageBox.Show(appPath, "Path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void PrintLoadOut()
        {

        }

        public void PrintHookline()
        {

        }

        public void PrintSeatingChart()
        {

        }

        public void PrintIIPP6()
        {

        }

        public void PrintFC79()
        {

        }

        public void PrintFireRoll()
        {

        }
    }
}

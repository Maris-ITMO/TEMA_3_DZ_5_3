using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Media.Imaging;

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace TEMA_3_DZ_5_3
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "TEMA_3_DZ_5_3";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\Program Files\RevitAPITraining\";

            var panel = application.CreateRibbonPanel(tabName, "TEMA_3_DZ_5_3");

            var button1 = new PushButtonData("DZ_5_1", "Количество элементов", Path.Combine(utilsFolderPath, "TEMA_3_DZ_5_1.dll"), "TEMA_3_DZ_5_1.Main");
            var button2 = new PushButtonData("DZ_5_2", "Смена типа стены", Path.Combine(utilsFolderPath, "TEMA_3_DZ_5_2.dll"), "TEMA_3_DZ_5_2.Main");

            panel.AddItem(button1);
            panel.AddItem(button2);

            return Result.Succeeded;
        }
    }
}

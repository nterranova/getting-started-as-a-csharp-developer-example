using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRevitAddin
{
    public class Main : IExternalApplication
    {

        public PaneProvider Pane;

        public Result OnStartup(UIControlledApplication app)
        {
            try
            {
                app.CreateRibbonTab("MyRevitTab");
                app.CreateRibbonPanel("MyRevitTab", "RevitPanel1");
                CreateDockablePane(app);

            }
            catch (Exception ex)
            {
                TaskDialog.Show("My Revit Addin Loaded", ex.ToString());
                return Result.Failed;
            }

            //var ribbonPanel = app.GetRibbonPanels
            TaskDialog.Show("My Revit Addin Loaded", "Load succeded");
            return Result.Succeeded;
        }

        private void CreateDockablePane(UIControlledApplication a)
        {
            var PanelId = new DockablePaneId(Guid.NewGuid());
            Pane = new PaneProvider();
            a.RegisterDockablePane(PanelId, "IMEG Properties", Pane);
        }

        public Result OnShutdown(UIControlledApplication app)
        {

            return Result.Succeeded;
        }

    }

}

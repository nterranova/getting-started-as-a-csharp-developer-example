using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyRevitAddin
{
    public class PaneProvider : IDockablePaneProvider, IFrameworkElementCreator
    {
        private YourPage _page;

        public void SetupDockablePane(DockablePaneProviderData data)
        {
            data.FrameworkElementCreator = this;
            data.InitialState = new DockablePaneState();
            data.VisibleByDefault = false;
            data.EditorInteraction = new EditorInteraction(EditorInteractionType.KeepAlive);
            data.InitialState.DockPosition = DockPosition.Right;
            data.InitialState.TabBehind = DockablePanes.BuiltInDockablePanes.ProjectBrowser;
        }

        public FrameworkElement CreateFrameworkElement()
        {
            _page = new YourPage
            {
                WebView =
                    {
                        Source = new Uri("https://www.google.com/")
                    }
            };

            return _page;
        }
    }
}

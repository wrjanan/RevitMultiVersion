#region Namespaces
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB.Events;
using System;
using System.Reflection;
using RevitMultiVersionPlugin.Commands;
using RevitMultiVersionPlugin.Utilities;
using RevitMultiVersionPlugin.Properties;

#endregion

namespace RevitMultiVersionPlugin
{
    class App : IExternalApplication
    {
        private void EditUI(UIControlledApplication a)
        {
            var tabName = "RevitMultiVersion";
            var panelName = "Test Buttons";

            RevitUi.AddRibbonTab(a, tabName);
            var testPanel = RevitUi.AddRibbonPanel(a, tabName, panelName);

            string testTitle = "Say Hello";
            var btnListLinks = RevitUi.AddPushButton(testPanel, testTitle, typeof(SayHelloCmd), Resources.information, Resources.information, typeof(AvailableIfOpenDoc));
            btnListLinks.ToolTip = "Message Prompt";

        }

        public Result OnStartup(UIControlledApplication a)
        {
            EditUI(a);
            a.ControlledApplication.DocumentOpened += ControlledApplication_DocumentOpened;

            return Result.Succeeded;
        }

        private void ApplicationInitialized(object sender, ApplicationInitializedEventArgs e)
        {

        }

        private void ControlledApplication_DocumentOpened(object sender, Autodesk.Revit.DB.Events.DocumentOpenedEventArgs e)
        {

        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
        private class AvailableIfOpenDoc : IExternalCommandAvailability
        {
            public bool IsCommandAvailable(UIApplication applicationData, CategorySet selectedCategories)
            {
                if (applicationData.ActiveUIDocument != null && applicationData.ActiveUIDocument.Document != null)
                    return true;
                return false;
            }
        }
    }
}

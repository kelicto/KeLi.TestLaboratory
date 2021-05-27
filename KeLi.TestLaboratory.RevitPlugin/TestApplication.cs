using Autodesk.Revit.UI;

namespace KeLi.TestLaboratory.RevitPlugin
{
    public class TestApplication : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}

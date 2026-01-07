using ExcelDna.Integration;
using ExcelDna.Registration;
using ExcelDna.IntelliSense;

namespace MinimumCaseAddIn
{
    public class SmallAddIn : IExcelAddIn {
        public void AutoOpen() {
            ExcelRegistration.GetExcelFunctions()
                .ProcessParamsRegistrations()
                .ProcessAsyncRegistrations(nativeAsyncIfAvailable: false)
                .RegisterFunctions();
            IntelliSenseServer.Install();
        }

        public void AutoClose() {
            IntelliSenseServer.Uninstall();
        }
    }
    public class Colours
    {
        [ExcelFunction(Name = "ROYGBIV")]
        public static int Rgb(int red, int green, int blue, bool windowsStyle = true) {
            // for some reason windows is fn flipped? This makes no sense tbh 
            if (windowsStyle)
                return (int)(blue * Math.Pow(256, 2)) + green * 256 + red;
            else
                return (int)(red * Math.Pow(256, 2)) + green * 256 + blue;
        }
    }
}

using ExcelDna.Integration;

namespace FunctionsExternal {
    public class DummyAddIn : IExcelAddIn {
        public void AutoOpen() { }

        public void AutoClose() {}
    }
    public class SuperAddition {
        [ExcelFunction(Name = "SUPAADD", Description = "Super Addition, it happens, but you cant control the inputs")]
        public static object[,] SupaAdd() {
            return new object[,] { { "Hello World" } };
        }
    }
}

// one of the purposes of namespaces is so our types do not clash
namespace LinkedIn.Essentials // traditional namespace
{
    static class Constants
    {
        private static string connectionString;
        public static readonly string CONFIG_SERVER_NAME = "TargetServer";
        public const string CONFIG_DB_NAME = "DataBase";

        public static int MyProperty { get; set; }
        public static DateTime GetDateTimeFromDateOnly(DateOnly input)
        {
            return new DateTime(input.Year, input.Month, input.Day);
        }
        static Constants()
        {
            connectionString = "Server=..."; // config
        }
    }
}
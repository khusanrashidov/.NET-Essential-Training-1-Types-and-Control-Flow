namespace LinkedIn.Essentials // C# 8 namespace
{
    static class Constants
    {
        private static string connectionString; // The string is private, meaning, it is available within this class or within the type itself.
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
// For a class or a record or a struct, the default access modifier for its visibility is internal.
// That means that it's accessible within this set of compiled together files or within the assembly.

// public - accessible to all
// private - accessible just within that scope or within that type
// internal - available within the library
// protected - accessible only to those derived types from base type
// private protected
// proteced internal
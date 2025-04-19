namespace LinkedIn.Essentials
{
    static class Constants
    {
        // Everything in static class must be static: constructor, members, data fields, properties.

        public static string connectionString;
        public static readonly string CONFIG_SERVER_NAME = "TargetServer";
        public const string CONFIG_DB_NAME = "DataBaseName";
        public static int MyProperty { get; set; }
        public static DateTime GetDateTimeFromDateOnly(DateOnly date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }

        static Constants() // Access modifiers are not allowed on static constructors. Also, we can use static constructors inside of instance or non-static classes.
        {
            connectionString = "Server=..."; // config
        }
    }
}
namespace View
{
    internal static class Program
    {
        internal static Color iconForeColor = Color.FromArgb(0, 125, 250);
        internal static Color iconBackColor = Color.Transparent;
        internal static Color primaryBackColor = Color.FromArgb(24, 30, 54);
        internal static Color secondaryBackColor = Color.FromArgb(46, 51, 73);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Container());
        }
    }
}
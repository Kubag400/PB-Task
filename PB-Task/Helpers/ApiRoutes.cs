namespace PB_Task.Helpers
{
    public class ApiRoutes
    {
        public const string Root = "api/";
        public const string Version = "v1/" ;
        public const string Base = Root + Version;
        public static class AddressBook
        {
            private const string _controllerName = Base + "AddressBook/";

            public const string Add = _controllerName + "add";
            public const string FindByCity = _controllerName + "{city}";
            public const string GetLastAddress = _controllerName + "lastaddress";
        }
    }
}

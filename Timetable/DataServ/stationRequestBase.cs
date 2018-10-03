namespace DataService.BaseF
{
    internal static class StationRequestBase
    {
        internal static readonly string FuncName = "getStationOrAddrByText";
        internal static readonly string[] SearchIn = { "stations" };
        internal static readonly short MaxResults = 120;
        internal static readonly short[] Networks = { 1, 2, 3 };
        internal static readonly string CurrentLang = "hu";
    }
}
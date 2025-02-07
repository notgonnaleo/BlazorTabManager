namespace BlazorTabManagerApp.Util
{
    public class TabDataService
    {
        // Maybe create a proper data object for it instead of using dictionary?
        public Dictionary<Type, object> TabData { get; set; } = new Dictionary<Type, object>();

        // Maybe we should separate it? 
        public T GetOrCreateTabData<T>(Type tab)
        {
            if (TabData.ContainsKey(tab))
            {
                return (T)TabData[tab];
            }
            else
            {
                var newData = Activator.CreateInstance<T>();
                TabData[tab] = newData;
                return newData;
            }
        }
    }
}

namespace BlazorTabManagerApp.Util
{
    public class TabDataService
    {
        public Dictionary<Type, object> TabData { get; set; } = new Dictionary<Type, object>();
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

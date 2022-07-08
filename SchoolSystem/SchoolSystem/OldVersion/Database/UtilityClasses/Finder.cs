 
namespace OldVersion
{
    internal class Finder
    {
        public static T FindandReturn<T>(string name, string lastName, List<T> list)
        {
            foreach (IListedObjects<T> t in list)
            {
                if (t.GetName().Equals(name, StringComparison.OrdinalIgnoreCase) &&
                        t.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return (T)t;
                }
            }
            return default;
        }
    }
}

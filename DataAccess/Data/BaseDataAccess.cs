namespace DataAccess.Data
{
    internal static class BaseDataAccess
    {
        static MecaDB db = new MecaDB();

        internal static MecaDB DB { get => db; set => db = value; }
    }
}

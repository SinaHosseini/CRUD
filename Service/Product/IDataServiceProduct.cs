
public interface IDataServiceProduct
{
    public Task<IEnumerable<TableModel>> Table1Select();
    public Task<DbR> TableChange(int type, TableModel tm);
}


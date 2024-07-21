using Type.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
public interface IDataServiceProduct
{
    public Task<IEnumerable<TableModel>> Table1Select();
    public Task<DbR> TableChange(int type, TableModel tm);
    public Task<IEnumerable<TypeModel>> TypeSelect();
    public Task<DbR> TypeChange(int type, TypeModel appMode);
    public Task<IEnumerable<string>> GetTableType();
}


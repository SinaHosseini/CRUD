using Type.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IDataServiceProduct
{
    Task<IEnumerable<string>> GetProductType();
    Task<IEnumerable<ProductModel>> ProductModelSelect();
    public Task<DbR> ProductChange(int type, TableModel tm);
    Task<DbR> ProductChange(int type, ProductModel appModel);
    Task<IEnumerable<TypeModel>> TypeSelect();
    Task<DbR> TypeChange(int type, TypeModel appMode);
}


using Type.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public partial class DataServiceProduct : IDataServiceProduct
{
    public async Task<IEnumerable<TypeModel>> TypeSelect()
        => await new ClsBase().GetAllList<TypeModel>();

    public async Task<DbR> TypeChange(int type, TypeModel appModel)
    {
        DbR dbR = new DbR();
        switch (type)
        {
            case 1:
                dbR.InsertedId = await new ClsBase().InsertOne(appModel);
                break;
            case 2:
                dbR.Flg = await new ClsBase().UpdateOne(appModel);
                break;
            case 3:
                dbR.Flg = await new ClsBase().DeleteOne(appModel);
                break;
        }
        return dbR;
    }

    public async Task<IEnumerable<ProductModel>> ProductModelSelect()
    => await new ClsBase().strQueryasyn<ProductModel>(@"SELECT
                                                               t1.Id,
                                                               t1.Name,
                                                               t1.Price,
                                                               t2.IdType,
                                                               t2.NameType,
                                                               t1.TimeAdd,
                                                               t1.TimeUpdate
                                                             FROM dbo.Table_1 t1
                                                             INNER JOIN dbo.Table_2 t2
                                                             ON t1.IdType = t2.IdType;");

    public async Task<DbR> ProductChange(int type, TableModel tm)
    {
        DbR dbR = new DbR();
        switch (type)
        {
            case 1:
                dbR.InsertedId = await new ClsBase().InsertOne(tm);
                break;
            case 2:
                dbR.Flg = await new ClsBase().UpdateOne(tm);
                break;
            case 3:
                dbR.Flg = await new ClsBase().DeleteOne(tm);
                break;
        }
        return dbR;
    }

    public async Task<DbR> TableChange(int type, ProductModel appModel)
    {
        DbR dbR = new DbR();
        switch (type)
        {
            case 1:
                dbR.InsertedId = await new ClsBase().InsertOne(appModel);
                break;
            case 2:
                dbR.Flg = await new ClsBase().UpdateOne(appModel);
                break;
            case 3:
                dbR.Flg = await new ClsBase().DeleteOne(appModel);
                break;
        }
        return dbR;
    }

    public async Task<IEnumerable<ProductModel>> GetPeoductType()
        => await new ClsBase().strQueryasyn<ProductModel>("SELECT NameType FROM dbo.Table_2");
}



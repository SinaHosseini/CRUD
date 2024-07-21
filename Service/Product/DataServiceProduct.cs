using Type.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public partial class DataServiceProduct : IDataServiceProduct
{
    public async Task<IEnumerable<TableModel>> Table1Select()
     => await new ClsBase().GetAllList<TableModel>();
    public async Task<DbR> TableChange(int type, TableModel tm)
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

    public async Task<IEnumerable<string>> GetTableType()
        => await new ClsBase().strQueryasyn<string>("SELECT NameType FROM dbo.Table_2");
}



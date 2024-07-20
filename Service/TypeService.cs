using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class TypeService
{
    private readonly YourDbContext _context;

    public TypeService(YourDbContext context)
    {
        _context = context;
    }

    public async Task<List<TypeModel>> GetTypesAsync()
    {
        return await _context.Table_2
            .Select(t => new TypeModel { IdType = t.Id, NameType = t.Name })
            .ToListAsync();
    }
}

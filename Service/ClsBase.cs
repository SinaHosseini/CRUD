using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
 
using System.Data;

 
    public class ClsBase
    {
        public async Task<int> strQueryFirstOrDefault(string sql, object? param = null)
        {
            int entries = 0;
            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();
                    entries = await conn.QueryFirstOrDefaultAsync<int>(sql, param);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return entries;
        }

        public async Task<IEnumerable<T>> strQueryasyn<T>(string sql, object? param = null )
        {
            IEnumerable<T>? entries = null;
 
            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();
 
                    entries = await conn.QueryAsync<T>(sql, param , commandType: CommandType.Text);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return entries;
        }

        public async Task<IEnumerable<T>> Queryasyn<T>(string sql, object param)
        {
            IEnumerable<T> entries = null;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    entries = await conn.QueryAsync<T>(sql, param, commandType: CommandType.StoredProcedure);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return entries;
        }

        public async Task<int> strExecuteAsync(string sql, object? param = null)
        {
            int result = 0;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    result = await conn.ExecuteAsync(sql,param, commandType: CommandType.Text);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return result;
        }

        public async Task<int> ExecuteAsync(string sql, object param)
        {
            int result = 0;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    result = await conn.ExecuteAsync(sql, param, commandType: CommandType.StoredProcedure);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return result;
        }

        public async Task<int> InsertOne<TEntity>(TEntity entity) where TEntity : class
        {
            int result = 0;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    result = await conn.InsertAsync(entity);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return result;
        }

        public async Task<bool> UpdateOne<TEntity>(TEntity entity) where TEntity : class
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    result = await conn.UpdateAsync(entity);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return result;
        }

        public async Task<bool> DeleteOne<TEntity>(TEntity entity) where TEntity : class
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    result = await conn.DeleteAsync(entity);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return result;
        }

        public async Task<TEntity> GetOne<TEntity>(int Id) where TEntity : class
        {
            TEntity entries = null;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    entries = await conn.GetAsync<TEntity>(Id);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return entries;
        }

        public async Task<IEnumerable<TEntity>> GetAllList<TEntity>() where TEntity : class
        {
            IEnumerable<TEntity> entries = null;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    entries = await conn.GetAllAsync<TEntity>();
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return entries;
        }

        public async Task<int> InsertList<TEntity>(List<TEntity> entities)
        {
            int result = 0;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    result = await conn.InsertAsync(entities);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return result;
        }

        public async Task<bool> UpdateList<TEntity>(List<TEntity> entities)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    result = await conn.UpdateAsync(entities);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return result;
        }

        public async Task<bool> DeleteList<TEntity>(List<TEntity> entities)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(StaticValues.DefaultConnectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        await conn.OpenAsync();

                    result = await conn.DeleteAsync(entities);
                }
                catch
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        await conn.CloseAsync();
                }
            }
            return result;
        }
    }
 


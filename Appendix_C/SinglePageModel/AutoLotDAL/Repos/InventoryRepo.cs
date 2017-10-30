using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.Models;

namespace AutoLotDAL.Repos
{
	public class InventoryRepo : BaseRepo, IRepo<Inventory>
	{
		public int Add(Inventory entity)
		{
			Context.Inventory.Add(entity);
			return SaveChanges();
		}

		public Task<int> AddAsync(Inventory entity)
		{
			Context.Inventory.Add(entity);
			return SaveChangesAsync();
		}

		public int AddRange(IList<Inventory> entities)
		{
			Context.Inventory.AddRange(entities);
			return SaveChanges();
		}
		public Task<int> AddRangeAsync(IList<Inventory> entities)
		{
			Context.Inventory.AddRange(entities);
			return SaveChangesAsync();
		}
		public int Save(Inventory entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			return SaveChanges();
		}

		public Task<int> SaveAsync(Inventory entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			return SaveChangesAsync();
		}

		public int Delete(int id, byte[] timeStamp)
		{
			Context.Entry(new Inventory()
			{
				CarId=id,
				Timestamp = timeStamp
			}).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(int id, byte[] timeStamp)
		{
			Context.Entry(new Inventory()
			{
				CarId = id,
				Timestamp = timeStamp
			}).State = EntityState.Deleted;
			return SaveChangesAsync();
		}

		public int Delete(Inventory entity)
		{
			Context.Entry(entity).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(Inventory entity)
		{
			Context.Entry(entity).State = EntityState.Deleted;
			return SaveChangesAsync();
		}

		public Inventory GetOne(int? id)
			=> Context.Inventory.Find(id);

		public Task<Inventory> GetOneAsync(int? id)
			=> Context.Inventory.FindAsync(id);

		public List<Inventory> GetAll()
			=> Context.Inventory.ToList();

		public Task<List<Inventory>> GetAllAsync()
			=> Context.Inventory.ToListAsync();

		public List<Inventory> ExecuteQuery(string sql)
			=> Context.Inventory.SqlQuery(sql).ToList();

		public Task<List<Inventory>> ExecuteQueryAsync(string sql)
			=> Context.Inventory.SqlQuery(sql).ToListAsync();
		public List<Inventory> ExecuteQuery(
			string sql, object[] sqlParametersObjects)
			=> Context.Inventory.SqlQuery(sql, sqlParametersObjects).ToList();
		public Task<List<Inventory>> ExecuteQueryAsync(
			string sql, object[] sqlParametersObjects)
			=> Context.Inventory.SqlQuery(sql).ToListAsync();
	}
}

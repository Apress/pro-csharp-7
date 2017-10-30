using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.Models;

namespace AutoLotDAL.Repos
{
	public class OrderRepo:BaseRepo,IRepo<Order>
	{
		public int Add(Order entity)
		{
			Context.Orders.Add(entity);
			return SaveChanges();
		}

		public Task<int> AddAsync(Order entity)
		{
			Context.Orders.Add(entity);
			return SaveChangesAsync();
		}

		public int AddRange(IList<Order> entities)
		{
			Context.Orders.AddRange(entities);
			return SaveChanges();
		}
		public Task<int> AddRangeAsync(IList<Order> entities)
		{
			Context.Orders.AddRange(entities);
			return SaveChangesAsync();
		}
		public int Save(Order entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			return SaveChanges();
		}

		public Task<int> SaveAsync(Order entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			return SaveChangesAsync();
		}

		public int Delete(int id, byte[] timeStamp)
		{
			Context.Entry(new Order()
			{
				OrderId = id,
				Timestamp = timeStamp
			}).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(int id, byte[] timeStamp)
		{
			Context.Entry(new Order()
			{
				OrderId = id,
				Timestamp = timeStamp
			}).State = EntityState.Deleted;
			return SaveChangesAsync();
		}
		public int Delete(Order entity)
		{
			Context.Entry(entity).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(Order entity)
		{
			Context.Entry(entity).State = EntityState.Deleted;
			return SaveChangesAsync();
		}

		public Order GetOne(int? id) 
			=> Context.Orders.Find(id);

		public Task<Order> GetOneAsync(int? id) 
			=> Context.Orders.FindAsync(id);

		public List<Order> GetAll() 
			=> Context.Orders.ToList();

		public Task<List<Order>> GetAllAsync() 
			=> Context.Orders.ToListAsync();

		public List<Order> ExecuteQuery(string sql) 
			=> Context.Orders.SqlQuery(sql).ToList();

		public Task<List<Order>> ExecuteQueryAsync(string sql) 
			=> Context.Orders.SqlQuery(sql).ToListAsync();
		public List<Order> ExecuteQuery(
			string sql, object[] sqlParametersObjects) 
			=> Context.Orders.SqlQuery(sql, sqlParametersObjects).ToList();
		public Task<List<Order>> ExecuteQueryAsync(
			string sql, object[] sqlParametersObjects) 
			=> Context.Orders.SqlQuery(sql).ToListAsync();
	}
}

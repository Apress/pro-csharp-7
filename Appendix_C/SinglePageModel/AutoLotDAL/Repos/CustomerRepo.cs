using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.Models;

namespace AutoLotDAL.Repos
{
	public class CustomerRepo:BaseRepo,IRepo<Customer>
	{
		public int Add(Customer entity)
		{
			Context.Customers.Add(entity);
			return SaveChanges();
		}

		public Task<int> AddAsync(Customer entity)
		{
			Context.Customers.Add(entity);
			return SaveChangesAsync();
		}

		public int AddRange(IList<Customer> entities)
		{
			Context.Customers.AddRange(entities);
			return SaveChanges();
		}
		public Task<int> AddRangeAsync(IList<Customer> entities)
		{
			Context.Customers.AddRange(entities);
			return SaveChangesAsync();
		}
		public int Save(Customer entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			return SaveChanges();
		}

		public Task<int> SaveAsync(Customer entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			return SaveChangesAsync();
		}

		public int Delete(int id, byte[] timeStamp)
		{
			Context.Entry(new Customer()
			{
				CustId = id,
				Timestamp = timeStamp
			}).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(int id, byte[] timeStamp)
		{
			Context.Entry(new Customer()
			{
				CustId = id,
				Timestamp = timeStamp
			}).State = EntityState.Deleted;
			return SaveChangesAsync();
		}
		public int Delete(Customer entity)
		{
			Context.Entry(entity).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(Customer entity)
		{
			Context.Entry(entity).State = EntityState.Deleted;
			return SaveChangesAsync();
		}

		public Customer GetOne(int? id) 
			=> Context.Customers.Find(id);

		public Task<Customer> GetOneAsync(int? id) 
			=> Context.Customers.FindAsync(id);

		public List<Customer> GetAll() 
			=> Context.Customers.ToList();

		public Task<List<Customer>> GetAllAsync() 
			=> Context.Customers.ToListAsync();

		public List<Customer> ExecuteQuery(string sql) 
			=> Context.Customers.SqlQuery(sql).ToList();

		public Task<List<Customer>> ExecuteQueryAsync(string sql) 
			=> Context.Customers.SqlQuery(sql).ToListAsync();
		public List<Customer> ExecuteQuery(
			string sql, object[] sqlParametersObjects) 
			=> Context.Customers.SqlQuery(sql, sqlParametersObjects).ToList();
		public Task<List<Customer>> ExecuteQueryAsync(
			string sql, object[] sqlParametersObjects) 
			=> Context.Customers.SqlQuery(sql).ToListAsync();
	}
}

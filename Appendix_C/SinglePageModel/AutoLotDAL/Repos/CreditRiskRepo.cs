using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.Models;

namespace AutoLotDAL.Repos
{
	public class CreditRiskRepo:BaseRepo,IRepo<CreditRisk>
	{
		public int Add(CreditRisk entity)
		{
			Context.CreditRisks.Add(entity);
			return SaveChanges();
		}

		public Task<int> AddAsync(CreditRisk entity)
		{
			Context.CreditRisks.Add(entity);
			return SaveChangesAsync();
		}

		public int AddRange(IList<CreditRisk> entities)
		{
			Context.CreditRisks.AddRange(entities);
			return SaveChanges();
		}
		public Task<int> AddRangeAsync(IList<CreditRisk> entities)
		{
			Context.CreditRisks.AddRange(entities);
			return SaveChangesAsync();
		}
		public int Save(CreditRisk entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			return SaveChanges();
		}

		public Task<int> SaveAsync(CreditRisk entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			return SaveChangesAsync();
		}

		public int Delete(int id, byte[] timeStamp)
		{
			Context.Entry(new CreditRisk()
			{
				CustId = id,
				Timestamp = timeStamp
			}).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(int id, byte[] timeStamp)
		{
			Context.Entry(new CreditRisk()
			{
				CustId = id,
				Timestamp = timeStamp
			}).State = EntityState.Deleted;
			return SaveChangesAsync();
		}
		public int Delete(CreditRisk entity)
		{
			Context.Entry(entity).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(CreditRisk entity)
		{
			Context.Entry(entity).State = EntityState.Deleted;
			return SaveChangesAsync();
		}

		public CreditRisk GetOne(int? id) 
			=> Context.CreditRisks.Find(id);

		public Task<CreditRisk> GetOneAsync(int? id) 
			=> Context.CreditRisks.FindAsync(id);

		public List<CreditRisk> GetAll() 
			=> Context.CreditRisks.ToList();

		public Task<List<CreditRisk>> GetAllAsync() 
			=> Context.CreditRisks.ToListAsync();

		public List<CreditRisk> ExecuteQuery(string sql) 
			=> Context.CreditRisks.SqlQuery(sql).ToList();

		public Task<List<CreditRisk>> ExecuteQueryAsync(string sql) 
			=> Context.CreditRisks.SqlQuery(sql).ToListAsync();
		public List<CreditRisk> ExecuteQuery(
			string sql, object[] sqlParametersObjects) 
			=> Context.CreditRisks.SqlQuery(sql, sqlParametersObjects).ToList();
		public Task<List<CreditRisk>> ExecuteQueryAsync(
			string sql, object[] sqlParametersObjects) 
			=> Context.CreditRisks.SqlQuery(sql).ToListAsync();
	}
}

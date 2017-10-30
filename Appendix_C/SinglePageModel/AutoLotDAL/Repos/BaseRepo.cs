using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.EF;

namespace AutoLotDAL.Repos
{
	public abstract class BaseRepo: IDisposable
	{
		public AutoLotEntities Context { get; } 
			= new AutoLotEntities();

		internal int SaveChanges()
		{
			try
			{
				return Context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException ex)
			{
				//Thrown when there is a concurrency errors
				//If Entries propery is null, no records were modified
				//entities in Entries threw error due to timestamp/conncurrency
				//for now, just rethrow the exception
				throw;
			}
			catch (DbUpdateException ex)
			{
				//Thrown when database update fails
				//Examine the inner execption(s) for additional 
				//details and affected objects
				//for now, just rethrow the exception
				throw;
			}
			catch (CommitFailedException ex)
			{
				//handle transaction failures here
				//for now, just rethrow the exception
				throw;
			}
			catch (Exception ex)
			{
				//some other exception happened and should be handled
				throw;
			}
		}
		internal async Task<int> SaveChangesAsync()
		{
			try
			{
				return await Context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException ex)
			{
				//Thrown when there is a concurrency errors
				//for now, just rethrow the exception
				throw;
			}
			catch (DbUpdateException ex)
			{
				//Thrown when database update fails
				//Examine the inner execption(s) for additional 
				//details and affected objects
				//for now, just rethrow the exception
				throw;
			}
			catch (CommitFailedException ex)
			{
				//handle transaction failures here
				//for now, just rethrow the exception
				throw;
			}
			catch (Exception ex)
			{
				//some other exception happened and should be handled
				throw;
			}
		}

		bool disposed = false;
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (disposed)
				return;

			if (disposing)
			{
				Context.Dispose();
				// Free any managed objects here. 
				//
			}

			// Free any unmanaged objects here. 
			//
			disposed = true;
		}
	}

}

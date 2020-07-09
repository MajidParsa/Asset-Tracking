using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AssetTracking.Domain.SeedWork;

namespace AssetTracking.Domain.AggregatesModel.AssetAggregate
{
	public interface IAssetRepository : IRepository<Asset>
	{
		Task<bool> Insert(Asset asset);
	}
}

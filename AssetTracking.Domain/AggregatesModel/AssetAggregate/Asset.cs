using System;
using System.Collections.Generic;
using System.Text;
using AssetTracking.Domain.Exceptions;
using AssetTracking.Domain.SeedWork;

namespace AssetTracking.Domain.AggregatesModel.AssetAggregate
{
	public class Asset : Entity, IAggregateRoot
	{
		public int Id { get; private set; }
		public int AssetGroupId { get; private set; }
		public string SerialNo { get; private set; }
		public string Title { get; private set; }


		private Asset(int id, int assetGroupId, string serialNo, string title)
		{
			if (assetGroupId < 1)
				throw new AssetTrackingDomainException("Invalid assetGroupId", 
					new ArgumentOutOfRangeException("assetGroupId is less than one"));

			Id = id;
			AssetGroupId = assetGroupId;
			SerialNo = serialNo;
			Title = title;
		}

		public static Asset CreateAsset(int id, int assetGroupId, string serialNo, string title)
		{
			return new Asset(id, assetGroupId, serialNo, title);
		}

	}
}

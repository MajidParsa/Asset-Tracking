using System;
using System.Collections.Generic;
using System.Text;
using AssetTracking.Domain.SeedWork;

namespace AssetTracking.Domain.AggregatesModel.AssetAggregate
{
	public class AssetGroup : Entity
	{
		public int Id { get; private set; }
		public string Code { get; private set; }
		public string Title { get; private set; }

		private AssetGroup(int id, string code, string title)
		{
			Id = id;
			Code = code;
			Title = title;
		}

		public static AssetGroup CreateAssetGroup(int id, string code, string title)
		{
			return new AssetGroup(id, code, title);
		}

	}
}

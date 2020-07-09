using AssetTracking.Domain.AggregatesModel.AssetAggregate;
using AssetTracking.Domain.Exceptions;
using Xunit;
using Xunit.Sdk;

namespace AssetTracking.UnitTests.Domain.AggregatesModel
{
	public class AssetTests
	{
		private const int ValidId = 1;
		private const string ValidSeriaNo = "A-1234567890";
		private const string ValidTitle = "Test";

		[Theory]
		[InlineData(0)]
		[InlineData(-1)]
		public void CreateAsset_InvalidAssetGroupId_ExceptionShouldBeThrown(int assetGroupid)
		{
			// Act and Assert
			Assert.Throws<AssetTrackingDomainException>(() => Asset.CreateAsset(ValidId, assetGroupid, ValidSeriaNo, ValidTitle));
		}
	}
}

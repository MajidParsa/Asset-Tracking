using System;
using System.Collections.Generic;
using System.Text;

namespace AssertTracking.Infrastructure.Exceptions
{
	public class AssetTrackingInfrastructureException : Exception
	{
		public AssetTrackingInfrastructureException()
		{
		}

		public AssetTrackingInfrastructureException(string message) : base(message)
		{
		}

		public AssetTrackingInfrastructureException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}

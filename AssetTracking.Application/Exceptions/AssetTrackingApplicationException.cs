using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking.Application.Exceptions
{
	public class AssetTrackingApplicationException: Exception
	{
		public AssetTrackingApplicationException()
		{
		}

		public AssetTrackingApplicationException(string message) : base(message)
		{
		}

		public AssetTrackingApplicationException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}

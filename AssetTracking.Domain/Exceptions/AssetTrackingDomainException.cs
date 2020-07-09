using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking.Domain.Exceptions
{
	public class AssetTrackingDomainException : Exception
	{
		public AssetTrackingDomainException()
		{
		}

		public AssetTrackingDomainException(string message) : base(message)
		{
		}

		public AssetTrackingDomainException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}

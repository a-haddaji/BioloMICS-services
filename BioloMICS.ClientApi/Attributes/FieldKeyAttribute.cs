using System;
using System.Collections.Generic;
using System.Text;

namespace BioloMICS.ClientApi.Attributes
{
	[System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	sealed class FieldKeyAttribute : Attribute
	{
		// See the attribute guidelines at 
		//  http://go.microsoft.com/fwlink/?LinkId=85236
		readonly long _key;

		// This is a positional argument
		public FieldKeyAttribute(long key)
		{
			this._key = key;
		}

		public long Key
		{
			get { return _key; }
		}
	}
}

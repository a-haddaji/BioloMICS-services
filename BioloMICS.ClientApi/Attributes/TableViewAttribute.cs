using System;

namespace BioloMICS.ClientApi.Attributes
{
	[System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public sealed class TableViewAttribute : Attribute
	{
		// See the attribute guidelines at 
		//  http://go.microsoft.com/fwlink/?LinkId=85236
		readonly string tableViewName;

		// This is a positional argument
		public TableViewAttribute(string name)
		{
			this.tableViewName = name;
		}

		public string TableViewName
		{
			get { return tableViewName; }
		}
	}
}

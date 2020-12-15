using BioloMICS.ClientApi.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BioloMICS.ClientApi.Model
{
	public abstract class EntityBase
	{
		[FieldKey((long)FieldTypeEnum.RecordId)]
		public int Id { get; set; }
		[FieldKey((long)FieldTypeEnum.RecordName)]
		public string Name { get; set; }
		[FieldKey((long)FieldTypeEnum.Owner)]
		public string OwnerEmail { get; set; }
		[FieldKey((long)FieldTypeEnum.CreationDate)]
		public DateTime CreationDate { get; set; }
		[FieldKey((long)FieldTypeEnum.LastChangeDate)]
		public DateTime LastChangeDate { get; set; }
		[FieldKey((long)FieldTypeEnum.LastChangeUser)]
		public string LastChangeUserEmail { get; set; }
	}
}

using System.Collections.Generic;

namespace BioloMICS.ClientApi.Model
{
	public class ValueOfFieldRLink : ValueOfFieldBase
	{
		//Public Property Value As New List(Of RLinkValueEntity)
		public List<RecordValueEntity> Value { get; set; } = new List<RecordValueEntity>();

		public ValueOfFieldRLink()
		{
			FieldType = FieldTypeEnum.RLink;
		}
	}
}

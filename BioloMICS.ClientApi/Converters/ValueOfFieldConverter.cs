using System;
using BioloMICS.ClientApi.Model;
using Newtonsoft.Json.Linq;

namespace BioloMICS.ClientApi.Converters
{
		public class ValueOfFieldConverter : JsonReaderConverter<ValueOfFieldBase>
		{
			public override bool CanConvert(Type type)
			{
				return typeof(ValueOfFieldBase).IsAssignableFrom(type);
			}

			protected override ValueOfFieldBase Create(Type p_ObjectType, JObject p_JObject)
			{
				FieldTypeEnum fieldType;
				if (p_JObject.Property("FieldType").Value.Type == JTokenType.String)
				{
					fieldType = (FieldTypeEnum)Enum.Parse(typeof(FieldTypeEnum), p_JObject.Property("FieldType").Value.ToString());
				}
				else
				{
					fieldType = (FieldTypeEnum)Convert.ToInt32(p_JObject.Property("FieldType").Value);
				}
				return RecordFieldValueFactory.GetFieldValueInstance(fieldType);
			}
		}

		public class RecordFieldValueFactory
		{
			public static ValueOfFieldBase GetFieldValueInstance(FieldTypeEnum p_FieldType)
			{
				ValueOfFieldBase result = null;
				switch (p_FieldType)
				{
					case FieldTypeEnum.RecordId:
						result = new ValueOfFieldI();
						break;
					case FieldTypeEnum.RecordName:
						result = new ValueOfFieldE();
						break;
					case FieldTypeEnum.CreationDate:
						result = new ValueOfFieldH();
						break;
					case FieldTypeEnum.LastChangeDate:
						result = new ValueOfFieldH();
						break;
					case FieldTypeEnum.Owner:
						result = new ValueOfFieldE();
						break;
					case FieldTypeEnum.LastChangeUser:
						result = new ValueOfFieldE();
						break;
					case FieldTypeEnum.A:
						result = new ValueOfFieldA();
						break;
					case FieldTypeEnum.C:
						result = new ValueOfFieldC();
						break;
					case FieldTypeEnum.D:
						result = new ValueOfFieldD();
						break;
					case FieldTypeEnum.E:
						result = new ValueOfFieldE();
						break;
					case FieldTypeEnum.F:
						result = new ValueOfFieldF();
						break;
					case FieldTypeEnum.H:
						result = new ValueOfFieldH();
						break;
					case FieldTypeEnum.I:
						result = new ValueOfFieldI();
						break;
					case FieldTypeEnum.K:
						result = new ValueOfFieldK();
						break;
					case FieldTypeEnum.L:
						result = new ValueOfFieldL();
						break;
					case FieldTypeEnum.M:
						result = new ValueOfFieldM();
						break;
					case FieldTypeEnum.N:
						result = new ValueOfFieldN();
						break;
					case FieldTypeEnum.O:
						result = new ValueOfFieldO();
						break;
					case FieldTypeEnum.S:
						result = new ValueOfFieldS();
						break;
					case FieldTypeEnum.T:
						result = new ValueOfFieldT();
						break;
					case FieldTypeEnum.U:
						result = new ValueOfFieldU();
						break;
					case FieldTypeEnum.V:
						result = new ValueOfFieldV();
						break;
					case FieldTypeEnum.W:
						result = new ValueOfFieldW();
						break;
					//case FieldTypeEnum.Y:
					//	result = new ValueOfFieldY();
					//	break;
					case FieldTypeEnum.Syn:
						result = new ValueOfFieldSyn();
						break;
					case FieldTypeEnum.ALink:
					case FieldTypeEnum.CLink:
					case FieldTypeEnum.DLink:
					case FieldTypeEnum.ELink:
					case FieldTypeEnum.HLink:
					case FieldTypeEnum.ILink:
					case FieldTypeEnum.KLink:
					case FieldTypeEnum.LLink:
					case FieldTypeEnum.MLink:
					case FieldTypeEnum.NLink:
					case FieldTypeEnum.OLink:
					case FieldTypeEnum.RLink:
					case FieldTypeEnum.SLink:
					case FieldTypeEnum.SynLink:
					case FieldTypeEnum.TLink:
					case FieldTypeEnum.VLink:
					case FieldTypeEnum.WLink:
					case FieldTypeEnum.FLink:
						result = new ValueOfFieldLinkWithTargetRecords(p_FieldType);

						break;
					default:
						result = new ValueOfFieldE();
						break;
				}
				return result;
			}

		}

}
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace BioloMICS.ClientApi.Converters
{
	public abstract class JsonReaderConverter<T> : JsonConverter
	{
		//Read only converter.
		public override bool CanWrite { get { return false; } }

		/// <summary>
		/// Create an instance of objectType, based properties in the JSON object
		/// </summary>
		/// <paramname="p_ObjectType">type of object expected</param>
		/// <paramname="p_JObject">
		/// contents of JSON object that will be deserialized
		/// </param>
		/// <returns></returns>
		protected abstract T Create(Type p_ObjectType, JObject p_JObject);

		public override bool CanConvert(Type objectType)
		{
			return typeof(T).IsAssignableFrom(objectType);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}
			// Load JObject from stream
			JObject jObject__1 = JObject.Load(reader);

			// Create target object based on JObject
			T target = this.Create(objectType, jObject__1);

			// Populate the object properties
			serializer.Populate(jObject__1.CreateReader(), target);
			return target;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}

namespace BioloMICS.ClientApi.Model
{
		public class FileInfoEntity
		{
			#region Properties

			public string FullPath { get; set; }

			public string FileName { get; set; }

			public string IconPath { get; set; }

			public bool IsImage { get; set; }

			public int Id { get; set; }

			public string RecordName { get; set; }

			public long FileSize { get; set; }

			#endregion
		}
}
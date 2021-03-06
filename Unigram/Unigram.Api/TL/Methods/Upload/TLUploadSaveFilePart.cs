// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Upload
{
	/// <summary>
	/// RCP method upload.saveFilePart
	/// </summary>
	public partial class TLUploadSaveFilePart : TLObject
	{
		public Int64 FileId { get; set; }
		public Int32 FilePart { get; set; }
		public Byte[] Bytes { get; set; }

		public TLUploadSaveFilePart() { }
		public TLUploadSaveFilePart(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UploadSaveFilePart; } }

		public override void Read(TLBinaryReader from)
		{
			FileId = from.ReadInt64();
			FilePart = from.ReadInt32();
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xB304A621);
			to.Write(FileId);
			to.Write(FilePart);
			to.WriteByteArray(Bytes);
		}
	}
}
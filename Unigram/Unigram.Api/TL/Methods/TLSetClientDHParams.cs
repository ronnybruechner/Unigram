// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method set_client_DH_params
	/// </summary>
	public partial class TLSetClientDHParams : TLObject
	{
		public TLInt128 Nonce { get; set; }
		public TLInt128 ServerNonce { get; set; }
		public Byte[] EncryptedData { get; set; }

		public TLSetClientDHParams() { }
		public TLSetClientDHParams(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.SetClientDHParams; } }

		public override void Read(TLBinaryReader from)
		{
			Nonce = new TLInt128(from);
			ServerNonce = new TLInt128(from);
			EncryptedData = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF5045F1F);
			to.WriteObject(Nonce);
			to.WriteObject(ServerNonce);
			to.WriteByteArray(EncryptedData);
		}
	}
}
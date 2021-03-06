// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getInlineBotResults
	/// </summary>
	public partial class TLMessagesGetInlineBotResults : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			GeoPoint = (1 << 0),
		}

		public bool HasGeoPoint { get { return Flags.HasFlag(Flag.GeoPoint); } set { Flags = value ? (Flags | Flag.GeoPoint) : (Flags & ~Flag.GeoPoint); } }

		public Flag Flags { get; set; }
		public TLInputUserBase Bot { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public TLInputGeoPointBase GeoPoint { get; set; }
		public String Query { get; set; }
		public String Offset { get; set; }

		public TLMessagesGetInlineBotResults() { }
		public TLMessagesGetInlineBotResults(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetInlineBotResults; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Bot = TLFactory.Read<TLInputUserBase>(from);
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			if (HasGeoPoint) GeoPoint = TLFactory.Read<TLInputGeoPointBase>(from);
			Query = from.ReadString();
			Offset = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x514E999D);
			to.Write((Int32)Flags);
			to.WriteObject(Bot);
			to.WriteObject(Peer);
			if (HasGeoPoint) to.WriteObject(GeoPoint);
			to.Write(Query);
			to.Write(Offset);
		}

		private void UpdateFlags()
		{
			HasGeoPoint = GeoPoint != null;
		}
	}
}
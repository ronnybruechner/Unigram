// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTextUrl : TLRichTextBase 
	{
		public TLRichTextBase Text { get; set; }
		public String Url { get; set; }
		public Int64 WebpageId { get; set; }

		public TLTextUrl() { }
		public TLTextUrl(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TextUrl; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
			Url = from.ReadString();
			WebpageId = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3C2884C1);
			to.WriteObject(Text);
			to.Write(Url);
			to.Write(WebpageId);
		}
	}
}
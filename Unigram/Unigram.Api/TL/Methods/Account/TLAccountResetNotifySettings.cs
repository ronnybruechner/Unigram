// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.resetNotifySettings
	/// </summary>
	public partial class TLAccountResetNotifySettings : TLObject
	{
		public TLAccountResetNotifySettings() { }
		public TLAccountResetNotifySettings(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountResetNotifySettings; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDB7E1747);
		}
	}
}
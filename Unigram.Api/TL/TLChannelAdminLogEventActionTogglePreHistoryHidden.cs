// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLChannelAdminLogEventActionTogglePreHistoryHidden : TLChannelAdminLogEventActionBase 
	{
		public Boolean NewValue { get; set; }

		public TLChannelAdminLogEventActionTogglePreHistoryHidden() { }
		public TLChannelAdminLogEventActionTogglePreHistoryHidden(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelAdminLogEventActionTogglePreHistoryHidden; } }

		public override void Read(TLBinaryReader from)
		{
			NewValue = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteBoolean(NewValue);
		}
	}
}
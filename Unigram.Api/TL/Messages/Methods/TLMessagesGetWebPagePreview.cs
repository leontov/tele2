// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.getWebPagePreview.
	/// Returns <see cref="Telegram.Api.TL.TLMessageMediaBase"/>
	/// </summary>
	public partial class TLMessagesGetWebPagePreview : TLObject
	{
		public String Message { get; set; }

		public TLMessagesGetWebPagePreview() { }
		public TLMessagesGetWebPagePreview(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetWebPagePreview; } }

		public override void Read(TLBinaryReader from)
		{
			Message = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Message ?? string.Empty);
		}
	}
}
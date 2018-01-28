// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockBlockquote : TLPageBlockBase 
	{
		public TLRichTextBase Text { get; set; }
		public TLRichTextBase Caption { get; set; }

		public TLPageBlockBlockquote() { }
		public TLPageBlockBlockquote(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockBlockquote; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
			Caption = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Text);
			to.WriteObject(Caption);
		}
	}
}
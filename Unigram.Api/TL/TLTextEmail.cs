// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLTextEmail : TLRichTextBase 
	{
		public TLRichTextBase Text { get; set; }
		public String Email { get; set; }

		public TLTextEmail() { }
		public TLTextEmail(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TextEmail; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
			Email = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Text);
			to.WriteString(Email ?? string.Empty);
		}
	}
}
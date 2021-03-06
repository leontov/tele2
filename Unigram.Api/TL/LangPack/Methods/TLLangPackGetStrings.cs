// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.LangPack.Methods
{
	/// <summary>
	/// RCP method langpack.getStrings.
	/// Returns <see cref="Telegram.Api.TL.TLVector<TLLangPackString>"/>
	/// </summary>
	public partial class TLLangPackGetStrings : TLObject
	{
		public String LangCode { get; set; }
		public TLVector<String> Keys { get; set; }

		public TLLangPackGetStrings() { }
		public TLLangPackGetStrings(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.LangPackGetStrings; } }

		public override void Read(TLBinaryReader from)
		{
			LangCode = from.ReadString();
			Keys = TLFactory.Read<TLVector<String>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(LangCode ?? string.Empty);
			to.WriteObject(Keys);
		}
	}
}
// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Account
{
	public partial class TLAccountAuthorizations : TLObject 
	{
		public TLVector<TLAuthorization> Authorizations { get; set; }

		public TLAccountAuthorizations() { }
		public TLAccountAuthorizations(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountAuthorizations; } }

		public override void Read(TLBinaryReader from)
		{
			Authorizations = TLFactory.Read<TLVector<TLAuthorization>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Authorizations);
		}
	}
}
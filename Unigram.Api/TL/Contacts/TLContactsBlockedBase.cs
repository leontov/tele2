// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Contacts
{
	public abstract partial class TLContactsBlockedBase : TLObject
	{
		public TLVector<TLContactBlocked> Blocked { get; set; }
		public TLVector<TLUserBase> Users { get; set; }
	}
}
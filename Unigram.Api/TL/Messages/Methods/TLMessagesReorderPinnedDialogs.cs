// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.reorderPinnedDialogs.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesReorderPinnedDialogs : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Force = (1 << 0),
		}

		public bool IsForce { get { return Flags.HasFlag(Flag.Force); } set { Flags = value ? (Flags | Flag.Force) : (Flags & ~Flag.Force); } }

		public Flag Flags { get; set; }
		public TLVector<TLInputPeerBase> Order { get; set; }

		public TLMessagesReorderPinnedDialogs() { }
		public TLMessagesReorderPinnedDialogs(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesReorderPinnedDialogs; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Order = TLFactory.Read<TLVector<TLInputPeerBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteObject(Order);
		}
	}
}
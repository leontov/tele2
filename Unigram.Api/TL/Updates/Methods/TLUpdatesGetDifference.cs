// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Updates.Methods
{
	/// <summary>
	/// RCP method updates.getDifference.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesDifferenceBase"/>
	/// </summary>
	public partial class TLUpdatesGetDifference : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			PtsTotalLimit = (1 << 0),
		}

		public bool HasPtsTotalLimit { get { return Flags.HasFlag(Flag.PtsTotalLimit); } set { Flags = value ? (Flags | Flag.PtsTotalLimit) : (Flags & ~Flag.PtsTotalLimit); } }

		public Flag Flags { get; set; }
		public Int32 Pts { get; set; }
		public Int32? PtsTotalLimit { get; set; }
		public Int32 Date { get; set; }
		public Int32 Qts { get; set; }

		public TLUpdatesGetDifference() { }
		public TLUpdatesGetDifference(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdatesGetDifference; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Pts = from.ReadInt32();
			if (HasPtsTotalLimit) PtsTotalLimit = from.ReadInt32();
			Date = from.ReadInt32();
			Qts = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt32(Pts);
			if (HasPtsTotalLimit) to.WriteInt32(PtsTotalLimit.Value);
			to.WriteInt32(Date);
			to.WriteInt32(Qts);
		}

		private void UpdateFlags()
		{
			HasPtsTotalLimit = PtsTotalLimit != null;
		}
	}
}
// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLTopPeerCategoryPeers : TLObject 
	{
		public TLTopPeerCategoryBase Category { get; set; }
		public Int32 Count { get; set; }
		public TLVector<TLTopPeer> Peers { get; set; }

		public TLTopPeerCategoryPeers() { }
		public TLTopPeerCategoryPeers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TopPeerCategoryPeers; } }

		public override void Read(TLBinaryReader from)
		{
			Category = TLFactory.Read<TLTopPeerCategoryBase>(from);
			Count = from.ReadInt32();
			Peers = TLFactory.Read<TLVector<TLTopPeer>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Category);
			to.WriteInt32(Count);
			to.WriteObject(Peers);
		}
	}
}
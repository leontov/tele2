// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputStickeredMediaPhoto : TLInputStickeredMediaBase 
	{
		public TLInputPhotoBase Id { get; set; }

		public TLInputStickeredMediaPhoto() { }
		public TLInputStickeredMediaPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputStickeredMediaPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			Id = TLFactory.Read<TLInputPhotoBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Id);
		}
	}
}
// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Upload.Methods
{
	/// <summary>
	/// RCP method upload.reuploadCdnFile.
	/// Returns <see cref="Telegram.Api.TL.TLVector<TLCdnFileHash>"/>
	/// </summary>
	public partial class TLUploadReuploadCdnFile : TLObject
	{
		public Byte[] FileToken { get; set; }
		public Byte[] RequestToken { get; set; }

		public TLUploadReuploadCdnFile() { }
		public TLUploadReuploadCdnFile(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UploadReuploadCdnFile; } }

		public override void Read(TLBinaryReader from)
		{
			FileToken = from.ReadByteArray();
			RequestToken = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteByteArray(FileToken);
			to.WriteByteArray(RequestToken);
		}
	}
}
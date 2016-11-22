﻿namespace nStratis.Protocol.Payloads
{
	[Payload("filteradd")]
	public class FilterAddPayload : Payload
	{
		public FilterAddPayload()
		{

		}
		public FilterAddPayload(byte[] data)
		{
			_Data = data;
		}
		byte[] _Data;
		public byte[] Data
		{
			get
			{
				return _Data;
			}
			set
			{
				_Data = value;
			}
		}

		public override void ReadWriteCore(BitcoinStream stream)
		{
			stream.ReadWriteAsVarString(ref _Data);
		}
	}
}

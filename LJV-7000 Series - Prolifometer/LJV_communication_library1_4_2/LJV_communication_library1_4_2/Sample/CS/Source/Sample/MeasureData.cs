using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJV7_IF_Test
{
	public class MeasureData
	{
		/// <summary>
		/// 経過時間(ms)
		/// </summary>
		private uint _offsetTime;

		/// <summary>
		/// 測定結果
		/// </summary>
		private LJV7IF_MEASURE_DATA[] _data;

		/// <summary>
		/// 経過時間(ms)
		/// </summary>
		public uint OffsetTime { get { return _offsetTime; } }

		/// <summary>
		/// 測定結果
		/// </summary>
		public LJV7IF_MEASURE_DATA[] Data { get { return _data; } }

		public MeasureData(uint offsetTime, LJV7IF_MEASURE_DATA[] data)
		{
			_offsetTime = offsetTime;
			_data = data;
		}

		public MeasureData(byte[] data, int startIndex)
		{
			_offsetTime = BitConverter.ToUInt32(data, startIndex);
			int measureDataIndex = startIndex + sizeof(uint);
			_data = new LJV7IF_MEASURE_DATA[Define.MESUREMENT_VALUE_DATA_COUNT];
			int measureDataSize = Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA);
			
			for (int i = 0; i < Define.MESUREMENT_VALUE_DATA_COUNT; i++)
			{				
				_data[i].byDataInfo = data[measureDataIndex + 0];
				_data[i].byJudge = data[measureDataIndex + 1];
				_data[i].fValue = BitConverter.ToSingle(data, (measureDataIndex + 4));
				measureDataIndex += measureDataSize;
			}
		}

		public static int GetByteSize()
		{
			return (sizeof(uint) + Utility.GetByteSize(Utility.TypeOfStruct.MEASURE_DATA) * Define.MESUREMENT_VALUE_DATA_COUNT);
		}

	}
}

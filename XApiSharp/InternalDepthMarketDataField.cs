using System.Runtime.InteropServices;

namespace QuantBox.XApi
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    internal class InternalDepthMarketDataField
    {
        ///ռ�����ֽڴ�С
        public int Size;

        public int TradingDay;
        public int ActionDay;
        public int UpdateTime;
        public int UpdateMillisec;

        /// <summary>
        /// ��Լ����
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string Symbol;
        /// <summary>
        /// ��Լ����
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// ����������
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// ����������
        /// </summary>
        public ExchangeType Exchange;
        
        /// <summary>
        /// ���¼�
        /// </summary>
        public double LastPrice;
        /// <summary>
        /// ����
        /// </summary>
        public double Volume;
        /// <summary>
        /// �ɽ����
        /// </summary>
        public double Turnover;
        /// <summary>
        /// �ֲ���
        /// </summary>
        public double OpenInterest;
        /// <summary>
        /// ���վ���
        /// </summary>
        public double AveragePrice;


        /// <summary>
        /// ����
        /// </summary>
        public double OpenPrice;
        /// <summary>
        /// ��߼�
        /// </summary>
        public double HighestPrice;
        /// <summary>
        /// ��ͼ�
        /// </summary>
        public double LowestPrice;
        /// <summary>
        /// ������
        /// </summary>
        public double ClosePrice;
        /// <summary>
        /// ���ν����
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// ��ͣ���
        /// </summary>
        public double UpperLimitPrice;
        /// <summary>
        /// ��ͣ���
        /// </summary>
        public double LowerLimitPrice;
        /// <summary>
        /// ������
        /// </summary>
        public double PreClosePrice;
        /// <summary>
        /// �ϴν����
        /// </summary>
        public double PreSettlementPrice;
        /// <summary>
        /// ��ֲ���
        /// </summary>
        public double PreOpenInterest;

        ///���׽׶�����
        public TradingPhaseType TradingPhase;

        ///�򵵸���
        public int BidCount;
    }
}
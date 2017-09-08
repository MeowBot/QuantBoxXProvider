using System.Runtime.InteropServices;

namespace QuantBox.XApi
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public class InstrumentField
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] InstrumentName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string Symbol;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        
        /// <summary>
        /// ����
        /// </summary>
        public InstrumentType Type;
        /// <summary>
        /// ��Լ��������
        /// </summary>
        public int VolumeMultiple;
        /// <summary>
        /// ��С�䶯��λ
        /// </summary>
        public double PriceTick;
        /// <summary>
        /// ������
        /// </summary>
        public int ExpireDate;
        /// <summary>
        /// ִ�м�
        /// </summary>
        public double StrikePrice;
        /// <summary>
        /// ��Ȩ����
        /// </summary>
        public PutCall OptionsType;
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        /// <summary>
        /// ������Ʒ����
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string UnderlyingInstrID;
        ///��Լ��������״̬
        public InstLifePhaseType InstLifePhase;
    }
}
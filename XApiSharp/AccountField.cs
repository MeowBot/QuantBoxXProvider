using System.Runtime.InteropServices;

namespace QuantBox.XApi
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public class AccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// �ϴν���׼����
        /// </summary>
        public double PreBalance;
        /// <summary>
        /// ��ǰ��֤���ܶ�
        /// </summary>
        public double CurrMargin;
        /// <summary>
        /// ƽ��ӯ��
        /// </summary>
        public double CloseProfit;
        /// <summary>
        /// �ֲ�ӯ��
        /// </summary>
        public double PositionProfit;
        /// <summary>
        /// �ڻ�����׼����
        /// </summary>
        public double Balance;
        /// <summary>
        /// �����ʽ�
        /// </summary>
        public double Available;
        /// <summary>
        /// �����
        /// </summary>
        public double Deposit;
        /// <summary>
        /// ������
        /// </summary>
        public double Withdraw;
        /// <summary>
        /// ��ȡ�ʽ�
        /// </summary>
        public double WithdrawQuota;
        /// <summary>
        /// ����Ĺ�����
        /// </summary>
        public double FrozenTransferFee;
        /// <summary>
        /// �����ӡ��˰
        /// </summary>
        public double FrozenStampTax;
        /// <summary>
        /// �����������
        /// </summary>
        public double FrozenCommission;
        /// <summary>
        /// ������ʽ�
        /// </summary>
        public double FrozenCash;
        /// <summary>
        /// ������
        /// </summary>
        public double TransferFee;
        /// <summary>
        /// ӡ��˰
        /// </summary>
        public double StampTax;
        /// <summary>
        /// ������
        /// </summary>
        public double Commission;
        /// <summary>
        /// �ʽ���
        /// </summary>
        public double CashIn;
    }
}
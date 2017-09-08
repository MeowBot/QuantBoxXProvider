using System.Runtime.InteropServices;

namespace QuantBox.XApi
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    internal class InternalErrorField
    {
        /// <summary>
        /// �������
        /// </summary>
        public int XErrorID;
        /// <summary>
        /// �������
        /// </summary>
        public int RawErrorID;
        /// <summary>
        /// ������Ϣ
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] Text;
        /// <summary>
        /// ��Ϣ��Դ
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string Source;
    }
}
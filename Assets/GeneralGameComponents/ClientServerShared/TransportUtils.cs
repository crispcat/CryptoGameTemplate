namespace ClientServerSharedLogic
{
    using System;
    using System.Text;

    public static class TransportUtils
    {
        public static string WideString(this ArraySegment<byte> bytes)
        {
            return Encoding.UTF8.GetString(bytes.Array ?? Array.Empty<byte>(), bytes.Offset, bytes.Count);
        }

        public static ArraySegment<byte> Bytes(this string str)
        {
            return new ArraySegment<byte>(Encoding.UTF8.GetBytes(str));
        }
    }
}
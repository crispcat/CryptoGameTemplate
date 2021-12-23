using System;

namespace CGT
{
    [GenSerialization, GenHashing]
    public partial class ConnectionInfo : IEquatable<ConnectionInfo>, IHashable
    {
        public byte ip0;
        public byte ip1;
        public byte ip2;
        public byte ip3;
        public int port;
        public string host => $"{ip0}.{ip1}.{ip2}.{ip3}";
        public byte[] ToBytes() => new byte[] { ip0, ip1, ip2, ip3, (byte)(port >> 8), (byte)port };
        public static ConnectionInfo CreateLocalBattle() => new ConnectionInfo { ip0 = 127, ip1 = 0, ip2 = 0, ip3 = 1, port = 9000 };
        public static ConnectionInfo CreateLocalMeta() => new ConnectionInfo { ip0 = 127, ip1 = 0, ip2 = 0, ip3 = 1, port = 9100 };
        //public static ConnectionInfo CreateMerged() => new ConnectionInfo { ip0 = 127, ip1 = 0, ip2 = 0, ip3 = 1, port = 1 };
        //public bool isMerged => port == 1;
        public static ConnectionInfo FromBytes(byte[] bytes)
        {
            var res = new ConnectionInfo();
            res.ip0 = bytes[0];
            res.ip1 = bytes[1];
            res.ip2 = bytes[2];
            res.ip3 = bytes[3];
            res.port = (bytes[4] << 8) + bytes[5];
            return res;
        }

#if CLIENT
        const int ProtectionBytesCount = 4;
        public const int BytesLengthProtected = ProtectionBytesCount + 6;
        public byte[] ToBytesProtected() {
            byte[] info = ToBytes();
            byte[] protection = CreateProtectionBytes(info);
            byte[] protectedInfo = new byte[ProtectionBytesCount + info.Length];
            for (int i = 0; i < info.Length; i++)
                protectedInfo[i] = info[i];
            for (int i = 0; i < protection.Length; i++)
                protectedInfo[i + info.Length] = protection[i];
            return protectedInfo;
        }
        public static ConnectionInfo FromProtectedBytes(byte[] protectedInfo)
        {
            byte[] infoCanBeDamaged = new byte[protectedInfo.Length - ProtectionBytesCount];
            byte[] protection = new byte[ProtectionBytesCount];
            for (int i = 0; i < protectedInfo.Length; i++)
            {
                if (i < infoCanBeDamaged.Length)
                    infoCanBeDamaged[i] = protectedInfo[i];
                else
                    protection[i - infoCanBeDamaged.Length] = protectedInfo[i];
            }
            byte[] info = TryDecodeProtectionBytes(infoCanBeDamaged, protection);
            if (info == null)
                return null;
            else
                return FromBytes(info);
        }

        static byte[] CreateProtectionBytes(byte[] info) {
            return ReedSolomon.ReedSolomonAlgorithm.Encode(info, ProtectionBytesCount);
        }
        static byte[] TryDecodeProtectionBytes(byte[] infoDamaged, byte[] protection) {
            return ReedSolomon.ReedSolomonAlgorithm.Decode(infoDamaged, protection);
        }
#endif

        public bool Equals(ConnectionInfo other)
        {
            return other != null && CalculateHash() == other.CalculateHash();
        }
        public override string ToString() => $"{ip0}.{ip1}.{ip2}.{ip3}:{port}";

        public static ConnectionInfo FromString(string str)
        {
            string[] split1 = str.Split(':');
            if (split1.Length != 2)
                return null;
            int port;
            if (!int.TryParse(split1[1], out port))
                return null;
            var res = FromHostPort(split1[0], port);
            if (res != null)
                res.port = port;
            return res;
        }
        public static ConnectionInfo FromHostPort(string host, int port)
        {
            ConnectionInfo res = new ConnectionInfo();
            string[] split = host.Split('.');
            if (split.Length != 4)
                return null;
            if (!byte.TryParse(split[0], out res.ip0))
                return null;
            if (!byte.TryParse(split[1], out res.ip1))
                return null;
            if (!byte.TryParse(split[2], out res.ip2))
                return null;
            if (!byte.TryParse(split[3], out res.ip3))
                return null;
            res.port = port;
            return res;
        }
    }
}
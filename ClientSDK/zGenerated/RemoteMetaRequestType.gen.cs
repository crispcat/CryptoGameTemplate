using System;
using System.Collections.Generic;
using System.Text;
public enum RemoteMetaRequestType : ushort
{
    FlushLocalCommands = 1,
    DebugAuthenticateMergedPlayer = 2,
    ConnectToServer = 3,
    FinishSession = 4,
    GetShortPlayerInfo = 5,
    DebugTimeoutSession = 6,
    DebugThrowException = 7,
    DebugLaggyCommand = 8,
}

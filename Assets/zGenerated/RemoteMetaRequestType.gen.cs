using System;
using System.Collections.Generic;
using System.Text;
public enum RemoteMetaRequestType : ushort
{
    FlushLocalCommands = 2,
    DebugAuthenticateMergedPlayer = 3,
    ConnectToServer = 1,
    FinishSession = 5,
    GetShortPlayerInfo = 6,
    DebugTimeoutSession = 7,
    DebugThrowException = 8,
    DebugLaggyCommand = 9,
}

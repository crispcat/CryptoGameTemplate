using System;
using System.IO;
using UnityEngine;
using ZergRush.CodeGen;

namespace Game
{
    public enum RemoteMetaResponseType : byte
    {
        NotFound,
        LocalBatchException,
        Exception,
        NotAuthed,
        Complete
    }
    
    [GenSerialization, GenTask(GenTaskFlags.JsonSerialization)]
    public partial class RemoteMetaResponse : ISerializable
    {        
        public RemoteMetaResponseType type;
        public bool success => type == RemoteMetaResponseType.Complete;
        public bool logged => true;
        [CanBeNull] public string error;
        [CanBeNull] public byte[] responseData;

        public static RemoteMetaResponse NotAuthed = new RemoteMetaResponse { type = RemoteMetaResponseType.NotAuthed };
        public static RemoteMetaResponse LocalBatchException(string error)
        {
            var res = new RemoteMetaResponse { type = RemoteMetaResponseType.LocalBatchException, error = error };
            Debug.LogError("LocalBatchException = " + error);
            return res;
        }
        public static RemoteMetaResponse RemoteCommandException(string error)
        {
            var res = new RemoteMetaResponse { type = RemoteMetaResponseType.Exception, error = error };
            Debug.LogError("RemoteCommandException = " + error);
            return res;
        }
        public static RemoteMetaResponse NotFound = new RemoteMetaResponse { type = RemoteMetaResponseType.NotFound };
        public static RemoteMetaResponse Complete() => new RemoteMetaResponse { type = RemoteMetaResponseType.Complete };
        public static RemoteMetaResponse Complete(byte[] responseData) => new RemoteMetaResponse { type = RemoteMetaResponseType.Complete, responseData = responseData };

        // public string Log(RemoteMetaRequestType type)
        // {
        //     return $"type = {type}\n{(success?"":error)}\n{DebugRemoteCommandResultPrinter.PrintResult(type, responseData)}\n{(timings==null?"no timings":timings.ToString())}";
        // }

        public string Log(RemoteMetaRequestType requestType)
        {
            return "";
        }
    }
}
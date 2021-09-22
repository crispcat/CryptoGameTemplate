using System;
using PlayFab;
using UnityEngine;

namespace PlayFab
{
    public class PlayFabResult<TResult> : CustomYieldInstruction
    {
        bool ready;

        public Action<TResult> processSuccess => r =>
        {
            Result = r;
            ready = true;
        };

        public Action<PlayFabError> processFail => err =>
        {
            Error = err;
            ready = true;
        };

        public TResult Result;
        public PlayFabError Error;

        public override bool keepWaiting
        {
            get { return ready == false; }
        }

        public bool success => !keepWaiting && Error == null;
    }
}
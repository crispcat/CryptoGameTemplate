using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public enum RemoteMetaRequestType {}

    public enum RemoteMetaResponseType : byte
    {
        NotFound,
        LocalBatchException,
        Exception,
        NotAuthed,
        Complete
    }
    public class AuthenticationInfo
    {
        
    }
    
    public abstract class MetaNetworkLayer
    {
        public abstract Task<RemoteMetaResponse> CallServerApi(RemoteMetaRequest info);
    }
    
    public interface IGameServer
    {
        Task<MetaNetworkLayer> Authenticate(AuthenticationInfo loginInfo);
        Task Exit();
    }
    
    public abstract class GameClientController : IGameControllerBase
    {
        public abstract Task Start();
        public abstract Task Exit();
        public virtual Task Reset() {
            return Task.CompletedTask;
        }

        public override void SinkLocalCommand(LocalMetaCommand command)
        {
            if (!player.inTutor)
                sinkedLocalCommands.items.Add(command);
            else
            {
                sinkedLocalCommandsBetweenTutorialSteps.items.Add(command);

                if (command.type == LocalMetaCommandType.SetTutorialStep) { 
                    sinkedLocalCommands.items.AddRange(sinkedLocalCommandsBetweenTutorialSteps.items);
                    sinkedLocalCommandsBetweenTutorialSteps.items.Clear();
                    SavePlayer();                    
                }
            }
            //SaveLocalCommands();
            //            Debug.Log($"sinked local command, sinked count = {sinkedLocalCommands.items.Count}");
        }

        public LocalCommandsBatch sinkedLocalCommands;
        public LocalCommandsBatch DrainLocalCommands()
        {
            //Debug.Log($"drained {sinkedLocalCommands.items.Count} local commands");
            var commands = sinkedLocalCommands;
            sinkedLocalCommands = new LocalCommandsBatch();
            //SaveLocalCommands();
            return commands;
        }
        protected const string localCommandsFileName = "local_commands.bin";
        protected void SaveLocalCommands() => SerializationTools.SaveToFile(sinkedLocalCommands, localCommandsFileName);
        protected void LoadLocalCommands()
        {
            LocalCommandsBatch loadedBatch;
            if (Utils.LoadBinary(localCommandsFileName, out loadedBatch))
                sinkedLocalCommands = loadedBatch;
        }

        public virtual void SavePlayer() {
        }

        public abstract long metaTime { get; }
        void UpdateMetaTime()
        {
            if (authed && player != null)
                player.time.currTime = metaTime;
        }

        // returns true if purchase can be confurmed
        public abstract Task<bool> HardPurchase(ShopPurchasable item, Product product, bool sandbox);
        public abstract void OnAppPause();        
        protected abstract Task<BattleResult> GetCurrMultiplayerBattleResults();
        
        public virtual void UnityFrameUpdate()
        {
            try
            {
                if (Input.GetKey(KeyCode.F6))
                {
                    QuitProperly();
                }
                UpdateMetaTime();
            }
            catch (Exception e)
            {
            }
        }

        public async void QuitProperly()
        {
            await Exit();
        }
    }
}
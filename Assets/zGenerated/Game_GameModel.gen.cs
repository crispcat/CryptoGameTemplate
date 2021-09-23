using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class GameModel : IUpdatableFrom<Game.GameModel>, IUpdatableFrom<ZergRush.Alive.DataNode>, IHashable, ICompareChechable<ZergRush.Alive.DataNode>, IJsonSerializable
    {
        public void TestCommandCommand() 
        {
            var command = root.PrepareCommand(LocalMetaCommandType.TestCommand, 0);;
            var _data = new MemoryStream();
            var writer = new BinaryWriter(_data);
            var commandArgData = _data.GetBuffer();
            command.args = commandArgData;
            try
            {
                root.BeforeExecutionLocalCommand(command);
                TestCommand();
                root.SinkLocalCommand(command);
            }
            catch (Exception e)
            {
                SystemLayer.LogError($"Local command TestCommand execution failed, request args: , \n SERVER ERROR = {e.Message}, \nstacktrace={e.StackTrace}");
                root.ExecutionFailed(command);
            }
        }
        public virtual Game.LocalMetaCommandResult ExecuteCommand(LocalMetaCommandType _type, BinaryReader reader) 
        {
            switch(_type)
            {
                case LocalMetaCommandType.TestCommand:
                {
                    TestCommand();
                    return LocalMetaCommandResult.Complete();
                    break;
                }
            }
            return Game.LocalMetaCommandResult.NotFound;
        }
        public Game.GameReferencableEntity CreateGameReferencableEntity() 
        {
            var inst = new Game.GameReferencableEntity();
            inst.root = this;
            inst.__GenIds(this);
            inst.__PropagateHierarchyAndRememberIds();
            return inst;
        }
        public Game.GameReferencableEntity CreateGameReferencableEntity(Game.GameReferencableEntity prototype) 
        {
            Game.GameReferencableEntity inst = default;
            inst = new Game.GameReferencableEntity();
            inst.UpdateFrom(prototype);
            inst.root = this;
            inst.__GenIds(this);
            inst.__PropagateHierarchyAndRememberIds();
            return inst;
        }
        public Game.GameEntity CreateGameEntity() 
        {
            var inst = (Game.GameEntity)new Game.GameEntity();
            inst.root = this;
            inst.__GenIds(this);
            inst.__PropagateHierarchyAndRememberIds();
            return inst;
        }
        public Game.GameEntity CreateGameEntity(Game.GameEntity prototype) 
        {
            Game.GameEntity inst = default;
            inst = (Game.GameEntity)prototype.NewInst();
            inst.UpdateFrom(prototype);
            inst.root = this;
            inst.__GenIds(this);
            inst.__PropagateHierarchyAndRememberIds();
            return inst;
        }
        public override void UpdateFrom(ZergRush.Alive.DataNode other) 
        {
            base.UpdateFrom(other);
            var otherConcrete = (Game.GameModel)other;
            displayName = otherConcrete.displayName;
        }
        public void UpdateFrom(Game.GameModel other) 
        {
            this.UpdateFrom((ZergRush.Alive.DataNode)other);
        }
        public override void Deserialize(BinaryReader reader) 
        {
            base.Deserialize(reader);
            displayName = reader.ReadString();
        }
        public override void Serialize(BinaryWriter writer) 
        {
            base.Serialize(writer);
            writer.Write(displayName);
        }
        public override ulong CalculateHash() 
        {
            var baseVal = base.CalculateHash();
            System.UInt64 hash = baseVal;
            hash += (ulong)709428417;
            hash += hash << 11; hash ^= hash >> 7;
            hash += (ulong)displayName.GetHashCode();
            hash += hash << 11; hash ^= hash >> 7;
            return hash;
        }
        public override void Enlive() 
        {
            EnliveSelf();
            EnliveChildren();
        }
        public override void Mortify() 
        {
            MortifySelf();
            MortifyChildren();
        }
        protected override void EnliveChildren() 
        {
            base.EnliveChildren();

        }
        protected override void MortifyChildren() 
        {
            base.MortifyChildren();

        }
        public override void __GenIds(DataRoot __root) 
        {
            base.__GenIds(__root);

        }
        public override void __PropagateHierarchyAndRememberIds() 
        {
            base.__PropagateHierarchyAndRememberIds();

        }
        public override void __ForgetIds() 
        {
            base.__ForgetIds();

        }
        public  GameModel() 
        {
            displayName = string.Empty;
            root = this;
            __GenIds(root);
            __PropagateHierarchyAndRememberIds();
        }
        public override void CompareCheck(ZergRush.Alive.DataNode other, Stack<string> __path) 
        {
            base.CompareCheck(other,__path);
            var otherConcrete = (Game.GameModel)other;
            if (displayName != otherConcrete.displayName) SerializationTools.LogCompError(__path, "displayName", otherConcrete.displayName, displayName);
        }
        public override void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            base.ReadFromJsonField(reader,__name);
            switch(__name)
            {
                case "displayName":
                displayName = (string) reader.Value;
                break;
            }
        }
        public override void WriteJsonFields(JsonTextWriter writer) 
        {
            base.WriteJsonFields(writer);
            writer.WritePropertyName("displayName");
            writer.WriteValue(displayName);
        }
    }
}
#endif

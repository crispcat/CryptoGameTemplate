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
        }
        public void UpdateFrom(Game.GameModel other) 
        {
            this.UpdateFrom((ZergRush.Alive.DataNode)other);
        }
        public override void Deserialize(BinaryReader reader) 
        {
            base.Deserialize(reader);

        }
        public override void Serialize(BinaryWriter writer) 
        {
            base.Serialize(writer);

        }
        public override ulong CalculateHash() 
        {
            var baseVal = base.CalculateHash();
            System.UInt64 hash = baseVal;
            hash += (ulong)709428417;
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
            root = this;
            __GenIds(root);
            __PropagateHierarchyAndRememberIds();
        }
        public override void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            base.ReadFromJsonField(reader,__name);
            switch(__name)
            {
            }
        }
        public override void WriteJsonFields(JsonTextWriter writer) 
        {
            base.WriteJsonFields(writer);

        }
    }
}
#endif

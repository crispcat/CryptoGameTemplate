using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class GameEntity : IUpdatableFrom<Game.GameEntity>, IUpdatableFrom<ZergRush.Alive.DataNode>, IHashable, ICompareChechable<ZergRush.Alive.DataNode>, IJsonSerializable, IPolymorphable
    {
        public enum Types : ushort
        {
            GameEntity = 1,
            GameReferencableEntity = 2,
        }
        static Func<GameEntity> [] polymorphConstructors = new Func<GameEntity> [] {
            () => null, // 0
            () => new Game.GameEntity(), // 1
            () => new Game.GameReferencableEntity(), // 2
        };
        public static GameEntity CreatePolymorphic(System.UInt16 typeId) {
            return polymorphConstructors[typeId]();
        }
        public override void UpdateFrom(ZergRush.Alive.DataNode other) 
        {
            base.UpdateFrom(other);
            var otherConcrete = (Game.GameEntity)other;
        }
        public void UpdateFrom(Game.GameEntity other) 
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
            hash += (ulong)507791003;
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
        public  GameEntity() 
        {

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
        public virtual ushort GetClassId() 
        {
        return (System.UInt16)Types.GameEntity;
        }
        public virtual Game.GameEntity NewInst() 
        {
        return new GameEntity();
        }
    }
}
#endif

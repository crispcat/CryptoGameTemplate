using System;
using System.Collections.Generic;
using System.Text;
using ZergRush.Alive;
using System.IO;
using Newtonsoft.Json;
#if !INCLUDE_ONLY_CODE_GENERATION
namespace Game {

    public partial class GameReferencableEntity : IUpdatableFrom<Game.GameReferencableEntity>, IUpdatableFrom<ZergRush.Alive.DataNode>, IHashable, IReferencableFromDataRoot, ICompareChechable<ZergRush.Alive.DataNode>, IJsonSerializable, IPolymorphable
    {
            public int Id { get { return id; } set { id = value; root?.ForceId(value, this); } }
        public override void UpdateFrom(ZergRush.Alive.DataNode other) 
        {
            base.UpdateFrom(other);
            var otherConcrete = (Game.GameReferencableEntity)other;
            id = otherConcrete.id;
            Id = otherConcrete.Id;
        }
        public void UpdateFrom(Game.GameReferencableEntity other) 
        {
            this.UpdateFrom((ZergRush.Alive.DataNode)other);
        }
        public override void Deserialize(BinaryReader reader) 
        {
            base.Deserialize(reader);
            id = reader.ReadInt32();
            Id = reader.ReadInt32();
        }
        public override void Serialize(BinaryWriter writer) 
        {
            base.Serialize(writer);
            writer.Write(id);
            writer.Write(Id);
        }
        public override ulong CalculateHash() 
        {
            var baseVal = base.CalculateHash();
            System.UInt64 hash = baseVal;
            hash += (ulong)1253895621;
            hash += hash << 11; hash ^= hash >> 7;
            hash += (System.UInt64)id;
            hash += hash << 11; hash ^= hash >> 7;
            hash += (System.UInt64)Id;
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
            Id = __root.entityIdFactory++;
        }
        public override void __PropagateHierarchyAndRememberIds() 
        {
            base.__PropagateHierarchyAndRememberIds();
            if (Id != 0) root.Remember(this, Id);
        }
        public override void __ForgetIds() 
        {
            base.__ForgetIds();
            if (Id != 0) root.Forget(Id, this);
        }
        public  GameReferencableEntity() 
        {

        }
        public override void CompareCheck(ZergRush.Alive.DataNode other, Stack<string> __path) 
        {
            base.CompareCheck(other,__path);
            var otherConcrete = (Game.GameReferencableEntity)other;
            if (id != otherConcrete.id) SerializationTools.LogCompError(__path, "id", otherConcrete.id, id);
            if (Id != otherConcrete.Id) SerializationTools.LogCompError(__path, "Id", otherConcrete.Id, Id);
        }
        public override void ReadFromJsonField(JsonTextReader reader, string __name) 
        {
            base.ReadFromJsonField(reader,__name);
            switch(__name)
            {
                case "id":
                id = (int)(Int64)reader.Value;
                break;
                case "Id":
                Id = (int)(Int64)reader.Value;
                break;
            }
        }
        public override void WriteJsonFields(JsonTextWriter writer) 
        {
            base.WriteJsonFields(writer);
            writer.WritePropertyName("id");
            writer.WriteValue(id);
            writer.WritePropertyName("Id");
            writer.WriteValue(Id);
        }
        public override ushort GetClassId() 
        {
        return (System.UInt16)Types.GameReferencableEntity;
        }
        public override Game.GameEntity NewInst() 
        {
        return new GameReferencableEntity();
        }
    }
}
#endif

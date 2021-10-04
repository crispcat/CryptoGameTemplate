using ZergRush.Alive;

namespace Game
{
    public static class ModelCommandTools
    {
        public static LocalMetaCommandResult ExecuteCommand(this ILocalCommandExecuter model, LocalMetaCommand command)
        {
            ILocalCommandExecuter target = null;
            var id = command.objId;
            if (id == 0) target = (ILocalCommandExecuter) model;
            else target = (ILocalCommandExecuter)((DataRoot) model).RecallMayBe(id);
            if (target == null) { throw new GameException($"object with id {id} not found in the model"); }
            
            var reader = ProtocolTools.GetReader(command.args);
            var result = target.ExecuteCommand(command.type, reader);
            if (result.type != LocalMetaCommandResultType.Complete) throw new GameException($"local command {command} error:{result.type}");
            return result;
        }
    }
}
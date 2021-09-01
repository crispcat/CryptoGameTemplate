namespace Game
{
    public abstract class GameControllerBase
    {
        public abstract void SinkLocalCommand(LocalMetaCommand command);
        public abstract void BeforeExecutionLocalCommand(LocalMetaCommand command);
        public abstract void CommandExecutionFailed(LocalMetaCommand command);
    }
}
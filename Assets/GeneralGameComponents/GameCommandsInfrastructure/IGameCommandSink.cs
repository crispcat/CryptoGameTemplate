namespace CGT
{
    public interface IGameCommandSink
    {
        public abstract void SinkLocalCommand(LocalMetaCommand command);
        public abstract void BeforeExecutionLocalCommand(LocalMetaCommand command);
        public abstract void CommandExecutionFailed(LocalMetaCommand command);
    }
}
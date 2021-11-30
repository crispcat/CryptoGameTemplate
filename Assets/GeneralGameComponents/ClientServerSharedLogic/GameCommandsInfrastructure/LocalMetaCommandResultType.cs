namespace Game
{
    public enum LocalMetaCommandResultType : byte
    {
        NotFound,
        Exception,
        Complete
    }
    
    public static class LocalMetaCommandResultTypeExtensions
    {
        public static bool IsOk(this LocalMetaCommandResultType type) => type == LocalMetaCommandResultType.Complete;
        public static bool IsFailed(this LocalMetaCommandResultType type) => !type.IsOk();
    }
}
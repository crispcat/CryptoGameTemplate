namespace AGameServer.HostingProviders
{
    using System;
    
    using static AGameServer;

    public abstract class HostingProviderImpl
    {
        protected HostingProviderImpl()
        {
            checkHealth = ServerConfig.HEALTH_CHECK;
            Shutdown += ServerConfig.ON_SHUTDOWN;
            Shutdown += Dispose;
        }
        
        public abstract void Initialize();
        
        public abstract void Ready();

        public abstract bool PlayerSessionIsValid(string sessionId);

        public abstract int GetPort(string name);
        
        protected Func<bool> checkHealth { get; }

        public event Action Shutdown;
        protected void InvokeShutdown() => Shutdown?.Invoke();
    }
}
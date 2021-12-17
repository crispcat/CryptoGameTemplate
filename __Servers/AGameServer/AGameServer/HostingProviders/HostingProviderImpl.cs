namespace AGameServer.HostingProviders
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net.NetworkInformation;

    using static AGameServer;

    public abstract class HostingProviderImpl
    {
        private Dictionary<string, int> allocatedPorts;

        protected HostingProviderImpl()
        {
            checkHealth = ServerConfig.HEALTH_CHECK;
            Shutdown += ServerConfig.ON_SHUTDOWN;
            Shutdown += Dispose;
            
            AllocatePorts();
        }
        
        
        public abstract void Initialize();
        
        public abstract void Ready();

        public abstract bool PlayerSessionIsValid(string sessionId);

        protected Func<bool> checkHealth { get; }

        public event Action Shutdown;
        protected void InvokeShutdown() => Shutdown?.Invoke();


        public virtual int GetPort(string name)
        {
            if (!allocatedPorts.TryGetValue(name, out int port))
                throw new NotImplementedException($"There is no port {name} implemented by demand.");

            return port;
        }

        protected void AllocatePorts()
        {
            const ushort PORTS_COUNT = 2;
            
            if (GetFreeTcpPorts(ServerConfig.PORT_RANGE_MIN, ServerConfig.PORT_RANGE_MAX, PORTS_COUNT, out var ports))
            {
                allocatedPorts = new Dictionary<string, int>
                {
                    { ServerConfig.ENDPOINT_PORT_NAME,  ports[0] },
                    { ServerConfig.LOGS_PORT_NAME,      ports[1] }
                };
            }
            else
            {
                throw new Exception(
                    $"Cannot allocate {PORTS_COUNT} free ports in range [{ServerConfig.PORT_RANGE_MIN}, {ServerConfig.PORT_RANGE_MAX}]. " +
                     "Server cannot run. Terminating..."
                );
            }
        }
        
        protected static bool GetFreeTcpPorts(ushort min, ushort max, ushort count, out List<int> ports)
        {
            var systemAllocPorts = IPGlobalProperties.GetIPGlobalProperties()
                                                     .GetActiveTcpConnections()
                                                     .Select(c => c.RemoteEndPoint.Port);

            var domainAllocPorts = IPGlobalProperties.GetIPGlobalProperties()
                                                     .GetActiveTcpListeners()
                                                     .Select(l => l.Port);

            var allocPorts = systemAllocPorts.Concat(domainAllocPorts).Where(p => p >= min && p <= max).ToHashSet();
            ports = new List<int>();

            for (int p = min; p <= max; p++)
            {
                if (!allocPorts.Contains(p))
                {
                    ports.Add(p);

                    if (ports.Count == count)
                        return true;
                }
            }

            return false;
        }
    }
}
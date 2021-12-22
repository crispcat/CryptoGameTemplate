namespace AGameServer.HostingProviders
{
    public class Localhost : HostingProviderImpl
    {
        public override void Initialize() { }

        public override void Ready() { }

        public override bool PlayerSessionIsValid(string sessionId) => true;
    }
}
using Exiled.API.Interfaces;

namespace PingPong
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
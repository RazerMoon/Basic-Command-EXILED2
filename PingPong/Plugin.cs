using Exiled.API.Enums;
using Exiled.API.Features;
using System;

namespace PingPong
{
    public class Plugin : Plugin<Config>
    {
        private static readonly Lazy<Plugin> LazyInstance = new Lazy<Plugin>(() => new Plugin());

        private Plugin()
        {
        }

        public static Plugin Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Last;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Log.Warn($"PingPong plugin enabled!");
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}
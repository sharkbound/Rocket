﻿using Rocket.API;
using Rocket.API.Plugins;

namespace Rocket.Plugins.ScriptBase
{
    /// <summary>
    /// <p>The RocketPluginBase for a scripting implementation</p>
    /// <p>To be implemented by the script implementation.</p>
    /// </summary>
    public class ScriptRocketPlugin : RocketPluginBase
    {
        public void Awake()
        {
            Name = GetType().Name;
            PluginManager = ScriptPluginManager;
            base.Initialize();
        }

        public ScriptRocketPluginManager ScriptPluginManager => ScriptContext.ScriptEngine.PluginManager;
        public IScriptContext ScriptContext { get; set; }
    }

    /// <summary>
    /// <p>The RocketPluginBase with configuration for a scripting implementation</p>
    /// <p>To be implemented by the script implementation.</p>
    /// </summary>
    public class ScriptRocketPlugin<RocketPluginConfiguration> : RocketPluginBase<RocketPluginConfiguration> where RocketPluginConfiguration : class, IRocketPluginConfiguration
    {
        public void Awake()
        {
            Name = GetType().Name;
            PluginManager = ScriptPluginManager;
            base.Initialize();
        }

        public ScriptRocketPluginManager ScriptPluginManager => ScriptContext.ScriptEngine.PluginManager;
        public IScriptContext ScriptContext { get; set; }
    }
}
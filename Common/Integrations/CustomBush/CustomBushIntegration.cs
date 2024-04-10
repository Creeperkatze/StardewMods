using StardewModdingAPI;

namespace Pathoschild.Stardew.Common.Integrations.CustomBush
{
    /// <summary>Handles the logic for integrating with the CustomBush mod.</summary>
    internal class CustomBushIntegration : BaseIntegration<ICustomBushApi>
    {
        /*********
         ** Public methods
         *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="modRegistry">An API for fetching metadata about loaded mods.</param>
        /// <param name="monitor">Encapsulates monitoring and logging.</param>
        public CustomBushIntegration(IModRegistry modRegistry, IMonitor monitor)
            : base("CustomBush", "furyx639.CustomBush", "1.0.5", modRegistry, monitor) { }


    }
}

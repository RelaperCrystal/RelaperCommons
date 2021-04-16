using Rage;
using Rage.Native;

namespace RelaperCommons
{
    /// <summary>
    /// Provides extensions to <see cref="Vehicle"/>.
    /// </summary>
    public static class VehicleExtensions
    {
        /// <summary>
        /// Gets the localized display name of the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns>The display name of vehicle, or <see cref="string.Empty"/> if not found.</returns>
        public static string GetDisplayName(this Vehicle vehicle)
        {
            var name = NativeFunction.Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL<string>(vehicle.Model.Hash);
            if (string.IsNullOrWhiteSpace(name) || name == "CARNOTFOUND")
            {
                return string.Empty;
            }

            return Game.GetLocalizedString(name);
        }
    }
}

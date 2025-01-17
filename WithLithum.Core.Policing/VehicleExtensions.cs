﻿using System;
using Rage;
using Rage.Exceptions;
using Rage.Native;

namespace WithLithum.Core.Policing
{
    /// <summary>
    /// Provides extensions to <see cref="Vehicle"/>.
    /// </summary>
    public static class VehicleExtensions
    {
        /// <summary>Randomizes the license plate.</summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <exception cref="ArgumentNullException">The vehicle is null.</exception>
        /// <exception cref="InvalidHandleableException">
        ///   <para>The vehicle is invalid.</para>
        /// </exception>
        /// <seealso cref="Vehicle" />
        public static void RandomizeLicensePlate(this Vehicle vehicle)
        {
            if (vehicle == null) throw new ArgumentNullException(nameof(vehicle));

            vehicle.LicensePlate = MathHelper.GetRandomInteger(1, 9) +
                MathHelper.GetRandomInteger(1, 9) +
                ((char)MathHelper.GetRandomInteger('A', 'Z')).ToString() +
                ((char)MathHelper.GetRandomInteger('A', 'Z')).ToString() +
                ((char)MathHelper.GetRandomInteger('A', 'Z')).ToString() +
                MathHelper.GetRandomInteger(1, 9) +
                MathHelper.GetRandomInteger(1, 9) +
                MathHelper.GetRandomInteger(1, 9);
        }

        /// <summary>
        /// Gets the localized display name of the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns>The display name of vehicle, or <see langword="null"/> if not found.</returns>
        public static string GetDisplayName(this Vehicle vehicle)
        {
            var name = NativeFunction.Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL<string>(vehicle.Model.Hash);
            if (string.IsNullOrWhiteSpace(name) || name == "CARNOTFOUND")
            {
                return null;
            }

            return Game.GetLocalizedString(name);
        }

        /// <summary>Tries to get the display name of specified vehicle model.</summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <param name="result">The result.</param>
        /// <returns>
        ///   <para>Returns true if a proper name has been found; otherwise, false.</para>
        /// </returns>
        public static bool TryGetDisplayNameOfVehicleModel(this Vehicle vehicle, out string result)
        {
            var name = NativeFunction.Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL<string>(vehicle.Model.Hash);
            if (name == "CARNOTFOUND")
            {
                result = string.Empty;
                return false;
            }

            var tempResult = Game.GetLocalizedString(name);
            if (string.IsNullOrWhiteSpace(tempResult))
            {
                result = string.Empty;
                return false;
            }

            result = tempResult;
            return true;
        }
    }
}

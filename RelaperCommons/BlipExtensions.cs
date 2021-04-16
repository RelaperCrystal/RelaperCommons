using System;
using Rage;
using Rage.Native;
using RelaperCommons.Entities;

namespace RelaperCommons
{
    /// <summary>Extension methods of <see cref="Blip" /> class.</summary>
    /// <seealso cref="Blip" />
    public static class BlipExtensions
    {
        /// <summary>Sets the color of this <see cref="Blip" /> to the predefined system blip color.</summary>
        /// <param name="blip">The blip to set color.</param>
        /// <param name="color">The color.</param>
        /// <remarks>
        ///   <note type="important">Do not set <see cref="Blip.Color" /> once you set this color. If you want to set anyway, imagine it's secondary color (mix with this).</note>
        /// </remarks>
        public static void SetColor(this Blip blip, BlipColor color)
        {
            NativeFunction.Natives.SET_BLIP_COLOUR(blip, (int)color);
        }

        /// <summary>Sets the route color of the <see cref="Blip" /> to a predefined system color.</summary>
        /// <param name="blip">The blip.</param>
        /// <param name="color">The color.</param>
        public static void SetRouteColor(this Blip blip, BlipColor color)
        {
            NativeFunction.Natives.SET_BLIP_ROUTE_COLOUR(blip, (int)color);
        }

        /// <inheritdoc cref="Blip.EnableRoute(System.Drawing.Color)"/>
        /// <param name="blip">The blip to set the color.</param>
        /// <param name="color"><inheritdoc /></param>
        public static void EnableRoute(this Blip blip, BlipColor color)
        {
            blip.SetRouteColor(color);
            blip.IsRouteEnabled = true;
        }
    }
}

using System.Drawing;

namespace RelaperCommons.Entities
{
    /// <summary>
    ///   <para>An enumeration of all predefined blip colors.</para>
    ///   <para>To set literal colors, please set to <see cref="White" /> then use <see cref="Rage.Blip.Color" /> property to set color of type <see cref="Color" />.</para>
    /// </summary>
    public enum BlipColor
    {
        /// <summary>The white color.</summary>
        /// <seealso cref="BlipExtensions" />
        White = 0,
        /// <summary>
        /// The red (<see cref="Color.Red" />).
        /// </summary>
        Red = 1,
        /// <summary>
        /// The green color which will be <see cref="Red"/> or <see cref="Blue"/> based on <see cref="Rage.Blip.IsFriendly"/>.
        /// </summary>
        /// <remarks>
        /// If <see cref="Rage.Blip.IsFriendly"/> is set to true, it will be <see cref="Blue"/>; otherwise, it will be <see cref="Red"/>.
        /// </remarks>
        GreenAutomatic = 2,
        /// <summary>
        /// The blue color which will be <see cref="Red"/> if <see cref="Rage.Blip.IsFriendly"/> was set to <c>false</c>.
        /// </summary>
        BlueAutomatic = 3,
        /// <summary>
        /// The white color which will be <see cref="Red"/> or <see cref="Blue"/> based on <see cref="Rage.Blip.IsFriendly"/>.
        /// </summary>
        /// <remarks>
        /// If <see cref="Rage.Blip.IsFriendly"/> is set to true, it will be <see cref="Blue"/>; otherwise, it will be <see cref="Red"/>.
        /// </remarks>
        Automatic = 4,
        /// <summary>
        /// The yellow color which will be <see cref="Red"/> or <see cref="Blue"/> based on <see cref="Rage.Blip.IsFriendly"/>.
        /// </summary>
        /// <remarks>
        /// If <see cref="Rage.Blip.IsFriendly"/> is set to true, it will be <see cref="Blue"/>; otherwise, it will be <see cref="Red"/>.
        /// </remarks>
        YellowAutomatic = 5,
        /// <summary>
        /// The light red.
        /// </summary>
        LightRed = 6,
        /// <summary>
        /// The violet.
        /// </summary>
        Violet = 7,
        /// <summary>
        /// The pink.
        /// </summary>
        Pink = 8,
        /// <summary>
        /// The light orange.
        /// </summary>
        LightOrange = 9,
        /// <summary>
        /// The light brown.
        /// </summary>
        LightBrown = 10,
        /// <summary>
        /// The light green.
        /// </summary>
        LightGreen = 11,
        /// <summary>
        /// The light blue.
        /// </summary>
        LightBlue = 12,
        /// <summary>
        /// The light purple.
        /// </summary>
        LightPurple = 13,
        /// <summary>
        /// The dark purple.
        /// </summary>
        DarkPurple = 14,
        /// <summary>
        /// The cyan.
        /// </summary>
        Cyan = 15,
        /// <summary>
        /// The light yellow.
        /// </summary>
        LightYellow = 16,
        /// <summary>
        /// The orange.
        /// </summary>
        Orange = 17,
        /// <summary>
        /// The lighter blue.
        /// </summary>
        LighterBlue = 18,
        /// <summary>
        /// The dark pink.
        /// </summary>
        DarkPink = 19,
        /// <summary>
        /// The dark yellow.
        /// </summary>
        DarkYellow = 20,
        /// <summary>
        /// The dark orange.
        /// </summary>
        DarkOrange = 21,
        /// <summary>
        /// The light gray.
        /// </summary>
        LightGray = 22,
        /// <summary>
        /// The light pink.
        /// </summary>
        LightPink = 23,
        /// <summary>
        /// The lemon green.
        /// </summary>
        LemonGreen = 24,
        /// <summary>
        /// The forest green.
        /// </summary>
        ForestGreen = 25,
        /// <summary>
        /// The electric blue.
        /// </summary>
        ElectricBlue = 26,
        /// <summary>
        /// The bright purple.
        /// </summary>
        BrightPurple = 27,
        /// <summary>
        /// The darker yellow.
        /// </summary>
        DarkerYellow = 28,
        /// <summary>
        /// The dark blue.
        /// </summary>
        DarkBlue = 29,
        /// <summary>
        /// The dark cyan.
        /// </summary>
        DarkCyan = 30,
        /// <summary>
        /// The lighter brown.
        /// </summary>
        LighterBrown = 31,
        /// <summary>
        /// The lighter blue.
        /// </summary>
        EvenLighterBlue = 32,
        /// <summary>
        /// The lighter yellow.
        /// </summary>
        LighterYellow = 33,
        /// <summary>
        /// The lighter pink.
        /// </summary>
        LighterPink = 34,
        /// <summary>
        /// The lighter red.
        /// </summary>
        LighterRed = 35,
        /// <summary>
        /// The beige.
        /// </summary>
        Beige = 36,
        /// <summary>
        /// Another white.
        /// </summary>
        AnotherWhite = 37,
        /// <summary>
        /// The darker blue.
        /// </summary>
        DarkerBlue = 38,
        /// <summary>
        /// The lighter gray.
        /// </summary>
        LighterGray = 39,
        /// <summary>
        /// The dark gray.
        /// </summary>
        DarkGray = 40,
        /// <summary>
        /// The pink red.
        /// </summary>
        PinkRed = 41,
        /// <summary>
        /// The slightly darker blue.
        /// </summary>
        SlightlyDarkerBlue = 42,
        /// <summary>
        /// The lighter green.
        /// </summary>
        LighterGreen = 43,
        /// <summary>
        /// The lighter orange.
        /// </summary>
        LighterOrange = 44,
        /// <summary>
        /// The slightly darker white.
        /// </summary>
        SlightlyDarkerWhite = 45,
        /// <summary>
        /// The gold.
        /// </summary>
        Gold = 46,
        /// <summary>
        /// Another orange.
        /// </summary>
        AnotherOrange = 47,
        /// <summary>
        /// The brilliant rose.
        /// </summary>
        BrilliantRose = 48,
        /// <summary>
        /// The red color which will be <see cref="Blue"/> if <see cref="Rage.Blip.IsFriendly"/> is set to <c>true</c>.
        /// </summary>
        RedAutomatic = 49,
        /// <summary>
        /// The medium purple.
        /// </summary>
        MediumPurple = 50,
        /// <summary>
        /// The salmon.
        /// </summary>
        Salmon = 51,
        /// <summary>
        /// The very dark green.
        /// </summary>
        VeryDarkGreen = 52,
        /// <summary>
        /// The blizzard blue.
        /// </summary>
        BlizzardBlue = 53,
        /// <summary>
        /// The oracle blue.
        /// </summary>
        OracleBlue = 54,
        /// <summary>
        /// The silver.
        /// </summary>
        Silver = 55,
        /// <summary>
        /// The very dark brown.
        /// </summary>
        VeryDarkBrown = 56,
        /// <summary>
        /// The blue.
        /// </summary>
        Blue = 57,
        EastBay = 58,
        /// <summary>
        /// The yellow.
        /// </summary>
        Yellow = 60,
        /// <summary>
        /// The mulberry pink.
        /// </summary>
        MulberryPink = 61,
        /// <summary>
        /// The alto gray.
        /// </summary>
        AltoGray = 62,
        JellyBeanBlue = 63,
        /// <summary>
        /// The darker orange.
        /// </summary>
        DarkerOrange = 64,
        /// <summary>
        /// The mamba.
        /// </summary>
        Mamba = 65,
        /// <summary>
        /// The transparent black.
        /// </summary>
        TransparentBlack = 72,
        /// <summary>
        /// The deep red.
        /// </summary>
        DeepRed = 76,
        /// <summary>
        /// Another oracle blue.
        /// </summary>
        AnotherOracleBlue = 78,
        /// <summary>
        /// The transparent red.
        /// </summary>
        TransparentRed = 79,
        /// <summary>
        /// The transparent blue.
        /// </summary>
        TransparentBlue = 80,
        /// <summary>
        /// The purple.
        /// </summary>
        Purple = 83
    }
}

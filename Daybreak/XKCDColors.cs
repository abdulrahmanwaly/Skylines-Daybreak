﻿using System;
using UnityEngine;

namespace Daybreak
{

    public static class XKCDColors
    {
        internal class ColorTranslator
        {
            public static Color FromHtml(string hexString)
            {
                return new Color(Convert.ToInt32(hexString.Substring(1, 2), 16)/255f,
                    Convert.ToInt32(hexString.Substring(3, 2), 16)/255f,
                    Convert.ToInt32(hexString.Substring(5, 2), 16)/255f);
            }
        }

        public static Color CloudyBlue
        {
            get { return ColorTranslator.FromHtml("#acc2d9"); }
        }

        public static Color DarkPastelGreen
        {
            get { return ColorTranslator.FromHtml("#56ae57"); }
        }

        public static Color Dust
        {
            get { return ColorTranslator.FromHtml("#b2996e"); }
        }

        public static Color ElectricLime
        {
            get { return ColorTranslator.FromHtml("#a8ff04"); }
        }

        public static Color FreshGreen
        {
            get { return ColorTranslator.FromHtml("#69d84f"); }
        }

        public static Color LightEggplant
        {
            get { return ColorTranslator.FromHtml("#894585"); }
        }

        public static Color NastyGreen
        {
            get { return ColorTranslator.FromHtml("#70b23f"); }
        }

        public static Color ReallyLightBlue
        {
            get { return ColorTranslator.FromHtml("#d4ffff"); }
        }

        public static Color Tea
        {
            get { return ColorTranslator.FromHtml("#65ab7c"); }
        }

        public static Color WarmPurple
        {
            get { return ColorTranslator.FromHtml("#952e8f"); }
        }

        public static Color YellowishTan
        {
            get { return ColorTranslator.FromHtml("#fcfc81"); }
        }

        public static Color Cement
        {
            get { return ColorTranslator.FromHtml("#a5a391"); }
        }

        public static Color DarkGrassGreen
        {
            get { return ColorTranslator.FromHtml("#388004"); }
        }

        public static Color DustyTeal
        {
            get { return ColorTranslator.FromHtml("#4c9085"); }
        }

        public static Color GreyTeal
        {
            get { return ColorTranslator.FromHtml("#5e9b8a"); }
        }

        public static Color MacaroniAndCheese
        {
            get { return ColorTranslator.FromHtml("#efb435"); }
        }

        public static Color PinkishTan
        {
            get { return ColorTranslator.FromHtml("#d99b82"); }
        }

        public static Color Spruce
        {
            get { return ColorTranslator.FromHtml("#0a5f38"); }
        }

        public static Color StrongBlue
        {
            get { return ColorTranslator.FromHtml("#0c06f7"); }
        }

        public static Color ToxicGreen
        {
            get { return ColorTranslator.FromHtml("#61de2a"); }
        }

        public static Color WindowsBlue
        {
            get { return ColorTranslator.FromHtml("#3778bf"); }
        }

        public static Color BlueBlue
        {
            get { return ColorTranslator.FromHtml("#2242c7"); }
        }

        public static Color BlueWithAHintOfPurple
        {
            get { return ColorTranslator.FromHtml("#533cc6"); }
        }

        public static Color Booger
        {
            get { return ColorTranslator.FromHtml("#9bb53c"); }
        }

        public static Color BrightSeaGreen
        {
            get { return ColorTranslator.FromHtml("#05ffa6"); }
        }

        public static Color DarkGreenBlue
        {
            get { return ColorTranslator.FromHtml("#1f6357"); }
        }

        public static Color DeepTurquoise
        {
            get { return ColorTranslator.FromHtml("#017374"); }
        }

        public static Color GreenTeal
        {
            get { return ColorTranslator.FromHtml("#0cb577"); }
        }

        public static Color StrongPink
        {
            get { return ColorTranslator.FromHtml("#ff0789"); }
        }

        public static Color Bland
        {
            get { return ColorTranslator.FromHtml("#afa88b"); }
        }

        public static Color DeepAqua
        {
            get { return ColorTranslator.FromHtml("#08787f"); }
        }

        public static Color LavenderPink
        {
            get { return ColorTranslator.FromHtml("#dd85d7"); }
        }

        public static Color LightMossGreen
        {
            get { return ColorTranslator.FromHtml("#a6c875"); }
        }

        public static Color LightSeafoamGreen
        {
            get { return ColorTranslator.FromHtml("#a7ffb5"); }
        }

        public static Color OliveYellow
        {
            get { return ColorTranslator.FromHtml("#c2b709"); }
        }

        public static Color PigPink
        {
            get { return ColorTranslator.FromHtml("#e78ea5"); }
        }

        public static Color DeepLilac
        {
            get { return ColorTranslator.FromHtml("#966ebd"); }
        }

        public static Color Desert
        {
            get { return ColorTranslator.FromHtml("#ccad60"); }
        }

        public static Color DustyLavender
        {
            get { return ColorTranslator.FromHtml("#ac86a8"); }
        }

        public static Color PurpleyGrey
        {
            get { return ColorTranslator.FromHtml("#947e94"); }
        }

        public static Color Purply
        {
            get { return ColorTranslator.FromHtml("#983fb2"); }
        }

        public static Color CandyPink
        {
            get { return ColorTranslator.FromHtml("#ff63e9"); }
        }

        public static Color LightPastelGreen
        {
            get { return ColorTranslator.FromHtml("#b2fba5"); }
        }

        public static Color BoringGreen
        {
            get { return ColorTranslator.FromHtml("#63b365"); }
        }

        public static Color KiwiGreen
        {
            get { return ColorTranslator.FromHtml("#8ee53f"); }
        }

        public static Color LightGreyGreen
        {
            get { return ColorTranslator.FromHtml("#b7e1a1"); }
        }

        public static Color OrangePink
        {
            get { return ColorTranslator.FromHtml("#ff6f52"); }
        }

        public static Color TeaGreen
        {
            get { return ColorTranslator.FromHtml("#bdf8a3"); }
        }

        public static Color VeryLightBrown
        {
            get { return ColorTranslator.FromHtml("#d3b683"); }
        }

        public static Color EggShell
        {
            get { return ColorTranslator.FromHtml("#fffcc4"); }
        }

        public static Color EggplantPurple
        {
            get { return ColorTranslator.FromHtml("#430541"); }
        }

        public static Color PowderPink
        {
            get { return ColorTranslator.FromHtml("#ffb2d0"); }
        }

        public static Color ReddishGrey
        {
            get { return ColorTranslator.FromHtml("#997570"); }
        }

        public static Color BabyShitBrown
        {
            get { return ColorTranslator.FromHtml("#ad900d"); }
        }

        public static Color Liliac
        {
            get { return ColorTranslator.FromHtml("#c48efd"); }
        }

        public static Color StormyBlue
        {
            get { return ColorTranslator.FromHtml("#507b9c"); }
        }

        public static Color UglyBrown
        {
            get { return ColorTranslator.FromHtml("#7d7103"); }
        }

        public static Color Custard
        {
            get { return ColorTranslator.FromHtml("#fffd78"); }
        }

        public static Color DarkishPink
        {
            get { return ColorTranslator.FromHtml("#da467d"); }
        }

        public static Color DeepBrown
        {
            get { return ColorTranslator.FromHtml("#410200"); }
        }

        public static Color GreenishBeige
        {
            get { return ColorTranslator.FromHtml("#c9d179"); }
        }

        public static Color Manilla
        {
            get { return ColorTranslator.FromHtml("#fffa86"); }
        }

        public static Color OffBlue
        {
            get { return ColorTranslator.FromHtml("#5684ae"); }
        }

        public static Color BattleshipGrey
        {
            get { return ColorTranslator.FromHtml("#6b7c85"); }
        }

        public static Color BrownyGreen
        {
            get { return ColorTranslator.FromHtml("#6f6c0a"); }
        }

        public static Color Bruise
        {
            get { return ColorTranslator.FromHtml("#7e4071"); }
        }

        public static Color KelleyGreen
        {
            get { return ColorTranslator.FromHtml("#009337"); }
        }

        public static Color SicklyYellow
        {
            get { return ColorTranslator.FromHtml("#d0e429"); }
        }

        public static Color SunnyYellow
        {
            get { return ColorTranslator.FromHtml("#fff917"); }
        }

        public static Color Azul
        {
            get { return ColorTranslator.FromHtml("#1d5dec"); }
        }

        public static Color Darkgreen
        {
            get { return ColorTranslator.FromHtml("#054907"); }
        }

        public static Color Green_Yellow
        {
            get { return ColorTranslator.FromHtml("#b5ce08"); }
        }

        public static Color Lichen
        {
            get { return ColorTranslator.FromHtml("#8fb67b"); }
        }

        public static Color LightLightGreen
        {
            get { return ColorTranslator.FromHtml("#c8ffb0"); }
        }

        public static Color PaleGold
        {
            get { return ColorTranslator.FromHtml("#fdde6c"); }
        }

        public static Color SunYellow
        {
            get { return ColorTranslator.FromHtml("#ffdf22"); }
        }

        public static Color TanGreen
        {
            get { return ColorTranslator.FromHtml("#a9be70"); }
        }

        public static Color Burple
        {
            get { return ColorTranslator.FromHtml("#6832e3"); }
        }

        public static Color Butterscotch
        {
            get { return ColorTranslator.FromHtml("#fdb147"); }
        }

        public static Color Toupe
        {
            get { return ColorTranslator.FromHtml("#c7ac7d"); }
        }

        public static Color DarkCream
        {
            get { return ColorTranslator.FromHtml("#fff39a"); }
        }

        public static Color IndianRed
        {
            get { return ColorTranslator.FromHtml("#850e04"); }
        }

        public static Color LightLavendar
        {
            get { return ColorTranslator.FromHtml("#efc0fe"); }
        }

        public static Color PoisonGreen
        {
            get { return ColorTranslator.FromHtml("#40fd14"); }
        }

        public static Color BabyPukeGreen
        {
            get { return ColorTranslator.FromHtml("#b6c406"); }
        }

        public static Color BrightYellowGreen
        {
            get { return ColorTranslator.FromHtml("#9dff00"); }
        }

        public static Color CharcoalGrey
        {
            get { return ColorTranslator.FromHtml("#3c4142"); }
        }

        public static Color Squash
        {
            get { return ColorTranslator.FromHtml("#f2ab15"); }
        }

        public static Color Cinnamon
        {
            get { return ColorTranslator.FromHtml("#ac4f06"); }
        }

        public static Color LightPeaGreen
        {
            get { return ColorTranslator.FromHtml("#c4fe82"); }
        }

        public static Color RadioactiveGreen
        {
            get { return ColorTranslator.FromHtml("#2cfa1f"); }
        }

        public static Color RawSienna
        {
            get { return ColorTranslator.FromHtml("#9a6200"); }
        }

        public static Color BabyPurple
        {
            get { return ColorTranslator.FromHtml("#ca9bf7"); }
        }

        public static Color Cocoa
        {
            get { return ColorTranslator.FromHtml("#875f42"); }
        }

        public static Color LightRoyalBlue
        {
            get { return ColorTranslator.FromHtml("#3a2efe"); }
        }

        public static Color Orangeish
        {
            get { return ColorTranslator.FromHtml("#fd8d49"); }
        }

        public static Color RustBrown
        {
            get { return ColorTranslator.FromHtml("#8b3103"); }
        }

        public static Color SandBrown
        {
            get { return ColorTranslator.FromHtml("#cba560"); }
        }

        public static Color Swamp
        {
            get { return ColorTranslator.FromHtml("#698339"); }
        }

        public static Color TealishGreen
        {
            get { return ColorTranslator.FromHtml("#0cdc73"); }
        }

        public static Color BurntSiena
        {
            get { return ColorTranslator.FromHtml("#b75203"); }
        }

        public static Color Camo
        {
            get { return ColorTranslator.FromHtml("#7f8f4e"); }
        }

        public static Color DuskBlue
        {
            get { return ColorTranslator.FromHtml("#26538d"); }
        }

        public static Color Fern
        {
            get { return ColorTranslator.FromHtml("#63a950"); }
        }

        public static Color OldRose
        {
            get { return ColorTranslator.FromHtml("#c87f89"); }
        }

        public static Color PaleLightGreen
        {
            get { return ColorTranslator.FromHtml("#b1fc99"); }
        }

        public static Color PeachyPink
        {
            get { return ColorTranslator.FromHtml("#ff9a8a"); }
        }

        public static Color RosyPink
        {
            get { return ColorTranslator.FromHtml("#f6688e"); }
        }

        public static Color LightBluishGreen
        {
            get { return ColorTranslator.FromHtml("#76fda8"); }
        }

        public static Color LightBrightGreen
        {
            get { return ColorTranslator.FromHtml("#53fe5c"); }
        }

        public static Color LightNeonGreen
        {
            get { return ColorTranslator.FromHtml("#4efd54"); }
        }

        public static Color LightSeafoam
        {
            get { return ColorTranslator.FromHtml("#a0febf"); }
        }

        public static Color TiffanyBlue
        {
            get { return ColorTranslator.FromHtml("#7bf2da"); }
        }

        public static Color WashedOutGreen
        {
            get { return ColorTranslator.FromHtml("#bcf5a6"); }
        }

        public static Color BrownyOrange
        {
            get { return ColorTranslator.FromHtml("#ca6b02"); }
        }

        public static Color NiceBlue
        {
            get { return ColorTranslator.FromHtml("#107ab0"); }
        }

        public static Color Sapphire
        {
            get { return ColorTranslator.FromHtml("#2138ab"); }
        }

        public static Color GreyishTeal
        {
            get { return ColorTranslator.FromHtml("#719f91"); }
        }

        public static Color OrangeyYellow
        {
            get { return ColorTranslator.FromHtml("#fdb915"); }
        }

        public static Color Parchment
        {
            get { return ColorTranslator.FromHtml("#fefcaf"); }
        }

        public static Color Straw
        {
            get { return ColorTranslator.FromHtml("#fcf679"); }
        }

        public static Color VeryDarkBrown
        {
            get { return ColorTranslator.FromHtml("#1d0200"); }
        }

        public static Color Terracota
        {
            get { return ColorTranslator.FromHtml("#cb6843"); }
        }

        public static Color UglyBlue
        {
            get { return ColorTranslator.FromHtml("#31668a"); }
        }

        public static Color ClearBlue
        {
            get { return ColorTranslator.FromHtml("#247afd"); }
        }

        public static Color Creme
        {
            get { return ColorTranslator.FromHtml("#ffffb6"); }
        }

        public static Color FoamGreen
        {
            get { return ColorTranslator.FromHtml("#90fda9"); }
        }

        public static Color Grey_Green
        {
            get { return ColorTranslator.FromHtml("#86a17d"); }
        }

        public static Color LightGold
        {
            get { return ColorTranslator.FromHtml("#fddc5c"); }
        }

        public static Color SeafoamBlue
        {
            get { return ColorTranslator.FromHtml("#78d1b6"); }
        }

        public static Color Topaz
        {
            get { return ColorTranslator.FromHtml("#13bbaf"); }
        }

        public static Color VioletPink
        {
            get { return ColorTranslator.FromHtml("#fb5ffc"); }
        }

        public static Color Wintergreen
        {
            get { return ColorTranslator.FromHtml("#20f986"); }
        }

        public static Color YellowTan
        {
            get { return ColorTranslator.FromHtml("#ffe36e"); }
        }

        public static Color DarkFuchsia
        {
            get { return ColorTranslator.FromHtml("#9d0759"); }
        }

        public static Color IndigoBlue
        {
            get { return ColorTranslator.FromHtml("#3a18b1"); }
        }

        public static Color LightYellowishGreen
        {
            get { return ColorTranslator.FromHtml("#c2ff89"); }
        }

        public static Color PaleMagenta
        {
            get { return ColorTranslator.FromHtml("#d767ad"); }
        }

        public static Color RichPurple
        {
            get { return ColorTranslator.FromHtml("#720058"); }
        }

        public static Color SunflowerYellow
        {
            get { return ColorTranslator.FromHtml("#ffda03"); }
        }

        public static Color Green_Blue
        {
            get { return ColorTranslator.FromHtml("#01c08d"); }
        }

        public static Color Leather
        {
            get { return ColorTranslator.FromHtml("#ac7434"); }
        }

        public static Color RacingGreen
        {
            get { return ColorTranslator.FromHtml("#014600"); }
        }

        public static Color VividPurple
        {
            get { return ColorTranslator.FromHtml("#9900fa"); }
        }

        public static Color DarkRoyalBlue
        {
            get { return ColorTranslator.FromHtml("#02066f"); }
        }

        public static Color Hazel
        {
            get { return ColorTranslator.FromHtml("#8e7618"); }
        }

        public static Color MutedPink
        {
            get { return ColorTranslator.FromHtml("#d1768f"); }
        }

        public static Color BoogerGreen
        {
            get { return ColorTranslator.FromHtml("#96b403"); }
        }

        public static Color Canary
        {
            get { return ColorTranslator.FromHtml("#fdff63"); }
        }

        public static Color CoolGrey
        {
            get { return ColorTranslator.FromHtml("#95a3a6"); }
        }

        public static Color DarkTaupe
        {
            get { return ColorTranslator.FromHtml("#7f684e"); }
        }

        public static Color DarkishPurple
        {
            get { return ColorTranslator.FromHtml("#751973"); }
        }

        public static Color TrueGreen
        {
            get { return ColorTranslator.FromHtml("#089404"); }
        }

        public static Color CoralPink
        {
            get { return ColorTranslator.FromHtml("#ff6163"); }
        }

        public static Color DarkSage
        {
            get { return ColorTranslator.FromHtml("#598556"); }
        }

        public static Color DarkSlateBlue
        {
            get { return ColorTranslator.FromHtml("#214761"); }
        }

        public static Color FlatBlue
        {
            get { return ColorTranslator.FromHtml("#3c73a8"); }
        }

        public static Color Mushroom
        {
            get { return ColorTranslator.FromHtml("#ba9e88"); }
        }

        public static Color RichBlue
        {
            get { return ColorTranslator.FromHtml("#021bf9"); }
        }

        public static Color DirtyPurple
        {
            get { return ColorTranslator.FromHtml("#734a65"); }
        }

        public static Color Greenblue
        {
            get { return ColorTranslator.FromHtml("#23c48b"); }
        }

        public static Color IckyGreen
        {
            get { return ColorTranslator.FromHtml("#8fae22"); }
        }

        public static Color LightKhaki
        {
            get { return ColorTranslator.FromHtml("#e6f2a2"); }
        }

        public static Color WarmBlue
        {
            get { return ColorTranslator.FromHtml("#4b57db"); }
        }

        public static Color DarkHotPink
        {
            get { return ColorTranslator.FromHtml("#d90166"); }
        }

        public static Color DeepSeaBlue
        {
            get { return ColorTranslator.FromHtml("#015482"); }
        }

        public static Color Carmine
        {
            get { return ColorTranslator.FromHtml("#9d0216"); }
        }

        public static Color DarkYellowGreen
        {
            get { return ColorTranslator.FromHtml("#728f02"); }
        }

        public static Color PalePeach
        {
            get { return ColorTranslator.FromHtml("#ffe5ad"); }
        }

        public static Color PlumPurple
        {
            get { return ColorTranslator.FromHtml("#4e0550"); }
        }

        public static Color GoldenRod
        {
            get { return ColorTranslator.FromHtml("#f9bc08"); }
        }

        public static Color NeonRed
        {
            get { return ColorTranslator.FromHtml("#ff073a"); }
        }

        public static Color OldPink
        {
            get { return ColorTranslator.FromHtml("#c77986"); }
        }

        public static Color VeryPaleBlue
        {
            get { return ColorTranslator.FromHtml("#d6fffe"); }
        }

        public static Color BloodOrange
        {
            get { return ColorTranslator.FromHtml("#fe4b03"); }
        }

        public static Color Grapefruit
        {
            get { return ColorTranslator.FromHtml("#fd5956"); }
        }

        public static Color SandYellow
        {
            get { return ColorTranslator.FromHtml("#fce166"); }
        }

        public static Color ClayBrown
        {
            get { return ColorTranslator.FromHtml("#b2713d"); }
        }

        public static Color DarkBlueGrey
        {
            get { return ColorTranslator.FromHtml("#1f3b4d"); }
        }

        public static Color FlatGreen
        {
            get { return ColorTranslator.FromHtml("#699d4c"); }
        }

        public static Color LightGreenBlue
        {
            get { return ColorTranslator.FromHtml("#56fca2"); }
        }

        public static Color WarmPink
        {
            get { return ColorTranslator.FromHtml("#fb5581"); }
        }

        public static Color DodgerBlue
        {
            get { return ColorTranslator.FromHtml("#3e82fc"); }
        }

        public static Color GrossGreen
        {
            get { return ColorTranslator.FromHtml("#a0bf16"); }
        }

        public static Color Ice
        {
            get { return ColorTranslator.FromHtml("#d6fffa"); }
        }

        public static Color MetallicBlue
        {
            get { return ColorTranslator.FromHtml("#4f738e"); }
        }

        public static Color PaleSalmon
        {
            get { return ColorTranslator.FromHtml("#ffb19a"); }
        }

        public static Color SapGreen
        {
            get { return ColorTranslator.FromHtml("#5c8b15"); }
        }

        public static Color Algae
        {
            get { return ColorTranslator.FromHtml("#54ac68"); }
        }

        public static Color BlueyGrey
        {
            get { return ColorTranslator.FromHtml("#89a0b0"); }
        }

        public static Color GreenyGrey
        {
            get { return ColorTranslator.FromHtml("#7ea07a"); }
        }

        public static Color HighlighterGreen
        {
            get { return ColorTranslator.FromHtml("#1bfc06"); }
        }

        public static Color LightLightBlue
        {
            get { return ColorTranslator.FromHtml("#cafffb"); }
        }

        public static Color LightMint
        {
            get { return ColorTranslator.FromHtml("#b6ffbb"); }
        }

        public static Color RawUmber
        {
            get { return ColorTranslator.FromHtml("#a75e09"); }
        }

        public static Color VividBlue
        {
            get { return ColorTranslator.FromHtml("#152eff"); }
        }

        public static Color DeepLavender
        {
            get { return ColorTranslator.FromHtml("#8d5eb7"); }
        }

        public static Color DullTeal
        {
            get { return ColorTranslator.FromHtml("#5f9e8f"); }
        }

        public static Color LightGreenishBlue
        {
            get { return ColorTranslator.FromHtml("#63f7b4"); }
        }

        public static Color MudGreen
        {
            get { return ColorTranslator.FromHtml("#606602"); }
        }

        public static Color Pinky
        {
            get { return ColorTranslator.FromHtml("#fc86aa"); }
        }

        public static Color RedWine
        {
            get { return ColorTranslator.FromHtml("#8c0034"); }
        }

        public static Color ShitGreen
        {
            get { return ColorTranslator.FromHtml("#758000"); }
        }

        public static Color TanBrown
        {
            get { return ColorTranslator.FromHtml("#ab7e4c"); }
        }

        public static Color Darkblue
        {
            get { return ColorTranslator.FromHtml("#030764"); }
        }

        public static Color Rosa
        {
            get { return ColorTranslator.FromHtml("#fe86a4"); }
        }

        public static Color Lipstick
        {
            get { return ColorTranslator.FromHtml("#d5174e"); }
        }

        public static Color PaleMauve
        {
            get { return ColorTranslator.FromHtml("#fed0fc"); }
        }

        public static Color Claret
        {
            get { return ColorTranslator.FromHtml("#680018"); }
        }

        public static Color Dandelion
        {
            get { return ColorTranslator.FromHtml("#fedf08"); }
        }

        public static Color Orangered
        {
            get { return ColorTranslator.FromHtml("#fe420f"); }
        }

        public static Color PoopGreen
        {
            get { return ColorTranslator.FromHtml("#6f7c00"); }
        }

        public static Color Ruby
        {
            get { return ColorTranslator.FromHtml("#ca0147"); }
        }

        public static Color Dark
        {
            get { return ColorTranslator.FromHtml("#1b2431"); }
        }

        public static Color GreenishTurquoise
        {
            get { return ColorTranslator.FromHtml("#00fbb0"); }
        }

        public static Color PastelRed
        {
            get { return ColorTranslator.FromHtml("#db5856"); }
        }

        public static Color PissYellow
        {
            get { return ColorTranslator.FromHtml("#ddd618"); }
        }

        public static Color BrightCyan
        {
            get { return ColorTranslator.FromHtml("#41fdfe"); }
        }

        public static Color DarkCoral
        {
            get { return ColorTranslator.FromHtml("#cf524e"); }
        }

        public static Color AlgaeGreen
        {
            get { return ColorTranslator.FromHtml("#21c36f"); }
        }

        public static Color DarkishRed
        {
            get { return ColorTranslator.FromHtml("#a90308"); }
        }

        public static Color ReddyBrown
        {
            get { return ColorTranslator.FromHtml("#6e1005"); }
        }

        public static Color BlushPink
        {
            get { return ColorTranslator.FromHtml("#fe828c"); }
        }

        public static Color CamouflageGreen
        {
            get { return ColorTranslator.FromHtml("#4b6113"); }
        }

        public static Color LawnGreen
        {
            get { return ColorTranslator.FromHtml("#4da409"); }
        }

        public static Color Putty
        {
            get { return ColorTranslator.FromHtml("#beae8a"); }
        }

        public static Color VibrantBlue
        {
            get { return ColorTranslator.FromHtml("#0339f8"); }
        }

        public static Color DarkSand
        {
            get { return ColorTranslator.FromHtml("#a88f59"); }
        }

        public static Color Purple_Blue
        {
            get { return ColorTranslator.FromHtml("#5d21d0"); }
        }

        public static Color Saffron
        {
            get { return ColorTranslator.FromHtml("#feb209"); }
        }

        public static Color Twilight
        {
            get { return ColorTranslator.FromHtml("#4e518b"); }
        }

        public static Color WarmBrown
        {
            get { return ColorTranslator.FromHtml("#964e02"); }
        }

        public static Color Bluegrey
        {
            get { return ColorTranslator.FromHtml("#85a3b2"); }
        }

        public static Color BubbleGumPink
        {
            get { return ColorTranslator.FromHtml("#ff69af"); }
        }

        public static Color DuckEggBlue
        {
            get { return ColorTranslator.FromHtml("#c3fbf4"); }
        }

        public static Color GreenishCyan
        {
            get { return ColorTranslator.FromHtml("#2afeb7"); }
        }

        public static Color Petrol
        {
            get { return ColorTranslator.FromHtml("#005f6a"); }
        }

        public static Color Royal
        {
            get { return ColorTranslator.FromHtml("#0c1793"); }
        }

        public static Color Butter
        {
            get { return ColorTranslator.FromHtml("#ffff81"); }
        }

        public static Color DustyOrange
        {
            get { return ColorTranslator.FromHtml("#f0833a"); }
        }

        public static Color OffYellow
        {
            get { return ColorTranslator.FromHtml("#f1f33f"); }
        }

        public static Color PaleOliveGreen
        {
            get { return ColorTranslator.FromHtml("#b1d27b"); }
        }

        public static Color Orangish
        {
            get { return ColorTranslator.FromHtml("#fc824a"); }
        }

        public static Color Leaf
        {
            get { return ColorTranslator.FromHtml("#71aa34"); }
        }

        public static Color LightBlueGrey
        {
            get { return ColorTranslator.FromHtml("#b7c9e2"); }
        }

        public static Color DriedBlood
        {
            get { return ColorTranslator.FromHtml("#4b0101"); }
        }

        public static Color LightishPurple
        {
            get { return ColorTranslator.FromHtml("#a552e6"); }
        }

        public static Color RustyRed
        {
            get { return ColorTranslator.FromHtml("#af2f0d"); }
        }

        public static Color LavenderBlue
        {
            get { return ColorTranslator.FromHtml("#8b88f8"); }
        }

        public static Color LightGrassGreen
        {
            get { return ColorTranslator.FromHtml("#9af764"); }
        }

        public static Color LightMintGreen
        {
            get { return ColorTranslator.FromHtml("#a6fbb2"); }
        }

        public static Color Sunflower
        {
            get { return ColorTranslator.FromHtml("#ffc512"); }
        }

        public static Color Velvet
        {
            get { return ColorTranslator.FromHtml("#750851"); }
        }

        public static Color BrickOrange
        {
            get { return ColorTranslator.FromHtml("#c14a09"); }
        }

        public static Color LightishRed
        {
            get { return ColorTranslator.FromHtml("#fe2f4a"); }
        }

        public static Color PureBlue
        {
            get { return ColorTranslator.FromHtml("#0203e2"); }
        }

        public static Color TwilightBlue
        {
            get { return ColorTranslator.FromHtml("#0a437a"); }
        }

        public static Color VioletRed
        {
            get { return ColorTranslator.FromHtml("#a50055"); }
        }

        public static Color YellowyBrown
        {
            get { return ColorTranslator.FromHtml("#ae8b0c"); }
        }

        public static Color Carnation
        {
            get { return ColorTranslator.FromHtml("#fd798f"); }
        }

        public static Color MuddyYellow
        {
            get { return ColorTranslator.FromHtml("#bfac05"); }
        }

        public static Color DarkSeafoamGreen
        {
            get { return ColorTranslator.FromHtml("#3eaf76"); }
        }

        public static Color DeepRose
        {
            get { return ColorTranslator.FromHtml("#c74767"); }
        }

        public static Color DustyRed
        {
            get { return ColorTranslator.FromHtml("#b9484e"); }
        }

        public static Color Grey_Blue
        {
            get { return ColorTranslator.FromHtml("#647d8e"); }
        }

        public static Color LemonLime
        {
            get { return ColorTranslator.FromHtml("#bffe28"); }
        }

        public static Color Purple_Pink
        {
            get { return ColorTranslator.FromHtml("#d725de"); }
        }

        public static Color BrownYellow
        {
            get { return ColorTranslator.FromHtml("#b29705"); }
        }

        public static Color PurpleBrown
        {
            get { return ColorTranslator.FromHtml("#673a3f"); }
        }

        public static Color Wisteria
        {
            get { return ColorTranslator.FromHtml("#a87dc2"); }
        }

        public static Color BananaYellow
        {
            get { return ColorTranslator.FromHtml("#fafe4b"); }
        }

        public static Color LipstickRed
        {
            get { return ColorTranslator.FromHtml("#c0022f"); }
        }

        public static Color WaterBlue
        {
            get { return ColorTranslator.FromHtml("#0e87cc"); }
        }

        public static Color BrownGrey
        {
            get { return ColorTranslator.FromHtml("#8d8468"); }
        }

        public static Color VibrantPurple
        {
            get { return ColorTranslator.FromHtml("#ad03de"); }
        }

        public static Color BabyGreen
        {
            get { return ColorTranslator.FromHtml("#8cff9e"); }
        }

        public static Color BarfGreen
        {
            get { return ColorTranslator.FromHtml("#94ac02"); }
        }

        public static Color EggshellBlue
        {
            get { return ColorTranslator.FromHtml("#c4fff7"); }
        }

        public static Color SandyYellow
        {
            get { return ColorTranslator.FromHtml("#fdee73"); }
        }

        public static Color CoolGreen
        {
            get { return ColorTranslator.FromHtml("#33b864"); }
        }

        public static Color Pale
        {
            get { return ColorTranslator.FromHtml("#fff9d0"); }
        }

        public static Color Blue_Grey
        {
            get { return ColorTranslator.FromHtml("#758da3"); }
        }

        public static Color HotMagenta
        {
            get { return ColorTranslator.FromHtml("#f504c9"); }
        }

        public static Color Greyblue
        {
            get { return ColorTranslator.FromHtml("#77a1b5"); }
        }

        public static Color Purpley
        {
            get { return ColorTranslator.FromHtml("#8756e4"); }
        }

        public static Color BabyShitGreen
        {
            get { return ColorTranslator.FromHtml("#889717"); }
        }

        public static Color BrownishPink
        {
            get { return ColorTranslator.FromHtml("#c27e79"); }
        }

        public static Color DarkAquamarine
        {
            get { return ColorTranslator.FromHtml("#017371"); }
        }

        public static Color Diarrhea
        {
            get { return ColorTranslator.FromHtml("#9f8303"); }
        }

        public static Color LightMustard
        {
            get { return ColorTranslator.FromHtml("#f7d560"); }
        }

        public static Color PaleSkyBlue
        {
            get { return ColorTranslator.FromHtml("#bdf6fe"); }
        }

        public static Color TurtleGreen
        {
            get { return ColorTranslator.FromHtml("#75b84f"); }
        }

        public static Color BrightOlive
        {
            get { return ColorTranslator.FromHtml("#9cbb04"); }
        }

        public static Color DarkGreyBlue
        {
            get { return ColorTranslator.FromHtml("#29465b"); }
        }

        public static Color GreenyBrown
        {
            get { return ColorTranslator.FromHtml("#696006"); }
        }

        public static Color LemonGreen
        {
            get { return ColorTranslator.FromHtml("#adf802"); }
        }

        public static Color LightPeriwinkle
        {
            get { return ColorTranslator.FromHtml("#c1c6fc"); }
        }

        public static Color SeaweedGreen
        {
            get { return ColorTranslator.FromHtml("#35ad6b"); }
        }

        public static Color SunshineYellow
        {
            get { return ColorTranslator.FromHtml("#fffd37"); }
        }

        public static Color UglyPurple
        {
            get { return ColorTranslator.FromHtml("#a442a0"); }
        }

        public static Color MediumPink
        {
            get { return ColorTranslator.FromHtml("#f36196"); }
        }

        public static Color PukeBrown
        {
            get { return ColorTranslator.FromHtml("#947706"); }
        }

        public static Color VeryLightPink
        {
            get { return ColorTranslator.FromHtml("#fff4f2"); }
        }

        public static Color Viridian
        {
            get { return ColorTranslator.FromHtml("#1e9167"); }
        }

        public static Color Bile
        {
            get { return ColorTranslator.FromHtml("#b5c306"); }
        }

        public static Color FadedYellow
        {
            get { return ColorTranslator.FromHtml("#feff7f"); }
        }

        public static Color VeryPaleGreen
        {
            get { return ColorTranslator.FromHtml("#cffdbc"); }
        }

        public static Color VibrantGreen
        {
            get { return ColorTranslator.FromHtml("#0add08"); }
        }

        public static Color BrightLime
        {
            get { return ColorTranslator.FromHtml("#87fd05"); }
        }

        public static Color Spearmint
        {
            get { return ColorTranslator.FromHtml("#1ef876"); }
        }

        public static Color LightAquamarine
        {
            get { return ColorTranslator.FromHtml("#7bfdc7"); }
        }

        public static Color LightSage
        {
            get { return ColorTranslator.FromHtml("#bcecac"); }
        }

        public static Color Yellowgreen
        {
            get { return ColorTranslator.FromHtml("#bbf90f"); }
        }

        public static Color BabyPoo
        {
            get { return ColorTranslator.FromHtml("#ab9004"); }
        }

        public static Color DarkSeafoam
        {
            get { return ColorTranslator.FromHtml("#1fb57a"); }
        }

        public static Color DeepTeal
        {
            get { return ColorTranslator.FromHtml("#00555a"); }
        }

        public static Color Heather
        {
            get { return ColorTranslator.FromHtml("#a484ac"); }
        }

        public static Color RustOrange
        {
            get { return ColorTranslator.FromHtml("#c45508"); }
        }

        public static Color DirtyBlue
        {
            get { return ColorTranslator.FromHtml("#3f829d"); }
        }

        public static Color FernGreen
        {
            get { return ColorTranslator.FromHtml("#548d44"); }
        }

        public static Color BrightLilac
        {
            get { return ColorTranslator.FromHtml("#c95efb"); }
        }

        public static Color WeirdGreen
        {
            get { return ColorTranslator.FromHtml("#3ae57f"); }
        }

        public static Color PeacockBlue
        {
            get { return ColorTranslator.FromHtml("#016795"); }
        }

        public static Color AvocadoGreen
        {
            get { return ColorTranslator.FromHtml("#87a922"); }
        }

        public static Color FadedOrange
        {
            get { return ColorTranslator.FromHtml("#f0944d"); }
        }

        public static Color GrapePurple
        {
            get { return ColorTranslator.FromHtml("#5d1451"); }
        }

        public static Color HotGreen
        {
            get { return ColorTranslator.FromHtml("#25ff29"); }
        }

        public static Color LimeYellow
        {
            get { return ColorTranslator.FromHtml("#d0fe1d"); }
        }

        public static Color Mango
        {
            get { return ColorTranslator.FromHtml("#ffa62b"); }
        }

        public static Color Shamrock
        {
            get { return ColorTranslator.FromHtml("#01b44c"); }
        }

        public static Color Bubblegum
        {
            get { return ColorTranslator.FromHtml("#ff6cb5"); }
        }

        public static Color PurplishBrown
        {
            get { return ColorTranslator.FromHtml("#6b4247"); }
        }

        public static Color VomitYellow
        {
            get { return ColorTranslator.FromHtml("#c7c10c"); }
        }

        public static Color PaleCyan
        {
            get { return ColorTranslator.FromHtml("#b7fffa"); }
        }

        public static Color KeyLime
        {
            get { return ColorTranslator.FromHtml("#aeff6e"); }
        }

        public static Color TomatoRed
        {
            get { return ColorTranslator.FromHtml("#ec2d01"); }
        }

        public static Color Lightgreen
        {
            get { return ColorTranslator.FromHtml("#76ff7b"); }
        }

        public static Color Merlot
        {
            get { return ColorTranslator.FromHtml("#730039"); }
        }

        public static Color NightBlue
        {
            get { return ColorTranslator.FromHtml("#040348"); }
        }

        public static Color PurpleishPink
        {
            get { return ColorTranslator.FromHtml("#df4ec8"); }
        }

        public static Color Apple
        {
            get { return ColorTranslator.FromHtml("#6ecb3c"); }
        }

        public static Color BabyPoopGreen
        {
            get { return ColorTranslator.FromHtml("#8f9805"); }
        }

        public static Color GreenApple
        {
            get { return ColorTranslator.FromHtml("#5edc1f"); }
        }

        public static Color Heliotrope
        {
            get { return ColorTranslator.FromHtml("#d94ff5"); }
        }

        public static Color Yellow_Green
        {
            get { return ColorTranslator.FromHtml("#c8fd3d"); }
        }

        public static Color AlmostBlack
        {
            get { return ColorTranslator.FromHtml("#070d0d"); }
        }

        public static Color CoolBlue
        {
            get { return ColorTranslator.FromHtml("#4984b8"); }
        }

        public static Color LeafyGreen
        {
            get { return ColorTranslator.FromHtml("#51b73b"); }
        }

        public static Color MustardBrown
        {
            get { return ColorTranslator.FromHtml("#ac7e04"); }
        }

        public static Color Dusk
        {
            get { return ColorTranslator.FromHtml("#4e5481"); }
        }

        public static Color DullBrown
        {
            get { return ColorTranslator.FromHtml("#876e4b"); }
        }

        public static Color FrogGreen
        {
            get { return ColorTranslator.FromHtml("#58bc08"); }
        }

        public static Color VividGreen
        {
            get { return ColorTranslator.FromHtml("#2fef10"); }
        }

        public static Color BrightLightGreen
        {
            get { return ColorTranslator.FromHtml("#2dfe54"); }
        }

        public static Color FluroGreen
        {
            get { return ColorTranslator.FromHtml("#0aff02"); }
        }

        public static Color Kiwi
        {
            get { return ColorTranslator.FromHtml("#9cef43"); }
        }

        public static Color Seaweed
        {
            get { return ColorTranslator.FromHtml("#18d17b"); }
        }

        public static Color NavyGreen
        {
            get { return ColorTranslator.FromHtml("#35530a"); }
        }

        public static Color UltramarineBlue
        {
            get { return ColorTranslator.FromHtml("#1805db"); }
        }

        public static Color Iris
        {
            get { return ColorTranslator.FromHtml("#6258c4"); }
        }

        public static Color PastelOrange
        {
            get { return ColorTranslator.FromHtml("#ff964f"); }
        }

        public static Color YellowishOrange
        {
            get { return ColorTranslator.FromHtml("#ffab0f"); }
        }

        public static Color Perrywinkle
        {
            get { return ColorTranslator.FromHtml("#8f8ce7"); }
        }

        public static Color Tealish
        {
            get { return ColorTranslator.FromHtml("#24bca8"); }
        }

        public static Color DarkPlum
        {
            get { return ColorTranslator.FromHtml("#3f012c"); }
        }

        public static Color Pear
        {
            get { return ColorTranslator.FromHtml("#cbf85f"); }
        }

        public static Color PinkishOrange
        {
            get { return ColorTranslator.FromHtml("#ff724c"); }
        }

        public static Color MidnightPurple
        {
            get { return ColorTranslator.FromHtml("#280137"); }
        }

        public static Color LightUrple
        {
            get { return ColorTranslator.FromHtml("#b36ff6"); }
        }

        public static Color DarkMint
        {
            get { return ColorTranslator.FromHtml("#48c072"); }
        }

        public static Color GreenishTan
        {
            get { return ColorTranslator.FromHtml("#bccb7a"); }
        }

        public static Color LightBurgundy
        {
            get { return ColorTranslator.FromHtml("#a8415b"); }
        }

        public static Color TurquoiseBlue
        {
            get { return ColorTranslator.FromHtml("#06b1c4"); }
        }

        public static Color UglyPink
        {
            get { return ColorTranslator.FromHtml("#cd7584"); }
        }

        public static Color Sandy
        {
            get { return ColorTranslator.FromHtml("#f1da7a"); }
        }

        public static Color ElectricPink
        {
            get { return ColorTranslator.FromHtml("#ff0490"); }
        }

        public static Color MutedPurple
        {
            get { return ColorTranslator.FromHtml("#805b87"); }
        }

        public static Color MidGreen
        {
            get { return ColorTranslator.FromHtml("#50a747"); }
        }

        public static Color Greyish
        {
            get { return ColorTranslator.FromHtml("#a8a495"); }
        }

        public static Color NeonYellow
        {
            get { return ColorTranslator.FromHtml("#cfff04"); }
        }

        public static Color Banana
        {
            get { return ColorTranslator.FromHtml("#ffff7e"); }
        }

        public static Color CarnationPink
        {
            get { return ColorTranslator.FromHtml("#ff7fa7"); }
        }

        public static Color Tomato
        {
            get { return ColorTranslator.FromHtml("#ef4026"); }
        }

        public static Color Sea
        {
            get { return ColorTranslator.FromHtml("#3c9992"); }
        }

        public static Color MuddyBrown
        {
            get { return ColorTranslator.FromHtml("#886806"); }
        }

        public static Color TurquoiseGreen
        {
            get { return ColorTranslator.FromHtml("#04f489"); }
        }

        public static Color Buff
        {
            get { return ColorTranslator.FromHtml("#fef69e"); }
        }

        public static Color Fawn
        {
            get { return ColorTranslator.FromHtml("#cfaf7b"); }
        }

        public static Color MutedBlue
        {
            get { return ColorTranslator.FromHtml("#3b719f"); }
        }

        public static Color PaleRose
        {
            get { return ColorTranslator.FromHtml("#fdc1c5"); }
        }

        public static Color DarkMintGreen
        {
            get { return ColorTranslator.FromHtml("#20c073"); }
        }

        public static Color Amethyst
        {
            get { return ColorTranslator.FromHtml("#9b5fc0"); }
        }

        public static Color Blue_Green
        {
            get { return ColorTranslator.FromHtml("#0f9b8e"); }
        }

        public static Color Chestnut
        {
            get { return ColorTranslator.FromHtml("#742802"); }
        }

        public static Color SickGreen
        {
            get { return ColorTranslator.FromHtml("#9db92c"); }
        }

        public static Color Pea
        {
            get { return ColorTranslator.FromHtml("#a4bf20"); }
        }

        public static Color RustyOrange
        {
            get { return ColorTranslator.FromHtml("#cd5909"); }
        }

        public static Color Stone
        {
            get { return ColorTranslator.FromHtml("#ada587"); }
        }

        public static Color RoseRed
        {
            get { return ColorTranslator.FromHtml("#be013c"); }
        }

        public static Color PaleAqua
        {
            get { return ColorTranslator.FromHtml("#b8ffeb"); }
        }

        public static Color DeepOrange
        {
            get { return ColorTranslator.FromHtml("#dc4d01"); }
        }

        public static Color Earth
        {
            get { return ColorTranslator.FromHtml("#a2653e"); }
        }

        public static Color MossyGreen
        {
            get { return ColorTranslator.FromHtml("#638b27"); }
        }

        public static Color GrassyGreen
        {
            get { return ColorTranslator.FromHtml("#419c03"); }
        }

        public static Color PaleLimeGreen
        {
            get { return ColorTranslator.FromHtml("#b1ff65"); }
        }

        public static Color LightGreyBlue
        {
            get { return ColorTranslator.FromHtml("#9dbcd4"); }
        }

        public static Color PaleGrey
        {
            get { return ColorTranslator.FromHtml("#fdfdfe"); }
        }

        public static Color Asparagus
        {
            get { return ColorTranslator.FromHtml("#77ab56"); }
        }

        public static Color Blueberry
        {
            get { return ColorTranslator.FromHtml("#464196"); }
        }

        public static Color PurpleRed
        {
            get { return ColorTranslator.FromHtml("#990147"); }
        }

        public static Color PaleLime
        {
            get { return ColorTranslator.FromHtml("#befd73"); }
        }

        public static Color GreenishTeal
        {
            get { return ColorTranslator.FromHtml("#32bf84"); }
        }

        public static Color Caramel
        {
            get { return ColorTranslator.FromHtml("#af6f09"); }
        }

        public static Color DeepMagenta
        {
            get { return ColorTranslator.FromHtml("#a0025c"); }
        }

        public static Color LightPeach
        {
            get { return ColorTranslator.FromHtml("#ffd8b1"); }
        }

        public static Color MilkChocolate
        {
            get { return ColorTranslator.FromHtml("#7f4e1e"); }
        }

        public static Color Ocher
        {
            get { return ColorTranslator.FromHtml("#bf9b0c"); }
        }

        public static Color OffGreen
        {
            get { return ColorTranslator.FromHtml("#6ba353"); }
        }

        public static Color PurplyPink
        {
            get { return ColorTranslator.FromHtml("#f075e6"); }
        }

        public static Color Lightblue
        {
            get { return ColorTranslator.FromHtml("#7bc8f6"); }
        }

        public static Color DuskyBlue
        {
            get { return ColorTranslator.FromHtml("#475f94"); }
        }

        public static Color Golden
        {
            get { return ColorTranslator.FromHtml("#f5bf03"); }
        }

        public static Color LightBeige
        {
            get { return ColorTranslator.FromHtml("#fffeb6"); }
        }

        public static Color ButterYellow
        {
            get { return ColorTranslator.FromHtml("#fffd74"); }
        }

        public static Color DuskyPurple
        {
            get { return ColorTranslator.FromHtml("#895b7b"); }
        }

        public static Color FrenchBlue
        {
            get { return ColorTranslator.FromHtml("#436bad"); }
        }

        public static Color UglyYellow
        {
            get { return ColorTranslator.FromHtml("#d0c101"); }
        }

        public static Color GreenyYellow
        {
            get { return ColorTranslator.FromHtml("#c6f808"); }
        }

        public static Color OrangishRed
        {
            get { return ColorTranslator.FromHtml("#f43605"); }
        }

        public static Color ShamrockGreen
        {
            get { return ColorTranslator.FromHtml("#02c14d"); }
        }

        public static Color OrangishBrown
        {
            get { return ColorTranslator.FromHtml("#b25f03"); }
        }

        public static Color TreeGreen
        {
            get { return ColorTranslator.FromHtml("#2a7e19"); }
        }

        public static Color DeepViolet
        {
            get { return ColorTranslator.FromHtml("#490648"); }
        }

        public static Color Gunmetal
        {
            get { return ColorTranslator.FromHtml("#536267"); }
        }

        public static Color Blue_Purple
        {
            get { return ColorTranslator.FromHtml("#5a06ef"); }
        }

        public static Color Cherry
        {
            get { return ColorTranslator.FromHtml("#cf0234"); }
        }

        public static Color SandyBrown
        {
            get { return ColorTranslator.FromHtml("#c4a661"); }
        }

        public static Color WarmGrey
        {
            get { return ColorTranslator.FromHtml("#978a84"); }
        }

        public static Color DarkIndigo
        {
            get { return ColorTranslator.FromHtml("#1f0954"); }
        }

        public static Color Midnight
        {
            get { return ColorTranslator.FromHtml("#03012d"); }
        }

        public static Color BlueyGreen
        {
            get { return ColorTranslator.FromHtml("#2bb179"); }
        }

        public static Color GreyPink
        {
            get { return ColorTranslator.FromHtml("#c3909b"); }
        }

        public static Color SoftPurple
        {
            get { return ColorTranslator.FromHtml("#a66fb5"); }
        }

        public static Color Blood
        {
            get { return ColorTranslator.FromHtml("#770001"); }
        }

        public static Color BrownRed
        {
            get { return ColorTranslator.FromHtml("#922b05"); }
        }

        public static Color MediumGrey
        {
            get { return ColorTranslator.FromHtml("#7d7f7c"); }
        }

        public static Color Berry
        {
            get { return ColorTranslator.FromHtml("#990f4b"); }
        }

        public static Color Poo
        {
            get { return ColorTranslator.FromHtml("#8f7303"); }
        }

        public static Color PurpleyPink
        {
            get { return ColorTranslator.FromHtml("#c83cb9"); }
        }

        public static Color LightSalmon
        {
            get { return ColorTranslator.FromHtml("#fea993"); }
        }

        public static Color Snot
        {
            get { return ColorTranslator.FromHtml("#acbb0d"); }
        }

        public static Color EasterPurple
        {
            get { return ColorTranslator.FromHtml("#c071fe"); }
        }

        public static Color LightYellowGreen
        {
            get { return ColorTranslator.FromHtml("#ccfd7f"); }
        }

        public static Color DarkNavyBlue
        {
            get { return ColorTranslator.FromHtml("#00022e"); }
        }

        public static Color Drab
        {
            get { return ColorTranslator.FromHtml("#828344"); }
        }

        public static Color LightRose
        {
            get { return ColorTranslator.FromHtml("#ffc5cb"); }
        }

        public static Color Rouge
        {
            get { return ColorTranslator.FromHtml("#ab1239"); }
        }

        public static Color PurplishRed
        {
            get { return ColorTranslator.FromHtml("#b0054b"); }
        }

        public static Color SlimeGreen
        {
            get { return ColorTranslator.FromHtml("#99cc04"); }
        }

        public static Color BabyPoop
        {
            get { return ColorTranslator.FromHtml("#937c00"); }
        }

        public static Color IrishGreen
        {
            get { return ColorTranslator.FromHtml("#019529"); }
        }

        public static Color Pink_Purple
        {
            get { return ColorTranslator.FromHtml("#ef1de7"); }
        }

        public static Color DarkNavy
        {
            get { return ColorTranslator.FromHtml("#000435"); }
        }

        public static Color GreenyBlue
        {
            get { return ColorTranslator.FromHtml("#42b395"); }
        }

        public static Color LightPlum
        {
            get { return ColorTranslator.FromHtml("#9d5783"); }
        }

        public static Color PinkishGrey
        {
            get { return ColorTranslator.FromHtml("#c8aca9"); }
        }

        public static Color DirtyOrange
        {
            get { return ColorTranslator.FromHtml("#c87606"); }
        }

        public static Color RustRed
        {
            get { return ColorTranslator.FromHtml("#aa2704"); }
        }

        public static Color PaleLilac
        {
            get { return ColorTranslator.FromHtml("#e4cbff"); }
        }

        public static Color OrangeyRed
        {
            get { return ColorTranslator.FromHtml("#fa4224"); }
        }

        public static Color PrimaryBlue
        {
            get { return ColorTranslator.FromHtml("#0804f9"); }
        }

        public static Color KermitGreen
        {
            get { return ColorTranslator.FromHtml("#5cb200"); }
        }

        public static Color BrownishPurple
        {
            get { return ColorTranslator.FromHtml("#76424e"); }
        }

        public static Color MurkyGreen
        {
            get { return ColorTranslator.FromHtml("#6c7a0e"); }
        }

        public static Color Wheat
        {
            get { return ColorTranslator.FromHtml("#fbdd7e"); }
        }

        public static Color VeryDarkPurple
        {
            get { return ColorTranslator.FromHtml("#2a0134"); }
        }

        public static Color BottleGreen
        {
            get { return ColorTranslator.FromHtml("#044a05"); }
        }

        public static Color Watermelon
        {
            get { return ColorTranslator.FromHtml("#fd4659"); }
        }

        public static Color DeepSkyBlue
        {
            get { return ColorTranslator.FromHtml("#0d75f8"); }
        }

        public static Color FireEngineRed
        {
            get { return ColorTranslator.FromHtml("#fe0002"); }
        }

        public static Color YellowOchre
        {
            get { return ColorTranslator.FromHtml("#cb9d06"); }
        }

        public static Color PumpkinOrange
        {
            get { return ColorTranslator.FromHtml("#fb7d07"); }
        }

        public static Color PaleOlive
        {
            get { return ColorTranslator.FromHtml("#b9cc81"); }
        }

        public static Color LightLilac
        {
            get { return ColorTranslator.FromHtml("#edc8ff"); }
        }

        public static Color LightishGreen
        {
            get { return ColorTranslator.FromHtml("#61e160"); }
        }

        public static Color CarolinaBlue
        {
            get { return ColorTranslator.FromHtml("#8ab8fe"); }
        }

        public static Color Mulberry
        {
            get { return ColorTranslator.FromHtml("#920a4e"); }
        }

        public static Color ShockingPink
        {
            get { return ColorTranslator.FromHtml("#fe02a2"); }
        }

        public static Color Auburn
        {
            get { return ColorTranslator.FromHtml("#9a3001"); }
        }

        public static Color BrightLimeGreen
        {
            get { return ColorTranslator.FromHtml("#65fe08"); }
        }

        public static Color Celadon
        {
            get { return ColorTranslator.FromHtml("#befdb7"); }
        }

        public static Color PinkishBrown
        {
            get { return ColorTranslator.FromHtml("#b17261"); }
        }

        public static Color PooBrown
        {
            get { return ColorTranslator.FromHtml("#885f01"); }
        }

        public static Color BrightSkyBlue
        {
            get { return ColorTranslator.FromHtml("#02ccfe"); }
        }

        public static Color Celery
        {
            get { return ColorTranslator.FromHtml("#c1fd95"); }
        }

        public static Color DirtBrown
        {
            get { return ColorTranslator.FromHtml("#836539"); }
        }

        public static Color Strawberry
        {
            get { return ColorTranslator.FromHtml("#fb2943"); }
        }

        public static Color DarkLime
        {
            get { return ColorTranslator.FromHtml("#84b701"); }
        }

        public static Color Copper
        {
            get { return ColorTranslator.FromHtml("#b66325"); }
        }

        public static Color MediumBrown
        {
            get { return ColorTranslator.FromHtml("#7f5112"); }
        }

        public static Color MutedGreen
        {
            get { return ColorTranslator.FromHtml("#5fa052"); }
        }

        public static Color RobinSEgg
        {
            get { return ColorTranslator.FromHtml("#6dedfd"); }
        }

        public static Color BrightAqua
        {
            get { return ColorTranslator.FromHtml("#0bf9ea"); }
        }

        public static Color BrightLavender
        {
            get { return ColorTranslator.FromHtml("#c760ff"); }
        }

        public static Color Ivory
        {
            get { return ColorTranslator.FromHtml("#ffffcb"); }
        }

        public static Color VeryLightPurple
        {
            get { return ColorTranslator.FromHtml("#f6cefc"); }
        }

        public static Color LightNavy
        {
            get { return ColorTranslator.FromHtml("#155084"); }
        }

        public static Color PinkRed
        {
            get { return ColorTranslator.FromHtml("#f5054f"); }
        }

        public static Color OliveBrown
        {
            get { return ColorTranslator.FromHtml("#645403"); }
        }

        public static Color PoopBrown
        {
            get { return ColorTranslator.FromHtml("#7a5901"); }
        }

        public static Color MustardGreen
        {
            get { return ColorTranslator.FromHtml("#a8b504"); }
        }

        public static Color OceanGreen
        {
            get { return ColorTranslator.FromHtml("#3d9973"); }
        }

        public static Color VeryDarkBlue
        {
            get { return ColorTranslator.FromHtml("#000133"); }
        }

        public static Color DustyGreen
        {
            get { return ColorTranslator.FromHtml("#76a973"); }
        }

        public static Color LightNavyBlue
        {
            get { return ColorTranslator.FromHtml("#2e5a88"); }
        }

        public static Color MintyGreen
        {
            get { return ColorTranslator.FromHtml("#0bf77d"); }
        }

        public static Color Adobe
        {
            get { return ColorTranslator.FromHtml("#bd6c48"); }
        }

        public static Color Barney
        {
            get { return ColorTranslator.FromHtml("#ac1db8"); }
        }

        public static Color JadeGreen
        {
            get { return ColorTranslator.FromHtml("#2baf6a"); }
        }

        public static Color BrightLightBlue
        {
            get { return ColorTranslator.FromHtml("#26f7fd"); }
        }

        public static Color LightLime
        {
            get { return ColorTranslator.FromHtml("#aefd6c"); }
        }

        public static Color DarkKhaki
        {
            get { return ColorTranslator.FromHtml("#9b8f55"); }
        }

        public static Color OrangeYellow
        {
            get { return ColorTranslator.FromHtml("#ffad01"); }
        }

        public static Color Ocre
        {
            get { return ColorTranslator.FromHtml("#c69c04"); }
        }

        public static Color Maize
        {
            get { return ColorTranslator.FromHtml("#f4d054"); }
        }

        public static Color FadedPink
        {
            get { return ColorTranslator.FromHtml("#de9dac"); }
        }

        public static Color BritishRacingGreen
        {
            get { return ColorTranslator.FromHtml("#05480d"); }
        }

        public static Color Sandstone
        {
            get { return ColorTranslator.FromHtml("#c9ae74"); }
        }

        public static Color MudBrown
        {
            get { return ColorTranslator.FromHtml("#60460f"); }
        }

        public static Color LightSeaGreen
        {
            get { return ColorTranslator.FromHtml("#98f6b0"); }
        }

        public static Color RobinEggBlue
        {
            get { return ColorTranslator.FromHtml("#8af1fe"); }
        }

        public static Color AquaMarine
        {
            get { return ColorTranslator.FromHtml("#2ee8bb"); }
        }

        public static Color DarkSeaGreen
        {
            get { return ColorTranslator.FromHtml("#11875d"); }
        }

        public static Color SoftPink
        {
            get { return ColorTranslator.FromHtml("#fdb0c0"); }
        }

        public static Color OrangeyBrown
        {
            get { return ColorTranslator.FromHtml("#b16002"); }
        }

        public static Color CherryRed
        {
            get { return ColorTranslator.FromHtml("#f7022a"); }
        }

        public static Color BurntYellow
        {
            get { return ColorTranslator.FromHtml("#d5ab09"); }
        }

        public static Color BrownishGrey
        {
            get { return ColorTranslator.FromHtml("#86775f"); }
        }

        public static Color Camel
        {
            get { return ColorTranslator.FromHtml("#c69f59"); }
        }

        public static Color PurplishGrey
        {
            get { return ColorTranslator.FromHtml("#7a687f"); }
        }

        public static Color Marine
        {
            get { return ColorTranslator.FromHtml("#042e60"); }
        }

        public static Color GreyishPink
        {
            get { return ColorTranslator.FromHtml("#c88d94"); }
        }

        public static Color PaleTurquoise
        {
            get { return ColorTranslator.FromHtml("#a5fbd5"); }
        }

        public static Color PastelYellow
        {
            get { return ColorTranslator.FromHtml("#fffe71"); }
        }

        public static Color BlueyPurple
        {
            get { return ColorTranslator.FromHtml("#6241c7"); }
        }

        public static Color CanaryYellow
        {
            get { return ColorTranslator.FromHtml("#fffe40"); }
        }

        public static Color FadedRed
        {
            get { return ColorTranslator.FromHtml("#d3494e"); }
        }

        public static Color Sepia
        {
            get { return ColorTranslator.FromHtml("#985e2b"); }
        }

        public static Color Coffee
        {
            get { return ColorTranslator.FromHtml("#a6814c"); }
        }

        public static Color BrightMagenta
        {
            get { return ColorTranslator.FromHtml("#ff08e8"); }
        }

        public static Color Mocha
        {
            get { return ColorTranslator.FromHtml("#9d7651"); }
        }

        public static Color Ecru
        {
            get { return ColorTranslator.FromHtml("#feffca"); }
        }

        public static Color Purpleish
        {
            get { return ColorTranslator.FromHtml("#98568d"); }
        }

        public static Color Cranberry
        {
            get { return ColorTranslator.FromHtml("#9e003a"); }
        }

        public static Color DarkishGreen
        {
            get { return ColorTranslator.FromHtml("#287c37"); }
        }

        public static Color BrownOrange
        {
            get { return ColorTranslator.FromHtml("#b96902"); }
        }

        public static Color DuskyRose
        {
            get { return ColorTranslator.FromHtml("#ba6873"); }
        }

        public static Color Melon
        {
            get { return ColorTranslator.FromHtml("#ff7855"); }
        }

        public static Color SicklyGreen
        {
            get { return ColorTranslator.FromHtml("#94b21c"); }
        }

        public static Color Silver
        {
            get { return ColorTranslator.FromHtml("#c5c9c7"); }
        }

        public static Color PurplyBlue
        {
            get { return ColorTranslator.FromHtml("#661aee"); }
        }

        public static Color PurpleishBlue
        {
            get { return ColorTranslator.FromHtml("#6140ef"); }
        }

        public static Color HospitalGreen
        {
            get { return ColorTranslator.FromHtml("#9be5aa"); }
        }

        public static Color ShitBrown
        {
            get { return ColorTranslator.FromHtml("#7b5804"); }
        }

        public static Color MidBlue
        {
            get { return ColorTranslator.FromHtml("#276ab3"); }
        }

        public static Color Amber
        {
            get { return ColorTranslator.FromHtml("#feb308"); }
        }

        public static Color EasterGreen
        {
            get { return ColorTranslator.FromHtml("#8cfd7e"); }
        }

        public static Color SoftBlue
        {
            get { return ColorTranslator.FromHtml("#6488ea"); }
        }

        public static Color CeruleanBlue
        {
            get { return ColorTranslator.FromHtml("#056eee"); }
        }

        public static Color GoldenBrown
        {
            get { return ColorTranslator.FromHtml("#b27a01"); }
        }

        public static Color BrightTurquoise
        {
            get { return ColorTranslator.FromHtml("#0ffef9"); }
        }

        public static Color RedPink
        {
            get { return ColorTranslator.FromHtml("#fa2a55"); }
        }

        public static Color RedPurple
        {
            get { return ColorTranslator.FromHtml("#820747"); }
        }

        public static Color GreyishBrown
        {
            get { return ColorTranslator.FromHtml("#7a6a4f"); }
        }

        public static Color Vermillion
        {
            get { return ColorTranslator.FromHtml("#f4320c"); }
        }

        public static Color Russet
        {
            get { return ColorTranslator.FromHtml("#a13905"); }
        }

        public static Color SteelGrey
        {
            get { return ColorTranslator.FromHtml("#6f828a"); }
        }

        public static Color LighterPurple
        {
            get { return ColorTranslator.FromHtml("#a55af4"); }
        }

        public static Color BrightViolet
        {
            get { return ColorTranslator.FromHtml("#ad0afd"); }
        }

        public static Color PrussianBlue
        {
            get { return ColorTranslator.FromHtml("#004577"); }
        }

        public static Color SlateGreen
        {
            get { return ColorTranslator.FromHtml("#658d6d"); }
        }

        public static Color DirtyPink
        {
            get { return ColorTranslator.FromHtml("#ca7b80"); }
        }

        public static Color DarkBlueGreen
        {
            get { return ColorTranslator.FromHtml("#005249"); }
        }

        public static Color Pine
        {
            get { return ColorTranslator.FromHtml("#2b5d34"); }
        }

        public static Color YellowyGreen
        {
            get { return ColorTranslator.FromHtml("#bff128"); }
        }

        public static Color DarkGold
        {
            get { return ColorTranslator.FromHtml("#b59410"); }
        }

        public static Color Bluish
        {
            get { return ColorTranslator.FromHtml("#2976bb"); }
        }

        public static Color DarkishBlue
        {
            get { return ColorTranslator.FromHtml("#014182"); }
        }

        public static Color DullRed
        {
            get { return ColorTranslator.FromHtml("#bb3f3f"); }
        }

        public static Color PinkyRed
        {
            get { return ColorTranslator.FromHtml("#fc2647"); }
        }

        public static Color Bronze
        {
            get { return ColorTranslator.FromHtml("#a87900"); }
        }

        public static Color PaleTeal
        {
            get { return ColorTranslator.FromHtml("#82cbb2"); }
        }

        public static Color MilitaryGreen
        {
            get { return ColorTranslator.FromHtml("#667c3e"); }
        }

        public static Color BarbiePink
        {
            get { return ColorTranslator.FromHtml("#fe46a5"); }
        }

        public static Color BubblegumPink
        {
            get { return ColorTranslator.FromHtml("#fe83cc"); }
        }

        public static Color PeaSoupGreen
        {
            get { return ColorTranslator.FromHtml("#94a617"); }
        }

        public static Color DarkMustard
        {
            get { return ColorTranslator.FromHtml("#a88905"); }
        }

        public static Color Shit
        {
            get { return ColorTranslator.FromHtml("#7f5f00"); }
        }

        public static Color MediumPurple
        {
            get { return ColorTranslator.FromHtml("#9e43a2"); }
        }

        public static Color VeryDarkGreen
        {
            get { return ColorTranslator.FromHtml("#062e03"); }
        }

        public static Color Dirt
        {
            get { return ColorTranslator.FromHtml("#8a6e45"); }
        }

        public static Color DuskyPink
        {
            get { return ColorTranslator.FromHtml("#cc7a8b"); }
        }

        public static Color RedViolet
        {
            get { return ColorTranslator.FromHtml("#9e0168"); }
        }

        public static Color LemonYellow
        {
            get { return ColorTranslator.FromHtml("#fdff38"); }
        }

        public static Color Pistachio
        {
            get { return ColorTranslator.FromHtml("#c0fa8b"); }
        }

        public static Color DullYellow
        {
            get { return ColorTranslator.FromHtml("#eedc5b"); }
        }

        public static Color DarkLimeGreen
        {
            get { return ColorTranslator.FromHtml("#7ebd01"); }
        }

        public static Color DenimBlue
        {
            get { return ColorTranslator.FromHtml("#3b5b92"); }
        }

        public static Color TealBlue
        {
            get { return ColorTranslator.FromHtml("#01889f"); }
        }

        public static Color LightishBlue
        {
            get { return ColorTranslator.FromHtml("#3d7afd"); }
        }

        public static Color PurpleyBlue
        {
            get { return ColorTranslator.FromHtml("#5f34e7"); }
        }

        public static Color LightIndigo
        {
            get { return ColorTranslator.FromHtml("#6d5acf"); }
        }

        public static Color SwampGreen
        {
            get { return ColorTranslator.FromHtml("#748500"); }
        }

        public static Color BrownGreen
        {
            get { return ColorTranslator.FromHtml("#706c11"); }
        }

        public static Color DarkMaroon
        {
            get { return ColorTranslator.FromHtml("#3c0008"); }
        }

        public static Color HotPurple
        {
            get { return ColorTranslator.FromHtml("#cb00f5"); }
        }

        public static Color DarkForestGreen
        {
            get { return ColorTranslator.FromHtml("#002d04"); }
        }

        public static Color FadedBlue
        {
            get { return ColorTranslator.FromHtml("#658cbb"); }
        }

        public static Color DrabGreen
        {
            get { return ColorTranslator.FromHtml("#749551"); }
        }

        public static Color LightLimeGreen
        {
            get { return ColorTranslator.FromHtml("#b9ff66"); }
        }

        public static Color SnotGreen
        {
            get { return ColorTranslator.FromHtml("#9dc100"); }
        }

        public static Color Yellowish
        {
            get { return ColorTranslator.FromHtml("#faee66"); }
        }

        public static Color LightBlueGreen
        {
            get { return ColorTranslator.FromHtml("#7efbb3"); }
        }

        public static Color Bordeaux
        {
            get { return ColorTranslator.FromHtml("#7b002c"); }
        }

        public static Color LightMauve
        {
            get { return ColorTranslator.FromHtml("#c292a1"); }
        }

        public static Color Ocean
        {
            get { return ColorTranslator.FromHtml("#017b92"); }
        }

        public static Color Marigold
        {
            get { return ColorTranslator.FromHtml("#fcc006"); }
        }

        public static Color MuddyGreen
        {
            get { return ColorTranslator.FromHtml("#657432"); }
        }

        public static Color DullOrange
        {
            get { return ColorTranslator.FromHtml("#d8863b"); }
        }

        public static Color Steel
        {
            get { return ColorTranslator.FromHtml("#738595"); }
        }

        public static Color ElectricPurple
        {
            get { return ColorTranslator.FromHtml("#aa23ff"); }
        }

        public static Color FluorescentGreen
        {
            get { return ColorTranslator.FromHtml("#08ff08"); }
        }

        public static Color YellowishBrown
        {
            get { return ColorTranslator.FromHtml("#9b7a01"); }
        }

        public static Color Blush
        {
            get { return ColorTranslator.FromHtml("#f29e8e"); }
        }

        public static Color SoftGreen
        {
            get { return ColorTranslator.FromHtml("#6fc276"); }
        }

        public static Color BrightOrange
        {
            get { return ColorTranslator.FromHtml("#ff5b00"); }
        }

        public static Color Lemon
        {
            get { return ColorTranslator.FromHtml("#fdff52"); }
        }

        public static Color PurpleGrey
        {
            get { return ColorTranslator.FromHtml("#866f85"); }
        }

        public static Color AcidGreen
        {
            get { return ColorTranslator.FromHtml("#8ffe09"); }
        }

        public static Color PaleLavender
        {
            get { return ColorTranslator.FromHtml("#eecffe"); }
        }

        public static Color VioletBlue
        {
            get { return ColorTranslator.FromHtml("#510ac9"); }
        }

        public static Color LightForestGreen
        {
            get { return ColorTranslator.FromHtml("#4f9153"); }
        }

        public static Color BurntRed
        {
            get { return ColorTranslator.FromHtml("#9f2305"); }
        }

        public static Color KhakiGreen
        {
            get { return ColorTranslator.FromHtml("#728639"); }
        }

        public static Color Cerise
        {
            get { return ColorTranslator.FromHtml("#de0c62"); }
        }

        public static Color FadedPurple
        {
            get { return ColorTranslator.FromHtml("#916e99"); }
        }

        public static Color Apricot
        {
            get { return ColorTranslator.FromHtml("#ffb16d"); }
        }

        public static Color DarkOliveGreen
        {
            get { return ColorTranslator.FromHtml("#3c4d03"); }
        }

        public static Color GreyBrown
        {
            get { return ColorTranslator.FromHtml("#7f7053"); }
        }

        public static Color GreenGrey
        {
            get { return ColorTranslator.FromHtml("#77926f"); }
        }

        public static Color TrueBlue
        {
            get { return ColorTranslator.FromHtml("#010fcc"); }
        }

        public static Color PaleViolet
        {
            get { return ColorTranslator.FromHtml("#ceaefa"); }
        }

        public static Color PeriwinkleBlue
        {
            get { return ColorTranslator.FromHtml("#8f99fb"); }
        }

        public static Color LightSkyBlue
        {
            get { return ColorTranslator.FromHtml("#c6fcff"); }
        }

        public static Color Blurple
        {
            get { return ColorTranslator.FromHtml("#5539cc"); }
        }

        public static Color GreenBrown
        {
            get { return ColorTranslator.FromHtml("#544e03"); }
        }

        public static Color Bluegreen
        {
            get { return ColorTranslator.FromHtml("#017a79"); }
        }

        public static Color BrightTeal
        {
            get { return ColorTranslator.FromHtml("#01f9c6"); }
        }

        public static Color BrownishYellow
        {
            get { return ColorTranslator.FromHtml("#c9b003"); }
        }

        public static Color PeaSoup
        {
            get { return ColorTranslator.FromHtml("#929901"); }
        }

        public static Color Forest
        {
            get { return ColorTranslator.FromHtml("#0b5509"); }
        }

        public static Color BarneyPurple
        {
            get { return ColorTranslator.FromHtml("#a00498"); }
        }

        public static Color Ultramarine
        {
            get { return ColorTranslator.FromHtml("#2000b1"); }
        }

        public static Color Purplish
        {
            get { return ColorTranslator.FromHtml("#94568c"); }
        }

        public static Color PukeYellow
        {
            get { return ColorTranslator.FromHtml("#c2be0e"); }
        }

        public static Color BluishGrey
        {
            get { return ColorTranslator.FromHtml("#748b97"); }
        }

        public static Color DarkPeriwinkle
        {
            get { return ColorTranslator.FromHtml("#665fd1"); }
        }

        public static Color DarkLilac
        {
            get { return ColorTranslator.FromHtml("#9c6da5"); }
        }

        public static Color Reddish
        {
            get { return ColorTranslator.FromHtml("#c44240"); }
        }

        public static Color LightMaroon
        {
            get { return ColorTranslator.FromHtml("#a24857"); }
        }

        public static Color DustyPurple
        {
            get { return ColorTranslator.FromHtml("#825f87"); }
        }

        public static Color TerraCotta
        {
            get { return ColorTranslator.FromHtml("#c9643b"); }
        }

        public static Color Avocado
        {
            get { return ColorTranslator.FromHtml("#90b134"); }
        }

        public static Color MarineBlue
        {
            get { return ColorTranslator.FromHtml("#01386a"); }
        }

        public static Color TealGreen
        {
            get { return ColorTranslator.FromHtml("#25a36f"); }
        }

        public static Color SlateGrey
        {
            get { return ColorTranslator.FromHtml("#59656d"); }
        }

        public static Color LighterGreen
        {
            get { return ColorTranslator.FromHtml("#75fd63"); }
        }

        public static Color ElectricGreen
        {
            get { return ColorTranslator.FromHtml("#21fc0d"); }
        }

        public static Color DustyBlue
        {
            get { return ColorTranslator.FromHtml("#5a86ad"); }
        }

        public static Color GoldenYellow
        {
            get { return ColorTranslator.FromHtml("#fec615"); }
        }

        public static Color BrightYellow
        {
            get { return ColorTranslator.FromHtml("#fffd01"); }
        }

        public static Color LightLavender
        {
            get { return ColorTranslator.FromHtml("#dfc5fe"); }
        }

        public static Color Umber
        {
            get { return ColorTranslator.FromHtml("#b26400"); }
        }

        public static Color Poop
        {
            get { return ColorTranslator.FromHtml("#7f5e00"); }
        }

        public static Color DarkPeach
        {
            get { return ColorTranslator.FromHtml("#de7e5d"); }
        }

        public static Color JungleGreen
        {
            get { return ColorTranslator.FromHtml("#048243"); }
        }

        public static Color Eggshell
        {
            get { return ColorTranslator.FromHtml("#ffffd4"); }
        }

        public static Color Denim
        {
            get { return ColorTranslator.FromHtml("#3b638c"); }
        }

        public static Color YellowBrown
        {
            get { return ColorTranslator.FromHtml("#b79400"); }
        }

        public static Color DullPurple
        {
            get { return ColorTranslator.FromHtml("#84597e"); }
        }

        public static Color ChocolateBrown
        {
            get { return ColorTranslator.FromHtml("#411900"); }
        }

        public static Color WineRed
        {
            get { return ColorTranslator.FromHtml("#7b0323"); }
        }

        public static Color NeonBlue
        {
            get { return ColorTranslator.FromHtml("#04d9ff"); }
        }

        public static Color DirtyGreen
        {
            get { return ColorTranslator.FromHtml("#667e2c"); }
        }

        public static Color LightTan
        {
            get { return ColorTranslator.FromHtml("#fbeeac"); }
        }

        public static Color IceBlue
        {
            get { return ColorTranslator.FromHtml("#d7fffe"); }
        }

        public static Color CadetBlue
        {
            get { return ColorTranslator.FromHtml("#4e7496"); }
        }

        public static Color DarkMauve
        {
            get { return ColorTranslator.FromHtml("#874c62"); }
        }

        public static Color VeryLightBlue
        {
            get { return ColorTranslator.FromHtml("#d5ffff"); }
        }

        public static Color GreyPurple
        {
            get { return ColorTranslator.FromHtml("#826d8c"); }
        }

        public static Color PastelPink
        {
            get { return ColorTranslator.FromHtml("#ffbacd"); }
        }

        public static Color VeryLightGreen
        {
            get { return ColorTranslator.FromHtml("#d1ffbd"); }
        }

        public static Color DarkSkyBlue
        {
            get { return ColorTranslator.FromHtml("#448ee4"); }
        }

        public static Color Evergreen
        {
            get { return ColorTranslator.FromHtml("#05472a"); }
        }

        public static Color DullPink
        {
            get { return ColorTranslator.FromHtml("#d5869d"); }
        }

        public static Color Aubergine
        {
            get { return ColorTranslator.FromHtml("#3d0734"); }
        }

        public static Color Mahogany
        {
            get { return ColorTranslator.FromHtml("#4a0100"); }
        }

        public static Color ReddishOrange
        {
            get { return ColorTranslator.FromHtml("#f8481c"); }
        }

        public static Color DeepGreen
        {
            get { return ColorTranslator.FromHtml("#02590f"); }
        }

        public static Color VomitGreen
        {
            get { return ColorTranslator.FromHtml("#89a203"); }
        }

        public static Color PurplePink
        {
            get { return ColorTranslator.FromHtml("#e03fd8"); }
        }

        public static Color DustyPink
        {
            get { return ColorTranslator.FromHtml("#d58a94"); }
        }

        public static Color FadedGreen
        {
            get { return ColorTranslator.FromHtml("#7bb274"); }
        }

        public static Color CamoGreen
        {
            get { return ColorTranslator.FromHtml("#526525"); }
        }

        public static Color PinkyPurple
        {
            get { return ColorTranslator.FromHtml("#c94cbe"); }
        }

        public static Color PinkPurple
        {
            get { return ColorTranslator.FromHtml("#db4bda"); }
        }

        public static Color BrownishRed
        {
            get { return ColorTranslator.FromHtml("#9e3623"); }
        }

        public static Color DarkRose
        {
            get { return ColorTranslator.FromHtml("#b5485d"); }
        }

        public static Color Mud
        {
            get { return ColorTranslator.FromHtml("#735c12"); }
        }

        public static Color Brownish
        {
            get { return ColorTranslator.FromHtml("#9c6d57"); }
        }

        public static Color EmeraldGreen
        {
            get { return ColorTranslator.FromHtml("#028f1e"); }
        }

        public static Color PaleBrown
        {
            get { return ColorTranslator.FromHtml("#b1916e"); }
        }

        public static Color DullBlue
        {
            get { return ColorTranslator.FromHtml("#49759c"); }
        }

        public static Color BurntUmber
        {
            get { return ColorTranslator.FromHtml("#a0450e"); }
        }

        public static Color MediumGreen
        {
            get { return ColorTranslator.FromHtml("#39ad48"); }
        }

        public static Color Clay
        {
            get { return ColorTranslator.FromHtml("#b66a50"); }
        }

        public static Color LightAqua
        {
            get { return ColorTranslator.FromHtml("#8cffdb"); }
        }

        public static Color LightOliveGreen
        {
            get { return ColorTranslator.FromHtml("#a4be5c"); }
        }

        public static Color BrownishOrange
        {
            get { return ColorTranslator.FromHtml("#cb7723"); }
        }

        public static Color DarkAqua
        {
            get { return ColorTranslator.FromHtml("#05696b"); }
        }

        public static Color PurplishPink
        {
            get { return ColorTranslator.FromHtml("#ce5dae"); }
        }

        public static Color DarkSalmon
        {
            get { return ColorTranslator.FromHtml("#c85a53"); }
        }

        public static Color GreenishGrey
        {
            get { return ColorTranslator.FromHtml("#96ae8d"); }
        }

        public static Color Jade
        {
            get { return ColorTranslator.FromHtml("#1fa774"); }
        }

        public static Color UglyGreen
        {
            get { return ColorTranslator.FromHtml("#7a9703"); }
        }

        public static Color DarkBeige
        {
            get { return ColorTranslator.FromHtml("#ac9362"); }
        }

        public static Color Emerald
        {
            get { return ColorTranslator.FromHtml("#01a049"); }
        }

        public static Color PaleRed
        {
            get { return ColorTranslator.FromHtml("#d9544d"); }
        }

        public static Color LightMagenta
        {
            get { return ColorTranslator.FromHtml("#fa5ff7"); }
        }

        public static Color Sky
        {
            get { return ColorTranslator.FromHtml("#82cafc"); }
        }

        public static Color LightCyan
        {
            get { return ColorTranslator.FromHtml("#acfffc"); }
        }

        public static Color YellowOrange
        {
            get { return ColorTranslator.FromHtml("#fcb001"); }
        }

        public static Color ReddishPurple
        {
            get { return ColorTranslator.FromHtml("#910951"); }
        }

        public static Color ReddishPink
        {
            get { return ColorTranslator.FromHtml("#fe2c54"); }
        }

        public static Color Orchid
        {
            get { return ColorTranslator.FromHtml("#c875c4"); }
        }

        public static Color DirtyYellow
        {
            get { return ColorTranslator.FromHtml("#cdc50a"); }
        }

        public static Color OrangeRed
        {
            get { return ColorTranslator.FromHtml("#fd411e"); }
        }

        public static Color DeepRed
        {
            get { return ColorTranslator.FromHtml("#9a0200"); }
        }

        public static Color OrangeBrown
        {
            get { return ColorTranslator.FromHtml("#be6400"); }
        }

        public static Color CobaltBlue
        {
            get { return ColorTranslator.FromHtml("#030aa7"); }
        }

        public static Color NeonPink
        {
            get { return ColorTranslator.FromHtml("#fe019a"); }
        }

        public static Color RosePink
        {
            get { return ColorTranslator.FromHtml("#f7879a"); }
        }

        public static Color GreyishPurple
        {
            get { return ColorTranslator.FromHtml("#887191"); }
        }

        public static Color Raspberry
        {
            get { return ColorTranslator.FromHtml("#b00149"); }
        }

        public static Color AquaGreen
        {
            get { return ColorTranslator.FromHtml("#12e193"); }
        }

        public static Color SalmonPink
        {
            get { return ColorTranslator.FromHtml("#fe7b7c"); }
        }

        public static Color Tangerine
        {
            get { return ColorTranslator.FromHtml("#ff9408"); }
        }

        public static Color BrownishGreen
        {
            get { return ColorTranslator.FromHtml("#6a6e09"); }
        }

        public static Color RedBrown
        {
            get { return ColorTranslator.FromHtml("#8b2e16"); }
        }

        public static Color GreenishBrown
        {
            get { return ColorTranslator.FromHtml("#696112"); }
        }

        public static Color Pumpkin
        {
            get { return ColorTranslator.FromHtml("#e17701"); }
        }

        public static Color PineGreen
        {
            get { return ColorTranslator.FromHtml("#0a481e"); }
        }

        public static Color Charcoal
        {
            get { return ColorTranslator.FromHtml("#343837"); }
        }

        public static Color BabyPink
        {
            get { return ColorTranslator.FromHtml("#ffb7ce"); }
        }

        public static Color Cornflower
        {
            get { return ColorTranslator.FromHtml("#6a79f7"); }
        }

        public static Color BlueViolet
        {
            get { return ColorTranslator.FromHtml("#5d06e9"); }
        }

        public static Color Chocolate
        {
            get { return ColorTranslator.FromHtml("#3d1c02"); }
        }

        public static Color GreyishGreen
        {
            get { return ColorTranslator.FromHtml("#82a67d"); }
        }

        public static Color Scarlet
        {
            get { return ColorTranslator.FromHtml("#be0119"); }
        }

        public static Color GreenYellow
        {
            get { return ColorTranslator.FromHtml("#c9ff27"); }
        }

        public static Color DarkOlive
        {
            get { return ColorTranslator.FromHtml("#373e02"); }
        }

        public static Color Sienna
        {
            get { return ColorTranslator.FromHtml("#a9561e"); }
        }

        public static Color PastelPurple
        {
            get { return ColorTranslator.FromHtml("#caa0ff"); }
        }

        public static Color Terracotta
        {
            get { return ColorTranslator.FromHtml("#ca6641"); }
        }

        public static Color AquaBlue
        {
            get { return ColorTranslator.FromHtml("#02d8e9"); }
        }

        public static Color SageGreen
        {
            get { return ColorTranslator.FromHtml("#88b378"); }
        }

        public static Color BloodRed
        {
            get { return ColorTranslator.FromHtml("#980002"); }
        }

        public static Color DeepPink
        {
            get { return ColorTranslator.FromHtml("#cb0162"); }
        }

        public static Color Grass
        {
            get { return ColorTranslator.FromHtml("#5cac2d"); }
        }

        public static Color Moss
        {
            get { return ColorTranslator.FromHtml("#769958"); }
        }

        public static Color PastelBlue
        {
            get { return ColorTranslator.FromHtml("#a2bffe"); }
        }

        public static Color BluishGreen
        {
            get { return ColorTranslator.FromHtml("#10a674"); }
        }

        public static Color GreenBlue
        {
            get { return ColorTranslator.FromHtml("#06b48b"); }
        }

        public static Color DarkTan
        {
            get { return ColorTranslator.FromHtml("#af884a"); }
        }

        public static Color GreenishBlue
        {
            get { return ColorTranslator.FromHtml("#0b8b87"); }
        }

        public static Color PaleOrange
        {
            get { return ColorTranslator.FromHtml("#ffa756"); }
        }

        public static Color Vomit
        {
            get { return ColorTranslator.FromHtml("#a2a415"); }
        }

        public static Color ForrestGreen
        {
            get { return ColorTranslator.FromHtml("#154406"); }
        }

        public static Color DarkLavender
        {
            get { return ColorTranslator.FromHtml("#856798"); }
        }

        public static Color DarkViolet
        {
            get { return ColorTranslator.FromHtml("#34013f"); }
        }

        public static Color PurpleBlue
        {
            get { return ColorTranslator.FromHtml("#632de9"); }
        }

        public static Color DarkCyan
        {
            get { return ColorTranslator.FromHtml("#0a888a"); }
        }

        public static Color OliveDrab
        {
            get { return ColorTranslator.FromHtml("#6f7632"); }
        }

        public static Color Pinkish
        {
            get { return ColorTranslator.FromHtml("#d46a7e"); }
        }

        public static Color Cobalt
        {
            get { return ColorTranslator.FromHtml("#1e488f"); }
        }

        public static Color NeonPurple
        {
            get { return ColorTranslator.FromHtml("#bc13fe"); }
        }

        public static Color LightTurquoise
        {
            get { return ColorTranslator.FromHtml("#7ef4cc"); }
        }

        public static Color AppleGreen
        {
            get { return ColorTranslator.FromHtml("#76cd26"); }
        }

        public static Color DullGreen
        {
            get { return ColorTranslator.FromHtml("#74a662"); }
        }

        public static Color Wine
        {
            get { return ColorTranslator.FromHtml("#80013f"); }
        }

        public static Color PowderBlue
        {
            get { return ColorTranslator.FromHtml("#b1d1fc"); }
        }

        public static Color OffWhite
        {
            get { return ColorTranslator.FromHtml("#ffffe4"); }
        }

        public static Color ElectricBlue
        {
            get { return ColorTranslator.FromHtml("#0652ff"); }
        }

        public static Color DarkTurquoise
        {
            get { return ColorTranslator.FromHtml("#045c5a"); }
        }

        public static Color BluePurple
        {
            get { return ColorTranslator.FromHtml("#5729ce"); }
        }

        public static Color Azure
        {
            get { return ColorTranslator.FromHtml("#069af3"); }
        }

        public static Color BrightRed
        {
            get { return ColorTranslator.FromHtml("#ff000d"); }
        }

        public static Color PinkishRed
        {
            get { return ColorTranslator.FromHtml("#f10c45"); }
        }

        public static Color CornflowerBlue
        {
            get { return ColorTranslator.FromHtml("#5170d7"); }
        }

        public static Color LightOlive
        {
            get { return ColorTranslator.FromHtml("#acbf69"); }
        }

        public static Color Grape
        {
            get { return ColorTranslator.FromHtml("#6c3461"); }
        }

        public static Color GreyishBlue
        {
            get { return ColorTranslator.FromHtml("#5e819d"); }
        }

        public static Color PurplishBlue
        {
            get { return ColorTranslator.FromHtml("#601ef9"); }
        }

        public static Color YellowishGreen
        {
            get { return ColorTranslator.FromHtml("#b0dd16"); }
        }

        public static Color GreenishYellow
        {
            get { return ColorTranslator.FromHtml("#cdfd02"); }
        }

        public static Color MediumBlue
        {
            get { return ColorTranslator.FromHtml("#2c6fbb"); }
        }

        public static Color DustyRose
        {
            get { return ColorTranslator.FromHtml("#c0737a"); }
        }

        public static Color LightViolet
        {
            get { return ColorTranslator.FromHtml("#d6b4fc"); }
        }

        public static Color MidnightBlue
        {
            get { return ColorTranslator.FromHtml("#020035"); }
        }

        public static Color BluishPurple
        {
            get { return ColorTranslator.FromHtml("#703be7"); }
        }

        public static Color RedOrange
        {
            get { return ColorTranslator.FromHtml("#fd3c06"); }
        }

        public static Color DarkMagenta
        {
            get { return ColorTranslator.FromHtml("#960056"); }
        }

        public static Color Greenish
        {
            get { return ColorTranslator.FromHtml("#40a368"); }
        }

        public static Color OceanBlue
        {
            get { return ColorTranslator.FromHtml("#03719c"); }
        }

        public static Color Coral
        {
            get { return ColorTranslator.FromHtml("#fc5a50"); }
        }

        public static Color Cream
        {
            get { return ColorTranslator.FromHtml("#ffffc2"); }
        }

        public static Color ReddishBrown
        {
            get { return ColorTranslator.FromHtml("#7f2b0a"); }
        }

        public static Color BurntSienna
        {
            get { return ColorTranslator.FromHtml("#b04e0f"); }
        }

        public static Color Brick
        {
            get { return ColorTranslator.FromHtml("#a03623"); }
        }

        public static Color Sage
        {
            get { return ColorTranslator.FromHtml("#87ae73"); }
        }

        public static Color GreyGreen
        {
            get { return ColorTranslator.FromHtml("#789b73"); }
        }

        public static Color White
        {
            get { return ColorTranslator.FromHtml("#ffffff"); }
        }

        public static Color RobinSEggBlue
        {
            get { return ColorTranslator.FromHtml("#98eff9"); }
        }

        public static Color MossGreen
        {
            get { return ColorTranslator.FromHtml("#658b38"); }
        }

        public static Color SteelBlue
        {
            get { return ColorTranslator.FromHtml("#5a7d9a"); }
        }

        public static Color Eggplant
        {
            get { return ColorTranslator.FromHtml("#380835"); }
        }

        public static Color LightYellow
        {
            get { return ColorTranslator.FromHtml("#fffe7a"); }
        }

        public static Color LeafGreen
        {
            get { return ColorTranslator.FromHtml("#5ca904"); }
        }

        public static Color LightGrey
        {
            get { return ColorTranslator.FromHtml("#d8dcd6"); }
        }

        public static Color Puke
        {
            get { return ColorTranslator.FromHtml("#a5a502"); }
        }

        public static Color PinkishPurple
        {
            get { return ColorTranslator.FromHtml("#d648d7"); }
        }

        public static Color SeaBlue
        {
            get { return ColorTranslator.FromHtml("#047495"); }
        }

        public static Color PalePurple
        {
            get { return ColorTranslator.FromHtml("#b790d4"); }
        }

        public static Color SlateBlue
        {
            get { return ColorTranslator.FromHtml("#5b7c99"); }
        }

        public static Color BlueGrey
        {
            get { return ColorTranslator.FromHtml("#607c8e"); }
        }

        public static Color HunterGreen
        {
            get { return ColorTranslator.FromHtml("#0b4008"); }
        }

        public static Color Fuchsia
        {
            get { return ColorTranslator.FromHtml("#ed0dd9"); }
        }

        public static Color Crimson
        {
            get { return ColorTranslator.FromHtml("#8c000f"); }
        }

        public static Color PaleYellow
        {
            get { return ColorTranslator.FromHtml("#ffff84"); }
        }

        public static Color Ochre
        {
            get { return ColorTranslator.FromHtml("#bf9005"); }
        }

        public static Color MustardYellow
        {
            get { return ColorTranslator.FromHtml("#d2bd0a"); }
        }

        public static Color LightRed
        {
            get { return ColorTranslator.FromHtml("#ff474c"); }
        }

        public static Color Cerulean
        {
            get { return ColorTranslator.FromHtml("#0485d1"); }
        }

        public static Color PalePink
        {
            get { return ColorTranslator.FromHtml("#ffcfdc"); }
        }

        public static Color DeepBlue
        {
            get { return ColorTranslator.FromHtml("#040273"); }
        }

        public static Color Rust
        {
            get { return ColorTranslator.FromHtml("#a83c09"); }
        }

        public static Color LightTeal
        {
            get { return ColorTranslator.FromHtml("#90e4c1"); }
        }

        public static Color Slate
        {
            get { return ColorTranslator.FromHtml("#516572"); }
        }

        public static Color Goldenrod
        {
            get { return ColorTranslator.FromHtml("#fac205"); }
        }

        public static Color DarkYellow
        {
            get { return ColorTranslator.FromHtml("#d5b60a"); }
        }

        public static Color DarkGrey
        {
            get { return ColorTranslator.FromHtml("#363737"); }
        }

        public static Color ArmyGreen
        {
            get { return ColorTranslator.FromHtml("#4b5d16"); }
        }

        public static Color GreyBlue
        {
            get { return ColorTranslator.FromHtml("#6b8ba4"); }
        }

        public static Color Seafoam
        {
            get { return ColorTranslator.FromHtml("#80f9ad"); }
        }

        public static Color Puce
        {
            get { return ColorTranslator.FromHtml("#a57e52"); }
        }

        public static Color SpringGreen
        {
            get { return ColorTranslator.FromHtml("#a9f971"); }
        }

        public static Color DarkOrange
        {
            get { return ColorTranslator.FromHtml("#c65102"); }
        }

        public static Color Sand
        {
            get { return ColorTranslator.FromHtml("#e2ca76"); }
        }

        public static Color PastelGreen
        {
            get { return ColorTranslator.FromHtml("#b0ff9d"); }
        }

        public static Color Mint
        {
            get { return ColorTranslator.FromHtml("#9ffeb0"); }
        }

        public static Color LightOrange
        {
            get { return ColorTranslator.FromHtml("#fdaa48"); }
        }

        public static Color BrightPink
        {
            get { return ColorTranslator.FromHtml("#fe01b1"); }
        }

        public static Color Chartreuse
        {
            get { return ColorTranslator.FromHtml("#c1f80a"); }
        }

        public static Color DeepPurple
        {
            get { return ColorTranslator.FromHtml("#36013f"); }
        }

        public static Color DarkBrown
        {
            get { return ColorTranslator.FromHtml("#341c02"); }
        }

        public static Color Taupe
        {
            get { return ColorTranslator.FromHtml("#b9a281"); }
        }

        public static Color PeaGreen
        {
            get { return ColorTranslator.FromHtml("#8eab12"); }
        }

        public static Color PukeGreen
        {
            get { return ColorTranslator.FromHtml("#9aae07"); }
        }

        public static Color KellyGreen
        {
            get { return ColorTranslator.FromHtml("#02ab2e"); }
        }

        public static Color SeafoamGreen
        {
            get { return ColorTranslator.FromHtml("#7af9ab"); }
        }

        public static Color BlueGreen
        {
            get { return ColorTranslator.FromHtml("#137e6d"); }
        }

        public static Color Khaki
        {
            get { return ColorTranslator.FromHtml("#aaa662"); }
        }

        public static Color Burgundy
        {
            get { return ColorTranslator.FromHtml("#610023"); }
        }

        public static Color DarkTeal
        {
            get { return ColorTranslator.FromHtml("#014d4e"); }
        }

        public static Color BrickRed
        {
            get { return ColorTranslator.FromHtml("#8f1402"); }
        }

        public static Color RoyalPurple
        {
            get { return ColorTranslator.FromHtml("#4b006e"); }
        }

        public static Color Plum
        {
            get { return ColorTranslator.FromHtml("#580f41"); }
        }

        public static Color MintGreen
        {
            get { return ColorTranslator.FromHtml("#8fff9f"); }
        }

        public static Color Gold
        {
            get { return ColorTranslator.FromHtml("#dbb40c"); }
        }

        public static Color BabyBlue
        {
            get { return ColorTranslator.FromHtml("#a2cffe"); }
        }

        public static Color YellowGreen
        {
            get { return ColorTranslator.FromHtml("#c0fb2d"); }
        }

        public static Color BrightPurple
        {
            get { return ColorTranslator.FromHtml("#be03fd"); }
        }

        public static Color DarkRed
        {
            get { return ColorTranslator.FromHtml("#840000"); }
        }

        public static Color PaleBlue
        {
            get { return ColorTranslator.FromHtml("#d0fefe"); }
        }

        public static Color GrassGreen
        {
            get { return ColorTranslator.FromHtml("#3f9b0b"); }
        }

        public static Color Navy
        {
            get { return ColorTranslator.FromHtml("#01153e"); }
        }

        public static Color Aquamarine
        {
            get { return ColorTranslator.FromHtml("#04d8b2"); }
        }

        public static Color BurntOrange
        {
            get { return ColorTranslator.FromHtml("#c04e01"); }
        }

        public static Color NeonGreen
        {
            get { return ColorTranslator.FromHtml("#0cff0c"); }
        }

        public static Color BrightBlue
        {
            get { return ColorTranslator.FromHtml("#0165fc"); }
        }

        public static Color Rose
        {
            get { return ColorTranslator.FromHtml("#cf6275"); }
        }

        public static Color LightPink
        {
            get { return ColorTranslator.FromHtml("#ffd1df"); }
        }

        public static Color Mustard
        {
            get { return ColorTranslator.FromHtml("#ceb301"); }
        }

        public static Color Indigo
        {
            get { return ColorTranslator.FromHtml("#380282"); }
        }

        public static Color Lime
        {
            get { return ColorTranslator.FromHtml("#aaff32"); }
        }

        public static Color SeaGreen
        {
            get { return ColorTranslator.FromHtml("#53fca1"); }
        }

        public static Color Periwinkle
        {
            get { return ColorTranslator.FromHtml("#8e82fe"); }
        }

        public static Color DarkPink
        {
            get { return ColorTranslator.FromHtml("#cb416b"); }
        }

        public static Color OliveGreen
        {
            get { return ColorTranslator.FromHtml("#677a04"); }
        }

        public static Color Peach
        {
            get { return ColorTranslator.FromHtml("#ffb07c"); }
        }

        public static Color PaleGreen
        {
            get { return ColorTranslator.FromHtml("#c7fdb5"); }
        }

        public static Color LightBrown
        {
            get { return ColorTranslator.FromHtml("#ad8150"); }
        }

        public static Color HotPink
        {
            get { return ColorTranslator.FromHtml("#ff028d"); }
        }

        public static Color Black
        {
            get { return ColorTranslator.FromHtml("#000000"); }
        }

        public static Color Lilac
        {
            get { return ColorTranslator.FromHtml("#cea2fd"); }
        }

        public static Color NavyBlue
        {
            get { return ColorTranslator.FromHtml("#001146"); }
        }

        public static Color RoyalBlue
        {
            get { return ColorTranslator.FromHtml("#0504aa"); }
        }

        public static Color Beige
        {
            get { return ColorTranslator.FromHtml("#e6daa6"); }
        }

        public static Color Salmon
        {
            get { return ColorTranslator.FromHtml("#ff796c"); }
        }

        public static Color Olive
        {
            get { return ColorTranslator.FromHtml("#6e750e"); }
        }

        public static Color Maroon
        {
            get { return ColorTranslator.FromHtml("#650021"); }
        }

        public static Color BrightGreen
        {
            get { return ColorTranslator.FromHtml("#01ff07"); }
        }

        public static Color DarkPurple
        {
            get { return ColorTranslator.FromHtml("#35063e"); }
        }

        public static Color Mauve
        {
            get { return ColorTranslator.FromHtml("#ae7181"); }
        }

        public static Color ForestGreen
        {
            get { return ColorTranslator.FromHtml("#06470c"); }
        }

        public static Color Aqua
        {
            get { return ColorTranslator.FromHtml("#13eac9"); }
        }

        public static Color Cyan
        {
            get { return ColorTranslator.FromHtml("#00ffff"); }
        }

        public static Color Tan
        {
            get { return ColorTranslator.FromHtml("#d1b26f"); }
        }

        public static Color DarkBlue
        {
            get { return ColorTranslator.FromHtml("#00035b"); }
        }

        public static Color Lavender
        {
            get { return ColorTranslator.FromHtml("#c79fef"); }
        }

        public static Color Turquoise
        {
            get { return ColorTranslator.FromHtml("#06c2ac"); }
        }

        public static Color DarkGreen
        {
            get { return ColorTranslator.FromHtml("#033500"); }
        }

        public static Color Violet
        {
            get { return ColorTranslator.FromHtml("#9a0eea"); }
        }

        public static Color LightPurple
        {
            get { return ColorTranslator.FromHtml("#bf77f6"); }
        }

        public static Color LimeGreen
        {
            get { return ColorTranslator.FromHtml("#89fe05"); }
        }

        public static Color Grey
        {
            get { return ColorTranslator.FromHtml("#929591"); }
        }

        public static Color SkyBlue
        {
            get { return ColorTranslator.FromHtml("#75bbfd"); }
        }

        public static Color Yellow
        {
            get { return ColorTranslator.FromHtml("#ffff14"); }
        }

        public static Color Magenta
        {
            get { return ColorTranslator.FromHtml("#c20078"); }
        }

        public static Color LightGreen
        {
            get { return ColorTranslator.FromHtml("#96f97b"); }
        }

        public static Color Orange
        {
            get { return ColorTranslator.FromHtml("#f97306"); }
        }

        public static Color Teal
        {
            get { return ColorTranslator.FromHtml("#029386"); }
        }

        public static Color LightBlue
        {
            get { return ColorTranslator.FromHtml("#95d0fc"); }
        }

        public static Color Red
        {
            get { return ColorTranslator.FromHtml("#e50000"); }
        }

        public static Color Brown
        {
            get { return ColorTranslator.FromHtml("#653700"); }
        }

        public static Color Pink
        {
            get { return ColorTranslator.FromHtml("#ff81c0"); }
        }

        public static Color Blue
        {
            get { return ColorTranslator.FromHtml("#0343df"); }
        }

        public static Color Green
        {
            get { return ColorTranslator.FromHtml("#15b01a"); }
        }

        public static Color Purple
        {
            get { return ColorTranslator.FromHtml("#7e1e9c"); }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Drawing;

namespace curtains
{
    sealed class XkcdColour
    {
        private XkcdColour(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }

        public string Value { get; private set; }

        private Color _colour;
        private Color Colour
        {
            get
            {
                if (_colour == Color.Empty)
                {
                    _colour = ColorTranslator.FromHtml(Value);
                }
                return _colour;
            }
        }

        public int Proximity(string value)
        {
            var other = new XkcdColour("user input", value);
            return Proximity(other);
        }

        private int Proximity(XkcdColour other)
        {
            var redDiff = Math.Abs(this.Colour.R - other.Colour.R);
            var greenDiff = Math.Abs(this.Colour.G - other.Colour.G);
            var blueDiff = Math.Abs(this.Colour.B - other.Colour.B);
            return redDiff + greenDiff + blueDiff;
        }

        #region static colours

        public static readonly XkcdColour AcidGreen = new XkcdColour("acid green", "#8ffe09");

        public static readonly XkcdColour Adobe = new XkcdColour("adobe", "#bd6c48");

        public static readonly XkcdColour Algae = new XkcdColour("algae", "#54ac68");

        public static readonly XkcdColour AlgaeGreen = new XkcdColour("algae green", "#21c36f");

        public static readonly XkcdColour AlmostBlack = new XkcdColour("almost black", "#070d0d");

        public static readonly XkcdColour Amber = new XkcdColour("amber", "#feb308");

        public static readonly XkcdColour Amethyst = new XkcdColour("amethyst", "#9b5fc0");

        public static readonly XkcdColour Apple = new XkcdColour("apple", "#6ecb3c");

        public static readonly XkcdColour AppleGreen = new XkcdColour("apple green", "#76cd26");

        public static readonly XkcdColour Apricot = new XkcdColour("apricot", "#ffb16d");

        public static readonly XkcdColour Aqua = new XkcdColour("aqua", "#13eac9");

        public static readonly XkcdColour AquaBlue = new XkcdColour("aqua blue", "#02d8e9");

        public static readonly XkcdColour AquaGreen = new XkcdColour("aqua green", "#12e193");

        public static readonly XkcdColour AquaMarine = new XkcdColour("aqua marine", "#2ee8bb");

        public static readonly XkcdColour Aquamarine = new XkcdColour("aquamarine", "#04d8b2");

        public static readonly XkcdColour ArmyGreen = new XkcdColour("army green", "#4b5d16");

        public static readonly XkcdColour Asparagus = new XkcdColour("asparagus", "#77ab56");

        public static readonly XkcdColour Aubergine = new XkcdColour("aubergine", "#3d0734");

        public static readonly XkcdColour Auburn = new XkcdColour("auburn", "#9a3001");

        public static readonly XkcdColour Avocado = new XkcdColour("avocado", "#90b134");

        public static readonly XkcdColour AvocadoGreen = new XkcdColour("avocado green", "#87a922");

        public static readonly XkcdColour Azul = new XkcdColour("azul", "#1d5dec");

        public static readonly XkcdColour Azure = new XkcdColour("azure", "#069af3");

        public static readonly XkcdColour BabyBlue = new XkcdColour("baby blue", "#a2cffe");

        public static readonly XkcdColour BabyGreen = new XkcdColour("baby green", "#8cff9e");

        public static readonly XkcdColour BabyPink = new XkcdColour("baby pink", "#ffb7ce");

        public static readonly XkcdColour BabyPoo = new XkcdColour("baby poo", "#ab9004");

        public static readonly XkcdColour BabyPoop = new XkcdColour("baby poop", "#937c00");

        public static readonly XkcdColour BabyPoopGreen = new XkcdColour("baby poop green", "#8f9805");

        public static readonly XkcdColour BabyPukeGreen = new XkcdColour("baby puke green", "#b6c406");

        public static readonly XkcdColour BabyPurple = new XkcdColour("baby purple", "#ca9bf7");

        public static readonly XkcdColour BabyShitBrown = new XkcdColour("baby shit brown", "#ad900d");

        public static readonly XkcdColour BabyShitGreen = new XkcdColour("baby shit green", "#889717");

        public static readonly XkcdColour Banana = new XkcdColour("banana", "#ffff7e");

        public static readonly XkcdColour BananaYellow = new XkcdColour("banana yellow", "#fafe4b");

        public static readonly XkcdColour BarbiePink = new XkcdColour("barbie pink", "#fe46a5");

        public static readonly XkcdColour BarfGreen = new XkcdColour("barf green", "#94ac02");

        public static readonly XkcdColour Barney = new XkcdColour("barney", "#ac1db8");

        public static readonly XkcdColour BarneyPurple = new XkcdColour("barney purple", "#a00498");

        public static readonly XkcdColour BattleshipGrey = new XkcdColour("battleship grey", "#6b7c85");

        public static readonly XkcdColour Beige = new XkcdColour("beige", "#e6daa6");

        public static readonly XkcdColour Berry = new XkcdColour("berry", "#990f4b");

        public static readonly XkcdColour Bile = new XkcdColour("bile", "#b5c306");

        public static readonly XkcdColour Black = new XkcdColour("black", "#000000");

        public static readonly XkcdColour Bland = new XkcdColour("bland", "#afa88b");

        public static readonly XkcdColour Blood = new XkcdColour("blood", "#770001");

        public static readonly XkcdColour BloodOrange = new XkcdColour("blood orange", "#fe4b03");

        public static readonly XkcdColour BloodRed = new XkcdColour("blood red", "#980002");

        public static readonly XkcdColour Blue = new XkcdColour("blue", "#0343df");

        public static readonly XkcdColour BlueBlue = new XkcdColour("blue blue", "#2242c7");

        public static readonly XkcdColour BlueGreen = new XkcdColour("blue green", "#137e6d");

        public static readonly XkcdColour BlueGrey = new XkcdColour("blue grey", "#607c8e");

        public static readonly XkcdColour BluePurple = new XkcdColour("blue purple", "#5729ce");

        public static readonly XkcdColour BlueViolet = new XkcdColour("blue violet", "#5d06e9");

        public static readonly XkcdColour BlueWithAHintOfPurple = new XkcdColour("blue with a hint of purple", "#533cc6");

        public static readonly XkcdColour BlueSlashGreen = new XkcdColour("blue/green", "#0f9b8e");

        public static readonly XkcdColour BlueSlashGrey = new XkcdColour("blue/grey", "#758da3");

        public static readonly XkcdColour BlueSlashPurple = new XkcdColour("blue/purple", "#5a06ef");

        public static readonly XkcdColour Blueberry = new XkcdColour("blueberry", "#464196");

        public static readonly XkcdColour Bluegreen = new XkcdColour("bluegreen", "#017a79");

        public static readonly XkcdColour Bluegrey = new XkcdColour("bluegrey", "#85a3b2");

        public static readonly XkcdColour BlueyGreen = new XkcdColour("bluey green", "#2bb179");

        public static readonly XkcdColour BlueyGrey = new XkcdColour("bluey grey", "#89a0b0");

        public static readonly XkcdColour BlueyPurple = new XkcdColour("bluey purple", "#6241c7");

        public static readonly XkcdColour Bluish = new XkcdColour("bluish", "#2976bb");

        public static readonly XkcdColour BluishGreen = new XkcdColour("bluish green", "#10a674");

        public static readonly XkcdColour BluishGrey = new XkcdColour("bluish grey", "#748b97");

        public static readonly XkcdColour BluishPurple = new XkcdColour("bluish purple", "#703be7");

        public static readonly XkcdColour Blurple = new XkcdColour("blurple", "#5539cc");

        public static readonly XkcdColour Blush = new XkcdColour("blush", "#f29e8e");

        public static readonly XkcdColour BlushPink = new XkcdColour("blush pink", "#fe828c");

        public static readonly XkcdColour Booger = new XkcdColour("booger", "#9bb53c");

        public static readonly XkcdColour BoogerGreen = new XkcdColour("booger green", "#96b403");

        public static readonly XkcdColour Bordeaux = new XkcdColour("bordeaux", "#7b002c");

        public static readonly XkcdColour BoringGreen = new XkcdColour("boring green", "#63b365");

        public static readonly XkcdColour BottleGreen = new XkcdColour("bottle green", "#044a05");

        public static readonly XkcdColour Brick = new XkcdColour("brick", "#a03623");

        public static readonly XkcdColour BrickOrange = new XkcdColour("brick orange", "#c14a09");

        public static readonly XkcdColour BrickRed = new XkcdColour("brick red", "#8f1402");

        public static readonly XkcdColour BrightAqua = new XkcdColour("bright aqua", "#0bf9ea");

        public static readonly XkcdColour BrightBlue = new XkcdColour("bright blue", "#0165fc");

        public static readonly XkcdColour BrightCyan = new XkcdColour("bright cyan", "#41fdfe");

        public static readonly XkcdColour BrightGreen = new XkcdColour("bright green", "#01ff07");

        public static readonly XkcdColour BrightLavender = new XkcdColour("bright lavender", "#c760ff");

        public static readonly XkcdColour BrightLightBlue = new XkcdColour("bright light blue", "#26f7fd");

        public static readonly XkcdColour BrightLightGreen = new XkcdColour("bright light green", "#2dfe54");

        public static readonly XkcdColour BrightLilac = new XkcdColour("bright lilac", "#c95efb");

        public static readonly XkcdColour BrightLime = new XkcdColour("bright lime", "#87fd05");

        public static readonly XkcdColour BrightLimeGreen = new XkcdColour("bright lime green", "#65fe08");

        public static readonly XkcdColour BrightMagenta = new XkcdColour("bright magenta", "#ff08e8");

        public static readonly XkcdColour BrightOlive = new XkcdColour("bright olive", "#9cbb04");

        public static readonly XkcdColour BrightOrange = new XkcdColour("bright orange", "#ff5b00");

        public static readonly XkcdColour BrightPink = new XkcdColour("bright pink", "#fe01b1");

        public static readonly XkcdColour BrightPurple = new XkcdColour("bright purple", "#be03fd");

        public static readonly XkcdColour BrightRed = new XkcdColour("bright red", "#ff000d");

        public static readonly XkcdColour BrightSeaGreen = new XkcdColour("bright sea green", "#05ffa6");

        public static readonly XkcdColour BrightSkyBlue = new XkcdColour("bright sky blue", "#02ccfe");

        public static readonly XkcdColour BrightTeal = new XkcdColour("bright teal", "#01f9c6");

        public static readonly XkcdColour BrightTurquoise = new XkcdColour("bright turquoise", "#0ffef9");

        public static readonly XkcdColour BrightViolet = new XkcdColour("bright violet", "#ad0afd");

        public static readonly XkcdColour BrightYellow = new XkcdColour("bright yellow", "#fffd01");

        public static readonly XkcdColour BrightYellowGreen = new XkcdColour("bright yellow green", "#9dff00");

        public static readonly XkcdColour BritishRacingGreen = new XkcdColour("british racing green", "#05480d");

        public static readonly XkcdColour Bronze = new XkcdColour("bronze", "#a87900");

        public static readonly XkcdColour Brown = new XkcdColour("brown", "#653700");

        public static readonly XkcdColour BrownGreen = new XkcdColour("brown green", "#706c11");

        public static readonly XkcdColour BrownGrey = new XkcdColour("brown grey", "#8d8468");

        public static readonly XkcdColour BrownOrange = new XkcdColour("brown orange", "#b96902");

        public static readonly XkcdColour BrownRed = new XkcdColour("brown red", "#922b05");

        public static readonly XkcdColour BrownYellow = new XkcdColour("brown yellow", "#b29705");

        public static readonly XkcdColour Brownish = new XkcdColour("brownish", "#9c6d57");

        public static readonly XkcdColour BrownishGreen = new XkcdColour("brownish green", "#6a6e09");

        public static readonly XkcdColour BrownishGrey = new XkcdColour("brownish grey", "#86775f");

        public static readonly XkcdColour BrownishOrange = new XkcdColour("brownish orange", "#cb7723");

        public static readonly XkcdColour BrownishPink = new XkcdColour("brownish pink", "#c27e79");

        public static readonly XkcdColour BrownishPurple = new XkcdColour("brownish purple", "#76424e");

        public static readonly XkcdColour BrownishRed = new XkcdColour("brownish red", "#9e3623");

        public static readonly XkcdColour BrownishYellow = new XkcdColour("brownish yellow", "#c9b003");

        public static readonly XkcdColour BrownyGreen = new XkcdColour("browny green", "#6f6c0a");

        public static readonly XkcdColour BrownyOrange = new XkcdColour("browny orange", "#ca6b02");

        public static readonly XkcdColour Bruise = new XkcdColour("bruise", "#7e4071");

        public static readonly XkcdColour BubbleGumPink = new XkcdColour("bubble gum pink", "#ff69af");

        public static readonly XkcdColour Bubblegum = new XkcdColour("bubblegum", "#ff6cb5");

        public static readonly XkcdColour BubblegumPink = new XkcdColour("bubblegum pink", "#fe83cc");

        public static readonly XkcdColour Buff = new XkcdColour("buff", "#fef69e");

        public static readonly XkcdColour Burgundy = new XkcdColour("burgundy", "#610023");

        public static readonly XkcdColour BurntOrange = new XkcdColour("burnt orange", "#c04e01");

        public static readonly XkcdColour BurntRed = new XkcdColour("burnt red", "#9f2305");

        public static readonly XkcdColour BurntSiena = new XkcdColour("burnt siena", "#b75203");

        public static readonly XkcdColour BurntSienna = new XkcdColour("burnt sienna", "#b04e0f");

        public static readonly XkcdColour BurntUmber = new XkcdColour("burnt umber", "#a0450e");

        public static readonly XkcdColour BurntYellow = new XkcdColour("burnt yellow", "#d5ab09");

        public static readonly XkcdColour Burple = new XkcdColour("burple", "#6832e3");

        public static readonly XkcdColour Butter = new XkcdColour("butter", "#ffff81");

        public static readonly XkcdColour ButterYellow = new XkcdColour("butter yellow", "#fffd74");

        public static readonly XkcdColour Butterscotch = new XkcdColour("butterscotch", "#fdb147");

        public static readonly XkcdColour CadetBlue = new XkcdColour("cadet blue", "#4e7496");

        public static readonly XkcdColour Camel = new XkcdColour("camel", "#c69f59");

        public static readonly XkcdColour Camo = new XkcdColour("camo", "#7f8f4e");

        public static readonly XkcdColour CamoGreen = new XkcdColour("camo green", "#526525");

        public static readonly XkcdColour CamouflageGreen = new XkcdColour("camouflage green", "#4b6113");

        public static readonly XkcdColour Canary = new XkcdColour("canary", "#fdff63");

        public static readonly XkcdColour CanaryYellow = new XkcdColour("canary yellow", "#fffe40");

        public static readonly XkcdColour CandyPink = new XkcdColour("candy pink", "#ff63e9");

        public static readonly XkcdColour Caramel = new XkcdColour("caramel", "#af6f09");

        public static readonly XkcdColour Carmine = new XkcdColour("carmine", "#9d0216");

        public static readonly XkcdColour Carnation = new XkcdColour("carnation", "#fd798f");

        public static readonly XkcdColour CarnationPink = new XkcdColour("carnation pink", "#ff7fa7");

        public static readonly XkcdColour CarolinaBlue = new XkcdColour("carolina blue", "#8ab8fe");

        public static readonly XkcdColour Celadon = new XkcdColour("celadon", "#befdb7");

        public static readonly XkcdColour Celery = new XkcdColour("celery", "#c1fd95");

        public static readonly XkcdColour Cement = new XkcdColour("cement", "#a5a391");

        public static readonly XkcdColour Cerise = new XkcdColour("cerise", "#de0c62");

        public static readonly XkcdColour Cerulean = new XkcdColour("cerulean", "#0485d1");

        public static readonly XkcdColour CeruleanBlue = new XkcdColour("cerulean blue", "#056eee");

        public static readonly XkcdColour Charcoal = new XkcdColour("charcoal", "#343837");

        public static readonly XkcdColour CharcoalGrey = new XkcdColour("charcoal grey", "#3c4142");

        public static readonly XkcdColour Chartreuse = new XkcdColour("chartreuse", "#c1f80a");

        public static readonly XkcdColour Cherry = new XkcdColour("cherry", "#cf0234");

        public static readonly XkcdColour CherryRed = new XkcdColour("cherry red", "#f7022a");

        public static readonly XkcdColour Chestnut = new XkcdColour("chestnut", "#742802");

        public static readonly XkcdColour Chocolate = new XkcdColour("chocolate", "#3d1c02");

        public static readonly XkcdColour ChocolateBrown = new XkcdColour("chocolate brown", "#411900");

        public static readonly XkcdColour Cinnamon = new XkcdColour("cinnamon", "#ac4f06");

        public static readonly XkcdColour Claret = new XkcdColour("claret", "#680018");

        public static readonly XkcdColour Clay = new XkcdColour("clay", "#b66a50");

        public static readonly XkcdColour ClayBrown = new XkcdColour("clay brown", "#b2713d");

        public static readonly XkcdColour ClearBlue = new XkcdColour("clear blue", "#247afd");

        public static readonly XkcdColour CloudyBlue = new XkcdColour("cloudy blue", "#acc2d9");

        public static readonly XkcdColour Cobalt = new XkcdColour("cobalt", "#1e488f");

        public static readonly XkcdColour CobaltBlue = new XkcdColour("cobalt blue", "#030aa7");

        public static readonly XkcdColour Cocoa = new XkcdColour("cocoa", "#875f42");

        public static readonly XkcdColour Coffee = new XkcdColour("coffee", "#a6814c");

        public static readonly XkcdColour CoolBlue = new XkcdColour("cool blue", "#4984b8");

        public static readonly XkcdColour CoolGreen = new XkcdColour("cool green", "#33b864");

        public static readonly XkcdColour CoolGrey = new XkcdColour("cool grey", "#95a3a6");

        public static readonly XkcdColour Copper = new XkcdColour("copper", "#b66325");

        public static readonly XkcdColour Coral = new XkcdColour("coral", "#fc5a50");

        public static readonly XkcdColour CoralPink = new XkcdColour("coral pink", "#ff6163");

        public static readonly XkcdColour Cornflower = new XkcdColour("cornflower", "#6a79f7");

        public static readonly XkcdColour CornflowerBlue = new XkcdColour("cornflower blue", "#5170d7");

        public static readonly XkcdColour Cranberry = new XkcdColour("cranberry", "#9e003a");

        public static readonly XkcdColour Cream = new XkcdColour("cream", "#ffffc2");

        public static readonly XkcdColour Creme = new XkcdColour("creme", "#ffffb6");

        public static readonly XkcdColour Crimson = new XkcdColour("crimson", "#8c000f");

        public static readonly XkcdColour Custard = new XkcdColour("custard", "#fffd78");

        public static readonly XkcdColour Cyan = new XkcdColour("cyan", "#00ffff");

        public static readonly XkcdColour Dandelion = new XkcdColour("dandelion", "#fedf08");

        public static readonly XkcdColour Dark = new XkcdColour("dark", "#1b2431");

        public static readonly XkcdColour DarkAqua = new XkcdColour("dark aqua", "#05696b");

        public static readonly XkcdColour DarkAquamarine = new XkcdColour("dark aquamarine", "#017371");

        public static readonly XkcdColour DarkBeige = new XkcdColour("dark beige", "#ac9362");

        public static readonly XkcdColour DarkBlue = new XkcdColour("dark blue", "#00035b");

        public static readonly XkcdColour DarkBlueGreen = new XkcdColour("dark blue green", "#005249");

        public static readonly XkcdColour DarkBlueGrey = new XkcdColour("dark blue grey", "#1f3b4d");

        public static readonly XkcdColour DarkBrown = new XkcdColour("dark brown", "#341c02");

        public static readonly XkcdColour DarkCoral = new XkcdColour("dark coral", "#cf524e");

        public static readonly XkcdColour DarkCream = new XkcdColour("dark cream", "#fff39a");

        public static readonly XkcdColour DarkCyan = new XkcdColour("dark cyan", "#0a888a");

        public static readonly XkcdColour DarkForestGreen = new XkcdColour("dark forest green", "#002d04");

        public static readonly XkcdColour DarkFuchsia = new XkcdColour("dark fuchsia", "#9d0759");

        public static readonly XkcdColour DarkGold = new XkcdColour("dark gold", "#b59410");

        public static readonly XkcdColour DarkGrassGreen = new XkcdColour("dark grass green", "#388004");

        public static readonly XkcdColour DarkGreen = new XkcdColour("dark green", "#033500");

        public static readonly XkcdColour DarkGreenBlue = new XkcdColour("dark green blue", "#1f6357");

        public static readonly XkcdColour DarkGrey = new XkcdColour("dark grey", "#363737");

        public static readonly XkcdColour DarkGreyBlue = new XkcdColour("dark grey blue", "#29465b");

        public static readonly XkcdColour DarkHotPink = new XkcdColour("dark hot pink", "#d90166");

        public static readonly XkcdColour DarkIndigo = new XkcdColour("dark indigo", "#1f0954");

        public static readonly XkcdColour DarkKhaki = new XkcdColour("dark khaki", "#9b8f55");

        public static readonly XkcdColour DarkLavender = new XkcdColour("dark lavender", "#856798");

        public static readonly XkcdColour DarkLilac = new XkcdColour("dark lilac", "#9c6da5");

        public static readonly XkcdColour DarkLime = new XkcdColour("dark lime", "#84b701");

        public static readonly XkcdColour DarkLimeGreen = new XkcdColour("dark lime green", "#7ebd01");

        public static readonly XkcdColour DarkMagenta = new XkcdColour("dark magenta", "#960056");

        public static readonly XkcdColour DarkMaroon = new XkcdColour("dark maroon", "#3c0008");

        public static readonly XkcdColour DarkMauve = new XkcdColour("dark mauve", "#874c62");

        public static readonly XkcdColour DarkMint = new XkcdColour("dark mint", "#48c072");

        public static readonly XkcdColour DarkMintGreen = new XkcdColour("dark mint green", "#20c073");

        public static readonly XkcdColour DarkMustard = new XkcdColour("dark mustard", "#a88905");

        public static readonly XkcdColour DarkNavy = new XkcdColour("dark navy", "#000435");

        public static readonly XkcdColour DarkNavyBlue = new XkcdColour("dark navy blue", "#00022e");

        public static readonly XkcdColour DarkOlive = new XkcdColour("dark olive", "#373e02");

        public static readonly XkcdColour DarkOliveGreen = new XkcdColour("dark olive green", "#3c4d03");

        public static readonly XkcdColour DarkOrange = new XkcdColour("dark orange", "#c65102");

        public static readonly XkcdColour DarkPastelGreen = new XkcdColour("dark pastel green", "#56ae57");

        public static readonly XkcdColour DarkPeach = new XkcdColour("dark peach", "#de7e5d");

        public static readonly XkcdColour DarkPeriwinkle = new XkcdColour("dark periwinkle", "#665fd1");

        public static readonly XkcdColour DarkPink = new XkcdColour("dark pink", "#cb416b");

        public static readonly XkcdColour DarkPlum = new XkcdColour("dark plum", "#3f012c");

        public static readonly XkcdColour DarkPurple = new XkcdColour("dark purple", "#35063e");

        public static readonly XkcdColour DarkRed = new XkcdColour("dark red", "#840000");

        public static readonly XkcdColour DarkRose = new XkcdColour("dark rose", "#b5485d");

        public static readonly XkcdColour DarkRoyalBlue = new XkcdColour("dark royal blue", "#02066f");

        public static readonly XkcdColour DarkSage = new XkcdColour("dark sage", "#598556");

        public static readonly XkcdColour DarkSalmon = new XkcdColour("dark salmon", "#c85a53");

        public static readonly XkcdColour DarkSand = new XkcdColour("dark sand", "#a88f59");

        public static readonly XkcdColour DarkSeaGreen = new XkcdColour("dark sea green", "#11875d");

        public static readonly XkcdColour DarkSeafoam = new XkcdColour("dark seafoam", "#1fb57a");

        public static readonly XkcdColour DarkSeafoamGreen = new XkcdColour("dark seafoam green", "#3eaf76");

        public static readonly XkcdColour DarkSkyBlue = new XkcdColour("dark sky blue", "#448ee4");

        public static readonly XkcdColour DarkSlateBlue = new XkcdColour("dark slate blue", "#214761");

        public static readonly XkcdColour DarkTan = new XkcdColour("dark tan", "#af884a");

        public static readonly XkcdColour DarkTaupe = new XkcdColour("dark taupe", "#7f684e");

        public static readonly XkcdColour DarkTeal = new XkcdColour("dark teal", "#014d4e");

        public static readonly XkcdColour DarkTurquoise = new XkcdColour("dark turquoise", "#045c5a");

        public static readonly XkcdColour DarkViolet = new XkcdColour("dark violet", "#34013f");

        public static readonly XkcdColour DarkYellow = new XkcdColour("dark yellow", "#d5b60a");

        public static readonly XkcdColour DarkYellowGreen = new XkcdColour("dark yellow green", "#728f02");

        public static readonly XkcdColour Darkblue = new XkcdColour("darkblue", "#030764");

        public static readonly XkcdColour Darkgreen = new XkcdColour("darkgreen", "#054907");

        public static readonly XkcdColour DarkishBlue = new XkcdColour("darkish blue", "#014182");

        public static readonly XkcdColour DarkishGreen = new XkcdColour("darkish green", "#287c37");

        public static readonly XkcdColour DarkishPink = new XkcdColour("darkish pink", "#da467d");

        public static readonly XkcdColour DarkishPurple = new XkcdColour("darkish purple", "#751973");

        public static readonly XkcdColour DarkishRed = new XkcdColour("darkish red", "#a90308");

        public static readonly XkcdColour DeepAqua = new XkcdColour("deep aqua", "#08787f");

        public static readonly XkcdColour DeepBlue = new XkcdColour("deep blue", "#040273");

        public static readonly XkcdColour DeepBrown = new XkcdColour("deep brown", "#410200");

        public static readonly XkcdColour DeepGreen = new XkcdColour("deep green", "#02590f");

        public static readonly XkcdColour DeepLavender = new XkcdColour("deep lavender", "#8d5eb7");

        public static readonly XkcdColour DeepLilac = new XkcdColour("deep lilac", "#966ebd");

        public static readonly XkcdColour DeepMagenta = new XkcdColour("deep magenta", "#a0025c");

        public static readonly XkcdColour DeepOrange = new XkcdColour("deep orange", "#dc4d01");

        public static readonly XkcdColour DeepPink = new XkcdColour("deep pink", "#cb0162");

        public static readonly XkcdColour DeepPurple = new XkcdColour("deep purple", "#36013f");

        public static readonly XkcdColour DeepRed = new XkcdColour("deep red", "#9a0200");

        public static readonly XkcdColour DeepRose = new XkcdColour("deep rose", "#c74767");

        public static readonly XkcdColour DeepSeaBlue = new XkcdColour("deep sea blue", "#015482");

        public static readonly XkcdColour DeepSkyBlue = new XkcdColour("deep sky blue", "#0d75f8");

        public static readonly XkcdColour DeepTeal = new XkcdColour("deep teal", "#00555a");

        public static readonly XkcdColour DeepTurquoise = new XkcdColour("deep turquoise", "#017374");

        public static readonly XkcdColour DeepViolet = new XkcdColour("deep violet", "#490648");

        public static readonly XkcdColour Denim = new XkcdColour("denim", "#3b638c");

        public static readonly XkcdColour DenimBlue = new XkcdColour("denim blue", "#3b5b92");

        public static readonly XkcdColour Desert = new XkcdColour("desert", "#ccad60");

        public static readonly XkcdColour Diarrhea = new XkcdColour("diarrhea", "#9f8303");

        public static readonly XkcdColour Dirt = new XkcdColour("dirt", "#8a6e45");

        public static readonly XkcdColour DirtBrown = new XkcdColour("dirt brown", "#836539");

        public static readonly XkcdColour DirtyBlue = new XkcdColour("dirty blue", "#3f829d");

        public static readonly XkcdColour DirtyGreen = new XkcdColour("dirty green", "#667e2c");

        public static readonly XkcdColour DirtyOrange = new XkcdColour("dirty orange", "#c87606");

        public static readonly XkcdColour DirtyPink = new XkcdColour("dirty pink", "#ca7b80");

        public static readonly XkcdColour DirtyPurple = new XkcdColour("dirty purple", "#734a65");

        public static readonly XkcdColour DirtyYellow = new XkcdColour("dirty yellow", "#cdc50a");

        public static readonly XkcdColour DodgerBlue = new XkcdColour("dodger blue", "#3e82fc");

        public static readonly XkcdColour Drab = new XkcdColour("drab", "#828344");

        public static readonly XkcdColour DrabGreen = new XkcdColour("drab green", "#749551");

        public static readonly XkcdColour DriedBlood = new XkcdColour("dried blood", "#4b0101");

        public static readonly XkcdColour DuckEggBlue = new XkcdColour("duck egg blue", "#c3fbf4");

        public static readonly XkcdColour DullBlue = new XkcdColour("dull blue", "#49759c");

        public static readonly XkcdColour DullBrown = new XkcdColour("dull brown", "#876e4b");

        public static readonly XkcdColour DullGreen = new XkcdColour("dull green", "#74a662");

        public static readonly XkcdColour DullOrange = new XkcdColour("dull orange", "#d8863b");

        public static readonly XkcdColour DullPink = new XkcdColour("dull pink", "#d5869d");

        public static readonly XkcdColour DullPurple = new XkcdColour("dull purple", "#84597e");

        public static readonly XkcdColour DullRed = new XkcdColour("dull red", "#bb3f3f");

        public static readonly XkcdColour DullTeal = new XkcdColour("dull teal", "#5f9e8f");

        public static readonly XkcdColour DullYellow = new XkcdColour("dull yellow", "#eedc5b");

        public static readonly XkcdColour Dusk = new XkcdColour("dusk", "#4e5481");

        public static readonly XkcdColour DuskBlue = new XkcdColour("dusk blue", "#26538d");

        public static readonly XkcdColour DuskyBlue = new XkcdColour("dusky blue", "#475f94");

        public static readonly XkcdColour DuskyPink = new XkcdColour("dusky pink", "#cc7a8b");

        public static readonly XkcdColour DuskyPurple = new XkcdColour("dusky purple", "#895b7b");

        public static readonly XkcdColour DuskyRose = new XkcdColour("dusky rose", "#ba6873");

        public static readonly XkcdColour Dust = new XkcdColour("dust", "#b2996e");

        public static readonly XkcdColour DustyBlue = new XkcdColour("dusty blue", "#5a86ad");

        public static readonly XkcdColour DustyGreen = new XkcdColour("dusty green", "#76a973");

        public static readonly XkcdColour DustyLavender = new XkcdColour("dusty lavender", "#ac86a8");

        public static readonly XkcdColour DustyOrange = new XkcdColour("dusty orange", "#f0833a");

        public static readonly XkcdColour DustyPink = new XkcdColour("dusty pink", "#d58a94");

        public static readonly XkcdColour DustyPurple = new XkcdColour("dusty purple", "#825f87");

        public static readonly XkcdColour DustyRed = new XkcdColour("dusty red", "#b9484e");

        public static readonly XkcdColour DustyRose = new XkcdColour("dusty rose", "#c0737a");

        public static readonly XkcdColour DustyTeal = new XkcdColour("dusty teal", "#4c9085");

        public static readonly XkcdColour Earth = new XkcdColour("earth", "#a2653e");

        public static readonly XkcdColour EasterGreen = new XkcdColour("easter green", "#8cfd7e");

        public static readonly XkcdColour EasterPurple = new XkcdColour("easter purple", "#c071fe");

        public static readonly XkcdColour Ecru = new XkcdColour("ecru", "#feffca");

        public static readonly XkcdColour EggShell = new XkcdColour("egg shell", "#fffcc4");

        public static readonly XkcdColour Eggplant = new XkcdColour("eggplant", "#380835");

        public static readonly XkcdColour EggplantPurple = new XkcdColour("eggplant purple", "#430541");

        public static readonly XkcdColour Eggshell = new XkcdColour("eggshell", "#ffffd4");

        public static readonly XkcdColour EggshellBlue = new XkcdColour("eggshell blue", "#c4fff7");

        public static readonly XkcdColour ElectricBlue = new XkcdColour("electric blue", "#0652ff");

        public static readonly XkcdColour ElectricGreen = new XkcdColour("electric green", "#21fc0d");

        public static readonly XkcdColour ElectricLime = new XkcdColour("electric lime", "#a8ff04");

        public static readonly XkcdColour ElectricPink = new XkcdColour("electric pink", "#ff0490");

        public static readonly XkcdColour ElectricPurple = new XkcdColour("electric purple", "#aa23ff");

        public static readonly XkcdColour Emerald = new XkcdColour("emerald", "#01a049");

        public static readonly XkcdColour EmeraldGreen = new XkcdColour("emerald green", "#028f1e");

        public static readonly XkcdColour Evergreen = new XkcdColour("evergreen", "#05472a");

        public static readonly XkcdColour FadedBlue = new XkcdColour("faded blue", "#658cbb");

        public static readonly XkcdColour FadedGreen = new XkcdColour("faded green", "#7bb274");

        public static readonly XkcdColour FadedOrange = new XkcdColour("faded orange", "#f0944d");

        public static readonly XkcdColour FadedPink = new XkcdColour("faded pink", "#de9dac");

        public static readonly XkcdColour FadedPurple = new XkcdColour("faded purple", "#916e99");

        public static readonly XkcdColour FadedRed = new XkcdColour("faded red", "#d3494e");

        public static readonly XkcdColour FadedYellow = new XkcdColour("faded yellow", "#feff7f");

        public static readonly XkcdColour Fawn = new XkcdColour("fawn", "#cfaf7b");

        public static readonly XkcdColour Fern = new XkcdColour("fern", "#63a950");

        public static readonly XkcdColour FernGreen = new XkcdColour("fern green", "#548d44");

        public static readonly XkcdColour FireEngineRed = new XkcdColour("fire engine red", "#fe0002");

        public static readonly XkcdColour FlatBlue = new XkcdColour("flat blue", "#3c73a8");

        public static readonly XkcdColour FlatGreen = new XkcdColour("flat green", "#699d4c");

        public static readonly XkcdColour FluorescentGreen = new XkcdColour("fluorescent green", "#08ff08");

        public static readonly XkcdColour FluroGreen = new XkcdColour("fluro green", "#0aff02");

        public static readonly XkcdColour FoamGreen = new XkcdColour("foam green", "#90fda9");

        public static readonly XkcdColour Forest = new XkcdColour("forest", "#0b5509");

        public static readonly XkcdColour ForestGreen = new XkcdColour("forest green", "#06470c");

        public static readonly XkcdColour ForrestGreen = new XkcdColour("forrest green", "#154406");

        public static readonly XkcdColour FrenchBlue = new XkcdColour("french blue", "#436bad");

        public static readonly XkcdColour FreshGreen = new XkcdColour("fresh green", "#69d84f");

        public static readonly XkcdColour FrogGreen = new XkcdColour("frog green", "#58bc08");

        public static readonly XkcdColour Fuchsia = new XkcdColour("fuchsia", "#ed0dd9");

        public static readonly XkcdColour Gold = new XkcdColour("gold", "#dbb40c");

        public static readonly XkcdColour Golden = new XkcdColour("golden", "#f5bf03");

        public static readonly XkcdColour GoldenBrown = new XkcdColour("golden brown", "#b27a01");

        public static readonly XkcdColour GoldenRod = new XkcdColour("golden rod", "#f9bc08");

        public static readonly XkcdColour GoldenYellow = new XkcdColour("golden yellow", "#fec615");

        public static readonly XkcdColour Goldenrod = new XkcdColour("goldenrod", "#fac205");

        public static readonly XkcdColour Grape = new XkcdColour("grape", "#6c3461");

        public static readonly XkcdColour GrapePurple = new XkcdColour("grape purple", "#5d1451");

        public static readonly XkcdColour Grapefruit = new XkcdColour("grapefruit", "#fd5956");

        public static readonly XkcdColour Grass = new XkcdColour("grass", "#5cac2d");

        public static readonly XkcdColour GrassGreen = new XkcdColour("grass green", "#3f9b0b");

        public static readonly XkcdColour GrassyGreen = new XkcdColour("grassy green", "#419c03");

        public static readonly XkcdColour Green = new XkcdColour("green", "#15b01a");

        public static readonly XkcdColour GreenApple = new XkcdColour("green apple", "#5edc1f");

        public static readonly XkcdColour GreenBlue = new XkcdColour("green blue", "#06b48b");

        public static readonly XkcdColour GreenBrown = new XkcdColour("green brown", "#544e03");

        public static readonly XkcdColour GreenGrey = new XkcdColour("green grey", "#77926f");

        public static readonly XkcdColour GreenTeal = new XkcdColour("green teal", "#0cb577");

        public static readonly XkcdColour GreenYellow = new XkcdColour("green yellow", "#c9ff27");

        public static readonly XkcdColour GreenSlashBlue = new XkcdColour("green/blue", "#01c08d");

        public static readonly XkcdColour GreenSlashYellow = new XkcdColour("green/yellow", "#b5ce08");

        public static readonly XkcdColour Greenblue = new XkcdColour("greenblue", "#23c48b");

        public static readonly XkcdColour Greenish = new XkcdColour("greenish", "#40a368");

        public static readonly XkcdColour GreenishBeige = new XkcdColour("greenish beige", "#c9d179");

        public static readonly XkcdColour GreenishBlue = new XkcdColour("greenish blue", "#0b8b87");

        public static readonly XkcdColour GreenishBrown = new XkcdColour("greenish brown", "#696112");

        public static readonly XkcdColour GreenishCyan = new XkcdColour("greenish cyan", "#2afeb7");

        public static readonly XkcdColour GreenishGrey = new XkcdColour("greenish grey", "#96ae8d");

        public static readonly XkcdColour GreenishTan = new XkcdColour("greenish tan", "#bccb7a");

        public static readonly XkcdColour GreenishTeal = new XkcdColour("greenish teal", "#32bf84");

        public static readonly XkcdColour GreenishTurquoise = new XkcdColour("greenish turquoise", "#00fbb0");

        public static readonly XkcdColour GreenishYellow = new XkcdColour("greenish yellow", "#cdfd02");

        public static readonly XkcdColour GreenyBlue = new XkcdColour("greeny blue", "#42b395");

        public static readonly XkcdColour GreenyBrown = new XkcdColour("greeny brown", "#696006");

        public static readonly XkcdColour GreenyGrey = new XkcdColour("greeny grey", "#7ea07a");

        public static readonly XkcdColour GreenyYellow = new XkcdColour("greeny yellow", "#c6f808");

        public static readonly XkcdColour Grey = new XkcdColour("grey", "#929591");

        public static readonly XkcdColour GreyBlue = new XkcdColour("grey blue", "#6b8ba4");

        public static readonly XkcdColour GreyBrown = new XkcdColour("grey brown", "#7f7053");

        public static readonly XkcdColour GreyGreen = new XkcdColour("grey green", "#789b73");

        public static readonly XkcdColour GreyPink = new XkcdColour("grey pink", "#c3909b");

        public static readonly XkcdColour GreyPurple = new XkcdColour("grey purple", "#826d8c");

        public static readonly XkcdColour GreyTeal = new XkcdColour("grey teal", "#5e9b8a");

        public static readonly XkcdColour GreySlashBlue = new XkcdColour("grey/blue", "#647d8e");

        public static readonly XkcdColour GreySlashGreen = new XkcdColour("grey/green", "#86a17d");

        public static readonly XkcdColour Greyblue = new XkcdColour("greyblue", "#77a1b5");

        public static readonly XkcdColour Greyish = new XkcdColour("greyish", "#a8a495");

        public static readonly XkcdColour GreyishBlue = new XkcdColour("greyish blue", "#5e819d");

        public static readonly XkcdColour GreyishBrown = new XkcdColour("greyish brown", "#7a6a4f");

        public static readonly XkcdColour GreyishGreen = new XkcdColour("greyish green", "#82a67d");

        public static readonly XkcdColour GreyishPink = new XkcdColour("greyish pink", "#c88d94");

        public static readonly XkcdColour GreyishPurple = new XkcdColour("greyish purple", "#887191");

        public static readonly XkcdColour GreyishTeal = new XkcdColour("greyish teal", "#719f91");

        public static readonly XkcdColour GrossGreen = new XkcdColour("gross green", "#a0bf16");

        public static readonly XkcdColour Gunmetal = new XkcdColour("gunmetal", "#536267");

        public static readonly XkcdColour Hazel = new XkcdColour("hazel", "#8e7618");

        public static readonly XkcdColour Heather = new XkcdColour("heather", "#a484ac");

        public static readonly XkcdColour Heliotrope = new XkcdColour("heliotrope", "#d94ff5");

        public static readonly XkcdColour HighlighterGreen = new XkcdColour("highlighter green", "#1bfc06");

        public static readonly XkcdColour HospitalGreen = new XkcdColour("hospital green", "#9be5aa");

        public static readonly XkcdColour HotGreen = new XkcdColour("hot green", "#25ff29");

        public static readonly XkcdColour HotMagenta = new XkcdColour("hot magenta", "#f504c9");

        public static readonly XkcdColour HotPink = new XkcdColour("hot pink", "#ff028d");

        public static readonly XkcdColour HotPurple = new XkcdColour("hot purple", "#cb00f5");

        public static readonly XkcdColour HunterGreen = new XkcdColour("hunter green", "#0b4008");

        public static readonly XkcdColour Ice = new XkcdColour("ice", "#d6fffa");

        public static readonly XkcdColour IceBlue = new XkcdColour("ice blue", "#d7fffe");

        public static readonly XkcdColour IckyGreen = new XkcdColour("icky green", "#8fae22");

        public static readonly XkcdColour IndianRed = new XkcdColour("indian red", "#850e04");

        public static readonly XkcdColour Indigo = new XkcdColour("indigo", "#380282");

        public static readonly XkcdColour IndigoBlue = new XkcdColour("indigo blue", "#3a18b1");

        public static readonly XkcdColour Iris = new XkcdColour("iris", "#6258c4");

        public static readonly XkcdColour IrishGreen = new XkcdColour("irish green", "#019529");

        public static readonly XkcdColour Ivory = new XkcdColour("ivory", "#ffffcb");

        public static readonly XkcdColour Jade = new XkcdColour("jade", "#1fa774");

        public static readonly XkcdColour JadeGreen = new XkcdColour("jade green", "#2baf6a");

        public static readonly XkcdColour JungleGreen = new XkcdColour("jungle green", "#048243");

        public static readonly XkcdColour KelleyGreen = new XkcdColour("kelley green", "#009337");

        public static readonly XkcdColour KellyGreen = new XkcdColour("kelly green", "#02ab2e");

        public static readonly XkcdColour KermitGreen = new XkcdColour("kermit green", "#5cb200");

        public static readonly XkcdColour KeyLime = new XkcdColour("key lime", "#aeff6e");

        public static readonly XkcdColour Khaki = new XkcdColour("khaki", "#aaa662");

        public static readonly XkcdColour KhakiGreen = new XkcdColour("khaki green", "#728639");

        public static readonly XkcdColour Kiwi = new XkcdColour("kiwi", "#9cef43");

        public static readonly XkcdColour KiwiGreen = new XkcdColour("kiwi green", "#8ee53f");

        public static readonly XkcdColour Lavender = new XkcdColour("lavender", "#c79fef");

        public static readonly XkcdColour LavenderBlue = new XkcdColour("lavender blue", "#8b88f8");

        public static readonly XkcdColour LavenderPink = new XkcdColour("lavender pink", "#dd85d7");

        public static readonly XkcdColour LawnGreen = new XkcdColour("lawn green", "#4da409");

        public static readonly XkcdColour Leaf = new XkcdColour("leaf", "#71aa34");

        public static readonly XkcdColour LeafGreen = new XkcdColour("leaf green", "#5ca904");

        public static readonly XkcdColour LeafyGreen = new XkcdColour("leafy green", "#51b73b");

        public static readonly XkcdColour Leather = new XkcdColour("leather", "#ac7434");

        public static readonly XkcdColour Lemon = new XkcdColour("lemon", "#fdff52");

        public static readonly XkcdColour LemonGreen = new XkcdColour("lemon green", "#adf802");

        public static readonly XkcdColour LemonLime = new XkcdColour("lemon lime", "#bffe28");

        public static readonly XkcdColour LemonYellow = new XkcdColour("lemon yellow", "#fdff38");

        public static readonly XkcdColour Lichen = new XkcdColour("lichen", "#8fb67b");

        public static readonly XkcdColour LightAqua = new XkcdColour("light aqua", "#8cffdb");

        public static readonly XkcdColour LightAquamarine = new XkcdColour("light aquamarine", "#7bfdc7");

        public static readonly XkcdColour LightBeige = new XkcdColour("light beige", "#fffeb6");

        public static readonly XkcdColour LightBlue = new XkcdColour("light blue", "#95d0fc");

        public static readonly XkcdColour LightBlueGreen = new XkcdColour("light blue green", "#7efbb3");

        public static readonly XkcdColour LightBlueGrey = new XkcdColour("light blue grey", "#b7c9e2");

        public static readonly XkcdColour LightBluishGreen = new XkcdColour("light bluish green", "#76fda8");

        public static readonly XkcdColour LightBrightGreen = new XkcdColour("light bright green", "#53fe5c");

        public static readonly XkcdColour LightBrown = new XkcdColour("light brown", "#ad8150");

        public static readonly XkcdColour LightBurgundy = new XkcdColour("light burgundy", "#a8415b");

        public static readonly XkcdColour LightCyan = new XkcdColour("light cyan", "#acfffc");

        public static readonly XkcdColour LightEggplant = new XkcdColour("light eggplant", "#894585");

        public static readonly XkcdColour LightForestGreen = new XkcdColour("light forest green", "#4f9153");

        public static readonly XkcdColour LightGold = new XkcdColour("light gold", "#fddc5c");

        public static readonly XkcdColour LightGrassGreen = new XkcdColour("light grass green", "#9af764");

        public static readonly XkcdColour LightGreen = new XkcdColour("light green", "#96f97b");

        public static readonly XkcdColour LightGreenBlue = new XkcdColour("light green blue", "#56fca2");

        public static readonly XkcdColour LightGreenishBlue = new XkcdColour("light greenish blue", "#63f7b4");

        public static readonly XkcdColour LightGrey = new XkcdColour("light grey", "#d8dcd6");

        public static readonly XkcdColour LightGreyBlue = new XkcdColour("light grey blue", "#9dbcd4");

        public static readonly XkcdColour LightGreyGreen = new XkcdColour("light grey green", "#b7e1a1");

        public static readonly XkcdColour LightIndigo = new XkcdColour("light indigo", "#6d5acf");

        public static readonly XkcdColour LightKhaki = new XkcdColour("light khaki", "#e6f2a2");

        public static readonly XkcdColour LightLavendar = new XkcdColour("light lavendar", "#efc0fe");

        public static readonly XkcdColour LightLavender = new XkcdColour("light lavender", "#dfc5fe");

        public static readonly XkcdColour LightLightBlue = new XkcdColour("light light blue", "#cafffb");

        public static readonly XkcdColour LightLightGreen = new XkcdColour("light light green", "#c8ffb0");

        public static readonly XkcdColour LightLilac = new XkcdColour("light lilac", "#edc8ff");

        public static readonly XkcdColour LightLime = new XkcdColour("light lime", "#aefd6c");

        public static readonly XkcdColour LightLimeGreen = new XkcdColour("light lime green", "#b9ff66");

        public static readonly XkcdColour LightMagenta = new XkcdColour("light magenta", "#fa5ff7");

        public static readonly XkcdColour LightMaroon = new XkcdColour("light maroon", "#a24857");

        public static readonly XkcdColour LightMauve = new XkcdColour("light mauve", "#c292a1");

        public static readonly XkcdColour LightMint = new XkcdColour("light mint", "#b6ffbb");

        public static readonly XkcdColour LightMintGreen = new XkcdColour("light mint green", "#a6fbb2");

        public static readonly XkcdColour LightMossGreen = new XkcdColour("light moss green", "#a6c875");

        public static readonly XkcdColour LightMustard = new XkcdColour("light mustard", "#f7d560");

        public static readonly XkcdColour LightNavy = new XkcdColour("light navy", "#155084");

        public static readonly XkcdColour LightNavyBlue = new XkcdColour("light navy blue", "#2e5a88");

        public static readonly XkcdColour LightNeonGreen = new XkcdColour("light neon green", "#4efd54");

        public static readonly XkcdColour LightOlive = new XkcdColour("light olive", "#acbf69");

        public static readonly XkcdColour LightOliveGreen = new XkcdColour("light olive green", "#a4be5c");

        public static readonly XkcdColour LightOrange = new XkcdColour("light orange", "#fdaa48");

        public static readonly XkcdColour LightPastelGreen = new XkcdColour("light pastel green", "#b2fba5");

        public static readonly XkcdColour LightPeaGreen = new XkcdColour("light pea green", "#c4fe82");

        public static readonly XkcdColour LightPeach = new XkcdColour("light peach", "#ffd8b1");

        public static readonly XkcdColour LightPeriwinkle = new XkcdColour("light periwinkle", "#c1c6fc");

        public static readonly XkcdColour LightPink = new XkcdColour("light pink", "#ffd1df");

        public static readonly XkcdColour LightPlum = new XkcdColour("light plum", "#9d5783");

        public static readonly XkcdColour LightPurple = new XkcdColour("light purple", "#bf77f6");

        public static readonly XkcdColour LightRed = new XkcdColour("light red", "#ff474c");

        public static readonly XkcdColour LightRose = new XkcdColour("light rose", "#ffc5cb");

        public static readonly XkcdColour LightRoyalBlue = new XkcdColour("light royal blue", "#3a2efe");

        public static readonly XkcdColour LightSage = new XkcdColour("light sage", "#bcecac");

        public static readonly XkcdColour LightSalmon = new XkcdColour("light salmon", "#fea993");

        public static readonly XkcdColour LightSeaGreen = new XkcdColour("light sea green", "#98f6b0");

        public static readonly XkcdColour LightSeafoam = new XkcdColour("light seafoam", "#a0febf");

        public static readonly XkcdColour LightSeafoamGreen = new XkcdColour("light seafoam green", "#a7ffb5");

        public static readonly XkcdColour LightSkyBlue = new XkcdColour("light sky blue", "#c6fcff");

        public static readonly XkcdColour LightTan = new XkcdColour("light tan", "#fbeeac");

        public static readonly XkcdColour LightTeal = new XkcdColour("light teal", "#90e4c1");

        public static readonly XkcdColour LightTurquoise = new XkcdColour("light turquoise", "#7ef4cc");

        public static readonly XkcdColour LightUrple = new XkcdColour("light urple", "#b36ff6");

        public static readonly XkcdColour LightViolet = new XkcdColour("light violet", "#d6b4fc");

        public static readonly XkcdColour LightYellow = new XkcdColour("light yellow", "#fffe7a");

        public static readonly XkcdColour LightYellowGreen = new XkcdColour("light yellow green", "#ccfd7f");

        public static readonly XkcdColour LightYellowishGreen = new XkcdColour("light yellowish green", "#c2ff89");

        public static readonly XkcdColour Lightblue = new XkcdColour("lightblue", "#7bc8f6");

        public static readonly XkcdColour LighterGreen = new XkcdColour("lighter green", "#75fd63");

        public static readonly XkcdColour LighterPurple = new XkcdColour("lighter purple", "#a55af4");

        public static readonly XkcdColour Lightgreen = new XkcdColour("lightgreen", "#76ff7b");

        public static readonly XkcdColour LightishBlue = new XkcdColour("lightish blue", "#3d7afd");

        public static readonly XkcdColour LightishGreen = new XkcdColour("lightish green", "#61e160");

        public static readonly XkcdColour LightishPurple = new XkcdColour("lightish purple", "#a552e6");

        public static readonly XkcdColour LightishRed = new XkcdColour("lightish red", "#fe2f4a");

        public static readonly XkcdColour Lilac = new XkcdColour("lilac", "#cea2fd");

        public static readonly XkcdColour Liliac = new XkcdColour("liliac", "#c48efd");

        public static readonly XkcdColour Lime = new XkcdColour("lime", "#aaff32");

        public static readonly XkcdColour LimeGreen = new XkcdColour("lime green", "#89fe05");

        public static readonly XkcdColour LimeYellow = new XkcdColour("lime yellow", "#d0fe1d");

        public static readonly XkcdColour Lipstick = new XkcdColour("lipstick", "#d5174e");

        public static readonly XkcdColour LipstickRed = new XkcdColour("lipstick red", "#c0022f");

        public static readonly XkcdColour MacaroniAndCheese = new XkcdColour("macaroni and cheese", "#efb435");

        public static readonly XkcdColour Magenta = new XkcdColour("magenta", "#c20078");

        public static readonly XkcdColour Mahogany = new XkcdColour("mahogany", "#4a0100");

        public static readonly XkcdColour Maize = new XkcdColour("maize", "#f4d054");

        public static readonly XkcdColour Mango = new XkcdColour("mango", "#ffa62b");

        public static readonly XkcdColour Manilla = new XkcdColour("manilla", "#fffa86");

        public static readonly XkcdColour Marigold = new XkcdColour("marigold", "#fcc006");

        public static readonly XkcdColour Marine = new XkcdColour("marine", "#042e60");

        public static readonly XkcdColour MarineBlue = new XkcdColour("marine blue", "#01386a");

        public static readonly XkcdColour Maroon = new XkcdColour("maroon", "#650021");

        public static readonly XkcdColour Mauve = new XkcdColour("mauve", "#ae7181");

        public static readonly XkcdColour MediumBlue = new XkcdColour("medium blue", "#2c6fbb");

        public static readonly XkcdColour MediumBrown = new XkcdColour("medium brown", "#7f5112");

        public static readonly XkcdColour MediumGreen = new XkcdColour("medium green", "#39ad48");

        public static readonly XkcdColour MediumGrey = new XkcdColour("medium grey", "#7d7f7c");

        public static readonly XkcdColour MediumPink = new XkcdColour("medium pink", "#f36196");

        public static readonly XkcdColour MediumPurple = new XkcdColour("medium purple", "#9e43a2");

        public static readonly XkcdColour Melon = new XkcdColour("melon", "#ff7855");

        public static readonly XkcdColour Merlot = new XkcdColour("merlot", "#730039");

        public static readonly XkcdColour MetallicBlue = new XkcdColour("metallic blue", "#4f738e");

        public static readonly XkcdColour MidBlue = new XkcdColour("mid blue", "#276ab3");

        public static readonly XkcdColour MidGreen = new XkcdColour("mid green", "#50a747");

        public static readonly XkcdColour Midnight = new XkcdColour("midnight", "#03012d");

        public static readonly XkcdColour MidnightBlue = new XkcdColour("midnight blue", "#020035");

        public static readonly XkcdColour MidnightPurple = new XkcdColour("midnight purple", "#280137");

        public static readonly XkcdColour MilitaryGreen = new XkcdColour("military green", "#667c3e");

        public static readonly XkcdColour MilkChocolate = new XkcdColour("milk chocolate", "#7f4e1e");

        public static readonly XkcdColour Mint = new XkcdColour("mint", "#9ffeb0");

        public static readonly XkcdColour MintGreen = new XkcdColour("mint green", "#8fff9f");

        public static readonly XkcdColour MintyGreen = new XkcdColour("minty green", "#0bf77d");

        public static readonly XkcdColour Mocha = new XkcdColour("mocha", "#9d7651");

        public static readonly XkcdColour Moss = new XkcdColour("moss", "#769958");

        public static readonly XkcdColour MossGreen = new XkcdColour("moss green", "#658b38");

        public static readonly XkcdColour MossyGreen = new XkcdColour("mossy green", "#638b27");

        public static readonly XkcdColour Mud = new XkcdColour("mud", "#735c12");

        public static readonly XkcdColour MudBrown = new XkcdColour("mud brown", "#60460f");

        public static readonly XkcdColour MudGreen = new XkcdColour("mud green", "#606602");

        public static readonly XkcdColour MuddyBrown = new XkcdColour("muddy brown", "#886806");

        public static readonly XkcdColour MuddyGreen = new XkcdColour("muddy green", "#657432");

        public static readonly XkcdColour MuddyYellow = new XkcdColour("muddy yellow", "#bfac05");

        public static readonly XkcdColour Mulberry = new XkcdColour("mulberry", "#920a4e");

        public static readonly XkcdColour MurkyGreen = new XkcdColour("murky green", "#6c7a0e");

        public static readonly XkcdColour Mushroom = new XkcdColour("mushroom", "#ba9e88");

        public static readonly XkcdColour Mustard = new XkcdColour("mustard", "#ceb301");

        public static readonly XkcdColour MustardBrown = new XkcdColour("mustard brown", "#ac7e04");

        public static readonly XkcdColour MustardGreen = new XkcdColour("mustard green", "#a8b504");

        public static readonly XkcdColour MustardYellow = new XkcdColour("mustard yellow", "#d2bd0a");

        public static readonly XkcdColour MutedBlue = new XkcdColour("muted blue", "#3b719f");

        public static readonly XkcdColour MutedGreen = new XkcdColour("muted green", "#5fa052");

        public static readonly XkcdColour MutedPink = new XkcdColour("muted pink", "#d1768f");

        public static readonly XkcdColour MutedPurple = new XkcdColour("muted purple", "#805b87");

        public static readonly XkcdColour NastyGreen = new XkcdColour("nasty green", "#70b23f");

        public static readonly XkcdColour Navy = new XkcdColour("navy", "#01153e");

        public static readonly XkcdColour NavyBlue = new XkcdColour("navy blue", "#001146");

        public static readonly XkcdColour NavyGreen = new XkcdColour("navy green", "#35530a");

        public static readonly XkcdColour NeonBlue = new XkcdColour("neon blue", "#04d9ff");

        public static readonly XkcdColour NeonGreen = new XkcdColour("neon green", "#0cff0c");

        public static readonly XkcdColour NeonPink = new XkcdColour("neon pink", "#fe019a");

        public static readonly XkcdColour NeonPurple = new XkcdColour("neon purple", "#bc13fe");

        public static readonly XkcdColour NeonRed = new XkcdColour("neon red", "#ff073a");

        public static readonly XkcdColour NeonYellow = new XkcdColour("neon yellow", "#cfff04");

        public static readonly XkcdColour NiceBlue = new XkcdColour("nice blue", "#107ab0");

        public static readonly XkcdColour NightBlue = new XkcdColour("night blue", "#040348");

        public static readonly XkcdColour Ocean = new XkcdColour("ocean", "#017b92");

        public static readonly XkcdColour OceanBlue = new XkcdColour("ocean blue", "#03719c");

        public static readonly XkcdColour OceanGreen = new XkcdColour("ocean green", "#3d9973");

        public static readonly XkcdColour Ocher = new XkcdColour("ocher", "#bf9b0c");

        public static readonly XkcdColour Ochre = new XkcdColour("ochre", "#bf9005");

        public static readonly XkcdColour Ocre = new XkcdColour("ocre", "#c69c04");

        public static readonly XkcdColour OffBlue = new XkcdColour("off blue", "#5684ae");

        public static readonly XkcdColour OffGreen = new XkcdColour("off green", "#6ba353");

        public static readonly XkcdColour OffWhite = new XkcdColour("off white", "#ffffe4");

        public static readonly XkcdColour OffYellow = new XkcdColour("off yellow", "#f1f33f");

        public static readonly XkcdColour OldPink = new XkcdColour("old pink", "#c77986");

        public static readonly XkcdColour OldRose = new XkcdColour("old rose", "#c87f89");

        public static readonly XkcdColour Olive = new XkcdColour("olive", "#6e750e");

        public static readonly XkcdColour OliveBrown = new XkcdColour("olive brown", "#645403");

        public static readonly XkcdColour OliveDrab = new XkcdColour("olive drab", "#6f7632");

        public static readonly XkcdColour OliveGreen = new XkcdColour("olive green", "#677a04");

        public static readonly XkcdColour OliveYellow = new XkcdColour("olive yellow", "#c2b709");

        public static readonly XkcdColour Orange = new XkcdColour("orange", "#f97306");

        public static readonly XkcdColour OrangeBrown = new XkcdColour("orange brown", "#be6400");

        public static readonly XkcdColour OrangePink = new XkcdColour("orange pink", "#ff6f52");

        public static readonly XkcdColour OrangeRed = new XkcdColour("orange red", "#fd411e");

        public static readonly XkcdColour OrangeYellow = new XkcdColour("orange yellow", "#ffad01");

        public static readonly XkcdColour Orangeish = new XkcdColour("orangeish", "#fd8d49");

        public static readonly XkcdColour Orangered = new XkcdColour("orangered", "#fe420f");

        public static readonly XkcdColour OrangeyBrown = new XkcdColour("orangey brown", "#b16002");

        public static readonly XkcdColour OrangeyRed = new XkcdColour("orangey red", "#fa4224");

        public static readonly XkcdColour OrangeyYellow = new XkcdColour("orangey yellow", "#fdb915");

        public static readonly XkcdColour Orangish = new XkcdColour("orangish", "#fc824a");

        public static readonly XkcdColour OrangishBrown = new XkcdColour("orangish brown", "#b25f03");

        public static readonly XkcdColour OrangishRed = new XkcdColour("orangish red", "#f43605");

        public static readonly XkcdColour Orchid = new XkcdColour("orchid", "#c875c4");

        public static readonly XkcdColour Pale = new XkcdColour("pale", "#fff9d0");

        public static readonly XkcdColour PaleAqua = new XkcdColour("pale aqua", "#b8ffeb");

        public static readonly XkcdColour PaleBlue = new XkcdColour("pale blue", "#d0fefe");

        public static readonly XkcdColour PaleBrown = new XkcdColour("pale brown", "#b1916e");

        public static readonly XkcdColour PaleCyan = new XkcdColour("pale cyan", "#b7fffa");

        public static readonly XkcdColour PaleGold = new XkcdColour("pale gold", "#fdde6c");

        public static readonly XkcdColour PaleGreen = new XkcdColour("pale green", "#c7fdb5");

        public static readonly XkcdColour PaleGrey = new XkcdColour("pale grey", "#fdfdfe");

        public static readonly XkcdColour PaleLavender = new XkcdColour("pale lavender", "#eecffe");

        public static readonly XkcdColour PaleLightGreen = new XkcdColour("pale light green", "#b1fc99");

        public static readonly XkcdColour PaleLilac = new XkcdColour("pale lilac", "#e4cbff");

        public static readonly XkcdColour PaleLime = new XkcdColour("pale lime", "#befd73");

        public static readonly XkcdColour PaleLimeGreen = new XkcdColour("pale lime green", "#b1ff65");

        public static readonly XkcdColour PaleMagenta = new XkcdColour("pale magenta", "#d767ad");

        public static readonly XkcdColour PaleMauve = new XkcdColour("pale mauve", "#fed0fc");

        public static readonly XkcdColour PaleOlive = new XkcdColour("pale olive", "#b9cc81");

        public static readonly XkcdColour PaleOliveGreen = new XkcdColour("pale olive green", "#b1d27b");

        public static readonly XkcdColour PaleOrange = new XkcdColour("pale orange", "#ffa756");

        public static readonly XkcdColour PalePeach = new XkcdColour("pale peach", "#ffe5ad");

        public static readonly XkcdColour PalePink = new XkcdColour("pale pink", "#ffcfdc");

        public static readonly XkcdColour PalePurple = new XkcdColour("pale purple", "#b790d4");

        public static readonly XkcdColour PaleRed = new XkcdColour("pale red", "#d9544d");

        public static readonly XkcdColour PaleRose = new XkcdColour("pale rose", "#fdc1c5");

        public static readonly XkcdColour PaleSalmon = new XkcdColour("pale salmon", "#ffb19a");

        public static readonly XkcdColour PaleSkyBlue = new XkcdColour("pale sky blue", "#bdf6fe");

        public static readonly XkcdColour PaleTeal = new XkcdColour("pale teal", "#82cbb2");

        public static readonly XkcdColour PaleTurquoise = new XkcdColour("pale turquoise", "#a5fbd5");

        public static readonly XkcdColour PaleViolet = new XkcdColour("pale violet", "#ceaefa");

        public static readonly XkcdColour PaleYellow = new XkcdColour("pale yellow", "#ffff84");

        public static readonly XkcdColour Parchment = new XkcdColour("parchment", "#fefcaf");

        public static readonly XkcdColour PastelBlue = new XkcdColour("pastel blue", "#a2bffe");

        public static readonly XkcdColour PastelGreen = new XkcdColour("pastel green", "#b0ff9d");

        public static readonly XkcdColour PastelOrange = new XkcdColour("pastel orange", "#ff964f");

        public static readonly XkcdColour PastelPink = new XkcdColour("pastel pink", "#ffbacd");

        public static readonly XkcdColour PastelPurple = new XkcdColour("pastel purple", "#caa0ff");

        public static readonly XkcdColour PastelRed = new XkcdColour("pastel red", "#db5856");

        public static readonly XkcdColour PastelYellow = new XkcdColour("pastel yellow", "#fffe71");

        public static readonly XkcdColour Pea = new XkcdColour("pea", "#a4bf20");

        public static readonly XkcdColour PeaGreen = new XkcdColour("pea green", "#8eab12");

        public static readonly XkcdColour PeaSoup = new XkcdColour("pea soup", "#929901");

        public static readonly XkcdColour PeaSoupGreen = new XkcdColour("pea soup green", "#94a617");

        public static readonly XkcdColour Peach = new XkcdColour("peach", "#ffb07c");

        public static readonly XkcdColour PeachyPink = new XkcdColour("peachy pink", "#ff9a8a");

        public static readonly XkcdColour PeacockBlue = new XkcdColour("peacock blue", "#016795");

        public static readonly XkcdColour Pear = new XkcdColour("pear", "#cbf85f");

        public static readonly XkcdColour Periwinkle = new XkcdColour("periwinkle", "#8e82fe");

        public static readonly XkcdColour PeriwinkleBlue = new XkcdColour("periwinkle blue", "#8f99fb");

        public static readonly XkcdColour Perrywinkle = new XkcdColour("perrywinkle", "#8f8ce7");

        public static readonly XkcdColour Petrol = new XkcdColour("petrol", "#005f6a");

        public static readonly XkcdColour PigPink = new XkcdColour("pig pink", "#e78ea5");

        public static readonly XkcdColour Pine = new XkcdColour("pine", "#2b5d34");

        public static readonly XkcdColour PineGreen = new XkcdColour("pine green", "#0a481e");

        public static readonly XkcdColour Pink = new XkcdColour("pink", "#ff81c0");

        public static readonly XkcdColour PinkPurple = new XkcdColour("pink purple", "#db4bda");

        public static readonly XkcdColour PinkRed = new XkcdColour("pink red", "#f5054f");

        public static readonly XkcdColour PinkSlashPurple = new XkcdColour("pink/purple", "#ef1de7");

        public static readonly XkcdColour Pinkish = new XkcdColour("pinkish", "#d46a7e");

        public static readonly XkcdColour PinkishBrown = new XkcdColour("pinkish brown", "#b17261");

        public static readonly XkcdColour PinkishGrey = new XkcdColour("pinkish grey", "#c8aca9");

        public static readonly XkcdColour PinkishOrange = new XkcdColour("pinkish orange", "#ff724c");

        public static readonly XkcdColour PinkishPurple = new XkcdColour("pinkish purple", "#d648d7");

        public static readonly XkcdColour PinkishRed = new XkcdColour("pinkish red", "#f10c45");

        public static readonly XkcdColour PinkishTan = new XkcdColour("pinkish tan", "#d99b82");

        public static readonly XkcdColour Pinky = new XkcdColour("pinky", "#fc86aa");

        public static readonly XkcdColour PinkyPurple = new XkcdColour("pinky purple", "#c94cbe");

        public static readonly XkcdColour PinkyRed = new XkcdColour("pinky red", "#fc2647");

        public static readonly XkcdColour PissYellow = new XkcdColour("piss yellow", "#ddd618");

        public static readonly XkcdColour Pistachio = new XkcdColour("pistachio", "#c0fa8b");

        public static readonly XkcdColour Plum = new XkcdColour("plum", "#580f41");

        public static readonly XkcdColour PlumPurple = new XkcdColour("plum purple", "#4e0550");

        public static readonly XkcdColour PoisonGreen = new XkcdColour("poison green", "#40fd14");

        public static readonly XkcdColour Poo = new XkcdColour("poo", "#8f7303");

        public static readonly XkcdColour PooBrown = new XkcdColour("poo brown", "#885f01");

        public static readonly XkcdColour Poop = new XkcdColour("poop", "#7f5e00");

        public static readonly XkcdColour PoopBrown = new XkcdColour("poop brown", "#7a5901");

        public static readonly XkcdColour PoopGreen = new XkcdColour("poop green", "#6f7c00");

        public static readonly XkcdColour PowderBlue = new XkcdColour("powder blue", "#b1d1fc");

        public static readonly XkcdColour PowderPink = new XkcdColour("powder pink", "#ffb2d0");

        public static readonly XkcdColour PrimaryBlue = new XkcdColour("primary blue", "#0804f9");

        public static readonly XkcdColour PrussianBlue = new XkcdColour("prussian blue", "#004577");

        public static readonly XkcdColour Puce = new XkcdColour("puce", "#a57e52");

        public static readonly XkcdColour Puke = new XkcdColour("puke", "#a5a502");

        public static readonly XkcdColour PukeBrown = new XkcdColour("puke brown", "#947706");

        public static readonly XkcdColour PukeGreen = new XkcdColour("puke green", "#9aae07");

        public static readonly XkcdColour PukeYellow = new XkcdColour("puke yellow", "#c2be0e");

        public static readonly XkcdColour Pumpkin = new XkcdColour("pumpkin", "#e17701");

        public static readonly XkcdColour PumpkinOrange = new XkcdColour("pumpkin orange", "#fb7d07");

        public static readonly XkcdColour PureBlue = new XkcdColour("pure blue", "#0203e2");

        public static readonly XkcdColour Purple = new XkcdColour("purple", "#7e1e9c");

        public static readonly XkcdColour PurpleBlue = new XkcdColour("purple blue", "#632de9");

        public static readonly XkcdColour PurpleBrown = new XkcdColour("purple brown", "#673a3f");

        public static readonly XkcdColour PurpleGrey = new XkcdColour("purple grey", "#866f85");

        public static readonly XkcdColour PurplePink = new XkcdColour("purple pink", "#e03fd8");

        public static readonly XkcdColour PurpleRed = new XkcdColour("purple red", "#990147");

        public static readonly XkcdColour PurpleSlashBlue = new XkcdColour("purple/blue", "#5d21d0");

        public static readonly XkcdColour PurpleSlashPink = new XkcdColour("purple/pink", "#d725de");

        public static readonly XkcdColour Purpleish = new XkcdColour("purpleish", "#98568d");

        public static readonly XkcdColour PurpleishBlue = new XkcdColour("purpleish blue", "#6140ef");

        public static readonly XkcdColour PurpleishPink = new XkcdColour("purpleish pink", "#df4ec8");

        public static readonly XkcdColour Purpley = new XkcdColour("purpley", "#8756e4");

        public static readonly XkcdColour PurpleyBlue = new XkcdColour("purpley blue", "#5f34e7");

        public static readonly XkcdColour PurpleyGrey = new XkcdColour("purpley grey", "#947e94");

        public static readonly XkcdColour PurpleyPink = new XkcdColour("purpley pink", "#c83cb9");

        public static readonly XkcdColour Purplish = new XkcdColour("purplish", "#94568c");

        public static readonly XkcdColour PurplishBlue = new XkcdColour("purplish blue", "#601ef9");

        public static readonly XkcdColour PurplishBrown = new XkcdColour("purplish brown", "#6b4247");

        public static readonly XkcdColour PurplishGrey = new XkcdColour("purplish grey", "#7a687f");

        public static readonly XkcdColour PurplishPink = new XkcdColour("purplish pink", "#ce5dae");

        public static readonly XkcdColour PurplishRed = new XkcdColour("purplish red", "#b0054b");

        public static readonly XkcdColour Purply = new XkcdColour("purply", "#983fb2");

        public static readonly XkcdColour PurplyBlue = new XkcdColour("purply blue", "#661aee");

        public static readonly XkcdColour PurplyPink = new XkcdColour("purply pink", "#f075e6");

        public static readonly XkcdColour Putty = new XkcdColour("putty", "#beae8a");

        public static readonly XkcdColour RacingGreen = new XkcdColour("racing green", "#014600");

        public static readonly XkcdColour RadioactiveGreen = new XkcdColour("radioactive green", "#2cfa1f");

        public static readonly XkcdColour Raspberry = new XkcdColour("raspberry", "#b00149");

        public static readonly XkcdColour RawSienna = new XkcdColour("raw sienna", "#9a6200");

        public static readonly XkcdColour RawUmber = new XkcdColour("raw umber", "#a75e09");

        public static readonly XkcdColour ReallyLightBlue = new XkcdColour("really light blue", "#d4ffff");

        public static readonly XkcdColour Red = new XkcdColour("red", "#e50000");

        public static readonly XkcdColour RedBrown = new XkcdColour("red brown", "#8b2e16");

        public static readonly XkcdColour RedOrange = new XkcdColour("red orange", "#fd3c06");

        public static readonly XkcdColour RedPink = new XkcdColour("red pink", "#fa2a55");

        public static readonly XkcdColour RedPurple = new XkcdColour("red purple", "#820747");

        public static readonly XkcdColour RedViolet = new XkcdColour("red violet", "#9e0168");

        public static readonly XkcdColour RedWine = new XkcdColour("red wine", "#8c0034");

        public static readonly XkcdColour Reddish = new XkcdColour("reddish", "#c44240");

        public static readonly XkcdColour ReddishBrown = new XkcdColour("reddish brown", "#7f2b0a");

        public static readonly XkcdColour ReddishGrey = new XkcdColour("reddish grey", "#997570");

        public static readonly XkcdColour ReddishOrange = new XkcdColour("reddish orange", "#f8481c");

        public static readonly XkcdColour ReddishPink = new XkcdColour("reddish pink", "#fe2c54");

        public static readonly XkcdColour ReddishPurple = new XkcdColour("reddish purple", "#910951");

        public static readonly XkcdColour ReddyBrown = new XkcdColour("reddy brown", "#6e1005");

        public static readonly XkcdColour RichBlue = new XkcdColour("rich blue", "#021bf9");

        public static readonly XkcdColour RichPurple = new XkcdColour("rich purple", "#720058");

        public static readonly XkcdColour RobinEggBlue = new XkcdColour("robin egg blue", "#8af1fe");

        public static readonly XkcdColour RobinsEgg = new XkcdColour("robin's egg", "#6dedfd");

        public static readonly XkcdColour RobinsEggBlue = new XkcdColour("robin's egg blue", "#98eff9");

        public static readonly XkcdColour Rosa = new XkcdColour("rosa", "#fe86a4");

        public static readonly XkcdColour Rose = new XkcdColour("rose", "#cf6275");

        public static readonly XkcdColour RosePink = new XkcdColour("rose pink", "#f7879a");

        public static readonly XkcdColour RoseRed = new XkcdColour("rose red", "#be013c");

        public static readonly XkcdColour RosyPink = new XkcdColour("rosy pink", "#f6688e");

        public static readonly XkcdColour Rouge = new XkcdColour("rouge", "#ab1239");

        public static readonly XkcdColour Royal = new XkcdColour("royal", "#0c1793");

        public static readonly XkcdColour RoyalBlue = new XkcdColour("royal blue", "#0504aa");

        public static readonly XkcdColour RoyalPurple = new XkcdColour("royal purple", "#4b006e");

        public static readonly XkcdColour Ruby = new XkcdColour("ruby", "#ca0147");

        public static readonly XkcdColour Russet = new XkcdColour("russet", "#a13905");

        public static readonly XkcdColour Rust = new XkcdColour("rust", "#a83c09");

        public static readonly XkcdColour RustBrown = new XkcdColour("rust brown", "#8b3103");

        public static readonly XkcdColour RustOrange = new XkcdColour("rust orange", "#c45508");

        public static readonly XkcdColour RustRed = new XkcdColour("rust red", "#aa2704");

        public static readonly XkcdColour RustyOrange = new XkcdColour("rusty orange", "#cd5909");

        public static readonly XkcdColour RustyRed = new XkcdColour("rusty red", "#af2f0d");

        public static readonly XkcdColour Saffron = new XkcdColour("saffron", "#feb209");

        public static readonly XkcdColour Sage = new XkcdColour("sage", "#87ae73");

        public static readonly XkcdColour SageGreen = new XkcdColour("sage green", "#88b378");

        public static readonly XkcdColour Salmon = new XkcdColour("salmon", "#ff796c");

        public static readonly XkcdColour SalmonPink = new XkcdColour("salmon pink", "#fe7b7c");

        public static readonly XkcdColour Sand = new XkcdColour("sand", "#e2ca76");

        public static readonly XkcdColour SandBrown = new XkcdColour("sand brown", "#cba560");

        public static readonly XkcdColour SandYellow = new XkcdColour("sand yellow", "#fce166");

        public static readonly XkcdColour Sandstone = new XkcdColour("sandstone", "#c9ae74");

        public static readonly XkcdColour Sandy = new XkcdColour("sandy", "#f1da7a");

        public static readonly XkcdColour SandyBrown = new XkcdColour("sandy brown", "#c4a661");

        public static readonly XkcdColour SandyYellow = new XkcdColour("sandy yellow", "#fdee73");

        public static readonly XkcdColour SapGreen = new XkcdColour("sap green", "#5c8b15");

        public static readonly XkcdColour Sapphire = new XkcdColour("sapphire", "#2138ab");

        public static readonly XkcdColour Scarlet = new XkcdColour("scarlet", "#be0119");

        public static readonly XkcdColour Sea = new XkcdColour("sea", "#3c9992");

        public static readonly XkcdColour SeaBlue = new XkcdColour("sea blue", "#047495");

        public static readonly XkcdColour SeaGreen = new XkcdColour("sea green", "#53fca1");

        public static readonly XkcdColour Seafoam = new XkcdColour("seafoam", "#80f9ad");

        public static readonly XkcdColour SeafoamBlue = new XkcdColour("seafoam blue", "#78d1b6");

        public static readonly XkcdColour SeafoamGreen = new XkcdColour("seafoam green", "#7af9ab");

        public static readonly XkcdColour Seaweed = new XkcdColour("seaweed", "#18d17b");

        public static readonly XkcdColour SeaweedGreen = new XkcdColour("seaweed green", "#35ad6b");

        public static readonly XkcdColour Sepia = new XkcdColour("sepia", "#985e2b");

        public static readonly XkcdColour Shamrock = new XkcdColour("shamrock", "#01b44c");

        public static readonly XkcdColour ShamrockGreen = new XkcdColour("shamrock green", "#02c14d");

        public static readonly XkcdColour Shit = new XkcdColour("shit", "#7f5f00");

        public static readonly XkcdColour ShitBrown = new XkcdColour("shit brown", "#7b5804");

        public static readonly XkcdColour ShitGreen = new XkcdColour("shit green", "#758000");

        public static readonly XkcdColour ShockingPink = new XkcdColour("shocking pink", "#fe02a2");

        public static readonly XkcdColour SickGreen = new XkcdColour("sick green", "#9db92c");

        public static readonly XkcdColour SicklyGreen = new XkcdColour("sickly green", "#94b21c");

        public static readonly XkcdColour SicklyYellow = new XkcdColour("sickly yellow", "#d0e429");

        public static readonly XkcdColour Sienna = new XkcdColour("sienna", "#a9561e");

        public static readonly XkcdColour Silver = new XkcdColour("silver", "#c5c9c7");

        public static readonly XkcdColour Sky = new XkcdColour("sky", "#82cafc");

        public static readonly XkcdColour SkyBlue = new XkcdColour("sky blue", "#75bbfd");

        public static readonly XkcdColour Slate = new XkcdColour("slate", "#516572");

        public static readonly XkcdColour SlateBlue = new XkcdColour("slate blue", "#5b7c99");

        public static readonly XkcdColour SlateGreen = new XkcdColour("slate green", "#658d6d");

        public static readonly XkcdColour SlateGrey = new XkcdColour("slate grey", "#59656d");

        public static readonly XkcdColour SlimeGreen = new XkcdColour("slime green", "#99cc04");

        public static readonly XkcdColour Snot = new XkcdColour("snot", "#acbb0d");

        public static readonly XkcdColour SnotGreen = new XkcdColour("snot green", "#9dc100");

        public static readonly XkcdColour SoftBlue = new XkcdColour("soft blue", "#6488ea");

        public static readonly XkcdColour SoftGreen = new XkcdColour("soft green", "#6fc276");

        public static readonly XkcdColour SoftPink = new XkcdColour("soft pink", "#fdb0c0");

        public static readonly XkcdColour SoftPurple = new XkcdColour("soft purple", "#a66fb5");

        public static readonly XkcdColour Spearmint = new XkcdColour("spearmint", "#1ef876");

        public static readonly XkcdColour SpringGreen = new XkcdColour("spring green", "#a9f971");

        public static readonly XkcdColour Spruce = new XkcdColour("spruce", "#0a5f38");

        public static readonly XkcdColour Squash = new XkcdColour("squash", "#f2ab15");

        public static readonly XkcdColour Steel = new XkcdColour("steel", "#738595");

        public static readonly XkcdColour SteelBlue = new XkcdColour("steel blue", "#5a7d9a");

        public static readonly XkcdColour SteelGrey = new XkcdColour("steel grey", "#6f828a");

        public static readonly XkcdColour Stone = new XkcdColour("stone", "#ada587");

        public static readonly XkcdColour StormyBlue = new XkcdColour("stormy blue", "#507b9c");

        public static readonly XkcdColour Straw = new XkcdColour("straw", "#fcf679");

        public static readonly XkcdColour Strawberry = new XkcdColour("strawberry", "#fb2943");

        public static readonly XkcdColour StrongBlue = new XkcdColour("strong blue", "#0c06f7");

        public static readonly XkcdColour StrongPink = new XkcdColour("strong pink", "#ff0789");

        public static readonly XkcdColour SunYellow = new XkcdColour("sun yellow", "#ffdf22");

        public static readonly XkcdColour Sunflower = new XkcdColour("sunflower", "#ffc512");

        public static readonly XkcdColour SunflowerYellow = new XkcdColour("sunflower yellow", "#ffda03");

        public static readonly XkcdColour SunnyYellow = new XkcdColour("sunny yellow", "#fff917");

        public static readonly XkcdColour SunshineYellow = new XkcdColour("sunshine yellow", "#fffd37");

        public static readonly XkcdColour Swamp = new XkcdColour("swamp", "#698339");

        public static readonly XkcdColour SwampGreen = new XkcdColour("swamp green", "#748500");

        public static readonly XkcdColour Tan = new XkcdColour("tan", "#d1b26f");

        public static readonly XkcdColour TanBrown = new XkcdColour("tan brown", "#ab7e4c");

        public static readonly XkcdColour TanGreen = new XkcdColour("tan green", "#a9be70");

        public static readonly XkcdColour Tangerine = new XkcdColour("tangerine", "#ff9408");

        public static readonly XkcdColour Taupe = new XkcdColour("taupe", "#b9a281");

        public static readonly XkcdColour Tea = new XkcdColour("tea", "#65ab7c");

        public static readonly XkcdColour TeaGreen = new XkcdColour("tea green", "#bdf8a3");

        public static readonly XkcdColour Teal = new XkcdColour("teal", "#029386");

        public static readonly XkcdColour TealBlue = new XkcdColour("teal blue", "#01889f");

        public static readonly XkcdColour TealGreen = new XkcdColour("teal green", "#25a36f");

        public static readonly XkcdColour Tealish = new XkcdColour("tealish", "#24bca8");

        public static readonly XkcdColour TealishGreen = new XkcdColour("tealish green", "#0cdc73");

        public static readonly XkcdColour TerraCotta = new XkcdColour("terra cotta", "#c9643b");

        public static readonly XkcdColour Terracota = new XkcdColour("terracota", "#cb6843");

        public static readonly XkcdColour Terracotta = new XkcdColour("terracotta", "#ca6641");

        public static readonly XkcdColour TiffanyBlue = new XkcdColour("tiffany blue", "#7bf2da");

        public static readonly XkcdColour Tomato = new XkcdColour("tomato", "#ef4026");

        public static readonly XkcdColour TomatoRed = new XkcdColour("tomato red", "#ec2d01");

        public static readonly XkcdColour Topaz = new XkcdColour("topaz", "#13bbaf");

        public static readonly XkcdColour Toupe = new XkcdColour("toupe", "#c7ac7d");

        public static readonly XkcdColour ToxicGreen = new XkcdColour("toxic green", "#61de2a");

        public static readonly XkcdColour TreeGreen = new XkcdColour("tree green", "#2a7e19");

        public static readonly XkcdColour TrueBlue = new XkcdColour("true blue", "#010fcc");

        public static readonly XkcdColour TrueGreen = new XkcdColour("true green", "#089404");

        public static readonly XkcdColour Turquoise = new XkcdColour("turquoise", "#06c2ac");

        public static readonly XkcdColour TurquoiseBlue = new XkcdColour("turquoise blue", "#06b1c4");

        public static readonly XkcdColour TurquoiseGreen = new XkcdColour("turquoise green", "#04f489");

        public static readonly XkcdColour TurtleGreen = new XkcdColour("turtle green", "#75b84f");

        public static readonly XkcdColour Twilight = new XkcdColour("twilight", "#4e518b");

        public static readonly XkcdColour TwilightBlue = new XkcdColour("twilight blue", "#0a437a");

        public static readonly XkcdColour UglyBlue = new XkcdColour("ugly blue", "#31668a");

        public static readonly XkcdColour UglyBrown = new XkcdColour("ugly brown", "#7d7103");

        public static readonly XkcdColour UglyGreen = new XkcdColour("ugly green", "#7a9703");

        public static readonly XkcdColour UglyPink = new XkcdColour("ugly pink", "#cd7584");

        public static readonly XkcdColour UglyPurple = new XkcdColour("ugly purple", "#a442a0");

        public static readonly XkcdColour UglyYellow = new XkcdColour("ugly yellow", "#d0c101");

        public static readonly XkcdColour Ultramarine = new XkcdColour("ultramarine", "#2000b1");

        public static readonly XkcdColour UltramarineBlue = new XkcdColour("ultramarine blue", "#1805db");

        public static readonly XkcdColour Umber = new XkcdColour("umber", "#b26400");

        public static readonly XkcdColour Velvet = new XkcdColour("velvet", "#750851");

        public static readonly XkcdColour Vermillion = new XkcdColour("vermillion", "#f4320c");

        public static readonly XkcdColour VeryDarkBlue = new XkcdColour("very dark blue", "#000133");

        public static readonly XkcdColour VeryDarkBrown = new XkcdColour("very dark brown", "#1d0200");

        public static readonly XkcdColour VeryDarkGreen = new XkcdColour("very dark green", "#062e03");

        public static readonly XkcdColour VeryDarkPurple = new XkcdColour("very dark purple", "#2a0134");

        public static readonly XkcdColour VeryLightBlue = new XkcdColour("very light blue", "#d5ffff");

        public static readonly XkcdColour VeryLightBrown = new XkcdColour("very light brown", "#d3b683");

        public static readonly XkcdColour VeryLightGreen = new XkcdColour("very light green", "#d1ffbd");

        public static readonly XkcdColour VeryLightPink = new XkcdColour("very light pink", "#fff4f2");

        public static readonly XkcdColour VeryLightPurple = new XkcdColour("very light purple", "#f6cefc");

        public static readonly XkcdColour VeryPaleBlue = new XkcdColour("very pale blue", "#d6fffe");

        public static readonly XkcdColour VeryPaleGreen = new XkcdColour("very pale green", "#cffdbc");

        public static readonly XkcdColour VibrantBlue = new XkcdColour("vibrant blue", "#0339f8");

        public static readonly XkcdColour VibrantGreen = new XkcdColour("vibrant green", "#0add08");

        public static readonly XkcdColour VibrantPurple = new XkcdColour("vibrant purple", "#ad03de");

        public static readonly XkcdColour Violet = new XkcdColour("violet", "#9a0eea");

        public static readonly XkcdColour VioletBlue = new XkcdColour("violet blue", "#510ac9");

        public static readonly XkcdColour VioletPink = new XkcdColour("violet pink", "#fb5ffc");

        public static readonly XkcdColour VioletRed = new XkcdColour("violet red", "#a50055");

        public static readonly XkcdColour Viridian = new XkcdColour("viridian", "#1e9167");

        public static readonly XkcdColour VividBlue = new XkcdColour("vivid blue", "#152eff");

        public static readonly XkcdColour VividGreen = new XkcdColour("vivid green", "#2fef10");

        public static readonly XkcdColour VividPurple = new XkcdColour("vivid purple", "#9900fa");

        public static readonly XkcdColour Vomit = new XkcdColour("vomit", "#a2a415");

        public static readonly XkcdColour VomitGreen = new XkcdColour("vomit green", "#89a203");

        public static readonly XkcdColour VomitYellow = new XkcdColour("vomit yellow", "#c7c10c");

        public static readonly XkcdColour WarmBlue = new XkcdColour("warm blue", "#4b57db");

        public static readonly XkcdColour WarmBrown = new XkcdColour("warm brown", "#964e02");

        public static readonly XkcdColour WarmGrey = new XkcdColour("warm grey", "#978a84");

        public static readonly XkcdColour WarmPink = new XkcdColour("warm pink", "#fb5581");

        public static readonly XkcdColour WarmPurple = new XkcdColour("warm purple", "#952e8f");

        public static readonly XkcdColour WashedOutGreen = new XkcdColour("washed out green", "#bcf5a6");

        public static readonly XkcdColour WaterBlue = new XkcdColour("water blue", "#0e87cc");

        public static readonly XkcdColour Watermelon = new XkcdColour("watermelon", "#fd4659");

        public static readonly XkcdColour WeirdGreen = new XkcdColour("weird green", "#3ae57f");

        public static readonly XkcdColour Wheat = new XkcdColour("wheat", "#fbdd7e");

        public static readonly XkcdColour White = new XkcdColour("white", "#ffffff");

        public static readonly XkcdColour WindowsBlue = new XkcdColour("windows blue", "#3778bf");

        public static readonly XkcdColour Wine = new XkcdColour("wine", "#80013f");

        public static readonly XkcdColour WineRed = new XkcdColour("wine red", "#7b0323");

        public static readonly XkcdColour Wintergreen = new XkcdColour("wintergreen", "#20f986");

        public static readonly XkcdColour Wisteria = new XkcdColour("wisteria", "#a87dc2");

        public static readonly XkcdColour Yellow = new XkcdColour("yellow", "#ffff14");

        public static readonly XkcdColour YellowBrown = new XkcdColour("yellow brown", "#b79400");

        public static readonly XkcdColour YellowGreen = new XkcdColour("yellow green", "#c0fb2d");

        public static readonly XkcdColour YellowOchre = new XkcdColour("yellow ochre", "#cb9d06");

        public static readonly XkcdColour YellowOrange = new XkcdColour("yellow orange", "#fcb001");

        public static readonly XkcdColour YellowTan = new XkcdColour("yellow tan", "#ffe36e");

        public static readonly XkcdColour YellowSlashGreen = new XkcdColour("yellow/green", "#c8fd3d");

        public static readonly XkcdColour Yellowgreen = new XkcdColour("yellowgreen", "#bbf90f");

        public static readonly XkcdColour Yellowish = new XkcdColour("yellowish", "#faee66");

        public static readonly XkcdColour YellowishBrown = new XkcdColour("yellowish brown", "#9b7a01");

        public static readonly XkcdColour YellowishGreen = new XkcdColour("yellowish green", "#b0dd16");

        public static readonly XkcdColour YellowishOrange = new XkcdColour("yellowish orange", "#ffab0f");

        public static readonly XkcdColour YellowishTan = new XkcdColour("yellowish tan", "#fcfc81");

        public static readonly XkcdColour YellowyBrown = new XkcdColour("yellowy brown", "#ae8b0c");

        public static readonly XkcdColour YellowyGreen = new XkcdColour("yellowy green", "#bff128");

        #endregion

        #region  all colours enumerable
        public static readonly ISet<XkcdColour> AllColours = new HashSet<XkcdColour>
        {
            AcidGreen,
            Adobe,
            Algae,
            AlgaeGreen,
            AlmostBlack,
            Amber,
            Amethyst,
            Apple,
            AppleGreen,
            Apricot,
            Aqua,
            AquaBlue,
            AquaGreen,
            AquaMarine,
            Aquamarine,
            ArmyGreen,
            Asparagus,
            Aubergine,
            Auburn,
            Avocado,
            AvocadoGreen,
            Azul,
            Azure,
            BabyBlue,
            BabyGreen,
            BabyPink,
            BabyPoo,
            BabyPoop,
            BabyPoopGreen,
            BabyPukeGreen,
            BabyPurple,
            BabyShitBrown,
            BabyShitGreen,
            Banana,
            BananaYellow,
            BarbiePink,
            BarfGreen,
            Barney,
            BarneyPurple,
            BattleshipGrey,
            Beige,
            Berry,
            Bile,
            Black,
            Bland,
            Blood,
            BloodOrange,
            BloodRed,
            Blue,
            BlueBlue,
            BlueGreen,
            BlueGrey,
            BluePurple,
            BlueViolet,
            BlueWithAHintOfPurple,
            BlueSlashGreen,
            BlueSlashGrey,
            BlueSlashPurple,
            Blueberry,
            Bluegreen,
            Bluegrey,
            BlueyGreen,
            BlueyGrey,
            BlueyPurple,
            Bluish,
            BluishGreen,
            BluishGrey,
            BluishPurple,
            Blurple,
            Blush,
            BlushPink,
            Booger,
            BoogerGreen,
            Bordeaux,
            BoringGreen,
            BottleGreen,
            Brick,
            BrickOrange,
            BrickRed,
            BrightAqua,
            BrightBlue,
            BrightCyan,
            BrightGreen,
            BrightLavender,
            BrightLightBlue,
            BrightLightGreen,
            BrightLilac,
            BrightLime,
            BrightLimeGreen,
            BrightMagenta,
            BrightOlive,
            BrightOrange,
            BrightPink,
            BrightPurple,
            BrightRed,
            BrightSeaGreen,
            BrightSkyBlue,
            BrightTeal,
            BrightTurquoise,
            BrightViolet,
            BrightYellow,
            BrightYellowGreen,
            BritishRacingGreen,
            Bronze,
            Brown,
            BrownGreen,
            BrownGrey,
            BrownOrange,
            BrownRed,
            BrownYellow,
            Brownish,
            BrownishGreen,
            BrownishGrey,
            BrownishOrange,
            BrownishPink,
            BrownishPurple,
            BrownishRed,
            BrownishYellow,
            BrownyGreen,
            BrownyOrange,
            Bruise,
            BubbleGumPink,
            Bubblegum,
            BubblegumPink,
            Buff,
            Burgundy,
            BurntOrange,
            BurntRed,
            BurntSiena,
            BurntSienna,
            BurntUmber,
            BurntYellow,
            Burple,
            Butter,
            ButterYellow,
            Butterscotch,
            CadetBlue,
            Camel,
            Camo,
            CamoGreen,
            CamouflageGreen,
            Canary,
            CanaryYellow,
            CandyPink,
            Caramel,
            Carmine,
            Carnation,
            CarnationPink,
            CarolinaBlue,
            Celadon,
            Celery,
            Cement,
            Cerise,
            Cerulean,
            CeruleanBlue,
            Charcoal,
            CharcoalGrey,
            Chartreuse,
            Cherry,
            CherryRed,
            Chestnut,
            Chocolate,
            ChocolateBrown,
            Cinnamon,
            Claret,
            Clay,
            ClayBrown,
            ClearBlue,
            CloudyBlue,
            Cobalt,
            CobaltBlue,
            Cocoa,
            Coffee,
            CoolBlue,
            CoolGreen,
            CoolGrey,
            Copper,
            Coral,
            CoralPink,
            Cornflower,
            CornflowerBlue,
            Cranberry,
            Cream,
            Creme,
            Crimson,
            Custard,
            Cyan,
            Dandelion,
            Dark,
            DarkAqua,
            DarkAquamarine,
            DarkBeige,
            DarkBlue,
            DarkBlueGreen,
            DarkBlueGrey,
            DarkBrown,
            DarkCoral,
            DarkCream,
            DarkCyan,
            DarkForestGreen,
            DarkFuchsia,
            DarkGold,
            DarkGrassGreen,
            DarkGreen,
            DarkGreenBlue,
            DarkGrey,
            DarkGreyBlue,
            DarkHotPink,
            DarkIndigo,
            DarkKhaki,
            DarkLavender,
            DarkLilac,
            DarkLime,
            DarkLimeGreen,
            DarkMagenta,
            DarkMaroon,
            DarkMauve,
            DarkMint,
            DarkMintGreen,
            DarkMustard,
            DarkNavy,
            DarkNavyBlue,
            DarkOlive,
            DarkOliveGreen,
            DarkOrange,
            DarkPastelGreen,
            DarkPeach,
            DarkPeriwinkle,
            DarkPink,
            DarkPlum,
            DarkPurple,
            DarkRed,
            DarkRose,
            DarkRoyalBlue,
            DarkSage,
            DarkSalmon,
            DarkSand,
            DarkSeaGreen,
            DarkSeafoam,
            DarkSeafoamGreen,
            DarkSkyBlue,
            DarkSlateBlue,
            DarkTan,
            DarkTaupe,
            DarkTeal,
            DarkTurquoise,
            DarkViolet,
            DarkYellow,
            DarkYellowGreen,
            Darkblue,
            Darkgreen,
            DarkishBlue,
            DarkishGreen,
            DarkishPink,
            DarkishPurple,
            DarkishRed,
            DeepAqua,
            DeepBlue,
            DeepBrown,
            DeepGreen,
            DeepLavender,
            DeepLilac,
            DeepMagenta,
            DeepOrange,
            DeepPink,
            DeepPurple,
            DeepRed,
            DeepRose,
            DeepSeaBlue,
            DeepSkyBlue,
            DeepTeal,
            DeepTurquoise,
            DeepViolet,
            Denim,
            DenimBlue,
            Desert,
            Diarrhea,
            Dirt,
            DirtBrown,
            DirtyBlue,
            DirtyGreen,
            DirtyOrange,
            DirtyPink,
            DirtyPurple,
            DirtyYellow,
            DodgerBlue,
            Drab,
            DrabGreen,
            DriedBlood,
            DuckEggBlue,
            DullBlue,
            DullBrown,
            DullGreen,
            DullOrange,
            DullPink,
            DullPurple,
            DullRed,
            DullTeal,
            DullYellow,
            Dusk,
            DuskBlue,
            DuskyBlue,
            DuskyPink,
            DuskyPurple,
            DuskyRose,
            Dust,
            DustyBlue,
            DustyGreen,
            DustyLavender,
            DustyOrange,
            DustyPink,
            DustyPurple,
            DustyRed,
            DustyRose,
            DustyTeal,
            Earth,
            EasterGreen,
            EasterPurple,
            Ecru,
            EggShell,
            Eggplant,
            EggplantPurple,
            Eggshell,
            EggshellBlue,
            ElectricBlue,
            ElectricGreen,
            ElectricLime,
            ElectricPink,
            ElectricPurple,
            Emerald,
            EmeraldGreen,
            Evergreen,
            FadedBlue,
            FadedGreen,
            FadedOrange,
            FadedPink,
            FadedPurple,
            FadedRed,
            FadedYellow,
            Fawn,
            Fern,
            FernGreen,
            FireEngineRed,
            FlatBlue,
            FlatGreen,
            FluorescentGreen,
            FluroGreen,
            FoamGreen,
            Forest,
            ForestGreen,
            ForrestGreen,
            FrenchBlue,
            FreshGreen,
            FrogGreen,
            Fuchsia,
            Gold,
            Golden,
            GoldenBrown,
            GoldenRod,
            GoldenYellow,
            Goldenrod,
            Grape,
            GrapePurple,
            Grapefruit,
            Grass,
            GrassGreen,
            GrassyGreen,
            Green,
            GreenApple,
            GreenBlue,
            GreenBrown,
            GreenGrey,
            GreenTeal,
            GreenYellow,
            GreenSlashBlue,
            GreenSlashYellow,
            Greenblue,
            Greenish,
            GreenishBeige,
            GreenishBlue,
            GreenishBrown,
            GreenishCyan,
            GreenishGrey,
            GreenishTan,
            GreenishTeal,
            GreenishTurquoise,
            GreenishYellow,
            GreenyBlue,
            GreenyBrown,
            GreenyGrey,
            GreenyYellow,
            Grey,
            GreyBlue,
            GreyBrown,
            GreyGreen,
            GreyPink,
            GreyPurple,
            GreyTeal,
            GreySlashBlue,
            GreySlashGreen,
            Greyblue,
            Greyish,
            GreyishBlue,
            GreyishBrown,
            GreyishGreen,
            GreyishPink,
            GreyishPurple,
            GreyishTeal,
            GrossGreen,
            Gunmetal,
            Hazel,
            Heather,
            Heliotrope,
            HighlighterGreen,
            HospitalGreen,
            HotGreen,
            HotMagenta,
            HotPink,
            HotPurple,
            HunterGreen,
            Ice,
            IceBlue,
            IckyGreen,
            IndianRed,
            Indigo,
            IndigoBlue,
            Iris,
            IrishGreen,
            Ivory,
            Jade,
            JadeGreen,
            JungleGreen,
            KelleyGreen,
            KellyGreen,
            KermitGreen,
            KeyLime,
            Khaki,
            KhakiGreen,
            Kiwi,
            KiwiGreen,
            Lavender,
            LavenderBlue,
            LavenderPink,
            LawnGreen,
            Leaf,
            LeafGreen,
            LeafyGreen,
            Leather,
            Lemon,
            LemonGreen,
            LemonLime,
            LemonYellow,
            Lichen,
            LightAqua,
            LightAquamarine,
            LightBeige,
            LightBlue,
            LightBlueGreen,
            LightBlueGrey,
            LightBluishGreen,
            LightBrightGreen,
            LightBrown,
            LightBurgundy,
            LightCyan,
            LightEggplant,
            LightForestGreen,
            LightGold,
            LightGrassGreen,
            LightGreen,
            LightGreenBlue,
            LightGreenishBlue,
            LightGrey,
            LightGreyBlue,
            LightGreyGreen,
            LightIndigo,
            LightKhaki,
            LightLavendar,
            LightLavender,
            LightLightBlue,
            LightLightGreen,
            LightLilac,
            LightLime,
            LightLimeGreen,
            LightMagenta,
            LightMaroon,
            LightMauve,
            LightMint,
            LightMintGreen,
            LightMossGreen,
            LightMustard,
            LightNavy,
            LightNavyBlue,
            LightNeonGreen,
            LightOlive,
            LightOliveGreen,
            LightOrange,
            LightPastelGreen,
            LightPeaGreen,
            LightPeach,
            LightPeriwinkle,
            LightPink,
            LightPlum,
            LightPurple,
            LightRed,
            LightRose,
            LightRoyalBlue,
            LightSage,
            LightSalmon,
            LightSeaGreen,
            LightSeafoam,
            LightSeafoamGreen,
            LightSkyBlue,
            LightTan,
            LightTeal,
            LightTurquoise,
            LightUrple,
            LightViolet,
            LightYellow,
            LightYellowGreen,
            LightYellowishGreen,
            Lightblue,
            LighterGreen,
            LighterPurple,
            Lightgreen,
            LightishBlue,
            LightishGreen,
            LightishPurple,
            LightishRed,
            Lilac,
            Liliac,
            Lime,
            LimeGreen,
            LimeYellow,
            Lipstick,
            LipstickRed,
            MacaroniAndCheese,
            Magenta,
            Mahogany,
            Maize,
            Mango,
            Manilla,
            Marigold,
            Marine,
            MarineBlue,
            Maroon,
            Mauve,
            MediumBlue,
            MediumBrown,
            MediumGreen,
            MediumGrey,
            MediumPink,
            MediumPurple,
            Melon,
            Merlot,
            MetallicBlue,
            MidBlue,
            MidGreen,
            Midnight,
            MidnightBlue,
            MidnightPurple,
            MilitaryGreen,
            MilkChocolate,
            Mint,
            MintGreen,
            MintyGreen,
            Mocha,
            Moss,
            MossGreen,
            MossyGreen,
            Mud,
            MudBrown,
            MudGreen,
            MuddyBrown,
            MuddyGreen,
            MuddyYellow,
            Mulberry,
            MurkyGreen,
            Mushroom,
            Mustard,
            MustardBrown,
            MustardGreen,
            MustardYellow,
            MutedBlue,
            MutedGreen,
            MutedPink,
            MutedPurple,
            NastyGreen,
            Navy,
            NavyBlue,
            NavyGreen,
            NeonBlue,
            NeonGreen,
            NeonPink,
            NeonPurple,
            NeonRed,
            NeonYellow,
            NiceBlue,
            NightBlue,
            Ocean,
            OceanBlue,
            OceanGreen,
            Ocher,
            Ochre,
            Ocre,
            OffBlue,
            OffGreen,
            OffWhite,
            OffYellow,
            OldPink,
            OldRose,
            Olive,
            OliveBrown,
            OliveDrab,
            OliveGreen,
            OliveYellow,
            Orange,
            OrangeBrown,
            OrangePink,
            OrangeRed,
            OrangeYellow,
            Orangeish,
            Orangered,
            OrangeyBrown,
            OrangeyRed,
            OrangeyYellow,
            Orangish,
            OrangishBrown,
            OrangishRed,
            Orchid,
            Pale,
            PaleAqua,
            PaleBlue,
            PaleBrown,
            PaleCyan,
            PaleGold,
            PaleGreen,
            PaleGrey,
            PaleLavender,
            PaleLightGreen,
            PaleLilac,
            PaleLime,
            PaleLimeGreen,
            PaleMagenta,
            PaleMauve,
            PaleOlive,
            PaleOliveGreen,
            PaleOrange,
            PalePeach,
            PalePink,
            PalePurple,
            PaleRed,
            PaleRose,
            PaleSalmon,
            PaleSkyBlue,
            PaleTeal,
            PaleTurquoise,
            PaleViolet,
            PaleYellow,
            Parchment,
            PastelBlue,
            PastelGreen,
            PastelOrange,
            PastelPink,
            PastelPurple,
            PastelRed,
            PastelYellow,
            Pea,
            PeaGreen,
            PeaSoup,
            PeaSoupGreen,
            Peach,
            PeachyPink,
            PeacockBlue,
            Pear,
            Periwinkle,
            PeriwinkleBlue,
            Perrywinkle,
            Petrol,
            PigPink,
            Pine,
            PineGreen,
            Pink,
            PinkPurple,
            PinkRed,
            PinkSlashPurple,
            Pinkish,
            PinkishBrown,
            PinkishGrey,
            PinkishOrange,
            PinkishPurple,
            PinkishRed,
            PinkishTan,
            Pinky,
            PinkyPurple,
            PinkyRed,
            PissYellow,
            Pistachio,
            Plum,
            PlumPurple,
            PoisonGreen,
            Poo,
            PooBrown,
            Poop,
            PoopBrown,
            PoopGreen,
            PowderBlue,
            PowderPink,
            PrimaryBlue,
            PrussianBlue,
            Puce,
            Puke,
            PukeBrown,
            PukeGreen,
            PukeYellow,
            Pumpkin,
            PumpkinOrange,
            PureBlue,
            Purple,
            PurpleBlue,
            PurpleBrown,
            PurpleGrey,
            PurplePink,
            PurpleRed,
            PurpleSlashBlue,
            PurpleSlashPink,
            Purpleish,
            PurpleishBlue,
            PurpleishPink,
            Purpley,
            PurpleyBlue,
            PurpleyGrey,
            PurpleyPink,
            Purplish,
            PurplishBlue,
            PurplishBrown,
            PurplishGrey,
            PurplishPink,
            PurplishRed,
            Purply,
            PurplyBlue,
            PurplyPink,
            Putty,
            RacingGreen,
            RadioactiveGreen,
            Raspberry,
            RawSienna,
            RawUmber,
            ReallyLightBlue,
            Red,
            RedBrown,
            RedOrange,
            RedPink,
            RedPurple,
            RedViolet,
            RedWine,
            Reddish,
            ReddishBrown,
            ReddishGrey,
            ReddishOrange,
            ReddishPink,
            ReddishPurple,
            ReddyBrown,
            RichBlue,
            RichPurple,
            RobinEggBlue,
            RobinsEgg,
            RobinsEggBlue,
            Rosa,
            Rose,
            RosePink,
            RoseRed,
            RosyPink,
            Rouge,
            Royal,
            RoyalBlue,
            RoyalPurple,
            Ruby,
            Russet,
            Rust,
            RustBrown,
            RustOrange,
            RustRed,
            RustyOrange,
            RustyRed,
            Saffron,
            Sage,
            SageGreen,
            Salmon,
            SalmonPink,
            Sand,
            SandBrown,
            SandYellow,
            Sandstone,
            Sandy,
            SandyBrown,
            SandyYellow,
            SapGreen,
            Sapphire,
            Scarlet,
            Sea,
            SeaBlue,
            SeaGreen,
            Seafoam,
            SeafoamBlue,
            SeafoamGreen,
            Seaweed,
            SeaweedGreen,
            Sepia,
            Shamrock,
            ShamrockGreen,
            Shit,
            ShitBrown,
            ShitGreen,
            ShockingPink,
            SickGreen,
            SicklyGreen,
            SicklyYellow,
            Sienna,
            Silver,
            Sky,
            SkyBlue,
            Slate,
            SlateBlue,
            SlateGreen,
            SlateGrey,
            SlimeGreen,
            Snot,
            SnotGreen,
            SoftBlue,
            SoftGreen,
            SoftPink,
            SoftPurple,
            Spearmint,
            SpringGreen,
            Spruce,
            Squash,
            Steel,
            SteelBlue,
            SteelGrey,
            Stone,
            StormyBlue,
            Straw,
            Strawberry,
            StrongBlue,
            StrongPink,
            SunYellow,
            Sunflower,
            SunflowerYellow,
            SunnyYellow,
            SunshineYellow,
            Swamp,
            SwampGreen,
            Tan,
            TanBrown,
            TanGreen,
            Tangerine,
            Taupe,
            Tea,
            TeaGreen,
            Teal,
            TealBlue,
            TealGreen,
            Tealish,
            TealishGreen,
            TerraCotta,
            Terracota,
            Terracotta,
            TiffanyBlue,
            Tomato,
            TomatoRed,
            Topaz,
            Toupe,
            ToxicGreen,
            TreeGreen,
            TrueBlue,
            TrueGreen,
            Turquoise,
            TurquoiseBlue,
            TurquoiseGreen,
            TurtleGreen,
            Twilight,
            TwilightBlue,
            UglyBlue,
            UglyBrown,
            UglyGreen,
            UglyPink,
            UglyPurple,
            UglyYellow,
            Ultramarine,
            UltramarineBlue,
            Umber,
            Velvet,
            Vermillion,
            VeryDarkBlue,
            VeryDarkBrown,
            VeryDarkGreen,
            VeryDarkPurple,
            VeryLightBlue,
            VeryLightBrown,
            VeryLightGreen,
            VeryLightPink,
            VeryLightPurple,
            VeryPaleBlue,
            VeryPaleGreen,
            VibrantBlue,
            VibrantGreen,
            VibrantPurple,
            Violet,
            VioletBlue,
            VioletPink,
            VioletRed,
            Viridian,
            VividBlue,
            VividGreen,
            VividPurple,
            Vomit,
            VomitGreen,
            VomitYellow,
            WarmBlue,
            WarmBrown,
            WarmGrey,
            WarmPink,
            WarmPurple,
            WashedOutGreen,
            WaterBlue,
            Watermelon,
            WeirdGreen,
            Wheat,
            White,
            WindowsBlue,
            Wine,
            WineRed,
            Wintergreen,
            Wisteria,
            Yellow,
            YellowBrown,
            YellowGreen,
            YellowOchre,
            YellowOrange,
            YellowTan,
            YellowSlashGreen,
            Yellowgreen,
            Yellowish,
            YellowishBrown,
            YellowishGreen,
            YellowishOrange,
            YellowishTan,
            YellowyBrown,
            YellowyGreen,
        };
        #endregion
    }
}

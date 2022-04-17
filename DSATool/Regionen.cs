using DSATool.Pflanzen;
using System.Collections;

namespace DSATool.Regionen
{
    public abstract class BasisRegion
    {
        private string m_Name = "";
        private readonly ArrayList m_Tiere = new();
        private readonly ArrayList m_Pflanzen = new();
        private readonly ArrayList m_Landschaften = new();
        private int m_EssbarePflanzen;
        private int m_Wildvorkommen;

        public string Name
        {
            get { return m_Name; }
            init { m_Name = value; }
        }

        public ArrayList Tiere
        {
            get { return m_Tiere; }
        }

        public ArrayList Pflanzen
        {
            get { return m_Pflanzen; }
        }

        public ArrayList Landschaften
        {
            get { return m_Landschaften; }
        }

        public int EssbarePflanzen
        {
            get { return m_EssbarePflanzen; }
            init { m_EssbarePflanzen = value; }
        }

        public int Wildvorkommen
        {
            get { return m_Wildvorkommen; }
            init { m_Wildvorkommen = value; }
        }
    }

    public static class Utility
    {
        private static readonly ArrayList regionen = new();
        private static readonly Dictionary<string, BasisRegion> region_by_name = new();

        public static ArrayList Regionen
        {
            get { return ArrayList.ReadOnly(regionen); }
        }

        public static BasisRegion FindRegionByName(string name)
        {
            return region_by_name[name];
        }

        static Utility()
        {
            regionen.Add(new RegionEwigesEis());
            regionen.Add(new RegionNoerdlicheTundra());
            regionen.Add(new RegionNoerdlicheGraslaenderUndSteppen());
            regionen.Add(new RegionNoerdlichesHochland());
            regionen.Add(new RegionKalkgebirge());
            regionen.Add(new RegionAndereMittellaendischeGebirge());
            regionen.Add(new RegionNoerdlicheWaelderWestkueste());
            regionen.Add(new RegionNoerdlicheWaelderTaiga());
            regionen.Add(new RegionNoerdlicheWaelderBornland());
            regionen.Add(new RegionNoerdlicheSuempfeMarschenMoore());
            regionen.Add(new RegionMittellaendischeGraslaenderHeideSteppe());
            regionen.Add(new RegionMittellaendischeWaelderGemaesigt());
            regionen.Add(new RegionMittellaendischeWaelderYaquir());
            regionen.Add(new RegionMittellaendischeWaelderTobrisch());
            regionen.Add(new RegionImmgergrueneWaelderSuedosten());
            regionen.Add(new RegionSuedlaendischeGraslaenderSteppen());
            regionen.Add(new RegionWuestenrandgebiete());
            regionen.Add(new RegionWueste());
            regionen.Add(new RegionSuedlaendischeGebirge());
            regionen.Add(new RegionMaraskan());
            regionen.Add(new RegionSuedlicheSuempfe());
            regionen.Add(new RegionRegenwald());
            regionen.Add(new RegionSuedlicheRegengebirge());
            regionen.Add(new RegionIfirnsOzean());
            regionen.Add(new RegionMeerSiebenWinde());
            regionen.Add(new RegionSuedmeer());
            regionen.Add(new RegionPerlenmeer());

            foreach (BasisRegion region in regionen)
            {
                region_by_name.Add(region.Name, region);
            }
        }
    }

    public class VerbreitungsElementTiere
    {
        private string m_tier = "";
        private int m_vorkommen;

        public VerbreitungsElementTiere(string t, int v)
        {
            Tier = t;
            Vorkommen = v;
        }

        public string Tier
        {
            get { return m_tier; }
            init { m_tier = value; }
        }

        public int Vorkommen
        {
            get { return m_vorkommen; }
            init { m_vorkommen = value; }
        }
    }

    public class RegionEwigesEis : BasisRegion
    {
        public RegionEwigesEis()
        {
            Name = "Ewiges Eis";
            EssbarePflanzen = (int)EVorkommen.KEINE;
            Wildvorkommen = (int)EVorkommen.SEHRSELTEN;

            Landschaften.Add("Eis");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Rattenpilz");

            Tiere.Add(new VerbreitungsElementTiere(("Felsrobbe"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Firnyak"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Firnluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Firunsbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Mammut"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Mastodon"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Meerkalb"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schneedachs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Seetiger"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionNoerdlicheTundra : BasisRegion
    {
        public RegionNoerdlicheTundra()
        {
            Name = "Nördliche Tundra";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Eis");
            Landschaften.Add("Steppe");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Bunter Mohn");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Wirselkraut");

            Tiere.Add(new VerbreitungsElementTiere(("Felsrobbe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Karen"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Elch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Firnluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Firnyak"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Schneedachs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Blaufuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Firunsbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Mammut"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Mastodon"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Meerkalb"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Seetiger"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Steppenhund"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Steppentiger"), (int)EVorkommen.SEHRSELTEN));

        }
    }

    public class RegionNoerdlicheGraslaenderUndSteppen : BasisRegion
    {
        public RegionNoerdlicheGraslaenderUndSteppen()
        {
            Name = "Nördliche Grasländer und Steppen";
            EssbarePflanzen = (int)EVorkommen.GELEGENTLICH;
            Wildvorkommen = (int)EVorkommen.GELEGENTLICH;

            Landschaften.Add("Hochland");
            Landschaften.Add("Steppe");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Donf");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Grüne Schleimschlange");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Klippenzahn");
            Pflanzen.Add("Madablüte");
            Pflanzen.Add("Messergras");
            Pflanzen.Add("Bunter Mohn");
            Pflanzen.Add("Naftanstaude");
            Pflanzen.Add("Orklandbovist");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Tigermohn");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Karen"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Steppenhund"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gelbfuchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Elch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Firunshirsch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Klippechse"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Schneedachs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Steppenrind"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Trappe"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Blaufuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Borkenbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Firnluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Halmar-Antilope"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Mammut"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Orklandbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Steppentiger"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Vielfraß"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionNoerdlichesHochland : BasisRegion
    {
        public RegionNoerdlichesHochland()
        {
            Name = "Nördliches Hochland";
            EssbarePflanzen = (int)EVorkommen.GELEGENTLICH;
            Wildvorkommen = (int)EVorkommen.GELEGENTLICH;

            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Basilamine");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Grüne Schleimschlange");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Klippenzahn");
            Pflanzen.Add("Messergras");
            Pflanzen.Add("Bunter Mohn");
            Pflanzen.Add("Naftanstaude");
            Pflanzen.Add("Orklandbovist");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Orklandkarnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gelbfuchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Halmar-Antilope"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Trappe"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Klippechse"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Orklandbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schreckkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Borkenbär"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Mammut"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Steppentiger"), (int)EVorkommen.SEHRSELTEN));

        }
    }

    public class RegionKalkgebirge : BasisRegion
    {
        public RegionKalkgebirge()
        {
            Name = "Kalkgebirge";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");
            Landschaften.Add("Höhle (feucht)");
            Landschaften.Add("Höhle (trocken)");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Atan-Kiefer");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Feuermoos und Efferdmoos");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Madablüte");
            Pflanzen.Add("Bleichmohn (Weißer Mohn)");
            Pflanzen.Add("Grauer Mohn");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Phosphorpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zwölfblatt");
            Pflanzen.Add("Dergolasch");
            Pflanzen.Add("Felsenmilch");
            Pflanzen.Add("Grüner Schleimpilz");
            Pflanzen.Add("Lichtnebler");
            Pflanzen.Add("Steinrinde");
            Pflanzen.Add("Wandermoos");

            Tiere.Add(new VerbreitungsElementTiere(("Gebirgsbock"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Berglöwe"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Höhlenbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionAndereMittellaendischeGebirge : BasisRegion
    {
        public RegionAndereMittellaendischeGebirge()
        {
            Name = "Andere Mittelländische Gebirge";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");
            Landschaften.Add("Höhle (feucht)");
            Landschaften.Add("Höhle (trocken)");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Feuermoos und Efferdmoos");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Madablüte");
            Pflanzen.Add("Bleichmohn (Weißer Mohn)");
            Pflanzen.Add("Grauer Mohn");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Phosphorpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Schleimiger Sumpfknöterich");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zwölfblatt");
            Pflanzen.Add("Dergolasch");
            Pflanzen.Add("Felsenmilch");
            Pflanzen.Add("Grüner Schleimpilz");
            Pflanzen.Add("Lichtnebler");
            Pflanzen.Add("Steinrinde");
            Pflanzen.Add("Wandermoos");

            Tiere.Add(new VerbreitungsElementTiere(("Gebirgsbock"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenlöffler"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Berglöwe"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Höhlenbär"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionNoerdlicheWaelderWestkueste : BasisRegion
    {
        public RegionNoerdlicheWaelderWestkueste()
        {
            Name = "Nördliche Wälder (Westküste)";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.HAEUFIG;

            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Basilamine");
            Pflanzen.Add("Belmart");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Carlog");
            Pflanzen.Add("Efeuer");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Hollbeere");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Klippenzahn");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Orklandbovist");
            Pflanzen.Add("Pestsporenpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Ulmenwürger");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Auerhahn"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Streifendachs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Kronenhirsch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Blaufuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Borkenbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Vielfraß"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Waldlöwe"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Höhlenbär"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberlöwe"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionNoerdlicheWaelderTaiga : BasisRegion
    {
        public RegionNoerdlicheWaelderTaiga()
        {
            Name = "Nördliche Wälder (Taiga)";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.SEHRHAEUFIG;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Belmart");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Efeuer");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Pestsporenpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schleimiger Sumpfknöterich");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Ulmenwürger");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Elch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Schneedachs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Blaufuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Firunshirsch"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Karen"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Kronenhirsch"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schwarzbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Grimmbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Streifendachs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Vielfraß"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Waldlöwe"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Borkenbär"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberlöwe"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionNoerdlicheWaelderBornland : BasisRegion
    {
        public RegionNoerdlicheWaelderBornland()
        {
            Name = "Nördliche Wälder (Bornland)";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.SEHRHAEUFIG;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Belmart");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Efeuer");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Pestsporenpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schleimiger Sumpfknöterich");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Ulmenwürger");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wasserrausch");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Silberbock"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Blaufuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Elch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Kronenhirsch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Streifendachs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Sumpfranze"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Firunshirsch"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Höhlenbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schneedachs"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schwarzbär"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Grimmbär"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Vielfraß"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Waldlöwe"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionNoerdlicheSuempfeMarschenMoore : BasisRegion
    {
        public RegionNoerdlicheSuempfeMarschenMoore()
        {
            Name = "Nördliche Sümpfe, Marschen und Moore";
            EssbarePflanzen = (int)EVorkommen.GELEGENTLICH;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Sumpf und Moor");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Carlog");
            Pflanzen.Add("Donf");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Grüne Schleimschlange");
            Pflanzen.Add("Iribaarslilie");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Morgendornstrauch");
            Pflanzen.Add("Neckerkraut");
            Pflanzen.Add("Pestsporenpilz");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Schleimiger Sumpfknöterich");
            Pflanzen.Add("Schlinggras");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zwölfblatt");
            Pflanzen.Add("Braunschlinge");
            Pflanzen.Add("Libellengras");
            Pflanzen.Add("Seelenhauch");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Klippechse"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Sumpfranze"), (int)EVorkommen.GELEGENTLICH));
        }
    }

    public class RegionMittellaendischeGraslaenderHeideSteppe : BasisRegion
    {
        public RegionMittellaendischeGraslaenderHeideSteppe()
        {
            Name = "Mittelländische Grasländer, Heide und Steppe";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.HAEUFIG;

            Landschaften.Add("Steppe");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Donf");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Hiradwurz");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Färberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Weißer Lotus");
            Pflanzen.Add("Weißgelber Lotus");
            Pflanzen.Add("Lulanie");
            Pflanzen.Add("Messergras");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Mirbelstein");
            Pflanzen.Add("Bunter Mohn");
            Pflanzen.Add("Purpurmohn");
            Pflanzen.Add("Schwarzer Mohn");
            Pflanzen.Add("Tigermohn");
            Pflanzen.Add("Naftanstaude");
            Pflanzen.Add("Neckerkraut");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Schlangenzünglein");
            Pflanzen.Add("Schwarmschwamm");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Winselgras");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zwölfblatt");
            Pflanzen.Add("Braunschlinge");
            Pflanzen.Add("Libellengras");
            Pflanzen.Add("Seelenhauch");

            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gänseluchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Trappe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Ente"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Gelbfuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Gabelantilope"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Steppentiger"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionMittellaendischeWaelderGemaesigt : BasisRegion
    {
        public RegionMittellaendischeWaelderGemaesigt()
        {
            Name = "Mittelländische Wälder (Gemäßigtes Klima)";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.HAEUFIG;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Belmart");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Carlog");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Efeuer");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Färberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Weißer Lotus");
            Pflanzen.Add("Weißgelber Lotus");
            Pflanzen.Add("Lulanie");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Mirbelstein");
            Pflanzen.Add("Neckerkraut");
            Pflanzen.Add("Quasselwurz");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schleimiger Sumpfknöterich");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Ulmenwürger");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenlöffler"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gänseluchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Auerhahn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Kronenhirsch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Streifendachs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Höhlenbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schwarzbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Grimmbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberbock"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberlöwe"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionMittellaendischeWaelderYaquir : BasisRegion
    {
        public RegionMittellaendischeWaelderYaquir()
        {
            Name = "Mittelländische Wälder (Yaquirisches Klima)";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.HAEUFIG;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Arganstrauch");
            Pflanzen.Add("Belmart");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Boronsschlinge");
            Pflanzen.Add("Carlog");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Efeuer");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Färberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Weißer Lotus");
            Pflanzen.Add("Weißgelber Lotus");
            Pflanzen.Add("Lulanie");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Purpurmohn");
            Pflanzen.Add("Schwarzer Mohn");
            Pflanzen.Add("Neckerkraut");
            Pflanzen.Add("Quasselwurz");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Ulmenwürger");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenlöffler"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gänseluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Regenbogenfasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Baumbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Streifendachs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Süßmauldachs"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionMittellaendischeWaelderTobrisch : BasisRegion
    {
        public RegionMittellaendischeWaelderTobrisch()
        {
            Name = "Mittelländische Wälder (Tobrisches Klima)";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.GELEGENTLICH;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Belmart");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Efeuer");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Mirbelstein");
            Pflanzen.Add("Purpurmohn");
            Pflanzen.Add("Quasselwurz");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schwarmschwamm");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Tuur-Amash-Kelch");
            Pflanzen.Add("Ulmenwürger");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wasserrausch");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenlöffler"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Auerhahn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionImmgergrueneWaelderSuedosten : BasisRegion
    {
        public RegionImmgergrueneWaelderSuedosten()
        {
            Name = "Immergrüne Wälder (Südosten)";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.HAEUFIG;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Dornrose");
            Pflanzen.Add("Efeuer");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Färberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Weißer Lotus");
            Pflanzen.Add("Weißgelber Lotus");
            Pflanzen.Add("Purpurmohn");
            Pflanzen.Add("Quasselwurz");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schwarzer Wein");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenlöffler"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Auerhahn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Ongalobulle"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Regenbogenfasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Warzenschwein"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Al'Kebir-Antilope"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumbär"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Springbock"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Moosaffe"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionSuedlaendischeGraslaenderSteppen : BasisRegion
    {
        public RegionSuedlaendischeGraslaenderSteppen()
        {
            Name = "Südländische Grasländer und Steppen";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.GELEGENTLICH;

            Landschaften.Add("Wüste und Wüstenrand");
            Landschaften.Add("Steppe");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Atmon");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Dornrose");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Finage");
            Pflanzen.Add("Hiradwurz");
            Pflanzen.Add("Jagdgras");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Khôm- oder Mhanadiknolle");
            Pflanzen.Add("Menchal-Kaktus");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Messergras");
            Pflanzen.Add("Mirbelstein");
            Pflanzen.Add("Bunter Mohn");
            Pflanzen.Add("Purpurmohn");
            Pflanzen.Add("Naftanstaude");
            Pflanzen.Add("Olginwurz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Schlangenzünglein");
            Pflanzen.Add("Schwarzer Wein");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Winselgras");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Yaganstrauch");
            Pflanzen.Add("Zithabar");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Al'Kebir-Antilope"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gabelantilope"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Springbock"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Khômgepard"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Ongalobulle"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Strauß"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Warzenschwein"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Gelbfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Regenbogenfasan"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sandlöwe"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Süßmauldachs"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionWuestenrandgebiete : BasisRegion
    {
        public RegionWuestenrandgebiete()
        {
            Name = "Wüstenrandgebiete";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Wüste und Wüstenrand");
            Landschaften.Add("Steppe");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Atmon");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Cheria-Kaktus");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Finage");
            Pflanzen.Add("Hiradwurz");
            Pflanzen.Add("Khôm- oder Mhanadiknolle");
            Pflanzen.Add("Menchal-Kaktus");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Messergras");
            Pflanzen.Add("Purpurmohn");
            Pflanzen.Add("Naftanstaude");
            Pflanzen.Add("Olginwurz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Winselgras");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Gabelantilope"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Springbock"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Al'Kebir-Antilope"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Khômgepard"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sandlöwe"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Strauß"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionWueste : BasisRegion
    {
        public RegionWueste()
        {
            Name = "Wüste";
            EssbarePflanzen = (int)EVorkommen.SEHRSELTEN;
            Wildvorkommen = (int)EVorkommen.SEHRSELTEN;

            Landschaften.Add("Wüste und Wüstenrand");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Cheria-Kaktus");
            Pflanzen.Add("Khôm- oder Mhanadiknolle");
            Pflanzen.Add("Menchal-Kaktus");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Talaschin");

            Tiere.Add(new VerbreitungsElementTiere(("Sandlöwe"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionSuedlaendischeGebirge : BasisRegion
    {
        public RegionSuedlaendischeGebirge()
        {
            Name = "Südländische Gebirge";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Atmon");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Bleichmohn (Weißer Mohn)");
            Pflanzen.Add("Olginwurz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Wirselkraut");

            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.HAEUFIG));
        }
    }

    public class RegionMaraskan : BasisRegion
    {
        public RegionMaraskan()
        {
            Name = "Maraskan";
            EssbarePflanzen = (int)EVorkommen.GELEGENTLICH;
            Wildvorkommen = (int)EVorkommen.HAEUFIG;

            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Sumpf und Moor");
            Landschaften.Add("Regenwald");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Axorda-Baum");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Disdychonda");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Horusche");
            Pflanzen.Add("Jagdgras");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Rauschgurke");
            Pflanzen.Add("Schlangenzünglein");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnblatt");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Trichterwurzel");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Yaganstrauch");

            Tiere.Add(new VerbreitungsElementTiere(("Riesenlöffler"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Otan-Otan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotpüschel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Vy'Tagga-Antilope"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Maraskanisches Stachelschwein"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumschleimer"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumwürger"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Totenkopfäffchen"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionSuedlicheSuempfe : BasisRegion
    {
        public RegionSuedlicheSuempfe()
        {
            Name = "Südliche Sümpfe";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Küste, Strand");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Sumpf und Moor");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Arganstrauch");
            Pflanzen.Add("Atmon");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Carlog");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Disdychonda");
            Pflanzen.Add("Donf");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Iribaarslilie");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Kajubo");
            Pflanzen.Add("Färberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Weißer Lotus");
            Pflanzen.Add("Weißgelber Lotus");
            Pflanzen.Add("Mirhamer Seidenliane");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Rote Pfeilblüte");
            Pflanzen.Add("Sansaro");
            Pflanzen.Add("Schleichender Tod");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zwölfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Sumpfranze"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionRegenwald : BasisRegion
    {
        public RegionRegenwald()
        {
            Name = "Regenwald";
            EssbarePflanzen = (int)EVorkommen.SEHRHAEUFIG;
            Wildvorkommen = (int)EVorkommen.SEHRHAEUFIG;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Küste, Strand");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Regenwald");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Arganstrauch");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Boronie");
            Pflanzen.Add("Boronsschlinge");
            Pflanzen.Add("Carlog");
            Pflanzen.Add("Cheria-Kaktus");
            Pflanzen.Add("Disdychonda");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Finage");
            Pflanzen.Add("Höllenkraut");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Kajubo");
            Pflanzen.Add("Kukuka");
            Pflanzen.Add("Färberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Weißer Lotus");
            Pflanzen.Add("Weißgelber Lotus");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Mirhamer Seidenliane");
            Pflanzen.Add("Orazal");
            Pflanzen.Add("Quinja");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Rote Pfeilblüte");
            Pflanzen.Add("Schleichender Tod");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Würgedattel");
            Pflanzen.Add("Zunderschwamm");

            Tiere.Add(new VerbreitungsElementTiere(("Moosaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Otan-Otan"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Brüllaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Boronsäffchen"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Zuckeraffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Zirkusaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Löwenaffe"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Purzelaffe"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Fleckenpanther"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Jaguar"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Zwergelefant"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Brabaker Waldelefant"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Dschungeltiger"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Lioma"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
        }
    }


    public class RegionSuedlicheRegengebirge : BasisRegion
    {
        public RegionSuedlicheRegengebirge()
        {
            Name = "Südliche Regengebirge";
            EssbarePflanzen = (int)EVorkommen.GELEGENTLICH;
            Wildvorkommen = (int)EVorkommen.GELEGENTLICH;

            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Regenwald");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");
            Landschaften.Add("Höhle (feucht)");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Atmon");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Feuermoos und Efferdmoos");
            Pflanzen.Add("Finage");
            Pflanzen.Add("Höllenkraut");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Kukuka");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Mirhamer Seidenliane");
            Pflanzen.Add("Bleichmohn (Weißer Mohn)");
            Pflanzen.Add("Grauer Mohn");
            Pflanzen.Add("Orazal");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Schleichender Tod");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Dergolasch");
            Pflanzen.Add("Felsenmilch");
            Pflanzen.Add("Grüner Schleimpilz");
            Pflanzen.Add("Steinrinde");
            Pflanzen.Add("Wandermoos");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Löwenaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Boronsäffchen"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Zuckeraffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Purzelaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Moosaffe"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Otan-Otan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Fleckenpanther"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Jaguar"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Dschungeltiger"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionIfirnsOzean : BasisRegion
    {
        public RegionIfirnsOzean()
        {
            Name = "Ifirns Ozean";
            EssbarePflanzen = (int)EVorkommen.KEINE;
            Wildvorkommen = (int)EVorkommen.KEINE;

            Landschaften.Add("Meer");
        }
    }

    public class RegionMeerSiebenWinde : BasisRegion
    {
        public RegionMeerSiebenWinde()
        {
            Name = "Meer der Sieben Winde";
            EssbarePflanzen = (int)EVorkommen.KEINE;
            Wildvorkommen = (int)EVorkommen.KEINE;

            Landschaften.Add("Meer");
        }
    }

    public class RegionSuedmeer : BasisRegion
    {
        public RegionSuedmeer()
        {
            Name = "Südmeer (Feuermeer)";
            EssbarePflanzen = (int)EVorkommen.KEINE;
            Wildvorkommen = (int)EVorkommen.KEINE;

            Landschaften.Add("Meer");
        }
    }

    public class RegionPerlenmeer : BasisRegion
    {
        public RegionPerlenmeer()
        {
            Name = "Perlenmeer";
            EssbarePflanzen = (int)EVorkommen.KEINE;
            Wildvorkommen = (int)EVorkommen.KEINE;

            Landschaften.Add("Meer");

            Pflanzen.Add("Feuerschlick");
            Pflanzen.Add("Sansaro");
        }
    }

    #region Musterregion
    public class RegionMuster : BasisRegion
    {
        public RegionMuster()
        {
            Name = "Musterregion";
            EssbarePflanzen = (int)EVorkommen.KEINE;
            Wildvorkommen = (int)EVorkommen.KEINE;

            Landschaften.Add("Eis");
            Landschaften.Add("Wüste und Wüstenrand");
            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Steppe");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Küste, Strand");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Sumpf und Moor");
            Landschaften.Add("Regenwald");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");
            Landschaften.Add("Meer");
            Landschaften.Add("Höhle (feucht)");
            Landschaften.Add("Höhle (trocken)");

            Pflanzen.Add("Alraune");
            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Arganstrauch");
            Pflanzen.Add("Atan-Kiefer");
            Pflanzen.Add("Atmon");
            Pflanzen.Add("Axorda-Baum");
            Pflanzen.Add("Basilamine");
            Pflanzen.Add("Belmart");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Boronie");
            Pflanzen.Add("Boronsschlinge");
            Pflanzen.Add("Carlog");
            Pflanzen.Add("Cheria-Kaktus");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Disdychonda");
            Pflanzen.Add("Donf");
            Pflanzen.Add("Dornrose");
            Pflanzen.Add("Efeuer");
            Pflanzen.Add("Egelschreck");
            Pflanzen.Add("Eitriger Krötenschemel");
            Pflanzen.Add("Feuermoos und Efferdmoos");
            Pflanzen.Add("Feuerschlick");
            Pflanzen.Add("Finage");
            Pflanzen.Add("Grüne Schleimschlange");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Hiradwurz");
            Pflanzen.Add("Höllenkraut");
            Pflanzen.Add("Hollbeere");
            Pflanzen.Add("Horusche");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Iribaarslilie");
            Pflanzen.Add("Jagdgras");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Kajubo");
            Pflanzen.Add("Khôm- oder Mhanadiknolle");
            Pflanzen.Add("Klippenzahn");
            Pflanzen.Add("Kukuka");
            Pflanzen.Add("Färberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Weißer Lotus");
            Pflanzen.Add("Weißgelber Lotus");
            Pflanzen.Add("Lulanie");
            Pflanzen.Add("Madablüte");
            Pflanzen.Add("Menchal-Kaktus");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Messergras");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Mirbelstein");
            Pflanzen.Add("Mirhamer Seidenliane");
            Pflanzen.Add("Bleichmohn (Weißer Mohn)");
            Pflanzen.Add("Bunter Mohn");
            Pflanzen.Add("Grauer Mohn");
            Pflanzen.Add("Purpurmohn");
            Pflanzen.Add("Schwarzer Mohn");
            Pflanzen.Add("Tigermohn");
            Pflanzen.Add("Morgendornstrauch");
            Pflanzen.Add("Naftanstaude");
            Pflanzen.Add("Neckerkraut");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Olginwurz");
            Pflanzen.Add("Orazal");
            Pflanzen.Add("Orklandbovist");
            Pflanzen.Add("Pestsporenpilz");
            Pflanzen.Add("Phosphorpilz");
            Pflanzen.Add("Quasselwurz");
            Pflanzen.Add("Quinja");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Rauschgurke");
            Pflanzen.Add("Rote Pfeilblüte");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Sansaro");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schlangenzünglein");
            Pflanzen.Add("Schleichender Tod");
            Pflanzen.Add("Schleimiger Sumpfknöterich");
            Pflanzen.Add("Schlinggras");
            Pflanzen.Add("Schwarmschwamm");
            Pflanzen.Add("Schwarzer Wein");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnblatt");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Trichterwurzel");
            Pflanzen.Add("Tuur-Amash-Kelch");
            Pflanzen.Add("Ulmenwürger");
            Pflanzen.Add("Vierblättrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wasserrausch");
            Pflanzen.Add("Winselgras");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Würgedattel");
            Pflanzen.Add("Yaganstrauch");
            Pflanzen.Add("Zithabar");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zwölfblatt");

            /*
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            this.Tiere.Add(new VerbreitungsElementTiere((""), (int)EVorkommen.));
            */
        }
    }
    #endregion
}


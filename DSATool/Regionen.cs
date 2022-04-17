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
            Tiere.Add(new VerbreitungsElementTiere(("Firunsb�r"), (int)EVorkommen.SELTEN));
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
            Name = "N�rdliche Tundra";
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
            Pflanzen.Add("Vierbl�ttrige Einbeere");
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
            Tiere.Add(new VerbreitungsElementTiere(("Firunsb�r"), (int)EVorkommen.SELTEN));
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
            Name = "N�rdliche Grasl�nder und Steppen";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Gr�ne Schleimschlange");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Klippenzahn");
            Pflanzen.Add("Madabl�te");
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
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zw�lfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Karen"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Steppenhund"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gelbfuchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Elch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Firunshirsch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Klippechse"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Schneedachs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Steppenrind"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Trappe"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Blaufuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Borkenb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Firnluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Halmar-Antilope"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Mammut"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Orklandb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Steppentiger"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Vielfra�"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionNoerdlichesHochland : BasisRegion
    {
        public RegionNoerdlichesHochland()
        {
            Name = "N�rdliches Hochland";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Gr�ne Schleimschlange");
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
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zw�lfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Orklandkarnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gelbfuchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Halmar-Antilope"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Trappe"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Klippechse"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Orklandb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schreckkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Borkenb�r"), (int)EVorkommen.SEHRSELTEN));
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
            Landschaften.Add("H�hle (feucht)");
            Landschaften.Add("H�hle (trocken)");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Atan-Kiefer");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Feuermoos und Efferdmoos");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Madabl�te");
            Pflanzen.Add("Bleichmohn (Wei�er Mohn)");
            Pflanzen.Add("Grauer Mohn");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Phosphorpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zw�lfblatt");
            Pflanzen.Add("Dergolasch");
            Pflanzen.Add("Felsenmilch");
            Pflanzen.Add("Gr�ner Schleimpilz");
            Pflanzen.Add("Lichtnebler");
            Pflanzen.Add("Steinrinde");
            Pflanzen.Add("Wandermoos");

            Tiere.Add(new VerbreitungsElementTiere(("Gebirgsbock"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Bergl�we"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("H�hlenb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionAndereMittellaendischeGebirge : BasisRegion
    {
        public RegionAndereMittellaendischeGebirge()
        {
            Name = "Andere Mittell�ndische Gebirge";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");
            Landschaften.Add("H�hle (feucht)");
            Landschaften.Add("H�hle (trocken)");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Feuermoos und Efferdmoos");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Madabl�te");
            Pflanzen.Add("Bleichmohn (Wei�er Mohn)");
            Pflanzen.Add("Grauer Mohn");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Phosphorpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Schleimiger Sumpfkn�terich");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zw�lfblatt");
            Pflanzen.Add("Dergolasch");
            Pflanzen.Add("Felsenmilch");
            Pflanzen.Add("Gr�ner Schleimpilz");
            Pflanzen.Add("Lichtnebler");
            Pflanzen.Add("Steinrinde");
            Pflanzen.Add("Wandermoos");

            Tiere.Add(new VerbreitungsElementTiere(("Gebirgsbock"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenl�ffler"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Bergl�we"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("H�hlenb�r"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionNoerdlicheWaelderWestkueste : BasisRegion
    {
        public RegionNoerdlicheWaelderWestkueste()
        {
            Name = "N�rdliche W�lder (Westk�ste)";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
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
            Pflanzen.Add("Ulmenw�rger");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zw�lfblatt");

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
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Blaufuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Borkenb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Vielfra�"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Waldl�we"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("H�hlenb�r"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberl�we"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionNoerdlicheWaelderTaiga : BasisRegion
    {
        public RegionNoerdlicheWaelderTaiga()
        {
            Name = "N�rdliche W�lder (Taiga)";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Pestsporenpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schleimiger Sumpfkn�terich");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Ulmenw�rger");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zw�lfblatt");

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
            Tiere.Add(new VerbreitungsElementTiere(("Schwarzb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Grimmb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sonnenluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Streifendachs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Vielfra�"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Waldl�we"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Borkenb�r"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberl�we"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionNoerdlicheWaelderBornland : BasisRegion
    {
        public RegionNoerdlicheWaelderBornland()
        {
            Name = "N�rdliche W�lder (Bornland)";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Nothilf");
            Pflanzen.Add("Pestsporenpilz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schleimiger Sumpfkn�terich");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Thonnys");
            Pflanzen.Add("Ulmenw�rger");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wasserrausch");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zw�lfblatt");

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
            Tiere.Add(new VerbreitungsElementTiere(("H�hlenb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schneedachs"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schwarzb�r"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Grimmb�r"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Vielfra�"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Waldl�we"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionNoerdlicheSuempfeMarschenMoore : BasisRegion
    {
        public RegionNoerdlicheSuempfeMarschenMoore()
        {
            Name = "N�rdliche S�mpfe, Marschen und Moore";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Gr�ne Schleimschlange");
            Pflanzen.Add("Iribaarslilie");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Morgendornstrauch");
            Pflanzen.Add("Neckerkraut");
            Pflanzen.Add("Pestsporenpilz");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Schleimiger Sumpfkn�terich");
            Pflanzen.Add("Schlinggras");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zw�lfblatt");
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
            Name = "Mittell�ndische Grasl�nder, Heide und Steppe";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Hiradwurz");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("F�rberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Wei�er Lotus");
            Pflanzen.Add("Wei�gelber Lotus");
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
            Pflanzen.Add("Schlangenz�nglein");
            Pflanzen.Add("Schwarmschwamm");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Winselgras");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zw�lfblatt");
            Pflanzen.Add("Braunschlinge");
            Pflanzen.Add("Libellengras");
            Pflanzen.Add("Seelenhauch");

            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("G�nseluchs"), (int)EVorkommen.HAEUFIG));
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
            Name = "Mittell�ndische W�lder (Gem��igtes Klima)";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("F�rberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Wei�er Lotus");
            Pflanzen.Add("Wei�gelber Lotus");
            Pflanzen.Add("Lulanie");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Mirbelstein");
            Pflanzen.Add("Neckerkraut");
            Pflanzen.Add("Quasselwurz");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schleimiger Sumpfkn�terich");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Traschbart");
            Pflanzen.Add("Ulmenw�rger");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zw�lfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenl�ffler"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("G�nseluchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Pfeifhase"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Auerhahn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Kronenhirsch"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Streifendachs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("H�hlenb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Schwarzb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Grimmb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberbock"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Silberl�we"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionMittellaendischeWaelderYaquir : BasisRegion
    {
        public RegionMittellaendischeWaelderYaquir()
        {
            Name = "Mittell�ndische W�lder (Yaquirisches Klima)";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("F�rberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Wei�er Lotus");
            Pflanzen.Add("Wei�gelber Lotus");
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
            Pflanzen.Add("Ulmenw�rger");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zw�lfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenl�ffler"), (int)EVorkommen.SEHRHAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("G�nseluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Regenbogenfasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Baumb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Streifendachs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("S��mauldachs"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionMittellaendischeWaelderTobrisch : BasisRegion
    {
        public RegionMittellaendischeWaelderTobrisch()
        {
            Name = "Mittell�ndische W�lder (Tobrisches Klima)";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
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
            Pflanzen.Add("Ulmenw�rger");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wasserrausch");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zw�lfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenl�ffler"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Auerhahn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wildkatze"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Auerochse"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumb�r"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionImmgergrueneWaelderSuedosten : BasisRegion
    {
        public RegionImmgergrueneWaelderSuedosten()
        {
            Name = "Immergr�ne W�lder (S�dosten)";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("F�rberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Wei�er Lotus");
            Pflanzen.Add("Wei�gelber Lotus");
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
            Pflanzen.Add("Zw�lfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenl�ffler"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Auerhahn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Ongalobulle"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rebhuhn"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wachtel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Regenbogenfasan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotfuchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Warzenschwein"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Al'Kebir-Antilope"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumb�r"), (int)EVorkommen.SELTEN));
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
            Name = "S�dl�ndische Grasl�nder und Steppen";
            EssbarePflanzen = (int)EVorkommen.HAEUFIG;
            Wildvorkommen = (int)EVorkommen.GELEGENTLICH;

            Landschaften.Add("W�ste und W�stenrand");
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Finage");
            Pflanzen.Add("Hiradwurz");
            Pflanzen.Add("Jagdgras");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Kh�m- oder Mhanadiknolle");
            Pflanzen.Add("Menchal-Kaktus");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Messergras");
            Pflanzen.Add("Mirbelstein");
            Pflanzen.Add("Bunter Mohn");
            Pflanzen.Add("Purpurmohn");
            Pflanzen.Add("Naftanstaude");
            Pflanzen.Add("Olginwurz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Schlangenz�nglein");
            Pflanzen.Add("Schwarzer Wein");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Winselgras");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Yaganstrauch");
            Pflanzen.Add("Zithabar");
            Pflanzen.Add("Zw�lfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Al'Kebir-Antilope"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Gabelantilope"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Springbock"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Kh�mgepard"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Ongalobulle"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Strau�"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Warzenschwein"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Fasan"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Gelbfuchs"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Regenbogenfasan"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sandl�we"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("S��mauldachs"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionWuestenrandgebiete : BasisRegion
    {
        public RegionWuestenrandgebiete()
        {
            Name = "W�stenrandgebiete";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("W�ste und W�stenrand");
            Landschaften.Add("Steppe");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Atmon");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Cheria-Kaktus");
            Pflanzen.Add("Chonchinis");
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Finage");
            Pflanzen.Add("Hiradwurz");
            Pflanzen.Add("Kh�m- oder Mhanadiknolle");
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
            Pflanzen.Add("Zw�lfblatt");

            Tiere.Add(new VerbreitungsElementTiere(("Gabelantilope"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Springbock"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Al'Kebir-Antilope"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Kh�mgepard"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Sandl�we"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Strau�"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Raschtulsluchs"), (int)EVorkommen.SEHRSELTEN));
        }
    }

    public class RegionWueste : BasisRegion
    {
        public RegionWueste()
        {
            Name = "W�ste";
            EssbarePflanzen = (int)EVorkommen.SEHRSELTEN;
            Wildvorkommen = (int)EVorkommen.SEHRSELTEN;

            Landschaften.Add("W�ste und W�stenrand");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Cheria-Kaktus");
            Pflanzen.Add("Kh�m- oder Mhanadiknolle");
            Pflanzen.Add("Menchal-Kaktus");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Talaschin");

            Tiere.Add(new VerbreitungsElementTiere(("Sandl�we"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionSuedlaendischeGebirge : BasisRegion
    {
        public RegionSuedlaendischeGebirge()
        {
            Name = "S�dl�ndische Gebirge";
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Bleichmohn (Wei�er Mohn)");
            Pflanzen.Add("Olginwurz");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Talaschin");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Horusche");
            Pflanzen.Add("Jagdgras");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Rauschgurke");
            Pflanzen.Add("Schlangenz�nglein");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Tarnblatt");
            Pflanzen.Add("Tarnele");
            Pflanzen.Add("Trichterwurzel");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Yaganstrauch");

            Tiere.Add(new VerbreitungsElementTiere(("Riesenl�ffler"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Otan-Otan"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Rotp�schel"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Vy'Tagga-Antilope"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Wildschwein"), (int)EVorkommen.GELEGENTLICH));
            Tiere.Add(new VerbreitungsElementTiere(("Maraskanisches Stachelschwein"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumschleimer"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Baumw�rger"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Rehwild"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Riesenaffe"), (int)EVorkommen.SEHRSELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Totenkopf�ffchen"), (int)EVorkommen.SELTEN));
        }
    }

    public class RegionSuedlicheSuempfe : BasisRegion
    {
        public RegionSuedlicheSuempfe()
        {
            Name = "S�dliche S�mpfe";
            EssbarePflanzen = (int)EVorkommen.SELTEN;
            Wildvorkommen = (int)EVorkommen.SELTEN;

            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("K�ste, Strand");
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Iribaarslilie");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Kajubo");
            Pflanzen.Add("F�rberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Wei�er Lotus");
            Pflanzen.Add("Wei�gelber Lotus");
            Pflanzen.Add("Mirhamer Seidenliane");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Rote Pfeilbl�te");
            Pflanzen.Add("Sansaro");
            Pflanzen.Add("Schleichender Tod");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("Zw�lfblatt");

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
            Landschaften.Add("K�ste, Strand");
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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Finage");
            Pflanzen.Add("H�llenkraut");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Kajubo");
            Pflanzen.Add("Kukuka");
            Pflanzen.Add("F�rberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Wei�er Lotus");
            Pflanzen.Add("Wei�gelber Lotus");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Mirhamer Seidenliane");
            Pflanzen.Add("Orazal");
            Pflanzen.Add("Quinja");
            Pflanzen.Add("Rahjalieb");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Rote Pfeilbl�te");
            Pflanzen.Add("Schleichender Tod");
            Pflanzen.Add("Shurinstrauch");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("W�rgedattel");
            Pflanzen.Add("Zunderschwamm");

            Tiere.Add(new VerbreitungsElementTiere(("Moosaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Otan-Otan"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Br�llaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Borons�ffchen"), (int)EVorkommen.SELTEN));
            Tiere.Add(new VerbreitungsElementTiere(("Zuckeraffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Zirkusaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("L�wenaffe"), (int)EVorkommen.GELEGENTLICH));
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
            Name = "S�dliche Regengebirge";
            EssbarePflanzen = (int)EVorkommen.GELEGENTLICH;
            Wildvorkommen = (int)EVorkommen.GELEGENTLICH;

            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("Regenwald");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");
            Landschaften.Add("H�hle (feucht)");

            Pflanzen.Add("Alveranie");
            Pflanzen.Add("Atmon");
            Pflanzen.Add("Blutblatt");
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Feuermoos und Efferdmoos");
            Pflanzen.Add("Finage");
            Pflanzen.Add("H�llenkraut");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Kukuka");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Mirhamer Seidenliane");
            Pflanzen.Add("Bleichmohn (Wei�er Mohn)");
            Pflanzen.Add("Grauer Mohn");
            Pflanzen.Add("Orazal");
            Pflanzen.Add("Rattenpilz");
            Pflanzen.Add("Schleichender Tod");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Dergolasch");
            Pflanzen.Add("Felsenmilch");
            Pflanzen.Add("Gr�ner Schleimpilz");
            Pflanzen.Add("Steinrinde");
            Pflanzen.Add("Wandermoos");

            Tiere.Add(new VerbreitungsElementTiere(("Karnickel"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("L�wenaffe"), (int)EVorkommen.HAEUFIG));
            Tiere.Add(new VerbreitungsElementTiere(("Borons�ffchen"), (int)EVorkommen.SELTEN));
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
            Name = "S�dmeer (Feuermeer)";
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
            Landschaften.Add("W�ste und W�stenrand");
            Landschaften.Add("Gebirge");
            Landschaften.Add("Hochland");
            Landschaften.Add("Steppe");
            Landschaften.Add("Grasland, Wiesen");
            Landschaften.Add("Fluss- und Seeufer, Teiche");
            Landschaften.Add("K�ste, Strand");
            Landschaften.Add("Flussauen");
            Landschaften.Add("Sumpf und Moor");
            Landschaften.Add("Regenwald");
            Landschaften.Add("Wald");
            Landschaften.Add("Waldrand");
            Landschaften.Add("Meer");
            Landschaften.Add("H�hle (feucht)");
            Landschaften.Add("H�hle (trocken)");

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
            Pflanzen.Add("Eitriger Kr�tenschemel");
            Pflanzen.Add("Feuermoos und Efferdmoos");
            Pflanzen.Add("Feuerschlick");
            Pflanzen.Add("Finage");
            Pflanzen.Add("Gr�ne Schleimschlange");
            Pflanzen.Add("Gulmond");
            Pflanzen.Add("Hiradwurz");
            Pflanzen.Add("H�llenkraut");
            Pflanzen.Add("Hollbeere");
            Pflanzen.Add("Horusche");
            Pflanzen.Add("Ilmenblatt");
            Pflanzen.Add("Iribaarslilie");
            Pflanzen.Add("Jagdgras");
            Pflanzen.Add("Joruga");
            Pflanzen.Add("Kairan");
            Pflanzen.Add("Kajubo");
            Pflanzen.Add("Kh�m- oder Mhanadiknolle");
            Pflanzen.Add("Klippenzahn");
            Pflanzen.Add("Kukuka");
            Pflanzen.Add("F�rberlotus (Gelber, Blauer, Roter und Rosa Lotus)");
            Pflanzen.Add("Purpurner Lotus");
            Pflanzen.Add("Schwarzer Lotus");
            Pflanzen.Add("Grauer Lotus");
            Pflanzen.Add("Wei�er Lotus");
            Pflanzen.Add("Wei�gelber Lotus");
            Pflanzen.Add("Lulanie");
            Pflanzen.Add("Madabl�te");
            Pflanzen.Add("Menchal-Kaktus");
            Pflanzen.Add("Merach-Strauch");
            Pflanzen.Add("Messergras");
            Pflanzen.Add("Mibelrohr");
            Pflanzen.Add("Mirbelstein");
            Pflanzen.Add("Mirhamer Seidenliane");
            Pflanzen.Add("Bleichmohn (Wei�er Mohn)");
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
            Pflanzen.Add("Rote Pfeilbl�te");
            Pflanzen.Add("Roter Drachenschlund");
            Pflanzen.Add("Sansaro");
            Pflanzen.Add("Satuariensbusch");
            Pflanzen.Add("Schlangenz�nglein");
            Pflanzen.Add("Schleichender Tod");
            Pflanzen.Add("Schleimiger Sumpfkn�terich");
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
            Pflanzen.Add("Ulmenw�rger");
            Pflanzen.Add("Vierbl�ttrige Einbeere");
            Pflanzen.Add("Vragieswurzel");
            Pflanzen.Add("Waldwebe");
            Pflanzen.Add("Wasserrausch");
            Pflanzen.Add("Winselgras");
            Pflanzen.Add("Wirselkraut");
            Pflanzen.Add("W�rgedattel");
            Pflanzen.Add("Yaganstrauch");
            Pflanzen.Add("Zithabar");
            Pflanzen.Add("Zunderschwamm");
            Pflanzen.Add("Zw�lfblatt");

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


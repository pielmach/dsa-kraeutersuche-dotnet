using System.Collections;

namespace DSATool.Pflanzen
{
    public enum EVorkommen
    {
        SEHRHAEUFIG = 1,
        HAEUFIG = 2,
        GELEGENTLICH = 4,
        SELTEN = 8,
        SEHRSELTEN = 16,
        KEINE = 100
    }

    public abstract class BasisPflanze
    {
        private string m_Name = "";
        private string m_Referenz = "Zoo-Botanica Aventurica";
        private int m_SeiteReferenz;
        private int m_Bestimmung;
        private string m_Grundmenge = "";
        private readonly ArrayList m_Verbreitung = new();
        private readonly ArrayList m_Erntezeit = new();

        public string Name
        {
            get { return m_Name; }
            init { m_Name = value; }
        }

        public string Referenz
        {
            get { return m_Referenz; }
            init { m_Referenz = value; }
        }

        public int SeiteReferenz
        {
            get { return m_SeiteReferenz; }
            init { m_SeiteReferenz = value; }
        }

        protected int Bestimmung
        {
            get { return m_Bestimmung; }
            init { m_Bestimmung = value; }
        }

        protected string Grundmenge
        {
            get { return m_Grundmenge; }
            init { m_Grundmenge = value; }
        }

        protected ArrayList Verbreitung
        {
            get { return m_Verbreitung; }
        }

        protected ArrayList Erntezeit
        {
            get { return m_Erntezeit; }
        }

        /// <summary>
        /// Gibt die Grundmenge, die bei einer Pflanze gefunden wird, zurück. Bei Besonderheiten (z.B. Abhängigkeit vom Suchmonat)
        /// sollte die Methode in der jeweiligen Pflanze entsprechend überladen werden.
        /// </summary>
        /// <returns></returns>
        public virtual string GetGrundmenge(string monat, int tapstern)
        {
            return Grundmenge;
        }

        /// <summary>
        /// Gibt die Bestimmungsschwierigkeit der Pflanze zurück. Bei Besonderheiten (z.B. Abhängigkeit vom Suchmonat) sollte
        /// die Methode in der jeweiligen Pflanze entsprechend überladen werden.
        /// </summary>
        /// <param name="monat">Name des Suchmonat</param>
        /// <param name="speziell">Eintrag im Feld Speziell</param>
        public virtual int GetBestimmung(string monat, string speziell, string landschaft)
        {
            return Bestimmung;
        }

        /// <summary>
        /// Gibt einen fertig formatierten Text zurück über die Gefahr bzw. Besonderheit die möglicherweise bei der Suche oder
        /// Ernte der Pflanze auftreten kann. Muss in den jeweiligen Pflanzen überlanden werden.
        /// </summary>
        public virtual string GetGefahr()
        {
            return "";
        }

        /// <summary>
        /// Gibt die Verbreitungs ArrayListe zurück, kann in der einzelnen Pflanze überladen werden für besondere Verbreitung
        /// je nach Suchmonat.
        /// </summary>
        /// <param name="monat">Suchmonat</param>
        public virtual ArrayList GetVerbreitung(string monat)
        {
            return Verbreitung;
        }

        /// <summary>
        /// Gibt die Erntezeit ArrayListe zurück, kann in der einzelnen Pflanze überladen werden, für besondere Verbreitung
        /// je nach Region.
        /// </summary>
        /// <param name="region">Region in der gesucht wird.</param>
        public virtual ArrayList GetErntezeit(string region)
        {
            return Erntezeit;
        }
    }

    public static class Utility
    {
        private static readonly ArrayList pflanzen = new();
        private static readonly Dictionary<string, BasisPflanze> pflanze_by_name = new();

        public static ArrayList Pflanzen
        {
            get { return ArrayList.ReadOnly(pflanzen); }
        }

        public static BasisPflanze FindPflanzeByName(string name)
        {
            return pflanze_by_name[name];
        }

        static Utility()
        {
            // Malomis nicht implementiert (Wächst nur in Gärten)
            // Nemezijn nicht implementiert (Keine Spielwerte)
            // Guraanstrauch bzw. Hesindigo nicht implementieren (Nur in DSA3 Regelwerk)

            // ZBA Pflanzen
            pflanzen.Add(new PflanzeAlraune());
            pflanzen.Add(new PflanzeAlveranie());
            pflanzen.Add(new PflanzeArganstrauch());
            pflanzen.Add(new PflanzeAtanKiefer());
            pflanzen.Add(new PflanzeAtmon());
            pflanzen.Add(new PflanzeAxordaBaum());
            pflanzen.Add(new PflanzeBasilamine());
            pflanzen.Add(new PflanzeBelmart());
            pflanzen.Add(new PflanzeBlutblatt());
            pflanzen.Add(new PflanzeBoronie());
            pflanzen.Add(new PflanzeBoronsschlinge());
            pflanzen.Add(new PflanzeCarlog());
            pflanzen.Add(new PflanzeCheriaKaktus());
            pflanzen.Add(new PflanzeChonchinis());
            pflanzen.Add(new PflanzeDisdychonda());
            pflanzen.Add(new PflanzeDonf());
            pflanzen.Add(new PflanzeDornrose());
            pflanzen.Add(new PflanzeEfeuer());
            pflanzen.Add(new PflanzeEgelschreck());
            pflanzen.Add(new PflanzeEitrigerKrötenschemel());
            pflanzen.Add(new PflanzeFeuermoosEfferdmoos());
            pflanzen.Add(new PflanzeFeuerschlick());
            pflanzen.Add(new PflanzeFinage());
            pflanzen.Add(new PflanzeGrüneSchleimschlange());
            pflanzen.Add(new PflanzeGulmond());
            pflanzen.Add(new PflanzeHiradwurz());
            pflanzen.Add(new PflanzeHoellenkraut());
            pflanzen.Add(new PflanzeHollbeere());
            pflanzen.Add(new PflanzeHorusche());
            pflanzen.Add(new PflanzeIlmenblatt());
            pflanzen.Add(new PflanzeIribaarslilie());
            pflanzen.Add(new PflanzeJagdgras());
            pflanzen.Add(new PflanzeJoruga());
            pflanzen.Add(new PflanzeKairan());
            pflanzen.Add(new PflanzeKajubo());
            pflanzen.Add(new PflanzeKhomMhanadiknolle());
            pflanzen.Add(new PflanzeKlippenzahn());
            pflanzen.Add(new PflanzeKukuka());
            pflanzen.Add(new PflanzeLotusFaerber());
            pflanzen.Add(new PflanzeLotusPurpurner());
            pflanzen.Add(new PflanzeLotusSchwarzer());
            pflanzen.Add(new PflanzeLotusGrauer());
            pflanzen.Add(new PflanzeLotusWeisser());
            pflanzen.Add(new PflanzeLotusWeissgelber());
            pflanzen.Add(new PflanzeLulanie());
            pflanzen.Add(new PflanzeMadabluete());
            pflanzen.Add(new PflanzeMenchalKaktus());
            pflanzen.Add(new PflanzeMerachStrauch());
            pflanzen.Add(new PflanzeMessergras());
            pflanzen.Add(new PflanzeMibelrohr());
            pflanzen.Add(new PflanzeMirbelstein());
            pflanzen.Add(new PflanzeMirhamerSeidenliane());
            pflanzen.Add(new PflanzeMohnWeisser());
            pflanzen.Add(new PflanzeMohnBunter());
            pflanzen.Add(new PflanzeMohnGrauer());
            pflanzen.Add(new PflanzeMohnPurpur());
            pflanzen.Add(new PflanzeMohnSchwarzer());
            pflanzen.Add(new PflanzeMohnTiger());
            pflanzen.Add(new PflanzeMorgendornstrauch());
            pflanzen.Add(new PflanzeNaftanstaude());
            pflanzen.Add(new PflanzeNeckerkraut());
            pflanzen.Add(new PflanzeNothilf());
            pflanzen.Add(new PflanzeOlginwurz());
            pflanzen.Add(new PflanzeOrazal());
            pflanzen.Add(new PflanzeOrklandBovist());
            pflanzen.Add(new PflanzePestsporenpilz());
            pflanzen.Add(new PflanzePhosphorpilz());
            pflanzen.Add(new PflanzeQuasselwurz());
            pflanzen.Add(new PflanzeQuinja());
            pflanzen.Add(new PflanzeRahjalieb());
            pflanzen.Add(new PflanzeRattenpilz());
            pflanzen.Add(new PflanzeRauschgurke());
            pflanzen.Add(new PflanzeRotePfeilbluete());
            pflanzen.Add(new PflanzeRoterDrachenschlund());
            pflanzen.Add(new PflanzeSansaro());
            pflanzen.Add(new PflanzeSatuariensbusch());
            pflanzen.Add(new PflanzeSchlangenzuenglein());
            pflanzen.Add(new PflanzeSchleichenderTod());
            pflanzen.Add(new PflanzeSchleimigerSumpfknoeterich());
            pflanzen.Add(new PflanzeSchlinggras());
            pflanzen.Add(new PflanzeSchwarmschwamm());
            pflanzen.Add(new PflanzeSchwarzerWein());
            pflanzen.Add(new PflanzeShurinstrauch());
            pflanzen.Add(new PflanzeTalaschin());
            pflanzen.Add(new PflanzeTarnblatt());
            pflanzen.Add(new PflanzeTarnele());
            pflanzen.Add(new PflanzeThonnys());
            pflanzen.Add(new PflanzeTraschbart());
            pflanzen.Add(new PflanzeTrichterwurzel());
            pflanzen.Add(new PflanzeTuurAmashKelch());
            pflanzen.Add(new PflanzeUlmenwürger());
            pflanzen.Add(new PflanzeVierblatt());
            pflanzen.Add(new PflanzeVragieswurzel());
            pflanzen.Add(new PflanzeWaldwebe());
            pflanzen.Add(new PflanzeWasserrausch());
            pflanzen.Add(new PflanzeWinselgras());
            pflanzen.Add(new PflanzeWirselkraut());
            pflanzen.Add(new PflanzeWuergedattel());
            pflanzen.Add(new PflanzeYaganstrauch());
            pflanzen.Add(new PflanzeZithabar());
            pflanzen.Add(new PflanzeZunderschwamm());
            pflanzen.Add(new PflanzeZwoelfblatt());
            // WdA und KuK Pflanzen
            pflanzen.Add(new PflanzeBraunschlinge());
            pflanzen.Add(new PflanzeDergolasch());
            pflanzen.Add(new PflanzeFelsenmilch());
            pflanzen.Add(new PflanzeGruenerSchleimpilz());
            pflanzen.Add(new PflanzeLibellengras());
            pflanzen.Add(new PflanzeLichtnebler());
            pflanzen.Add(new PflanzeSeelenhauch());
            pflanzen.Add(new PflanzeSteinrinde());
            pflanzen.Add(new PflanzeWandermoos());

            foreach (BasisPflanze pflanze in pflanzen)
            {
                pflanze_by_name.Add(pflanze.Name, pflanze);
            }
        }
    }

    public class VerbreitungsElementPflanzen
    {
        private string m_landschaft = "";
        private int m_vorkommen;

        public VerbreitungsElementPflanzen(string l, int v)
        {
            Landschaft = l;
            Vorkommen = v;
        }

        public string Landschaft
        {
            get { return m_landschaft; }
            init { m_landschaft = value; }
        }

        public int Vorkommen
        {
            get { return m_vorkommen; }
            init { m_vorkommen = value; }
        }
    }

    #region Pflanzen A-D
    public class PflanzeAlraune : BasisPflanze
    {
        public PflanzeAlraune()
        {
            Name = "Alraune";
            Bestimmung = 9;
            SeiteReferenz = 227;
            Grundmenge = "eine Pflanze";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeAlveranie : BasisPflanze
    {
        public PflanzeAlveranie()
        {
            Name = "Alveranie";
            Bestimmung = -5;
            SeiteReferenz = 228;
            Grundmenge = "12 einzelne Blätter, in der Farbe des Monats";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Eis", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wüste und Wüstenrand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
        }
    }

    public class PflanzeArganstrauch : BasisPflanze
    {
        public PflanzeArganstrauch()
        {
            Name = "Arganstrauch";
            Bestimmung = 4;
            SeiteReferenz = 228;
            Grundmenge = "eine Wurzel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeAtanKiefer : BasisPflanze
    {
        public PflanzeAtanKiefer()
        {
            Name = "Atan-Kiefer";
            Bestimmung = 6;
            SeiteReferenz = 228;
            Grundmenge = "W20 Stein Rinde, bei komplettem Abschälen Verdreifachung des Wertes";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeAtmon : BasisPflanze
    {
        public PflanzeAtmon()
        {
            Name = "Atmon";
            Bestimmung = 5;
            SeiteReferenz = 229;
            Grundmenge = "W6 Büschel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Peraine");
        }
    }

    public class PflanzeAxordaBaum : BasisPflanze
    {
        public PflanzeAxordaBaum()
        {
            Name = "Axorda-Baum";
            Bestimmung = 4;
            SeiteReferenz = 229;
            Grundmenge = "ein Baum";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeBasilamine : BasisPflanze
    {
        public PflanzeBasilamine()
        {
            Name = "Basilamine";
            Bestimmung = 15;
            SeiteReferenz = 230;
            Grundmenge = "W20+10 Schoten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (monat.Equals("Ingerimm"))
                return 5;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }

        public override string GetGefahr()
        {
            return "Wer in einem Feld von Basilaminen steht, wird von der säurehaltigen Schoten beschossen.";
        }
    }

    public class PflanzeBelmart : BasisPflanze
    {
        public PflanzeBelmart()
        {
            Name = "Belmart";
            Bestimmung = 6;
            SeiteReferenz = 230;
            Grundmenge = "2W20 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeBlutblatt : BasisPflanze
    {
        public PflanzeBlutblatt()
        {
            Name = "Blutblatt";
            Bestimmung = 4;
            SeiteReferenz = 230;
            Grundmenge = "W20+2 Zweige pro 10 AsP der Quelle";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Eis", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wüste und Wüstenrand", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeBoronie : BasisPflanze
    {
        public PflanzeBoronie()
        {
            Name = "Boronie";
            Bestimmung = -2;
            SeiteReferenz = 231;
            Grundmenge = "5 Blüten, die kurz vor dem Verblühen sind";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeBoronsschlinge : BasisPflanze
    {
        public PflanzeBoronsschlinge()
        {
            Name = "Boronsschlinge";
            Bestimmung = 15;
            SeiteReferenz = 231;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Wer sich der Boronsschlinge auf einen halben Schritt nähert muss eine KO+4 Probe ablegen oder er schläft binnen einer halben Minute ein und wird anschließend von den Ranken umschlungen.";
        }
    }

    public class PflanzeCarlog : BasisPflanze
    {
        public PflanzeCarlog()
        {
            Name = "Carlog";
            Bestimmung = 5;
            SeiteReferenz = 232;
            Grundmenge = "W6 Blüten mit je einem Stempel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Efferd");
            Erntezeit.Add("Peraine");
        }
    }

    public class PflanzeCheriaKaktus : BasisPflanze
    {
        public PflanzeCheriaKaktus()
        {
            Name = "Cheria-Kaktus";
            Bestimmung = 4;
            SeiteReferenz = 232;
            Grundmenge = "W3 Stein Kaktusfleisch und pro Stein 3W6+8 Stacheln";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wüste und Wüstenrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Werden bei der Kaktusernte keine dicken Lederhandschuhe getragen, muss eine FF Probe abgelegt werden. Ansonsten verletzt man sich an den Stacheln und wird vergiftet.";
        }
    }

    public class PflanzeChonchinis : BasisPflanze
    {
        public PflanzeChonchinis()
        {
            Name = "Chonchinis";
            Bestimmung = 6;
            SeiteReferenz = 233;
            Grundmenge = "W20 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeDisdychonda : BasisPflanze
    {
        public PflanzeDisdychonda()
        {
            Name = "Disdychonda";
            Bestimmung = 5;
            SeiteReferenz = 234;
            Grundmenge = "4 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Die Disdychonda greift mit ihren Blättern an. Außerdem befindet sich in der Umgebung möglicherweise noch ein Feld von Raubnesseln.";
        }
    }

    public class PflanzeDonf : BasisPflanze
    {
        public PflanzeDonf()
        {
            Name = "Donf";
            Bestimmung = 6;
            SeiteReferenz = 234;
            Grundmenge = "ein Stängel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeDornrose : BasisPflanze
    {
        public PflanzeDornrose()
        {
            Name = "Dornrose";
            Bestimmung = 3;
            SeiteReferenz = 235;
            Grundmenge = "Strauch mit W6 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }
    #endregion

    #region Pflanzen E-G
    public class PflanzeEfeuer : BasisPflanze
    {
        public PflanzeEfeuer()
        {
            Name = "Efeuer";
            Bestimmung = 4;
            SeiteReferenz = 235;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (trocken)", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (speziell.Equals("Ruine"))
                return 0;
            return base.GetBestimmung(monat, speziell, landschaft);
        }

        public override string GetGefahr()
        {
            return "Efeuer gilt als gefährliches Dornicht (ZBA S.205) und eine Berührung verursacht Schaden.";
        }
    }

    public class PflanzeEgelschreck : BasisPflanze
    {
        public PflanzeEgelschreck()
        {
            Name = "Egelschreck";
            Bestimmung = 6;
            SeiteReferenz = 235;
            Grundmenge = "2W20 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
        }
    }

    public class PflanzeEitrigerKrötenschemel : BasisPflanze
    {
        public PflanzeEitrigerKrötenschemel()
        {
            Name = "Eitriger Krötenschemel";
            Bestimmung = 2;
            SeiteReferenz = 236;
            Grundmenge = "2W6 Pilzhäute";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
        }
    }

    public class PflanzeFeuermoosEfferdmoos : BasisPflanze
    {
        public PflanzeFeuermoosEfferdmoos()
        {
            Name = "Feuermoos und Efferdmoos";
            Bestimmung = 15;
            SeiteReferenz = 236;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Die Berührung mit Feuer- bzw. Efferdmoos erzeugt schwere Verätzungen. Die Wirkungen von Feuer- und Efferdmoos heben sich jedoch gegenseitig auf.";
        }
    }

    public class PflanzeFeuerschlick : BasisPflanze
    {
        public PflanzeFeuerschlick()
        {
            Name = "Feuerschlick";
            Bestimmung = 6;
            SeiteReferenz = 237;
            Grundmenge = "W6 Stein der Algen";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Meer", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (monat.Equals("Rondra") || monat.Equals("Efferd"))
            {
                if (speziell.Equals("Vollmondnacht (+/- 1 Tag)"))
                    return -5;
                else
                    return base.GetBestimmung(monat, speziell, landschaft);
            }
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }

        public override ArrayList GetVerbreitung(string monat)
        {
            if (monat.Equals("Rondra") || monat.Equals("Efferd"))
            {
                ArrayList erg = new()
                {
                    new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.SEHRHAEUFIG),
                    new VerbreitungsElementPflanzen("Meer", (int)EVorkommen.SEHRSELTEN)
                };
                return erg;

            }
            else
                return base.GetVerbreitung(monat);
        }
    }

    public class PflanzeFinage : BasisPflanze
    {
        public PflanzeFinage()
        {
            Name = "Finage";
            Bestimmung = 5;
            SeiteReferenz = 238;
            Grundmenge = "Baum mit W20 Trieben und Bast";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Peraine");
        }

        public override string GetGrundmenge(string monat, int tapstern)
        {
            if (monat.Equals("Boron") || monat.Equals("Hesinde") || monat.Equals("Firun"))
                return "Bast eines Baumes";
            else if (monat.Equals("Peraine"))
                return "Baum mit W20 Trieben";
            else
                return base.GetGrundmenge(monat, tapstern);
        }
    }

    public class PflanzeGrüneSchleimschlange : BasisPflanze
    {
        public PflanzeGrüneSchleimschlange()
        {
            Name = "Grüne Schleimschlange";
            Bestimmung = 4;
            SeiteReferenz = 238;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Bei Anblick eines überwucherten Kadavers ist eine MU Probe fällig (vgl. MGS 51/54 Dämoneneigenschaft Schreckgestalt I) und ein Patzer bringt Phobie gegen die Pflanze als permanenten Nachteil.";
        }
    }

    public class PflanzeGulmond : BasisPflanze
    {
        public PflanzeGulmond()
        {
            Name = "Gulmond";
            Bestimmung = 6;
            SeiteReferenz = 238;
            Grundmenge = "2W6 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }


    #endregion

    #region Pflanzen H-K
    public class PflanzeHiradwurz : BasisPflanze
    {
        public PflanzeHiradwurz()
        {
            Name = "Hiradwurz";
            Bestimmung = 8;
            SeiteReferenz = 239;
            Grundmenge = "eine Wurzel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (monat.Equals("Efferd") || monat.Equals("Travia") || monat.Equals("Tsa") || monat.Equals("Phex"))
                return 5;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }
    }

    public class PflanzeHollbeere : BasisPflanze
    {
        public PflanzeHollbeere()
        {
            Name = "Hollbeere";
            Bestimmung = 4;
            SeiteReferenz = 240;
            Grundmenge = "2W6 Sträucher mit jeweils 2W6+5 Beeren und 2W6+3 Blätter der untersten Zweige";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.HAEUFIG));

            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
        }
    }

    public class PflanzeHoellenkraut : BasisPflanze
    {
        public PflanzeHoellenkraut()
        {
            Name = "Höllenkraut";
            Bestimmung = 8;
            SeiteReferenz = 240;
            Grundmenge = "W10 Stein der Ranken";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeHorusche : BasisPflanze
    {
        public PflanzeHorusche()
        {
            Name = "Horusche";
            Bestimmung = 7;
            SeiteReferenz = 240;
            Grundmenge = "W6 erntereife Schoten mit je W3 Kernen";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeIlmenblatt : BasisPflanze
    {
        public PflanzeIlmenblatt()
        {
            Name = "Ilmenblatt";
            Bestimmung = 2;
            SeiteReferenz = 241;
            // Grundmenge an Harz ergänzt, da in ZBA nicht angegeben
            Grundmenge = "W20 Blätter und Blüten sowie 1 Unze Harz";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Travia");
            Erntezeit.Add("Ingerimm");
        }
    }

    public class PflanzeIribaarslilie : BasisPflanze
    {
        public PflanzeIribaarslilie()
        {
            Name = "Iribaarslilie";
            Bestimmung = 12;
            SeiteReferenz = 241;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Die Iribaarslilie verzaubert jeden, der sich ihr nähert und zieht ihn anschließend in die Tiefe.";
        }
    }

    public class PflanzeJagdgras : BasisPflanze
    {
        public PflanzeJagdgras()
        {
            Name = "Jagdgras";
            Bestimmung = 15;
            SeiteReferenz = 242;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Jagdgras wandert nachts und läßt sich auf Opfern nieder um seine Wurzeln in sie zu schlagen. Wird manchmal mit Wirselkraut verwechselt, was schlimme Folgen hat.";
        }

    }

    public class PflanzeJoruga : BasisPflanze
    {
        public PflanzeJoruga()
        {
            Name = "Joruga";
            Bestimmung = 7;
            SeiteReferenz = 243;
            Grundmenge = "eine Wurzel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeKairan : BasisPflanze
    {
        public PflanzeKairan()
        {
            Name = "Kairan";
            Bestimmung = 6;
            SeiteReferenz = 243;
            Grundmenge = "ein Halm";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeKajubo : BasisPflanze
    {
        public PflanzeKajubo()
        {
            Name = "Kajubo";
            Bestimmung = 4;
            SeiteReferenz = 244;
            Grundmenge = "2W6 Knospen (Nur die Hälfte um den Strauch zu schonen)";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeKhomMhanadiknolle : BasisPflanze
    {
        public PflanzeKhomMhanadiknolle()
        {
            Name = "Khôm- oder Mhanadiknolle";
            Bestimmung = 12;
            SeiteReferenz = 244;
            Grundmenge = "eine Wurzel mit W6 Maß klarem Wasser";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wüste und Wüstenrand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (monat.Equals("Praios") || monat.Equals("Rondra") || monat.Equals("Efferd"))
                return 5;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }
    }

    public class PflanzeKlippenzahn : BasisPflanze
    {
        public PflanzeKlippenzahn()
        {
            Name = "Klippenzahn";
            Bestimmung = 8;
            SeiteReferenz = 245;
            Grundmenge = "2W6 Stängel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeKukuka : BasisPflanze
    {
        public PflanzeKukuka()
        {
            Name = "Kukuka";
            Bestimmung = 10;
            SeiteReferenz = 245;
            Grundmenge = "1W3 x 20 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }
    #endregion

    #region Pflanzen L-M
    public class PflanzeLotusFaerber : BasisPflanze
    {
        public PflanzeLotusFaerber()
        {
            Name = "Färberlotus (Gelber, Blauer, Roter und Rosa Lotus)";
            Bestimmung = 9;
            SeiteReferenz = 246;
            Grundmenge = "2W6+1 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeLotusPurpurner : BasisPflanze
    {
        public PflanzeLotusPurpurner()
        {
            Name = "Purpurner Lotus";
            Bestimmung = 7;
            SeiteReferenz = 246;
            Grundmenge = "W6+1 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Im Umkreis von 5 Schritt ist eine KO Probe nötig um den giftigen Blütenstaub nicht einzuatmen. Fehlende Punkte entsprechen der Zahl an eingeatmeten Dosen.";
        }
    }

    public class PflanzeLotusSchwarzer : BasisPflanze
    {
        public PflanzeLotusSchwarzer()
        {
            Name = "Schwarzer Lotus";
            Bestimmung = 6;
            SeiteReferenz = 246;
            Grundmenge = "W6 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Im Umkreis von 5 Schritt ist eine KO Probe nötig um den giftigen Blütenstaub nicht einzuatmen. Fehlende Punkte entsprechen der Zahl an eingeatmeten Dosen.";
        }
    }

    public class PflanzeLotusGrauer : BasisPflanze
    {
        public PflanzeLotusGrauer()
        {
            Name = "Grauer Lotus";
            Bestimmung = 8;
            SeiteReferenz = 246;
            Grundmenge = "W6+1 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Im Umkreis von 5 Schritt ist eine KO Probe nötig um den giftigen Blütenstaub nicht einzuatmen. Fehlende Punkte entsprechen der Zahl an eingeatmeten Dosen.";
        }
    }

    public class PflanzeLotusWeisser : BasisPflanze
    {
        public PflanzeLotusWeisser()
        {
            Name = "Weißer Lotus";
            Bestimmung = 10;
            SeiteReferenz = 247;
            Grundmenge = "W6+1 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Im Umkreis von 5 Schritt ist eine KO Probe nötig um den giftigen Blütenstaub nicht einzuatmen. Fehlende Punkte entsprechen der Zahl an eingeatmeten Dosen.";
        }
    }

    public class PflanzeLotusWeissgelber : BasisPflanze
    {
        public PflanzeLotusWeissgelber()
        {
            Name = "Weißgelber Lotus";
            Bestimmung = 10;
            SeiteReferenz = 247;
            Grundmenge = "W3 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Im Umkreis von 5 Schritt ist eine KO Probe nötig um den giftigen Blütenstaub nicht einzuatmen. Fehlende Punkte entsprechen der Zahl an eingeatmeten Dosen.";
        }
    }

    public class PflanzeLulanie : BasisPflanze
    {
        public PflanzeLulanie()
        {
            Name = "Lulanie";
            Bestimmung = 5;
            SeiteReferenz = 248;
            Grundmenge = "eine Blüte";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeMadabluete : BasisPflanze
    {
        public PflanzeMadabluete()
        {
            Name = "Madablüte";
            Bestimmung = 15;
            SeiteReferenz = 248;
            Grundmenge = "eine Blüte";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (speziell.Equals("Vollmondnacht (+/- 1 Tag)"))
                return 5;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }
    }

    public class PflanzeMenchalKaktus : BasisPflanze
    {
        public PflanzeMenchalKaktus()
        {
            Name = "Menchal-Kaktus";
            Bestimmung = 4;
            SeiteReferenz = 249;
            Grundmenge = "ein Kaktus mit W3 Maß Menchalsaft; bei 1 auf W20 außerdem mit W6 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wüste und Wüstenrand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeMerachStrauch : BasisPflanze
    {
        public PflanzeMerachStrauch()
        {
            Name = "Merach-Strauch";
            Bestimmung = 2;
            SeiteReferenz = 250;
            Grundmenge = "2W20 reife Früchte";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
        }
    }

    public class PflanzeMessergras : BasisPflanze
    {
        public PflanzeMessergras()
        {
            Name = "Messergras";
            Bestimmung = 6;
            SeiteReferenz = 250;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wüste und Wüstenrand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Messergras verletzt bei Berührungen und eine Reise durch ein derart bewachsende Gebiet kann tödlich enden.";
        }
    }

    public class PflanzeMibelrohr : BasisPflanze
    {
        public PflanzeMibelrohr()
        {
            Name = "Mibelrohr";
            Bestimmung = 10;
            SeiteReferenz = 251;
            Grundmenge = "2W6 Kolben";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeMirbelstein : BasisPflanze
    {
        public PflanzeMirbelstein()
        {
            Name = "Mirbelstein";
            Bestimmung = 8;
            SeiteReferenz = 251;
            Grundmenge = "1 Wurzelknolle";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.HAEUFIG));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeMirhamerSeidenliane : BasisPflanze
    {
        public PflanzeMirhamerSeidenliane()
        {
            Name = "Mirhamer Seidenliane";
            Bestimmung = 4;
            SeiteReferenz = 251;
            Grundmenge = "eine Ranke mit W2+1 Knoten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGrundmenge(string monat, int tapstern)
        {
            if (monat.Equals("Tsa") || monat.Equals("Phex") || monat.Equals("Peraine") || monat.Equals("Ingerimm"))
                return "eine Ranke mit W2+1 Knoten";
            else if (monat.Equals("Komplettes Jahr"))
                return base.GetGrundmenge(monat, tapstern);
            else
                return "eine Ranke";
        }
    }

    public class PflanzeMohnWeisser : BasisPflanze
    {
        public PflanzeMohnWeisser()
        {
            Name = "Bleichmohn (Weißer Mohn)";
            Bestimmung = 5;
            SeiteReferenz = 252;
            Grundmenge = "W6 geschlossene Samenkapseln";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Rondra");
        }
    }

    public class PflanzeMohnBunter : BasisPflanze
    {
        public PflanzeMohnBunter()
        {
            Name = "Bunter Mohn";
            Bestimmung = -5;
            SeiteReferenz = 252;
            Grundmenge = "eine geschlossene Samenkapsel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Travia");
        }
    }

    public class PflanzeMohnGrauer : BasisPflanze
    {
        public PflanzeMohnGrauer()
        {
            Name = "Grauer Mohn";
            Bestimmung = 1;
            SeiteReferenz = 253;
            Grundmenge = "eine geschlossene Samenkapsel und eine Blüte";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGrundmenge(string monat, int tapstern)
        {
            if (monat.Equals("Rondra"))
                return "eine geschlossene Samenkapsel und eine Blüte";
            else if (monat.Equals("Komplettes Jahr"))
                return base.GetGrundmenge(monat, tapstern);
            else
                return "eine Blüte";
        }
    }

    public class PflanzeMohnPurpur : BasisPflanze
    {
        public PflanzeMohnPurpur()
        {
            Name = "Purpurmohn";
            Bestimmung = 3;
            SeiteReferenz = 253;
            Grundmenge = "eine geschlossene Samenkapsel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Rahja");
        }
    }

    public class PflanzeMohnSchwarzer : BasisPflanze
    {
        public PflanzeMohnSchwarzer()
        {
            Name = "Schwarzer Mohn";
            Bestimmung = 5;
            SeiteReferenz = 253;
            Grundmenge = "2 Blätter und eine geschlossene Samenkapsel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRHAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SEHRHAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRHAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRHAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRHAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRHAEUFIG));

            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
        }
    }

    public class PflanzeMohnTiger : BasisPflanze
    {
        public PflanzeMohnTiger()
        {
            Name = "Tigermohn";
            Bestimmung = 10;
            SeiteReferenz = 254;
            Grundmenge = "eine geschlossene Samenkapsel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Travia");
        }
    }

    public class PflanzeMorgendornstrauch : BasisPflanze
    {
        public PflanzeMorgendornstrauch()
        {
            Name = "Morgendornstrauch";
            Bestimmung = 13;
            SeiteReferenz = 254;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Die Berührung einer Blüte des Morgendornstrauchs verwandelt denjenigen binnen einer Woche in eine Sumpfranze.";
        }
    }
    #endregion

    #region Pflanzen N-R
    public class PflanzeNaftanstaude : BasisPflanze
    {
        public PflanzeNaftanstaude()
        {
            Name = "Naftanstaude";
            Bestimmung = 1;
            SeiteReferenz = 255;
            Grundmenge = "eine Staude";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Der Saft der Naftanstaude ist stark ätzend und kann nur mit einer FF+2 Probe gefahrlos geerntet werden.";
        }

        public override ArrayList GetErntezeit(string region)
        {
            if (region.Equals("Südländische Grasländer und Steppen") || region.Equals("Wüstenrandgebiete"))
            {
                ArrayList erg = new()
                {
                    "Praios",
                    "Rondra",
                    "Efferd",
                    "Travia",
                    "Boron",
                    "Hesinde",
                    "Firun",
                    "Tsa",
                    "Phex",
                    "Peraine",
                    "Ingerimm",
                    "Rahja",
                    "Namenlose Tage"
                };
                return erg;
            }
            else
                return base.GetErntezeit(region);
        }

        public override ArrayList GetVerbreitung(string monat)
        {
            if (monat.Equals("Boron") || monat.Equals("Hesinde") || monat.Equals("Firun"))
            {
                ArrayList erg = new()
                {
                    new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.SELTEN)
                };
                return erg;
            }
            else
                return base.GetVerbreitung(monat);
        }
    }

    public class PflanzeNeckerkraut : BasisPflanze
    {
        public PflanzeNeckerkraut()
        {
            Name = "Neckerkraut";
            Bestimmung = 4;
            SeiteReferenz = 255;
            Grundmenge = "W20+5 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeNothilf : BasisPflanze
    {
        public PflanzeNothilf()
        {
            Name = "Nothilf";
            Bestimmung = 6;
            SeiteReferenz = 256;
            Grundmenge = "W20+2 Blüten und 2W20+10 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Peraine");
        }
    }

    public class PflanzeOlginwurz : BasisPflanze
    {
        public PflanzeOlginwurz()
        {
            Name = "Olginwurz";
            Bestimmung = 10;
            SeiteReferenz = 256;
            Grundmenge = "W3 Moosballen";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeOrazal : BasisPflanze
    {
        public PflanzeOrazal()
        {
            Name = "Orazal";
            Bestimmung = 4;
            SeiteReferenz = 257;
            Grundmenge = "W6 verholzte Stängel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "In großer Hitze kann sich Orazal so sehr aufheizen, dass die Pflanze bei Berührung auf der Haut festklebt und beim Ablösen die Haut verletzt.";
        }
    }

    public class PflanzeOrklandBovist : BasisPflanze
    {
        public PflanzeOrklandBovist()
        {
            Name = "Orklandbovist";
            Bestimmung = 4;
            SeiteReferenz = 258;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "In den Monaten Ingerimm, Rahja, Praios und Rondra ist der Orklandbovist gefährlich. Platzt er auf, so kann man sich in 5 Schritt Umkreis nur durch eine Athletik-Probe +15 in Deckung bringen. Andernfalls muss eine KO Probe klären ob man die Pilzsporen eingeatmet hat.";
        }
    }

    public class PflanzePestsporenpilz : BasisPflanze
    {
        public PflanzePestsporenpilz()
        {
            Name = "Pestsporenpilz";
            Bestimmung = 6;
            SeiteReferenz = 258;
            Grundmenge = "eine Pilzhaut";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
        }

        public override string GetGefahr()
        {
            return "Wird beim Ernten die Haut des Pestsporenpilzes nicht vorsichtig abgelöst (FF+2 Probe) oder stolpert man versehentlich über einen Pilz (GE+2 Probe) so setzt der Pilz eine giftige Wolke frei.";
        }
    }

    public class PflanzePhosphorpilz : BasisPflanze
    {
        public PflanzePhosphorpilz()
        {
            Name = "Phosphorpilz";
            Bestimmung = 10;
            SeiteReferenz = 259;
            Grundmenge = "W6 Stein Geflechtstücke";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (trocken)", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (landschaft.Equals("Höhle (feucht)"))
                return -3;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }
    }

    public class PflanzeQuasselwurz : BasisPflanze
    {
        public PflanzeQuasselwurz()
        {
            Name = "Quasselwurz";
            Bestimmung = 12;
            SeiteReferenz = 259;
            Grundmenge = "eine Wurzel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeQuinja : BasisPflanze
    {
        public PflanzeQuinja()
        {
            Name = "Quinja";
            Bestimmung = 6;
            SeiteReferenz = 260;
            Grundmenge = "W3+2 Beeren";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Verwechslung mit Scheinquinja möglich (zusätzliche Pflanzenkunde-Probe +8) welcher leicht giftig ist.";
        }
    }

    public class PflanzeRahjalieb : BasisPflanze
    {
        public PflanzeRahjalieb()
        {
            Name = "Rahjalieb";
            Bestimmung = 5;
            SeiteReferenz = 260;
            Grundmenge = "2W6 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeRattenpilz : BasisPflanze
    {
        public PflanzeRattenpilz()
        {
            Name = "Rattenpilz";
            Bestimmung = 7;
            SeiteReferenz = 260;
            Grundmenge = "ein Pilz";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (speziell.Equals("Stätte Namenloser Macht"))
                return -7;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }

        public override string GetGefahr()
        {
            return "Der Rattenpilz verströmt eine magische Anziehungskraft auf jeden Wanderer.";
        }
    }

    public class PflanzeRauschgurke : BasisPflanze
    {
        public PflanzeRauschgurke()
        {
            Name = "Rauschgurke";
            Bestimmung = 3;
            SeiteReferenz = 261;
            Grundmenge = "3W6 reife Rauschgurken";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeRotePfeilbluete : BasisPflanze
    {
        public PflanzeRotePfeilbluete()
        {
            Name = "Rote Pfeilblüte";
            Bestimmung = 7;
            SeiteReferenz = 261;
            Grundmenge = "W6 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
        }
    }

    public class PflanzeRoterDrachenschlund : BasisPflanze
    {
        public PflanzeRoterDrachenschlund()
        {
            Name = "Roter Drachenschlund";
            Bestimmung = 10;
            SeiteReferenz = 262;
            Grundmenge = "W6 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (monat.Equals("Rahja") || monat.Equals("Ingerimm"))
                return 3;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }
    }
    #endregion

    #region Pflanzen S-T
    public class PflanzeSansaro : BasisPflanze
    {
        public PflanzeSansaro()
        {
            Name = "Sansaro";
            Bestimmung = 12;
            SeiteReferenz = 262;
            Grundmenge = "eine Pflanze";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Meer", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override ArrayList GetVerbreitung(string monat)
        {
            if (monat.Equals("Boron") || monat.Equals("Hesinde") || monat.Equals("Firun"))
            {
                ArrayList erg = new()
                {
                    new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.SELTEN)
                };
                return erg;
            }
            else
                return base.GetVerbreitung(monat);
        }
    }

    public class PflanzeSatuariensbusch : BasisPflanze
    {
        public PflanzeSatuariensbusch()
        {
            Name = "Satuariensbusch";
            Bestimmung = -2;
            SeiteReferenz = 263;
            Grundmenge = "4W20 Blätter, W20 Blüten, W20 Früchte, W3 Flux Saft";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGrundmenge(string monat, int tapstern)
        {
            string ergebnis = "";

            if (monat.Equals("Ingerimm") || monat.Equals("Rahja") || monat.Equals("Namenlose Tage") || monat.Equals("Praios"))
            {
                if (!ergebnis.Equals(""))
                    ergebnis += ", ";
                ergebnis += "4W20 Blätter";
            }
            if (monat.Equals("Ingerimm") || monat.Equals("Rahja"))
            {
                if (!ergebnis.Equals(""))
                    ergebnis += ", ";
                ergebnis += "W20 Blüten";
            }
            if (monat.Equals("Efferd") || monat.Equals("Travia"))
            {
                if (!ergebnis.Equals(""))
                    ergebnis += ", ";
                ergebnis += "W20 Früchte";
            }
            if (monat.Equals("Phex") || monat.Equals("Peraine") || monat.Equals("Ingerimm") || monat.Equals("Rahja") || monat.Equals("Namenlose Tage") || monat.Equals("Praios"))
            {
                if (!ergebnis.Equals(""))
                    ergebnis += ", ";
                ergebnis += "W3 Flux Saft";
            }

            if (monat.Equals("Komplettes Jahr"))
                return base.GetGrundmenge(monat, tapstern);
            else
                return ergebnis;
        }
    }

    public class PflanzeSchlangenzuenglein : BasisPflanze
    {
        public PflanzeSchlangenzuenglein()
        {
            Name = "Schlangenzünglein";
            Bestimmung = 3;
            SeiteReferenz = 263;
            Grundmenge = "Saft einer Pflanze";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeSchleichenderTod : BasisPflanze
    {
        public PflanzeSchleichenderTod()
        {
            Name = "Schleichender Tod";
            Bestimmung = 6;
            SeiteReferenz = 264;
            Grundmenge = "W6 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
        }
    }

    public class PflanzeSchleimigerSumpfknoeterich : BasisPflanze
    {
        public PflanzeSchleimigerSumpfknoeterich()
        {
            Name = "Schleimiger Sumpfknöterich";
            Bestimmung = 3;
            SeiteReferenz = 264;
            Grundmenge = "2W6 Pilze";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
        }

        public override string GetGefahr()
        {
            return "Die Berührung mit bloßer Haut verursacht 3 SP pro Pilz.";
        }
    }

    public class PflanzeSchlinggras : BasisPflanze
    {
        public PflanzeSchlinggras()
        {
            Name = "Schlinggras";
            Bestimmung = 12;
            SeiteReferenz = 265;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Eine IN Probe klärt ob man rechtzeitig auf das Schlinggras aufmerksam wird um es zu umgehen. Andernfalls versucht die Pflanze einen zu packen und ins Moor zu ziehen.";
        }
    }

    public class PflanzeSchwarmschwamm : BasisPflanze
    {
        public PflanzeSchwarmschwamm()
        {
            Name = "Schwarmschwamm";
            Bestimmung = 3;
            SeiteReferenz = 265;
            Grundmenge = "ein Schwamm und W2 Samenkörper";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeSchwarzerWein : BasisPflanze
    {
        public PflanzeSchwarzerWein()
        {
            Name = "Schwarzer Wein";
            Bestimmung = 2;
            SeiteReferenz = 266;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.HAEUFIG));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGrundmenge(string monat, int tapstern)
        {
            if (tapstern >= 7)
                return "7W6 Beeren";
            else
                return base.GetGrundmenge(monat, tapstern);
        }

        public override string GetGefahr()
        {
            return "Schwarzer Wein bildet nur dann Früchte aus, wenn zuvor Menschen ausgesaugt wurden. Außerdem sind die Ranken gefährlich und giftig. Nur bei mehr als 7 TaP* kann man einige Beeren finden ohne zuvor Menschen opfern zu müssen.";
        }
    }

    public class PflanzeShurinstrauch : BasisPflanze
    {
        public PflanzeShurinstrauch()
        {
            Name = "Shurinstrauch";
            Bestimmung = 2;
            SeiteReferenz = 267;
            Grundmenge = "W20 Knollen";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeTalaschin : BasisPflanze
    {
        public PflanzeTalaschin()
        {
            Name = "Talaschin";
            Bestimmung = 5;
            SeiteReferenz = 268;
            Grundmenge = "W6 Flechten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Eis", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wüste und Wüstenrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeTarnblatt : BasisPflanze
    {
        public PflanzeTarnblatt()
        {
            Name = "Tarnblatt";
            Bestimmung = 8;
            SeiteReferenz = 268;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Tarnblatt ist leicht giftig und gibt sich je nach Jahreszeit als eine andere Pflanze aus.";
        }
    }

    public class PflanzeTarnele : BasisPflanze
    {
        public PflanzeTarnele()
        {
            Name = "Tarnele";
            Bestimmung = 4;
            SeiteReferenz = 268;
            Grundmenge = "eine Pflanze";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeThonnys : BasisPflanze
    {
        public PflanzeThonnys()
        {
            Name = "Thonnys";
            Bestimmung = 12;
            SeiteReferenz = 269;
            Grundmenge = "W6+4 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            //Quelle DSA3 Herbarium S.58, zweiwöchige Blüte im Rahja
            if (monat.Equals("Rahja"))
                return 5;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }
    }

    public class PflanzeTraschbart : BasisPflanze
    {
        public PflanzeTraschbart()
        {
            Name = "Traschbart";
            Bestimmung = 6;
            SeiteReferenz = 269;
            Grundmenge = "W6 Flechten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.HAEUFIG));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeTrichterwurzel : BasisPflanze
    {
        public PflanzeTrichterwurzel()
        {
            Name = "Trichterwurzel";
            Bestimmung = 11;
            SeiteReferenz = 270;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Nur eine Sinnesschärfe-Probe +8 erlaubt es die Grube der Trichterwurzel rechtzeitig zu erkennen. Andernfalls fällt man in diese hinein und wird zusätzlich von Wurzeln attackiert.";
        }
    }

    public class PflanzeTuurAmashKelch : BasisPflanze
    {
        public PflanzeTuurAmashKelch()
        {
            Name = "Tuur-Amash-Kelch";
            Bestimmung = 1;
            SeiteReferenz = 270;
            Grundmenge = "W6+3 Kelche";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGrundmenge(string monat, int tapstern)
        {
            if (tapstern >= 13)
                return "W6+3 Kelche und eine Beere";
            else
                return base.GetGrundmenge(monat, tapstern);
        }

        public override string GetGefahr()
        {
            return "Nur eine Sinnesschärfe-Probe +7 erlaubt es den Tuur-Amash-Kelch rechtzeitig zu entdecken. Andernfalls greift eine Pflanze an und kurz darauf weitere. Nur bei mehr als 13 TaP* findet sich auch eine Beere.";
        }
    }
    #endregion

    #region Pflanzen U-Z
    public class PflanzeUlmenwürger : BasisPflanze
    {
        public PflanzeUlmenwürger()
        {
            Name = "Ulmenwürger";
            Bestimmung = 2;
            SeiteReferenz = 271;
            Grundmenge = "W20 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
        }
    }

    public class PflanzeVierblatt : BasisPflanze
    {
        public PflanzeVierblatt()
        {
            Name = "Vierblättrige Einbeere";
            Bestimmung = 5;
            SeiteReferenz = 271;
            Grundmenge = "W6 Beeren";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Eis", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.HAEUFIG));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeVragieswurzel : BasisPflanze
    {
        public PflanzeVragieswurzel()
        {
            Name = "Vragieswurzel";
            Bestimmung = 6;
            SeiteReferenz = 272;
            Grundmenge = "eine Wurzel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
        }

        public override ArrayList GetErntezeit(string region)
        {
            if (region.Equals("Regenwald") || region.Equals("Südliche Regengebirge"))
            {
                ArrayList erg = new()
                {
                    "Efferd",
                    "Travia",
                    "Boron"
                };
                return erg;
            }
            else
                return base.GetErntezeit(region);
        }
    }

    public class PflanzeWaldwebe : BasisPflanze
    {
        public PflanzeWaldwebe()
        {
            Name = "Waldwebe";
            Bestimmung = 9;
            SeiteReferenz = 272;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Sofern keine besonderne Umstände eine leichte Erkennung erlauben, ist eine Sinnensschärfe-Probe +12 nötig um das Netz der Waldwebe zu erkennen. Andernfalls verfängt man sich im Netz.";
        }
    }

    public class PflanzeWasserrausch : BasisPflanze
    {
        public PflanzeWasserrausch()
        {
            Name = "Wasserrausch";
            Bestimmung = 1;
            SeiteReferenz = 273;
            Grundmenge = "2W20 Blüten";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGrundmenge(string monat, int tapstern)
        {
            if (monat.Equals("Rahja") || monat.Equals("Namenlose Tage") || monat.Equals("Praios") || monat.Equals("Rondra") || monat.Equals("Efferd"))
            {
                if ((monat.Equals("Rondra") || monat.Equals("Efferd") || monat.Equals("Travia")) && tapstern >= 12)
                    return "2W20 Blüten und eine Frucht";
                else
                    return "2W20 Blüten";
            }
            else if ((monat.Equals("Travia")) && tapstern >= 12)
                return "eine Frucht";
            else if ((monat.Equals("Komplettes Jahr")) && tapstern >= 12)
                return "2W20 Blüten und eine Frucht";
            else
                return base.GetGrundmenge(monat, tapstern);
        }

        public override string GetGefahr()
        {
            return "Im Umkreis von 5 Metern um die Blüten des Wasserrausches ist eine KO+5 Probe nötig. Andernfalls fällt man in berauschende Träume, was für eine Schwimmer den Tod bedeuten kann. Nur bei mehr als 12 TaP* findet sich auch eine Frucht.";
        }
    }

    public class PflanzeWinselgras : BasisPflanze
    {
        public PflanzeWinselgras()
        {
            Name = "Winselgras";
            Bestimmung = 12;
            SeiteReferenz = 273;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override int GetBestimmung(string monat, string speziell, string landschaft)
        {
            if (speziell.Equals("Nacht") || speziell.Equals("Vollmondnacht (+/- 1 Tag)"))
                return -2;
            else
                return base.GetBestimmung(monat, speziell, landschaft);
        }

        public override string GetGefahr()
        {
            return "Das Heulen des Winselgrases kann einen um den Schlaf bringen und vermindert die nächtliche Regeneration um 2 Punkte.";
        }
    }

    public class PflanzeWirselkraut : BasisPflanze
    {
        public PflanzeWirselkraut()
        {
            Name = "Wirselkraut";
            Bestimmung = 5;
            SeiteReferenz = 273;
            Grundmenge = "W6+4 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeWuergedattel : BasisPflanze
    {
        public PflanzeWuergedattel()
        {
            Name = "Würgedattel";
            Bestimmung = 5;
            SeiteReferenz = 274;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }

        public override string GetGefahr()
        {
            return "Wer eine Frucht der Würgedattel berührt, wird von den Würgeschlingen der Pflanze attackiert.";
        }
    }

    public class PflanzeYaganstrauch : BasisPflanze
    {
        public PflanzeYaganstrauch()
        {
            Name = "Yaganstrauch";
            Bestimmung = 6;
            SeiteReferenz = 274;
            Grundmenge = "W6 Nüsse";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Boron");
        }
    }

    public class PflanzeZithabar : BasisPflanze
    {
        public PflanzeZithabar()
        {
            Name = "Zithabar";
            Bestimmung = 5;
            SeiteReferenz = 275;
            Grundmenge = "3W20 Blätter";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.HAEUFIG));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeZunderschwamm : BasisPflanze
    {
        public PflanzeZunderschwamm()
        {
            Name = "Zunderschwamm";
            Bestimmung = 4;
            SeiteReferenz = 275;
            Grundmenge = "W6 Pilze";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.HAEUFIG));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeZwoelfblatt : BasisPflanze
    {
        public PflanzeZwoelfblatt()
        {
            Name = "Zwölfblatt";
            Bestimmung = 5;
            SeiteReferenz = 276;
            Grundmenge = "12 Stängel";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }
    #endregion

    #region Pflanzen Wege der Alchemie
    public class PflanzeBraunschlinge : BasisPflanze
    {
        public PflanzeBraunschlinge()
        {
            Name = "Braunschlinge";
            Bestimmung = 6;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 192;
            Grundmenge = "vier Farnblätter und zwei je 3W6 Schritt lange Rangen (je nach Alter der Pflanze)";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeDergolasch : BasisPflanze
    {
        public PflanzeDergolasch()
        {
            Name = "Dergolasch";
            Bestimmung = 8;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 193;
            Grundmenge = "1W6 Pilzhüte";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
        }
    }

    public class PflanzeFelsenmilch : BasisPflanze
    {
        public PflanzeFelsenmilch()
        {
            Name = "Felsenmilch";
            Bestimmung = 4;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 193;
            Grundmenge = "1 Schank";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (trocken)", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeGruenerSchleimpilz : BasisPflanze
    {
        public PflanzeGruenerSchleimpilz()
        {
            Name = "Grüner Schleimpilz";
            Bestimmung = 6;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 194;
            Grundmenge = "1W20 Unzen";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (trocken)", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeLibellengras : BasisPflanze
    {
        public PflanzeLibellengras()
        {
            Name = "Libellengras";
            Bestimmung = 5;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 194;
            Grundmenge = "eine Frucht";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
        }
    }

    public class PflanzeLichtnebler : BasisPflanze
    {
        public PflanzeLichtnebler()
        {
            Name = "Lichtnebler";
            Bestimmung = 10;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 194;
            Grundmenge = "1 Skrupel Sporen";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (trocken)", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeSeelenhauch : BasisPflanze
    {
        public PflanzeSeelenhauch()
        {
            Name = "Seelenhauch";
            Bestimmung = 3;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 195;
            Grundmenge = "eine Blüte";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeSteinrinde : BasisPflanze
    {
        public PflanzeSteinrinde()
        {
            Name = "Steinrinde";
            Bestimmung = 12;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 195;
            Grundmenge = "1W6 Stein";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (trocken)", (int)EVorkommen.SELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    public class PflanzeWandermoos : BasisPflanze
    {
        public PflanzeWandermoos()
        {
            Name = "Wandermoos";
            Bestimmung = 14;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 196;
            Grundmenge = "ein Moosballen";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.SELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (trocken)", (int)EVorkommen.SEHRSELTEN));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }

    #endregion

    #region Musterpflanze
    public class PflanzeMuster : BasisPflanze
    {
        public PflanzeMuster()
        {
            Name = "Musterpflanze";
            Bestimmung = 0;
            Referenz = "Wege der Alchemie";
            SeiteReferenz = 2;
            Grundmenge = "";

            Verbreitung.Add(new VerbreitungsElementPflanzen("Eis", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wüste und Wüstenrand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Gebirge", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Hochland", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Steppe", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Grasland, Wiesen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Fluss- und Seeufer, Teiche", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Küste, Strand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Flussauen", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Sumpf und Moor", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Regenwald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Wald", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Waldrand", (int)EVorkommen.SEHRSELTEN));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (feucht)", (int)EVorkommen.GELEGENTLICH));
            Verbreitung.Add(new VerbreitungsElementPflanzen("Höhle (trocken)", (int)EVorkommen.GELEGENTLICH));

            Erntezeit.Add("Praios");
            Erntezeit.Add("Rondra");
            Erntezeit.Add("Efferd");
            Erntezeit.Add("Travia");
            Erntezeit.Add("Boron");
            Erntezeit.Add("Hesinde");
            Erntezeit.Add("Firun");
            Erntezeit.Add("Tsa");
            Erntezeit.Add("Phex");
            Erntezeit.Add("Peraine");
            Erntezeit.Add("Ingerimm");
            Erntezeit.Add("Rahja");
            Erntezeit.Add("Namenlose Tage");
        }
    }
    #endregion

}

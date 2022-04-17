using System.Collections;

namespace DSATool.Tiere
{
    public abstract class BasisTier
    {
        private string m_Name = "";
        private readonly string m_Referenz = "Zoo-Botanica Aventurica";
        private int m_SeiteZBA;
        private int m_Jagdschwierigkeit;
        private string m_Beute = "";
        private readonly ArrayList m_Verbreitung = new();

        public string Name
        {
            get { return m_Name; }
            init { m_Name = value; }
        }

        public string Referenz
        {
            get { return m_Referenz; }
        }

        public int SeiteReferenz
        {
            get { return m_SeiteZBA; }
            init { m_SeiteZBA = value; }
        }

        public int Jagdschwierigkeit
        {
            get { return m_Jagdschwierigkeit; }
            init { m_Jagdschwierigkeit = value; }
        }

        public string Beute
        {
            get { return m_Beute; }
            init { m_Beute = value; }
        }

        public ArrayList Verbreitung
        {
            get { return m_Verbreitung; }
        }
    }

    public static class Utility
    {
        private static readonly ArrayList tiere = new();
        private static readonly Dictionary<string, BasisTier> tier_by_name = new();

        public static ArrayList Tiere
        {
            get { return ArrayList.ReadOnly(tiere); }
        }

        public static BasisTier FindTierByName(string name)
        {
            return tier_by_name[name];
        }

        static Utility()
        {
            tiere.Add(new TierAffeBoronsaeffchen());
            tiere.Add(new TierAffeBruellaffe());
            tiere.Add(new TierAffeLoewenaffe());
            tiere.Add(new TierAffeMoosaffe());
            tiere.Add(new TierAffeOtanOtan());
            tiere.Add(new TierAffePurzelaffe());
            tiere.Add(new TierAffeRiesenaffe());
            tiere.Add(new TierAffeSumpfranze());
            tiere.Add(new TierAffeTotenkopfaeffchen());
            tiere.Add(new TierAffeZirkusaffe());
            tiere.Add(new TierAffeZuckeraffe());
            tiere.Add(new TierAntilopeAlKebirAntilope());
            tiere.Add(new TierAntilopeGabelantilope());
            tiere.Add(new TierAntilopeHalmarAntilope());
            tiere.Add(new TierAntilopeKaren());
            tiere.Add(new TierAntilopeSpringbock());
            tiere.Add(new TierAntilopeVytaggaAntilope());
            tiere.Add(new TierBaerBaumbaer());
            tiere.Add(new TierBaerBaumwuerger());
            tiere.Add(new TierBaerBorkenbaer());
            tiere.Add(new TierBaerFirunsbaer());
            tiere.Add(new TierBaerHoehlenbaer());
            tiere.Add(new TierBaerOrklandbaer());
            tiere.Add(new TierBaerSchwarzbaer());
            tiere.Add(new TierBaerGrimmbaer());
            tiere.Add(new TierDachsSchneedachs());
            tiere.Add(new TierDachsStreifendachs());
            tiere.Add(new TierDachsSuessmaul());
            tiere.Add(new TierElefantBrabakerWaldelefant());
            tiere.Add(new TierElefantMammut());
            tiere.Add(new TierElefantMastodon());
            tiere.Add(new TierElefantZwergelefant());
            tiere.Add(new TierFuchsGelbfuchs());
            tiere.Add(new TierFuchsRotfuchs());
            tiere.Add(new TierFuchsBlaufuchs());
            tiere.Add(new TierFuchsSilberfuchs());
            tiere.Add(new TierGefluegelAuerhahn());
            tiere.Add(new TierGefluegelEnte());
            tiere.Add(new TierGefluegelFasan());
            tiere.Add(new TierGefluegelRegenbogenfasan());
            tiere.Add(new TierGefluegelRebhuhn());
            tiere.Add(new TierGefluegelWachtel());
            tiere.Add(new TierGefluegelTrappe());
            tiere.Add(new TierHaseKarnickel());
            tiere.Add(new TierHaseOrklandkarnickel());
            tiere.Add(new TierHasePfeifhase());
            tiere.Add(new TierHaseRiesenloeffler());
            tiere.Add(new TierHaseRotpueschel());
            tiere.Add(new TierHaseSilberbock());
            tiere.Add(new TierHirschElch());
            tiere.Add(new TierHirschFirunshirsch());
            tiere.Add(new TierHirschKronenhirsch());
            tiere.Add(new TierHirschRehwild());
            tiere.Add(new TierHundSteppenhund());
            tiere.Add(new TierKatzeWildkatze());
            tiere.Add(new TierKlippechse());
            tiere.Add(new TierLoeweBergloewe());
            tiere.Add(new TierLoeweSandloewe());
            tiere.Add(new TierLoeweSchattenloewe());
            tiere.Add(new TierLoeweWaldloewe());
            tiere.Add(new TierLuchsFirnluchs());
            tiere.Add(new TierLuchsGaenseluchs());
            tiere.Add(new TierLuchsRaschtulsluchs());
            tiere.Add(new TierLuchsRotluchs());
            tiere.Add(new TierLuchsSonnenluchs());
            tiere.Add(new TierPantherFleckenpanther());
            tiere.Add(new TierPantherJaguar());
            tiere.Add(new TierPantherKhomgepard());
            tiere.Add(new TierRinderAuerochse());
            tiere.Add(new TierRinderFirnyak());
            tiere.Add(new TierRinderOngalobulle());
            tiere.Add(new TierRinderSteppenrind());
            tiere.Add(new TierRobbeFelsrobbe());
            tiere.Add(new TierRobbeMeerkalb());
            tiere.Add(new TierRobbeSeetiger());
            tiere.Add(new TierSaebelzahntigerDschungeltiger());
            tiere.Add(new TierSaebelzahntigerSilberloewe());
            tiere.Add(new TierSaebelzahntigerSteppentiger());
            tiere.Add(new TierSchreckkatze());
            tiere.Add(new TierSchweinMaraskanischesStachelschwein());
            tiere.Add(new TierSchweinWildschwein());
            tiere.Add(new TierSchweinWarzenschwein());
            tiere.Add(new TierStrauss());
            tiere.Add(new TierVielfrass());
            tiere.Add(new TierVielfrassBaumschleimer());
            tiere.Add(new TierZiegeGebirgsbock());

            foreach (BasisTier tier in tiere)
            {
                tier_by_name.Add(tier.Name, tier);
            }
        }
    }

    #region Tiere A-D
    public class TierAffeZirkusaffe : BasisTier
    {
        public TierAffeZirkusaffe()
        {
            Name = "Zirkusaffe";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 66;
            Beute = "0.5 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierAffePurzelaffe : BasisTier
    {
        public TierAffePurzelaffe()
        {
            Name = "Purzelaffe";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 66;
            Beute = "0.5 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierAffeMoosaffe : BasisTier
    {
        public TierAffeMoosaffe()
        {
            Name = "Moosaffe";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 66;
            Beute = "0.5 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierAffeLoewenaffe : BasisTier
    {
        public TierAffeLoewenaffe()
        {
            Name = "Löwenaffe";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 67;
            Beute = "0.5 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierAffeZuckeraffe : BasisTier
    {
        public TierAffeZuckeraffe()
        {
            Name = "Zuckeraffe";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 67;
            Beute = "0.5 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierAffeBoronsaeffchen : BasisTier
    {
        public TierAffeBoronsaeffchen()
        {
            Name = "Boronsäffchen";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 67;
            Beute = "0.5 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierAffeTotenkopfaeffchen : BasisTier
    {
        public TierAffeTotenkopfaeffchen()
        {
            Name = "Totenkopfäffchen";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 67;
            Beute = "0.5 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierAffeBruellaffe : BasisTier
    {
        public TierAffeBruellaffe()
        {
            Name = "Brüllaffe";
            Jagdschwierigkeit = 2;
            SeiteReferenz = 67;
            Beute = "bis 40 Rationen Fleisch (zäh), Fell (besser)";

            Verbreitung.Add("Regenwald");
        }
    }

    public class TierAffeOtanOtan : BasisTier
    {
        public TierAffeOtanOtan()
        {
            Name = "Otan-Otan";
            Jagdschwierigkeit = 2;
            SeiteReferenz = 67;
            Beute = "bis 40 Rationen Fleisch (zäh), Fell (besser)";

            Verbreitung.Add("Regenwald");
        }
    }

    public class TierAffeRiesenaffe : BasisTier
    {
        public TierAffeRiesenaffe()
        {
            Name = "Riesenaffe";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 67;
            Beute = "190 Rationen Fleisch (zäh), Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierAffeSumpfranze : BasisTier
    {
        public TierAffeSumpfranze()
        {
            Name = "Sumpfranze";
            Jagdschwierigkeit = 2;
            SeiteReferenz = 68;
            Beute = "25 Rationen Fleisch (ungenießbar), Fell (wertlos)";

            Verbreitung.Add("Sumpf");
        }
    }

    public class TierAntilopeAlKebirAntilope : BasisTier
    {
        public TierAntilopeAlKebirAntilope()
        {
            Name = "Al'Kebir-Antilope";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 69;
            Beute = "140 Rationen Fleisch, Geweih (Trophäe), Fell (besser) oder Leder (teuer)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierAntilopeHalmarAntilope : BasisTier
    {
        public TierAntilopeHalmarAntilope()
        {
            Name = "Halmar-Antilope";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 69;
            Beute = "15 Rationen Fleisch, Geweih (Trophäe), Fell (besser) oder Leder (teuer)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierAntilopeGabelantilope : BasisTier
    {
        public TierAntilopeGabelantilope()
        {
            Name = "Gabelantilope";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 69;
            Beute = "9 Rationen Fleisch, Geweih (Trophäe), Fell (besser) oder Leder (teuer)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Wüste und Wüstenrand");
        }
    }

    public class TierAntilopeKaren : BasisTier
    {
        public TierAntilopeKaren()
        {
            Name = "Karen";
            Jagdschwierigkeit = 10;
            SeiteReferenz = 70;
            Beute = "40 Rationen Fleisch, Geweih (Trophäe), Fell (besser) oder Leder (besser)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierAntilopeSpringbock : BasisTier
    {
        public TierAntilopeSpringbock()
        {
            Name = "Springbock";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 70;
            Beute = "19 Rationen Fleisch, Geweih (Trophäe), Fell (besser) oder Leder (teuer)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierAntilopeVytaggaAntilope : BasisTier
    {
        public TierAntilopeVytaggaAntilope()
        {
            Name = "Vy'Tagga-Antilope";
            Jagdschwierigkeit = 10;
            SeiteReferenz = 70;
            Beute = "15 Rationen Fleisch (ungenießbar), Geweih (Trophäe), Fell (besser) oder Leder (besser)";

            Verbreitung.Add("Waldrand");
        }
    }

    public class TierBaerBaumbaer : BasisTier
    {
        public TierBaerBaumbaer()
        {
            Name = "Baumbär";
            Jagdschwierigkeit = 6;
            SeiteReferenz = 72;
            Beute = "15-20 Rationen Fleisch (zäh), Fell (teuer)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierBaerBaumwuerger : BasisTier
    {
        public TierBaerBaumwuerger()
        {
            Name = "Baumwürger";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 73;
            Beute = "30 Rationen Fleisch (zäh), Fell (teuer)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierBaerBorkenbaer : BasisTier
    {
        public TierBaerBorkenbaer()
        {
            Name = "Borkenbär";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 73;
            Beute = "110 Rationen Fleisch, Fell (einfach)";

            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierBaerFirunsbaer : BasisTier
    {
        public TierBaerFirunsbaer()
        {
            Name = "Firunsbär";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 73;
            Beute = "600 Rationen Fleisch, Fell (Luxusartikel)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Küste, Strand");
        }
    }

    public class TierBaerHoehlenbaer : BasisTier
    {
        public TierBaerHoehlenbaer()
        {
            Name = "Höhlenbär";
            Jagdschwierigkeit = 6;
            SeiteReferenz = 73;
            Beute = "350 Rationen Fleisch, Fell (teuer)";

            Verbreitung.Add("Gebirge");
        }
    }

    public class TierBaerOrklandbaer : BasisTier
    {
        public TierBaerOrklandbaer()
        {
            Name = "Orklandbär";
            Jagdschwierigkeit = 7;
            SeiteReferenz = 73;
            Beute = "50 Rationen Fleisch, Fell (billig)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierBaerSchwarzbaer : BasisTier
    {
        public TierBaerSchwarzbaer()
        {
            Name = "Schwarzbär";
            Jagdschwierigkeit = 4;
            SeiteReferenz = 74;
            Beute = "380 Rationen Fleisch, Fell (Luxusartikel)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierBaerGrimmbaer : TierBaerSchwarzbaer
    {
        public TierBaerGrimmbaer()
        {
            Name = "Grimmbär";
        }
    }

    public class TierDachsStreifendachs : BasisTier
    {
        public TierDachsStreifendachs()
        {
            Name = "Streifendachs";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 77;
            Beute = "4 Rationen Fleisch, Fell (einfach)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierDachsSchneedachs : BasisTier
    {
        public TierDachsSchneedachs()
        {
            Name = "Schneedachs";
            Jagdschwierigkeit = 9;
            SeiteReferenz = 77;
            Beute = "5 Rationen Fleisch, Fell (einfach)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierDachsSuessmaul : BasisTier
    {
        public TierDachsSuessmaul()
        {
            Name = "Süßmauldachs";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 77;
            Beute = "4 Rationen Fleisch, Fell (einfach)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Waldrand");
        }
    }
    #endregion

    #region Tiere E-G
    public class TierElefantBrabakerWaldelefant : BasisTier
    {
        public TierElefantBrabakerWaldelefant()
        {
            Name = "Brabaker Waldelefant";
            Jagdschwierigkeit = 7;
            SeiteReferenz = 90;
            Beute = "1500 bis 2000 Rationen Fleisch, Haut (Leder, teuer), Stoßzähne (5 D je Stein / pro Zahn bis zu 15 Stein)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierElefantMastodon : BasisTier
    {
        public TierElefantMastodon()
        {
            Name = "Mastodon";
            Jagdschwierigkeit = 8;
            SeiteReferenz = 90;
            Beute = "1600 bis 2400 Rationen Fleisch, Haut (Fell oder Leder, teuer), Stoßzähne (3 D je Stein / pro Zahn bis zu 20 Stein)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierElefantMammut : BasisTier
    {
        public TierElefantMammut()
        {
            Name = "Mammut";
            Jagdschwierigkeit = 10;
            SeiteReferenz = 91;
            Beute = "2800 bis 3400 Rationen Fleisch, Haut (Fell oder Leder, teuer), Stoßzähne (4 D je Stein / pro Zahn bis zu 40 Stein)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierElefantZwergelefant : BasisTier
    {
        public TierElefantZwergelefant()
        {
            Name = "Zwergelefant";
            Jagdschwierigkeit = 4;
            SeiteReferenz = 91;
            Beute = "500 Rationen Fleisch, Haut (Fell oder Leder, teuer), Stoßzähne (3 D je Stein / pro Zahn bis zu 30 Stein)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierFuchsRotfuchs : BasisTier
    {
        public TierFuchsRotfuchs()
        {
            Name = "Rotfuchs";
            Jagdschwierigkeit = 9;
            SeiteReferenz = 98;
            Beute = "3 Rationen Fleisch (sehr zäh), Pelz (teuer)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierFuchsGelbfuchs : BasisTier
    {
        public TierFuchsGelbfuchs()
        {
            Name = "Gelbfuchs";
            Jagdschwierigkeit = 13;
            SeiteReferenz = 98;
            Beute = "3 Rationen Fleisch (sehr zäh), Pelz (billig)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierFuchsBlaufuchs : BasisTier
    {
        public TierFuchsBlaufuchs()
        {
            Name = "Blaufuchs";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 98;
            Beute = "3 Rationen Fleisch (sehr zäh), Pelz (Luxusartikel)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierFuchsSilberfuchs : TierFuchsBlaufuchs
    {
        public TierFuchsSilberfuchs()
        {
            Name = "Silberfuchs";
        }
    }

    public class TierGefluegelAuerhahn : BasisTier
    {
        public TierGefluegelAuerhahn()
        {
            Name = "Auerhahn";
            Jagdschwierigkeit = 6;
            SeiteReferenz = 100;
            Beute = "3 Rationen Fleisch";

            Verbreitung.Add("Wald");
        }
    }

    public class TierGefluegelEnte : BasisTier
    {
        public TierGefluegelEnte()
        {
            Name = "Ente";
            Jagdschwierigkeit = 6;
            SeiteReferenz = 100;
            Beute = "1 Ration Fleisch";

            Verbreitung.Add("Fluss- und Seeufer, Teiche");
            Verbreitung.Add("Flussauen");
        }
    }

    public class TierGefluegelFasan : BasisTier
    {
        public TierGefluegelFasan()
        {
            Name = "Fasan";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 100;
            Beute = "1 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierGefluegelRegenbogenfasan : BasisTier
    {
        public TierGefluegelRegenbogenfasan()
        {
            Name = "Regenbogenfasan";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 100;
            Beute = "1 Ration Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierGefluegelRebhuhn : BasisTier
    {
        public TierGefluegelRebhuhn()
        {
            Name = "Rebhuhn";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 100;
            Beute = "1 bis 2 Rationen Fleisch";

            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierGefluegelWachtel : BasisTier
    {
        public TierGefluegelWachtel()
        {
            Name = "Wachtel";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 100;
            Beute = "1/5 Ration Fleisch";

            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierGefluegelTrappe : BasisTier
    {
        public TierGefluegelTrappe()
        {
            Name = "Trappe";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 101;
            Beute = "5 Rationen Fleisch";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Fluss- und Seeufer, Teiche");
            Verbreitung.Add("Flussauen");
        }
    }
    #endregion

    #region Tiere H-K
    public class TierHaseKarnickel : BasisTier
    {
        public TierHaseKarnickel()
        {
            Name = "Karnickel";
            Jagdschwierigkeit = 7;
            SeiteReferenz = 108;
            Beute = "1 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierHaseOrklandkarnickel : BasisTier
    {
        public TierHaseOrklandkarnickel()
        {
            Name = "Orklandkarnickel";
            Jagdschwierigkeit = 7;
            SeiteReferenz = 109;
            Beute = "1 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierHasePfeifhase : BasisTier
    {
        public TierHasePfeifhase()
        {
            Name = "Pfeifhase";
            Jagdschwierigkeit = 7;
            SeiteReferenz = 109;
            Beute = "1 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierHaseRiesenloeffler : BasisTier
    {
        public TierHaseRiesenloeffler()
        {
            Name = "Riesenlöffler";
            Jagdschwierigkeit = 4;
            SeiteReferenz = 109;
            Beute = "2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Waldrand");
        }
    }

    public class TierHaseRotpueschel : BasisTier
    {
        public TierHaseRotpueschel()
        {
            Name = "Rotpüschel";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 109;
            Beute = "1 Ration Fleisch, Fell (besser)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierHaseSilberbock : BasisTier
    {
        public TierHaseSilberbock()
        {
            Name = "Silberbock";
            Jagdschwierigkeit = 10;
            SeiteReferenz = 109;
            Beute = "1 bis 2 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierHirschElch : BasisTier
    {
        public TierHirschElch()
        {
            Name = "Elch";
            Jagdschwierigkeit = 4;
            SeiteReferenz = 110;
            Beute = "450 Rationen Fleisch, Geweih (Trophäe), Fell (besser) oder Leder (teuer)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierHirschKronenhirsch : BasisTier
    {
        public TierHirschKronenhirsch()
        {
            Name = "Kronenhirsch";
            Jagdschwierigkeit = 6;
            SeiteReferenz = 110;
            Beute = "110 Rationen Fleisch, Geweih (Trophäe), Fell (teuer) oder Leder (teuer)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierHirschRehwild : BasisTier
    {
        public TierHirschRehwild()
        {
            Name = "Rehwild";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 110;
            Beute = "11 Rationen Fleisch, Geweih (Trophäe), Fell (besser) oder Leder (teuer)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierHirschFirunshirsch : BasisTier
    {
        public TierHirschFirunshirsch()
        {
            Name = "Firunshirsch";
            Jagdschwierigkeit = 8;
            SeiteReferenz = 110;
            Beute = "60 Rationen Fleisch, Geweih (Trophäe), Fell (teuer, in reinem Weiß Luxusware) oder Leder (teuer)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierHundSteppenhund : BasisTier
    {
        public TierHundSteppenhund()
        {
            Name = "Steppenhund";
            Jagdschwierigkeit = 10;
            SeiteReferenz = 116;
            Beute = "12 Rationen Fleisch (zäh), Fell (billig)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierKatzeWildkatze : BasisTier
    {
        public TierKatzeWildkatze()
        {
            Name = "Wildkatze";
            Jagdschwierigkeit = 20;
            SeiteReferenz = 120;
            Beute = "3 Rationen Fleisch, Fell (einfach)";

            Verbreitung.Add("Grasland, Wiesen");
            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierKlippechse : BasisTier
    {
        public TierKlippechse()
        {
            Name = "Klippechse";
            Jagdschwierigkeit = 7;
            SeiteReferenz = 121;
            Beute = "10 Rationen Fleisch, Haut (Leder, teuer), Eier (diverse alchemistische Anwendungen)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Fluss- und Seeufer, Teiche");
            Verbreitung.Add("Sumpf und Moor");
        }
    }
    #endregion

    #region Tiere L-M
    public class TierLoeweBergloewe : BasisTier
    {
        public TierLoeweBergloewe()
        {
            Name = "Berglöwe";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 128;
            Beute = "65 Rationen Fleisch, Fell (Luxusartikel)";

            Verbreitung.Add("Gebirge");
        }
    }

    public class TierLoeweSandloewe : BasisTier
    {
        public TierLoeweSandloewe()
        {
            Name = "Sandlöwe";
            Jagdschwierigkeit = 6;
            SeiteReferenz = 128;
            Beute = "100 Rationen Fleisch, Fell (Luxusartikel)";

            Verbreitung.Add("Wüste und Wüstenrand");
            Verbreitung.Add("Steppe");
        }
    }

    public class TierLoeweSchattenloewe : BasisTier
    {
        public TierLoeweSchattenloewe()
        {
            Name = "Lioma";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 128;
            Beute = "90 Rationen Fleisch, Fell (Luxusartikel)";

            Verbreitung.Add("Regenwald");
        }
    }

    public class TierLoeweWaldloewe : BasisTier
    {
        public TierLoeweWaldloewe()
        {
            Name = "Waldlöwe";
            Jagdschwierigkeit = 9;
            SeiteReferenz = 128;
            Beute = "60 Rationen Fleisch, Fell (Luxusartikel)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierLuchsRotluchs : BasisTier
    {
        public TierLuchsRotluchs()
        {
            Name = "Rotluchs";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 129;
            Beute = "10 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierLuchsRaschtulsluchs : BasisTier
    {
        public TierLuchsRaschtulsluchs()
        {
            Name = "Raschtulsluchs";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 129;
            Beute = "10 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierLuchsSonnenluchs : BasisTier
    {
        public TierLuchsSonnenluchs()
        {
            Name = "Sonnenluchs";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 129;
            Beute = "10 Rationen Fleisch, Fell (besser)";

            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierLuchsFirnluchs : BasisTier
    {
        public TierLuchsFirnluchs()
        {
            Name = "Firnluchs";
            Jagdschwierigkeit = 20;
            SeiteReferenz = 129;
            Beute = "12 Rationen Fleisch, Fell (teuer)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierLuchsGaenseluchs : BasisTier
    {
        public TierLuchsGaenseluchs()
        {
            Name = "Gänseluchs";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 129;
            Beute = "3 Rationen Fleisch, Fell (einfach)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }
    #endregion

    #region Tiere N-R
    public class TierPantherJaguar : TierPantherFleckenpanther
    {
        public TierPantherJaguar()
        {
            Name = "Jaguar";
        }
    }

    public class TierPantherFleckenpanther : BasisTier
    {
        public TierPantherFleckenpanther()
        {
            Name = "Fleckenpanther";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 147;
            Beute = "40 Rationen Fleisch, Fell (Luxusartikel)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierPantherKhomgepard : BasisTier
    {
        public TierPantherKhomgepard()
        {
            Name = "Khômgepard";
            Jagdschwierigkeit = 15;
            SeiteReferenz = 147;
            Beute = "15 Rationen Fleisch, Fell (Luxusartikel)";

            Verbreitung.Add("Wüste und Wüstenrand");
            Verbreitung.Add("Steppe");
        }
    }

    public class TierRinderAuerochse : BasisTier
    {
        public TierRinderAuerochse()
        {
            Name = "Auerochse";
            Jagdschwierigkeit = 8;
            SeiteReferenz = 158;
            Beute = "550 Rationen Fleisch, Hörner (Trophäe), Haut (einfach), Leder (teuer)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierRinderFirnyak : BasisTier
    {
        public TierRinderFirnyak()
        {
            Name = "Firnyak";
            Jagdschwierigkeit = 7;
            SeiteReferenz = 158;
            Beute = "140 Rationen Fleisch, Hörner (Trophäe), Fell (teuer, in reinem weiß Luxusware) oder Leder (teuer)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierRinderOngalobulle : BasisTier
    {
        public TierRinderOngalobulle()
        {
            Name = "Ongalobulle";
            Jagdschwierigkeit = 4;
            SeiteReferenz = 159;
            Beute = "300 Rationen Fleisch, Hörner (Trophäe), Haut (einfach), Leder (besser)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierRinderSteppenrind : BasisTier
    {
        public TierRinderSteppenrind()
        {
            Name = "Steppenrind";
            Jagdschwierigkeit = 12;
            SeiteReferenz = 159;
            Beute = "600 Rationen Fleisch, Hörner (Trophäe), Haut (einfach), Leder (teuer)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierRobbeFelsrobbe : BasisTier
    {
        public TierRobbeFelsrobbe()
        {
            Name = "Felsrobbe";
            Jagdschwierigkeit = 2;
            SeiteReferenz = 160;
            Beute = "bis 45 Rationen Fleisch, Talg (Fett, Öl, 5 S), Tran (1 D), Haut (Fell, besser, von Jungtieren teuer)";

            Verbreitung.Add("Küste, Strand");
        }
    }

    public class TierRobbeMeerkalb : BasisTier
    {
        public TierRobbeMeerkalb()
        {
            Name = "Meerkalb";
            Jagdschwierigkeit = 8;
            SeiteReferenz = 160;
            Beute = "bis 250 Rationen Fleisch, Tran (5-7 D), Haut (Leder, besser)";

            Verbreitung.Add("Küste, Strand");
        }
    }

    public class TierRobbeSeetiger : BasisTier
    {
        public TierRobbeSeetiger()
        {
            Name = "Seetiger";
            Jagdschwierigkeit = 13;
            SeiteReferenz = 160;
            Beute = "250-300 Rationen Fleisch, Tran (12-15 D), Haut (Leder, besser), Bein (teuer), Ambra (3 D)";

            Verbreitung.Add("Küste, Strand");
        }
    }
    #endregion

    #region Tiere S-Z
    public class TierSaebelzahntigerSteppentiger : BasisTier
    {
        public TierSaebelzahntigerSteppentiger()
        {
            Name = "Steppentiger";
            Jagdschwierigkeit = 10;
            SeiteReferenz = 162;
            Beute = "100 Rationen Fleisch, Fell (Luxusartikel), Zähne (Trophäe)";

            Verbreitung.Add("Steppe");
        }
    }

    public class TierSaebelzahntigerDschungeltiger : BasisTier
    {
        public TierSaebelzahntigerDschungeltiger()
        {
            Name = "Dschungeltiger";
            Jagdschwierigkeit = 10;
            SeiteReferenz = 162;
            Beute = "100 Rationen Fleisch, Fell (Luxusartikel), Zähne (Trophäe)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierSaebelzahntigerSilberloewe : BasisTier
    {
        public TierSaebelzahntigerSilberloewe()
        {
            Name = "Silberlöwe";
            Jagdschwierigkeit = 10;
            SeiteReferenz = 163;
            Beute = "100 Rationen Fleisch, Fell (Luxusartikel), Zähne (Trophäe)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierSchreckkatze : BasisTier
    {
        public TierSchreckkatze()
        {
            Name = "Schreckkatze";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 169;
            Beute = "12 Rationen Fleisch (nur für Orks und Goblins genießbar), Fell wertlos";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierSchweinMaraskanischesStachelschwein : BasisTier
    {
        public TierSchweinMaraskanischesStachelschwein()
        {
            Name = "Maraskanisches Stachelschwein";
            Jagdschwierigkeit = 7;
            SeiteReferenz = 172;
            Beute = "1 Ration Fleisch, 2W20+30 Stacheln (FF-Probe, um sie inklusive Giftdrüse aus dem Tier zu ziehen)";

            Verbreitung.Add("Steppe");
            Verbreitung.Add("Regenwald");
        }
    }

    public class TierSchweinWildschwein : BasisTier
    {
        public TierSchweinWildschwein()
        {
            Name = "Wildschwein";
            Jagdschwierigkeit = 2;
            SeiteReferenz = 173;
            Beute = "bis 130 Rationen Fleisch, Hauer (Trophäe), Fell (billig) oder Leder (einfach)";

            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }

    public class TierSchweinWarzenschwein : BasisTier
    {
        public TierSchweinWarzenschwein()
        {
            Name = "Warzenschwein";
            Jagdschwierigkeit = 2;
            SeiteReferenz = 173;
            Beute = "bis 130 Rationen Fleisch, Hauer (Trophäe), Fell (billig) oder Leder (einfach)";

            Verbreitung.Add("Wald");
        }
    }
    public class TierStrauss : BasisTier
    {
        public TierStrauss()
        {
            Name = "Strauß";
            Jagdschwierigkeit = 4;
            SeiteReferenz = 180;
            Beute = "50 Rationen Fleisch, 15 bis 60 Eier im Nest (jedes Ei eine Ration), Gefieder (teuer)";

            Verbreitung.Add("Wüste und Wüstenrand");
            Verbreitung.Add("Steppe");
        }
    }

    public class TierVielfrass : BasisTier
    {
        public TierVielfrass()
        {
            Name = "Vielfraß";
            Jagdschwierigkeit = 6;
            SeiteReferenz = 182;
            Beute = "8 Rationen Fleisch (ungenießbar), Fell (besser)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierVielfrassBaumschleimer : BasisTier
    {
        public TierVielfrassBaumschleimer()
        {
            Name = "Baumschleimer";
            Jagdschwierigkeit = 5;
            SeiteReferenz = 183;
            Beute = "6 Rationen Fleisch (ungenießbar), Fell (wertlos)";

            Verbreitung.Add("Wald");
        }
    }

    public class TierZiegeGebirgsbock : BasisTier
    {
        public TierZiegeGebirgsbock()
        {
            Name = "Gebirgsbock";
            Jagdschwierigkeit = 20;
            SeiteReferenz = 189;
            Beute = "60 Rationen Fleisch (zäh), Fell (einfach), Horn (Trophäe)";

            Verbreitung.Add("Gebirge");
        }
    }

    #endregion

    #region Mustertier
    public class TierMuster : BasisTier
    {
        public TierMuster()
        {
            Name = "Mustertier";
            Jagdschwierigkeit = 0;
            SeiteReferenz = 2;
            Beute = "";

            Verbreitung.Add("Eis");
            Verbreitung.Add("Wüste und Wüstenrand");
            Verbreitung.Add("Gebirge");
            Verbreitung.Add("Hochland");
            Verbreitung.Add("Steppe");
            Verbreitung.Add("Grasland, Wiesen");
            Verbreitung.Add("Fluss- und Seeufer, Teiche");
            Verbreitung.Add("Küste, Strand");
            Verbreitung.Add("Flussauen");
            Verbreitung.Add("Sumpf und Moor");
            Verbreitung.Add("Regenwald");
            Verbreitung.Add("Wald");
            Verbreitung.Add("Waldrand");
        }
    }
    #endregion

}


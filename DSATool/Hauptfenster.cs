using DSATool.Pflanzen;
using DSATool.Regionen;
using DSATool.Tiere;
using System.Collections;

namespace DSATool
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            InitializeRegionFields();
            LoadSettings();
        }

        #region WinFormsAndHelper
        /// <summary>
        /// Sortiert die Elemente in der ComboBox alphabetisch
        /// </summary>
        /// <param name="box">Die zu sortierende ComboBox</param>
        private static void SortComboBoxItemsAlphabetically(ComboBox box)
        {
            object[] SortedItems = new object[box.Items.Count];
            box.Items.CopyTo(SortedItems, 0);
            Array.Sort(SortedItems);
            box.Items.Clear();
            box.Items.AddRange(SortedItems);
        }

        /// <summary>
        /// Listet alle Regionen in den zugehörigen Auswahlboxen auf. Die Sortierreihenfolge ist wie in der ZBA, d.h. grob Nord nach Süd.
        /// </summary>
        private void InitializeRegionFields()
        {
            foreach (BasisRegion region in Regionen.Utility.Regionen)
            {
                if (region.Pflanzen.Count > 0)
                    Kraeuter_BoxRegion.Items.Add(region.Name);
                if (region.EssbarePflanzen != (int)EVorkommen.KEINE)
                    Nahrung_BoxRegion.Items.Add(region.Name);
                if (region.Tiere.Count > 0)
                    Jagd_BoxRegion.Items.Add(region.Name);
                Fischen_BoxRegion.Items.Add(region.Name);
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            if (About_Reset.Checked)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Kraeuter_MU = Kraeuter_MU.Value;
                Properties.Settings.Default.Kraeuter_IN = Kraeuter_IN.Value;
                Properties.Settings.Default.Kraeuter_FF = Kraeuter_FF.Value;
                Properties.Settings.Default.Kraeuter_Sinnesschaerfe = Kraeuter_TAWSinnes.Value;
                Properties.Settings.Default.Kraeuter_Wildnisleben = Kraeuter_TAWWildnis.Value;
                Properties.Settings.Default.Kraeuter_Pflanzenkunde = Kraeuter_TAWPflanzen.Value;
                Properties.Settings.Default.Nahrung_MU = Nahrung_MU.Value;
                Properties.Settings.Default.Nahrung_IN = Nahrung_IN.Value;
                Properties.Settings.Default.Nahrung_FF = Nahrung_FF.Value;
                Properties.Settings.Default.Nahrung_Sinnesschaerfe = Nahrung_TAWSinnes.Value;
                Properties.Settings.Default.Nahrung_Wildnisleben = Nahrung_TAWWildnis.Value;
                Properties.Settings.Default.Nahrung_Pflanzenkunde = Nahrung_TAWPflanzen.Value;
                Properties.Settings.Default.Nahrung_Ackerbau = Nahrung_TAWAckerbau.Value;
                Properties.Settings.Default.Jagd_MU = Jagd_MU.Value;
                Properties.Settings.Default.Jagd_IN = Jagd_IN.Value;
                Properties.Settings.Default.Jagd_GE = Jagd_GE.Value;
                Properties.Settings.Default.Jagd_Faehrtensuche = Jagd_TAWFaehrtensuche.Value;
                Properties.Settings.Default.Jagd_Wildnisleben = Jagd_TAWWildnisleben.Value;
                Properties.Settings.Default.Jagd_Tierkunde = Jagd_TAWTierkunde.Value;
                Properties.Settings.Default.Jagd_Schleichen = Jagd_TAWSchleichen.Value;
                Properties.Settings.Default.Jagd_SichVerstecken = Jagd_TAWSichVerstecken.Value;
                Properties.Settings.Default.Jagd_Fernkampfwaffe = Jagd_TAWFernkampfwaffe.Value;
                Properties.Settings.Default.Jagd_Scharfschuetze = Jagd_IstScharfschuetze.Checked;
                Properties.Settings.Default.Jagd_Meisterschuetze = Jagd_IstMeisterschuetze.Checked;
                Properties.Settings.Default.Fischen_IN = Fischen_IN.Value;
                Properties.Settings.Default.Fischen_KL = Fischen_KL.Value;
                Properties.Settings.Default.Fischen_FF = Fischen_FF.Value;
                Properties.Settings.Default.Fischen_KK = Fischen_KK.Value;
                Properties.Settings.Default.Fischen_FischenAngeln = Fischen_TAWFischen.Value;
                Properties.Settings.Default.Fischen_Fallenstellen = Fischen_TAWFallenstellen.Value;
                Properties.Settings.Default.About_ManuelleEingabe = About_Manuell.Checked;
                Properties.Settings.Default.About_CharakterKopplung = About_Kopplung.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void LoadSettings()
        {
            Kraeuter_MU.Value = Properties.Settings.Default.Kraeuter_MU;
            Kraeuter_IN.Value = Properties.Settings.Default.Kraeuter_IN;
            Kraeuter_FF.Value = Properties.Settings.Default.Kraeuter_FF;
            Kraeuter_TAWSinnes.Value = Properties.Settings.Default.Kraeuter_Sinnesschaerfe;
            Kraeuter_TAWWildnis.Value = Properties.Settings.Default.Kraeuter_Wildnisleben;
            Kraeuter_TAWPflanzen.Value = Properties.Settings.Default.Kraeuter_Pflanzenkunde;
            Nahrung_MU.Value = Properties.Settings.Default.Nahrung_MU;
            Nahrung_IN.Value = Properties.Settings.Default.Nahrung_IN;
            Nahrung_FF.Value = Properties.Settings.Default.Nahrung_FF;
            Nahrung_TAWSinnes.Value = Properties.Settings.Default.Nahrung_Sinnesschaerfe;
            Nahrung_TAWWildnis.Value = Properties.Settings.Default.Nahrung_Wildnisleben;
            Nahrung_TAWPflanzen.Value = Properties.Settings.Default.Nahrung_Pflanzenkunde;
            Nahrung_TAWAckerbau.Value = Properties.Settings.Default.Nahrung_Ackerbau;
            Jagd_MU.Value = Properties.Settings.Default.Jagd_MU;
            Jagd_IN.Value = Properties.Settings.Default.Jagd_IN;
            Jagd_GE.Value = Properties.Settings.Default.Jagd_GE;
            Jagd_TAWFaehrtensuche.Value = Properties.Settings.Default.Jagd_Faehrtensuche;
            Jagd_TAWWildnisleben.Value = Properties.Settings.Default.Jagd_Wildnisleben;
            Jagd_TAWTierkunde.Value = Properties.Settings.Default.Jagd_Tierkunde;
            Jagd_TAWSchleichen.Value = Properties.Settings.Default.Jagd_Schleichen;
            Jagd_TAWSichVerstecken.Value = Properties.Settings.Default.Jagd_SichVerstecken;
            Jagd_TAWFernkampfwaffe.Value = Properties.Settings.Default.Jagd_Fernkampfwaffe;
            Jagd_IstScharfschuetze.Checked = Properties.Settings.Default.Jagd_Scharfschuetze;
            Jagd_IstMeisterschuetze.Checked = Properties.Settings.Default.Jagd_Meisterschuetze;
            Fischen_IN.Value = Properties.Settings.Default.Fischen_IN;
            Fischen_KL.Value = Properties.Settings.Default.Fischen_KL;
            Fischen_FF.Value = Properties.Settings.Default.Fischen_FF;
            Fischen_KK.Value = Properties.Settings.Default.Fischen_KK;
            Fischen_TAWFischen.Value = Properties.Settings.Default.Fischen_FischenAngeln;
            Fischen_TAWFallenstellen.Value = Properties.Settings.Default.Fischen_Fallenstellen;
            About_Manuell.Checked = Properties.Settings.Default.About_ManuelleEingabe;
            About_Kopplung.Checked = Properties.Settings.Default.About_CharakterKopplung;
        }

        #endregion

        #region Methode zur Talentprobe
        /// <summary>
        /// Führt eine Talentprobe mit einem angegebenen Talentwert gegen eine definierte Erschwernis durch und gibt das Ergebnis in einem Textfeld aus.
        /// </summary>
        /// <param name="eig1">Erste Eigenschaft</param>
        /// <param name="eig2">Zweite Eigenschaft</param>
        /// <param name="eig3">Dritte Eigenschaft</param>
        /// <param name="taw">Talentwert</param>
        /// <param name="erschwernis">Probenerschwernis</param>
        /// <param name="tapstern">gibt TaP* zurück</param>
        /// <param name="box">TextBox in welcher Ausgabe erfolgen soll</param>
        /// <returns>true, wenn Probe gelungen</returns>
        private bool Talentprobe(int eig1, int eig2, int eig3, int taw, int erschwernis, out int tapstern, TextBox box)
        {
            Random rand = new();
            int[] wuerfel = new int[] { rand.Next(1, 21), rand.Next(1, 21), rand.Next(1, 21) };
            if (About_Manuell.Checked)
            {
                Wuerfeleingabe dialog = new();
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    wuerfel[0] = dialog.Wuerfelwurf1;
                    wuerfel[1] = dialog.Wuerfelwurf2;
                    wuerfel[2] = dialog.Wuerfelwurf3;
                }
            }

            string zuschlag;
            if (erschwernis < 0)
                zuschlag = erschwernis.ToString();
            else
                zuschlag = "+" + erschwernis.ToString();

            box.Text = "Bei einem Zuschlag von " + zuschlag + " und einem TaW von " + taw + " wurde " + wuerfel[0] + " / " + wuerfel[1] + " / " + wuerfel[2] + " gewürfelt.\r\n";

            int efftaw = taw - erschwernis;

            if (efftaw >= 0)
            {
                if (wuerfel[0] > eig1)
                    efftaw -= wuerfel[0] - eig1;
                if (wuerfel[1] > eig2)
                    efftaw -= wuerfel[1] - eig2;
                if (wuerfel[2] > eig3)
                    efftaw -= wuerfel[2] - eig3;
            }
            else
            {
                if (wuerfel[0] <= eig1 + efftaw)
                    if (wuerfel[1] <= eig2 + efftaw)
                        if (wuerfel[2] <= eig3 + efftaw)
                            efftaw = 0;
            }

            // Check ob Glückliche Probe oder Patzer
            if ((wuerfel[0] == 1 && wuerfel[1] == 1) || (wuerfel[1] == 1 && wuerfel[2] == 1) || (wuerfel[0] == 1 && wuerfel[2] == 1))
            {
                if (efftaw <= 0)
                    tapstern = 1;
                else
                    tapstern = efftaw;

                box.Text += "Spektakulärer Erfolg! (Spezielle Erfahrung)\r\n";

                return true;
            }
            if ((wuerfel[0] == 20 && wuerfel[1] == 20) || (wuerfel[1] == 20 && wuerfel[2] == 20) || (wuerfel[0] == 20 && wuerfel[2] == 20))
            {
                tapstern = -1;

                box.Text += "Katastrophaler Misserfolg! (Spezielle Erfahrung)\r\n";

                return false;
            }

            // Reguläre Auswertung
            if (efftaw >= 0)
            {
                if (efftaw == 0)
                {
                    tapstern = 1;
                }
                else if (efftaw > taw)
                {
                    tapstern = taw;
                    tapstern = Math.Max(1, tapstern);
                }
                else
                {
                    tapstern = efftaw;
                }

                return true;
            }
            else
            {
                tapstern = -1;
                return false;
            }
        }
        #endregion

        #region Kräutersuche - Eigenschaften, Talente, Checkboxen
        private void Kraeuter_MU_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Nahrung_MU.Value = Kraeuter_MU.Value;
                Jagd_MU.Value = Kraeuter_MU.Value;
            }
        }

        private void Kraeuter_IN_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Nahrung_IN.Value = Kraeuter_IN.Value;
                Jagd_IN.Value = Kraeuter_IN.Value;
                Fischen_IN.Value = Kraeuter_IN.Value;
            }
        }

        private void Kraeuter_FF_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Nahrung_FF.Value = Kraeuter_FF.Value;
                Fischen_FF.Value = Kraeuter_FF.Value;
            }
        }

        private void Kraeuter_TAWKraeuter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Kraeuter_TAWSinnes_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWKraeutersuche();
            if (About_Kopplung.Checked)
                Nahrung_TAWSinnes.Value = Kraeuter_TAWSinnes.Value;
        }

        private void Kraeuter_TAWWildnis_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWKraeutersuche();
            if (About_Kopplung.Checked)
            {
                Nahrung_TAWWildnis.Value = Kraeuter_TAWWildnis.Value;
                Jagd_TAWWildnisleben.Value = Kraeuter_TAWWildnis.Value;
            }
        }

        private void Kraeuter_TAWPflanzen_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWKraeutersuche();
            if (About_Kopplung.Checked)
                Nahrung_TAWPflanzen.Value = Kraeuter_TAWPflanzen.Value;
        }

        private void BerechneTAWKraeutersuche()
        {
            Kraeuter_TAWKraeuter.Value = Math.Round((Kraeuter_TAWSinnes.Value + Kraeuter_TAWWildnis.Value + Kraeuter_TAWPflanzen.Value) / 3, MidpointRounding.AwayFromZero);

            if (Kraeuter_TAWKraeuter.Value > 2 * Kraeuter_TAWSinnes.Value)
                Kraeuter_TAWKraeuter.Value = 2 * Kraeuter_TAWSinnes.Value;
            if (Kraeuter_TAWKraeuter.Value > 2 * Kraeuter_TAWWildnis.Value)
                Kraeuter_TAWKraeuter.Value = 2 * Kraeuter_TAWWildnis.Value;
            if (Kraeuter_TAWKraeuter.Value > 2 * Kraeuter_TAWPflanzen.Value)
                Kraeuter_TAWKraeuter.Value = 2 * Kraeuter_TAWPflanzen.Value;
        }

        private void Kraeuter_HatSuchdauerVerdoppelt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Kraeuter_HatOrtskenntnis_CheckedChanged(object sender, EventArgs e)
        {
            Kraeuter_BoxPflanze_SelectedIndexChanged(null, null);
        }

        private void Kraeuter_HatGelaendekunde_CheckedChanged(object sender, EventArgs e)
        {
            Kraeuter_BoxPflanze_SelectedIndexChanged(null, null);
        }
        #endregion

        #region Kräutersuche - Auswahlboxen: Suchmonat, Speziell, Region, Landschaft, Pflanzen
        private void Kraeuter_BoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kraeuter_BoxLandschaft.Text = "";
            Kraeuter_BoxLandschaft.Items.Clear();
            Kraeuter_BoxPflanze.Text = "";
            Kraeuter_BoxPflanze.Items.Clear();

            BasisRegion region = Regionen.Utility.FindRegionByName(Kraeuter_BoxRegion.SelectedItem.ToString());

            //Fügt alle in der Region gespeicherten Pflanzen hinzu
            foreach (string pflanze in region.Pflanzen)
            {
                Kraeuter_BoxPflanze.Items.Add(pflanze);
            }
            SortComboBoxItemsAlphabetically(Kraeuter_BoxPflanze);
            //Fügte alle in der Region gespeicherten Landschaften hinzu
            foreach (string landschaft in region.Landschaften)
            {
                Kraeuter_BoxLandschaft.Items.Add(landschaft);
            }
            SortComboBoxItemsAlphabetically(Kraeuter_BoxLandschaft);

            //Entfernt Blutblatt und Karain, falls kein astraler Ort gewählt
            //Entfernt Schwarzer Mohn, falls nicht Palakar gewählt
            for (int i = Kraeuter_BoxPflanze.Items.Count - 1; i >= 0; i--)
            {
                string pflanze = Kraeuter_BoxPflanze.Items[i].ToString();

                if ((pflanze.Equals("Kairan") || pflanze.Equals("Blutblatt")) && !Kraeuter_BoxBesonderheiten.SelectedItem.ToString().Equals("Astral durchzogener Ort"))
                {
                    Kraeuter_BoxPflanze.Items.RemoveAt(i);
                    continue;
                }

                if (pflanze.Equals("Schwarzer Mohn") && !Kraeuter_BoxBesonderheiten.SelectedItem.ToString().Equals("Palakar (Schwarze Stadt)"))
                {
                    Kraeuter_BoxPflanze.Items.RemoveAt(i);
                    continue;
                }
            }

            //Entfernt die nicht im Suchmonat erntebaren Pflanzen
            if (!Kraeuter_BoxSuchmonat.SelectedItem.ToString().Equals("Komplettes Jahr"))
            {
                for (int i = Kraeuter_BoxPflanze.Items.Count - 1; i >= 0; i--)
                {
                    BasisPflanze pflanze = Pflanzen.Utility.FindPflanzeByName(Kraeuter_BoxPflanze.Items[i].ToString());

                    ArrayList erntezeit = pflanze.GetErntezeit(Kraeuter_BoxRegion.SelectedItem.ToString());
                    if (!erntezeit.Contains(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                    {
                        Kraeuter_BoxPflanze.Items.RemoveAt(i);
                        continue;
                    }
                }
            }

            Kraeuter_Zuschlag.Text = "";
        }

        private void Kraeuter_BoxLandschaft_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kraeuter_BoxPflanze.Text = "";
            Kraeuter_BoxPflanze.Items.Clear();

            BasisRegion region = Regionen.Utility.FindRegionByName(Kraeuter_BoxRegion.SelectedItem.ToString());

            //Fügt alle in der Region gespeicherten Pflanzen hinzu
            foreach (string pflanze in region.Pflanzen)
            {
                Kraeuter_BoxPflanze.Items.Add(pflanze);
            }
            SortComboBoxItemsAlphabetically(Kraeuter_BoxPflanze);

            //Entfernt die nicht in der gewählten Landschaft vorkommenden Pflanzen der Region
            for (int i = Kraeuter_BoxPflanze.Items.Count - 1; i >= 0; i--)
            {
                BasisPflanze pflanze = Pflanzen.Utility.FindPflanzeByName(Kraeuter_BoxPflanze.Items[i].ToString());

                bool delete = true;
                foreach (VerbreitungsElementPflanzen v in pflanze.GetVerbreitung(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                {
                    if (v.Landschaft.Equals(Kraeuter_BoxLandschaft.SelectedItem.ToString()))
                        delete = false;
                }
                if (delete)
                    Kraeuter_BoxPflanze.Items.RemoveAt(i);
            }

            //Entfernt Blutblatt und Karain, falls kein astraler Ort gewählt
            //Entfernt Schwarzer Mohn, falls nicht Palakar gewählt
            for (int i = Kraeuter_BoxPflanze.Items.Count - 1; i >= 0; i--)
            {
                string pflanze = Kraeuter_BoxPflanze.Items[i].ToString();

                if ((pflanze.Equals("Kairan") || pflanze.Equals("Blutblatt")) && !Kraeuter_BoxBesonderheiten.SelectedItem.ToString().Equals("Astral durchzogener Ort"))
                {
                    Kraeuter_BoxPflanze.Items.RemoveAt(i);
                    continue;
                }

                if (pflanze.Equals("Schwarzer Mohn") && !Kraeuter_BoxBesonderheiten.SelectedItem.ToString().Equals("Palakar (Schwarze Stadt)"))
                {
                    Kraeuter_BoxPflanze.Items.RemoveAt(i);
                    continue;
                }
            }

            //Entfernt die nicht im Suchmonat erntebaren Pflanzen
            if (!Kraeuter_BoxSuchmonat.SelectedItem.ToString().Equals("Komplettes Jahr"))
            {
                for (int i = Kraeuter_BoxPflanze.Items.Count - 1; i >= 0; i--)
                {
                    BasisPflanze pflanze = Pflanzen.Utility.FindPflanzeByName(Kraeuter_BoxPflanze.Items[i].ToString());

                    ArrayList erntezeit = pflanze.GetErntezeit(Kraeuter_BoxRegion.SelectedItem.ToString());
                    if (!erntezeit.Contains(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                    {
                        Kraeuter_BoxPflanze.Items.RemoveAt(i);
                        continue;
                    }
                }
            }

            Kraeuter_Zuschlag.Text = "";
        }

        private bool Kraeuter_BerechneAktuelleProbenErschwernisUndSuchchwierigkeit(out int erschwernis, out int suchschwierigkeit)
        {
            bool alleNoetigenFelderAusgefuellt = true;

            //Prüfung ob Bedingungen für Berechnung des Zuschlag gegeben sind und alle Felder die dazu nötig ausgefüllt sind
            if (Kraeuter_BoxPflanze.SelectedItem == null || Kraeuter_BoxLandschaft.SelectedItem == null)
                alleNoetigenFelderAusgefuellt = false;

            if (alleNoetigenFelderAusgefuellt)
            {
                //Bestimmung Boni
                int bonus = 0;
                if (Kraeuter_HatGelaendekunde.Checked)
                    bonus += 3;
                if (Kraeuter_HatOrtskenntnis.Checked)
                    bonus += 7;

                //Ermittelung der Suchschwierigkeit
                BasisPflanze pflanze = Pflanzen.Utility.FindPflanzeByName(Kraeuter_BoxPflanze.SelectedItem.ToString());
                suchschwierigkeit = pflanze.GetBestimmung(Kraeuter_BoxSuchmonat.SelectedItem.ToString(), Kraeuter_BoxBesonderheiten.SelectedItem.ToString(), Kraeuter_BoxLandschaft.SelectedItem.ToString());
                foreach (VerbreitungsElementPflanzen v in pflanze.GetVerbreitung(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                {
                    if (Kraeuter_BoxLandschaft.SelectedItem.ToString().Equals(v.Landschaft))
                    {
                        suchschwierigkeit += v.Vorkommen;
                    }
                }

                erschwernis = suchschwierigkeit - bonus;
            }
            else
            {
                erschwernis = 99;
                suchschwierigkeit = 99;
            }

            return alleNoetigenFelderAusgefuellt;
        }

        private void Kraeuter_BoxPflanze_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Kraeuter_BerechneAktuelleProbenErschwernisUndSuchchwierigkeit(out int erschwernis, out _))
            {
                string zuschlag;
                if (erschwernis < 0)
                    zuschlag = erschwernis.ToString();
                else
                    zuschlag = "+" + erschwernis.ToString();

                Kraeuter_Zuschlag.Text = zuschlag;
            }
            else
            {
                Kraeuter_Zuschlag.Text = "";
            }
        }

        private void Kraeuter_BoxSuchmonat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Falls Landschaft bereits gewählt wurde, wird in Abhängigkeit davon die Pflanzenliste neu berechnet, andernfalls 
            //in Abhängigkeit der Region, so diese bereits gewählt wurde.
            if (Kraeuter_BoxLandschaft.SelectedItem != null)
                Kraeuter_BoxLandschaft_SelectedIndexChanged(null, null);
            else if (Kraeuter_BoxRegion.SelectedItem != null)
                Kraeuter_BoxRegion_SelectedIndexChanged(null, null);

            Kraeuter_Zuschlag.Text = "";
        }

        private void Kraeuter_BoxBesonderheiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Falls Landschaft bereits gewählt wurde, wird in Abhängigkeit davon die Pflanzenliste neu berechnet, andernfalls 
            //in Abhängigkeit der Region, so diese bereits gewählt wurde.
            if (Kraeuter_BoxLandschaft.SelectedItem != null)
                Kraeuter_BoxLandschaft_SelectedIndexChanged(null, null);
            else if (Kraeuter_BoxRegion.SelectedItem != null)
                Kraeuter_BoxRegion_SelectedIndexChanged(null, null);

            Kraeuter_Zuschlag.Text = "";

            //Astral durchzogener Ort und Palakar erfordern weiter Pflanzen in der Liste, was in der Neuberechnung der
            //Pflanzenliste Beachtung findet. Alle anderen Optionen haben nur Einfluss auf Bestimmung und/oder Grundmenge
        }
        #endregion

        #region Kräutersuche - Buttons: Gezielte Suche, Allgemeine Suche
        /// <summary>
        /// Button für gezielte Suche nach einer Pflanze
        /// </summary>
        private void ButtonSuchePflanzeGezielt_Click(object sender, EventArgs e)
        {
            bool alleNoetigenFelderAusgefuellt = true;

            //Prüfung ob Bedingungen für Suche gegeben sind und alle Felder die dazu nötig ausgefüllt sind
            if (Kraeuter_BoxPflanze.SelectedItem == null || Kraeuter_BoxLandschaft.SelectedItem == null)
                alleNoetigenFelderAusgefuellt = false;

            if (alleNoetigenFelderAusgefuellt)
            {
                int taw = (int)Kraeuter_TAWKraeuter.Value;
                if (Kraeuter_HatSuchdauerVerdoppelt.Checked)
                    taw = (int)Kraeuter_TAWKraeuter.Value + (int)Math.Round((double)Kraeuter_TAWKraeuter.Value / 2.0, MidpointRounding.AwayFromZero);

                Kraeuter_BerechneAktuelleProbenErschwernisUndSuchchwierigkeit(out int erschwernis, out int suchschwierigkeit);

                bool result = Talentprobe((int)Kraeuter_MU.Value, (int)Kraeuter_IN.Value, (int)Kraeuter_FF.Value, taw, erschwernis, out int tapstern, Kraeuter_TextfeldAusgabe);

                if (result)
                {
                    string grundmenge;
                    string gefahr;

                    BasisPflanze pflanze = Pflanzen.Utility.FindPflanzeByName(Kraeuter_BoxPflanze.SelectedItem.ToString());
                    gefahr = pflanze.GetGefahr();
                    grundmenge = pflanze.GetGrundmenge(Kraeuter_BoxSuchmonat.SelectedItem.ToString(), tapstern);

                    Kraeuter_TextfeldAusgabe.Text += "Die Probe ist mit " + tapstern + " TaP* gelungen und hat " + (Kraeuter_HatSuchdauerVerdoppelt.Checked ? "2 Stunden" : "1 Stunde") + " gedauert. \r\n\r\n";

                    int menge = 1;
                    tapstern--;
                    int suchschwierigkeitHalbe = (int)Math.Round(suchschwierigkeit / 2.0, MidpointRounding.AwayFromZero);
                    if (tapstern > 0)
                    {
                        menge += tapstern / suchschwierigkeitHalbe;
                    }

                    if (!grundmenge.Equals(""))
                        Kraeuter_TextfeldAusgabe.Text += "Von der Pflanze " + Kraeuter_BoxPflanze.SelectedItem.ToString() + " wurde insgesamt " + menge + " mal die Grundmenge (" + grundmenge + ") gefunden.";
                    else
                        Kraeuter_TextfeldAusgabe.Text += "Die Pflanze " + Kraeuter_BoxPflanze.SelectedItem.ToString() + " hat keine bekannten verwertbaren Pflanzenteile.";

                    Kraeuter_TextfeldAusgabe.Text += "\r\n\r\nFür detailliertere Informationen siehe \"" + pflanze.Referenz + "\" Seite " + pflanze.SeiteReferenz.ToString() + ".";

                    if (!gefahr.Equals(""))
                    {
                        Kraeuter_TextfeldAusgabe.Text += "\r\n\r\nHinweis: " + gefahr;
                    }
                }
                else
                {
                    Kraeuter_TextfeldAusgabe.Text += "Die Probe ist leider misslungen und hat " + (Kraeuter_HatSuchdauerVerdoppelt.Checked ? "2 Stunden" : "1 Stunde") + " gedauert.";
                }
            }
            else
            {
                Kraeuter_TextfeldAusgabe.Text = "Auswahl wurde nicht korrekt durchgeführt und eine Suche ist daher nicht möglich. Wurden Region, Landschaft und zu suchende Pflanze gewählt?";
            }
        }

        /// <summary>
        /// Button für allgemeine Suche nach Pflanzen
        /// </summary>
        private void ButtonSuchePflanzen_Click(object sender, EventArgs e)
        {
            bool alleNoetigenFelderAusgefuellt = true;

            //Prüfung ob Bedingungen für Suche gegeben sind und alle Felder die dazu nötig ausgefüllt sind
            if (Kraeuter_BoxLandschaft.SelectedItem == null)
                alleNoetigenFelderAusgefuellt = false;

            if (alleNoetigenFelderAusgefuellt)
            {
                int taw = (int)Kraeuter_TAWKraeuter.Value;
                if (Kraeuter_HatSuchdauerVerdoppelt.Checked)
                    taw = (int)Kraeuter_TAWKraeuter.Value + (int)Math.Round((double)Kraeuter_TAWKraeuter.Value / 2.0, MidpointRounding.AwayFromZero);
                if (Kraeuter_HatGelaendekunde.Checked)
                    taw += 3;
                if (Kraeuter_HatOrtskenntnis.Checked)
                    taw += 7;

                bool result = Talentprobe((int)Kraeuter_MU.Value, (int)Kraeuter_IN.Value, (int)Kraeuter_FF.Value, taw, 0, out int tapstern, Kraeuter_TextfeldAusgabe);

                if (result)
                {
                    Kraeuter_TextfeldAusgabe.Text += "Die Probe ist mit " + tapstern + " TaP* gelungen und hat " + (Kraeuter_HatSuchdauerVerdoppelt.Checked ? "2 Stunden" : "1 Stunde") + " gedauert. \r\n\r\n";

                    //Bestimmung Suchschwierigkeit für jede grundsätzlich findbare Pflanze und Vergleich mit TaP* ob Fund möglich
                    ArrayList optionen = new();
                    foreach (string option in Kraeuter_BoxPflanze.Items)
                    {
                        BasisPflanze pflanze = Pflanzen.Utility.FindPflanzeByName(option.ToString());
                        int suchschwierigkeit = pflanze.GetBestimmung(Kraeuter_BoxSuchmonat.SelectedItem.ToString(), Kraeuter_BoxBesonderheiten.SelectedItem.ToString(), Kraeuter_BoxLandschaft.SelectedItem.ToString());
                        foreach (VerbreitungsElementPflanzen v in pflanze.GetVerbreitung(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                        {
                            if (Kraeuter_BoxLandschaft.SelectedItem.ToString().Equals(v.Landschaft))
                            {
                                suchschwierigkeit += v.Vorkommen;
                            }
                        }

                        if (Math.Round(tapstern / 2.0, MidpointRounding.AwayFromZero) >= suchschwierigkeit)
                        {
                            optionen.Add(option);
                        }
                    }

                    //Falls mögliche Pflanzenfunde existieren, zufällige Auswahl und Ausgabe Ergebnis
                    if (optionen.Count > 0)
                    {
                        Random rand = new();
                        string gefundenePflanze = optionen[rand.Next(0, optionen.Count)].ToString();

                        BasisPflanze pflanze = Pflanzen.Utility.FindPflanzeByName(gefundenePflanze);
                        string gefahr = pflanze.GetGefahr();
                        string grundmenge = pflanze.GetGrundmenge(Kraeuter_BoxSuchmonat.SelectedItem.ToString(), tapstern);

                        int suchschwierigkeit = pflanze.GetBestimmung(Kraeuter_BoxSuchmonat.SelectedItem.ToString(), Kraeuter_BoxBesonderheiten.SelectedItem.ToString(), Kraeuter_BoxLandschaft.SelectedItem.ToString());
                        foreach (VerbreitungsElementPflanzen v in pflanze.GetVerbreitung(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                        {
                            if (Kraeuter_BoxLandschaft.SelectedItem.ToString().Equals(v.Landschaft))
                            {
                                suchschwierigkeit += v.Vorkommen;
                            }
                        }

                        int menge = 1;
                        tapstern--;
                        int suchschwierigkeitHalbe = (int)Math.Round(suchschwierigkeit / 2.0, MidpointRounding.AwayFromZero);
                        if (tapstern > 0)
                        {
                            menge += tapstern / suchschwierigkeitHalbe;
                        }

                        if (!grundmenge.Equals(""))
                            Kraeuter_TextfeldAusgabe.Text += "Von der Pflanze " + gefundenePflanze + " wurde insgesamt " + menge + " mal die Grundmenge (" + grundmenge + ") gefunden. ";
                        else
                            Kraeuter_TextfeldAusgabe.Text += "Die Pflanze " + gefundenePflanze + " hat keine bekannten verwertbaren Pflanzenteile. ";

                        Kraeuter_TextfeldAusgabe.Text += "\r\n\r\nFür detailliertere Informationen siehe \"" + pflanze.Referenz + "\" Seite " + pflanze.SeiteReferenz + ".";

                        if (!gefahr.Equals(""))
                        {
                            Kraeuter_TextfeldAusgabe.Text += "\r\n\r\nHinweis: " + gefahr;
                        }
                    }
                    else
                    {
                        Kraeuter_TextfeldAusgabe.Text += "Obwohl die Probe gelungen ist, reicht es leider nicht aus um etwas Brauchbares zu finden.";
                    }
                }
                else
                {
                    Kraeuter_TextfeldAusgabe.Text += "Die Probe ist leider misslungen und hat " + (Kraeuter_HatSuchdauerVerdoppelt.Checked ? "2 Stunden" : "1 Stunde") + "gedauert.";
                }
            }
            else
            {
                Kraeuter_TextfeldAusgabe.Text = "Auswahl wurde nicht korrekt durchgeführt und eine Suche ist daher nicht möglich. Wurde Region, Landschaft und zu suchende Pflanze gewählt?";
            }
        }
        #endregion

        #region Nahrungssuche - Eigenschaften, Talente, Checkboxen
        private void Nahrung_MU_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Kraeuter_MU.Value = Nahrung_MU.Value;
                Jagd_MU.Value = Nahrung_MU.Value;
            }
        }

        private void Nahrung_IN_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Kraeuter_IN.Value = Nahrung_IN.Value;
                Jagd_IN.Value = Nahrung_IN.Value;
                Fischen_IN.Value = Nahrung_IN.Value;
            }
        }

        private void Nahrung_FF_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Kraeuter_FF.Value = Nahrung_FF.Value;
                Fischen_FF.Value = Nahrung_FF.Value;
            }
        }

        private void Nahrung_TAWSinnes_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWNahrungssuche();
            if (About_Kopplung.Checked)
                Kraeuter_TAWSinnes.Value = Nahrung_TAWSinnes.Value;
        }

        private void Nahrung_TAWWildnis_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWNahrungssuche();
            if (About_Kopplung.Checked)
            {
                Kraeuter_TAWWildnis.Value = Nahrung_TAWWildnis.Value;
                Jagd_TAWWildnisleben.Value = Nahrung_TAWWildnis.Value;
            }
        }

        private void Nahrung_TAWPflanzen_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWNahrungssuche();
            if (About_Kopplung.Checked)
                Kraeuter_TAWPflanzen.Value = Nahrung_TAWPflanzen.Value;
        }

        private void Nahrung_TAWAckerbau_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWNahrungssuche();
        }

        private void BerechneTAWNahrungssuche()
        {
            if (Nahrung_NutzeAckerbau.Checked)
            {
                Nahrung_TAWNahrung.Value = Math.Round((Nahrung_TAWSinnes.Value + Nahrung_TAWAckerbau.Value + Nahrung_TAWPflanzen.Value) / 3, MidpointRounding.AwayFromZero);

                if (Nahrung_TAWNahrung.Value > 2 * Nahrung_TAWSinnes.Value)
                    Nahrung_TAWNahrung.Value = 2 * Nahrung_TAWSinnes.Value;
                if (Nahrung_TAWNahrung.Value > 2 * Nahrung_TAWAckerbau.Value)
                    Nahrung_TAWNahrung.Value = 2 * Nahrung_TAWAckerbau.Value;
                if (Nahrung_TAWNahrung.Value > 2 * Nahrung_TAWPflanzen.Value)
                    Nahrung_TAWNahrung.Value = 2 * Nahrung_TAWPflanzen.Value;
            }
            else
            {
                Nahrung_TAWNahrung.Value = Math.Round((Nahrung_TAWSinnes.Value + Nahrung_TAWWildnis.Value + Nahrung_TAWPflanzen.Value) / 3, MidpointRounding.AwayFromZero);

                if (Nahrung_TAWNahrung.Value > 2 * Nahrung_TAWSinnes.Value)
                    Nahrung_TAWNahrung.Value = 2 * Nahrung_TAWSinnes.Value;
                if (Nahrung_TAWNahrung.Value > 2 * Nahrung_TAWWildnis.Value)
                    Nahrung_TAWNahrung.Value = 2 * Nahrung_TAWWildnis.Value;
                if (Nahrung_TAWNahrung.Value > 2 * Nahrung_TAWPflanzen.Value)
                    Nahrung_TAWNahrung.Value = 2 * Nahrung_TAWPflanzen.Value;
            }
        }

        private void Nahrung_TAWNahrung_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nahrung_NutzeAckerbau_CheckedChanged(object sender, EventArgs e)
        {
            BerechneTAWNahrungssuche();
        }

        private void Nahrung_HatGelaendekunde_CheckedChanged(object sender, EventArgs e)
        {
            if (Nahrung_BoxRegion.SelectedItem != null)
                Nahrung_BoxRegion_SelectedIndexChanged(null, null);
        }

        private void Nahrung_HatOrtskenntnis_CheckedChanged(object sender, EventArgs e)
        {
            if (Nahrung_BoxRegion.SelectedItem != null)
                Nahrung_BoxRegion_SelectedIndexChanged(null, null);
        }

        private void Nahrung_HatSuchdauerVerdoppelt_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Nahrungssuche - Auswahlboxen: Region
        private void Nahrung_BerechneAktuelleProbenErschwernisUndSuchschwierigkeit(out int erschwernis, out int suchschwierigkeit)
        {
            int bonus = 0;
            if (Nahrung_HatGelaendekunde.Checked)
                bonus += 3;
            if (Nahrung_HatOrtskenntnis.Checked)
                bonus += 7;

            //Sucht den in der Region vorhandenen Zuschlag auf das Sammeln von Nahrung
            BasisRegion region = Regionen.Utility.FindRegionByName(Nahrung_BoxRegion.SelectedItem.ToString());
            suchschwierigkeit = region.EssbarePflanzen;

            erschwernis = suchschwierigkeit - bonus;
        }

        private void Nahrung_BoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nahrung_BerechneAktuelleProbenErschwernisUndSuchschwierigkeit(out int erschwernis, out _);
            {
                string zuschlag;
                if (erschwernis < 0)
                    zuschlag = erschwernis.ToString();
                else if (erschwernis < 50)
                    zuschlag = "+" + erschwernis.ToString();
                else
                    zuschlag = "---";

                Nahrung_Zuschlag.Text = zuschlag;
            }
        }
        #endregion 

        #region Nahrungssuche - Buttons: Nahrung sammeln
        /// <summary>
        /// Implementiert die komplette Nahrungssuche
        /// </summary>
        private void Nahrung_ButtonSuche_Click(object sender, EventArgs e)
        {
            bool alleNoetigenFelderAusgefuellt = true;

            if (Nahrung_BoxRegion.SelectedItem == null)
                alleNoetigenFelderAusgefuellt = false;

            if (alleNoetigenFelderAusgefuellt)
            {
                //Bestimmung Talentwert und Boni
                int taw = (int)Nahrung_TAWNahrung.Value;
                if (Nahrung_HatSuchdauerVerdoppelt.Checked)
                    taw = (int)Nahrung_TAWNahrung.Value + (int)Math.Round((double)Nahrung_TAWNahrung.Value / 2.0, MidpointRounding.AwayFromZero);

                Nahrung_BerechneAktuelleProbenErschwernisUndSuchschwierigkeit(out int erschwernis, out int suchschwierigkeit);

                if (suchschwierigkeit < 50)
                {
                    int tapstern;
                    bool result;
                    if (Nahrung_HatOrtskenntnis.Checked)
                    {
                        result = true;
                        tapstern = taw - erschwernis;
                        if (tapstern < 1)
                            tapstern = 1;
                        if (tapstern > taw)
                        {
                            tapstern = taw;
                            tapstern = Math.Max(1, tapstern);
                        }
                        Nahrung_TextfeldAusgabe.Text = "Es wurde keine Probe gewürfelt, da der Suchende über Ortskenntnis im betreffenden Gebiet verfügt.\r\n";
                    }
                    else
                    {
                        result = Talentprobe((int)Nahrung_MU.Value, (int)Nahrung_IN.Value, (int)Nahrung_FF.Value, taw, erschwernis, out tapstern, Nahrung_TextfeldAusgabe);
                    }

                    if (result)
                    {
                        Nahrung_TextfeldAusgabe.Text += "Die Probe ist mit " + tapstern + " TaP* gelungen und hat " + (Nahrung_HatSuchdauerVerdoppelt.Checked ? "2 Stunden" : "1 Stunde") + " gedauert. \r\n\r\n";

                        int menge = 1;
                        tapstern--;
                        if (tapstern > 0)
                        {
                            menge += tapstern / 3;
                        }

                        if (menge > 1)
                            Nahrung_TextfeldAusgabe.Text += "Es wurden insgesamt " + menge + " Tagesrationen an essbaren Pflanzen gefunden. ";
                        else
                            Nahrung_TextfeldAusgabe.Text += "Es wurde eine Tagesration an essbaren Pflanzen gefunden. ";

                        Nahrung_TextfeldAusgabe.Text += "\r\n\r\nFür detailliertere Informationen siehe \"Zoo-Botanica Aventurica\" Seite 224.";
                    }
                    else
                    {
                        Nahrung_TextfeldAusgabe.Text += "Die Probe ist leider misslungen und hat " + (Nahrung_HatSuchdauerVerdoppelt.Checked ? "2 Stunden" : "1 Stunde") + " gedauert.";
                    }
                }
                else
                {
                    Nahrung_TextfeldAusgabe.Text = "In dieser Region gibt es keine essbaren Pflanzen!";
                }
            }
            else
            {
                Nahrung_TextfeldAusgabe.Text = "Auswahl wurde nicht korrekt durchgeführt und eine Suche ist daher nicht möglich. Wurde die Region gewählt?";
            }
        }
        #endregion

        #region Jagd - Eigenschaften, Talente, Checkboxen
        private void Jagd_MU_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Kraeuter_MU.Value = Jagd_MU.Value;
                Nahrung_MU.Value = Jagd_MU.Value;
            }
        }

        private void Jagd_IN_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Kraeuter_IN.Value = Jagd_IN.Value;
                Nahrung_IN.Value = Jagd_IN.Value;
                Fischen_IN.Value = Jagd_IN.Value;
            }
        }

        private void Jagd_GE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Jagd_TAWFaehrtensuche_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWJagd();
        }

        private void Jagd_TAWWildnisleben_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWJagd();
            if (About_Kopplung.Checked)
            {
                Kraeuter_TAWWildnis.Value = Jagd_TAWWildnisleben.Value;
                Nahrung_TAWWildnis.Value = Jagd_TAWWildnisleben.Value;
            }
        }

        private void Jagd_TAWTierkunde_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWJagd();
        }

        private void Jagd_TAWSchleichen_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWJagd();
        }

        private void Jagd_TAWSichVerstecken_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWJagd();
        }

        private void Jagd_TAWFernkampfwaffe_ValueChanged(object sender, EventArgs e)
        {
            BerechneTAWJagd();
        }

        private void BerechneTAWJagd()
        {
            Jagd_TAWPirschjagd.Value = Math.Round((Jagd_TAWWildnisleben.Value + Jagd_TAWTierkunde.Value + Jagd_TAWFaehrtensuche.Value + Jagd_TAWSchleichen.Value + Jagd_TAWFernkampfwaffe.Value) / 5, MidpointRounding.AwayFromZero);
            Jagd_TAWAnsitzjagd.Value = Math.Round((Jagd_TAWWildnisleben.Value + Jagd_TAWTierkunde.Value + Jagd_TAWFaehrtensuche.Value + Jagd_TAWSichVerstecken.Value + Jagd_TAWFernkampfwaffe.Value) / 5, MidpointRounding.AwayFromZero);

            if (Jagd_TAWPirschjagd.Value > 2 * Jagd_TAWWildnisleben.Value)
                Jagd_TAWPirschjagd.Value = 2 * Jagd_TAWWildnisleben.Value;
            if (Jagd_TAWPirschjagd.Value > 2 * Jagd_TAWTierkunde.Value)
                Jagd_TAWPirschjagd.Value = 2 * Jagd_TAWTierkunde.Value;
            if (Jagd_TAWPirschjagd.Value > 2 * Jagd_TAWFaehrtensuche.Value)
                Jagd_TAWPirschjagd.Value = 2 * Jagd_TAWFaehrtensuche.Value;
            if (Jagd_TAWPirschjagd.Value > 2 * Jagd_TAWSchleichen.Value)
                Jagd_TAWPirschjagd.Value = 2 * Jagd_TAWSchleichen.Value;
            if (Jagd_TAWPirschjagd.Value > 2 * Jagd_TAWFernkampfwaffe.Value)
                Jagd_TAWPirschjagd.Value = 2 * Jagd_TAWFernkampfwaffe.Value;

            if (Jagd_TAWAnsitzjagd.Value > 2 * Jagd_TAWWildnisleben.Value)
                Jagd_TAWAnsitzjagd.Value = 2 * Jagd_TAWWildnisleben.Value;
            if (Jagd_TAWAnsitzjagd.Value > 2 * Jagd_TAWTierkunde.Value)
                Jagd_TAWAnsitzjagd.Value = 2 * Jagd_TAWTierkunde.Value;
            if (Jagd_TAWAnsitzjagd.Value > 2 * Jagd_TAWFaehrtensuche.Value)
                Jagd_TAWAnsitzjagd.Value = 2 * Jagd_TAWFaehrtensuche.Value;
            if (Jagd_TAWAnsitzjagd.Value > 2 * Jagd_TAWSichVerstecken.Value)
                Jagd_TAWAnsitzjagd.Value = 2 * Jagd_TAWSichVerstecken.Value;
            if (Jagd_TAWAnsitzjagd.Value > 2 * Jagd_TAWFernkampfwaffe.Value)
                Jagd_TAWAnsitzjagd.Value = 2 * Jagd_TAWFernkampfwaffe.Value;
        }

        private void Jagd_HatOrtskenntnis_CheckedChanged(object sender, EventArgs e)
        {
            Jagd_BoxTier_SelectedIndexChanged(null, null);
        }

        private void Jagd_HatGelaendekunde_CheckedChanged(object sender, EventArgs e)
        {
            Jagd_BoxTier_SelectedIndexChanged(null, null);
        }

        private void Jagd_IstScharfschuetze_CheckedChanged(object sender, EventArgs e)
        {
            Jagd_BoxTier_SelectedIndexChanged(null, null);
        }

        private void Jagd_IstMeisterschuetze_CheckedChanged(object sender, EventArgs e)
        {
            Jagd_BoxTier_SelectedIndexChanged(null, null);
        }
        #endregion

        #region Jagd - Auswahlboxen: Region, Landschaft, Tiere
        private bool Jagd_BerechneAktuelleProbenErschwernisUndJagdschwierigkeit(out int erschwernis, out int jagdschwierigkeit)
        {
            bool alleNoetigenFelderAusgefuellt = true;

            //Prüfung ob Bedingungen für Berechnung des Zuschlag gegeben sind und alle Felder die dazu nötig ausgefüllt sind
            if (Jagd_BoxTier.SelectedItem == null || Jagd_BoxLandschaft.SelectedItem == null)
                alleNoetigenFelderAusgefuellt = false;

            if (alleNoetigenFelderAusgefuellt)
            {
                //Bestimmung Boni
                int bonus = 0;
                if (Jagd_HatGelaendekunde.Checked)
                    bonus += 3;
                if (Jagd_HatOrtskenntnis.Checked)
                    bonus += 7;
                if (Jagd_IstScharfschuetze.Checked || Jagd_IstMeisterschuetze.Checked)
                {
                    if (Jagd_IstMeisterschuetze.Checked)
                        bonus += 7;
                    else
                        bonus += 3;
                }

                //Ermittelung der Jagdschwierigkeit
                BasisTier tier = Tiere.Utility.FindTierByName(Jagd_BoxTier.SelectedItem.ToString());
                jagdschwierigkeit = tier.Jagdschwierigkeit;
                BasisRegion region = Regionen.Utility.FindRegionByName(Jagd_BoxRegion.SelectedItem.ToString());
                foreach (VerbreitungsElementTiere v in region.Tiere)
                {
                    if (v.Tier.Equals(tier.Name))
                    {
                        jagdschwierigkeit += v.Vorkommen;
                        break;
                    }
                }

                erschwernis = jagdschwierigkeit - bonus;
            }
            else
            {
                erschwernis = 99;
                jagdschwierigkeit = 99;
            }

            return alleNoetigenFelderAusgefuellt;
        }

        private void Jagd_BoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jagd_BoxLandschaft.Text = "";
            Jagd_BoxLandschaft.Items.Clear();
            Jagd_BoxTier.Text = "";
            Jagd_BoxTier.Items.Clear();

            BasisRegion region = Regionen.Utility.FindRegionByName(Jagd_BoxRegion.SelectedItem.ToString());

            //Fügt alle in der Region gespeicherten Tiere hinzu
            foreach (VerbreitungsElementTiere v in region.Tiere)
            {
                Jagd_BoxTier.Items.Add(v.Tier);
            }
            SortComboBoxItemsAlphabetically(Jagd_BoxTier);

            //Fügt alle in den Tieren dieser Region gespeicherten Landschaften hinzu            
            foreach (VerbreitungsElementTiere v in region.Tiere)
            {
                BasisTier t = Tiere.Utility.FindTierByName(v.Tier);
                foreach (string l in t.Verbreitung)
                {
                    if (!Jagd_BoxLandschaft.Items.Contains(l))
                        Jagd_BoxLandschaft.Items.Add(l);
                }
            }
            SortComboBoxItemsAlphabetically(Jagd_BoxLandschaft);

            Jagd_Zuschlag.Text = "";
        }

        private void Jagd_BoxLandschaft_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jagd_BoxTier.Text = "";
            Jagd_BoxTier.Items.Clear();

            BasisRegion region = Regionen.Utility.FindRegionByName(Jagd_BoxRegion.SelectedItem.ToString());

            //Fügt alle in der Region gespeicherten Tiere hinzu
            foreach (VerbreitungsElementTiere v in region.Tiere)
            {
                Jagd_BoxTier.Items.Add(v.Tier);
            }
            //Entfernt die nicht in der gewählten Landschaft vorkommenden Tiere
            for (int i = Jagd_BoxTier.Items.Count - 1; i >= 0; i--)
            {
                bool delete = true;
                BasisTier tier = Tiere.Utility.FindTierByName(Jagd_BoxTier.Items[i].ToString());
                foreach (string landschaft in tier.Verbreitung)
                {
                    if (landschaft.Equals(Jagd_BoxLandschaft.SelectedItem.ToString()))
                        delete = false;
                }
                if (delete)
                    Jagd_BoxTier.Items.RemoveAt(i);
            }
            SortComboBoxItemsAlphabetically(Jagd_BoxTier);

            Jagd_Zuschlag.Text = "";
        }

        private void Jagd_BoxTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Jagd_BerechneAktuelleProbenErschwernisUndJagdschwierigkeit(out int erschwernis, out _))
            {
                string zuschlag;
                if (erschwernis < 0)
                    zuschlag = erschwernis.ToString();
                else
                    zuschlag = "+" + erschwernis.ToString();

                Jagd_Zuschlag.Text = zuschlag;
            }
            else
            {
                Jagd_Zuschlag.Text = "";
            }
        }
        #endregion

        #region Jagd - Buttons: Pirschjagd und Ansitzjagd
        private void Jagd_ButtonPirschjagd_Click(object sender, EventArgs e)
        {
            JagdAbwicklung((int)Jagd_TAWPirschjagd.Value, "1 Stunde");
        }

        private void Jagd_ButtonAnsitzjagd_Click(object sender, EventArgs e)
        {
            JagdAbwicklung((int)Jagd_TAWAnsitzjagd.Value, "1.5 Stunden");
        }

        private void JagdAbwicklung(int Talentwert, string dauer)
        {
            int taw = Talentwert;
            if (Jagd_BerechneAktuelleProbenErschwernisUndJagdschwierigkeit(out int erschwernis, out int jagdschwierigkeit))
            {
                bool probeErfolgreich = Talentprobe((int)Jagd_MU.Value, (int)Jagd_IN.Value, (int)Jagd_GE.Value, taw, erschwernis, out int tapstern, Jagd_TextfeldAusgabe);

                if (probeErfolgreich)
                {
                    BasisTier tier = Tiere.Utility.FindTierByName(Jagd_BoxTier.SelectedItem.ToString());

                    Jagd_TextfeldAusgabe.Text += "Die Probe ist mit " + tapstern + " TaP* gelungen und hat " + dauer + " gedauert. \r\n\r\n";

                    int menge = 1;
                    tapstern--;
                    int jagdschwierigkeitHalbe = (int)Math.Round(jagdschwierigkeit / 2.0, MidpointRounding.AwayFromZero);
                    if (tapstern > 0)
                    {
                        menge += tapstern / jagdschwierigkeitHalbe;
                    }

                    if (!tier.Beute.Equals(""))
                    {
                        if (menge == 1)
                            Jagd_TextfeldAusgabe.Text += "Es wurde 1 Exemplar der Gattung " + Jagd_BoxTier.SelectedItem.ToString() + " erlegt. ";
                        else
                            Jagd_TextfeldAusgabe.Text += "Es wurden " + menge + " Exemplare der Gattung " + Jagd_BoxTier.SelectedItem.ToString() + " erlegt. ";

                        Jagd_TextfeldAusgabe.Text += "Jedes Exemplar liefert folgende Beuteteile: " + tier.Beute;
                    }
                    else
                        Jagd_TextfeldAusgabe.Text += "Das Tier " + Jagd_BoxTier.SelectedItem.ToString() + " hat keine bekannten verwertbaren Beuteteile. ";

                    Jagd_TextfeldAusgabe.Text += "\r\n\r\nFür detailliertere Informationen siehe \"" + tier.Referenz + "\" Seite " + tier.SeiteReferenz + ".";
                }
                else
                {
                    Jagd_TextfeldAusgabe.Text += "Die Probe ist leider misslungen und hat " + dauer + " gedauert.";
                }
            }
            else
            {
                Jagd_Zuschlag.Text = "";
                Jagd_TextfeldAusgabe.Text = "Auswahl wurde nicht korrekt durchgeführt und eine Jagd ist daher nicht möglich. Wurden Region, Landschaft und zu jagendes Tier gewählt?";
            }
        }
        #endregion

        #region Fischen - Eigenschaften, Talente, Checkboxen
        private void Fischen_IN_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Kraeuter_IN.Value = Fischen_IN.Value;
                Nahrung_IN.Value = Fischen_IN.Value;
                Jagd_IN.Value = Fischen_IN.Value;
            }
        }

        private void Fischen_KL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fischen_FF_ValueChanged(object sender, EventArgs e)
        {
            if (About_Kopplung.Checked)
            {
                Kraeuter_FF.Value = Fischen_FF.Value;
                Nahrung_FF.Value = Fischen_FF.Value;
            }
        }

        private void Fischen_KK_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fischen_TAWFischen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fischen_TAWFallenstellen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fischen_HatGelaendekunde_CheckedChanged(object sender, EventArgs e)
        {
            Fischen_BoxRegion_SelectedIndexChanged(null, null);
        }

        private void Fischen_HatOrtskenntnis_CheckedChanged(object sender, EventArgs e)
        {
            Fischen_BoxRegion_SelectedIndexChanged(null, null);
        }

        private void Fischen_RuheAufstellen_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Fischen - Auswahlboxen: Region
        private void Fallenstellen_BerechneAktuelleProbenErschwernisUndJagdschwierigkeit(out int erschwernis, out int jagdschwierigkeit)
        {
            int bonus = 0;
            if (Fischen_HatGelaendekunde.Checked)
                bonus += 3;
            if (Fischen_HatOrtskenntnis.Checked)
                bonus += 7;

            // Für Fallenstellen fix +5 (ZBA S. 60)
            BasisRegion region = Regionen.Utility.FindRegionByName(Fischen_BoxRegion.SelectedItem.ToString());
            jagdschwierigkeit = region.Wildvorkommen + 5;

            erschwernis = jagdschwierigkeit - bonus;
        }

        private void Fischen_BoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fallenstellen_BerechneAktuelleProbenErschwernisUndJagdschwierigkeit(out int erschwernis, out _);
            {
                string zuschlag;
                if (erschwernis < 0)
                    zuschlag = erschwernis.ToString();
                else if (erschwernis < 50)
                    zuschlag = "+" + erschwernis.ToString();
                else
                    zuschlag = "---";

                Fischen_Zuschlag.Text = zuschlag;
            }
        }
        #endregion

        #region Fischen - Buttons: Fischen und Fallenstellen
        private void Fischen_ButtonGewaesserEinschaetzen_Click(object sender, EventArgs e)
        {
            bool allNoetigenFelderAusgefuellt = true;

            if (Fischen_BoxRegion.SelectedItem == null)
                allNoetigenFelderAusgefuellt = false;

            if (allNoetigenFelderAusgefuellt)
            {
                // Gewaesser einschaetzen (Siehe WdS S.26)
                int taw = (int)Fischen_TAWFischen.Value;
                bool result = Talentprobe((int)Fischen_IN.Value, (int)Fischen_IN.Value, (int)Fischen_KL.Value, taw, 0, out int tapstern, Fischen_TextfeldAusgabe);

                if (result)
                    Fischen_TextfeldAusgabe.Text += "Die Probe um einzuschätzen ob es sich überhaupt lohnt hier die Angel auszuwerfen ist mit " + tapstern + " TaP* gelungen.\r\n\r\n";
                else
                    Fischen_TextfeldAusgabe.Text += "Die Probe um einzuschätzen ob es sich überhaupt lohnt hier die Angel auszuwerfen ist leider misslungen.\r\n\r\n";

                Fischen_TextfeldAusgabe.Text += "Für detailliertere Informationen siehe \"Zoo-Botanica Aventurica\" Seite 60"; // und \"Wege des Schwertes\" Seite 26";
            }
            else
            {
                Fischen_TextfeldAusgabe.Text = "Auswahl wurde nicht korrekt durchgeführt und Gewässer einschätzen ist daher nicht möglich. Wurde die Region gewählt?";
            }
        }

        private void Fischen_ButtonAngeln_Click(object sender, EventArgs e)
        {
            bool alleNoetigenFelderAusgefuellt = true;

            if (Fischen_BoxRegion.SelectedItem == null)
                alleNoetigenFelderAusgefuellt = false;

            if (alleNoetigenFelderAusgefuellt)
            {
                int taw = (int)Fischen_TAWFischen.Value;
                bool result = Talentprobe((int)Fischen_IN.Value, (int)Fischen_FF.Value, (int)Fischen_KK.Value, taw, 0, out int tapstern, Fischen_TextfeldAusgabe);

                if (result)
                {
                    Fischen_TextfeldAusgabe.Text += "Die Probe ist mit " + tapstern + " TaP* gelungen und hat 1 Stunde gedauert. \r\n\r\n";

                    int menge = 2;
                    tapstern--;
                    if (tapstern > 0)
                    {
                        menge += tapstern / 3;
                    }

                    Fischen_TextfeldAusgabe.Text += "Es wurden insgesamt " + menge + " halbe Tagesrationen Fisch gefangen.";

                    Fischen_TextfeldAusgabe.Text += "\r\n\r\nFür detailliertere Informationen siehe \"Zoo-Botanica Aventurica\" Seite 60";
                }
                else
                {
                    Fischen_TextfeldAusgabe.Text += "Die Probe ist leider misslungen und hat 1 Stunde gedauert.";
                }
            }
            else
            {
                Fischen_TextfeldAusgabe.Text = "Auswahl wurde nicht korrekt durchgeführt und Fischen ist daher nicht möglich. Wurde die Region gewählt?";
            }
        }

        private void Fischen_ButtonFallenstellen_Click(object sender, EventArgs e)
        {
            bool alleNoetigenFelderAusgefuellt = true;

            //Prüfung ob Bedingungen für Suche gegeben sind und alle Felder die dazu nötig ausgefüllt sind
            if (Fischen_BoxRegion.SelectedItem == null)
                alleNoetigenFelderAusgefuellt = false;

            if (alleNoetigenFelderAusgefuellt)
            {
                //Bestimmung Talentwert und Boni
                int taw = (int)Fischen_TAWFallenstellen.Value;
                if (Fischen_RuheAufstellen.Checked)
                    taw = (int)Fischen_TAWFallenstellen.Value + (int)Math.Round((double)Fischen_TAWFallenstellen.Value / 2.0, MidpointRounding.AwayFromZero);

                Fallenstellen_BerechneAktuelleProbenErschwernisUndJagdschwierigkeit(out int erschwernis, out int jagdschwierigkeit);

                if (jagdschwierigkeit < 50)
                {
                    bool result = Talentprobe((int)Fischen_IN.Value, (int)Fischen_FF.Value, (int)Fischen_KK.Value, taw, erschwernis, out int tapstern, Fischen_TextfeldAusgabe);

                    if (result)
                    {
                        Fischen_TextfeldAusgabe.Text += "Die Probe ist mit " + tapstern + " TaP* gelungen und hat " + (Fischen_RuheAufstellen.Checked ? "1.5 Stunden" : "1 Stunde") + " gedauert. \r\n\r\n";

                        int menge = 1;
                        tapstern--;
                        int jagdschwierigkeitHalbe = (int)Math.Round(jagdschwierigkeit / 2.0, MidpointRounding.AwayFromZero);
                        if (tapstern > 0)
                        {
                            menge += tapstern / jagdschwierigkeitHalbe;
                        }

                        if (menge > 1)
                            Fischen_TextfeldAusgabe.Text += "Bei der Kontrolle der Fallen zeigt sich, dass insgesamt " + menge + " Tagesrationen Fleisch gefangen wurden. ";
                        else
                            Fischen_TextfeldAusgabe.Text += "Bei der Kontrolle der Fallen zeigt sich, dass eine Tagesration Fleisch gefangen wurde. ";

                        Fischen_TextfeldAusgabe.Text += "\r\n\r\nFür detailliertere Informationen siehe \"Zoo-Botanica Aventurica\" Seite 60.";
                    }
                    else
                    {
                        Fischen_TextfeldAusgabe.Text += "Die Probe ist leider misslungen und hat " + (Fischen_RuheAufstellen.Checked ? "1.5 Stunden" : "1 Stunde") + " gedauert.";
                    }
                }
                else
                {
                    Fischen_TextfeldAusgabe.Text = "Du kannst hier nicht Fallenstellen!";
                }
            }
            else
            {
                Fischen_TextfeldAusgabe.Text = "Auswahl wurde nicht korrekt durchgeführt und Fallenstellen ist daher nicht möglich. Wurde die Region gewählt?";
            }
        }
        #endregion

        #region About this Tool - Disclaimer und Kontakt
        private void KontaktLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = "mailto:dsatool@gmx.de" });
        }

        private void HomepageLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = "https://mprim.de/einsteins-dsa-tool/" });
        }

        private void GitHubLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = "https://github.com/pielmach/dsa-kraeutersuche-dotnet" });
        }
        #endregion
    }
}
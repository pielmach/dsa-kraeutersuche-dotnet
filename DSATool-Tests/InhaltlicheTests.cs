using DSATool.Pflanzen;
using DSATool.Regionen;
using DSATool.Tiere;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;


namespace DSATool_Tests
{
    [TestClass]
    public class InhaltlicheTests
    {

        [TestMethod]
        public void PflanzeInMindestensEinerRegionFindbar()
        {
            ArrayList RegionenGlobal = new(DSATool.Regionen.Utility.Regionen);
            ArrayList PflanzenGlobal = new(DSATool.Pflanzen.Utility.Pflanzen);

            foreach (BasisRegion region in RegionenGlobal)
            {
                foreach (string pflanze in region.Pflanzen)
                {
                    for (int k = 0; k < PflanzenGlobal.Count; k++)
                    {
                        if (pflanze.Equals((PflanzenGlobal[k] as BasisPflanze).Name))
                        {
                            PflanzenGlobal.RemoveAt(k);
                            break;
                        }
                    }
                }
            }

            foreach (BasisPflanze pflanze in PflanzenGlobal)
            {
                Assert.Fail(pflanze.Name + " wurde in keiner Region gefunden");
            }
        }

        [TestMethod]
        public void TierInKeinerRegionJagbar()
        {
            ArrayList RegionenGlobal = new(DSATool.Regionen.Utility.Regionen);
            ArrayList TiereGlobal = new(DSATool.Tiere.Utility.Tiere);

            foreach (BasisRegion region in RegionenGlobal)
            {
                foreach (VerbreitungsElementTiere v in region.Tiere)
                {
                    for (int k = 0; k < TiereGlobal.Count; k++)
                    {
                        if (v.Tier.Equals((TiereGlobal[k] as BasisTier).Name))
                        {
                            TiereGlobal.RemoveAt(k);
                            break;
                        }
                    }
                }
            }

            foreach (BasisTier tier in TiereGlobal)
            {
                Assert.Fail(tier.Name + " wurde in keiner Region gefunden");
            }
        }

        [TestMethod]
        public void RegionMitNichtExistierendenTieren()
        {
            ArrayList RegionenGlobal = new(DSATool.Regionen.Utility.Regionen); ;
            ArrayList TiereGlobal = new(DSATool.Tiere.Utility.Tiere);

            foreach (BasisRegion region in RegionenGlobal)
            {
                foreach (VerbreitungsElementTiere v in region.Tiere)
                {
                    bool found = false;
                    foreach (BasisTier tier in TiereGlobal)
                    {
                        if (tier.Name.Equals(v.Tier))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        Assert.Fail(v.Tier + " in Region " + region.Name + " ist nicht implementiert!");
                }
            }
        }

        /*
        /// <summary>
        /// Prüft welche Pflanzen in einer Region bei den möglichen Landschaften findbar sind und gibt die nicht findbaren auf der TextBox aus
        /// </summary>
        [TestMethod]
        private void SucheRegionalNichtFindbarePflanzen()
        {
            Kraeuter_TextfeldAusgabe.Text = "";
            for (int a = Kraeuter_BoxPflanze.Items.Count - 1; a >= 0; a--)
            {
                bool findbar = false;
                string s = Kraeuter_BoxPflanze.Items[a].ToString();
                foreach (BasisPflanze pflanze in PflanzenGlobal)
                {
                    if (s.Equals(pflanze.Name))
                    {
                        foreach (BasisRegion region in RegionenGlobal)
                        {
                            if (Kraeuter_BoxRegion.SelectedItem.ToString().Equals(region.Name))
                            {
                                foreach (string landschaft in region.Landschaften)
                                {
                                    foreach (VerbreitungsElementPflanzen v in pflanze.GetVerbreitung(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                                    {
                                        if (landschaft.Equals(v.Landschaft))
                                        {
                                            findbar = true;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
                if (!findbar)
                {
                    Kraeuter_TextfeldAusgabe.Text += Kraeuter_BoxPflanze.Items[a].ToString() + " Fund in den möglichen Landschaften nicht möglich! \r\n";
                    Kraeuter_TextfeldAusgabe.Text += "     Mögliche Landschaften wären ";
                    foreach (BasisPflanze pflanze in PflanzenGlobal)
                    {
                        if (pflanze.Name.Equals(Kraeuter_BoxPflanze.Items[a].ToString()))
                        {
                            foreach (VerbreitungsElementPflanzen v in pflanze.GetVerbreitung(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                            {
                                Kraeuter_TextfeldAusgabe.Text += v.Landschaft + ", ";
                            }
                            break;
                        }
                    }
                    Kraeuter_TextfeldAusgabe.Text += "\r\n";
                }
            }
        }

        /// <summary>
        /// Sucht Pflanzen in der Region, die die Landschaft Strand, Küste beinhalten
        /// </summary>
        [TestMethod]
        private void SucheStrandPflanzenInRegion()
        {
            Kraeuter_TextfeldAusgabe.Text = "";
            for (int a = Kraeuter_BoxPflanze.Items.Count - 1; a >= 0; a--)
            {
                bool strand = false;
                string s = Kraeuter_BoxPflanze.Items[a].ToString();
                foreach (BasisPflanze pfanze in PflanzenGlobal)
                {
                    if (s.Equals(pfanze.Name))
                    {
                        foreach (VerbreitungsElementPflanzen v in pfanze.GetVerbreitung(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                        {
                            if (v.Landschaft.ToString().Equals("Küste, Strand"))
                                strand = true;
                        }
                        break;
                    }
                }
                if (strand)
                {
                    Kraeuter_TextfeldAusgabe.Text += Kraeuter_BoxPflanze.Items[a].ToString() + " hat Strand als Fundlandschaft! \r\n";
                    Kraeuter_TextfeldAusgabe.Text += "     Mögliche Landschaften wären ";
                    foreach (BasisPflanze pflanze in PflanzenGlobal)
                    {
                        if (pflanze.Name.Equals(Kraeuter_BoxPflanze.Items[a].ToString()))
                        {
                            foreach (VerbreitungsElementPflanzen v in pflanze.GetVerbreitung(Kraeuter_BoxSuchmonat.SelectedItem.ToString()))
                            {
                                Kraeuter_TextfeldAusgabe.Text += v.Landschaft + ", ";
                            }
                            break;
                        }
                    }
                    Kraeuter_TextfeldAusgabe.Text += "\r\n";
                }

            }
        }
        */
    }
}
using System.Collections;

namespace DSATool.Landschaften
{
    public abstract class BasisLandschaft
    {
        private string m_Name = "";

        public string Name
        {
            get { return m_Name; }
            init { m_Name = value; }
        }
    }

    public static class Utility
    {
        private static readonly ArrayList landschaften = new();
        private static readonly Dictionary<string, BasisLandschaft> landschaft_by_name = new();

        public static ArrayList Landschaften
        {
            get { return ArrayList.ReadOnly(landschaften); }
        }

        public static BasisLandschaft FindLandschaftByName(string name)
        {
            return landschaft_by_name[name];
        }

        static Utility()
        {
            landschaften.Add(new LandschaftEis());
            landschaften.Add(new LandschaftWuesteUndWuestenrand());
            landschaften.Add(new LandschaftGebirge());
            landschaften.Add(new LandschaftHochland());
            landschaften.Add(new LandschaftSteppe());
            landschaften.Add(new LandschaftGraslandWiesen());
            landschaften.Add(new LandschaftFlussSeeuferTeiche());
            landschaften.Add(new LandschaftKuesteStrand());
            landschaften.Add(new LandschaftFlussauen());
            landschaften.Add(new LandschaftSumpfMoor());
            landschaften.Add(new LandschaftRegenwald());
            landschaften.Add(new LandschaftWald());
            landschaften.Add(new LandschaftWaldrand());
            landschaften.Add(new LandschaftMeer());
            landschaften.Add(new LandschaftHoehleFeucht());
            landschaften.Add(new LandschaftHoehleTrocken());

            foreach (BasisLandschaft landschaft in landschaften)
            {
                landschaft_by_name.Add(landschaft.Name, landschaft);
            }
        }
    }

    public class LandschaftEis : BasisLandschaft
    {
        public LandschaftEis() => Name = "Eis";
    }

    public class LandschaftWuesteUndWuestenrand : BasisLandschaft
    {
        public LandschaftWuesteUndWuestenrand() => Name = "Wüste und Wüstenrand";
    }

    public class LandschaftGebirge : BasisLandschaft
    {
        public LandschaftGebirge() => Name = "Gebirge";
    }

    public class LandschaftHochland : BasisLandschaft
    {
        public LandschaftHochland() => Name = "Hochland";
    }

    public class LandschaftSteppe : BasisLandschaft
    {
        public LandschaftSteppe() => Name = "Steppe";
    }

    public class LandschaftGraslandWiesen : BasisLandschaft
    {
        public LandschaftGraslandWiesen() => Name = "Grasland, Wiesen";
    }

    public class LandschaftFlussSeeuferTeiche : BasisLandschaft
    {
        public LandschaftFlussSeeuferTeiche() => Name = "Fluss- und Seeufer, Teiche";
    }

    public class LandschaftKuesteStrand : BasisLandschaft
    {
        public LandschaftKuesteStrand() => Name = "Küste, Strand";
    }

    public class LandschaftFlussauen : BasisLandschaft
    {
        public LandschaftFlussauen() => Name = "Flussauen";
    }

    public class LandschaftSumpfMoor : BasisLandschaft
    {
        public LandschaftSumpfMoor() => Name = "Sumpf und Moor";
    }

    public class LandschaftRegenwald : BasisLandschaft
    {
        public LandschaftRegenwald() => Name = "Regenwald";
    }

    public class LandschaftWald : BasisLandschaft
    {
        public LandschaftWald() => Name = "Wald";
    }

    public class LandschaftWaldrand : BasisLandschaft
    {
        public LandschaftWaldrand() => Name = "Waldrand";
    }

    public class LandschaftMeer : BasisLandschaft
    {
        public LandschaftMeer() => Name = "Meer";
    }

    public class LandschaftHoehleFeucht : BasisLandschaft
    {
        public LandschaftHoehleFeucht() => Name = "Höhle (feucht)";
    }

    public class LandschaftHoehleTrocken : BasisLandschaft
    {
        public LandschaftHoehleTrocken() => Name = "Höhle (trocken)";
    }
}

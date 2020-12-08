using System.Collections.Generic;
using System.Linq;


namespace BlazorShoppingServer.Data.Context
{
    public class SeedHelper
    {
        private readonly ApplicationDbContext context;

        public SeedHelper(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void SeedIfEmpty()
        {
            if (context.Sections.Any())
            {
                return;
            }

            var sections = new List<Section>
            {
                new Section
                {
                    Name = "Special",
                    Order = 1000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Tandkräm", Unit = "st"},
                        new Article {Name = "Batteri AA", Unit = "pkt"},
                        new Article {Name = "Lampor", Unit = "pkt"},
                    }
                },
                new Section
                {
                    Name = "Bröd / Kex",
                    Order = 2000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Veckans bröd", Unit = "st"},
                        new Article {Name = "Polarbröd", Unit = "st"},
                        new Article {Name = "Vitt bröd att rosta", Unit = "st"},
                        new Article {Name = "Finn Crisp", Unit = "pkt"},
                        new Article {Name = "Breton salta kex", Unit = "pkt"},
                    }
                },
                new Section
                {
                    Name = "Kött / Fisk / Ost",
                    Order = 3000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Köttbullar", Unit = "pkt"},
                        new Article {Name = "Lövbiff", Unit = "pkt"},
                        new Article {Name = "Skinkschnitzel", Unit = "pkt"},
                        new Article {Name = "Fläskfilé", Unit = "st"},
                        new Article {Name = "Grytbitar", Unit = "pkt"},
                        new Article {Name = "Kotletter", Unit = "pkt"},
                        new Article {Name = "Köttfärs", Unit = "pkt"},
                        new Article {Name = "Wienerkorv", Unit = "pkt"},
                        new Article {Name = "Prinskorv", Unit = "pkt"},
                        new Article {Name = "Falukorv", Unit = "st"},
                        new Article {Name = "Bacon", Unit = "pkt"},
                        new Article {Name = "Kaviar Klädesholmen", Unit = "st"},
                        new Article {Name = "Inlagd sill", Unit = "burk"},
                        new Article {Name = "Hushållsost", Unit = "st"},
                        new Article {Name = "Mozzarella", Unit = "st"},
                        new Article {Name = "Halloumi", Unit = "st"},
                    }
                },
                new Section
                {
                    Name = "Frukt / Grönt",
                    Order = 4000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Sallad", Unit = "st"},
                        new Article {Name = "Morot", Unit = "pkt"},
                        new Article {Name = "Potatis Fast", Unit = "kg"},
                        new Article {Name = "Potatis Mjölig", Unit = "kg"},
                        new Article {Name = "Lök", Unit = "pkt"},
                        new Article {Name = "Citron", Unit = "st"},
                        new Article {Name = "Apelsin", Unit = "kg"},
                        new Article {Name = "Klementin", Unit = "kg"},
                        new Article {Name = "Banan", Unit = "st"},
                        new Article {Name = "Äpple", Unit = "st"},
                        new Article {Name = "Miniomater", Unit = "pkt"},
                        new Article {Name = "Selleri", Unit = "st"},
                        new Article {Name = "Palsternacka", Unit = "st"},
                        new Article {Name = "Purjolök", Unit = "st"},
                        new Article {Name = "Vitlök", Unit = "st"},
                        new Article {Name = "Champinjoner", Unit = "hg"},
                        new Article {Name = "Zucchini", Unit = "st"},
                        new Article {Name = "Paprika", Unit = "st"},
                        new Article {Name = "Gurka", Unit = "st"},
                        new Article {Name = "Färsk Dill", Unit = "kruka"},
                        new Article {Name = "Färsk Basilika", Unit = "kruka"},
                    }
                },
                new Section
                {
                    Name = "Kolonial",
                    Order = 5000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Svartpeppar finmalen", Unit = "st"},
                        new Article {Name = "Svartpeppar grovmalen", Unit = "st"},
                        new Article {Name = "Vitpeppar finmalen", Unit = "st"},
                        new Article {Name = "Paprikapulver", Unit = "st"},
                        new Article {Name = "Citronpeppar", Unit = "st"},
                        new Article {Name = "Grönpeppar, hel", Unit = "st"},
                        new Article {Name = "Köttbuljong", Unit = "st"},
                        new Article {Name = "Kycklingbuljong", Unit = "st"},
                        new Article {Name = "Fiskbuljong", Unit = "st"},
                        new Article {Name = "Grönsaksbuljong", Unit = "st"},
                        new Article {Name = "Seltin", Unit = "st"},
                        new Article {Name = "Soja", Unit = "st"},
                        new Article {Name = "Olivolja Extra Virgin", Unit = "st"},
                        new Article {Name = "Rapsolja", Unit = "st"},
                        new Article {Name = "Jasminris", Unit = "st"},
                        new Article {Name = "Spagetti", Unit = "st"},
                        new Article {Name = "Makaroner", Unit = "st"},
                        new Article {Name = "Lasagne", Unit = "st"},
                        new Article {Name = "Annan pasta", Unit = "st"},
                        new Article {Name = "Havregryn, AXA stor", Unit = "pkt"},
                        new Article {Name = "Corn Flakes", Unit = "pkt"},
                        new Article {Name = "Müsli", Unit = "pkt"},
                        new Article {Name = "Mannagryn", Unit = "pkt"},
                        new Article {Name = "Vetemjöl", Unit = "pkt"},
                        new Article {Name = "Potatismjöl", Unit = "pkt"},
                        new Article {Name = "Maizenamjöl", Unit = "pkt"},
                        new Article {Name = "Ströbröd", Unit = "pkt"},
                        new Article {Name = "Socker", Unit = "pkt"},
                        new Article {Name = "Florsocker", Unit = "pkt"},
                        new Article {Name = "Pärlsocker", Unit = "pkt"},
                        new Article {Name = "Vaniljsocker", Unit = "pkt"},
                        new Article {Name = "Sirap", Unit = "st"},
                        new Article {Name = "Bakpulver", Unit = "pkt"},
                        new Article {Name = "Mandel", Unit = "pkt"},
                        new Article {Name = "Saft", Unit = "st"},
                        new Article {Name = "Lingonsylt, Rårörd", Unit = "st"},
                        new Article {Name = "Marmelad" , Unit = "st"},
                        new Article {Name = "Gelé", Unit = "st"},
                        new Article {Name = "Citronfromage", Unit = "pkt"},
                        new Article {Name = "Pannacotta", Unit = "pkt"},
                        new Article {Name = "Chokladpudding", Unit = "pkt"},
                        new Article {Name = "Nyponsoppa", Unit = "pkt"},
                        new Article {Name = "Krossade tomater", Unit = "pkt"},
                        new Article {Name = "Tomatpuré", Unit = "pkt"},
                        new Article {Name = "Ketchup", Unit = "st"},
                        new Article {Name = "Senap, Jonnys Sötstark", Unit = "st"},
                        new Article {Name = "Dressing", Unit = "st"},
                        new Article {Name = "Mor Annas smörgåsgurka", Unit = "st"},
                        new Article {Name = "Majs på burk", Unit = "pkt"},
                        new Article {Name = "Tacobröd", Unit = "pkt"},
                        new Article {Name = "Tacosås", Unit = "st"},
                        new Article {Name = "Tacokryddmix", Unit = "st"},
                        new Article {Name = "Ramlösa", Unit = "st"},
                        new Article {Name = "Coca-Cola", Unit = "st"},
                        new Article {Name = "Fanta", Unit = "st"},
                        new Article {Name = "Fläderdryck", Unit = "st"},
                    }
                },
                new Section
                {
                    Name = "Mejerivaror",
                    Order = 6000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Ägg", Unit = "pkt"},
                        new Article {Name = "Vispgrädde 40%", Unit = "dl"},
                        new Article {Name = "Gräddfil", Unit = "dl"},
                        new Article {Name = "Mellanmjölk", Unit = "pkt"},
                        new Article {Name = "Mild Yoghurt", Unit = "pkt"},
                        new Article {Name = "Valio Yoghurt Vanilj", Unit = "pkt"},
                        new Article {Name = "Valio Yoghurt Blåbär", Unit = "pkt"},
                        new Article {Name = "Apelsinjuice Ekologisk", Unit = "pkt"},
                        new Article {Name = "Bregott", Unit = "pkt"},
                        new Article {Name = "Smör", Unit = "pkt"},
                        new Article {Name = "Vanlig jäst", Unit = "pkt"},
                        new Article {Name = "Söt jäst", Unit = "pkt"},
                    }
                },
              new Section
                {
                    Name = "Rengöring",
                    Order = 8000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Plastpåsar", Unit = "pkt"},
                        new Article {Name = "Bakplåtspapper", Unit = "pkt"},
                        new Article {Name = "Ugnsfolie", Unit = "pkt"},
                        new Article {Name = "Hushållspapper", Unit = "pkt"},
                        new Article {Name = "Toapapper", Unit = "pkt"},
                        new Article {Name = "Tvättmedel", Unit = "pkt"},
                        new Article {Name = "Diskmedel, YES Grön", Unit = "dt"},
                        new Article {Name = "Diskborste", Unit = "st"},
                        new Article {Name = "Disktrasa", Unit = "st"},
                        new Article {Name = "Disksvamp", Unit = "pkt"},
                        new Article {Name = "Toalettrengöring", Unit = "pkt"},
                    }
                },
                new Section
                {
                    Name = "Frysdisken",
                    Order = 9000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Fryst Dill", Unit = "pkt"},
                        new Article {Name = "Fryst Persilja", Unit = "pkt"},
                        new Article {Name = "Broccoli", Unit = "pkt"},
                        new Article {Name = "Wokgrönsaker", Unit = "pkt"},
                        new Article {Name = "Haricots vertes", Unit = "pkt"},
                        new Article {Name = "Fryst Majs", Unit = "pkt"},
                        new Article {Name = "Lax", Unit = "pkt"},
                        new Article {Name = "Torsk", Unit = "pkt"},
                        new Article {Name = "Kyckling", Unit = "kg"},
                        new Article {Name = "GB Vaniljglass 2 l", Unit = "pkt"},
                        new Article {Name = "SIA Chokladglass", Unit = "pkt"},
                        new Article {Name = "ICA Pistageglass", Unit = "pkt"},
                        new Article {Name = "Piggelin", Unit = "pkt"},
                        new Article {Name = "Päronsplitt", Unit = "pkt"},
                    }
                },
                new Section
                {
                    Name = "Special",
                    Order = 10000,
                    Articles = new List<Article>
                    {
                        new Article {Name = "Choklad", Unit = "st"},
                        new Article {Name = "Godis", Unit = "st"},
                        new Article {Name = "Tomglaskvitton", Unit = "st"},
                    }
                }
            };


            foreach (var section in sections)
            {
                var articleOrder = 1;
                foreach (var article in section.Articles)
                {
                    article.Order = section.Order + articleOrder;
                    articleOrder += 1;
                }
            }

            context.Sections.AddRange(sections);
            context.SaveChanges();
        }
    }
}
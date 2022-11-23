using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Net6SpaTemplate.BLL.Objects
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CHOCDF
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CHOCDFNet
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CHOLE
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Digest
    {
        public string label { get; set; }
        public string tag { get; set; }
        public string schemaOrgTag { get; set; }
        public double total { get; set; }
        public bool hasRDI { get; set; }
        public double daily { get; set; }
        public string unit { get; set; }
        public List<Sub> sub { get; set; }
    }

    public class ENERCKCAL
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAMS
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAPU
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FASAT
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAT
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FATRN
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FE
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FIBTG
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLAC
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLDFE
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLFD
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Images
    {
        public THUMBNAIL THUMBNAIL { get; set; }
        public SMALL SMALL { get; set; }
        public REGULAR REGULAR { get; set; }
    }

    public class Ingredient
    {
        public string text { get; set; }
        public double quantity { get; set; }
        public string measure { get; set; }
        public string food { get; set; }
        public double weight { get; set; }
        public string foodCategory { get; set; }
        public string foodId { get; set; }
        public string image { get; set; }
    }

    public class K
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class MG
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class NA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class NIA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class P
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class PROCNT
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Recipe
    {
        public string uri { get; set; }
        public string label { get; set; }
        public string image { get; set; }
        public Images images { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public string shareAs { get; set; }
        public double yield { get; set; }
        public List<string> dietLabels { get; set; }
        public List<string> healthLabels { get; set; }
        public List<string> cautions { get; set; }
        public List<string> ingredientLines { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public double calories { get; set; }
        public double totalWeight { get; set; }
        public double totalTime { get; set; }
        public List<string> cuisineType { get; set; }
        public List<string> mealType { get; set; }
        public List<string> dishType { get; set; }
        public TotalNutrients totalNutrients { get; set; }
        public Nutrients nutrients { get; set; }
        public TotalDaily totalDaily { get; set; }
        public List<Digest> digest { get; set; }
    }

    public class REGULAR
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class RIBF
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class RecipieResponse
    {
        public Recipe recipe { get; set; }
        public Links _links { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
        public string title { get; set; }
    }

    public class SMALL
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Sub
    {
        public string label { get; set; }
        public string tag { get; set; }
        public string schemaOrgTag { get; set; }
        public double total { get; set; }
        public bool hasRDI { get; set; }
        public double daily { get; set; }
        public string unit { get; set; }
    }

    public class SUGAR
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class SUGARAdded
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class SugarAlcohol
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class THIA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class THUMBNAIL
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class TOCPHA
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class TotalDaily
    {
        public ENERCKCAL ENERC_KCAL { get; set; }
        public FAT FAT { get; set; }
        public FASAT FASAT { get; set; }
        public CHOCDF CHOCDF { get; set; }
        public FIBTG FIBTG { get; set; }
        public PROCNT PROCNT { get; set; }
        public CHOLE CHOLE { get; set; }
        public NA NA { get; set; }
        public CA CA { get; set; }
        public MG MG { get; set; }
        public K K { get; set; }
        public FE FE { get; set; }
        public ZN ZN { get; set; }
        public P P { get; set; }
        public VITARAE VITA_RAE { get; set; }
        public VITC VITC { get; set; }
        public THIA THIA { get; set; }
        public RIBF RIBF { get; set; }
        public NIA NIA { get; set; }
        public VITB6A VITB6A { get; set; }
        public FOLDFE FOLDFE { get; set; }
        public VITB12 VITB12 { get; set; }
        public VITD VITD { get; set; }
        public TOCPHA TOCPHA { get; set; }
        public VITK1 VITK1 { get; set; }
    }

    public class Nutrients
    {
        public String FAT { get; set; }
        public String FASAT { get; set; }
        public String FATRN { get; set; }
        public String FAMS { get; set; }
        public String FAPU { get; set; }
        public String CHOCDF { get; set; }
        public String CHOCDFnet { get; set; }
        public String FIBTG { get; set; }
        public String SUGAR { get; set; }
        public String SUGARadded { get; set; }
        public String PROCNT { get; set; }
        public String CHOLE { get; set; }
        public String NA { get; set; }
        public String CA { get; set; }
        public String MG { get; set; }
        public String K { get; set; }
        public String FE { get; set; }
        public String ZN { get; set; }
        public String P { get; set; }
        public String VITA_RAE { get; set; }
        public String VITC { get; set; }
        public String THIA { get; set; }
        public String RIBF { get; set; }
        public String NIA { get; set; }
        public String VITB6A { get; set; }
        public String FOLDFE { get; set; }
        public String FOLFD { get; set; }
        public String FOLAC { get; set; }
        public String VITB12 { get; set; }
        public String VITD { get; set; }
        public String TOCPHA { get; set; }
        public String VITK1 { get; set; }
        public String Sugaralcohol { get; set; }
        public String WATER { get; set; }
    }
    public class TotalNutrients
    {
        public ENERCKCAL ENERC_KCAL { get; set; }
        public FAT FAT { get; set; }
        public FASAT FASAT { get; set; }
        public FATRN FATRN { get; set; }
        public FAMS FAMS { get; set; }
        public FAPU FAPU { get; set; }
        public CHOCDF CHOCDF { get; set; }

        [JsonPropertyName("CHOCDF.net")]
        public CHOCDFNet CHOCDFnet { get; set; }
        public FIBTG FIBTG { get; set; }
        public SUGAR SUGAR { get; set; }

        [JsonPropertyName("SUGAR.added")]
        public SUGARAdded SUGARadded { get; set; }
        public PROCNT PROCNT { get; set; }
        public CHOLE CHOLE { get; set; }
        public NA NA { get; set; }
        public CA CA { get; set; }
        public MG MG { get; set; }
        public K K { get; set; }
        public FE FE { get; set; }
        public ZN ZN { get; set; }
        public P P { get; set; }
        public VITARAE VITA_RAE { get; set; }
        public VITC VITC { get; set; }
        public THIA THIA { get; set; }
        public RIBF RIBF { get; set; }
        public NIA NIA { get; set; }
        public VITB6A VITB6A { get; set; }
        public FOLDFE FOLDFE { get; set; }
        public FOLFD FOLFD { get; set; }
        public FOLAC FOLAC { get; set; }
        public VITB12 VITB12 { get; set; }
        public VITD VITD { get; set; }
        public TOCPHA TOCPHA { get; set; }
        public VITK1 VITK1 { get; set; }

        [JsonPropertyName("Sugar.alcohol")]
        public SugarAlcohol Sugaralcohol { get; set; }
        public WATER WATER { get; set; }
    }

    public class VITARAE
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITB12
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITB6A
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITC
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITD
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITK1
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class WATER
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class ZN
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }


}

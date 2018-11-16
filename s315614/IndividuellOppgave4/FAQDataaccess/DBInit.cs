using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAQDataaccess
{
    class DBInit : DropCreateDatabaseAlways<DatabaseEntities>
    {
        protected override void Seed(DatabaseEntities context)
        {
            var nyQuestion1 = new FAQDatabase()
            {
                Title = "FUNKSJONALITET",
                Question = "Kan jeg laste ned og se i offline-modus?",
                Answer = "Ja, i iOS-appene våre kan du laste ned filmer som du kan ta med deg hvis du skal" +
                " ut og reise eller oppholde deg en plass uten Internett.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion2 = new FAQDatabase()
            {
                Title = "FUNKSJONALITET",
                Question = "Kan jeg leie film på iPhone eller iPad?",
                Answer = "Du kan bruke iPhone eller iPad til å se film, men ikke til å leie."+
                "Per i dag må hver betaling i Apples økosystem utføres gjennom deres eget betalingssystem. " +
                "Det innebærer en ekstra avgift på 30 % av utsalgsprisen. " +
                "For deg som forbruker innebærer det høyere kostnad per film. " +
                "Derfor har vi valgt å tilby enkel avspilling på iPhone/iPad. " +
                "Du kan leie og kjøpe filmer på våres side. " +
                "Filmer som du har kjøpt og leid finner du under Mine filmer i appen på iPhone og iPad.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion3 = new FAQDatabase()
            {
                Title = "Aktuelt",
                Question = "New Android TV app.",
                Answer = "Have you seen our new Android TV app? " +
                "If you have an Android TV, you can easily download OMF through Google Play. " +
                "In the app, you can of course rent, buy, mark your favourites and watch movies and shows. " +
                "All you can´t do is update / add card details which you do online at oslometfilms.com.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion4 = new FAQDatabase()
            {
                Title = "FUNKSJONALITET",
                Question = "Hvordan lagrer jeg filmer jeg har lyst til å se senere?",
                Answer = "Du kan markere en film som favoritt dersom du vil se den senere.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion5 = new FAQDatabase()
            {
                Title = "FUNKSJONALITET",
                Question = "Kan jeg bruke Airplay?",
                Answer = "Per i dag er det dessverre ikke mulig å bruke Airplay for å se filmene og seriene " +
                "våre. På grunn av rettighetsårsaker kan du ikke bruke Airplay når du ser på video som krever " +
                "kopieringsbeskyttelse, noe som gjelder for våre filmer og serier. Vi jobber med en rettighetsavtale " +
                "og tekniske løsninger for å gjøre dette mulig",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion6 = new FAQDatabase()
            {
                Title = "FUNKSJONALITET",
                Question = "Er OMF tilgjengelig som app på Apple TV?",
                Answer = "Per i dag er det dessverre ikke mulig å bruke Apple TV for å se filmene og seriene" +
                " våre. På grunn av rettighetsårsaker kan du ikke bruke Apple TV når du ser på video som" +
                " krever kopieringsbeskyttelse, noe som gjelder for våre filmer og serier. Vi jobber med en" +
                " rettighetsavtale og tekniske løsninger for å gjøre dette mulig",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion7 = new FAQDatabase()
            {
                Title = "FUNKSJONALITET",
                Question = "Hvordan fungerer strømming?",
                Answer = "Når du strømmer en film, trenger du ikke å vente på at filmen skal lastes ned på forhånd. " +
                "Avspilleren leser filen direkte fra serverne våre. Det fungerer på samme måte som når du bruker en " +
                "play-tjeneste. Dette betyr at man må være tilkoblet Internett under hele filmvisningen.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion8 = new FAQDatabase()
            {
                Title = "KONTO OG BETALING",
                Question = "Må man være medlem?",
                Answer = "Nei, du trenger ikke å være medlem. Dog får du flere muligheter med et kostnadsfritt" +
                " medlemskap. Du kan f.eks. kun kjøpe filmer og serier dersom du er et registrert medlem. Som " +
                "medlem kan du også velge hvilken enhet du vil se på. Dersom du leier filmen som «gjest» kan " +
                "du kun se filmen i nettleseren du brukte til å leie filmen.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion9 = new FAQDatabase()
            {
                Title = "KONTO OG BETALING",
                Question = "Hvor mye koster det?",
                Answer = "OMF er ingen abonnementstjeneste. Hos oss betaler du kun for det du ønsker å se på." +
                " Du kan leie eller kjøpe filmer, episoder eller hele sesonger av en TV-serie. Leiefilmer koster fra" +
                " 19 kr, kjøpefilmer fra 79 kr og episoder fra 9 kr / stk. " +
                "Prisen ser du når du klikker deg inn på en film eller serie.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion10 = new FAQDatabase()
            {
                Title = "KONTO OG BETALING",
                Question = "Hvorfor er det ulike priser på filmene?",
                Answer = "Det er ulike priser for ulike oppløsninger av filmer. Filmer er ofte tilgjengelig i både SD og HD. HD gir deg høyere og bedre oppløsning og koster derfor 10 kr mer. " +
                " Snart håper vi også på å kunne tilby filmer i 4K." +
                " Det finnes også ulike priser for leie eller kjøp av film. " +
                "Dersom du klikker på «FRA KR x» ved siden av filmen får du opp en rekke ulike valg: " +
                "HD er forhåndsvalgt ettersom de fleste av kundene våre foretrekker HD-kvalitet. " +
                "Hvis du ikke ønsker HD-kvalitet, må du som kunde gjøre et aktivt valg og endre fra HD til SD." +
                "Prisen på filmen, som er basert på valgene dine, vises i betalingsruten før du går videre til betalingen.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion11 = new FAQDatabase()
            {
                Title = "KONTO OG BETALING",
                Question = "Hvor kan jeg kjøpe verdikoder eller gavekort?",
                Answer = "Digitale verdikoder eller gavekort fås kjøpt hos:" +
                " Gogift.com. eller bladkongen.no",
                 ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion12 = new FAQDatabase()
            {
                Title = "HJELP OG FEILSØKING",
                Question = "Feilkoder på smart-TV",
                Answer = "Om du får feilkoder, feilmeldinger eller opplever avspillingsproblemer på " +
                "smart-TV-en din, ber vi deg sende oss en e-post med følgende informasjon:" +
                " TV-merke modellkode programvareversjoner appversjonen av OMF " +
                "Send e - posten til support@oslometfilms.com. " +
                "Legg gjerne ved et bilde som viser problemet på TV - en din.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion13 = new FAQDatabase()
            {
                Title = "HJELP OG FEILSØKING",
                Question = "Problem med usynkronisert undertekster på smart-TV",
                Answer = "Er underteksten usynkronisert?" +
                "For å kunne hjelpe deg med feilsøkingen trenger vi litt informasjon." +
                " Logg inn på smart-TV-en din og gå til «Min konto» helt nederst. " +
                "Der finner du informasjonen vi trenger for å kunne hjelpe deg med feilsøkingen:" +
                "TV-modellens fastvareversjon (operativsystem)." +
                "Vi ønsker også informasjon om hvilken film dette gjelder, og hvilket språk du valgte for underteksten. " +
                "Send denne informasjonen via e-post til support@oslometfilms.com, så hjelper vi deg!",
                 ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion14 = new FAQDatabase()
            {
                Title = "FINN OG SE",
                Question = "Er norske filmer tekstet på norsk?",
                Answer = "Våre norske filmer har som regel ikke undertekster. I norske filmer der det snakkes " +
                "på et utenlandsk språk i flere scener, legges det til undertekst i akkurat disse scenene.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion15 = new FAQDatabase()
            {
                Title = "FINN OG SE",
                Question = "Hvordan velger jeg HD-kvalitet?",
                Answer = "De fleste filmene er tilgjengelig i både SD og HD-kvalitet, og snart vil vi også kunne lansere visse filmer i 4K." +
                "Du velger kvalitet samtidig som du leier/kjøper filmen.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion16 = new FAQDatabase()
            {
                Title = "FINN OG SE",
                Question = "Hvorfor tas visse filmer ut av sortimentet?",
                Answer = "Filmene på siden vår er tilgjengelig så lenge vi eier visningsrettighetene til den enkelte filmen. " +
                "Dersom du ikke finner en film du har sett tidligere, betyr dette at visningsrettighetene vi hadde for filmen har utløpt. " +
                "Dette gjelder ikke alle filmer – kun noen av dem. Det er filmselskapet som bestemmer hvor lang visningsrettigheten er.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion17 = new FAQDatabase()
            {
                Title = "OM OSLOMET FILMS",
                Question = "Hvem er ansvarlig utgiver?",
                Answer = "For filmer som tidligere ikke har blitt distribuert i Norden og dermed ikke har en ansvarlig " +
                "utgiver, er Micheal Porseryd, visedirektør i OMF Studios, ansvarlig utgiver.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion18 = new FAQDatabase()
            {
                Title = "OM OSLOMET FILMS",
                Question = "Hvor kan jeg se på OMF?",
                Answer = "For filmer som tidligere ikke har blitt distribuert i Norden og dermed ikke har en ansvarlig OMF er i dag tilgjengelig på følgende plattformer:" +
                "På nettsiden oslometfilms.com via datamaskin eller laptop" +
                "På nyere versjoner av smart-TV -er fra Samsung, LG, Philips, Sony og Panasonic" +
                "På Android-telefoner og nettbrett" +
                "På iPhone og iPad (i disse appene kan man dog ikke leie, men kun se filmer man har leid gjennom f.eks. nettsiden)." +
                "I tillegg finner du OMF utvalg på de fleste av de store TV-operatørene. Du leier da gjennom operatørens TV-boks og betaler leie av filmen til dem",
                ThumbsUp = 0,
                ThumbsDown = 0
            };
            var nyQuestion19 = new FAQDatabase()
            {
                Title = "OM OSLOMET FILMS",
                Question = "Hva er OMF?",
                Answer = "OMF ble grunnlagt i 2018 med tre kompis fra Oslomet storbyen universitet og er i dag den ledende video on demand-tjenesten i Norden og Baltikum. OMF er en del av OMF Studios, som igjen er en del av Bonnier AB." +
               "På OMF kan du leie og kjøpe filmer og TV-serier digitalt. Du kan strømme eller laste ned leiefilmer så mange ganger du vil i løpet av 48 timer. Kjøpefilmer eier du, akkurat som en DVD, men digitalt hos oss på OMF. Den kan du senere laste ned til nettbrettet og mobilen, eller strømme så ofte du vil." +
               "På OMF betaler du kun for det du ser på. Tjenesten er tilgjengelig som app til Android og iOS, samt på smart-TV-er fra Samsung, Panasonic, LG, Sony og Philips. Tjenesten vår er også tilgjengelig gjennom ledende TV-operatører og OTT-partnere." +
               "Vi har et av Nordens største filmbibliotek og tilbyr alt fra Hollywoods nyeste storfilmer til mindre kvalitetsfilmer og TV-serier. OMF har kontrakt med alle de store filmstudioene som Warner, Disney, Fox, Paramount, Sony og Universal. Sammenlagt distribuerer vi innhold fra nesten 50 ulike internasjonale og nordiske filmselskap og filmdistributører.",
                ThumbsUp = 0,
                ThumbsDown = 0
            };

            var questionList = new List<FAQDatabase>();
            questionList.Add(nyQuestion1);
            questionList.Add(nyQuestion2);
            questionList.Add(nyQuestion3);
            questionList.Add(nyQuestion4);
            questionList.Add(nyQuestion5);
            questionList.Add(nyQuestion6);
            questionList.Add(nyQuestion7);
            questionList.Add(nyQuestion8);
            questionList.Add(nyQuestion9);
            questionList.Add(nyQuestion10);
            questionList.Add(nyQuestion11);
            questionList.Add(nyQuestion12);
            questionList.Add(nyQuestion13);
            questionList.Add(nyQuestion14);
            questionList.Add(nyQuestion15);
            questionList.Add(nyQuestion16);
            questionList.Add(nyQuestion17);
            questionList.Add(nyQuestion18);
            questionList.Add(nyQuestion19);
            context.FaqDatabases.AddRange(questionList);
            base.Seed(context);

        }
    }
}

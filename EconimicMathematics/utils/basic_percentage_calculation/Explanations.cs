using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils.basic_percentage_calculation
{
    class Explanations
    {
        public static string GetExplanation(int value)
        {
            switch(value)
            {
                case 0:
                    return GetExplanation_0();
                case 1:
                    return GetExplanation_1();
                case 2:
                    return GetExplanation_2();
                case 3:
                    return GetExplanation_3();
                case 4:
                    return GetExplanation_4();
                case 5:
                    return GetExplanation_5();
                case 6:
                    return GetExplanation_6();
                case 7:
                    return GetExplanation_7();
                case 8:
                    return GetExplanation_8();
                case 9:
                    return GetExplanation_9();
                case 10:
                    return GetExplanation_9();
                case 11:
                    return GetExplanation_5();
                case 12:
                    return GetExplanation_5();
                default:
                    return null;
            }
        }

        /*Get each explanation that is required to use
         in the each algorithm type...*/
        private static string GetExplanation_0()
        {
            string output = "Prosentti tarkoittaa aina sadasosaa jostakin.\n" +
                "1% = 1/100 = 0,01\n\n" +
                "Kaikki yllä olevat merkinnät ovat tarkalleen yhtä suuria,\n" +
                "mutta erilaisissa yhteyksissä käytetään erilaista merkintätapaa.\n" +
                "Esimerkiksi alennusmyynneissä käytetään yleisesti prosenttimerkintää\n" +
                "(esim.  Ale 30 %).\n\n" +
                "Prosenttiosuus tarkoittaa jotakin prosentin määrittelemää osaa jostakin\n" +
                "alkuperäisestä määrästä. Prosenttiosuus voi olla pienempi, saman kokoinen\n" +
                "tai suurempi kuin alkuperäinen määrä.";
               
            return output;
        }

        private static string GetExplanation_1()
        {
            string output = "Lasketaan montako prosenttia jokin on jostakin.\n" +
                "Ole tarkkana alkuperäisen arvon kanssa. Voit laske prosenttiluvun\n" +
                "käyttämällä yhtälöä tai kaavaa\n\n" +
                "% - luku = osa / kokonaisuus * 100%";

            return output;
        }

        private static string GetExplanation_2()
        {
            string output = "Lasketaan perusarvoa eli alkuperäistä arvoa.\n" +
                "Tämä alkuperäinen arvo voidaan laskea yhtälön avulla (A) %-luku x\n" +
                "alkuperäinen arvo = osat tai (B) jakamalla tiedetty osa sitä\n" +
                "vastaavalla prosenttiluvulla x 100";

            return output;
        }

        private static string GetExplanation_3()
        {
            string output = "Alennuksen laskeminen on prosenttiosuuden laskemista\n" +
                "alkuperäisestä arvosta.";

            return output;
        }

        private static string GetExplanation_4()
        {
            string output = "Korotuksen laskeminen on prosenttiosuuden laskemista\n" +
                "alkuperäisestä arvosta. Korotettu hinta on alkuperäinen\n" +
                "arvo (100 %) + prosentti.";

            return output;
        }

        private static string GetExplanation_5()
        {
            string output = "Prosenttilaskennan perusta\n\n" +
                "prosentti * alkuperäinen arvo = prosenttiosuus\n\n" +
                " - Merkitse prosentti aina desimaalilukumuodossa lausekkeeseen\n" +
                " - Merkitse tuntematon x:llä ja ratkaise syntyvä yhtälö\n\n" +
                "Soveltavissa tehtävissä mieti aina tarkasti, että lausekkeen vasemmalla\n" +
                "puolella oleva prosentti kuvaa aina samaa asiaa kuin lausekkeen oikealla\n" +
                "puolella oleva prosenttiosuus. Esimerkiksi jos lausekkeessa on\n" +
                "alennusprosentti, on oikealla puolella olevat luku alennuksen määrä.\n" +
                "Samoin ole tarkkana, että prosentti lasketaan aina alkuperäisestä\n" +
                "hinnasta, määrästä tai luvusta.";

            return output;
        }

        private static string GetExplanation_6()
        {
            string output = "Jos muutoksia tapahtuu useampia peräkkäin, huomaa että\n" +
                "alkuperäinen arvo muuttuu jokaisen muutoksen jälkeen. Eli jos hintaan\n" +
                "tulee 50 prosentin korotus ja sen jälkeen 50 prosentin alennus, ei\n" +
                "päädytä alkuperäiseen hintaan, vaan alkuperäistä pienempään hintaan\n" +
                "(kokeile esim. luvulla 100).";

            return output;
        }

        private static string GetExplanation_7()
        {
            string output = "Muutoksista käytetään prosenttimerkintöjä usein talouteen\n" +
                "liittyvissä yhteyksissä (esim. pörssikurssit, yrityksen tulos).\n" +
                "Muutosprosenttia laskettaessa jakajaksi merkitään aina se luku, josta\n" +
                "muutos on lähtenyt liikkeelle.";

            return output;
        }

        private static string GetExplanation_8()
        {
            string output = "Vertailtaessa asioita voidaan käyttää prosentteja.\n" +
                "Verrtailuprosenttia laskettaessa lausekkeen jakajaan merkitään aina se\n" +
                "luku, johon verrataan. Suomenkielessä tämä luku löytyy lauseesta\n" +
                "\"kuin\"-sanan jälkeen. Jos \"kuin\"-sanaa ei ole, muuta lausetta niin,\n" +
                "että saat siihen \"kuin\"-sanan.";

            return output;
        }

        private static string GetExplanation_9()
        {
            string output = "Palkkaan liittyviä termejä ovat bruttopalkka, nettopalkka,\n" +
                "ylityöt ja verokortti. Bruttopalkka tarkoittaa palkkaa, josta ei ole\n" +
                "vielä vähennetty veroja ja nettopalkka sitä palkanosaa, joka jää\n" +
                "jäljelle, kun verot on vähennetty. Verokortti määrittelee prosentin,\n" +
                "jonka mukaan veroja maksetaan. Verokortissa on kaksi prosenttia:\n" +
                "perusprosentti ja lisäprosentti. Veroja maksetaan perusprosentin mukaan,\n" +
                "kunnes verokortissa oleva tuloraja ylitetään. Tulorajan ylittävästä\n" +
                "palkkatulosta maksetaan lisäprosentin mukaan veroa.\n\n" +

                "Veroa maksetaan sekä kunnalle että valtiolle. Kunnallisveroa peritään\n" +
                "kaikilta saman kunnan asukkailta samalla veroprosentilla.\n" +
                "Kunnallisveroprosentti määräytyy sen kunnan mukaan, jossa on kirjoilla.\n" +
                "Koska veroprosentti on kaikille sama, sanotaan kunnallisveron olevan\n" +
                "tasavero. Valtionveron suuruus riippuu vuodessa ansaitun\n" +
                "palkkatulon mukaan. Suuremmasta tulosta maksetaan suuremmalla prosentilla\n" +
                "veroa kuin pienemmästä. Valtionvero on progressiivinen eli veroprosentti\n" +
                "kasvaa tulojen kasvaessa. Valtionveroa laskettaessa\n" +
                "tarvitaan valtionverotaulukkoa.\n\n" +

                "Jokainen huolehtii itse verokortistaan eli siitä, että veroprosentti on\n" +
                "sopivan suuruinen. Jos tuloraja tulee täyteen jo esimerkiksi lokakuun\n" +
                "alussa, joutuu lokakuusta joulukuun loppuun maksamaan veroa\n" +
                "lisäprosentilla. Jos työnanataja ei ole saanut verokorttia,\n" +
                "palkasta otetaan veroa 60 %. Verokortti ja verotukseen liittyvät\n" +
                "asiat on helpoin hoitaa internetissä osoitteessa vero.fi.\n\n" +
                "Ylitöiden tekemisen ehdoista määrätään työehtosopimuksissa. Eri aloilla\n" +
                "on erilaisia työehtosopimuksia. Usein ylitöistä maksetaan siten, että\n" +
                "päivän kahdelta ensimmäiseltä ylityötunnilta maksetaan\n" +
                "ylityökorvausta 50 % tuntipalkasta ja seuraavilta\n" +
                "tunneilta 100 % tuntipalkasta. Eli kahdelta ensimmäiseltä tunnilta saa\n" +
                "normaalin tuntipalkan ja siihen vielä puolet lisää, jolloin tuntipalkka\n" +
                "on 1,5-kertainen. Seuraavilta ylityötunneilta maksetaan kaksinkertaista\n" +
                "palkkaa. Monella alalla normaali työaika on kahdeksan tuntia päivässä.";

            //###########################################################################

            return output;
        }

    }
}

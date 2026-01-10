namespace SimulazionePartitaCalcioDifficile
{
    internal class Program
    {
        static int Somma(int[] squadra)
        {
            int somma = 0;

            for (int i = 0; i < squadra.Length; i++)//esegue la somma della squadraB
            {
                somma = +squadra[i] + somma;
            }
            return somma;
        }
        static void ValorizzazioneTitolari(int[] squadra)
        {
            Random random = new Random(); //assegnazione del valore
            for (int i = 0; i < squadra.Length; i++)//for per i valori
            {
                int punteggio = random.Next(1, 100);
                squadra[i] = punteggio;

            }
        }
        static void ValorizzazionePanchinari(int[] panchinari)
        {
            Random random = new Random(); //assegnazione del valore
            for (int i = 0; i < panchinari.Length; i++)//for per i valori
            {
                int punteggio = random.Next(1, 50);
                panchinari[i] = punteggio;
            }
        }
        static void stampaGiocatori(int[] squadra)
        {
            for (int i = 0; i < squadra.Length; i++)
            {
                Console.WriteLine("il giocatore " + i + " ha come punteggio " + squadra[i]);//VISUALIZZAZIONE
            }
        }
        static void stampaGiocatoriPanchinari(int[] panchinari)
        {
            for (int i = 0; i < panchinari.Length; i++)
            {
                Console.WriteLine("il giocatore in panchina " + i + " ha come punteggio " + panchinari[i]);//VISUALIZZAZIONE
            }
        }
        static void Main(string[] args)
        {
            // CREO I VETTORI DELLE SQUADRE
            int[] squadraA = new int[11], squadraB = new int[11], panchinariA = new int[5], panchinariB = new int[5];
            Console.WriteLine("SQUADRA 1");

            //RIEMPIE IL VETTORE DELLA SQUADRA A
            ValorizzazioneTitolari(squadraA);

            //RIEMPIE IL VETTORE DELLA SQUADRA A PANCHINARI
            ValorizzazionePanchinari(panchinariA);

            //STAMPO VETTORE SQUADRA A
            stampaGiocatori(squadraA);

            //STAMPO VETTORE SQUADRA A PANCHINARI
            stampaGiocatoriPanchinari(panchinariA);

            Console.WriteLine("SQUADRA 2");
            //RIEMPIE IL VETTORE DELLA SQUADRA B
            ValorizzazioneTitolari(squadraB);

            //RIEMPIE IL VETTORE DELLA SQUADRA B PANCHINARI
            ValorizzazionePanchinari(panchinariB);

            //STAMPO VETTORE SQUADRA B
            stampaGiocatori(squadraB);

            //STAMPO VETTORE SQUADRA B PANCHINARI
            stampaGiocatoriPanchinari(panchinariB);

            //SOMMA DELLA SQUADRA A
            int sommaSquadraA = Somma(squadraA);

            //SOMMA DELLA SQUADRA B
            int sommaSquadraB = Somma(squadraB);
            int sommaTot = sommaSquadraA + sommaSquadraB;
            int golSquadra = 0;
            int punteggioFinaleA = 0;
            int punteggioFinaleB = 0;

            //se hanno fatto gol
            Random rnd = new Random();
            int limiti = rnd.Next(0, 100);
            bool gol = false;
            for (int i = 0; i < 90; i++)
            {
                if (limiti < 2)
                {
                    gol = true;
                    if (gol == true)
                    {
                        Random rnd2 = new Random();
                        golSquadra = rnd2.Next(0, sommaTot);
                        if (golSquadra <= sommaSquadraA)
                        {
                            Console.WriteLine("HA SEGNATO LA SQUADRA A");
                            punteggioFinaleA++;
                        }
                        else
                        {
                            Console.WriteLine("HA SEGNATO LA SQUADRA B");
                            punteggioFinaleB++;
                        }

                    }
                }
            }

        }
    }
}
    


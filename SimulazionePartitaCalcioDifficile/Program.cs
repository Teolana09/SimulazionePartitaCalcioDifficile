namespace SimulazionePartitaCalcioDifficile
{
    internal class Program
    {
        static void CaloPuntiGiocatore(int[] squadra, int puntiDaSottrarre)
        {
            for (int i = 0; i < squadra.Length; i++)
            {
                squadra[i] -= puntiDaSottrarre;
            }
            //esegue il calo dei punti del giocatore selezionato
        }
        static void Sostituzioni(int[] squadra,int[] panchinari)
        {
            int sostituito = 0;
            Random random = new Random();
            sostituito = random.Next(0, 10);
            for (int i = 0; i < panchinari.Length; i++)
            {
                panchinari[i] = squadra[sostituito];
            }
            
        }
        static void incremetoPuntiGiocatore(int[] squadra, int puntiDaAggiungere)
        {
            for (int i = 0; i < squadra.Length; i++)
            {
                squadra[i] += puntiDaAggiungere;
            }
            //esegue l'incremento dei punti del giocatore selezionato
               
        }
        static int Somma(int[] squadra)
        {
            int somma = 0;

            for (int i = 0; i < squadra.Length; i++)//esegue la somma della squadraB
            {
                somma = squadra[i] + somma;
            }
            return somma;
        }
        static void ValorizzazioneTitolari(int[] squadra)
        {
            Random random = new Random(); //assegnazione del valore
            for (int i = 0; i < squadra.Length; i++)//for per i valori
            {
                int punteggio = random.Next(30, 100);
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

            
            int golSquadra = 0;
            int punteggioFinaleA = 0;
            int punteggioFinaleB = 0;
            int recupero = 0;
            int eventi = 0;

            //inizio partita
            Random random = new Random();
            for (int minuti = 0; minuti < 90 + recupero; minuti++)
            {
                //SOMMA DELLA SQUADRA A
                int sommaSquadraA = Somma(squadraA);

                //SOMMA DELLA SQUADRA B
                int sommaSquadraB = Somma(squadraB);
                //somma totale
                int sommaTot = sommaSquadraA + sommaSquadraB;
               
                int eventoNullo = random.Next(0, 100);
                if (eventoNullo < 50)
                {
                    //possibili eventi
                    eventi = random.Next(0, 100);
                    if (eventi < 8)
                    {

                        //se hanno fatto gol
                        
                        int limiti = random.Next(0, 100);
                        bool gol = false;                       
                        if (limiti < 2)
                        {
                            gol = true;
                            
                            
                                
                                golSquadra = random.Next(0, sommaTot);
                                if (golSquadra <= sommaSquadraA)
                                {
                                    Console.WriteLine("HA SEGNATO LA SQUADRA A");
                                    punteggioFinaleA++;
                                    incremetoPuntiGiocatore(squadraA, 3);
                                    
                                }
                                else
                                {
                                    Console.WriteLine("HA SEGNATO LA SQUADRA B");
                                    punteggioFinaleB++;
                                    incremetoPuntiGiocatore(squadraB, 3);
                                    
                                }

                        }
                        
                        if (minuti == 89)
                        {
                            
                            recupero = random.Next(1, 5);

                        }

                    }
                    if (eventi <= 25)
                    {
                        int ammonizioniGiocatori = 0;
                        
                        int giocatoreAmmonito = random.Next(0, 10);
                        for (int i = 0; i < 10; i++)//ciclo per trovare il giocatore ammonito SquadraA
                        {
                            if (giocatoreAmmonito == i)
                            {
                                Console.WriteLine("MINUTO " + (minuti + 1));//stampa il minutaggio
                                Console.WriteLine("IL GIOCATORE " + i + " DELLA SQUADRA A E' STATO AMMONITO");
                                squadraA[i] -= 5;
                                
                                squadraA[i] = ammonizioniGiocatori++;
                            }
                            if (ammonizioniGiocatori == 2)
                            {
                                Console.WriteLine("IL GIOCATORE " + i + " DELLA SQUADRA A E' STATO ESPULSO PER DOPPIA AMMONIZIONE");
                                squadraA[i] = 0;
                                
                            }


                        }
                        for (int i = 0; i < 10; i++)
                        {

                            if (giocatoreAmmonito == i)
                            {
                                Console.WriteLine("MINUTO " + (minuti + 1));//stampa il minutaggio
                                Console.WriteLine("IL GIOCATORE " + i + " DELLA SQUADRA B E' STATO AMMONITO");
                                squadraB[i] -= 5;
                                
                                squadraB[i] = ammonizioniGiocatori++;
                            }
                            if (ammonizioniGiocatori == 2)
                            {
                                Console.WriteLine("IL GIOCATORE " + i + " DELLA SQUADRA B E' STATO ESPULSO PER DOPPIA AMMONIZIONE");
                                squadraB[i] = 0;
                                
                            }
                        }

                    }
                    if (eventi <= 28)
                    {

                        
                        int giocatoreEspulso = random.Next(0, 10);
                        for (int i = 0; i < 10; i++)//ciclo per trovare il giocatore espulso SquadraA
                        {
                            if (giocatoreEspulso == i)
                            {
                                Console.WriteLine("MINUTO " + (minuti + 1));//stampa il minutaggio
                                Console.WriteLine("IL GIOCATORE " + i + " DELLA SQUADRA A E' STATO ESPULSO");
                                squadraA[i] = 0;
                                

                            }


                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (giocatoreEspulso == i)
                            {
                                Console.WriteLine("MINUTO " + (minuti + 1));//stampa il minutaggio
                                Console.WriteLine("IL GIOCATORE " + i + " DELLA SQUADRA B E' STATO ESPULSO");
                                squadraB[i] = 0;
                                
                            }
                        }


                    }
                    if (eventi <= 60)
                    {
                        int cambioSquadra = random.Next(0, 1);
                        if (cambioSquadra == 0)
                        {
                            Console.WriteLine("MINUTO " + (minuti + 1));//stampa il minutaggio
                            Console.WriteLine("LA SQUADRA B EFFETTUA UNA SOSTITUZIONE");
                            Sostituzioni(squadraB, panchinariB);
                        }
                        else
                        {
                            Console.WriteLine("MINUTO " + (minuti + 1));//stampa il minutaggio
                            Console.WriteLine("LA SQUADRA A EFFETTUA UNA SOSTITUZIONE");
                            Sostituzioni(squadraA, panchinariA);
                        }
                        

                    }
                    else
                    {
                        int calopunti = random.Next(0, 1);
                        if (calopunti == 0)
                        {
                            Console.WriteLine("MINUTO " + (minuti + 1));//stampa il minutaggio
                            Console.WriteLine("CALO PUNTI PER LA SQUADRA A");
                            CaloPuntiGiocatore(squadraA, 15);
                        }
                            
                        else
                        {
                            Console.WriteLine("MINUTO " + (minuti + 1));//stampa il minutaggio
                            Console.WriteLine("CALO PUNTI PER LA SQUADRA B");
                            CaloPuntiGiocatore(squadraB, 15);
                        }
                        
                    }
                }
                Console.WriteLine("NON E' SUCCESSO NESSUN EVENTO AL MINUTO " + (minuti + 1));

               
            }
            Console.WriteLine("IL RISULTATO FINALE E' " + punteggioFinaleA + " - " + punteggioFinaleB);
        }
    }

}



using SuperTrunfo.model;

namespace SuperTrunfo
{
    public partial class Form1 : Form
    {
        private List<Carta> cartas;
        private Jogador jogador1;
        private Jogador jogador2;
        public Form1()
        {
            InitializeComponent();
            GerarCartas();
            jogador1 = new Jogador();
            jogador2 = new Jogador();
            SortearCartas();
        }

        public void GerarCartas()
        {
            cartas = new List<Carta>()
            {
                new Carta()
                {
                    Nome = "Mewtwo",
                    Ataque = 95,
                    Defesa = 80,
                    Magia = 100,
                    Velocidade = 90,
                },
                new Carta()
                {
                    Nome = "Dragonite",
                    Ataque = 95,
                    Defesa = 90,
                    Magia = 85,
                    Velocidade = 75,
                },
                new Carta()
                {
                    Nome = "Mew",
                    Ataque = 85,
                    Defesa = 85,
                    Magia = 95,
                    Velocidade = 90,
                },
                new Carta()
                {
                    Nome = "Alakazam",
                    Ataque = 50,
                    Defesa = 45,
                    Magia = 95,
                    Velocidade = 95,
                },
                new Carta()
                {
                    Nome = "Snorlax",
                    Ataque = 85,
                    Defesa = 95,
                    Magia = 60,
                    Velocidade = 25,
                },
                new Carta()
                {
                    Nome = "Zapdos",
                    Ataque = 85,
                    Defesa = 80,
                    Magia = 90,
                    Velocidade = 90,
                },
                new Carta()
                {
                    Nome = "Articuno",
                    Ataque = 75,
                    Defesa = 90,
                    Magia = 95,
                    Velocidade = 75,
                },
                new Carta()
                {
                    Nome = "Moltres",
                    Ataque = 90,
                    Defesa = 75,
                    Magia = 90,
                    Velocidade = 85,
                },
                new Carta()
                {
                    Nome = "Gengar",
                    Ataque = 80,
                    Defesa = 55,
                    Magia = 95,
                    Velocidade = 90,
                },
                new Carta()
                {
                    Nome = "Machamp",
                    Ataque = 95,
                    Defesa = 85,
                    Magia = 50,
                    Velocidade = 60,
                },
                new Carta()
                {
                    Nome = "Gyarados",
                    Ataque = 90,
                    Defesa = 80,
                    Magia = 65,
                    Velocidade = 75,
                },
                new Carta()
                {
                    Nome = "Charizard",
                    Ataque = 90,
                    Defesa = 75,
                    Magia = 85,
                    Velocidade = 85,
                },
                new Carta()
                {
                    Nome = "Blastoise",
                    Ataque = 80,
                    Defesa = 90,
                    Magia = 80,
                    Velocidade = 60,
                },
                new Carta()
                {
                    Nome = "Venusaur",
                    Ataque = 75,
                    Defesa = 80,
                    Magia = 85,
                    Velocidade = 70,
                },
                new Carta()
                {
                    Nome = "Rhydon",
                    Ataque = 90,
                    Defesa = 95,
                    Magia = 40,
                    Velocidade = 35,
                },
                new Carta()
                {
                    Nome = "Arcanine",
                    Ataque = 90,
                    Defesa = 75,
                    Magia = 80,
                    Velocidade = 90,
                },
                new Carta()
                {
                    Nome = "Nidoking",
                    Ataque = 90,
                    Defesa = 75,
                    Magia = 75,
                    Velocidade = 70,
                },
                new Carta()
                {
                    Nome = "Nidoqueen",
                    Ataque = 80,
                    Defesa = 90,
                    Magia = 75,
                    Velocidade = 60,
                },
                new Carta()
                {
                    Nome = "Aerodactyl",
                    Ataque = 85,
                    Defesa = 60,
                    Magia = 55,
                    Velocidade = 95,
                },
                new Carta()
                {
                    Nome = "Exeggutor",
                    Ataque = 80,
                    Defesa = 80,
                    Magia = 95,
                    Velocidade = 40,
                },
                new Carta()
                {
                    Nome = "Scyther",
                    Ataque = 85,
                    Defesa = 65,
                    Magia = 45,
                    Velocidade = 95,
                },
                new Carta()
                {
                    Nome = "Raichu",
                    Ataque = 70,
                    Defesa = 60,
                    Magia = 80,
                    Velocidade = 90,
                },
                new Carta()
                {
                    Nome = "Pidgeot",
                    Ataque = 75,
                    Defesa = 65,
                    Magia = 60,
                    Velocidade = 85,
                },
                new Carta()
                {
                    Nome = "Pinsir",
                    Ataque = 90,
                    Defesa = 80,
                    Magia = 35,
                    Velocidade = 70,
                },
                new Carta()
                {
                    Nome = "Golem",
                    Ataque = 85,
                    Defesa = 90,
                    Magia = 45,
                    Velocidade = 30,
                },
                new Carta()
                {
                    Nome = "Electabuzz",
                    Ataque = 75,
                    Defesa = 60,
                    Magia = 85,
                    Velocidade = 90,
                },
                new Carta()
                {
                    Nome = "Onix",
                    Ataque = 45,
                    Defesa = 95,
                    Magia = 40,
                    Velocidade = 70,
                },
                new Carta()
                {
                    Nome = "Starmie",
                    Ataque = 70,
                    Defesa = 70,
                    Magia = 90,
                    Velocidade = 95,
                },
                new Carta()
                {
                    Nome = "Tauros",
                    Ataque = 85,
                    Defesa = 75,
                    Magia = 50,
                    Velocidade = 90,
                },
                new Carta()
                {
                    Nome = "Rapidash",
                    Ataque = 80,
                    Defesa = 60,
                    Magia = 70,
                    Velocidade = 95,
                },
                new Carta()
                {
                    Nome = "Ninetales",
                    Ataque = 65,
                    Defesa = 75,
                    Magia = 90,
                    Velocidade = 85,
                },
                new Carta()
                {
                    Nome = "Kangaskhan",
                    Ataque = 85,
                    Defesa = 85,
                    Magia = 45,
                    Velocidade = 75,
                },
            };
        }

        private void SortearCartas()
        {
            int numeroAleatorio = (int)new Random().NextInt64(0, cartas.Count);
            jogador1.cartas = new List<Carta>();
            jogador2.cartas = new List<Carta>();
            jogador1.cartas.Add(cartas[numeroAleatorio]);
            cartas.RemoveAt(numeroAleatorio);
            numeroAleatorio = (int)new Random().NextInt64(0, cartas.Count);
            jogador2.cartas.Add(cartas[numeroAleatorio]);
            cartas.RemoveAt(numeroAleatorio);
            TxtCartaJogador1.Text = jogador1.cartas[0].Nome;
            TxtCartaJogador2.Text = jogador2.cartas[0].Nome;
        }

        private void CompararCartas()
        {
            Carta carta1 = jogador1.cartas[0];
            Carta carta2 = jogador2.cartas[0];

            int vitoriasJogador1 = 0;
            int vitoriasJogador2 = 0;

            if (carta1.Ataque > carta2.Ataque)
                vitoriasJogador1++;
            else if (carta2.Ataque > carta1.Ataque)
                vitoriasJogador2++;

            if (carta1.Defesa > carta2.Defesa)
                vitoriasJogador1++;
            else if (carta2.Defesa > carta1.Defesa)
                vitoriasJogador2++;

            if (carta1.Magia > carta2.Magia)
                vitoriasJogador1++;
            else if (carta2.Magia > carta1.Magia)
                vitoriasJogador2++;

            if (carta1.Velocidade > carta2.Velocidade)
                vitoriasJogador1++;
            else if (carta2.Velocidade > carta1.Velocidade)
                vitoriasJogador2++;

            if (vitoriasJogador1 > vitoriasJogador2)
            {
                jogador1.Pontos++;
                MessageBox.Show("Jogador 1 venceu a rodada!");
            }
            else if (vitoriasJogador2 > vitoriasJogador1)
            {
                jogador2.Pontos++;
                MessageBox.Show("Jogador 2 venceu a rodada!");
            }
            else
            {
                MessageBox.Show("Empate!");
            }

            AtualizarPontuacao();
        }

        private void AtualizarPontuacao()
        {
            LblPontosJogador1.Text = "Pontos: " + jogador1.Pontos;
            LblPontosJogador2.Text = "Pontos: " + jogador2.Pontos;
        }

        private void BtnDistribuirCartas_Click(object sender, EventArgs e)
        {
            SortearCartas();
            CompararCartas();
        }
    }
}

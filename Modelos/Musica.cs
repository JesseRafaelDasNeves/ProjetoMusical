class Musica {

    public Musica(Banda artista, string nome) {
        this.Artista = artista;
        this.Nome    = nome;
    }

    public string Nome {get;}
    public Banda Artista {get;}
    public int Duracao {get; set;}
    public bool Disponivel {get; set;}
    public Genero ?Genero { get; set; }

    /*public string DescricaoResumida { 
        get {
            return $"A música {Nome} pertence a banda {Artista}";
        }
    }*/
    //Lambda (Arrow function)
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista.Nome}";

    public string DescricaoFichaTecnica() {
        string ficha = $"Nome: {Nome}";
        string disp  = Disponivel ? "Disponível no plano" : "Indisponível no plano";
        ficha += $"\nArtista: {Artista.Nome}";
        ficha += $"\nDuração: {Duracao}";
        ficha += $"\nDisponível: {disp}";
        return ficha;
    }

}
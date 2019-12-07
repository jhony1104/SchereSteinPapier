namespace SchereSteinPapierBase
{
	public interface ISpieler
	{
		string Spielername { get; }

		string Autoren { get; }

		int Version { get; }
        
		void NeuePartie(int runden, string gegnername, int gegnerversion);
        
		Geste MacheZug();
        
		void Zugergebnis(Ergebnis ergebnis, Geste eigeneGeste, Geste gegnerGeste);
        
		void Partieergebnis(int gewonnen, int verloren, int unentschieden);
	}
}

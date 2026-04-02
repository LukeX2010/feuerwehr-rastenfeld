namespace FeuerwehrRastenfeld.Models;

public class Einsatz
{
    public int Id { get; set; }
    public string Titel { get; set; } = "";
    public string Beschreibung { get; set; } = "";
    public DateTime Datum { get; set; }
    public string Kategorie { get; set; } = ""; // Brand, THL, Unwetter, etc.
    public string Ort { get; set; } = "";
    public int AnzahlKraefte { get; set; }
    public string Icon { get; set; } = "🔥";
}

public class Fahrzeug
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Kurzbezeichnung { get; set; } = "";
    public string Beschreibung { get; set; } = "";
    public string Baujahr { get; set; } = "";
    public string Hersteller { get; set; } = "";
    public string Bild { get; set; } = "fahrzeug-placeholder.svg";
    public List<string> Ausstattung { get; set; } = new();
}

public class Mitglied
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Dienstgrad { get; set; } = "";
    public string Funktion { get; set; } = "";
    public string Bild { get; set; } = "member-placeholder.svg";
    public int DienstjahreAb { get; set; }
}

public class NewsArtikel
{
    public int Id { get; set; }
    public string Titel { get; set; } = "";
    public string Kurztext { get; set; } = "";
    public string Volltext { get; set; } = "";
    public DateTime Datum { get; set; }
    public string Kategorie { get; set; } = "";
    public string Bild { get; set; } = "";
    public string Autor { get; set; } = "";
}

public class GalerieBild
{
    public int Id { get; set; }
    public string Titel { get; set; } = "";
    public string Datei { get; set; } = "";
    public string Kategorie { get; set; } = "";
    public int Jahr { get; set; }
}

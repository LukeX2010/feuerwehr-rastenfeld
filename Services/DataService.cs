using FeuerwehrRastenfeld.Models;

namespace FeuerwehrRastenfeld.Services;

/// <summary>
/// Zentraler Datendienst – liefert alle Mock-Daten der FF Rastenfeld.
/// In Produktion: durch API-Calls oder JSON-Dateien ersetzen.
/// </summary>
public class DataService
{
    public List<Einsatz> GetEinsaetze() => new()
    {
        new Einsatz { Id=1, Titel="Waldbrand Ottenstein", Beschreibung="Ausgedehnter Waldbrand im Bereich Stausee Ottenstein. Mehrere Feuerwehren im Löscheinsatz. Durch schnelles Eingreifen konnte eine Ausbreitung verhindert werden.", Datum=new DateTime(2024,7,14,14,22,0), Kategorie="Brand", Ort="Ottenstein", AnzahlKraefte=24, Icon="🔥" },
        new Einsatz { Id=2, Titel="Verkehrsunfall B35", Beschreibung="PKW kollidierte mit Leitplanke auf der B35 Richtung Zwettl. Eine Person musste aus dem Fahrzeug befreit werden. Erstversorgung durch FF und Rettung vor Ort.", Datum=new DateTime(2024,6,3,7,45,0), Kategorie="THL", Ort="B35 bei Rastenfeld", AnzahlKraefte=12, Icon="🚗" },
        new Einsatz { Id=3, Titel="Sturmschaden Ortsgebiet", Beschreibung="Nach schwerem Unwetter zahlreiche umgestürzte Bäume im Ortsgebiet. Straßen wurden freigeschnitten, Keller abgepumpt.", Datum=new DateTime(2024,5,19,18,10,0), Kategorie="Unwetter", Ort="Rastenfeld", AnzahlKraefte=18, Icon="⛈️" },
        new Einsatz { Id=4, Titel="Kellerbrand Wohnhaus", Beschreibung="Brand im Keller eines Wohnhauses in Rastenfeld. Bewohner konnten das Gebäude rechtzeitig verlassen. Feuer wurde rasch unter Kontrolle gebracht.", Datum=new DateTime(2024,4,28,21,33,0), Kategorie="Brand", Ort="Rastenfeld", AnzahlKraefte=15, Icon="🔥" },
        new Einsatz { Id=5, Titel="Tierrettung – Reh im Teich", Beschreibung="Ein Reh war in einem Gartenteich eingebrochen und konnte sich nicht selbst befreien. Tier wurde gerettet und unverletzt freigelassen.", Datum=new DateTime(2024,3,12,10,5,0), Kategorie="Sonstige", Ort="Rastenfeld", AnzahlKraefte=6, Icon="🦌" },
        new Einsatz { Id=6, Titel="Fahrzeugbrand LKW", Beschreibung="LKW geriet auf der Zufahrt zum TÜPL in Brand. Feuer konnte rasch auf das Führerhaus begrenzt werden.", Datum=new DateTime(2024,2,7,13,20,0), Kategorie="Brand", Ort="TÜPL Allentsteig", AnzahlKraefte=20, Icon="🚒" },
        new Einsatz { Id=7, Titel="Ölspur B37", Beschreibung="Größere Ölspur auf der B37 nach Defekt an einem Traktor. Straße wurde gereinigt und abgesperrt.", Datum=new DateTime(2024,1,18,8,0,0), Kategorie="Gefahrgut", Ort="B37", AnzahlKraefte=9, Icon="⚠️" },
        new Einsatz { Id=8, Titel="Hochwassereinsatz Kamp", Beschreibung="Nach anhaltenden Regenfällen Hochwasser entlang des Kamp. Keller ausgepumpt, Sandsäcke verlegt.", Datum=new DateTime(2023,12,30,6,0,0), Kategorie="Unwetter", Ort="Kamp-Ufer Rastenfeld", AnzahlKraefte=30, Icon="🌊" },
    };

    public List<Fahrzeug> GetFahrzeuge() => new()
    {
        new Fahrzeug { Id=1, Name="Tanklöschfahrzeug 4000", Kurzbezeichnung="TLF 4000", Beschreibung="Das TLF 4000 ist unser leistungsstärkstes Löschfahrzeug mit einem 4.000-Liter-Wassertank. Es wird bei Waldbränden und bei fehlender Wasserversorgung eingesetzt.", Baujahr="2019", Hersteller="Rosenbauer / MAN", Bild="tlf.svg", Ausstattung=new(){"4.000 L Wassertank","Hochdruckpumpe 2.000 l/min","Schaummittelbehälter 200 L","Atemschutzgeräte","Tragbare Stromerzeuger"} },
        new Fahrzeug { Id=2, Name="Hilfeleistungsfahrzeug", Kurzbezeichnung="HLF 2", Beschreibung="Das HLF 2 ist unser Erstangriffsfahrzeug für technische Hilfeleistungen und Brandeinsätze. Es ist mit modernstem Rettungsgerät ausgestattet.", Baujahr="2016", Hersteller="Rosenbauer / Mercedes-Benz", Bild="hlf.svg", Ausstattung=new(){"1.000 L Wassertank","Hydraulisches Rettungsgerät (Spreizer, Schere)","Atemschutz für 6 Personen","Lichtmast","Stromerzeuger 8 kVA"} },
        new Fahrzeug { Id=3, Name="Mannschaftstransportfahrzeug", Kurzbezeichnung="MTF", Beschreibung="Das MTF dient dem Transport von Einsatzkräften und wird bei größeren Einsätzen als Unterstützungsfahrzeug eingesetzt.", Baujahr="2014", Hersteller="Mercedes-Benz Sprinter", Bild="mtf.svg", Ausstattung=new(){"9 Sitzplätze","Werkzeugbeladung","Sanitätsausstattung","Tragkraftspritze"} },
        new Fahrzeug { Id=4, Name="Kommandofahrzeug", Kurzbezeichnung="KDO", Beschreibung="Führungsfahrzeug des Kommandanten für Einsatzleitung und Erkundung.", Baujahr="2020", Hersteller="VW Touareg", Bild="kdo.svg", Ausstattung=new(){"Digitalfunk TETRA","Einsatzleitrechner","Einsatzpläne","Messtechnik"} },
    };

    public List<Mitglied> GetMitglieder() => new()
    {
        new Mitglied { Id=1, Name="Hubert Maier", Dienstgrad="Hauptbrandinspektor", Funktion="Kommandant", DienstjahreAb=2005 },
        new Mitglied { Id=2, Name="Klaus Steiner", Dienstgrad="Brandinspektor", Funktion="Kommandant-Stellvertreter", DienstjahreAb=2008 },
        new Mitglied { Id=3, Name="Thomas Gruber", Dienstgrad="Revierinspektor", Funktion="Atemschutzwart", DienstjahreAb=2012 },
        new Mitglied { Id=4, Name="Markus Hofmann", Dienstgrad="Inspektor", Funktion="Gerätewart", DienstjahreAb=2015 },
        new Mitglied { Id=5, Name="Andreas Wiesinger", Dienstgrad="Löschmeister", Funktion="Schriftführer", DienstjahreAb=2017 },
        new Mitglied { Id=6, Name="Michael Bauer", Dienstgrad="Löschmeister", Funktion="Kassier", DienstjahreAb=2016 },
        new Mitglied { Id=7, Name="Stefan Kohl", Dienstgrad="Feuerwehrmann", Funktion="Einsatzkraft", DienstjahreAb=2019 },
        new Mitglied { Id=8, Name="Patrick Leitner", Dienstgrad="Feuerwehrmann", Funktion="Einsatzkraft", DienstjahreAb=2020 },
        new Mitglied { Id=9, Name="Lukas Berger", Dienstgrad="Feuerwehrmann", Funktion="Jugendbeauftragter", DienstjahreAb=2021 },
        new Mitglied { Id=10, Name="Julia Reiter", Dienstgrad="Feuerwehrfrau", Funktion="Einsatzkraft", DienstjahreAb=2022 },
        new Mitglied { Id=11, Name="David Fuchs", Dienstgrad="Feuerwehrmann", Funktion="Einsatzkraft", DienstjahreAb=2023 },
        new Mitglied { Id=12, Name="Simon Eder", Dienstgrad="Feuerwehrmann", Funktion="Einsatzkraft", DienstjahreAb=2023 },
    };

    public List<NewsArtikel> GetNews() => new()
    {
        new NewsArtikel { Id=1, Titel="Erfolgreiche Jahreshauptübung 2024", Kurztext="Die diesjährige Jahreshauptübung stand unter dem Motto 'Großbrand im Industriegebiet' und war ein voller Erfolg.", Volltext="Die diesjährige Jahreshauptübung der FF Rastenfeld fand unter dem Szenario 'Großbrand im Industriegebiet' statt. Rund 40 Feuerwehrmitglieder sowie Kräfte der Nachbarfeuerwehren übten gemeinsam den koordinierten Angriff auf ein simuliertes Feuer. Die Übungsleitung zeigte sich mit dem Ablauf sehr zufrieden.", Datum=new DateTime(2024,10,5), Kategorie="Übungen", Bild="news-uebung.svg", Autor="Schriftführer" },
        new NewsArtikel { Id=2, Titel="Neue Schutzausrüstung eingetroffen", Kurztext="Dank der Unterstützung des NÖ Landesfeuerwehrverbandes konnte neue persönliche Schutzausrüstung für 8 Mitglieder angeschafft werden.", Volltext="Die Freiwillige Feuerwehr Rastenfeld konnte neue Schutzausrüstung für 8 Feuerwehrmitglieder anschaffen. Die modernen Überjacken und -hosen entsprechen dem neuesten Stand der Technik und erhöhen die Sicherheit im Einsatz erheblich. Ein herzliches Dankeschön gilt der Marktgemeinde Rastenfeld für die finanzielle Unterstützung.", Datum=new DateTime(2024,9,12), Kategorie="Ausrüstung", Bild="news-ausruestung.svg", Autor="Kommandant" },
        new NewsArtikel { Id=3, Titel="Jugendfeuerwehr – Neue Mitglieder", Kurztext="Vier neue Jugendliche haben die Jugendfeuerwehr Rastenfeld verstärkt. Herzlich willkommen!", Volltext="Die Jugendfeuerwehr der FF Rastenfeld freut sich über vier neue Mitglieder im Alter von 10 bis 14 Jahren. Die Jugendlichen werden spielerisch an die Feuerwehrarbeit herangeführt und lernen Kameradschaft, Verantwortung und technische Fähigkeiten.", Datum=new DateTime(2024,8,20), Kategorie="Jugend", Bild="news-jugend.svg", Autor="Jugendbeauftragter" },
        new NewsArtikel { Id=4, Titel="Feuerwehrball 2025 – Save the Date!", Kurztext="Am 8. Februar 2025 findet der traditionelle Feuerwehrball der FF Rastenfeld im Kulturhaus Rastenfeld statt.", Volltext="Wir laden herzlich zum Feuerwehrball 2025 ein! Am Samstag, den 8. Februar 2025, ab 20:00 Uhr öffnet das Kulturhaus Rastenfeld seine Türen. Freut euch auf Musik, Tanz und gute Gesellschaft. Karten sind bei allen Feuerwehrmitgliedern erhältlich.", Datum=new DateTime(2024,12,1), Kategorie="Veranstaltungen", Bild="news-ball.svg", Autor="Schriftführer" },
        new NewsArtikel { Id=5, Titel="Atemschutzübung absolviert", Kurztext="12 Feuerwehrmitglieder haben die jährliche Atemschutzübung erfolgreich abgeschlossen.", Volltext="Regelmäßige Atemschutzübungen sind Pflicht für alle zertifizierten Atemschutzträger. In diesem Jahr absolvierten 12 Mitglieder der FF Rastenfeld die Übung im Atemschutzzentrum Krems. Alle Teilnehmer bestanden erfolgreich.", Datum=new DateTime(2024,11,15), Kategorie="Ausbildung", Bild="news-atemschutz.svg", Autor="Atemschutzwart" },
        new NewsArtikel { Id=6, Titel="Hochwassereinsatz Jahreswechsel", Kurztext="Beim Jahreswechsel musste die FF Rastenfeld wegen Hochwasser am Kamp ausrücken.", Volltext="An Silvester und Neujahr stand die FF Rastenfeld im Dauereinsatz. Starke Regenfälle hatten den Kamp deutlich ansteigen lassen. Keller wurden ausgepumpt, Sandsäcke verlegt. Ein großes Dankeschön an alle Einsatzkräfte, die auf die Silvesternacht verzichtet haben.", Datum=new DateTime(2024,1,2), Kategorie="Einsatz", Bild="news-hochwasser.svg", Autor="Kommandant" },
    };

    public List<GalerieBild> GetGalerie() => new()
    {
        new GalerieBild { Id=1, Titel="Jahreshauptübung 2024", Datei="galerie1.svg", Kategorie="Übungen", Jahr=2024 },
        new GalerieBild { Id=2, Titel="Feuerwehrball 2024", Datei="galerie2.svg", Kategorie="Veranstaltungen", Jahr=2024 },
        new GalerieBild { Id=3, Titel="Waldbrandeinsatz Ottenstein", Datei="galerie3.svg", Kategorie="Einsätze", Jahr=2024 },
        new GalerieBild { Id=4, Titel="Neues TLF 4000 Übergabe", Datei="galerie4.svg", Kategorie="Fahrzeuge", Jahr=2023 },
        new GalerieBild { Id=5, Titel="Jugendfeuerwehr beim Training", Datei="galerie5.svg", Kategorie="Jugend", Jahr=2024 },
        new GalerieBild { Id=6, Titel="Atemschutzübung Krems", Datei="galerie6.svg", Kategorie="Ausbildung", Jahr=2024 },
        new GalerieBild { Id=7, Titel="Kameradschaftsabend", Datei="galerie7.svg", Kategorie="Veranstaltungen", Jahr=2023 },
        new GalerieBild { Id=8, Titel="Hochwassereinsatz Kamp", Datei="galerie8.svg", Kategorie="Einsätze", Jahr=2023 },
        new GalerieBild { Id=9, Titel="Frühjahrsübung 2023", Datei="galerie9.svg", Kategorie="Übungen", Jahr=2023 },
    };
}

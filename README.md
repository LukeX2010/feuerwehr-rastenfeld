# 🔥 FF Rastenfeld – Website

Offizielle Website der Freiwilligen Feuerwehr Rastenfeld, Niederösterreich.

## Tech Stack

- **Blazor WebAssembly** (.NET 8)
- **C#** + Razor Components
- **CSS3** (custom, kein Framework – Mobile First)
- **Fonts:** Oswald + Source Sans 3 (Google Fonts)

## Projektstruktur

```
FeuerwehrRastenfeld/
├── Pages/
│   ├── Index.razor          → Startseite (Hero, Einsätze, News, CTA)
│   ├── UeberUns.razor       → Geschichte, Timeline, Org-Chart
│   ├── Mannschaft.razor     → Mitgliederübersicht
│   ├── Einsaetze.razor      → Einsatzchronik mit Filter
│   ├── Fahrzeuge.razor      → Fahrzeuge & Ausrüstung
│   ├── News.razor           → News-Übersicht + Detailseite
│   ├── Galerie.razor        → Bildgalerie mit Lightbox
│   ├── Kontakt.razor        → Kontaktformular + Karte
│   ├── Impressum.razor      → Österreichisches Impressum
│   └── Datenschutz.razor    → DSGVO Datenschutzerklärung
├── Components/
│   ├── NavMenu.razor        → Responsive Navigation
│   └── Footer.razor         → Footer mit Links
├── Layouts/
│   └── MainLayout.razor     → Haupt-Layout
├── Models/
│   └── Models.cs            → C# Datenmodelle
├── Services/
│   └── DataService.cs       → Mock-Datendienst
└── wwwroot/
    ├── index.html           → App-Shell mit SEO Meta-Tags
    ├── favicon.svg
    ├── css/app.css          → Komplettes Stylesheet
    └── js/app.js            → Animations, Scroll, Navbar
```

## Starten

```bash
dotnet restore
dotnet run
# → https://localhost:5001
```

## Daten anpassen

Alle Inhalte (Einsätze, Fahrzeuge, Mitglieder, News, Galerie) sind in
`Services/DataService.cs` als Mock-Daten hinterlegt. Einfach ersetzen
oder später durch eine API/JSON-Datei austauschen.

## Design

- **Farben:** Rot `#CC1111`, Dunkelgrau `#111418`, Weiß
- **Fonts:** Oswald (Headlines) + Source Sans 3 (Body)
- **Animationen:** Flame-Partikel im Hero, Fade-in on Scroll, Hover-Effekte
- **Responsive:** Vollständig optimiert für Mobile, Tablet & Desktop

## Kontakt / Reale Daten

- **Adresse:** Rastenfeld 178, 3532 Rastenfeld, NÖ
- **E-Mail:** rastenfeld@feuerwehr.gv.at  
- **Notruf:** 122

---
*Erstellt für die FF Rastenfeld – Bezirk Krems-Land, Niederösterreich*

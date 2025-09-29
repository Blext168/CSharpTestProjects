# 🌳 Composite Pattern

- `IGraphic` als gemeinsame Komponente,
- `Circle` & `Rectangle` als Leafs,
- `Group` als Composite, das beliebig viele Kinder enthalten kann,
- einen `GraphicEditor` als Client, der nur die `root`-Komponente kennt,
- eine DI-Erweiterungsmethode, die eine Beispielstruktur registriert.

## 📝 Definition

Das **Composite Pattern** ist ein **Strukturmuster** in der objektorientierten Programmierung.  
Es ermöglicht, **Objekte und Objektgruppen einheitlich zu behandeln**, indem beide dieselbe Schnittstelle implementieren.  
So lassen sich **Baumstrukturen** darstellen und rekursiv verarbeiten.

## 🔧 Problemstellung

- In grafischen Editoren, Dateisystemen oder Organisationsstrukturen gibt es sowohl **einfache Elemente** (z. B. Dateien, Formen) als auch **Sammlungen von Elementen** (z. B. Ordner, Gruppen).
- Der Client müsste für jede Art eigene Logik implementieren, wenn keine gemeinsame Schnittstelle existiert.
- Dies führt zu **dupliziertem Code** und **hoher Komplexität**.

👉 Beispiel: Ein Grafikprogramm soll Kreise und Rechtecke zeichnen, aber auch Gruppen von Formen. Ohne Composite müsste man den Unterschied immer beachten.

## 💡 Lösung

- Definiere ein **gemeinsames Interface** (`Component`), das sowohl von **einfachen Objekten** (Leaf) als auch von **Kompositionen** (Composite) implementiert wird.
- Ein Composite enthält eine Sammlung von Komponenten (Leafs oder weitere Composites).
- Der Client arbeitet nur gegen das **gemeinsame Interface** und kann alle Elemente **gleich behandeln**.

## 🏗️ Struktur
```
    Component
         ▲
┌────────┴─────────┐
│                  │
    Leaf Composite
         │
┌────────┴─────────┐
│ ... │
Component Component
```

## ✅ Vorteile

- Einheitliche Behandlung von Einzelobjekten und Objektgruppen.
- Einfaches Hinzufügen neuer Leaf- oder Composite-Typen.
- Unterstützt **rekursive Strukturen** (z. B. Bäume, verschachtelte Gruppen).

## ⚠️ Nachteile

- Kann zu **sehr generischen Interfaces** führen.
- Nicht jedes Verhalten ist für Leafs sinnvoll (z.B. `Add()` bei einem Kreis).

## 🤝 Anwendungsfälle

- **Grafikprogramme**: Formen & Gruppen von Formen.
- **Dateisysteme**: Dateien & Ordner.
- **Organisation**: Mitarbeiter & Abteilungen.
- **GUI-Frameworks**: Widgets & Container.

## 👉 Merksatz:

Mit dem Composite Pattern kannst du **Bäume von Objekten aufbauen** und sie so behandeln, als wären es **einzelne Objekte**.
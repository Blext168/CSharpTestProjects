# 🚚 Strategy-Pattern

- `IShippingStrategy` (Strategy) mit Name und `Calculate(...)`.
- Drei konkrete Strategien: `GroundShippingStrategy`, `AirShippingStrategy`, `DroneShippingStrategy`.
- `ShippingCalculator` (Context) delegiert die Kostenberechnung an die aktuelle Strategie und 
erlaubt Laufzeit-Wechsel via `SetStrategy()`
- DI-Extension `AddShippingStrategies()` registriert alle Strategien, erzeugt eine Default-Instanz für `ShippingCalculator` 
und stellt eine Factory `Func<string, IShippingStrategy>` zur Laufzeitauswahl 
bereit.
- Beispielausgabe zeigt Kosten für Default-, Air- und Drone-Strategie (mit Fehlerbehandlung bei
Überschreitung von Drone-Limits).

## 📂 Projektstruktur

BehaviroPatterns/
└── Program.cs # Einstiegspunkt, Demo<br>

BehaviorPatterns/Strategy/<br>
├── IShippingStrategy.cs # Strategy-Interface<br>
└── ShippingCalculator.cs # Context, der Strategien verwendet<br>

BehaviorPatterns/Strategy/Strategies/<br>
├── GroundShippingStrategy.cs # Konkrete Strategie: Bodenversand<br>
├── AirShippingStrategy.cs # Konkrete Strategie: Luftversand<br>
└── DroneShippingStrategy.cs # Konkrete Strategie: Drohnenversand<br>

BehaviorPatterns/Strategy/Extensions/<br>
└── ServiceCollectionExtensions.cs # DI-Registrierung & Factory<br>

---

## 🏗️ Pattern-Erklärung

## ❓ Problem

- Unterschiedliche Algorithmen sollen **austauschbar** sein (z. B. Versandkostenberechnung).
- Der Client möchte flexibel zwischen diesen Algorithmen wechseln können, **ohne** dass er deren Implementierungsdetails kennt.

## 💡 Lösung

- Definiere eine **Strategy-Schnittstelle** (`IShippingStrategy`).
- Implementiere verschiedene **konkrete Strategien** (Ground, Air, Drone).
- Ein **Context** (`ShippingCalculator`) nutzt eine Strategie und kann diese **zur Laufzeit ändern**.

## ✅ Vorteile

- Austauschbare Algorithmen ohne Änderung des Clients.
- Open/Closed Principle: Neue Strategien können einfach hinzugefügt werden.
- Saubere Trennung von **Berechnungslogik** und **Verwendung**.

## ⚠️ Nachteile

- Erhöhte Anzahl an Klassen.
- Auswahl der richtigen Strategie muss verwaltet werden (z. B. durch Factory oder Konfiguration).

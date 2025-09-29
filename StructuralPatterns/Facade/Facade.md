# 🎭 Facade-Pattern

- drei Subsystem-Klassen (```InventoryService```, ```PaymentService```, ```ShippingService```),
- eine ```OrderFacade```-Klasse, die ```PlaceOrder(...)``` bereitstellt und die Subsystem-Interaktionen kapselt,
- einen einfachen ```OrderController``` als Client,
- eine ```AddOrderFacade()```-Erweiterungsmethode zur sauberen DI-Registrierung,
- eine Anleitung, wie du das Projekt erstellst und ausführst.

##  📖️ Erklärung

## 📂 Projektstruktur
StructuralPatterns/<br>
└── Program.cs # Einstiegspunkt<br>

StructuralPatterns/Facade/<br>
├── OrderFacade.cs # Fassade<br>
└── OrderController.cs # Client, der die Fassade nutzt<br>

StructuralPatterns/Facade/Subsystems/<br>
├── InventoryService.cs # Subsystem: Lager<br>
├── PaymentService.cs # Subsystem: Zahlung<br>
└── ShippingService.cs # Subsystem: Versand<br>

StructuralPatterns/Facade/Extensions/<br>
└── ServiceCollectionExtensions.cs # DI-Registrierung<br>

## 🏗️ Pattern-Erklärung

### ❓ Problem
- Große Anwendungen enthalten mehrere **Subsysteme** mit komplexen APIs.
- Clients, die direkt mit diesen Subsystemen arbeiten, werden **stark gekoppelt** und schwer wartbar.

### 💡 Lösung
- Einführung einer **Fassade**, die eine **einheitliche, vereinfachte Schnittstelle** bereitstellt.
- Die Fassade kapselt interne Abhängigkeiten und Interaktionen, sodass der Client nur noch **eine Methode** aufrufen muss.

## ✅ Vorteile
- Vereinfachung der Nutzung komplexer Subsysteme.
- Reduziert Abhängigkeiten → Clients müssen interne Details nicht kennen.
- Bessere Wartbarkeit durch klare Trennung.

## ⚠️ Nachteile
- Zusätzliche Abstraktionsschicht (leichter Overhead).
- Gefahr eines „God-Objects“, wenn die Fassade zu viele Aufgaben übernimmt.

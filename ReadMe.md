# Creational Patterns

## Singleton

- <b>Zweck:</b> Sicherstellen, dass eine Klasse genau eine Instanz hat und globalen Zugriff bietet.
- <b>Problem:</b> Manche Ressourcen (z.b. Konfigurationen, Log, Connection-Pools) sollen nur einmal erzeugt werden.
- <b>Lösung:</b> Klasse verwaltet ihre einzige Instanz selbst (private Konstruktor + statische ```GetInstance()```-Methode)
- <b>Teilnehmer:</b> Singleton (die Klasse selbst)
- <b>Kurzes Beispiel (C#):</b>
```csharp
public class Logger
{
    private static Logger? _instance;

    private Logger() { }

    public static Logger GetInstance()
    {
        // Create an instance once at runtime
        _instance ??= new Logger();
        return _instance;
    }
}
```
- <b>Vor-/Nachteile:</b> Einfach zu benutzen, aber schwer testbar (Global State), Probleme mit Nebenläufigkeit und 
verborgenem Coupling. Verwenden, wenn wirklich global single instance nötig; sonst lieber Dependency Injection.

## Factory Method

- <b>Zweck:</b> Erzeugung von Objekten einer Familie delegieren, ohne konkrete Klassen zu binden.
- <b>Problem:</b> Client soll von konkreter Implementierung entkoppelt sein; Subklassen sollen bestimmen, 
welche Klasse instanziiert wird,
- <b>Lösung:</b> Definiere eine abstrakte Creator-Klasse mit einer Factory-Methode, die Subklassen implementieren.
- <b>Teilnehmer:</b> Creator (mit ```FactoryMethod```), ```ConcreteCreate```, ```Product``` (Interface), 
```ConcreteProduct```
- <b>Kurzes Beispiel (C#):</b>
```csharp
// Produkt
internal abstract class Dialog 
{
    private abstract Button CreateButton();
}

// Konkreter Typ
internal class WindowsDialog : Dialog 
{
    private Button CreateButton() 
    {
        return new WindowsButton();
    }
}
```
- <b>Wann einsetzen:</b> Wenn Klassen ihre Unterklassen zur Laufzeit auswählen sollen 
(z.B. plattformspezifische UI-Elemente)

## Abstract Factory

- <b>Zweck:</b> Familien von verwandten Objekten zusammen erzeugen (ohne ihre konkreten Klassen zu nennen).
- <b>Problem:</b> Mehrere zusammengehörige Objekte müssen zusammen passen (z.B. Theme: Button + Checkbox), 
Client soll nicht an konkrete Klassen gebunden sein.
- <b>Lösung:</b> Schnittstelle für Factory-Familie (z.B. ```UIFactory```) mit konkreten Factories
(WindowsFactory, MacFactory).
- <b>Teilnehmer:</b> ```AbstractFactory```, ```ConcreteFactory```, ```AbstractProduct(s)```, 
```ConcreteProduct(s)```.
- <b>Beispiel (Übersicht):</b> ```UIFactory.createButton()```, ```UIFactory.createCheckbox()``` 
— konkrete Factory liefert konkrete Produkte.
- <b>Vor-/Nachteile:</b> Erleichtert konsistente Produktfamilien; schwer zu erweitern, wenn neue Produktarten hinzukommen.

# Structural Patterns

## Adapter
- <b>Zweck:</b> Schnittstellen inkompatibler Klassen anpassen, sodass sie zusammenarbeiten.
- <b>Problem:</b> Du brauchst eine Klasse mit einer bestimmten Schnittstelle, 
hast aber eine vorhandene Klasse mit anderer API.
- <b>Lösung:</b> Adapter implementiert die erwartete Schnittstelle und übersetzt Aufrufe an das vorhandene 
Objekt (```Adaptee```)
- <b>Teilnehmer:</b> ```Target``` (erwartete Schnittstelle), ```Adapter```, ```Adaptee```
- <b>Beispiel:</b>
```csharp
internal interface Target
{
    internal void Request();
}

internal class Adaptee
{
    internal void SpecificRequest();
}

internal class Adapter : Target
{
    Adaptee _adaptee;
    
    Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }
    
    internal void Request()
    {
        adaptee.SpecificRequest();
    }
}
```
- <b>Vor-/Nachteile:</b> Gut für Legacy-Integration; kann Boilerplate erzeugen.

## Decorator

- <b>Zweck:</b> Verhalten von Objekten zur Laufzeit dynamisch erweitern ohne Subklassenexplosion.
- <b>Problem:</b> Viele Kombinationsmöglichkeiten von Funktionen → nicht für jede Kombination eine Subklasse erstellen.
- <b>Lösung:</b> ```Component Interface```, ```ConcreteComponent```, ```Decorator``` 
enthält ```Component``` und erweitert Verhalten vor/nach delegierten Aufruf.
- <b>Teilnehmer:</b> ```Component```, ```ConcreteComponent```, ```Decorator```, ```ConcreteDecorator(s)```
- <b>Beispiel:</b>
```csharp
internal interface Stream
{
    void Write(string pString);
}

internal class FileStream : Stream  { ... }

internal class BufferDecorator : Stream
{
    Stream _wrap;
    internal void Write(string pString)
    {
        /* Buffer */
        _wrap.Write(pString);
    } 
}
```
- <b>Wann einsetzen:</b> Wenn du flexibel Features kombinieren möchtest (I/O-Streams, UI-Widgets).

## Facade

- <b>Zweck:</b> Einfaches Interface zu komplexen Subsystemen bereitstellen.
- <b>Problem:</b> Client muss mit vielen Klassen/Methoden eines Subsystems arbeiten — zu komplex.
- <b>Lösung:</b> Fassade kapselt und bietet eine vereinfachte Schnittstelle, intern delegiert sie an Subsystemklassen.
- <b>Teilnehmer:</b> ```Facade```, Subsystemklassen.
- <b>Beispiel:</b> ```VideoConverter.Convert("mp4","avi")``` ruft intern mehrere Subsysteme 
(```Codec```, ```Buffer```, ```Disk```).
- <b>Vorteil:</b> Kapselung, geringere Kopplung
- <b>Nachteil:</b> kann zu „god-object“ werden, wenn zu viel Logik hineingepackt wird.

## Composite

- <b>Zweck:</b> Baumstrukturen von Objekten behandeln — einzelne Objekte (Leaf) und Kompositionen uniform behandeln.
- <b>Problem:</b> Client soll mit Einzelobjekten und Gruppen gleich umgehen (z. B. Dateien & Ordner).
- <b>Lösung:</b> Gemeinsame Komponentenschnittstelle; Composite hält Kinder und delegiert Operationen rekursiv.
- <b>Teilnehmer:</b> ```Component```, ```Leaf```, ```Composite```.
- <b>Beispiel:</b>
```csharp
internal interface Graphic
{
    void Draw();
}

internal class Circle : Graphic
{
    internal Circle()
    {
        Draw();
    }
}

internal class Group : Graphic
{
    List<Graphic> _childrens;
    
    internal Group(List<Graphic> pChildrens)
    {
        List<Graphic> _childrens = pChildrens;
        foreach (Graphic child in _childrens)
        {
            child.Draw();
        }
    }
}
```
- <b>Wann einsetzen:</b> Wenn Objekte und Container gleich behandelt werden sollen (GUI, Dateisysteme).

# Behavioral Patterns

## Observer (Listener / Publish-Subscribe)

- <b>Zweck:</b> Eins zu vielen Abhängigkeiten: Änderungen an einem Objekt automatisch an Interessenten (Observers) melden.
- <b>Problem:</b> Lose Kopplung zwischen Subjekt und vielen Beobachtern; dynamische Registrierung nötig.
- <b>Lösung:</b> Subject verwaltet Liste von Observers; ```Notify()``` ruft ```Update()``` bei allen auf.
- <b>Teilnehmer:</b> ```Subject```, ```Observer```.
- <b>Beispiel:</b>
```csharp
internal interface Observer 
{
    void Update();
}

internal class Subject 
{
    List<Observer> _Observer = new(); 
    
    internal void register(pObserver)
    {
        _Observer.add(pObserver);
    } 
    
    internal void notifyAll()
    {
        for(Observer observer in _Observer) 
        {
            observer.Update();
        }
    }
}
```
- <b>Einsatz:</b> GUI-Events, Event-Bus, Model/View-Updates. Achtung: Gefahr von Speicherlecks 
(nicht abgemeldete Listener).

## Strategy

- <b>Zweck:</b> Familie von Algorithmen definieren und austauschbar machen (zur Laufzeit auswählbar).
- <b>Problem:</b> Wenn Verhalten variiert und nicht in einer Klasse hartkodiert werden soll.
- <b>Lösung:</b> Strategy-Interface, konkrete Strategien implementieren das Interface, 
Context hält Referenz und delegiert.
- <b>Teilnehmer:</b> Strategy, ConcreteStrategy, Context.
- <b>Beispiel:</b>
```csharp
internal interface SortStrategy 
{
    void Sort(List pList);
}

internal class QuickSort : SortStrategy { ... }

internal class Context 
{
    SortStrategy _strategy;
    
    internal void SetStrategy(object pStrategy) 
    {
        _strategy = pStrategy;
    } 
    
    internal void Sort(List pList)
    {
        _strategy.Sort(pList);
    }
}
```
- <b>Vorteil:</b> Offene Erweiterbarkeit, Testbarkeit; <b>Nachteil:</b> viele kleine Klassen.

## Command

- <b>Zweck:</b> Aufruf als Objekt kapseln — Befehle parametrieren, stapeln, rückgängig machen, verzögern.
- <b>Problem:</b> Aktionen (z. B. Undo/Redo, Queue) verlangen Entkopplung von Aufrufer und Ausführer.
- <b>Lösung:</b> Command-Interface (```Execute()```), ```ConcreteCommand``` enthält Empfänger (Receiver) und ruft 
dessen Operationen. Invoker führt Command aus.
- <b>Teilnehmer:</b> ```Command```, ```ConcreteCommand```, ```Receiver```, ```Invoker```, ```Client```.
- <b>Beispiel:</b>
```csharp
internal interface Command 
{
    void Execute();
}

internal class LightOnCommand : Command 
{
    Light _light = new(); 
    
    internal LightOnCommand(Light pLight)
    {
        _light = pLight;
    }
    
    internal void Execute()
    {
        _light.On();
    }
}
```
- <b>Einsatz:</b> GUIs (Buttons), Job-Queues, Macro-Recorder, Undo/Redo.

## Template Method

- <b>Zweck:</b> Algorithmus-Skeleton in der Oberklasse definieren, bestimmte Schritte sollen 
Unterklassen implementieren.
- <b>Problem:</b> Gleicher Algorithmus mit kleinen Varianten in Teilschritten.
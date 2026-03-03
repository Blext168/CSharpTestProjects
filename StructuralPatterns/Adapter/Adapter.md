# Adapter-Pattern

- ```ITemperatureSensor``` (Target) — die erwartete Schnittstelle (Celsius).
- ```LegacyFahrenheitSensor``` (Adaptee) — vorhandene Klasse, die Fahrenheit liefert.
- ```FahrenheitToCelsiusAdapter``` (Adapter) — übersetzt Fahrenheit → Celsius und implementiert ITemperatureSensor.
- ```TemperatureDisplay``` (Client) — verwendet ITemperatureSensor ohne etwas von der Legacy-API zu merken.
- Zwei Wege der Registrierung im IServiceCollection:
- Manuelle Factory-Registrierung (mache Adapter aus der Legacy-Instanz).
- Eine AddAdaptedTemperatureSensor()-Extension-Methode, die Registrierung kapselt.
  
### Erklärung:
- ```LegacyFahrenheitSensor``` ist die bestehende Klasse mit inkompatibler API (Fahrenheit).
- ```FahrenheitToCelsiusAdapter``` implementiert die gewünschte Schnittstelle ```ITemperatureSensor```
  und übersetzt innerhalb von ```GetTemperatureCelsius()``` die Werte.
- In der DI-Registrierung zeigen wir zwei Varianten:
  a) Manuelle Registrierung: registriere Legacy-Klasse und baue Adapter in einer Factory.
  b) Extension-Methode ```AddAdaptedTemperatureSensor()```: kapselt die Registrierungen zentral.


Das Muster erlaubt es, das bestehende System (das Celsius erwartet) beizubehalten,
obwohl die verfügbare Hardware/API Fahrenheit liefert. Die Adapter-Klasse ist die
einzige, die die Übersetzung übernimmt; der Rest der Anwendung bleibt unverändert.
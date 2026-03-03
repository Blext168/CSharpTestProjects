# Decorator-Pattern

Kurz: die Datei enthält eine ```IMessageService```-Schnittstelle, eine ```BasicMessageService```-Implementierung und zwei 
Dekoratoren (```LoggingDecorator```, ```TimingDecorator```). Außerdem zeige ich zwei Registrierungsansätze: 
eine factory-basierte Lösung mit ```Microsoft.Extensions.DependencyInjection``` (voll funktionsfähig) und ein 
kommentiertes Beispiel, wie man es mit der Bibliothek Scrutor eleganter machen könnte.
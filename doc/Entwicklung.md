# Entwicklung

Die Standardmakros sind auch als Beispiel für die Entwicklung von Makros bei der Landeshauptstadt München gedacht.

## Aufbau

Das Programm ist ein [VSTO](https://en.wikipedia.org/wiki/Visual_Studio_Tools_for_Office)-Add-In für MS Office. Das Add-In ist in C# geschrieben.

Der Programmstart erfolgt in `ThisAddin.BeginInit()`. 

Die einzelnen Makros werden über einen Ribbon (LHM) aufgerufen. Die `ControlId` des Ribbon ist `TabLHM`. Wenn vom Kunden nicht anders gefordert, sollten alle Makros diesen Ribbon verwenden. Jedes Makro-Add-In verwendet eine eigene `RibbonGroup`, die als Namen den Namen des Add-Ins in der Form `MAK001 Name` verwendet.

## Dependency Injection

Das Makro verwendet [Castle Windsor](http://www.castleproject.org/projects/windsor/) für [Dependency Injection](https://en.wikipedia.org/wiki/Dependency_injection).
Beim Dependency Injection werden Objekte nicht direkt mit `new` initialisiert. Stattdessen werden über den Konstruktor oder öffenliche Properties fertig initialiserte Objekte übergeben.

In `ThisAddin.BeginInit()` wird ein sogenannter Container erzeugt, der dafür verantwortlich ist, Objekte zu erzeugen und zu injizieren. Alle Klassen müssen in diesem Container registriert werden, damit sie für das Dependency Injection verwendet werden können.

Der `ComponentInstaller` ist dafür verantwortlich, die Klassen zu finden, die im Container registriert werden sollen. Bei den StandardMakros werden alle Klassen registriert, die im Namespace `StandardMakros.Components` liegen.

Die Klasse `Makro` ist der Root des Objektbaums für die Anwendung.
Alle Aufrufe aus dem Ribbon müssen über die Klasse `Makro` laufen. Die Klasse darf ansonsten keine Businesslogik enthalten.

Businesslogik wird über Services zur Verfügung gestellt. Wie die Services aufgbaut sind ergibt sich aus den Anforderung. Ganz allgemein sollte jeder Service in sich abgeschlossen sein und eine fachliche Einheit bilden (z.B. DatabaseService).8

## MarkdownViewer

Der `MarkdownViewer` dient zur Anzeige von Hilfedateien in MS-Office. Die Erstellung von Markdowndateien ist wesentlich einfacher als die Erstellung der offiziellen Hilfedateien (.hlp, .chm) für Windows. Der `MarkdownViewer` zeigt eine Markdowndatei in einem eigenständigen Fenster an.

```csharp
new MarkdownViewer.MarkdownViewerPanel().Show(<text>);
```

Die Hilfedateien werden als Resource in das Add-On eingebettet ([Anleitung](https://docs.microsoft.com/de-de/visualstudio/ide/build-actions?view=vs-2019)).
Die Datei kann zur Laufzeit aus der Assembly ausgelesen und an den MarkdownViewer übergeben werden.

```csharp
using (Stream stream = assembly.GetManifestResourceStream(resourceName))
using (StreamReader reader = new StreamReader(stream))
{
    string result = reader.ReadToEnd();
    new MarkdownViewer.MarkdownViewerPanel().Show(result);
}
```

## Logging

Für das Logging wird [log4net](https://logging.apache.org/log4net/) verwendet. Eine Instanz des Loggers kann in einen Service über ein öffentliches Property injiziert werden.

```csharp
public ILogger Logger { get; set; }
```

Alle unbehandelten Exceptions werden mit dem Event `AppDomain.CurrentDomain.UnhandledException` geloggt.

## Programmierstil

Es gelten die [Coding Conventions für C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions).

## Abhängigkeiten

* Castle.Core
* Castle.Windsor
* Castle.LoggingFacility
* Castle.Core-log4net
* log4net

## Konfigurationsdatei

Die Verwendung von Konfigurationsdateien mit Add-Ins wird [hier](https://docs.microsoft.com/en-us/visualstudio/vsto/how-to-set-up-configuration-information-for-an-office-solution?view=vs-2017) beschrieben.

Informationen zum Lesen von Konfigurationsdateien befinden sich [hier](https://docs.microsoft.com/en-us/visualstudio/vsto/how-to-set-up-configuration-information-for-an-office-solution?view=vs-2017).
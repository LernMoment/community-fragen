# C# Fragen aus der LernMoment-Community für dich zum Lernen
Gerade wenn du autodidaktisch lernst und keinen Mentor, Kollegen oder Lerngruppe hast, fehlt dir Rückmeldung beim Lernen. Als (momentan noch nicht vollwertigen) Ersatz kannst du sehr gut Fragen verwenden. D.h. du schaust dir an was andere Einsteiger in C# für Fragen haben und versuchst diese für dich zu beantworten. Wenn du eine Frage sicher beantworten kannst, weißt du, dass du das Thema verstanden hast. Wenn nicht, dann merkst du an welcher Stelle es hakt.

Um genau diesen Prozess zu forcieren habe ich dieses Projekt hier erstellt. Aus Kommentaren an YouTube-Videos und Fragen in meinen [Online-Kursen](https://www.lernmoment.de/kurse/) sammele ich hier die Fragen die sich gut zum Lernen eignen. Zusätzlich werde ich nach und nach dazu selber meine Antwort geben und sofern sinnvoll auch passenden Quellcode veröffentlichen.

Mehr Details wie du mit diesen Fragen arbeiten kannst und Rückmeldung bekommst gebe ich dir in diesem Video (https://youtu.be/r2HHQ_xvaxI):
<p align="center">
  <a href="https://www.youtube.com/watch?v=r2HHQ_xvaxI" target="_blank">
    <img alt="Erklärvideo auf YouTube -> https://youtu.be/r2HHQ_xvaxI" src="https://img.youtube.com/vi/r2HHQ_xvaxI/0.jpg">
  </a>
</p>

**WICHTIG:** Deine Antworten und/oder Lösungsansätze kannst du [hier](https://github.com/LernMoment/community-fragen/issues/new/choose) mit mir und anderen aus der LernMoment-Community diskutieren. Eine Beispielantwort findest du [hier](https://github.com/LernMoment/community-fragen/issues/1).

Viel Spaß beim üben und los gehts:

## Fragen zu WPF

### WPF-1: Wie öffne ich ein "Unterfenster"?

> Danke für das sehr gute Video. mich würde interessieren, wie man verschiedene Frames "schalten" kann. Von einem Fenster in ein Unterfenster. die abhängig von einander sind. z.B ein unterframe in dem die Eigenschaften " farbe..." vom Ball eingestellt werden können. vielleicht ist es möglich darauf einzugehen. Danke. - [Peter](https://www.youtube.com/watch?v=ugji-_yWoRk&lc=UgzPS-jGhK0mC8dj_pp4AaABAg)

Erst hat mich der Ausdruck *Frames* etwas verwirrt, aber es geht darum Einstellungen zum [BallSpiel - Projekt](https://github.com/LernMoment/ballspiel), wie beispielsweise die Auswahl der Farbe, in einem separaten Fenster umzusetzen. Es könnte also beispielsweise ein `Button` auf der Oberfläche existieren der ein weiteres Fenster öffnet in dem man die Einstellungen macht.

<details><summary>Lösungshinweis (klick auf diese Zeile um einen Lösungshinweis zubekommen)</summary>
<p>

Fenster sind wie fast alles in C# und WPF Klassen. Du legst dir also über den Projektexplorer noch ein weiteres Fenster an und fügst die benötigten Controls hinzu.
Nun kannst du im `MainWindow` einen neuen Button einfügen. Im Eventhandler dazu legst du eine Instanz deines 2. Fensters an und kannst dann darauf entweder „Show“ aufrufen dann öffnet sich das weitere Fenster und du kannst beide Fenster parallel bedienen oder du rufst „ShowDialog“ auf der 2. Fensterinstanz auf und das 2. Fenster öffnet sich modal (du kannst also nur darin bedienen).
</p>
</details>

Eine "Musterantwort" zu dieser Frage habe ich [hier](https://github.com/LernMoment/community-fragen/issues/3) veröffentlicht. Eine Beispielanwendung die das Verhalten zeigt findest du [hier](https://github.com/LernMoment/community-fragen/tree/master/WPF-1/WPF1-Unterfenster).

### WPF-2: Wie kann ich den Datei-Explorer durch Klick auf einen Button öffnen?

> Hi ich bin grad dabei mit WPF etwas zu probieren und wollte mir grad so ein kleines Programm machen das einen Dateipfad öffnet. jedoch finde ich keine aktuelle Möglichkeit wie man einen Dateipfad öffnen kann. (C:\desktop\<Ortner>) Würde mich freuen wenn du mir helfen könntest. - [Markus](https://www.youtube.com/watch?v=ugji-_yWoRk&lc=Ugw10Rj-RRskacV0PT54AaABAg)

Durch weitere Fragen habe ich heraus gefunden, dass Markus mit dem Klick auf einen Button in einer WPF-Anwendung den Windows Datei-Explorer öffnen möchte. Dabei möchte er bei Bedarf einen bestimmten Pfad übergeben der direkt angezeigt werden soll.

<details><summary>Lösungshinweis (klick auf diese Zeile um einen Lösungshinweis zubekommen)</summary>
<p>

Es gibt die Klasse [`Process`](https://docs.microsoft.com/de-de/dotnet/api/system.diagnostics.process?view=netframework-4.8) mit der eine beliebige Anwendung auf deinem Rechner gestartet werden kann.
</p>
</details>

### WPF-3: Wie sollten Controls in XAML benannt werden?

> Hallo Jan,
> Du beginnst die Benennung, also `x:Name ...`, immer mit Großbuchstabe. Auf der Microsoft-Seite habe ich es mit Kleinbuchstaben gesehen. Ist das egal oder gibt es da eine Richtlinie? - [Marco](https://github.com/LernMoment/tictactoe-wpf/commit/af4ce60c5989d4a7fd1c22ed4ce85ee2612a6853#commitcomment-38068156)

Hier ein Beispiel aus meinem *XAML*-Code:
```xml
<Grid x:Name="Spielfeld">
  <Button x:Name="Kasten_0_0" Grid.Column="0" Grid.Row="0" Content="X"/>
  <Button x:Name="Kasten_1_0" Grid.Column="1" Grid.Row="0" Content="O"/>
</Grid>
```
Und so sieht es bei Microsoft Docs aus:
```xml
<Button x:Name="btn1" Background="Pink" 
        BorderBrush="Black" BorderThickness="1" 
        Click="OnClick1" ClickMode="Hover">
  ClickMe1
</Button>

<Button x:Name="btn2" Background="LightBlue" 
        BorderBrush="Black" BorderThickness="1" 
        Click="OnClick2" ClickMode="Press">
  ClickMe2
</Button>
```
In Ergänzung zu Marcos Frage würde ich gerne von dir wissen:
1. Warum ist eine konsistente Namensgebung und Schreibweise wichtig?
2. Würdest du den Namen eines `Controls` mit einem Groß- oder Kleinbuchstaben beginnen und warum?

## Allgemeine Fragen

### ALL-1: Kann ich eine Konsolenanwendung von einer externen Festplatte starten?

> Kann ich mir das Programm auch auf eine externe Festplatte runterladen? Hat das Programm dann weiterhin Adminrechte, wenn ich das ausgewählt habe? - [Bejam](https://www.youtube.com/watch?v=xhD1HCVj5V0&lc=UgxWkxvm6x__LIZ1YYF4AaABAg)

Diese Frage wurde im Kontext des [Visual Studio 2019 Tutorials](https://youtu.be/xhD1HCVj5V0) gestellt. Bei "dem Programm" handelt es sich um ein einfaches *Hallo Welt* als .NET Core Konsolenanwendung. Als Ergänzung zu dieser Frage kannst du auch gerne ausprobieren ob es zwischen *.NET Core* und *.NET Framework* irgendwelche Unterschiede gibt.
Der Teil mit den "Adminrechten" ist mir nicht ganz klar. Also was Bejam damit meint. Wenn du eine Idee hast bzw. eine Antwort hast bin ich sehr darauf gespannt.

Eine "Musterantwort" zu dieser Frage habe ich [hier](https://github.com/LernMoment/community-fragen/issues/1) veröffentlicht. Wenn du selber ausprobieren willst was passiert, dann kannst du [diese Beispielanwendungen](https://github.com/LernMoment/community-fragen/tree/master/ALL-1) verwenden.

### ALL-2: Wie kann ich ein Projekt mit Git-Versionieren in VisualStudio 2019?

> Sehr gutes Video! Aber ich kann den Haken zum Erstellen einer Git Repo nicht finden. Das könnte daran liegen, dass der gesamte Erstellendialog in Visual Studio 2019 geändert wurde. Weißt Du zufällig, wo man den in VS 2019 findet? - [Ti Fusberger](https://www.youtube.com/watch?v=V_IDzTNA_ns&lc=UgzLHzBOjSevEnEbmBR4AaABAg)

Zwischen VisualStudio 2017 und 2019 hat Microsoft den Weg geändert wie du Projekte zu Git hinzufügen kannst. In Visual Studio 2017 gab es die Möglichkeit direkt während der Projekterstellung zusagen, dass das Projekt mit Git verwaltet werden soll. Das hat sich in VS2019 geändert. Wie geht es nun?

Die Antwort dazu findest du in meinem Artikel [Versionskontrolle mit Git und Visual Studio 2019](https://www.lernmoment.de/alle/git-mit-visual-studio-2019/).

## Syntax Fragen

### SYN-1: Wie kann ich einen String in ein Char-Array wandeln?

> ich habe mal eine Frage und zwar habe ich probiert einzelne Zeichen von dem string in ein Array zu packen, nur bekomme ich Fehler. Ich hoffe du kannst mir helfen. Im folgenden noch mein Code. - [David](https://www.youtube.com/watch?v=HbZTrkIE9Io&lc=UgySK2NJhsZ6GwgzBiZ4AaABAg)

```csharp
string[] sUD = new string[8];
string text = Console.ReadLine();
for (int x = 0; x <= 7; x++)
{
    char sUD[x] = text[x];
}
```

Der Fragende lernt gerade einiges zum Thema `string` und möchte mithilfe des *Array-Operators* (also eckige Klammern) einen `string` in ein `char`-Array konvertieren. Hast du eine Ahnung wie das geht?

Meine Antwort dazu findest du [hier](https://github.com/LernMoment/community-fragen/issues/5);

## Fragen zum Thema Testen

### TES-1: Wie sollten private Methoden einer Klasse getestet werden?

>Hallo Jan, beim Unit Test habe ich die Möglichkeit öffentliche Methoden einer Klasse zu testen. Was ist aber mit den privaten Methoden die es in der gleichen Klasse gibt? Ignoriert man diese beim Test, weil diese indirekt mit den öffenlichen mit getestet werden oder wie geht man damit um? - [Markus](https://www.udemy.com/course/einstieg-in-csharp-software-programmieren-wie-ein-profi/?referralCode=73784B79162D93219DEC)

Das ist eine wirklich coole Frage von Markus! Er nimmt an einem Online-Kurs "Einstieg in C#" teil und hat sich gerade mit dem Thema automatische Unit-Tests beschäftigt. Dabei kommt man früher oder später zu dem Punkt eine möglichst hohe Testabdeckung zubekommen.

Meine Antwort dazu findest du [hier](https://github.com/LernMoment/community-fragen/issues/6)


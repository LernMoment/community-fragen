# C# Fragen aus LernMoment Community für dich zum Lernen
Gerade wenn du autodidaktisch lernst und keinen Mentor, Kollegen oder Lerngruppe hast, fehlt dir Rückmeldung beim Lernen. Als (momentan noch nicht vollwertigen) Ersatz kannst du sehr gut Fragen verwenden. D.h. du schaust dir an was andere Einsteiger in C# für Fragen haben und versuchst diese für dich zu beantworten. Wenn du eine Frage sicher beantworten kannst, weißt du, dass du das Thema verstanden hast. Wenn nicht, dann merkst du an welcher Stelle es hakt.

Um genau diesen Prozess zu forcieren habe ich dieses Projekt hier erstellt. Aus Kommentaren an YouTube-Videos und Fragen in meinen [Online-Kursen](https://www.lernmoment.de/kurse/) sammele ich hier die Fragen die sich gut zum Lernen eignen. Zusätzlich werde ich nach und nach dazu selber meine Antwort geben und sofern sinnvoll auch passenden Quellcode veröffentlichen.

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


### WPF-2: Wie kann ich den Datei-Explorer durch Klick auf einen Button öffnen?

> Hi ich bin grad dabei mit WPF etwas zu probieren und wollte mir grad so ein kleines Programm machen das einen Dateipfad öffnet. jedoch finde ich keine aktuelle Möglichkeit wie man einen Dateipfad öffnen kann. (C:\desktop\<Ortner>) Würde mich freuen wenn du mir helfen könntest. - [Markus](https://www.youtube.com/watch?v=ugji-_yWoRk&lc=Ugw10Rj-RRskacV0PT54AaABAg)

Durch weitere Fragen habe ich heraus gefunden, dass Markus mit dem Klick auf einen Button in einer WPF-Anwendung den Windows Datei-Explorer öffnen möchte. Dabei möchte er bei Bedarf einen bestimmten Pfad übergeben der direkt angezeigt werden soll.

<details><summary>Lösungshinweis (klick auf diese Zeile um einen Lösungshinweis zubekommen)</summary>
<p>

Es gibt die Klasse [`Process`](https://docs.microsoft.com/de-de/dotnet/api/system.diagnostics.process?view=netframework-4.8) mit der eine beliebige Anwendung auf deinem Rechner gestartet werden kann.
</p>
</details>

# C# Fragen aus LernMoment Community für dich zum Lernen
Gerade wenn du autodidaktisch lernst und keinen Mentor, Kollegen oder Lerngruppe hast, fehlt dir Rückmeldung beim Lernen. Als (momentan noch nicht vollwertigen) Ersatz kannst du sehr gut Fragen verwenden. D.h. du schaust dir an was andere Einsteiger in C# für Fragen haben und versuchst diese für dich zu beantworten. Wenn du eine Frage sicher beantworten kannst, weißt du, dass du das Thema verstanden hast. Wenn nicht, dann merkst du an welcher Stelle es hakt.

Um genau diesen Prozess zu forcieren habe ich dieses Projekt hier erstellt. Aus Kommentaren an YouTube-Videos und Fragen in meinen [Online-Kursen](https://www.lernmoment.de/kurse/) sammele ich hier die Fragen die sich gut zum Lernen eignen. Zusätzlich werde ich nach und nach dazu selber meine Antwort geben und sofern sinnvoll auch passenden Quellcode veröffentlichen.

Viel Spaß beim üben und los gehts:

## Fragen zu WPF

### Datei-Explorer durch Klick auf Button in einer WPF-Anwendung öffnen

> Hi ich bin grad dabei mit WPF etwas zu probieren und wollte mir grad so ein kleines Programm machen das einen Dateipfad öffnet. jedoch finde ich keine aktuelle Möglichkeit wie man einen Dateipfad öffnen kann. (C:\desktop\<Ortner>) Würde mich freuen wenn du mir helfen könntest. - [Markus](https://www.youtube.com/watch?v=ugji-_yWoRk&lc=Ugw10Rj-RRskacV0PT54AaABAg)

Durch weitere Fragen habe ich heraus gefunden, dass Markus mit dem Klick auf einen Button in einer WPF-Anwendung den Windows Datei-Explorer öffnen möchte. Dabei möchte er bei Bedarf einen bestimmten Pfad übergeben der direkt angezeigt werden soll.

<details><summary>Lösungshinweis (klick auf diese Zeile um einen Lösungshinweis zubekommen)</summary>
<p>

Es gibt die Klasse [`Process`](https://docs.microsoft.com/de-de/dotnet/api/system.diagnostics.process?view=netframework-4.8) mit der eine beliebige Anwendung auf deinem Rechner gestartet werden kann.
</p>
</details>

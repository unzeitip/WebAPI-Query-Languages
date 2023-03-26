# Zdrojový kód pro diplomovou práci s názvem *Dotazovací jazyky pro webové API*.<br />
Tento projekt bsahuje implementaci specifikace **JSON:API** na platformě .NET
## Spuštění ##
Web API lze spustit klasicky pomocí příkazu *dotnet run* z aktuálního adresáře.

Při spuštění z Visual Studia je nutné nastavit tento projekt jakožto jeden ze spouštěcích projektů.<br />

## Testování ##
Pro testování lze využít prohlížeč nebo jakýkoliv *tool* umožnující odesílání *GET* požadavku přes HTTP protokol.
### Základní příklady ###
**1. Projekce:**.
```
http://localhost:26846/api/actors?fields[actors]=firstName,lastName
```
**2. Selekce:**.
```
http://localhost:26846/api/actors?filter=equals(gender,'F')
```
**3. Stránkování:**.
```
http://localhost:26846/api/actors?page[size]=10
```
**4. Komplexní dotaz:**.
```
http://localhost:26846/api/actors?filter=equals(gender,'F')&page[size]=10&fields[actors]=firstName
```

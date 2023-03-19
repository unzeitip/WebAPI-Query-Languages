# Zdrojový kód pro diplomovou práci s názvem *Dotazovací jazyky pro webové API*.
Tento projekt bsahuje implementaci protokolu **ODATA** na platformě .NET
## Spuštění
Web API lze spustit klasicky pomocí příkazu *dotnet run* z aktuálního adresáře.

Při spuštění z Visual Studia je nutné nastavit tento projekt jakožto jeden ze spouštěcích projektů.

## Testování
Pro testování lze využít prohlížeč nebo jakýkoliv *tool* umožnující odesílání *GET* požadavku přes HTTP protokol.
### Základní příklady
**1. Projekce:**.
```
http://localhost:22900/api/actors?$select=firstName,lastName
```
**2. Selekce:**.
```
http://localhost:22900/api/actors?$filter=gender eq 'F'
```
**3. Stránkování:**.
```
http://localhost:22900/api/actors?$top=10
```
**4. Komplexní dotaz:**.
```
http://localhost:22900/api/actors?$top=10&$filter=gender eq 'F'&$select=firstName
```

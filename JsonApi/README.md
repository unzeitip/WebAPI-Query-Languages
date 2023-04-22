# Zdrojový kód pro diplomovou práci s názvem *Dotazovací jazyky pro webové API*
Tento projekt bsahuje implementaci dotazovacího jazyka **JSON:API** na platformě .NET.

## Testování
Pro testování lze využít prohlížeč nebo jakýkoliv *tool* umožnující odesílání *GET* požadavku přes HTTP protokol.
### Základní příklady
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

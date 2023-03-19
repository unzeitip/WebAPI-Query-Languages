# Zdrojový kód pro diplomovou práci s názvem *Dotazovací jazyky pro webové API*.
Obsahuje implementace vybraných dotazovacích jazyků na platformě **.NET**
## Jak začít
1. Nejdřív je nutné stáhnout zálohu databáze pro testovací účely. Stáhnout soubor
[imdb_ijs.bak](https://upolomouc-my.sharepoint.com/:u:/g/personal/unzepe01_upol_cz/EUn4EqHN1GZEgOZJ-bNTPlUB9fK4UiRPfSJrW5rYbLPXGQ?e=ZigBVX) a uložit ho do složky Shared.
2. Poté stáhnout SQL Server docker image, vytvořit z něj vlastní, nakonfigurovaný a spustit ho. Stačí použít [dockerfile](https://github.com/unzeitip/WebAPI-Query-Languages/blob/main/Shared/dockerfile)
pomocí příkazů z aktuálního adresáře:
   1. docker build -t unzepe01:latest ./Shared
   2. docker run -d --name unzepe01-sql-server -p 1433:1433 -t unzepe01:latest

4. Jakmile běží databáze, je možné rozběhnout následující implementace:
- [OData](https://github.com/unzeitip/WebAPI-Query-Languages/tree/main/OData)
- [JsonAPI](https://github.com/unzeitip/WebAPI-Query-Languages//tree/main/JsonApi)
- [Hot Chocolate](https://github.com/unzeitip/WebAPI-Query-Languages/tree/Dotnet/HotChocolate)
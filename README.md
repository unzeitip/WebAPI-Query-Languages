# Zdrojový kód pro diplomovou práci s názvem *Dotazovací jazyky pro webové API*.
Obsahuje implementace vybraných dotazovacích jazyků na platformě **.NET**<br /><br />
## Jak začít
Nejdřív je nutné stáhnout SQL Server docker image, vytvořit z něj vlastní, nakonfigurovaný a spustit ho. Stačí tedy použít [dockerfile](https://github.com/unzeitip/WebAPI-Query-Languages/blob/main/Shared/dockerfile) pomocí příkazů:
1. docker build -t unzepe01:latest ./Shared<br />
2. docker run -d --name unzepe01-sql-server -p 1433:1433 -t unzepe01:latest<br />
<br /><br />

Jakmile běží databáze, je možné rozběhnout následující implementace:<br />
- [OData](https://github.com/unzeitip/WebAPI-Query-Languages/tree/main/OData)<br />
- [JsonAPI](https://github.com/unzeitip/WebAPI-Query-Languages//tree/main/JsonApi)<br />
- [Hot Chocolate](https://github.com/unzeitip/WebAPI-Query-Languages/tree/Dotnet/HotChocolate)<br />
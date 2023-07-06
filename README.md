# Zdrojový kód pro diplomovou práci s názvem *Dotazovací jazyky pro webové API*.
Tento projekt obsahuje implementace vybraných dotazovacích jazyků na platformě **.NET**

## Požadavky
- [Docker Desktop](https://docs.docker.com/desktop/)

## Jak začít
1. Stáhněte zálohu databáze pro testovací účely.
Stáhněte soubor [imdb_ijs.bak](https://upolomouc-my.sharepoint.com/:u:/g/personal/unzepe01_upol_cz/EZ7UzAyqvIhOpX0hSHfyE_MBYvCBnnM2TwHpp3ZaVARx_w?e=ujAZwI) a uložte ho do složky Shared.
2. Sestavte a spusťte služby, včetně databázového serveru pomocí Docker Compose.
Z aktálního adresáře spusťte příkaz `docker-compose up`.

**Note**: První spuštění zahrnuje build projektů a import databáze. Tento proces může trvat několik minut.
Úspěšné dokončení procesu končí následující zprávou:
```
Recovery is complete. This is an informational message only. No user action is required.
```
## Kam pokračovat
Po úspěšném spuštění je možné otestovat jednotlivé dotazovací jazyky pomocí následujících odkazů:
- [OData](./OData)
- [JSON:API](./JsonApi)
- [HotChocolate](./Hot-Chocolate)

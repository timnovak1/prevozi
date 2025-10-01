Aplikacija mora vsebovati appsettings.json, ki mora vsebovati Connection string do PB in atribute potrebne za JWT. 

Primer appsettings.json (na voljo tudi v appsettings.Development.json):
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=geslo"
  },
  "Jwt": {
    "Key": "nekaj",
    "Issuer": "Prevozi.WebApi",
    "Audience": "Prevozi.WebApi.Client",
    "ExpMinutes": 60
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

```


Nadaljujemo z generacijo tabel. 
```bash
dotnet ef migrations add su_cuy_gar
dotnet ef database update
```
Testni SQL podatki:

```sql
insert into public.carriers  
("registrationNumber", "name", "fullName", "address", "contactPerson", "contactEmail", "contactPhone")
values
('6423388000', 'Arriva', 'ARRIVA, družba za prevoz potnikov, d.o.o.', 
	'Ulica Mirka Vadnova 8, Kranj, 4000 Kranj', 'Sasa Horvat', 'sasa.horvat@arriva.si', '+38642013126'),
('5143373000', 'Nomago', 'NOMAGO, storitve mobilnosti in potovanj, d.o.o.',
'Vošnjakova ulica 3, Ljubljana', 'Natalija Račič', 'natalija.racic@nomago.si', '+38674994183');

INSERT INTO public."users" 
("firstName", "lastName", "email", "password", "userRole") 
VALUES 
('Sheev', 'Palpatine', 'admin@dujpp.si', 'admin', 2),
('Mas', 'Amedda', 'inspector@dujpp.si', 'inspector', 1);

INSERT INTO public."users" 
("firstName", "lastName", "email", "password", "userRole", "carrierRegistrationNumber")
values 
('Quarsh', 'Panaka','arriva@dujpp.si', 'arriva', 0, '6423388000'),
('Arihnda', 'Pryce', 'nomago@dujpp.si', 'nomago', 0, '5143373000');
```

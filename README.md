
# ChargeHub.Vehicles

Projekt i Programmering 2 – Utvecklingsingenjör Electromobility.

## Beskrivning
Detta är ett C#-program som simulerar laddning av en elbil.

Programmet:
- Skapar en bil med 75 kWh batterikapacitet.
- Startar med 20 % batteriladdning.
- Laddar bilen med 30 kWh till 60 %.
- Laddar ytterligare 50 kWh till 100 %.
- Förhindrar att laddningen överstiger 100 %.
- Hanterar felaktiga laddningsvärden.

## Kör programmet
dotnet run

## Förväntat resultat
Startladdning: 20%
Efter 30 kWh: 60%
Efter ytterligare 50 kWh: 100%

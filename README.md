### RestauQuizz
Guess the rating of a restaurant based on photos and reviews

## Api
Uses [Google Places API](https://developers.google.com/maps/documentation/places/web-service) to find restaurants based on a city or a GPS location

Results for known cities are cached in a [DuckDB](https://duckdb.net/docs/introduction.html) database

## App
A .NET MAUI app that consumes the [Api](#api)

Can target **Windows** or **Android**

## Console
A simple console app to play a single round

## Core
The shared code

Components
- **QuizzGame**: Main game class
- **ScoreRepository**: Saves the player's scores locally
- **QuizzApiClient**: Used to consume the [Api](#api)
- **PhotoDownloader**: Downloads restaurants' photos
- **SoundEffects**: Handles playing the game's sounds

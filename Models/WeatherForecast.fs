namespace DotnetReactFSharp.Models

open System

type WeatherForecast public() = 
    member val DateFormatted : string = null with get, set
    member val TemperatureC : int = 0 with get, set
    member val Summary : string = null with get, set
    member this.TemperatureF 
        with get () = Math.Round(32.0 + ((float)this.TemperatureC / 0.5556), 2);

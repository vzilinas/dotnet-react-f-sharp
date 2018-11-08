namespace DotnetReactFSharp.Controllers

open Microsoft.AspNetCore.Mvc
open DotnetReactFSharp.Models
open System


[<Route("api/[controller]")>]
[<ApiController>]
type SampleDataController () =
    inherit ControllerBase()

    let Summaries = [|"Freezing"; "Bracing"; "Chilly"; "Cool"; "Mild"; "Warm"; "Balmy"; "Hot"; "Sweltering"; "Scorching"|]

    [<HttpGet("[action]")>]
    member this.WeatherForecasts() =
        let rnd = System.Random()
        let res1 = 
            query { 
                for i in 1 .. 5 do
                select ( new WeatherForecast(
                            DateFormatted = DateTime.Now.AddDays((float)i).ToString("d"), 
                            TemperatureC = rnd.Next(-20, 55), 
                            Summary = Summaries.[rnd.Next(Summaries.Length)]))
            } |> Seq.toList
        ActionResult<List<WeatherForecast>>(res1)
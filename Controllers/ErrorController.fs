namespace DotnetReactFSharp.Controllers

open Microsoft.AspNetCore.Mvc

type ErrorController () =
    inherit Controller()

    member this.Index () =
        this.View("Error")
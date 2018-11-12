namespace DotnetReactFSharp.Pages

open Microsoft.AspNetCore.Mvc
open Microsoft.AspNetCore.Mvc.RazorPages;
open System.Diagnostics
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Http


[<ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)>]
type ErrorViewModel () =
    inherit PageModel()
    member val RequestId : string = null with get, set
    member this.ShowRequestId with get() = not(obj.ReferenceEquals(this.RequestId, null)) 

    member this.OnGet() =
        if Activity.Current <> null then
            this.RequestId = Activity.Current.Id
        else
            this.RequestId = null // HttpContext.TraceIdentifier
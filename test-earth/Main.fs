module Flight.LatLng

open System
open Flight.Units
open Flight.Units.Angle
open Flight.Units.Convert
open Flight.Zone
open Flight.LatLng
open Flight.Units.DegMinSec
open Flight.Earth.Ellipsoid
open Flight.Vincenty

let es = bessel :: List.replicate 4 hayford

let xys =
    [ ((( 55, 45,  0.00000), (  0,  0,  0.0)), ((-33, 26,  0.00000), (108, 13,  0.00000)))
    ; ((( 37, 19, 54.95367), (  0,  0,  0.0)), (( 26,  7, 42.83946), ( 41, 28, 35.50729)))
    ; ((( 35, 16, 11.24862), (  0,  0,  0.0)), (( 67, 22, 14.77638), (137, 47, 28.31435)))
    ; (((  1,  0,  0.00000), (  0,  0,  0.0)), (( 0, -59, 53.83076), (179, 17, 48.02997)))
    ; (((  1,  0,  0.00000), (  0,  0,  0.0)), ((  1,  1, 15.18952), (179, 46, 17.84244)))
    ]
    |> List.map (fun ((xLat, xLng), (yLat, yLng)) ->
        let x = (DMS.FromTuple xLat, DMS.FromTuple xLng)
        let y = (DMS.FromTuple yLat, DMS.FromTuple yLng)
        (x, y))

[<EntryPoint>]
let main argv =
    printf "Distances from Vincenty's 1975 paper using 1x Bessel and 4x Hayford ellipsoids:\r\n"
    printf "%O\r\n" bessel
    printf "%O\r\n" hayford
    for (e, (x, y)) in List.zip es xys do
        let x' = LatLng.FromDMS x
        let y' = LatLng.FromDMS y
        let (TaskDistance d) = distance e x' y'
        printf "Distance %O => %O = %fm\r\n" x y d

    0
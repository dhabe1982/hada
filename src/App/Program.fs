open Aardvark.Base
open FShade
   
let a : FShade.Effect = Unchecked.defaultof<_>
let b = 1
type Data = { pos : V4d; tc : V2d }

let shader (d : Data) =
    vertex {
        let mvp : M44d = uniform?ModelViewProjMatrix
        return { pos = mvp * d.pos; tc = 2.0 * d.tc }
    }

let effect = Effect.ofFunction shader

effect
    // Effect -> Module (the config specifies desired outputs, etc.)
    |> Effect.toModule { 
        EffectConfig.empty with 
            lastStage = ShaderStage.Vertex
            outputs = Map.ofList ["pos", (typeof<V4d>, 0)]
        }

    // Module -> CModule
    |> ModuleCompiler.compile glsl410

    // CModule -> string
    |> GLSL.Assembler.assemble glsl410  

    // show the code
    |> printfn "%s"

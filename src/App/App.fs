module App

open Browser
open Components

// Entry point must be in a separate file
// for Vite Hot Reload to work
 
Solid.render((fun () -> Sketch.Component(10)), document.getElementById("app-container"))

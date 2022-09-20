> **ATTENTION**: This repo has been now superseded by the following repos:
>
> - https://github.com/fable-compiler/Feliz.JSX
> - https://github.com/fable-compiler/Fable.Solid

# Feliz.Solid

This is an early prototype to compile F# to JSX in order to use a [Feliz-like](https://zaid-ajaj.github.io/Feliz/) HTML API with [SolidJS](https://www.solidjs.com/).

To test run `npm install && npm start`. Note that JSX elements need to be **solved at compile time** so it's not possible to use list generators for HTML attributes or children.

> Note: Requires Fable 4 Snake Island (currently in alpha)

![Screen cast](./screencast.gif)

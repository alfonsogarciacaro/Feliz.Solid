namespace Feliz

open System
open Fable.Core
open Fable.Core.JsInterop

module HtmlUtil =
    let inline childrenToProp (children: JSX.Element list): JSX.Prop = "children", children
    let inline childToProp (child: JSX.Element): JSX.Prop = "children", [child]
    let inline childStrToProp (child: string): JSX.Prop = "children", [child]

open HtmlUtil

/// <summary>HTML generator API.</summary>
type HtmlEngine() =
    /// Create a custom element
    ///
    /// You generally shouldn't need to use this, if you notice an element missing please submit an issue.
    member inline _.custom (key: string, props: JSX.Prop list) = JSX.create key props

    /// The empty element, renders nothing on screen
    member inline _.none : JSX.Element = null

    /// Cast multiple elements into one
    member inline _.fragment (children: JSX.Element list): JSX.Element = JSX. create "" ["children", children]

    member inline _.children (children: JSX.Element list): JSX.Prop = childrenToProp children

    member inline _.style (styles: (string * string) seq): JSX.Prop =
        "style", createObj !!styles

    member inline _.a (props: JSX.Prop list) = JSX.create "a" props

    member inline _.abbr (value: float) = JSX.create "abbr" [childStrToProp(Util.asString value)]
    member inline _.abbr (value: int) = JSX.create "abbr" [childStrToProp(Util.asString value)]
    member inline _.abbr (value: JSX.Element) = JSX.create "abbr" [childToProp value]
    member inline _.abbr (value: string) = JSX.create "abbr" [childStrToProp value]
    member inline _.abbr (props: JSX.Prop list) = JSX.create "abbr" props

    member inline _.address (value: float) = JSX.create "address" [childStrToProp(Util.asString value)]
    member inline _.address (value: int) = JSX.create "address" [childStrToProp(Util.asString value)]
    member inline _.address (value: JSX.Element) = JSX.create "address" [childToProp value]
    member inline _.address (value: string) = JSX.create "address" [childStrToProp value]
    member inline _.address (props: JSX.Prop list) = JSX.create "address" props

    member inline _.anchor (props: JSX.Prop list) = JSX.create "a" props

    member inline _.area (props: JSX.Prop list) = JSX.create "area" props

    member inline _.article (props: JSX.Prop list) = JSX.create "article" props

    member inline _.aside (props: JSX.Prop list) = JSX.create "aside" props

    member inline _.audio (props: JSX.Prop list) = JSX.create "audio" props

    member inline _.b (value: float) = JSX.create "b" [childStrToProp(Util.asString value)]
    member inline _.b (value: int) = JSX.create "b" [childStrToProp(Util.asString value)]
    member inline _.b (value: JSX.Element) = JSX.create "b" [childToProp value]
    member inline _.b (value: string) = JSX.create "b" [childStrToProp value]
    member inline _.b (props: JSX.Prop list) = JSX.create "b" props

    member inline _.base' (props: JSX.Prop list) = JSX.create "base" props

    member inline _.bdi (value: float) = JSX.create "bdi" [childStrToProp(Util.asString value)]
    member inline _.bdi (value: int) = JSX.create "bdi" [childStrToProp(Util.asString value)]
    member inline _.bdi (value: JSX.Element) = JSX.create "bdi" [childToProp value]
    member inline _.bdi (value: string) = JSX.create "bdi" [childStrToProp value]
    member inline _.bdi (props: JSX.Prop list) = JSX.create "bdi" props

    member inline _.bdo (value: float) = JSX.create "bdo" [childStrToProp(Util.asString value)]
    member inline _.bdo (value: int) = JSX.create "bdo" [childStrToProp(Util.asString value)]
    member inline _.bdo (value: JSX.Element) = JSX.create "bdo" [childToProp value]
    member inline _.bdo (value: string) = JSX.create "bdo" [childStrToProp value]
    member inline _.bdo (props: JSX.Prop list) = JSX.create "bdo" props

    member inline _.blockquote (value: float) = JSX.create "blockquote" [childStrToProp(Util.asString value)]
    member inline _.blockquote (value: int) = JSX.create "blockquote" [childStrToProp(Util.asString value)]
    member inline _.blockquote (value: JSX.Element) = JSX.create "blockquote" [childToProp value]
    member inline _.blockquote (value: string) = JSX.create "blockquote" [childStrToProp value]
    member inline _.blockquote (props: JSX.Prop list) = JSX.create "blockquote" props

    member inline _.body (value: float) = JSX.create "body" [childStrToProp(Util.asString value)]
    member inline _.body (value: int) = JSX.create "body" [childStrToProp(Util.asString value)]
    member inline _.body (value: JSX.Element) = JSX.create "body" [childToProp value]
    member inline _.body (value: string) = JSX.create "body" [childStrToProp value]
    member inline _.body (props: JSX.Prop list) = JSX.create "body" props

    member inline _.br (props: JSX.Prop list) = JSX.create "br" props

    member inline _.button (props: JSX.Prop list) = JSX.create "button" props

    member inline _.canvas (props: JSX.Prop list) = JSX.create "canvas" props

    member inline _.caption (value: float) = JSX.create "caption" [childStrToProp(Util.asString value)]
    member inline _.caption (value: int) = JSX.create "caption" [childStrToProp(Util.asString value)]
    member inline _.caption (value: JSX.Element) = JSX.create "caption" [childToProp value]
    member inline _.caption (value: string) = JSX.create "caption" [childStrToProp value]
    member inline _.caption (props: JSX.Prop list) = JSX.create "caption" props

    member inline _.cite (value: float) = JSX.create "cite" [childStrToProp(Util.asString value)]
    member inline _.cite (value: int) = JSX.create "cite" [childStrToProp(Util.asString value)]
    member inline _.cite (value: JSX.Element) = JSX.create "cite" [childToProp value]
    member inline _.cite (value: string) = JSX.create "cite" [childStrToProp value]
    member inline _.cite (props: JSX.Prop list) = JSX.create "cite" props

    // member inline _.code (value: bool) = JSX.create "code" value
    member inline _.code (value: float) = JSX.create "code" [childStrToProp(Util.asString value)]
    member inline _.code (value: int) = JSX.create "code" [childStrToProp(Util.asString value)]
    member inline _.code (value: JSX.Element) = JSX.create "code" [childToProp value]
    member inline _.code (value: string) = JSX.create "code" [childStrToProp value]
    member inline _.code (props: JSX.Prop list) = JSX.create "code" props

    member inline _.col (props: JSX.Prop list) = JSX.create "col" props

    member inline _.colgroup (props: JSX.Prop list) = JSX.create "colgroup" props

    member inline _.data (value: float) = JSX.create "data" [childStrToProp(Util.asString value)]
    member inline _.data (value: int) = JSX.create "data" [childStrToProp(Util.asString value)]
    member inline _.data (value: JSX.Element) = JSX.create "data" [childToProp value]
    member inline _.data (value: string) = JSX.create "data" [childStrToProp value]
    member inline _.data (props: JSX.Prop list) = JSX.create "data" props

    member inline _.datalist (value: float) = JSX.create "datalist" [childStrToProp(Util.asString value)]
    member inline _.datalist (value: int) = JSX.create "datalist" [childStrToProp(Util.asString value)]
    member inline _.datalist (value: JSX.Element) = JSX.create "datalist" [childToProp value]
    member inline _.datalist (value: string) = JSX.create "datalist" [childStrToProp value]
    member inline _.datalist (props: JSX.Prop list) = JSX.create "datalist" props

    member inline _.dd (value: float) = JSX.create "dd" [childStrToProp(Util.asString value)]
    member inline _.dd (value: int) = JSX.create "dd" [childStrToProp(Util.asString value)]
    member inline _.dd (value: JSX.Element) = JSX.create "dd" [childToProp value]
    member inline _.dd (value: string) = JSX.create "dd" [childStrToProp value]
    member inline _.dd (props: JSX.Prop list) = JSX.create "dd" props

    member inline _.del (value: float) = JSX.create "del" [childStrToProp(Util.asString value)]
    member inline _.del (value: int) = JSX.create "del" [childStrToProp(Util.asString value)]
    member inline _.del (value: JSX.Element) = JSX.create "del" [childToProp value]
    member inline _.del (value: string) = JSX.create "del" [childStrToProp value]
    member inline _.del (props: JSX.Prop list) = JSX.create "del" props

    member inline _.details (props: JSX.Prop list) = JSX.create "details" props

    member inline _.dfn (value: float) = JSX.create "dfn" [childStrToProp(Util.asString value)]
    member inline _.dfn (value: int) = JSX.create "dfn" [childStrToProp(Util.asString value)]
    member inline _.dfn (value: JSX.Element) = JSX.create "dfn" [childToProp value]
    member inline _.dfn (value: string) = JSX.create "dfn" [childStrToProp value]
    member inline _.dfn (props: JSX.Prop list) = JSX.create "dfn" props

    member inline _.dialog (value: float) = JSX.create "dialog" [childStrToProp(Util.asString value)]
    member inline _.dialog (value: int) = JSX.create "dialog" [childStrToProp(Util.asString value)]
    member inline _.dialog (value: JSX.Element) = JSX.create "dialog" [childToProp value]
    member inline _.dialog (value: string) = JSX.create "dialog" [childStrToProp value]
    member inline _.dialog (props: JSX.Prop list) = JSX.create "dialog" props

    member inline _.div (value: float) = JSX.create "div" [childStrToProp(Util.asString value)]
    member inline _.div (value: int) = JSX.create "div" [childStrToProp(Util.asString value)]
    member inline _.div (value: JSX.Element) = JSX.create "div" [childToProp value]
    member inline _.div (children: JSX.Element list) = JSX.create "div" [childrenToProp children]
    member inline _.div (value: string) = JSX.create "div" [childStrToProp value]
    /// The `<div>` tag defines a division or a section in an HTML document
    member inline _.div (props: JSX.Prop list) = JSX.create "div" props

    member inline _.dl (props: JSX.Prop list) = JSX.create "dl" props

    member inline _.dt (value: float) = JSX.create "dt" [childStrToProp(Util.asString value)]
    member inline _.dt (value: int) = JSX.create "dt" [childStrToProp(Util.asString value)]
    member inline _.dt (value: JSX.Element) = JSX.create "dt" [childToProp value]
    member inline _.dt (value: string) = JSX.create "dt" [childStrToProp value]
    member inline _.dt (props: JSX.Prop list) = JSX.create "dt" props

    member inline _.em (value: float) = JSX.create "em" [childStrToProp(Util.asString value)]
    member inline _.em (value: int) = JSX.create "em" [childStrToProp(Util.asString value)]
    member inline _.em (value: JSX.Element) = JSX.create "em" [childToProp value]
    member inline _.em (value: string) = JSX.create "em" [childStrToProp value]
    member inline _.em (props: JSX.Prop list) = JSX.create "em" props

    member inline _.fieldSet (props: JSX.Prop list) = JSX.create "fieldset" props

    member inline _.figcaption (props: JSX.Prop list) = JSX.create "figcaption" props

    member inline _.figure (props: JSX.Prop list) = JSX.create "figure" props

    member inline _.footer (props: JSX.Prop list) = JSX.create "footer" props

    member inline _.form (props: JSX.Prop list) = JSX.create "form" props

    member inline _.h1 (value: float) = JSX.create "h1" [childStrToProp(Util.asString value)]
    member inline _.h1 (value: int) = JSX.create "h1" [childStrToProp(Util.asString value)]
    member inline _.h1 (value: JSX.Element) = JSX.create "h1" [childToProp value]
    member inline _.h1 (value: string) = JSX.create "h1" [childStrToProp value]
    member inline _.h1 (props: JSX.Prop list) = JSX.create "h1" props
    member inline _.h2 (value: float) = JSX.create "h2" [childStrToProp(Util.asString value)]
    member inline _.h2 (value: int) = JSX.create "h2" [childStrToProp(Util.asString value)]
    member inline _.h2 (value: JSX.Element) = JSX.create "h2" [childToProp value]
    member inline _.h2 (value: string) = JSX.create "h2" [childStrToProp value]
    member inline _.h2 (props: JSX.Prop list) = JSX.create "h2" props

    member inline _.h3 (value: float) = JSX.create "h3" [childStrToProp(Util.asString value)]
    member inline _.h3 (value: int) = JSX.create "h3" [childStrToProp(Util.asString value)]
    member inline _.h3 (value: JSX.Element) = JSX.create "h3" [childToProp value]
    member inline _.h3 (value: string) = JSX.create "h3" [childStrToProp value]
    member inline _.h3 (props: JSX.Prop list) = JSX.create "h3" props

    member inline _.h4 (value: float) = JSX.create "h4" [childStrToProp(Util.asString value)]
    member inline _.h4 (value: int) = JSX.create "h4" [childStrToProp(Util.asString value)]
    member inline _.h4 (value: JSX.Element) = JSX.create "h4" [childToProp value]
    member inline _.h4 (value: string) = JSX.create "h4" [childStrToProp value]
    member inline _.h4 (props: JSX.Prop list) = JSX.create "h4" props

    member inline _.h5 (value: float) = JSX.create "h5" [childStrToProp(Util.asString value)]
    member inline _.h5 (value: int) = JSX.create "h5" [childStrToProp(Util.asString value)]
    member inline _.h5 (value: JSX.Element) = JSX.create "h5" [childToProp value]
    member inline _.h5 (value: string) = JSX.create "h5" [childStrToProp value]
    member inline _.h5 (props: JSX.Prop list) = JSX.create "h5" props

    member inline _.h6 (value: float) = JSX.create "h6" [childStrToProp(Util.asString value)]
    member inline _.h6 (value: int) = JSX.create "h6" [childStrToProp(Util.asString value)]
    member inline _.h6 (value: JSX.Element) = JSX.create "h6" [childToProp value]
    member inline _.h6 (value: string) = JSX.create "h6" [childStrToProp value]
    member inline _.h6 (props: JSX.Prop list) = JSX.create "h6" props

    member inline _.head (props: JSX.Prop list) = JSX.create "head" props

    member inline _.header (props: JSX.Prop list) = JSX.create "header" props

    member inline _.hr (props: JSX.Prop list) = JSX.create "hr" props

    member inline _.html (props: JSX.Prop list) = JSX.create "html" props

    member inline _.i (value: float) = JSX.create "i" [childStrToProp(Util.asString value)]
    member inline _.i (value: int) = JSX.create "i" [childStrToProp(Util.asString value)]
    member inline _.i (value: JSX.Element) = JSX.create "i" [childToProp value]
    member inline _.i (value: string) = JSX.create "i" [childStrToProp value]
    member inline _.i (props: JSX.Prop list) = JSX.create "i" props

    member inline _.iframe (props: JSX.Prop list) = JSX.create "iframe" props

    member inline _.img (props: JSX.Prop list) = JSX.create "img" props

    member inline _.input (props: JSX.Prop list) = JSX.create "input" props

    member inline _.ins (value: float) = JSX.create "ins" [childStrToProp(Util.asString value)]
    member inline _.ins (value: int) = JSX.create "ins" [childStrToProp(Util.asString value)]
    member inline _.ins (value: JSX.Element) = JSX.create "ins" [childToProp value]
    member inline _.ins (value: string) = JSX.create "ins" [childStrToProp value]
    member inline _.ins (props: JSX.Prop list) = JSX.create "ins" props

    member inline _.kbd (value: float) = JSX.create "kbd" [childStrToProp(Util.asString value)]
    member inline _.kbd (value: int) = JSX.create "kbd" [childStrToProp(Util.asString value)]
    member inline _.kbd (value: JSX.Element) = JSX.create "kbd" [childToProp value]
    member inline _.kbd (value: string) = JSX.create "kbd" [childStrToProp value]
    member inline _.kbd (props: JSX.Prop list) = JSX.create "kbd" props

    member inline _.label (value: string) = JSX.create "label" [childStrToProp value]
    member inline _.label (props: JSX.Prop list) = JSX.create "label" props

    member inline _.legend (value: float) = JSX.create "legend" [childStrToProp(Util.asString value)]
    member inline _.legend (value: int) = JSX.create "legend" [childStrToProp(Util.asString value)]
    member inline _.legend (value: JSX.Element) = JSX.create "legend" [childToProp value]
    member inline _.legend (value: string) = JSX.create "legend" [childStrToProp value]
    member inline _.legend (props: JSX.Prop list) = JSX.create "legend" props

    member inline _.li (value: float) = JSX.create "li" [childStrToProp(Util.asString value)]
    member inline _.li (value: int) = JSX.create "li" [childStrToProp(Util.asString value)]
    member inline _.li (value: JSX.Element) = JSX.create "li" [childToProp value]
    member inline _.li (value: string) = JSX.create "li" [childStrToProp value]
    member inline _.li (props: JSX.Prop list) = JSX.create "li" props

    member inline _.listItem (value: float) = JSX.create "li" [childStrToProp(Util.asString value)]
    member inline _.listItem (value: int) = JSX.create "li" [childStrToProp(Util.asString value)]
    member inline _.listItem (value: JSX.Element) = JSX.create "li" [childToProp value]
    member inline _.listItem (value: string) = JSX.create "li" [childStrToProp value]
    member inline _.listItem (props: JSX.Prop list) = JSX.create "li" props

    member inline _.main (props: JSX.Prop list) = JSX.create "main" props

    member inline _.map (props: JSX.Prop list) = JSX.create "map" props

    member inline _.mark (value: float) = JSX.create "mark" [childStrToProp(Util.asString value)]
    member inline _.mark (value: int) = JSX.create "mark" [childStrToProp(Util.asString value)]
    member inline _.mark (value: JSX.Element) = JSX.create "mark" [childToProp value]
    member inline _.mark (value: string) = JSX.create "mark" [childStrToProp value]
    member inline _.mark (props: JSX.Prop list) = JSX.create "mark" props

    member inline _.metadata (props: JSX.Prop list) = JSX.create "metadata" props

    member inline _.meter (value: float) = JSX.create "meter" [childStrToProp(Util.asString value)]
    member inline _.meter (value: int) = JSX.create "meter" [childStrToProp(Util.asString value)]
    member inline _.meter (value: JSX.Element) = JSX.create "meter" [childToProp value]
    member inline _.meter (value: string) = JSX.create "meter" [childStrToProp value]
    member inline _.meter (props: JSX.Prop list) = JSX.create "meter" props

    member inline _.nav (props: JSX.Prop list) = JSX.create "nav" props

    member inline _.noscript (props: JSX.Prop list) = JSX.create "noscript" props

    member inline _.object (props: JSX.Prop list) = JSX.create "object" props

    member inline _.ol (props: JSX.Prop list) = JSX.create "ol" props

    member inline _.option (value: float) = JSX.create "option" [childStrToProp(Util.asString value)]
    member inline _.option (value: int) = JSX.create "option" [childStrToProp(Util.asString value)]
    member inline _.option (value: JSX.Element) = JSX.create "option" [childToProp value]
    member inline _.option (value: string) = JSX.create "option" [childStrToProp value]
    member inline _.option (props: JSX.Prop list) = JSX.create "option" props

    member inline _.optgroup (props: JSX.Prop list) = JSX.create "optgroup" props

    member inline _.orderedList (props: JSX.Prop list) = JSX.create "ol" props

    member inline _.output (value: float) = JSX.create "output" [childStrToProp(Util.asString value)]
    member inline _.output (value: int) = JSX.create "output" [childStrToProp(Util.asString value)]
    member inline _.output (value: JSX.Element) = JSX.create "output" [childToProp value]
    member inline _.output (value: string) = JSX.create "output" [childStrToProp value]
    member inline _.output (props: JSX.Prop list) = JSX.create "output" props

    member inline _.p (value: float) = JSX.create "p" [childStrToProp(Util.asString value)]
    member inline _.p (value: int) = JSX.create "p" [childStrToProp(Util.asString value)]
    member inline _.p (value: JSX.Element) = JSX.create "p" [childToProp value]
    member inline _.p (value: string) = JSX.create "p" [childStrToProp value]
    member inline _.p (props: JSX.Prop list) = JSX.create "p" props

    member inline _.paragraph (value: float) = JSX.create "p" [childStrToProp(Util.asString value)]
    member inline _.paragraph (value: int) = JSX.create "p" [childStrToProp(Util.asString value)]
    member inline _.paragraph (value: JSX.Element) = JSX.create "p" [childToProp value]
    member inline _.paragraph (value: string) = JSX.create "p" [childStrToProp value]
    member inline _.paragraph (props: JSX.Prop list) = JSX.create "p" props

    member inline _.picture (props: JSX.Prop list) = JSX.create "picture" props

    // member inline _.pre (value: bool) = JSX.create "pre" value
    member inline _.pre (value: float) = JSX.create "pre" [childStrToProp(Util.asString value)]
    member inline _.pre (value: int) = JSX.create "pre" [childStrToProp(Util.asString value)]
    member inline _.pre (value: JSX.Element) = JSX.create "pre" [childToProp value]
    member inline _.pre (value: string) = JSX.create "pre" [childStrToProp value]
    member inline _.pre (props: JSX.Prop list) = JSX.create "pre" props

    member inline _.progress (props: JSX.Prop list) = JSX.create "progress" props

    member inline _.q (props: JSX.Prop list) = JSX.create "q" props

    member inline _.rb (value: float) = JSX.create "rb" [childStrToProp(Util.asString value)]
    member inline _.rb (value: int) = JSX.create "rb" [childStrToProp(Util.asString value)]
    member inline _.rb (value: JSX.Element) = JSX.create "rb" [childToProp value]
    member inline _.rb (value: string) = JSX.create "rb" [childStrToProp value]
    member inline _.rb (props: JSX.Prop list) = JSX.create "rb" props

    member inline _.rp (value: float) = JSX.create "rp" [childStrToProp(Util.asString value)]
    member inline _.rp (value: int) = JSX.create "rp" [childStrToProp(Util.asString value)]
    member inline _.rp (value: JSX.Element) = JSX.create "rp" [childToProp value]
    member inline _.rp (value: string) = JSX.create "rp" [childStrToProp value]
    member inline _.rp (props: JSX.Prop list) = JSX.create "rp" props

    member inline _.rt (value: float) = JSX.create "rt" [childStrToProp(Util.asString value)]
    member inline _.rt (value: int) = JSX.create "rt" [childStrToProp(Util.asString value)]
    member inline _.rt (value: JSX.Element) = JSX.create "rt" [childToProp value]
    member inline _.rt (value: string) = JSX.create "rt" [childStrToProp value]
    member inline _.rt (props: JSX.Prop list) = JSX.create "rt" props

    member inline _.rtc (value: float) = JSX.create "rtc" [childStrToProp(Util.asString value)]
    member inline _.rtc (value: int) = JSX.create "rtc" [childStrToProp(Util.asString value)]
    member inline _.rtc (value: JSX.Element) = JSX.create "rtc" [childToProp value]
    member inline _.rtc (value: string) = JSX.create "rtc" [childStrToProp value]
    member inline _.rtc (props: JSX.Prop list) = JSX.create "rtc" props

    member inline _.ruby (value: float) = JSX.create "ruby" [childStrToProp(Util.asString value)]
    member inline _.ruby (value: int) = JSX.create "ruby" [childStrToProp(Util.asString value)]
    member inline _.ruby (value: JSX.Element) = JSX.create "ruby" [childToProp value]
    member inline _.ruby (value: string) = JSX.create "ruby" [childStrToProp value]
    member inline _.ruby (props: JSX.Prop list) = JSX.create "ruby" props

    member inline _.s (value: float) = JSX.create "s" [childStrToProp(Util.asString value)]
    member inline _.s (value: int) = JSX.create "s" [childStrToProp(Util.asString value)]
    member inline _.s (value: JSX.Element) = JSX.create "s" [childToProp value]
    member inline _.s (value: string) = JSX.create "s" [childStrToProp value]
    member inline _.s (props: JSX.Prop list) = JSX.create "s" props

    member inline _.samp (value: float) = JSX.create "samp" [childStrToProp(Util.asString value)]
    member inline _.samp (value: int) = JSX.create "samp" [childStrToProp(Util.asString value)]
    member inline _.samp (value: JSX.Element) = JSX.create "samp" [childToProp value]
    member inline _.samp (value: string) = JSX.create "samp" [childStrToProp value]
    member inline _.samp (props: JSX.Prop list) = JSX.create "samp" props

    member inline _.script (props: JSX.Prop list) = JSX.create "script" props

    member inline _.section (props: JSX.Prop list) = JSX.create "section" props

    member inline _.select (props: JSX.Prop list) = JSX.create "select" props
    member inline _.small (value: float) = JSX.create "small" [childStrToProp(Util.asString value)]
    member inline _.small (value: int) = JSX.create "small" [childStrToProp(Util.asString value)]
    member inline _.small (value: JSX.Element) = JSX.create "small" [childToProp value]
    member inline _.small (value: string) = JSX.create "small" [childStrToProp value]
    member inline _.small (props: JSX.Prop list) = JSX.create "small" props

    member inline _.source (props: JSX.Prop list) = JSX.create "source" props

    member inline _.span (value: float) = JSX.create "span" [childStrToProp(Util.asString value)]
    member inline _.span (value: int) = JSX.create "span" [childStrToProp(Util.asString value)]
    member inline _.span (value: JSX.Element) = JSX.create "span" [childToProp value]
    member inline _.span (value: string) = JSX.create "span" [childStrToProp value]
    member inline _.span (props: JSX.Prop list) = JSX.create "span" props

    member inline _.strong (value: float) = JSX.create "strong" [childStrToProp(Util.asString value)]
    member inline _.strong (value: int) = JSX.create "strong" [childStrToProp(Util.asString value)]
    member inline _.strong (value: JSX.Element) = JSX.create "strong" [childToProp value]
    member inline _.strong (value: string) = JSX.create "strong" [childStrToProp value]
    member inline _.strong (props: JSX.Prop list) = JSX.create "strong" props

    member inline _.style (value: string) = JSX.create "style" [childStrToProp value]

    member inline _.sub (value: float) = JSX.create "sub" [childStrToProp(Util.asString value)]
    member inline _.sub (value: int) = JSX.create "sub" [childStrToProp(Util.asString value)]
    member inline _.sub (value: JSX.Element) = JSX.create "sub" [childToProp value]
    member inline _.sub (value: string) = JSX.create "sub" [childStrToProp value]
    member inline _.sub (props: JSX.Prop list) = JSX.create "sub" props

    member inline _.summary (value: float) = JSX.create "summary" [childStrToProp(Util.asString value)]
    member inline _.summary (value: int) = JSX.create "summary" [childStrToProp(Util.asString value)]
    member inline _.summary (value: JSX.Element) = JSX.create "summary" [childToProp value]
    member inline _.summary (value: string) = JSX.create "summary" [childStrToProp value]
    member inline _.summary (props: JSX.Prop list) = JSX.create "summary" props

    member inline _.sup (value: float) = JSX.create "sup" [childStrToProp(Util.asString value)]
    member inline _.sup (value: int) = JSX.create "sup" [childStrToProp(Util.asString value)]
    member inline _.sup (value: JSX.Element) = JSX.create "sup" [childToProp value]
    member inline _.sup (value: string) = JSX.create "sup" [childStrToProp value]
    member inline _.sup (props: JSX.Prop list) = JSX.create "sup" props

    member inline _.table (props: JSX.Prop list) = JSX.create "table" props

    member inline _.tableBody (props: JSX.Prop list) = JSX.create "tbody" props

    member inline _.tableCell (props: JSX.Prop list) = JSX.create "td" props

    member inline _.tableHeader (props: JSX.Prop list) = JSX.create "th" props

    member inline _.tableRow (props: JSX.Prop list) = JSX.create "tr" props

    member inline _.tbody (props: JSX.Prop list) = JSX.create "tbody" props

    member inline _.td (value: float) = JSX.create "td" [childStrToProp(Util.asString value)]
    member inline _.td (value: int) = JSX.create "td" [childStrToProp(Util.asString value)]
    member inline _.td (value: JSX.Element) = JSX.create "td" [childToProp value]
    member inline _.td (value: string) = JSX.create "td" [childStrToProp value]
    member inline _.td (props: JSX.Prop list) = JSX.create "td" props

    member inline _.template (props: JSX.Prop list) = JSX.create "template" props

    member inline _.text (value: float) : JSX.Element = unbox(Util.asString value)
    member inline _.text (value: int) : JSX.Element = unbox(Util.asString value)
    member inline _.text (value: string) : JSX.Element = unbox value
    member inline _.text (value: System.Guid) : JSX.Element = unbox(Util.asString value)

    member inline this.textf fmt = Printf.kprintf this.text fmt

    member inline _.textarea (props: JSX.Prop list) = JSX.create "textarea" props

    member inline _.tfoot (props: JSX.Prop list) = JSX.create "tfoot" props

    member inline _.th (value: float) = JSX.create "th" [childStrToProp(Util.asString value)]
    member inline _.th (value: int) = JSX.create "th" [childStrToProp(Util.asString value)]
    member inline _.th (value: JSX.Element) = JSX.create "th" [childToProp value]
    member inline _.th (value: string) = JSX.create "th" [childStrToProp value]
    member inline _.th (props: JSX.Prop list) = JSX.create "th" props

    member inline _.thead (props: JSX.Prop list) = JSX.create "thead" props

    member inline _.time (props: JSX.Prop list) = JSX.create "time" props

    member inline _.tr (props: JSX.Prop list) = JSX.create "tr" props

    member inline _.track (props: JSX.Prop list) = JSX.create "track" props

    member inline _.u (value: float) = JSX.create "u" [childStrToProp(Util.asString value)]
    member inline _.u (value: int) = JSX.create "u" [childStrToProp(Util.asString value)]
    member inline _.u (value: JSX.Element) = JSX.create "u" [childToProp value]
    member inline _.u (value: string) = JSX.create "u" [childStrToProp value]
    member inline _.u (props: JSX.Prop list) = JSX.create "u" props

    member inline _.ul (props: JSX.Prop list) = JSX.create "ul" props

    member inline _.unorderedList (props: JSX.Prop list) = JSX.create "ul" props

    member inline _.var (value: float) = JSX.create "var" [childStrToProp(Util.asString value)]
    member inline _.var (value: int) = JSX.create "var" [childStrToProp(Util.asString value)]
    member inline _.var (value: JSX.Element) = JSX.create "var" [childToProp value]
    member inline _.var (value: string) = JSX.create "var" [childStrToProp value]
    member inline _.var (props: JSX.Prop list) = JSX.create "var" props

    member inline _.video (props: JSX.Prop list) = JSX.create "video" props

    member inline _.wbr (props: JSX.Prop list) = JSX.create "wbr" props

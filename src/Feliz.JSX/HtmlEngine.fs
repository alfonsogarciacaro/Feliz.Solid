namespace Feliz.JSX

open Fable.Core

module HtmlUtil =
    let inline childrenToProp (children: JSX.Element list): JSX.Prop = "children", children
    let inline childToProp (child: JSX.Element): JSX.Prop = "children", [child]
    let inline childStrToProp (child: string): JSX.Prop = "children", [child]

open HtmlUtil

/// <summary>HTML generator API.</summary>
type Html =
    /// Create a custom element
    ///
    /// You generally shouldn't need to use this, if you notice an element missing please submit an issue.
    static member inline custom (key: string, props: JSX.Prop list) = JSX.create key props

    /// The empty element, renders nothing on screen
    static member inline none : JSX.Element = null

    /// Cast multiple elements into one
    static member inline fragment (children: JSX.Element list): JSX.Element = JSX.create "" ["children", children]

    /// To be used only with static list literals (no generators)
    static member inline children (children: JSX.Element list): JSX.Prop = "children", children

    /// To be used when passing children from props
    static member inline propsChildren (children: JSX.Element list): JSX.Element = unbox children

    static member inline a (props: JSX.Prop list) = JSX.create "a" props

    static member inline abbr (value: float) = JSX.create "abbr" [childStrToProp(Util.asString value)]
    static member inline abbr (value: int) = JSX.create "abbr" [childStrToProp(Util.asString value)]
    static member inline abbr (value: JSX.Element) = JSX.create "abbr" [childToProp value]
    static member inline abbr (value: string) = JSX.create "abbr" [childStrToProp value]
    static member inline abbr (props: JSX.Prop list) = JSX.create "abbr" props

    static member inline address (value: float) = JSX.create "address" [childStrToProp(Util.asString value)]
    static member inline address (value: int) = JSX.create "address" [childStrToProp(Util.asString value)]
    static member inline address (value: JSX.Element) = JSX.create "address" [childToProp value]
    static member inline address (value: string) = JSX.create "address" [childStrToProp value]
    static member inline address (props: JSX.Prop list) = JSX.create "address" props

    static member inline anchor (props: JSX.Prop list) = JSX.create "a" props

    static member inline area (props: JSX.Prop list) = JSX.create "area" props

    static member inline article (props: JSX.Prop list) = JSX.create "article" props

    static member inline aside (props: JSX.Prop list) = JSX.create "aside" props

    static member inline audio (props: JSX.Prop list) = JSX.create "audio" props

    static member inline b (value: float) = JSX.create "b" [childStrToProp(Util.asString value)]
    static member inline b (value: int) = JSX.create "b" [childStrToProp(Util.asString value)]
    static member inline b (value: JSX.Element) = JSX.create "b" [childToProp value]
    static member inline b (value: string) = JSX.create "b" [childStrToProp value]
    static member inline b (props: JSX.Prop list) = JSX.create "b" props

    static member inline base' (props: JSX.Prop list) = JSX.create "base" props

    static member inline bdi (value: float) = JSX.create "bdi" [childStrToProp(Util.asString value)]
    static member inline bdi (value: int) = JSX.create "bdi" [childStrToProp(Util.asString value)]
    static member inline bdi (value: JSX.Element) = JSX.create "bdi" [childToProp value]
    static member inline bdi (value: string) = JSX.create "bdi" [childStrToProp value]
    static member inline bdi (props: JSX.Prop list) = JSX.create "bdi" props

    static member inline bdo (value: float) = JSX.create "bdo" [childStrToProp(Util.asString value)]
    static member inline bdo (value: int) = JSX.create "bdo" [childStrToProp(Util.asString value)]
    static member inline bdo (value: JSX.Element) = JSX.create "bdo" [childToProp value]
    static member inline bdo (value: string) = JSX.create "bdo" [childStrToProp value]
    static member inline bdo (props: JSX.Prop list) = JSX.create "bdo" props

    static member inline blockquote (value: float) = JSX.create "blockquote" [childStrToProp(Util.asString value)]
    static member inline blockquote (value: int) = JSX.create "blockquote" [childStrToProp(Util.asString value)]
    static member inline blockquote (value: JSX.Element) = JSX.create "blockquote" [childToProp value]
    static member inline blockquote (value: string) = JSX.create "blockquote" [childStrToProp value]
    static member inline blockquote (props: JSX.Prop list) = JSX.create "blockquote" props

    static member inline body (value: float) = JSX.create "body" [childStrToProp(Util.asString value)]
    static member inline body (value: int) = JSX.create "body" [childStrToProp(Util.asString value)]
    static member inline body (value: JSX.Element) = JSX.create "body" [childToProp value]
    static member inline body (value: string) = JSX.create "body" [childStrToProp value]
    static member inline body (props: JSX.Prop list) = JSX.create "body" props

    static member inline br (props: JSX.Prop list) = JSX.create "br" props

    static member inline button (props: JSX.Prop list) = JSX.create "button" props

    static member inline canvas (props: JSX.Prop list) = JSX.create "canvas" props

    static member inline caption (value: float) = JSX.create "caption" [childStrToProp(Util.asString value)]
    static member inline caption (value: int) = JSX.create "caption" [childStrToProp(Util.asString value)]
    static member inline caption (value: JSX.Element) = JSX.create "caption" [childToProp value]
    static member inline caption (value: string) = JSX.create "caption" [childStrToProp value]
    static member inline caption (props: JSX.Prop list) = JSX.create "caption" props

    static member inline cite (value: float) = JSX.create "cite" [childStrToProp(Util.asString value)]
    static member inline cite (value: int) = JSX.create "cite" [childStrToProp(Util.asString value)]
    static member inline cite (value: JSX.Element) = JSX.create "cite" [childToProp value]
    static member inline cite (value: string) = JSX.create "cite" [childStrToProp value]
    static member inline cite (props: JSX.Prop list) = JSX.create "cite" props

    // static member inline code (value: bool) = JSX.create "code" value
    static member inline code (value: float) = JSX.create "code" [childStrToProp(Util.asString value)]
    static member inline code (value: int) = JSX.create "code" [childStrToProp(Util.asString value)]
    static member inline code (value: JSX.Element) = JSX.create "code" [childToProp value]
    static member inline code (value: string) = JSX.create "code" [childStrToProp value]
    static member inline code (props: JSX.Prop list) = JSX.create "code" props

    static member inline col (props: JSX.Prop list) = JSX.create "col" props

    static member inline colgroup (props: JSX.Prop list) = JSX.create "colgroup" props

    static member inline data (value: float) = JSX.create "data" [childStrToProp(Util.asString value)]
    static member inline data (value: int) = JSX.create "data" [childStrToProp(Util.asString value)]
    static member inline data (value: JSX.Element) = JSX.create "data" [childToProp value]
    static member inline data (value: string) = JSX.create "data" [childStrToProp value]
    static member inline data (props: JSX.Prop list) = JSX.create "data" props

    static member inline datalist (value: float) = JSX.create "datalist" [childStrToProp(Util.asString value)]
    static member inline datalist (value: int) = JSX.create "datalist" [childStrToProp(Util.asString value)]
    static member inline datalist (value: JSX.Element) = JSX.create "datalist" [childToProp value]
    static member inline datalist (value: string) = JSX.create "datalist" [childStrToProp value]
    static member inline datalist (props: JSX.Prop list) = JSX.create "datalist" props

    static member inline dd (value: float) = JSX.create "dd" [childStrToProp(Util.asString value)]
    static member inline dd (value: int) = JSX.create "dd" [childStrToProp(Util.asString value)]
    static member inline dd (value: JSX.Element) = JSX.create "dd" [childToProp value]
    static member inline dd (value: string) = JSX.create "dd" [childStrToProp value]
    static member inline dd (props: JSX.Prop list) = JSX.create "dd" props

    static member inline del (value: float) = JSX.create "del" [childStrToProp(Util.asString value)]
    static member inline del (value: int) = JSX.create "del" [childStrToProp(Util.asString value)]
    static member inline del (value: JSX.Element) = JSX.create "del" [childToProp value]
    static member inline del (value: string) = JSX.create "del" [childStrToProp value]
    static member inline del (props: JSX.Prop list) = JSX.create "del" props

    static member inline details (props: JSX.Prop list) = JSX.create "details" props

    static member inline dfn (value: float) = JSX.create "dfn" [childStrToProp(Util.asString value)]
    static member inline dfn (value: int) = JSX.create "dfn" [childStrToProp(Util.asString value)]
    static member inline dfn (value: JSX.Element) = JSX.create "dfn" [childToProp value]
    static member inline dfn (value: string) = JSX.create "dfn" [childStrToProp value]
    static member inline dfn (props: JSX.Prop list) = JSX.create "dfn" props

    static member inline dialog (value: float) = JSX.create "dialog" [childStrToProp(Util.asString value)]
    static member inline dialog (value: int) = JSX.create "dialog" [childStrToProp(Util.asString value)]
    static member inline dialog (value: JSX.Element) = JSX.create "dialog" [childToProp value]
    static member inline dialog (value: string) = JSX.create "dialog" [childStrToProp value]
    static member inline dialog (props: JSX.Prop list) = JSX.create "dialog" props

    static member inline div (value: float) = JSX.create "div" [childStrToProp(Util.asString value)]
    static member inline div (value: int) = JSX.create "div" [childStrToProp(Util.asString value)]
    // static member inline div (value: JSX.Element) = JSX.create "div" [childToProp value]
    static member inline div (children: JSX.Element list) = JSX.create "div" [childrenToProp children]
    static member inline div (value: string) = JSX.create "div" [childStrToProp value]
    /// The `<div>` tag defines a division or a section in an HTML document
    static member inline div (props: JSX.Prop list) = JSX.create "div" props

    static member inline dl (props: JSX.Prop list) = JSX.create "dl" props

    static member inline dt (value: float) = JSX.create "dt" [childStrToProp(Util.asString value)]
    static member inline dt (value: int) = JSX.create "dt" [childStrToProp(Util.asString value)]
    static member inline dt (value: JSX.Element) = JSX.create "dt" [childToProp value]
    static member inline dt (value: string) = JSX.create "dt" [childStrToProp value]
    static member inline dt (props: JSX.Prop list) = JSX.create "dt" props

    static member inline em (value: float) = JSX.create "em" [childStrToProp(Util.asString value)]
    static member inline em (value: int) = JSX.create "em" [childStrToProp(Util.asString value)]
    static member inline em (value: JSX.Element) = JSX.create "em" [childToProp value]
    static member inline em (value: string) = JSX.create "em" [childStrToProp value]
    static member inline em (props: JSX.Prop list) = JSX.create "em" props

    static member inline fieldSet (props: JSX.Prop list) = JSX.create "fieldset" props

    static member inline figcaption (props: JSX.Prop list) = JSX.create "figcaption" props

    static member inline figure (props: JSX.Prop list) = JSX.create "figure" props

    static member inline footer (props: JSX.Prop list) = JSX.create "footer" props

    static member inline form (props: JSX.Prop list) = JSX.create "form" props

    static member inline h1 (value: float) = JSX.create "h1" [childStrToProp(Util.asString value)]
    static member inline h1 (value: int) = JSX.create "h1" [childStrToProp(Util.asString value)]
    static member inline h1 (value: JSX.Element) = JSX.create "h1" [childToProp value]
    static member inline h1 (value: string) = JSX.create "h1" [childStrToProp value]
    static member inline h1 (props: JSX.Prop list) = JSX.create "h1" props
    static member inline h2 (value: float) = JSX.create "h2" [childStrToProp(Util.asString value)]
    static member inline h2 (value: int) = JSX.create "h2" [childStrToProp(Util.asString value)]
    static member inline h2 (value: JSX.Element) = JSX.create "h2" [childToProp value]
    static member inline h2 (value: string) = JSX.create "h2" [childStrToProp value]
    static member inline h2 (props: JSX.Prop list) = JSX.create "h2" props

    static member inline h3 (value: float) = JSX.create "h3" [childStrToProp(Util.asString value)]
    static member inline h3 (value: int) = JSX.create "h3" [childStrToProp(Util.asString value)]
    static member inline h3 (value: JSX.Element) = JSX.create "h3" [childToProp value]
    static member inline h3 (value: string) = JSX.create "h3" [childStrToProp value]
    static member inline h3 (props: JSX.Prop list) = JSX.create "h3" props

    static member inline h4 (value: float) = JSX.create "h4" [childStrToProp(Util.asString value)]
    static member inline h4 (value: int) = JSX.create "h4" [childStrToProp(Util.asString value)]
    static member inline h4 (value: JSX.Element) = JSX.create "h4" [childToProp value]
    static member inline h4 (value: string) = JSX.create "h4" [childStrToProp value]
    static member inline h4 (props: JSX.Prop list) = JSX.create "h4" props

    static member inline h5 (value: float) = JSX.create "h5" [childStrToProp(Util.asString value)]
    static member inline h5 (value: int) = JSX.create "h5" [childStrToProp(Util.asString value)]
    static member inline h5 (value: JSX.Element) = JSX.create "h5" [childToProp value]
    static member inline h5 (value: string) = JSX.create "h5" [childStrToProp value]
    static member inline h5 (props: JSX.Prop list) = JSX.create "h5" props

    static member inline h6 (value: float) = JSX.create "h6" [childStrToProp(Util.asString value)]
    static member inline h6 (value: int) = JSX.create "h6" [childStrToProp(Util.asString value)]
    static member inline h6 (value: JSX.Element) = JSX.create "h6" [childToProp value]
    static member inline h6 (value: string) = JSX.create "h6" [childStrToProp value]
    static member inline h6 (props: JSX.Prop list) = JSX.create "h6" props

    static member inline head (props: JSX.Prop list) = JSX.create "head" props

    static member inline header (props: JSX.Prop list) = JSX.create "header" props

    static member inline hr (props: JSX.Prop list) = JSX.create "hr" props

    static member inline html (props: JSX.Prop list) = JSX.create "html" props

    static member inline i (value: float) = JSX.create "i" [childStrToProp(Util.asString value)]
    static member inline i (value: int) = JSX.create "i" [childStrToProp(Util.asString value)]
    static member inline i (value: JSX.Element) = JSX.create "i" [childToProp value]
    static member inline i (value: string) = JSX.create "i" [childStrToProp value]
    static member inline i (props: JSX.Prop list) = JSX.create "i" props

    static member inline iframe (props: JSX.Prop list) = JSX.create "iframe" props

    static member inline img (props: JSX.Prop list) = JSX.create "img" props

    static member inline input (props: JSX.Prop list) = JSX.create "input" props

    static member inline ins (value: float) = JSX.create "ins" [childStrToProp(Util.asString value)]
    static member inline ins (value: int) = JSX.create "ins" [childStrToProp(Util.asString value)]
    static member inline ins (value: JSX.Element) = JSX.create "ins" [childToProp value]
    static member inline ins (value: string) = JSX.create "ins" [childStrToProp value]
    static member inline ins (props: JSX.Prop list) = JSX.create "ins" props

    static member inline kbd (value: float) = JSX.create "kbd" [childStrToProp(Util.asString value)]
    static member inline kbd (value: int) = JSX.create "kbd" [childStrToProp(Util.asString value)]
    static member inline kbd (value: JSX.Element) = JSX.create "kbd" [childToProp value]
    static member inline kbd (value: string) = JSX.create "kbd" [childStrToProp value]
    static member inline kbd (props: JSX.Prop list) = JSX.create "kbd" props

    static member inline label (value: string) = JSX.create "label" [childStrToProp value]
    static member inline label (children: JSX.Element list) = JSX.create "kbd" [childrenToProp children]
    static member inline label (props: JSX.Prop list) = JSX.create "label" props

    static member inline legend (value: float) = JSX.create "legend" [childStrToProp(Util.asString value)]
    static member inline legend (value: int) = JSX.create "legend" [childStrToProp(Util.asString value)]
    static member inline legend (value: JSX.Element) = JSX.create "legend" [childToProp value]
    static member inline legend (value: string) = JSX.create "legend" [childStrToProp value]
    static member inline legend (props: JSX.Prop list) = JSX.create "legend" props

    static member inline li (value: float) = JSX.create "li" [childStrToProp(Util.asString value)]
    static member inline li (value: int) = JSX.create "li" [childStrToProp(Util.asString value)]
    static member inline li (value: JSX.Element) = JSX.create "li" [childToProp value]
    static member inline li (value: string) = JSX.create "li" [childStrToProp value]
    static member inline li (props: JSX.Prop list) = JSX.create "li" props

    static member inline listItem (value: float) = JSX.create "li" [childStrToProp(Util.asString value)]
    static member inline listItem (value: int) = JSX.create "li" [childStrToProp(Util.asString value)]
    static member inline listItem (value: JSX.Element) = JSX.create "li" [childToProp value]
    static member inline listItem (value: string) = JSX.create "li" [childStrToProp value]
    static member inline listItem (props: JSX.Prop list) = JSX.create "li" props

    static member inline main (props: JSX.Prop list) = JSX.create "main" props

    static member inline map (props: JSX.Prop list) = JSX.create "map" props

    static member inline mark (value: float) = JSX.create "mark" [childStrToProp(Util.asString value)]
    static member inline mark (value: int) = JSX.create "mark" [childStrToProp(Util.asString value)]
    static member inline mark (value: JSX.Element) = JSX.create "mark" [childToProp value]
    static member inline mark (value: string) = JSX.create "mark" [childStrToProp value]
    static member inline mark (props: JSX.Prop list) = JSX.create "mark" props

    static member inline metadata (props: JSX.Prop list) = JSX.create "metadata" props

    static member inline meter (value: float) = JSX.create "meter" [childStrToProp(Util.asString value)]
    static member inline meter (value: int) = JSX.create "meter" [childStrToProp(Util.asString value)]
    static member inline meter (value: JSX.Element) = JSX.create "meter" [childToProp value]
    static member inline meter (value: string) = JSX.create "meter" [childStrToProp value]
    static member inline meter (props: JSX.Prop list) = JSX.create "meter" props

    static member inline nav (props: JSX.Prop list) = JSX.create "nav" props

    static member inline noscript (props: JSX.Prop list) = JSX.create "noscript" props

    static member inline object (props: JSX.Prop list) = JSX.create "object" props

    static member inline ol (props: JSX.Prop list) = JSX.create "ol" props

    static member inline option (value: float) = JSX.create "option" [childStrToProp(Util.asString value)]
    static member inline option (value: int) = JSX.create "option" [childStrToProp(Util.asString value)]
    static member inline option (value: JSX.Element) = JSX.create "option" [childToProp value]
    static member inline option (value: string) = JSX.create "option" [childStrToProp value]
    static member inline option (props: JSX.Prop list) = JSX.create "option" props

    static member inline optgroup (props: JSX.Prop list) = JSX.create "optgroup" props

    static member inline orderedList (props: JSX.Prop list) = JSX.create "ol" props

    static member inline output (value: float) = JSX.create "output" [childStrToProp(Util.asString value)]
    static member inline output (value: int) = JSX.create "output" [childStrToProp(Util.asString value)]
    static member inline output (value: JSX.Element) = JSX.create "output" [childToProp value]
    static member inline output (value: string) = JSX.create "output" [childStrToProp value]
    static member inline output (props: JSX.Prop list) = JSX.create "output" props

    static member inline p (value: float) = JSX.create "p" [childStrToProp(Util.asString value)]
    static member inline p (value: int) = JSX.create "p" [childStrToProp(Util.asString value)]
    static member inline p (value: JSX.Element) = JSX.create "p" [childToProp value]
    static member inline p (value: string) = JSX.create "p" [childStrToProp value]
    static member inline p (props: JSX.Prop list) = JSX.create "p" props

    static member inline paragraph (value: float) = JSX.create "p" [childStrToProp(Util.asString value)]
    static member inline paragraph (value: int) = JSX.create "p" [childStrToProp(Util.asString value)]
    static member inline paragraph (value: JSX.Element) = JSX.create "p" [childToProp value]
    static member inline paragraph (value: string) = JSX.create "p" [childStrToProp value]
    static member inline paragraph (props: JSX.Prop list) = JSX.create "p" props

    static member inline picture (props: JSX.Prop list) = JSX.create "picture" props

    // static member inline pre (value: bool) = JSX.create "pre" value
    static member inline pre (value: float) = JSX.create "pre" [childStrToProp(Util.asString value)]
    static member inline pre (value: int) = JSX.create "pre" [childStrToProp(Util.asString value)]
    static member inline pre (value: JSX.Element) = JSX.create "pre" [childToProp value]
    static member inline pre (value: string) = JSX.create "pre" [childStrToProp value]
    static member inline pre (props: JSX.Prop list) = JSX.create "pre" props

    static member inline progress (props: JSX.Prop list) = JSX.create "progress" props

    static member inline q (props: JSX.Prop list) = JSX.create "q" props

    static member inline rb (value: float) = JSX.create "rb" [childStrToProp(Util.asString value)]
    static member inline rb (value: int) = JSX.create "rb" [childStrToProp(Util.asString value)]
    static member inline rb (value: JSX.Element) = JSX.create "rb" [childToProp value]
    static member inline rb (value: string) = JSX.create "rb" [childStrToProp value]
    static member inline rb (props: JSX.Prop list) = JSX.create "rb" props

    static member inline rp (value: float) = JSX.create "rp" [childStrToProp(Util.asString value)]
    static member inline rp (value: int) = JSX.create "rp" [childStrToProp(Util.asString value)]
    static member inline rp (value: JSX.Element) = JSX.create "rp" [childToProp value]
    static member inline rp (value: string) = JSX.create "rp" [childStrToProp value]
    static member inline rp (props: JSX.Prop list) = JSX.create "rp" props

    static member inline rt (value: float) = JSX.create "rt" [childStrToProp(Util.asString value)]
    static member inline rt (value: int) = JSX.create "rt" [childStrToProp(Util.asString value)]
    static member inline rt (value: JSX.Element) = JSX.create "rt" [childToProp value]
    static member inline rt (value: string) = JSX.create "rt" [childStrToProp value]
    static member inline rt (props: JSX.Prop list) = JSX.create "rt" props

    static member inline rtc (value: float) = JSX.create "rtc" [childStrToProp(Util.asString value)]
    static member inline rtc (value: int) = JSX.create "rtc" [childStrToProp(Util.asString value)]
    static member inline rtc (value: JSX.Element) = JSX.create "rtc" [childToProp value]
    static member inline rtc (value: string) = JSX.create "rtc" [childStrToProp value]
    static member inline rtc (props: JSX.Prop list) = JSX.create "rtc" props

    static member inline ruby (value: float) = JSX.create "ruby" [childStrToProp(Util.asString value)]
    static member inline ruby (value: int) = JSX.create "ruby" [childStrToProp(Util.asString value)]
    static member inline ruby (value: JSX.Element) = JSX.create "ruby" [childToProp value]
    static member inline ruby (value: string) = JSX.create "ruby" [childStrToProp value]
    static member inline ruby (props: JSX.Prop list) = JSX.create "ruby" props

    static member inline s (value: float) = JSX.create "s" [childStrToProp(Util.asString value)]
    static member inline s (value: int) = JSX.create "s" [childStrToProp(Util.asString value)]
    static member inline s (value: JSX.Element) = JSX.create "s" [childToProp value]
    static member inline s (value: string) = JSX.create "s" [childStrToProp value]
    static member inline s (props: JSX.Prop list) = JSX.create "s" props

    static member inline samp (value: float) = JSX.create "samp" [childStrToProp(Util.asString value)]
    static member inline samp (value: int) = JSX.create "samp" [childStrToProp(Util.asString value)]
    static member inline samp (value: JSX.Element) = JSX.create "samp" [childToProp value]
    static member inline samp (value: string) = JSX.create "samp" [childStrToProp value]
    static member inline samp (props: JSX.Prop list) = JSX.create "samp" props

    static member inline script (props: JSX.Prop list) = JSX.create "script" props

    static member inline section (props: JSX.Prop list) = JSX.create "section" props

    static member inline select (props: JSX.Prop list) = JSX.create "select" props
    static member inline small (value: float) = JSX.create "small" [childStrToProp(Util.asString value)]
    static member inline small (value: int) = JSX.create "small" [childStrToProp(Util.asString value)]
    static member inline small (value: JSX.Element) = JSX.create "small" [childToProp value]
    static member inline small (value: string) = JSX.create "small" [childStrToProp value]
    static member inline small (props: JSX.Prop list) = JSX.create "small" props

    static member inline source (props: JSX.Prop list) = JSX.create "source" props

    static member inline span (value: float) = JSX.create "span" [childStrToProp(Util.asString value)]
    static member inline span (value: int) = JSX.create "span" [childStrToProp(Util.asString value)]
    static member inline span (value: JSX.Element) = JSX.create "span" [childToProp value]
    static member inline span (value: string) = JSX.create "span" [childStrToProp value]
    static member inline span (props: JSX.Prop list) = JSX.create "span" props

    static member inline strong (value: float) = JSX.create "strong" [childStrToProp(Util.asString value)]
    static member inline strong (value: int) = JSX.create "strong" [childStrToProp(Util.asString value)]
    static member inline strong (value: JSX.Element) = JSX.create "strong" [childToProp value]
    static member inline strong (value: string) = JSX.create "strong" [childStrToProp value]
    static member inline strong (props: JSX.Prop list) = JSX.create "strong" props

    static member inline style (value: string) = JSX.create "style" [childStrToProp value]

    static member inline sub (value: float) = JSX.create "sub" [childStrToProp(Util.asString value)]
    static member inline sub (value: int) = JSX.create "sub" [childStrToProp(Util.asString value)]
    static member inline sub (value: JSX.Element) = JSX.create "sub" [childToProp value]
    static member inline sub (value: string) = JSX.create "sub" [childStrToProp value]
    static member inline sub (props: JSX.Prop list) = JSX.create "sub" props

    static member inline summary (value: float) = JSX.create "summary" [childStrToProp(Util.asString value)]
    static member inline summary (value: int) = JSX.create "summary" [childStrToProp(Util.asString value)]
    static member inline summary (value: JSX.Element) = JSX.create "summary" [childToProp value]
    static member inline summary (value: string) = JSX.create "summary" [childStrToProp value]
    static member inline summary (props: JSX.Prop list) = JSX.create "summary" props

    static member inline sup (value: float) = JSX.create "sup" [childStrToProp(Util.asString value)]
    static member inline sup (value: int) = JSX.create "sup" [childStrToProp(Util.asString value)]
    static member inline sup (value: JSX.Element) = JSX.create "sup" [childToProp value]
    static member inline sup (value: string) = JSX.create "sup" [childStrToProp value]
    static member inline sup (props: JSX.Prop list) = JSX.create "sup" props

    static member inline table (props: JSX.Prop list) = JSX.create "table" props

    static member inline tableBody (props: JSX.Prop list) = JSX.create "tbody" props

    static member inline tableCell (props: JSX.Prop list) = JSX.create "td" props

    static member inline tableHeader (props: JSX.Prop list) = JSX.create "th" props

    static member inline tableRow (props: JSX.Prop list) = JSX.create "tr" props

    static member inline tbody (props: JSX.Prop list) = JSX.create "tbody" props

    static member inline td (value: float) = JSX.create "td" [childStrToProp(Util.asString value)]
    static member inline td (value: int) = JSX.create "td" [childStrToProp(Util.asString value)]
    static member inline td (value: JSX.Element) = JSX.create "td" [childToProp value]
    static member inline td (value: string) = JSX.create "td" [childStrToProp value]
    static member inline td (props: JSX.Prop list) = JSX.create "td" props

    static member inline template (props: JSX.Prop list) = JSX.create "template" props

    static member inline text (value: float) : JSX.Element = unbox(Util.asString value)
    static member inline text (value: int) : JSX.Element = unbox(Util.asString value)
    static member inline text (value: string) : JSX.Element = unbox value
    static member inline text (value: System.Guid) : JSX.Element = unbox(Util.asString value)

    static member inline textf fmt = Printf.kprintf Html.text fmt

    static member inline textarea (props: JSX.Prop list) = JSX.create "textarea" props

    static member inline tfoot (props: JSX.Prop list) = JSX.create "tfoot" props

    static member inline th (value: float) = JSX.create "th" [childStrToProp(Util.asString value)]
    static member inline th (value: int) = JSX.create "th" [childStrToProp(Util.asString value)]
    static member inline th (value: JSX.Element) = JSX.create "th" [childToProp value]
    static member inline th (value: string) = JSX.create "th" [childStrToProp value]
    static member inline th (props: JSX.Prop list) = JSX.create "th" props

    static member inline thead (props: JSX.Prop list) = JSX.create "thead" props

    static member inline time (props: JSX.Prop list) = JSX.create "time" props

    static member inline tr (props: JSX.Prop list) = JSX.create "tr" props

    static member inline track (props: JSX.Prop list) = JSX.create "track" props

    static member inline u (value: float) = JSX.create "u" [childStrToProp(Util.asString value)]
    static member inline u (value: int) = JSX.create "u" [childStrToProp(Util.asString value)]
    static member inline u (value: JSX.Element) = JSX.create "u" [childToProp value]
    static member inline u (value: string) = JSX.create "u" [childStrToProp value]
    static member inline u (props: JSX.Prop list) = JSX.create "u" props

    static member inline ul (children: JSX.Element list) = JSX.create "ul" [childrenToProp children]
    static member inline ul (props: JSX.Prop list) = JSX.create "ul" props

    static member inline unorderedList (props: JSX.Prop list) = JSX.create "ul" props

    static member inline var (value: float) = JSX.create "var" [childStrToProp(Util.asString value)]
    static member inline var (value: int) = JSX.create "var" [childStrToProp(Util.asString value)]
    static member inline var (value: JSX.Element) = JSX.create "var" [childToProp value]
    static member inline var (value: string) = JSX.create "var" [childStrToProp value]
    static member inline var (props: JSX.Prop list) = JSX.create "var" props

    static member inline video (props: JSX.Prop list) = JSX.create "video" props

    static member inline wbr (props: JSX.Prop list) = JSX.create "wbr" props

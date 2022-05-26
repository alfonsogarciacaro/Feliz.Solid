namespace Feliz.JSX

open Fable.Core

/// <summary>SVG generator API.</summary>
type Svg =
    /// Create a custom element
    ///
    /// You generally shouldn't need to use this, if you notice an element missing please submit an issue.
    static member inline custom (key: string) (props: JSX.Prop list) = JSX.create key props

    /// The empty element, renders nothing on screen
    static member inline none : JSX.Element = null

    /// Cast multiple elements into one
    static member inline fragment (children: JSX.Element list): JSX.Element = JSX.create "" ["children", children]

    /// To be used only with static list literals (no generators)
    static member inline children (children: JSX.Element list): JSX.Prop = "children", children

    /// SVG Image element, not to be confused with HTML img alias.
    static member inline image (props: JSX.Prop list) = JSX.create "image" props
    /// The svg element is a container that defines a new coordinate system and viewport. It is used as the outermost element of SVG documents, but it can also be used to embed an SVG fragment inside an SVG or HTML document.
    static member inline svg (props: JSX.Prop list) = JSX.create "svg" props
    static member inline circle (props: JSX.Prop list) = JSX.create "circle" props
    static member inline clipPath (props: JSX.Prop list) = JSX.create "clipPath" props
    /// The <defs> element is used to store graphical objects that will be used at a later time. Objects created inside a <defs> element are not rendered directly. To display them you have to reference them (with a <use> element for example). https://developer.mozilla.org/en-US/docs/Web/SVG/Element/defs
    static member inline defs (children: JSX.Element list) = JSX.create "defs" [HtmlUtil.childrenToProp children]
    /// The <desc> element provides an accessible, long-text description of any SVG container element or graphics element.
    static member inline desc (value: string) = JSX.create "desc" [HtmlUtil.childStrToProp value]
    static member inline ellipse (props: JSX.Prop list) = JSX.create "ellipse" props
    static member inline feBlend (props: JSX.Prop list) = JSX.create "feBlend" props
    static member inline feColorMatrix (props: JSX.Prop list) = JSX.create "feColorMatrix" props
    static member inline feComponentTransfer (props: JSX.Prop list) = JSX.create "feComponentTransfer" props
    static member inline feComposite (props: JSX.Prop list) = JSX.create "feComposite" props
    static member inline feConvolveMatrix (props: JSX.Prop list) = JSX.create "feConvolveMatrix" props
    static member inline feDiffuseLighting (props: JSX.Prop list) = JSX.create "feDiffuseLighting" props
    static member inline feDisplacementMap (props: JSX.Prop list) = JSX.create "feDisplacementMap" props
    static member inline feDistantLight (props: JSX.Prop list) = JSX.create "feDistantLight" props
    static member inline feDropShadow (props: JSX.Prop list) = JSX.create "feDropShadow" props
    static member inline feFlood (props: JSX.Prop list) = JSX.create "feFlood" props
    static member inline feFuncA (props: JSX.Prop list) = JSX.create "feFuncA" props
    static member inline feFuncB (props: JSX.Prop list) = JSX.create "feFuncB" props
    static member inline feFuncG (props: JSX.Prop list) = JSX.create "feFuncG" props
    static member inline feFuncR (props: JSX.Prop list) = JSX.create "feFuncR" props
    static member inline feGaussianBlur (props: JSX.Prop list) = JSX.create "feGaussianBlur" props
    static member inline feImage (props: JSX.Prop list) = JSX.create "feImage" props
    static member inline feMerge (props: JSX.Prop list) = JSX.create "feMerge" props
    static member inline feMergeNode (props: JSX.Prop list) = JSX.create "feMergeNode" props
    static member inline feMorphology (props: JSX.Prop list) = JSX.create "feMorphology" props
    static member inline feOffset (props: JSX.Prop list) = JSX.create "feOffset" props
    static member inline fePointLight (props: JSX.Prop list) = JSX.create "fePointLight" props
    static member inline feSpecularLighting (props: JSX.Prop list) = JSX.create "feSpecularLighting" props
    static member inline feSpotLight (props: JSX.Prop list) = JSX.create "feSpotLight" props
    static member inline feTile (props: JSX.Prop list) = JSX.create "feTile" props
    static member inline feTurbulence (props: JSX.Prop list) = JSX.create "feTurbulence" props
    static member inline filter (props: JSX.Prop list) = JSX.create "filter" props
    static member inline foreignObject (props: JSX.Prop list) = JSX.create "foreignObject" props
    /// The <g> SVG element is a container used to group other SVG elements.
    ///
    /// Transformations applied to the <g> element are performed on its child elements, and its attributes are inherited by its children. It can also group multiple elements to be referenced later with the <use> element.
    static member inline g (props: JSX.Prop list) = JSX.create "g" props
    static member inline line (props: JSX.Prop list) = JSX.create "line" props
    static member inline linearGradient (props: JSX.Prop list) = JSX.create "linearGradient" props
    /// The <marker> element defines the graphic that is to be used for drawing arrowheads or polymarkers on a given <path>, <line>, <polyline> or <polygon> element.
    static member inline marker (props: JSX.Prop list) = JSX.create "marker" props
    static member inline mask (props: JSX.Prop list) = JSX.create "marker" props
    static member inline mpath (props: JSX.Prop list) = JSX.create "mpath" props
    static member inline path (props: JSX.Prop list) = JSX.create "path" props
    static member inline pattern (props: JSX.Prop list) = JSX.create "pattern" props
    static member inline polygon (props: JSX.Prop list) = JSX.create "polygon" props
    static member inline polyline (props: JSX.Prop list) = JSX.create "polyline" props
    static member inline set (props: JSX.Prop list) = JSX.create "set" props
    static member inline stop (props: JSX.Prop list) = JSX.create "stop" props
    static member inline style (value: string) = JSX.create "style" [HtmlUtil.childStrToProp value]
    static member inline switch (props: JSX.Prop list) = JSX.create "switch" props
    static member inline symbol (props: JSX.Prop list) = JSX.create "symbol" props
    static member inline text (content: string) = JSX.create "text" [HtmlUtil.childStrToProp content]
    static member inline title (content: string) = JSX.create "title" [HtmlUtil.childStrToProp content]
    static member inline textPath (props: JSX.Prop list) = JSX.create "textPath" props
    static member inline tspan (props: JSX.Prop list) = JSX.create "tspan" props
    static member inline use' (props: JSX.Prop list) = JSX.create "use" props
    static member inline radialGradient (props: JSX.Prop list) = JSX.create "radialGradient" props
    static member inline rect (props: JSX.Prop list) = JSX.create "rect" props
    static member inline view (props: JSX.Prop list) = JSX.create "view" props

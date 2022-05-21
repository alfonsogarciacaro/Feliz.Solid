namespace Feliz.JSX

open System

/// <summary>SVG generator API.</summary>
type SvgEngine =

    /// Create a custom element
    ///
    /// You generally shouldn't need to use this, if you notice an element missing please submit an issue.
    static member inline custom (key: string, children: seq<'Node>) = mk key children
    /// The empty element, renders nothing on screen
    static member inline none : 'Node = empty()

    /// SVG Image element, not to be confused with HTML img alias.
    static member inline image (children: seq<'Node>) = mk "image" children
    /// The svg element is a container that defines a new coordinate system and viewport. It is used as the outermost element of SVG documents, but it can also be used to embed an SVG fragment inside an SVG or HTML document.
    static member inline svg (children: seq<'Node>) = mk "svg" children
    static member inline circle (children: seq<'Node>) = mk "circle" children
    static member inline clipPath (children: seq<'Node>) = mk "clipPath" children
    /// The <defs> element is used to store graphical objects that will be used at a later time. Objects created inside a <defs> element are not rendered directly. To display them you have to reference them (with a <use> element for example). https://developer.mozilla.org/en-US/docs/Web/SVG/Element/defs
    static member inline defs (children: seq<'Node>) = mk "defs" children
    /// The <desc> element provides an accessible, long-text description of any SVG container element or graphics element.
    static member inline desc (value: string) = mk "desc" [ofStr value]
    static member inline ellipse (children: seq<'Node>) = mk "ellipse" children
    static member inline feBlend (children: seq<'Node>) = mk "feBlend" children
    static member inline feColorMatrix (children: seq<'Node>) = mk "feColorMatrix" children
    static member inline feComponentTransfer (children: seq<'Node>) = mk "feComponentTransfer" children
    static member inline feComposite (children: seq<'Node>) = mk "feComposite" children
    static member inline feConvolveMatrix (children: seq<'Node>) = mk "feConvolveMatrix" children
    static member inline feDiffuseLighting (children: seq<'Node>) = mk "feDiffuseLighting" children
    static member inline feDisplacementMap (children: seq<'Node>) = mk "feDisplacementMap" children
    static member inline feDistantLight (children: seq<'Node>) = mk "feDistantLight" children
    static member inline feDropShadow (children: seq<'Node>) = mk "feDropShadow" children
    static member inline feFlood (children: seq<'Node>) = mk "feFlood" children
    static member inline feFuncA (children: seq<'Node>) = mk "feFuncA" children
    static member inline feFuncB (children: seq<'Node>) = mk "feFuncB" children
    static member inline feFuncG (children: seq<'Node>) = mk "feFuncG" children
    static member inline feFuncR (children: seq<'Node>) = mk "feFuncR" children
    static member inline feGaussianBlur (children: seq<'Node>) = mk "feGaussianBlur" children
    static member inline feImage (children: seq<'Node>) = mk "feImage" children
    static member inline feMerge (children: seq<'Node>) = mk "feMerge" children
    static member inline feMergeNode (children: seq<'Node>) = mk "feMergeNode" children
    static member inline feMorphology (children: seq<'Node>) = mk "feMorphology" children
    static member inline feOffset (children: seq<'Node>) = mk "feOffset" children
    static member inline fePointLight (children: seq<'Node>) = mk "fePointLight" children
    static member inline feSpecularLighting (children: seq<'Node>) = mk "feSpecularLighting" children
    static member inline feSpotLight (children: seq<'Node>) = mk "feSpotLight" children
    static member inline feTile (children: seq<'Node>) = mk "feTile" children
    static member inline feTurbulence (children: seq<'Node>) = mk "feTurbulence" children
    static member inline filter (children: seq<'Node>) = mk "filter" children
    static member inline foreignObject (children: seq<'Node>) = mk "foreignObject" children
    /// The <g> SVG element is a container used to group other SVG elements.
    ///
    /// Transformations applied to the <g> element are performed on its child elements, and its attributes are inherited by its children. It can also group multiple elements to be referenced later with the <use> element.
    static member inline g (children: seq<'Node>) = mk "g" children
    static member inline line (children: seq<'Node>) = mk "line" children
    static member inline linearGradient (children: seq<'Node>) = mk "linearGradient" children
    /// The <marker> element defines the graphic that is to be used for drawing arrowheads or polymarkers on a given <path>, <line>, <polyline> or <polygon> element.
    static member inline marker (children: seq<'Node>) = mk "marker" children
    static member inline mask (children: seq<'Node>) = mk "marker" children
    static member inline mpath (children: seq<'Node>) = mk "mpath" children
    static member inline path (children: seq<'Node>) = mk "path" children
    static member inline pattern (children: seq<'Node>) = mk "pattern" children
    static member inline polygon (children: seq<'Node>) = mk "polygon" children
    static member inline polyline (children: seq<'Node>) = mk "polyline" children
    static member inline set (children: seq<'Node>) = mk "set" children
    static member inline stop (children: seq<'Node>) = mk "stop" children
    static member inline style (value: string) = mk "style" [ofStr value]
    static member inline switch (children: seq<'Node>) = mk "switch" children
    static member inline symbol (children: seq<'Node>) = mk "symbol" children
    static member inline text (content: string) = mk "text" [ofStr content]
    static member inline title (content: string) = mk "title" [ofStr content]
    static member inline textPath (children: seq<'Node>) = mk "textPath" children
    static member inline tspan (children: seq<'Node>) = mk "tspan" children
    static member inline use' (children: seq<'Node>) = mk "use" children
    static member inline radialGradient (children: seq<'Node>) = mk "radialGradient" children
    static member inline rect (children: seq<'Node>) = mk "rect" children
    static member inline view (children: seq<'Node>) = mk "view" children

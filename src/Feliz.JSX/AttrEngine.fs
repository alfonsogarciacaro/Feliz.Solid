namespace Feliz.JSX

open System
open Fable.Core
open Fable.Core.JsInterop

// module AttrUtil =
//     let concatClasses classList =
//         classList |> Seq.choose (function false, _ -> None | true, c -> Some c) |> String.concat " "

// open AttrUtil

/// <summary>HTML Attribute generator API.</summary>
type Attr =
    /// Create a custom attribute
    ///
    /// You generally shouldn't need to use this, if you notice an attribute missing please submit an issue.
    static member inline custom (key: string, value: string): JSX.Prop = key, value

    static member inline style (styles: (string * string) seq): JSX.Prop =
        "style", createObj !!styles

    /// List of types the server accepts, typically a file type.
    static member inline accept (value: string): JSX.Prop = "accept", value

    /// List of supported charsets.
    static member inline acceptCharset (value: string): JSX.Prop = "accept-charset", value

    /// Defines a keyboard shortcut to activate or add focus to the element.
    static member inline accessKey (value: string): JSX.Prop = "accesskey", value

    /// The URI of a program that processes the information submitted via the form.
    static member inline action (value: string): JSX.Prop = "action", value

    /// Alternative text in case an image can't be displayed.
    static member inline alt (value: string): JSX.Prop = "alt", value

    /// Controls the amplitude of the gamma function of a component transfer element when
    /// its type attribute is gamma.
    static member inline amplitude (value: float): JSX.Prop = "amplitude", box(Util.asString value)

    /// Controls the amplitude of the gamma function of a component transfer element when
    /// its type attribute is gamma.
    static member inline amplitude (value: int): JSX.Prop = "amplitude", box(Util.asString value)

    /// Identifies the currently active descendant of a `composite` widget.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-activedescendant
    static member inline ariaActiveDescendant (id: string): JSX.Prop = "aria-activedescendant", id

    /// Indicates whether assistive technologies will present all, or only parts
    /// of, the changed region based on the change notifications defined by the
    /// `aria-relevant` attribute.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-atomic
    static member inline ariaAtomic (value: bool): JSX.Prop = "aria-atomic", value

    /// Indicates whether an element, and its subtree, are currently being
    /// updated.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-busy
    static member inline ariaBusy (value: bool): JSX.Prop = "aria-busy", value

    /// Indicates the current "checked" state of checkboxes, radio buttons, and
    /// other widgets. See related `aria-pressed` and `aria-selected`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-checked
    static member inline ariaChecked (value: bool): JSX.Prop = "aria-checked", value

    /// Identifies the element (or elements) whose contents or presence are
    /// controlled by the current element. See related `aria-owns`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-controls
    static member inline ariaControls ([<ParamArray>] ids: string[]): JSX.Prop = "aria-controls", box(String.concat " " ids)

    /// Specifies a URI referencing content that describes the object. See
    /// related `aria-describedby`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-describedat

    static member inline ariaDescribedAt (uri: string): JSX.Prop = "aria-describedat", uri
    /// Identifies the element (or elements) that describes the object. See
    /// related `aria-describedat` and `aria-labelledby`.
    ///
    /// The `aria-labelledby` attribute is similar to `aria-describedby` in that
    /// both reference other elements to calculate a text alternative, but a
    /// label should be concise, where a description is intended to provide more
    /// verbose information.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-describedby

    static member inline ariaDescribedBy ([<ParamArray>] ids: string[]): JSX.Prop = "aria-describedby", box(String.concat " " ids)
    /// Indicates that the element is perceivable but disabled, so it is not
    /// editable or otherwise operable. See related `aria-hidden` and
    /// `aria-readonly`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-disabled
    static member inline ariaDisabled (value: bool): JSX.Prop = "aria-disabled", value

    // /// Indicates what functions can be performed when the dragged object is
    // /// released on the drop target. This allows assistive technologies to
    // /// convey the possible drag options available to users, including whether a
    // /// pop-up menu of choices is provided by the application. Typically, drop
    // /// effect functions can only be provided once an object has been grabbed
    // /// for a drag operation as the drop effect functions available are
    // /// dependent on the object being dragged.
    // ///
    // /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-dropeffect
    // static member inline ariaDropEffect ([<ParamArray>] values: AriaDropEffect []): JSX.Prop = "aria-dropeffect", values |> Array.map Util.asString |> String.concat " "

    /// Indicates whether the element, or another grouping element it controls,
    /// is currently expanded or collapsed.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-expanded
    static member inline ariaExpanded (value: bool): JSX.Prop = "aria-expanded", value

    /// Identifies the next element (or elements) in an alternate reading order
    /// of content which, at the user's discretion, allows assistive technology
    /// to override the general default of reading in document source order.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-flowto
    static member inline ariaFlowTo ([<ParamArray>] ids: string[]): JSX.Prop = "aria-flowto", box(String.concat " " ids)

    /// Indicates an element's "grabbed" state in a drag-and-drop operation.
    ///
    /// When it is set to true it has been selected for dragging, false
    /// indicates that the element can be grabbed for a drag-and-drop operation,
    /// but is not currently grabbed, and undefined (or no value) indicates the
    /// element cannot be grabbed (default).
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-grabbed
    static member inline ariaGrabbed (value: bool): JSX.Prop = "aria-grabbed", value

    /// Indicates that the element has a popup context menu or sub-level menu.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-haspopup
    static member inline ariaHasPopup (value: bool): JSX.Prop = "aria-haspopup", value

    /// Indicates that the element and all of its descendants are not visible or
    /// perceivable to any user as implemented by the author. See related
    /// `aria-disabled`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-hidden
    static member inline ariaHidden (value: bool): JSX.Prop = "aria-hidden", value

    /// Indicates the entered value does not conform to the format expected by
    /// the application.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-invalid
    static member inline ariaInvalid (value: bool): JSX.Prop = "aria-invalid", value

    /// Defines a (Util.asString value) that labels the current element. See related
    /// `aria-labelledby`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-label
    static member inline ariaLabel (value: string): JSX.Prop = "aria-label", value
    /// Defines the hierarchical level of an element within a structure.
    ///
    /// This can be applied inside trees to tree items, to headings inside a
    /// document, to nested grids, nested tablists and to other structural items
    /// that may appear inside a container or participate in an ownership
    /// hierarchy. The value for `aria-level` is an integer greater than or
    /// equal to 1.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-level
    static member inline ariaLevel (value: int): JSX.Prop = "aria-level", box(Util.asString value)

    /// Identifies the element (or elements) that labels the current element.
    /// See related `aria-label` and `aria-describedby`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-labelledby
    static member inline ariaLabelledBy ([<ParamArray>] ids: string[]): JSX.Prop = "aria-labelledby", box(String.concat " " ids)

    /// Indicates whether a text box accepts multiple lines of input or only a
    /// single line.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-multiline
    static member inline ariaMultiLine (value: bool): JSX.Prop = "aria-multiline", value

    /// Indicates that the user may select more than one item from the current
    /// selectable descendants.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-multiselectable
    static member inline ariaMultiSelectable (value: bool): JSX.Prop = "aria-multiselectable", value

    /// Identifies an element (or elements) in order to define a visual,
    /// functional, or contextual parent/child relationship between DOM elements
    /// where the DOM hierarchy cannot be used to represent the relationship.
    /// See related `aria-controls`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-owns
    static member inline ariaOwns ([<ParamArray>] ids: string[]): JSX.Prop = "aria-owns", box(String.concat " " ids)

    /// Indicates the current "pressed" state of toggle buttons. See related
    /// `aria-checked` and `aria-selected`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-pressed
    static member inline ariaPressed (value: bool): JSX.Prop = "aria-pressed", value

    /// Defines an element's number or position in the current set of listitems
    /// or treeitems. Not required if all elements in the set are present in the
    /// DOM. See related `aria-setsize`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-posinset
    static member inline ariaPosInSet (value: int): JSX.Prop = "aria-posinset", box(Util.asString value)

    /// Indicates that the element is not editable, but is otherwise operable.
    /// See related `aria-disabled`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-readonly
    static member inline ariaReadOnly (value: bool): JSX.Prop = "aria-readonly", value

    // /// Indicates what user agent change notifications (additions, removals,
    // /// etc.) assistive technologies will receive within a live region. See
    // /// related `aria-atomic`.
    // ///
    // /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-relevant
    // static member inline ariaRelevant ([<ParamArray>] values: AriaRelevant []): JSX.Prop = "aria-relevant", values |> Array.map Util.asString |> String.concat " "

    /// Indicates that user input is required on the element before a form may
    /// be submitted.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-required
    static member inline ariaRequired (value: bool): JSX.Prop = "aria-required", value

    /// Indicates the current "selected" state of various widgets. See related
    /// `aria-checked` and `aria-pressed`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-selected
    static member inline ariaSelected (value: bool): JSX.Prop = "aria-selected", value

    /// Defines the maximum allowed value for a range widget.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-valuemax
    static member inline ariaValueMax (value: float): JSX.Prop = "aria-valuemax", box(Util.asString value)
    /// Defines the maximum allowed value for a range widget.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-valuemax
    static member inline ariaValueMax (value: int): JSX.Prop = "aria-valuemax", box(Util.asString value)

    /// Defines the minimum allowed value for a range widget.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-valuemin
    static member inline ariaValueMin (value: float): JSX.Prop = "aria-valuemin", box(Util.asString value)
    /// Defines the minimum allowed value for a range widget.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-valuemin
    static member inline ariaValueMin (value: int): JSX.Prop = "aria-valuemin", box(Util.asString value)

    /// Defines the current value for a range widget. See related
    /// `aria-valuetext`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-valuenow
    static member inline ariaValueNow (value: float): JSX.Prop = "aria-valuenow", box(Util.asString value)
    /// Defines the current value for a range widget. See related
    /// `aria-valuetext`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-valuenow
    static member inline ariaValueNow (value: int): JSX.Prop = "aria-valuenow", box(Util.asString value)

    /// Defines the human readable text alternative of `aria-valuenow` for a
    /// range widget.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-valuetext
    static member inline ariaValueText (value: string): JSX.Prop = "aria-valuetext", value

    /// Defines the number of items in the current set of listitems or
    /// treeitems. Not required if all elements in the set are present in the
    /// DOM. See related `aria-posinset`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-setsize
    static member inline ariaSetSize (value: int): JSX.Prop = "aria-setsize", box(Util.asString value)

    /// Indicates that the script should be executed asynchronously.
    static member inline async (value: bool): JSX.Prop = "async", value

    /// Indicates the name of the CSS property or attribute of the target element
    /// that is going to be changed during an animation.
    static member inline attributeName (value: string): JSX.Prop = "attributeName", value

    /// Indicates whether controls in this form can by default have their values
    /// automatically completed by the browser.
    static member inline autoComplete (value: string): JSX.Prop = "autocomplete", value

    /// The element should be automatically focused after the page loaded.
    static member inline autoFocus (value: bool): JSX.Prop = "autofocus", value

    /// The audio or video should play as soon as possible.
    static member inline autoPlay (value: bool): JSX.Prop = "autoplay", value

    /// Specifies the direction angle for the light source on the XY plane (clockwise),
    /// in degrees from the x axis.
    static member inline azimuth (value: float): JSX.Prop = "azimuth", box(Util.asString value)
    /// Specifies the direction angle for the light source on the XY plane (clockwise),
    /// in degrees from the x axis.
    static member inline azimuth (value: int): JSX.Prop = "azimuth", box(Util.asString value)

    /// Represents the base frequency parameter for the noise function of the
    /// <feTurbulence> filter primitive.
    static member inline baseFrequency (value: float): JSX.Prop = "baseFrequency", box(Util.asString value)
    /// Represents the base frequency parameter for the noise function of the
    /// <feTurbulence> filter primitive.
    static member inline baseFrequency (value: int): JSX.Prop = "baseFrequency", box(Util.asString value)
    /// Represents the base frequency parameter for the noise function of the
    /// <feTurbulence> filter primitive.
    static member inline baseFrequency (horizontal: float, vertical: float): JSX.Prop = "baseFrequency", box(Util.asString horizontal + "," + Util.asString vertical)
    /// Represents the base frequency parameter for the noise function of the
    /// <feTurbulence> filter primitive.
    static member inline baseFrequency (horizontal: int, vertical: int): JSX.Prop = "baseFrequency", box(Util.asString horizontal + "," + Util.asString vertical)
    /// Represents the base frequency parameter for the noise function of the
    /// <feTurbulence> filter primitive.

    /// Defines when an animation should begin or when an element should be discarded.
    static member inline begin' (value: string): JSX.Prop = "begin", value

    /// Shifts the range of the filter. After applying the kernelMatrix of the <feConvolveMatrix>
    /// element to the input image to yield a number and applied the divisor attribute, the bias
    /// attribute is added to each component. This allows representation of values that would
    /// otherwise be clamped to 0 or 1.
    static member inline bias (value: float): JSX.Prop = "bias", box(Util.asString value)
    /// Shifts the range of the filter. After applying the kernelMatrix of the <feConvolveMatrix>
    /// element to the input image to yield a number and applied the divisor attribute, the bias
    /// attribute is added to each component. This allows representation of values that would
    /// otherwise be clamped to 0 or 1.
    static member inline bias (value: int): JSX.Prop = "bias", box(Util.asString value)

    /// Specifies a relative offset value for an attribute that will be modified during an animation.
    static member inline by (value: float): JSX.Prop = "by", box(Util.asString value)
    /// Specifies a relative offset value for an attribute that will be modified during an animation.
    static member inline by (value: int): JSX.Prop = "by", box(Util.asString value)
    /// Specifies a relative offset value for an attribute that will be modified during an animation.
    static member inline by (value: string): JSX.Prop = "by", value

    static member inline capture (value: bool): JSX.Prop = "capture", value

    /// This attribute declares the document's character encoding. Must be used in the meta tag.
    static member inline charset (value: string): JSX.Prop = "charset", value

    /// A URL that designates a source document or message for the information quoted. This attribute is intended to
    /// point to information explaining the context or the reference for the quote.
    static member inline cite (value: string): JSX.Prop = "cite", value

    /// Specifies a CSS class for this element.
    static member inline className (value: string): JSX.Prop = "class", value
    /// Takes a `seq<string>` and joins them using a space to combine the classses into a single class property.
    ///
    /// `prop.className [ "one"; "two" ]`
    ///
    /// is the same as
    ///
    /// `prop.className "one two"`
    static member inline className (names: seq<string>): JSX.Prop = "class", box(String.concat " " names)

    /// Takes a `seq<string>` and joins them using a space to combine the classses into a single class property.
    ///
    /// `prop.classes [ "one"; "two" ]` => `prop.className "one two"`
    static member inline classes (names: seq<string>): JSX.Prop = "class", box(String.concat " " names)

    // static member inline classes (names: seq<bool * string>): JSX.Prop =
    //     "class", box(concatClasses names)

    /// Defines the number of columns in a textarea.
    static member inline cols (value: int): JSX.Prop = "cols", box(Util.asString value)

    /// Defines the number of columns a cell should span.
    static member inline colSpan (value: int): JSX.Prop = "colspan", box(Util.asString value)

    /// A value associated with http-equiv or name depending on the context.
    static member inline content (value: string): JSX.Prop = "content", value

    /// Indicates whether the element's content is editable.
    static member inline contentEditable (value: bool): JSX.Prop = "contenteditable", value

    /// If true, the browser will offer controls to allow the user to control video playback,
    /// including volume, seeking, and pause/resume playback.
    static member inline controls (value: bool): JSX.Prop = "controls", value

    /// The SVG cx attribute define the x-axis coordinate of a center point.
    ///
    /// Three elements are using this attribute: <circle>, <ellipse>, and <radialGradient>
    static member inline cx (value: ICssUnit): JSX.Prop = "cx", box(Util.asString value)
    /// The SVG cx attribute define the x-axis coordinate of a center point.
    ///
    /// Three elements are using this attribute: <circle>, <ellipse>, and <radialGradient>
    static member inline cx (value: int): JSX.Prop = "cx", box(Util.asString value)

    /// The SVG cy attribute define the y-axis coordinate of a center point.
    ///
    /// Three elements are using this attribute: <circle>, <ellipse>, and <radialGradient>
    static member inline cy (value: ICssUnit): JSX.Prop = "cy", box(Util.asString value)
    /// The SVG cy attribute define the y-axis coordinate of a center point.
    ///
    /// Three elements are using this attribute: <circle>, <ellipse>, and <radialGradient>
    static member inline cy (value: int): JSX.Prop = "cy", box(Util.asString value)

    // TODO
    // /// Defines a SVG path to be drawn.
    // static member inline d (path: seq<char * (float list list)>): JSX.Prop =
    //     PropHelpers.createSvgPathFloat path
    //     |> h.MakeAttr("d",)
    // /// Defines a SVG path to be drawn.
    // static member inline d (path: seq<char * (int list list)>): JSX.Prop =
    //     PropHelpers.createSvgPathInt path
    //     |> h.MakeAttr("d",)
    /// Defines a SVG path to be drawn.
    static member inline d (path: string): JSX.Prop = "d", path

    // /// Sets the inner Html content of the element.
    // static member inline dangerouslySetInnerHTML (content: string): JSX.Prop = "dangerouslySetInnerHTML", box(createObj [ "__html" ==> content ])

    /// This attribute indicates the time and/or date of the element.
    static member inline dateTime (value: string): JSX.Prop = "datetime", value

    /// Indicates to a browser that the script is meant to be executed after the document
    /// has been parsed, but before firing DOMContentLoaded.
    ///
    /// Scripts with the defer attribute will prevent the DOMContentLoaded event from
    /// firing until the script has loaded and finished evaluating.
    ///
    /// This attribute must not be used if the src attribute is absent (i.e. for inline scripts),
    /// in this case it would have no effect.
    static member inline defer (value: bool): JSX.Prop = "defer", value

    /// Represents the kd value in the Phong lighting model.
    ///
    /// In SVG, this can be any non-negative number.
    static member inline diffuseConstant (value: float): JSX.Prop = "diffuseConstant", box(Util.asString value)
    /// Represents the kd value in the Phong lighting model.
    ///
    /// In SVG, this can be any non-negative number.
    static member inline diffuseConstant (value: int): JSX.Prop = "diffuseConstant", box(Util.asString value)

    /// Sets the directionality of the element.
    static member inline dirName (value: string): JSX.Prop = "dirName", value

    /// Indicates whether the user can interact with the element.
    static member inline disabled (value: bool): JSX.Prop = "disabled", value

    /// Specifies the value by which the resulting number of applying the kernelMatrix
    /// of a <feConvolveMatrix> element to the input image color value is divided to
    /// yield the destination color value.
    ///
    /// A divisor that is the sum of all the matrix values tends to have an evening
    /// effect on the overall color intensity of the result.
    static member inline divisor (value: float): JSX.Prop = "divisor", box(Util.asString value)
    /// Specifies the value by which the resulting number of applying the kernelMatrix
    /// of a <feConvolveMatrix> element to the input image color value is divided to
    /// yield the destination color value.
    ///
    /// A divisor that is the sum of all the matrix values tends to have an evening
    /// effect on the overall color intensity of the result.
    static member inline divisor (value: int): JSX.Prop = "divisor", box(Util.asString value)

    /// This attribute, if present, indicates that the author intends the hyperlink to be used for downloading a resource.
    static member inline download (value: bool): JSX.Prop = "download", value

    /// Indicates whether the the element can be dragged.
    static member inline draggable (value: bool): JSX.Prop = "draggable", value

    /// SVG attribute to indicate a shift along the x-axis on the position of an element or its content.
    static member inline dx (value: float): JSX.Prop = "dx", box(Util.asString value)
    /// SVG attribute to indicate a shift along the x-axis on the position of an element or its content.
    static member inline dx (value: int): JSX.Prop = "dx", box(Util.asString value)

    /// SVG attribute to indicate a shift along the y-axis on the position of an element or its content.
    static member inline dy (value: float): JSX.Prop = "dy", box(Util.asString value)
    /// SVG attribute to indicate a shift along the y-axis on the position of an element or its content.
    static member inline dy (value: int): JSX.Prop = "dy", box(Util.asString value)

    /// SVG attribute that specifies the direction angle for the light source from the XY plane towards
    /// the Z-axis, in degrees.
    ///
    /// Note that the positive Z-axis points towards the viewer of the content.
    static member inline elevation (value: float): JSX.Prop = "elevation", box(Util.asString value)
    /// SVG attribute that specifies the direction angle for the light source from the XY plane towards
    /// the Z-axis, in degrees.
    ///
    /// Note that the positive Z-axis points towards the viewer of the content.
    static member inline elevation (value: int): JSX.Prop = "elevation", box(Util.asString value)

    /// Defines an end value for the animation that can constrain the active duration.
    static member inline end' (value: string): JSX.Prop = "end", value
    /// Defines an end value for the animation that can constrain the active duration.
    static member inline end' (values: seq<string>): JSX.Prop = "end", box(String.concat ";" values)
    /// Defines the exponent of the gamma function.
    static member inline exponent (value: float): JSX.Prop = "exponent", box(Util.asString value)
    /// Defines the exponent of the gamma function.
    static member inline exponent (value: int): JSX.Prop = "exponent", box(Util.asString value)

    // /// Defines the files that will be uploaded when using an input element of the file type.
    // static member inline files (value: FileList): JSX.Prop = "files", value

    /// SVG attribute to define the opacity of the paint server (color, gradient, pattern, etc) applied to a shape.
    static member inline fillOpacity (value: float): JSX.Prop = "fill-opacity", box(Util.asString value)
    /// SVG attribute to define the opacity of the paint server (color, gradient, pattern, etc) applied to a shape.
    static member inline fillOpacity (value: int): JSX.Prop = "fill-opacity", box(Util.asString value)

    /// SVG attribute to define the size of the font from baseline to baseline when multiple
    /// lines of text are set solid in a multiline layout environment.
    static member inline fontSize (value: float): JSX.Prop = "font-size", box(Util.asString value)
    /// SVG attribute to define the size of the font from baseline to baseline when multiple
    /// lines of text are set solid in a multiline layout environment.
    static member inline fontSize (value: int): JSX.Prop = "font-size", box(Util.asString value)

    /// A space-separated list of other elements’ ids, indicating that those elements contributed input
    /// values to (or otherwise affected) the calculation.
    static member inline for' (value: string): JSX.Prop = "for", value
    /// A space-separated list of other elements’ ids, indicating that those elements contributed input
    /// values to (or otherwise affected) the calculation.
    static member inline for' (ids: #seq<string>): JSX.Prop = "for", box(ids |> String.concat " ")

    /// The <form> element to associate the <meter> element with (its form owner). The value of this
    /// attribute must be the id of a <form> in the same document. If this attribute is not set, the
    /// <button> is associated with its ancestor <form> element, if any. This attribute is only used
    /// if the <meter> element is being used as a form-associated element, such as one displaying a
    /// range corresponding to an <input type="number">.
    static member inline form (value: string): JSX.Prop = "form", value

    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline from (value: float): JSX.Prop = "from", box(Util.asString value)
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline from (values: seq<float>): JSX.Prop = "from", box(values |> Seq.map Util.asString |> String.concat " ")
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline from (value: int): JSX.Prop = "from", box(Util.asString value)
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline from (values: seq<int>): JSX.Prop = "from", box(values |> Seq.map Util.asString |> String.concat " ")
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline from (value: string): JSX.Prop = "from", value
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline from (values: seq<string>): JSX.Prop = "from", box(values |> String.concat " ")

    /// Defines the radius of the focal point for the radial gradient.
    static member inline fr (value: int): JSX.Prop = "fr", box(Util.asString value)
    /// Defines the radius of the focal point for the radial gradient.
    static member inline fr (value: ICssUnit): JSX.Prop = "fr", box(Util.asString value)

    /// Defines the x-axis coordinate of the focal point for a radial gradient.
    static member inline fx (value: int): JSX.Prop = "fx", box(Util.asString value)
    /// Defines the x-axis coordinate of the focal point for a radial gradient.
    static member inline fx (value: ICssUnit): JSX.Prop = "fx", box(Util.asString value)

    /// Defines the y-axis coordinate of the focal point for a radial gradient.
    static member inline fy (value: int): JSX.Prop = "fy", box(Util.asString value)
    /// Defines the y-axis coordinate of the focal point for a radial gradient.
    static member inline fy (value: ICssUnit): JSX.Prop = "fy", box(Util.asString value)

    /// Defines an optional additional transformation from the gradient coordinate system
    /// onto the target coordinate system (i.e., userSpaceOnUse or objectBoundingBox).
    ///
    /// This allows for things such as skewing the gradient. This additional transformation
    /// matrix is post-multiplied to (i.e., inserted to the right of) any previously defined
    /// transformations, including the implicit transformation necessary to convert from object
    /// bounding box units to user space.
    static member inline gradientTransform (transform: ITransformProperty): JSX.Prop =
        "gradientTransform", box(Util.asString transform)
    /// Defines optional additional transformation(s) from the gradient coordinate system
    /// onto the target coordinate system (i.e., userSpaceOnUse or objectBoundingBox).
    ///
    /// This allows for things such as skewing the gradient. This additional transformation
    /// matrix is post-multiplied to (i.e., inserted to the right of) any previously defined
    /// transformations, including the implicit transformation necessary to convert from object
    /// bounding box units to user space.
    static member inline gradientTransform (transforms: seq<ITransformProperty>): JSX.Prop =
        "gradientTransform", box(transforms |> Seq.map Util.asString |> String.concat " ")

    /// Prevents rendering of given element, while keeping child elements, e.g. script elements, active.
    static member inline hidden (value: bool): JSX.Prop = "hidden", value

    /// Specifies the height of elements listed here. For all other elements, use the CSS height property.
    ///
    /// HTML: <canvas>, <embed>, <iframe>, <img>, <input>, <object>, <video>
    ///
    /// SVG: <feBlend>, <feColorMatrix>, <feComponentTransfer>, <feComposite>, <feConvolveMatrix>,
    /// <feDiffuseLighting>, <feDisplacementMap>, <feDropShadow>, <feFlood>, <feGaussianBlur>, <feImage>,
    /// <feMerge>, <feMorphology>, <feOffset>, <feSpecularLighting>, <feTile>, <feTurbulence>, <filter>,
    /// <mask>, <pattern>
    static member inline height (value: ICssUnit): JSX.Prop = "height", box(Util.asString value)
    /// Specifies the height of elements listed here. For all other elements, use the CSS height property.
    ///
    /// HTML: <canvas>, <embed>, <iframe>, <img>, <input>, <object>, <video>
    ///
    /// SVG: <feBlend>, <feColorMatrix>, <feComponentTransfer>, <feComposite>, <feConvolveMatrix>,
    /// <feDiffuseLighting>, <feDisplacementMap>, <feDropShadow>, <feFlood>, <feGaussianBlur>, <feImage>,
    /// <feMerge>, <feMorphology>, <feOffset>, <feSpecularLighting>, <feTile>, <feTurbulence>, <filter>,
    /// <mask>, <pattern>
    static member inline height (value: int): JSX.Prop = "height", box(Util.asString value)

    /// The lower numeric bound of the high end of the measured range. This must be less than the
    /// maximum value (max attribute), and it also must be greater than the low value and minimum
    /// value (low attribute and min attribute, respectively), if any are specified. If unspecified,
    /// or if greater than the maximum value, the high value is equal to the maximum value.
    static member inline high (value: float): JSX.Prop = "high", box(Util.asString value)
    /// The lower numeric bound of the high end of the measured range. This must be less than the
    /// maximum value (max attribute), and it also must be greater than the low value and minimum
    /// value (low attribute and min attribute, respectively), if any are specified. If unspecified,
    /// or if greater than the maximum value, the high value is equal to the maximum value.
    static member inline high (value: int): JSX.Prop = "high", box(Util.asString value)

    /// The URL of a linked resource.
    static member inline href (value: string): JSX.Prop = "href", value

    /// Indicates the language of the linked resource. Allowed values are determined by BCP47.
    ///
    /// Use this attribute only if the href attribute is present.
    static member inline hrefLang (value: string): JSX.Prop = "hreflang", value

    static member inline htmlFor (value: string): JSX.Prop = "for", value

    /// Often used with CSS to style a specific element. The value of this attribute must be unique.
    static member inline id (value: int): JSX.Prop = "id", box((Util.asString value))
    /// Often used with CSS to style a specific element. The value of this attribute must be unique.
    static member inline id (value: string): JSX.Prop = "id", value

    // /// Alias for `dangerouslySetInnerHTML`, sets the inner Html content of the element.
    // static member inline innerHtml (content: string): JSX.Prop = "dangerouslySetInnerHTML", box(createObj [ "__html" ==> content ])

    /// Contains inline metadata that a user agent can use to verify that a fetched resource
    /// has been delivered free of unexpected manipulation.
    static member inline integrity (value: string): JSX.Prop = "integrity", value

    /// Defines the intercept of the linear function of color component transfers when the type
    /// attribute is set to linear.
    static member inline intercept (value: float): JSX.Prop = "intercept", box(Util.asString value)
    /// Defines the intercept of the linear function of color component transfers when the type
    /// attribute is set to linear.
    static member inline intercept (value: int): JSX.Prop = "intercept", box(Util.asString value)

    /// Sets the checked attribute for an element.
    static member inline isChecked (value: bool): JSX.Prop = "checked", value

    /// Sets the open attribute for an element.
    static member inline isOpen (value: bool): JSX.Prop = "open", value

    /// Defines one of the values to be used within the the arithmetic operation of the
    /// <feComposite> filter primitive.
    static member inline k1 (value: float): JSX.Prop = "k1", box(Util.asString value)
    /// Defines one of the values to be used within the the arithmetic operation of the
    /// <feComposite> filter primitive.
    static member inline k1 (value: int): JSX.Prop = "k1", box(Util.asString value)

    /// Defines one of the values to be used within the the arithmetic operation of the
    /// <feComposite> filter primitive.
    static member inline k2 (value: float): JSX.Prop = "k2", box(Util.asString value)
    /// Defines one of the values to be used within the the arithmetic operation of the
    /// <feComposite> filter primitive.
    static member inline k2 (value: int): JSX.Prop = "k2", box(Util.asString value)

    /// Defines one of the values to be used within the the arithmetic operation of the
    /// <feComposite> filter primitive.
    static member inline k3 (value: float): JSX.Prop = "k3", box(Util.asString value)
    /// Defines one of the values to be used within the the arithmetic operation of the
    /// <feComposite> filter primitive.
    static member inline k3 (value: int): JSX.Prop = "k3", box(Util.asString value)

    /// Defines one of the values to be used within the the arithmetic operation of the
    /// <feComposite> filter primitive.
    static member inline k4 (value: float): JSX.Prop = "k4", box(Util.asString value)
    /// Defines one of the values to be used within the the arithmetic operation of the
    /// <feComposite> filter primitive.
    static member inline k4 (value: int): JSX.Prop = "k4", box(Util.asString value)

    /// Defines the list of numbers that make up the kernel matrix for the
    /// <feConvolveMatrix> element.
    static member inline kernelMatrix (values: seq<float>): JSX.Prop = "kernelMatrix", box(values |> Seq.map Util.asString |> String.concat " ")
    /// Defines the list of numbers that make up the kernel matrix for the
    /// <feConvolveMatrix> element.
    static member inline kernelMatrix (values: seq<int>): JSX.Prop = "kernelMatrix", box(values |> Seq.map Util.asString  |> String.concat " ")

    /// Indicates the simple duration of an animation.
    static member inline keyPoints (values: seq<float>): JSX.Prop =
        "keyPoints", box(values |> Seq.map Util.asString  |> String.concat ";")

    // /// Indicates the simple duration of an animation.
    // ///
    // /// Each control point description is a set of four values: x1 y1 x2 y2, describing the Bézier
    // /// control points for one time segment.
    // ///
    // /// The keyTimes values that define the associated segment are the Bézier "anchor points",
    // /// and the keySplines values are the control points. Thus, there must be one fewer sets of
    // /// control points than there are keyTimes.
    // ///
    // /// The values of x1 y1 x2 y2 must all be in the range 0 to 1.
    // static member inline keySplines (values: seq<float * float * float * float>): JSX.Prop =
    //     PropHelpers.createKeySplines(values)
    //     |> h.MakeAttr("keySplines",)

    /// Indicates the simple duration of an animation.
    static member inline keyTimes (values: seq<float>): JSX.Prop =
        "keyTimes", box(values |> Seq.map Util.asString |> String.concat ";")

    /// Helps define the language of an element: the language that non-editable elements are
    /// written in, or the language that the editable elements should be written in by the user.
    static member inline lang (value: string): JSX.Prop = "lang", value

    /// Defines the color of the light source for lighting filter primitives.
    static member inline lightingColor (value: string): JSX.Prop = "lighting-color", value

    /// Represents the angle in degrees between the spot light axis (i.e. the axis between the
    /// light source and the point to which it is pointing at) and the spot light cone. So it
    /// defines a limiting cone which restricts the region where the light is projected.
    ///
    /// No light is projected outside the cone.
    static member inline limitingConeAngle (value: float): JSX.Prop = "limitingConeAngle", box(Util.asString value)
    /// Represents the angle in degrees between the spot light axis (i.e. the axis between the
    /// light source and the point to which it is pointing at) and the spot light cone. So it
    /// defines a limiting cone which restricts the region where the light is projected.
    ///
    /// No light is projected outside the cone.
    static member inline limitingConeAngle (value: int): JSX.Prop = "limitingConeAngle", box(Util.asString value)

    /// If true, the browser will automatically seek back to the start upon reaching the end of the video.
    static member inline loop (value: bool): JSX.Prop = "loop", value

    /// The upper numeric bound of the low end of the measured range. This must be greater than
    /// the minimum value (min attribute), and it also must be less than the high value and
    /// maximum value (high attribute and max attribute, respectively), if any are specified.
    /// If unspecified, or if less than the minimum value, the low value is equal to the minimum value.
    static member inline low (value: float): JSX.Prop = "low", box(Util.asString value)
    /// The upper numeric bound of the low end of the measured range. This must be greater than
    /// the minimum value (min attribute), and it also must be less than the high value and
    /// maximum value (high attribute and max attribute, respectively), if any are specified.
    /// If unspecified, or if less than the minimum value, the low value is equal to the minimum value.
    static member inline low (value: int): JSX.Prop = "low", box(Util.asString value)
    /// Indicates the maximum value allowed.
    static member inline max (value: float): JSX.Prop = "max", box(Util.asString value)
    /// Indicates the maximum value allowed.
    static member inline max (value: int): JSX.Prop = "max", box(Util.asString value)
    /// Indicates the maximum value allowed.
    static member inline max (value: DateTime): JSX.Prop = "max", box(value.ToString("yyyy-MM-dd"))

    /// Defines the maximum number of characters allowed in the element.
    static member inline maxLength (value: int): JSX.Prop = "maxlength", box(Util.asString value)

    /// This attribute specifies the media that the linked resource applies to.
    /// Its value must be a media type / media query. This attribute is mainly useful
    /// when linking to external stylesheets — it allows the user agent to pick the
    /// best adapted one for the device it runs on.
    ///
    /// In HTML 4, this can only be a simple white-space-separated list of media
    /// description literals, i.e., media types and groups, where defined and allowed
    /// as values for this attribute, such as print, screen, aural, braille. HTML5
    /// extended this to any kind of media queries, which are a superset of the allowed
    /// values of HTML 4.
    ///
    /// Browsers not supporting CSS3 Media Queries won't necessarily recognize the adequate
    /// link; do not forget to set fallback links, the restricted set of media queries
    /// defined in HTML 4.
    static member inline media (value: string): JSX.Prop = "media", value

    /// Defines which HTTP method to use when submitting the form. Can be GET (default) or POST.
    static member inline method (value: string): JSX.Prop = "method", value

    /// Indicates the minimum value allowed.
    static member inline min (value: float): JSX.Prop = "min", box(Util.asString value)
    /// Indicates the minimum value allowed.
    static member inline min (value: int): JSX.Prop = "min", box(Util.asString value)
    /// Indicates the minimum value allowed.
    static member inline min (value: DateTime): JSX.Prop = "min", box(value.ToString("yyyy-MM-dd"))

    /// Defines the minimum number of characters allowed in the element.
    static member inline minLength (value: int): JSX.Prop = "minlength", box(Util.asString value)

    /// Indicates whether multiple values can be entered in an input of the type email or file.
    static member inline multiple (value: bool): JSX.Prop = "multiple", value

    /// Indicates whether the audio will be initially silenced on page load.
    static member inline muted (value: bool): JSX.Prop = "muted", value

    /// Name of the element.
    ///
    /// For example used by the server to identify the fields in form submits.
    static member inline name (value: string): JSX.Prop = "name", value

    /// This Boolean attribute is set to indicate that the script should not be executed in
    /// browsers that support ES2015 modules — in effect, this can be used to serve fallback
    /// scripts to older browsers that do not support modular JavaScript code.
    static member inline nomodule (value: bool): JSX.Prop = "nomodule", value

    /// A cryptographic nonce (number used once) to whitelist scripts in a script-src
    /// Content-Security-Policy. The server must generate a unique nonce value each time
    /// it transmits a policy. It is critical to provide a nonce that cannot be guessed
    /// as bypassing a resource's policy is otherwise trivial.
    static member inline nonce (value: string): JSX.Prop = "nonce", value

    /// Defines the number of octaves for the noise function of the <feTurbulence> primitive.
    static member inline numOctaves (value: int): JSX.Prop = "numOctaves", box(Util.asString value)

    /// SVG attribute to define where the gradient color will begin or end.
    static member inline offset (value: ICssUnit): JSX.Prop = "offset", box(Util.asString value)
    /// SVG attribute to define where the gradient color will begin or end.
    static member inline offset (value: int): JSX.Prop = "offset", box(Util.asString value)

    /// This attribute indicates the optimal numeric value. It must be within the range (as defined by the min
    /// attribute and max attribute). When used with the low attribute and high attribute, it gives an indication
    /// where along the range is considered preferable. For example, if it is between the min attribute and the
    /// low attribute, then the lower range is considered preferred.
    static member inline optimum (value: float): JSX.Prop = "optimum", box(Util.asString value)
    /// This attribute indicates the optimal numeric value. It must be within the range (as defined by the min
    /// attribute and max attribute). When used with the low attribute and high attribute, it gives an indication
    /// where along the range is considered preferable. For example, if it is between the min attribute and the
    /// low attribute, then the lower range is considered preferred.
    static member inline optimum (value: int): JSX.Prop = "optimum", box(Util.asString value)

    /// Indicates the minimum value allowed.
    static member inline order (value: int): JSX.Prop = "order", box(Util.asString value)
    /// Indicates the minimum value allowed.
    static member inline order (values: seq<int>): JSX.Prop = "order", box(values |> Seq.map Util.asString |> String.concat " ")

    /// Represents the ideal vertical position of the overline.
    ///
    /// The overline position is expressed in the font's coordinate system.
    static member inline overlinePosition (value: float): JSX.Prop = "overline-position", box(Util.asString value)
    /// Represents the ideal vertical position of the overline.
    ///
    /// The overline position is expressed in the font's coordinate system.
    static member inline overlinePosition (value: int): JSX.Prop = "overline-position", box(Util.asString value)

    /// Represents the ideal thickness of the overline.
    ///
    /// The overline thickness is expressed in the font's coordinate system.
    static member inline overlineThickness (value: float): JSX.Prop = "overline-thickness", box(Util.asString value)
    /// Represents the ideal thickness of the overline.
    ///
    /// The overline thickness is expressed in the font's coordinate system.
    static member inline overlineThickness (value: int): JSX.Prop = "overline-thickness", box(Util.asString value)

    // /// It either defines a text path along which the characters of a text are rendered, or a motion
    // /// path along which a referenced element is animated.
    // static member inline path (path: seq<char * (float list list)>): JSX.Prop =
    //     PropHelpers.createSvgPathFloat path
    //     |> h.MakeAttr("path")
    // /// It either defines a text path along which the characters of a text are rendered, or a motion
    // /// path along which a referenced element is animated.
    // static member inline path (path: seq<char * (int list list)>): JSX.Prop =
    //     PropHelpers.createSvgPathInt path
    //     |> h.MakeAttr("path")
    /// It either defines a text path along which the characters of a text are rendered, or a motion
    /// path along which a referenced element is animated.
    static member inline path (path: string): JSX.Prop = "path", path
    /// The part global attribute contains a space-separated list of the part names of the element.
    /// Part names allows CSS to select and style specific elements in a shadow tree
    static member inline part(value: string): JSX.Prop = "part", value
    /// The part global attribute contains a space-separated list of the part names of the element.
    /// Part names allows CSS to select and style specific elements in a shadow tree
    static member inline part(values: #seq<string>): JSX.Prop = "part", box(String.concat " " values)
    /// Specifies a total length for the path, in user units.
    ///
    /// This value is then used to calibrate the browser's distance calculations with those of the
    /// author, by scaling all distance computations using the ratio pathLength/(computed value of
    /// path length).
    ///
    /// This can affect the actual rendered lengths of paths; including text paths, animation paths,
    /// and various stroke operations. Basically, all computations that require the length of the path.
    static member inline pathLength (value: int): JSX.Prop = "pathLength", box(Util.asString value)

    /// Sets the input field allowed input.
    ///
    /// This attribute only applies when the value of the type attribute is text, search, tel, url or email.
    static member inline pattern (value: string): JSX.Prop = "pattern", value

    /// Defines a list of transform definitions that are applied to a pattern tile.
    static member inline patternTransform (transform: ITransformProperty): JSX.Prop =
        "patternTransform", box(Util.asString transform)
    /// Defines a list of transform definitions that are applied to a pattern tile.
    static member inline patternTransform (transforms: seq<ITransformProperty>): JSX.Prop =
        "patternTransform", box(transforms |> Seq.map Util.asString |> String.concat " ")

    /// Provides a hint to the user of what can be entered in the field.
    static member inline placeholder (value: string): JSX.Prop = "placeholder", value

    /// Indicating that the video is to be played "inline", that is within the element's playback area.
    ///
    /// Note that the absence of this attribute does not imply that the video will always be played in fullscreen.
    static member inline playsInline (value: bool): JSX.Prop = "playsinline", value

    /// Contains a space-separated list of URLs to which, when the hyperlink is followed,
    /// POST requests with the body PING will be sent by the browser (in the background).
    ///
    /// Typically used for tracking.
    static member inline ping (value: string): JSX.Prop = "ping", value
    /// Contains a space-separated list of URLs to which, when the hyperlink is followed,
    /// POST requests with the body PING will be sent by the browser (in the background).
    ///
    /// Typically used for tracking.
    static member inline ping (urls: #seq<string>): JSX.Prop = "ping", box(urls |> String.concat " ")

    // /// Defines a list of points.
    // ///
    // /// Each point is defined by a pair of numbers representing a X and a Y coordinate in
    // /// the user coordinate system.
    // static member inline points (coordinates: seq<float * float>): JSX.Prop =
    //     PropHelpers.createPointsFloat(coordinates)
    //     |> h.MakeAttr("points")
    // /// Defines a list of points.
    // ///
    // /// Each point is defined by a pair of numbers representing a X and a Y coordinate in
    // /// the user coordinate system.
    // static member inline points (coordinates: seq<int * int>): JSX.Prop =
    //     PropHelpers.createPointsInt(coordinates)
    //     |> h.MakeAttr("points")

    /// Defines a list of points.
    ///
    /// Each point is defined by a pair of numbers representing a X and a Y coordinate in
    /// the user coordinate system.
    static member inline points (coordinates: string): JSX.Prop = "points", coordinates

    /// Represents the x location in the coordinate system established by attribute primitiveUnits
    /// on the <filter> element of the point at which the light source is pointing.
    static member inline pointsAtX (value: float): JSX.Prop = "pointsAtX", box(Util.asString value)
    /// Represents the x location in the coordinate system established by attribute primitiveUnits
    /// on the <filter> element of the point at which the light source is pointing.
    static member inline pointsAtX (value: int): JSX.Prop = "pointsAtX", box(Util.asString value)

    /// Represents the y location in the coordinate system established by attribute primitiveUnits
    /// on the <filter> element of the point at which the light source is pointing.
    static member inline pointsAtY (value: float): JSX.Prop = "pointsAtY", box(Util.asString value)
    /// Represents the y location in the coordinate system established by attribute primitiveUnits
    /// on the <filter> element of the point at which the light source is pointing.
    static member inline pointsAtY (value: int): JSX.Prop = "pointsAtY", box(Util.asString value)

    /// Represents the y location in the coordinate system established by attribute primitiveUnits
    /// on the <filter> element of the point at which the light source is pointing, assuming that,
    /// in the initial local coordinate system, the positive z-axis comes out towards the person
    /// viewing the content and assuming that one unit along the z-axis equals one unit in x and y.
    static member inline pointsAtZ (value: float): JSX.Prop = "pointsAtZ", box(Util.asString value)
    /// Represents the y location in the coordinate system established by attribute primitiveUnits
    /// on the <filter> element of the point at which the light source is pointing, assuming that,
    /// in the initial local coordinate system, the positive z-axis comes out towards the person
    /// viewing the content and assuming that one unit along the z-axis equals one unit in x and y.
    static member inline pointsAtZ (value: int): JSX.Prop = "pointsAtZ", box(Util.asString value)

    /// Indicates how a <feConvolveMatrix> element handles alpha transparency.
    static member inline preserveAlpha (value: bool): JSX.Prop = "preserveAlpha", value

    /// A URL for an image to be shown while the video is downloading. If this attribute isn't specified, nothing
    /// is displayed until the first frame is available, then the first frame is shown as the poster frame.
    static member inline poster (value: string): JSX.Prop = "poster", value

    /// SVG attribute to define the radius of a circle.
    static member inline r (value: ICssUnit): JSX.Prop = "r", box(Util.asString value)
    /// SVG attribute to define the radius of a circle.
    static member inline r (value: int): JSX.Prop = "r", box(Util.asString value)

    /// Represents the radius (or radii) for the operation on a given <feMorphology> filter primitive.
    static member inline radius (value: float): JSX.Prop = "radius", box(Util.asString value)
    /// Represents the radius (or radii) for the operation on a given <feMorphology> filter primitive.
    static member inline radius (value: int): JSX.Prop = "radius", box(Util.asString value)
    /// Represents the radius (or radii) for the operation on a given <feMorphology> filter primitive.
    static member inline radius (xRadius: float, yRadius: float): JSX.Prop = "radius", box(Util.asString xRadius  + "," + Util.asString yRadius)
    /// Represents the radius (or radii) for the operation on a given <feMorphology> filter primitive.
    static member inline radius (xRadius: int, yRadius: int): JSX.Prop = "radius", box(Util.asString xRadius  + "," + Util.asString yRadius)

    /// Indicates whether the element can be edited.
    static member inline readOnly (value: bool): JSX.Prop = "readOnly", value

    // /// Used to reference a DOM element or class component from within a parent component.
    // static member inline ref (handler: Element -> unit): JSX.Prop = "ref", handler
    // /// Used to reference a DOM element or class component from within a parent component.
    // static member inline ref (ref: IRefValue<#HTMLElement option>): JSX.Prop = "ref", ref

    /// For anchors containing the href attribute, this attribute specifies the relationship
    /// of the target object to the link object. The value is a space-separated list of link
    /// types values. The values and their semantics will be registered by some authority that
    /// might have meaning to the document author. The default relationship, if no other is
    /// given, is void.
    ///
    /// Use this attribute only if the href attribute is present.
    static member inline rel (value: string): JSX.Prop = "rel", value

    /// Indicates whether this element is required to fill out or not.
    static member inline required (value: bool): JSX.Prop = "required", value

    /// Defines the assigned name for this filter primitive.
    ///
    /// If supplied, then graphics that result from processing this filter primitive can be
    /// referenced by an in attribute on a subsequent filter primitive within the same
    /// <filter> element.
    ///
    /// If no value is provided, the output will only be available for re-use as the implicit
    /// input into the next filter primitive if that filter primitive provides no value for
    /// its in attribute.
    static member inline result (value: string): JSX.Prop = "result", value

    /// Sets the aria role
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles
    static member inline role ([<System.ParamArray>] roles: string[]): JSX.Prop = "role", box(String.concat " " roles)

    /// Defines the number of rows in a text area.
    static member inline rows (value: int): JSX.Prop = "rows", box(Util.asString value)

    /// Defines the number of rows a table cell should span over.
    static member inline rowSpan (value: int): JSX.Prop = "rowspan", box(Util.asString value)

    /// The SVG rx attribute defines a radius on the x-axis.
    ///
    /// Two elements are using this attribute: <ellipse>, and <rect>
    static member inline rx (value: ICssUnit): JSX.Prop = "rx", box(Util.asString value)
    /// The SVG rx attribute defines a radius on the x-axis.
    ///
    /// Two elements are using this attribute: <ellipse>, and <rect>
    static member inline rx (value: int): JSX.Prop = "rx", box(Util.asString value)

    /// The SVG ry attribute defines a radius on the y-axis.
    ///
    /// Two elements are using this attribute: <ellipse>, and <rect>
    static member inline ry (value: ICssUnit): JSX.Prop = "ry", box(Util.asString value)
    /// The SVG ry attribute defines a radius on the y-axis.
    ///
    /// Two elements are using this attribute: <ellipse>, and <rect>
    static member inline ry (value: int): JSX.Prop = "ry", box(Util.asString value)

    /// Applies extra restrictions to the content in the frame.
    ///
    /// The value of the attribute can either be empty to apply all restrictions,
    /// or space-separated tokens to lift particular restrictions
    static member inline sandbox (values: #seq<string>): JSX.Prop = "sandbox", box(values |> String.concat " ")

    /// Defines the displacement scale factor to be used on a <feDisplacementMap> filter primitive.
    ///
    /// The amount is expressed in the coordinate system established by the primitiveUnits attribute
    /// on the <filter> element.
    static member inline scale (value: float): JSX.Prop = "scale", box(Util.asString value)
    /// Defines the displacement scale factor to be used on a <feDisplacementMap> filter primitive.
    ///
    /// The amount is expressed in the coordinate system established by the primitiveUnits attribute
    /// on the <filter> element.
    static member inline scale (value: int): JSX.Prop = "scale", box(Util.asString value)

    /// Represents the starting number for the pseudo random number generator of the <feTurbulence>
    /// filter primitive.
    static member inline seed (value: float): JSX.Prop = "seed", box(Util.asString value)
    /// Represents the starting number for the pseudo random number generator of the <feTurbulence>
    /// filter primitive.
    static member inline seed (value: int): JSX.Prop = "seed", box(Util.asString value)

    /// Defines a value which will be selected on page load.
    static member inline selected (value: bool): JSX.Prop = "selected", value

    /// Sets the beginning index of the selected text.
    ///
    /// When nothing is selected, this returns the position of the text input cursor (caret) inside of the <input> element.
    static member inline selectionStart (value: int): JSX.Prop = "selectionStart", box(Util.asString value)

    /// Sets the end index of the selected text.
    ///
    /// When there's no selection, this returns the offset of the character immediately following the current text input cursor position.
    static member inline selectionEnd (value: int): JSX.Prop = "selectionStart", box(Util.asString value)

    /// Sets the *visual* size of the control.
    ///
    /// The value is in pixels unless the value of type is text or password, in which case, it is the number of characters.
    ///
    /// This attribute only applies when type is set to text, search, tel, url, email, or password.
    static member inline size (value: int): JSX.Prop = "size", box(Util.asString value)

    /// Defines the sizes of the icons for visual media contained in the resource.
    /// It must be present only if the rel contains a value of icon or a non-standard
    /// type such as Apple's apple-touch-icon.
    ///
    /// It may have the following values:
    ///
    /// `any`, meaning that the icon can be scaled to any size as it is in a vector
    /// format, like image/svg+xml.
    ///
    /// A white-space separated list of sizes, each in the format `<width in pixels>x<height in pixels>`
    /// or `<width in pixels>X<height in pixels>`. Each of these sizes must be contained in the resource.
    static member inline sizes (value: string): JSX.Prop = "sizes", value

    /// This attribute contains a positive integer indicating the number of consecutive
    /// columns the <col> element spans. If not present, its default value is 1.
    static member inline spam (value: int): JSX.Prop = "span", box(Util.asString value)

    /// Defines whether the element may be checked for spelling errors.
    static member inline spellcheck (value: bool): JSX.Prop = "spellcheck", value

    /// Controls the ratio of reflection of the specular lighting.
    ///
    /// It represents the ks value in the Phong lighting model. The bigger the value the stronger the reflection.
    static member inline specularConstant (value: float): JSX.Prop = "specularConstant", box(Util.asString value)
    /// Controls the ratio of reflection of the specular lighting.
    ///
    /// It represents the ks value in the Phong lighting model. The bigger the value the stronger the reflection.
    static member inline specularConstant (value: int): JSX.Prop = "specularConstant", box(Util.asString value)

    /// For <feSpecularLighting>, specularExponent defines the exponent value for the specular term.
    ///
    /// For <feSpotLight>, specularExponent defines the exponent value controlling the focus for the light source.
    static member inline specularExponent (value: float): JSX.Prop = "specularExponent", box(Util.asString value)
    /// For <feSpecularLighting>, specularExponent defines the exponent value for the specular term.
    ///
    /// For <feSpotLight>, specularExponent defines the exponent value controlling the focus for the light source.
    static member inline specularExponent (value: int): JSX.Prop = "specularExponent", box(Util.asString value)

    /// The URL of the embeddable content.
    static member inline src (value: string): JSX.Prop = "src", value

    /// Language of the track text data. It must be a valid BCP 47 language tag.
    ///
    /// If the kind attribute is set to subtitles, then srclang must be defined.
    static member inline srcLang (value: string): JSX.Prop = "srclang", value

    /// One or more responsive image candidates.
    static member inline srcset (value: string): JSX.Prop = "srcset", value

    /// Defines the first number if other than 1.
    static member inline start (value: string): JSX.Prop = "start", value

    /// Defines the standard deviation for the blur operation.
    static member inline stdDeviation (value: float): JSX.Prop = "stdDeviation", box(Util.asString value)
    /// Defines the standard deviation for the blur operation.
    static member inline stdDeviation (value: int): JSX.Prop = "stdDeviation", box(Util.asString value)
    /// Defines the standard deviation for the blur operation.
    static member inline stdDeviation (xAxis: float, yAxis: float): JSX.Prop = "stdDeviation", box(Util.asString xAxis  + "," + Util.asString yAxis)
    /// Defines the standard deviation for the blur operation.
    static member inline stdDeviation (xAxis: int, yAxis: int): JSX.Prop = "stdDeviation", box(Util.asString xAxis  + "," + Util.asString yAxis)

    /// Indicates the stepping interval.
    static member inline step (value: float): JSX.Prop = "step", box(Util.asString value)
    /// Indicates the stepping interval.
    static member inline step (value: int): JSX.Prop = "step", box(Util.asString value)
    /// The slot global attribute assigns a slot in a shadow DOM shadow tree to an element: An element with a slot attribute is assigned to the slot created by the slot element whose name attribute's value matches that slot attribute's value.
    static member inline slot(value: string): JSX.Prop = "slot", value
    /// SVG attribute to indicate what color to use at a gradient stop.
    static member inline stopColor (value: string): JSX.Prop = "stop-color", value

    /// SVG attribute to define the opacity of a given color gradient stop.
    static member inline stopOpacity (value: float): JSX.Prop = "stop-opacity", box(Util.asString value)
    /// SVG attribute to define the opacity of a given color gradient stop.
    static member inline stopOpacity (value: int): JSX.Prop = "stop-opacity", box(Util.asString value)

    /// Represents the ideal vertical position of the strikethrough.
    ///
    /// The strikethrough position is expressed in the font's coordinate system.
    static member inline strikethroughPosition (value: float): JSX.Prop = "strikethrough-position", box(Util.asString value)
    /// Represents the ideal vertical position of the strikethrough.
    ///
    /// The strikethrough position is expressed in the font's coordinate system.
    static member inline strikethroughPosition (value: int): JSX.Prop = "strikethrough-position", box(Util.asString value)

    /// Represents the ideal vertical position of the strikethrough.
    ///
    /// The strikethrough position is expressed in the font's coordinate system.
    static member inline strikethroughThickness (value: float): JSX.Prop = "strikethrough-thickness", box(Util.asString value)
    /// Represents the ideal thickness of the strikethrough.
    ///
    /// The strikethrough thickness is expressed in the font's coordinate system.
    static member inline strikethroughThickness (value: int): JSX.Prop = "strikethrough-thickness", box(Util.asString value)

    /// SVG attribute to define the color (or any SVG paint servers like gradients or patterns) used to paint the outline of the shape.
    static member inline stroke (color: string): JSX.Prop = "stroke", color

    /// SVG attribute to define the width of the stroke to be applied to the shape.
    static member inline strokeWidth (value: ICssUnit): JSX.Prop = "stroke-width", box(Util.asString value)
    /// SVG attribute to define the width of the stroke to be applied to the shape.
    static member inline strokeWidth (value: int): JSX.Prop = "stroke-width", box(Util.asString value + "px")

    static member inline style (css: string): JSX.Prop = "style", css
    // static member inline style (properties: #IStyleAttribute list): JSX.Prop = "style", box(createObj !!properties)

    /// Represents the height of the surface for a light filter primitive.
    static member inline surfaceScale (value: float): JSX.Prop = "surfaceScale", box(Util.asString value)
    /// Represents the height of the surface for a light filter primitive.
    static member inline surfaceScale (value: int): JSX.Prop = "surfaceScale", box(Util.asString value)

    /// Represents a list of supported language tags.
    ///
    /// This list is matched against the language defined in the user preferences.
    static member inline systemLanguage (value: string): JSX.Prop = "systemLanguage", value

    /// The `tabindex` global attribute indicates that its element can be focused,
    /// and where it participates in sequential keyboard navigation (usually with the Tab key, hence the name).
    static member inline tabIndex (index: int): JSX.Prop = "tabindex", box(Util.asString index)

    /// Controls browser behavior when opening a link.
    static member inline target (frameName: string): JSX.Prop = "target", frameName

    /// Determines the positioning in horizontal direction of the convolution matrix relative to a
    /// given target pixel in the input image.
    ///
    /// The leftmost column of the matrix is column number zero.
    ///
    /// The value must be such that:
    ///
    /// 0 <= targetX < orderX.
    static member inline targetX (index: int): JSX.Prop = "targetX", box(Util.asString index)

    /// Determines the positioning in vertical direction of the convolution matrix relative to a
    /// given target pixel in the input image.
    ///
    /// The topmost row of the matrix is row number zero.
    ///
    /// The value must be such that:
    ///
    /// 0 <= targetY < orderY.
    static member inline targetY (index: int): JSX.Prop = "targetY", box(Util.asString index)

    /// A shorthand for using custom("data-testid", value). Useful for referencing elements when testing code.
    static member inline testId(value: string): JSX.Prop = "data-testid", value

    // /// Defines the text content of the element. Alias for `children [ Html.text (sprintf ...) ]`
    // static member inline textf fmt = Printf.kprintf prop.text fmt

    /// Specifies the width of the space into which the text will draw.
    ///
    /// The user agent will ensure that the text does not extend farther than that distance, using the method or methods
    /// specified by the lengthAdjust attribute.
    static member inline textLength (value: ICssUnit): JSX.Prop = "textLength", box(Util.asString value)
    /// Specifies the width of the space into which the text will draw.
    ///
    /// The user agent will ensure that the text does not extend farther than that distance, using the method or methods
    /// specified by the lengthAdjust attribute.
    static member inline textLength (value: int): JSX.Prop = "textLength", box(Util.asString value)

    /// The title global attribute contains text representing advisory information related to the element it belongs to.
    static member inline title (value: string): JSX.Prop = "title", value

    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline to' (value: float): JSX.Prop = "to", box(Util.asString value)
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline to' (values: seq<float>): JSX.Prop = "to", box(values |> Seq.map Util.asString |> String.concat " ")
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline to' (value: int): JSX.Prop = "to", box(Util.asString value)
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline to' (values: seq<int>): JSX.Prop = "to", box(values |> Seq.map Util.asString |> String.concat " ")
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline to' (value: string): JSX.Prop = "to", value
    /// Indicates the initial value of the attribute that will be modified during the animation.
    ///
    /// When used with the `to` attribute, the animation will change the modified attribute from
    /// the from value to the to value.
    ///
    /// When used with the `by` attribute, the animation will change the attribute relatively
    /// from the from value by the value specified in by.
    static member inline to' (values: seq<string>): JSX.Prop = "to", box(values |> String.concat " ")

    /// Defines a list of transform definitions that are applied to an element and the element's children.
    static member inline transform (transform: ITransformProperty): JSX.Prop =
        "transform", box(Util.asString transform)
    /// Defines a list of transform definitions that are applied to an element and the element's children.
    static member inline transform (transforms: seq<ITransformProperty>): JSX.Prop =
        "transform", box(
            transforms
            |> Seq.map Util.asString
            |> Seq.map (fun s ->
                List.fold (fun (ins:string) toReplace -> ins.Replace(toReplace,"")) s [ "px" ; "deg" ]
            ) |> String.concat " ")

    /// Sets the `type` attribute for the element.
    static member inline type' (value: string): JSX.Prop = "type", value

    /// Represents the ideal vertical position of the underline.
    ///
    /// The underline position is expressed in the font's coordinate system.
    static member inline underlinePosition (value: float): JSX.Prop = "underline-position", box(Util.asString value)
    /// Represents the ideal vertical position of the underline.
    ///
    /// The underline position is expressed in the font's coordinate system.
    static member inline underlinePosition (value: int): JSX.Prop = "underline-position", box(Util.asString value)

    /// Represents the ideal thickness of the underline.
    ///
    /// The underline thickness is expressed in the font's coordinate system.
    static member inline underlineThickness (value: float): JSX.Prop = "underline-thickness", box(Util.asString value)
    /// Represents the ideal thickness of the underline.
    ///
    /// The underline thickness is expressed in the font's coordinate system.
    static member inline underlineThickness (value: int): JSX.Prop = "underline-thickness", box(Util.asString value)

    /// A hash-name reference to a <map> element; that is a '#' followed by the value of a name of a map element.
    static member inline usemap (value: string): JSX.Prop = "usemap", value

    static member inline value (value: string): JSX.Prop = "value", value

    /// The values attribute has different meanings, depending upon the context where itʼs used,
    /// either it defines a sequence of values used over the course of an animation, or itʼs a
    /// list of numbers for a color matrix, which is interpreted differently depending on the
    /// type of color change to be performed. See: https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/values
    static member inline values (value: string): JSX.Prop = "values", value

    /// Specifies the width of elements listed here. For all other elements, use the CSS height property.
    ///
    /// HTML: <canvas>, <embed>, <iframe>, <img>, <input>, <object>, <video>
    ///
    /// SVG: <feBlend>, <feColorMatrix>, <feComponentTransfer>, <feComposite>, <feConvolveMatrix>,
    /// <feDiffuseLighting>, <feDisplacementMap>, <feDropShadow>, <feFlood>, <feGaussianBlur>, <feImage>,
    /// <feMerge>, <feMorphology>, <feOffset>, <feSpecularLighting>, <feTile>, <feTurbulence>, <filter>,
    /// <mask>, <pattern>
    static member inline width (value: ICssUnit): JSX.Prop = "width", box(Util.asString value)
    /// Specifies the width of elements listed here. For all other elements, use the CSS height property.
    ///
    /// HTML: <canvas>, <embed>, <iframe>, <img>, <input>, <object>, <video>
    ///
    /// SVG: <feBlend>, <feColorMatrix>, <feComponentTransfer>, <feComposite>, <feConvolveMatrix>,
    /// <feDiffuseLighting>, <feDisplacementMap>, <feDropShadow>, <feFlood>, <feGaussianBlur>, <feImage>,
    /// <feMerge>, <feMorphology>, <feOffset>, <feSpecularLighting>, <feTile>, <feTurbulence>, <filter>,
    /// <mask>, <pattern>
    static member inline width (value: int): JSX.Prop = "width", box(Util.asString value)

    /// SVG attribute to define a x-axis coordinate in the user coordinate system.
    static member inline x (value: ICssUnit): JSX.Prop = "x", box(Util.asString value)
    /// SVG attribute to define a x-axis coordinate in the user coordinate system.
    static member inline x (value: int): JSX.Prop = "x", box(Util.asString value)

    /// The x1 attribute is used to specify the first x-coordinate for drawing an SVG element that
    /// requires more than one coordinate. Elements that only need one coordinate use the x attribute instead.
    ///
    /// Two elements are using this attribute: <line>, and <linearGradient>
    static member inline x1 (value: ICssUnit): JSX.Prop = "x1", box(Util.asString value)
    /// The x1 attribute is used to specify the first x-coordinate for drawing an SVG element that
    /// requires more than one coordinate. Elements that only need one coordinate use the x attribute instead.
    ///
    /// Two elements are using this attribute: <line>, and <linearGradient>
    static member inline x1 (value: int): JSX.Prop = "x1", box(Util.asString value)

    /// The x2 attribute is used to specify the second x-coordinate for drawing an SVG element that requires
    /// more than one coordinate. Elements that only need one coordinate use the x attribute instead.
    ///
    /// Two elements are using this attribute: <line>, and <linearGradient>
    static member inline x2 (value: ICssUnit): JSX.Prop = "x2", box(Util.asString value)
    /// The x2 attribute is used to specify the second x-coordinate for drawing an SVG element that requires
    /// more than one coordinate. Elements that only need one coordinate use the x attribute instead.
    ///
    /// Two elements are using this attribute: <line>, and <linearGradient>
    static member inline x2 (value: int): JSX.Prop = "x2", box(Util.asString value)

    /// Specifies the XML Namespace of the document.
    ///
    /// Default value is "http://www.w3.org/1999/xhtml".
    ///
    /// This is required in documents parsed with XML parsers, and optional in text/html documents.
    static member inline xmlns (value: string): JSX.Prop = "xmlns", value

    /// SVG attribute to define a y-axis coordinate in the user coordinate system.
    static member inline y (value: ICssUnit): JSX.Prop = "y", box(Util.asString value)
    /// SVG attribute to define a y-axis coordinate in the user coordinate system.
    static member inline y (value: int): JSX.Prop = "y", box(Util.asString value)

    /// The y1 attribute is used to specify the first y-coordinate for drawing an SVG element that requires
    /// more than one coordinate. Elements that only need one coordinate use the y attribute instead.
    ///
    /// Two elements are using this attribute: <line>, and <linearGradient>
    static member inline y1 (value: ICssUnit): JSX.Prop = "y1", box(Util.asString value)
    /// The y1 attribute is used to specify the first y-coordinate for drawing an SVG element that requires
    /// more than one coordinate. Elements that only need one coordinate use the y attribute instead.
    ///
    /// Two elements are using this attribute: <line>, and <linearGradient>
    static member inline y1 (value: int): JSX.Prop = "y1", box(Util.asString value)

    /// The y2 attribute is used to specify the second y-coordinate for drawing an SVG element that requires
    /// more than one coordinate. Elements that only need one coordinate use the y attribute instead.
    ///
    /// Two elements are using this attribute: <line>, and <linearGradient>
    static member inline y2 (value: ICssUnit): JSX.Prop = "y2", box(Util.asString value)
    /// The y2 attribute is used to specify the second y-coordinate for drawing an SVG element that requires
    /// more than one coordinate. Elements that only need one coordinate use the y attribute instead.
    ///
    /// Two elements are using this attribute: <line>, and <linearGradient>
    static member inline y2 (value: int): JSX.Prop = "y2", box(Util.asString value)

    /// Defines the location along the z-axis for a light source in the coordinate system established by the
    /// primitiveUnits attribute on the <filter> element, assuming that, in the initial coordinate system,
    /// the positive z-axis comes out towards the person viewing the content and assuming that one unit along
    /// the z-axis equals one unit in x and y.
    static member inline z (value: ICssUnit): JSX.Prop = "z", box(Util.asString value)
    /// Defines the location along the z-axis for a light source in the coordinate system established by the
    /// primitiveUnits attribute on the <filter> element, assuming that, in the initial coordinate system,
    /// the positive z-axis comes out towards the person viewing the content and assuming that one unit along
    /// the z-axis equals one unit in x and y.
    static member inline z (value: int): JSX.Prop = "z", box(Util.asString value)

    /// Specifies that repeat iterations are not cumulative.
    static member inline accumulateNone: JSX.Prop = "accumulate", "none"
    /// Specifies that each repeat iteration after the first builds upon
    /// the last value of the previous iteration.
    static member inline accumulateSum: JSX.Prop = "accumulate", "sum"

    /// Specifies that the animation will override the underlying value of
    /// the attribute and other lower priority animations.
    static member inline additiveReplace: JSX.Prop = "additive", "replace"
    /// Specifies that the animation will add to the underlying value of
    /// the attribute and other lower priority animations.
    static member inline additiveSum: JSX.Prop = "additive", "sum"

    /// Uses the dominant baseline choice of the parent. Matches the box’s
    /// corresponding baseline to that of its parent.
    static member inline alignmentBaselineAlphabetic: JSX.Prop = "alignment-baseline", "alphabetic"
    /// Uses the dominant baseline choice of the parent. Matches the box’s
    /// corresponding baseline to that of its parent.
    static member inline alignmentBaselineBaseline: JSX.Prop = "alignment-baseline", "baseline"
    /// Uses the dominant baseline choice of the parent. Matches the box’s
    /// corresponding baseline to that of its parent.
    static member inline alignmentBaselineBottom: JSX.Prop = "alignment-baseline", "bottom"
    /// Specifies that the animation will add to the underlying value of
    /// the attribute and other lower priority animations.
    static member inline alignmentBaselineCenter: JSX.Prop = "alignment-baseline", "center"
    /// Uses the dominant baseline choice of the parent. Matches the box’s
    /// corresponding baseline to that of its parent.
    static member inline alignmentBaselineCentral: JSX.Prop = "alignment-baseline", "central"
    /// Specifies that the animation will add to the underlying value of
    /// the attribute and other lower priority animations.
    static member inline alignmentBaselineHanging: JSX.Prop = "alignment-baseline", "hanging"
    /// Specifies that the animation will add to the underlying value of
    /// the attribute and other lower priority animations.
    static member inline alignmentBaselineIdeographic: JSX.Prop = "alignment-baseline", "ideographic"
    /// Uses the dominant baseline choice of the parent. Matches the box’s
    /// corresponding baseline to that of its parent.
    static member inline alignmentBaselineMathematical: JSX.Prop = "alignment-baseline", "mathematical"
    /// Specifies that the animation will add to the underlying value of
    /// the attribute and other lower priority animations.
    static member inline alignmentBaselineMiddle: JSX.Prop = "alignment-baseline", "middle"
    /// Uses the dominant baseline choice of the parent. Matches the box’s
    /// corresponding baseline to that of its parent.
    static member inline alignmentBaselineTextAfterEdge: JSX.Prop = "alignment-baseline", "text-after-edge"
    /// Uses the dominant baseline choice of the parent. Matches the box’s
    /// corresponding baseline to that of its parent.
    static member inline alignmentBaselineTextBeforeEdge: JSX.Prop = "alignment-baseline", "text-before-edge"
    /// Specifies that the animation will add to the underlying value of
    /// the attribute and other lower priority animations.
    static member inline alignmentBaselineTextBottom: JSX.Prop = "alignment-baseline", "text-bottom"
    /// Specifies that the animation will add to the underlying value of
    /// the attribute and other lower priority animations.
    static member inline alignmentBaselineTextTop: JSX.Prop = "alignment-baseline", "text-top"
    /// Specifies that the animation will add to the underlying value of
    /// the attribute and other lower priority animations.
    static member inline alignmentBaselineTop: JSX.Prop = "alignment-baseline", "top"

    /// Controls whether the current document is allowed to gather information about the acceleration of
    /// the device through the Accelerometer interface.
    static member inline allowAccelerometer: JSX.Prop = "allow", "accelerometer"
    /// Controls whether the current document is allowed to gather information about the amount of light
    /// in the environment around the device through the AmbientLightSensor interface.
    static member inline allowAmbientLightSensor: JSX.Prop = "allow", "ambient-light-sensor"
    /// Controls whether the current document is allowed to autoplay media requested through the
    /// HTMLMediaElement interface.
    ///
    /// When this policy is disabled and there were no user gestures, the Promise returned by
    /// HTMLMediaElement.play() will reject with a DOMException. The autoplay attribute on <audio> and
    /// <video> elements will be ignored.
    static member inline allowAutoplay: JSX.Prop = "allow", "autoplay"
    /// Controls whether the use of the Battery Status API is allowed.
    ///
    /// When this policy is disabled, the  Promise returned by Navigator.getBattery() will reject with
    /// a NotAllowedError DOMException.
    static member inline allowBattery: JSX.Prop = "allow", "battery"
    /// Controls whether the current document is allowed to use video input devices.
    ///
    /// When this policy is disabled, the Promise returned by getUserMedia() will reject with a
    /// NotAllowedError DOMException.
    static member inline allowCamera: JSX.Prop = "allow", "camera"
    /// Controls whether or not the current document is permitted to use the getDisplayMedia() method to
    /// capture screen contents.
    ///
    /// When this policy is disabled, the promise returned by getDisplayMedia() will reject with a
    /// NotAllowedError if permission is not obtained to capture the display's contents.
    static member inline allowDisplayCapture: JSX.Prop = "allow", "display-capture"
    /// Controls whether the current document is allowed to set document.domain.
    ///
    /// When this policy is disabled, attempting to set document.domain will fail and cause a SecurityError
    /// DOMException to be be thrown.
    static member inline allowDocumentDomain: JSX.Prop = "allow", "document-domain"
    /// Controls whether the current document is allowed to use the Encrypted Media Extensions API (EME).
    ///
    /// When this policy is disabled, the Promise returned by Navigator.requestMediaKeySystemAccess() will
    /// reject with a DOMException.
    static member inline allowEncryptedMedia: JSX.Prop = "allow", "encrypted-media"
    /// Controls whether tasks should execute in frames while they're not being rendered (e.g. if an iframe
    /// is hidden or display: none).
    static member inline allowExecutionWhileNotRendered: JSX.Prop = "allow", "execution-while-not-rendered"
    /// Controls whether tasks should execute in frames while they're outside of the visible viewport.
    static member inline allowExecutionWhileOutOfViewport: JSX.Prop = "allow", "execution-while-out-of-viewport"
    /// Controls whether the current document is allowed to use Element.requestFullScreen().
    ///
    /// When this policy is disabled, the returned Promise rejects with a TypeError DOMException.
    static member inline allowFullscreen: JSX.Prop = "allow", "fullscreen"
    /// Controls whether the current document is allowed to use the Geolocation Interface.
    ///
    /// When this policy is disabled, calls to getCurrentPosition() and watchPosition() will cause those
    /// functions' callbacks to be invoked with a PositionError code of PERMISSION_DENIED.
    static member inline allowGeolocation: JSX.Prop = "allow", "geolocation"
    /// Controls whether the current document is allowed to gather information about the orientation of the
    /// device through the Gyroscope interface.
    static member inline allowGyroscope: JSX.Prop = "allow", "gyroscope"
    /// Controls whether the current document is allowed to show layout animations.
    static member inline allowLayoutAnimations: JSX.Prop = "allow", "layout-animations"
    /// Controls whether the current document is allowed to display images in legacy formats.
    static member inline allowLegacyImageFormats: JSX.Prop = "allow", "legacy-image-formats"
    /// Controls whether the current document is allowed to gather information about the orientation of the
    /// device through the Magnetometer interface.
    static member inline allowMagnetometer: JSX.Prop = "allow", "magnetometer"
    /// Controls whether the current document is allowed to use audio input devices.
    ///
    /// When this policy is disabled, the Promise returned by MediaDevices.getUserMedia() will reject
    /// with a NotAllowedError.
    static member inline allowMicrophone: JSX.Prop = "allow", "microphone"
    /// Controls whether the current document is allowed to use the Web MIDI API.
    ///
    /// When this policy is disabled, the Promise returned by Navigator.requestMIDIAccess() will reject
    /// with a DOMException.
    static member inline allowMidi: JSX.Prop = "allow", "midi"
    /// Controls the availability of mechanisms that enables the page author to take control over the behavior
    /// of spatial navigation, or to cancel it outright.
    static member inline allowNavigationOverride: JSX.Prop = "allow", "navigation-override"
    /// Controls whether the current document is allowed to download and display large images.
    static member inline allowOversizedImages: JSX.Prop = "allow", "oversized-images"
    /// Controls whether the current document is allowed to use the Payment Request API.
    ///
    /// When this policy is enabled, the PaymentRequest() constructor will throw a SecurityError DOMException.
    static member inline allowPayment: JSX.Prop = "allow", "payment"
    /// Controls whether the current document is allowed to play a video in a Picture-in-Picture mode via
    /// the corresponding API.
    static member inline allowPictureInPicture: JSX.Prop = "allow", "picture-in-picture"
    /// Controls whether the current document is allowed to use the Web Authentication API to create, store,
    /// and retreive public-key credentials.
    static member inline allowPublickeyCredentials: JSX.Prop = "allow", "publickey-credentials"
    /// Controls whether the current document is allowed to make synchronous XMLHttpRequest requests.
    static member inline allowSyncXhr: JSX.Prop = "allow", "sync-xhr"
    /// Controls whether the current document is allowed to use the WebUSB API.
    static member inline allowUsb: JSX.Prop = "allow", "usb"
    /// Controls whether the current document is allowed to use Wake Lock API to indicate that
    /// device should not enter power-saving mode.
    static member inline allowWakeLock: JSX.Prop = "allow", "wake-lock"
    /// Controls whether or not the current document is allowed to use the WebXR Device API to interact
    /// with a WebXR session.
    static member inline allowXrSpatialTracking: JSX.Prop = "allow", "xr-spatial-tracking"

    /// A list of choices appears and the currently selected suggestion also
    /// appears inline.
    static member inline ariaAutocompleteBoth: JSX.Prop = "aria-autocomplete", "both"
    /// The system provides text after the caret as a suggestion for how to
    /// complete the field.
    static member inline ariaAutocompleteInlinedAfterCaret: JSX.Prop = "aria-autocomplete", "inline"
    /// A list of choices appears from which the user can choose.
    static member inline ariaAutocompleteList: JSX.Prop = "aria-autocomplete", "list"
    /// No input completion suggestions are provided.
    static member inline ariaAutocompleteNone: JSX.Prop = "aria-autocomplete", "none"

    /// Indicates a mixed mode value for a tri-state checkbox or
    /// `menuitemcheckbox`.
    static member inline ariaCheckedMixed: JSX.Prop = "aria-checked", "mixed"

    /// A duplicate of the source object will be dropped into the target.
    static member inline ariaDropEffectCopy: JSX.Prop = "aria-dropeffect", "copy"
    /// A function supported by the drop target is executed, using the drag
    /// source as an input.
    static member inline ariaDropEffectExecute: JSX.Prop = "aria-dropeffect", "execute"
    /// A reference or shortcut to the dragged object will be created in the
    /// target object.
    static member inline ariaDropEffectLink: JSX.Prop = "aria-dropeffect", "link"
    /// The source object will be removed from its current location and
    /// dropped into the target.
    static member inline ariaDropEffectMove: JSX.Prop = "aria-dropeffect", "move"
    /// No operation can be performed; effectively cancels the drag
    /// operation if an attempt is made to drop on this object. Ignored if
    /// combined with any other token value. e.g. 'none copy' is equivalent
    /// to a 'copy' value.
    static member inline ariaDropEffectNone: JSX.Prop = "aria-dropeffect", "none"
    /// There is a popup menu or dialog that allows the user to choose one
    /// of the drag operations (copy, move, link, execute) and any other
    /// drag functionality, such as cancel.
    static member inline ariaDropEffectPopup: JSX.Prop = "aria-dropeffect", "popup"

    /// A grammatical error was detected.
    static member inline ariaInvalidGrammar: JSX.Prop = "aria-invalid", "grammar"
    /// A spelling error was detected.
    static member inline ariaInvalidSpelling: JSX.Prop = "aria-invalid", "spelling"

    /// Indicates that updates to the region have the highest priority and
    /// should be presented the user immediately.
    static member inline ariaLiveAssertive: JSX.Prop = "aria-live", "assertive"
    /// Indicates that updates to the region should not be presented to the
    /// user unless the used is currently focused on that region.
    static member inline ariaLiveOff: JSX.Prop = "aria-live", "off"
    /// Indicates that updates to the region should be presented at the next
    /// graceful opportunity, such as at the end of speaking the current
    /// sentence or when the user pauses typing.
    static member inline ariaLivePolite: JSX.Prop = "aria-live", "polite"

    /// The element is oriented horizontally.
    static member inline ariaOrientationHorizontal: JSX.Prop = "aria-orientation", "horizontal"
    /// The element is oriented vertically.
    static member inline ariaOrientationVertical: JSX.Prop = "aria-orientation", "vertical"

    /// Indicates a mixed mode value for a tri-state toggle button.
    static member inline ariaPressedMixed: JSX.Prop = "aria-pressed", "mixed"

    /// Element nodes are added to the DOM within the live region.
    static member inline ariaRelevantAdditions: JSX.Prop = "aria-relevant", "additions"
    /// Equivalent to the combination of all values, "additions removals
    /// text".
    static member inline ariaRelevantAll: JSX.Prop = "aria-relevant", "all"
    /// Text or element nodes within the live region are removed from the
    /// DOM.
    static member inline ariaRelevantRemovals: JSX.Prop = "aria-relevant", "removals"
    /// Text is added to any DOM descendant nodes of the live region.
    static member inline ariaRelevantText: JSX.Prop = "aria-relevant", "text"

    /// Items are sorted in ascending order by this column.
    static member inline ariaSortAscending: JSX.Prop = "aria-sort", "ascending"
    /// Items are sorted in descending order by this column.
    static member inline ariaSortDescending: JSX.Prop = "aria-sort", "descending"
    /// There is no defined sort applied to the column.
    static member inline ariaSortNone: JSX.Prop = "aria-sort", "none"
    /// A sort algorithm other than ascending or descending has been
    /// applied.
    static member inline ariaSortOther: JSX.Prop = "aria-sort", "other"

    /// Applies to <audio> elements.
    static member inline asAudio: JSX.Prop = "as", "audio"
    /// Applies to <iframe> and <frame> elements.
    static member inline asDocument: JSX.Prop = "as", "document"
    /// Applies to <embed> elements.
    static member inline asEmbed: JSX.Prop = "as", "embed"
    /// Applies to fetch and XHR.
    ///
    /// This value also requires <link> to contain the crossorigin attribute.
    static member inline asFetch: JSX.Prop = "as", "fetch"
    /// Applies to CSS @font-face.
    static member inline asFont: JSX.Prop = "as", "font"
    /// Applies to <img> and <picture> elements with srcset or imageset attributes,
    /// SVG <image> elements, and CSS *-image rules.
    static member inline asImage: JSX.Prop = "as", "image"
    /// Applies to <object> elements.
    static member inline asObject: JSX.Prop = "as", "object"
    /// Applies to <script> elements, Worker importScripts.
    static member inline asScript: JSX.Prop = "as", "script"
    /// Applies to <link rel=stylesheet> elements, and CSS @import.
    static member inline asStyle: JSX.Prop = "as", "style"
    /// Applies to <track> elements.
    static member inline asTrack: JSX.Prop = "as", "track"
    /// Applies to <video> elements.
    static member inline asVideo: JSX.Prop = "as", "video"
    /// Applies to Worker and SharedWorker.
    static member inline asWorker: JSX.Prop = "as", "worker"

    /// All letters should default to uppercase
    static member inline autoCapitalizeCharacters: JSX.Prop = "autocapitalize", "characters"
    /// No autocapitalization is applied (all letters default to lowercase)
    static member inline autoCapitalizeOff: JSX.Prop = "autocapitalize", "off"
    /// The first letter of each sentence defaults to a capital letter; all other letters default to lowercase
    static member inline autoCapitalizeOn': JSX.Prop = "autocapitalize", "on"
    /// The first letter of each word defaults to a capital letter; all other letters default to lowercase
    static member inline autoCapitalizeWords: JSX.Prop = "autocapitalize", "words"

    /// Specifies that the animation function will jump from one value to the next
    /// without any interpolation.
    static member inline calcModeDiscrete: JSX.Prop = "calcMode", "discrete"
    /// Simple linear interpolation between values is used to calculate the animation
    /// function. Except for <animateMotion>, this is the default value.
    static member inline calcModeLinear: JSX.Prop = "calcMode", "linear"
    /// Defines interpolation to produce an even pace of change across the animation.
    ///
    /// This is only supported for values that define a linear numeric range, and for
    /// which some notion of "distance" between points can be calculated (e.g. position,
    /// width, height, etc.).
    ///
    /// If paced is specified, any keyTimes or keySplines will be ignored.
    ///
    /// For <animateMotion>, this is the default value.
    static member inline calcModePaced: JSX.Prop = "calcMode", "paced"
    /// Interpolates from one value in the values list to the next according to a time
    /// function defined by a cubic Bézier spline.
    ///
    /// The points of the spline are defined in the keyTimes attribute, and the control
    /// points for each interval are defined in the keySplines attribute.
    static member inline calcModeSpline: JSX.Prop = "calcMode", "spline"

    static member inline charsetUtf8: JSX.Prop = "charset", "UTF-8"

    /// Indicates that all coordinates inside the <clipPath> element refer to the user
    /// coordinate system as defined when the clipping path was created.
    static member inline clipPathUserSpaceOnUse: JSX.Prop = "clip-path", "userSpaceOnUse"
    /// Indicates that all coordinates inside the <clipPath> element are relative to
    /// the bounding box of the element the clipping path is applied to.
    ///
    /// It means that the origin of the coordinate system is the top left corner of the
    /// object bounding box and the width and height of the object bounding box are
    /// considered to have a length of 1 unit value.
    static member inline clipPathObjectBoundingBox: JSX.Prop = "clip-path", "objectBoundingBox"

    /// Determines the "insideness" of a point in the shape by drawing a ray from that
    /// point to infinity in any direction and counting the number of path segments
    /// from the given shape that the ray crosses.
    ///
    /// If this number is odd, the point is inside; if even, the point is outside.
    static member inline clipRuleEvenodd: JSX.Prop = "clip-rule", "evenodd"
    static member inline clipRuleInheritFromParent: JSX.Prop = "clip-rule", "inherit"
    /// Determines the "insideness" of a point in the shape by drawing a ray from that
    /// point to infinity in any direction, and then examining the places where a
    /// segment of the shape crosses the ray.
    static member inline clipRuleNonzero: JSX.Prop = "clip-rule", "nonzero"

    /// Indicates that the user agent can choose either the sRGB or linearRGB spaces
    /// for color interpolation. This option indicates that the author doesn't require
    /// that color interpolation occur in a particular color space.
    static member inline colorInterpolationAuto: JSX.Prop = "color-interpolation", "auto"
    /// Indicates that color interpolation should occur in the linearized RGB color
    /// space as described in the sRGB specification.
    static member inline colorInterpolationLinearRGB: JSX.Prop = "color-interpolation", "linearRGB"
    /// Indicates that color interpolation should occur in the sRGB color space.
    static member inline colorInterpolationSRGB: JSX.Prop = "color-interpolation", "sRGB"

    /// Indicates that the user agent can choose either the sRGB or linearRGB spaces
    /// for color interpolation. This option indicates that the author doesn't require
    /// that color interpolation occur in a particular color space.
    static member inline colorInterpolationFiltersAuto: JSX.Prop = "color-interpolation-filters", "auto"
    /// Indicates that color interpolation should occur in the linearized RGB color
    /// space as described in the sRGB specification.
    static member inline colorInterpolationFiltersLinearRGB: JSX.Prop = "color-interpolation-filters", "linearRGB"
    /// Indicates that color interpolation should occur in the sRGB color space.
    static member inline colorInterpolationFiltersSRGB: JSX.Prop = "color-interpolation-filters", "sRGB"

    static member inline coordsRect (left: int, top: int, right: int, bottom: int): JSX.Prop =
        "coords", box((Util.asString left) + "," +
            (Util.asString top) + "," +
            (Util.asString right) + "," +
            (Util.asString bottom))
    static member inline coordsCircle (x: int, y: int, r: int): JSX.Prop =
        "coords", box((Util.asString x) + "," +
            (Util.asString y) + "," +
            (Util.asString r))
    static member inline coordsPoly (x1: int, y1: int, x2: int, y2: int, x3: int, y3: int): JSX.Prop =
        "coords", box((Util.asString x1) + "," +
            (Util.asString y1) + "," +
            (Util.asString x2) + "," +
            (Util.asString y2) + "," +
            (Util.asString x3) + "," +
            (Util.asString y3))

    /// A cross-origin request (i.e. with an Origin HTTP header) is performed, but no credential
    /// is sent (i.e. no cookie, X.509 certificate, or HTTP Basic authentication). If the server
    /// does not give credentials to the origin site (by not setting the Access-Control-Allow-Origin
    /// HTTP header) the resource will be tainted and its usage restricted.
    static member inline crossOriginAnonymous: JSX.Prop = "crossorigin", "anonymous"
    /// A cross-origin request (i.e. with an Origin HTTP header) is performed along with a credential
    /// sent (i.e. a cookie, certificate, and/or HTTP Basic authentication is performed). If the server
    /// does not give credentials to the origin site (through Access-Control-Allow-Credentials HTTP
    /// header), the resource will be tainted and its usage restricted.
    static member inline crossOriginUseCredentials: JSX.Prop = "crossorigin", "use-credentials"

    /// Lets the user agent decide.
    static member inline dirAuto: JSX.Prop = "dir", "auto"
    /// Left to right - for languages that are written from left to right.
    static member inline dirLtr: JSX.Prop = "dir", "ltr"
    /// Right to left - for languages that are written from right to left.
    static member inline dirRtl: JSX.Prop = "dir", "rtl"

    /// The baseline-identifier for the dominant-baseline is set to be alphabetic, the derived baseline-table is constructed
    /// using the alphabetic baseline-table in the font, and the baseline-table font-size is changed to the value of the
    /// font-size attribute on this element.
    static member inline dominantBaselineAlphabetic: JSX.Prop = "dominant-baseline", "alphabetic"
    /// If this property occurs on a <text> element, then the computed value depends on the value of the writing-mode attribute.
    ///
    /// If the writing-mode is horizontal, then the value of the dominant-baseline component is alphabetic, else if the writing-mode
    /// is vertical, then the value of the dominant-baseline component is central.
    ///
    /// If this property occurs on a <tspan>, <tref>,
    /// <altGlyph> or <textPath> element, then the dominant-baseline and the baseline-table components remain the same as those of
    /// the parent text content element.
    ///
    /// If the computed baseline-shift value actually shifts the baseline, then the baseline-table
    /// font-size component is set to the value of the font-size attribute on the element on which the dominant-baseline attribute
    /// occurs, otherwise the baseline-table font-size remains the same as that of the element.
    ///
    /// If there is no parent text content
    /// element, the scaled-baseline-table value is constructed as above for <text> elements.
    static member inline dominantBaselineAuto: JSX.Prop = "dominant-baseline", "auto"
    /// The baseline-identifier for the dominant-baseline is set to be central. The derived baseline-table is constructed from the
    /// defined baselines in a baseline-table in the font. That font baseline-table is chosen using the following priority order of
    /// baseline-table names: ideographic, alphabetic, hanging, mathematical. The baseline-table font-size is changed to the value
    /// of the font-size attribute on this element.
    static member inline dominantBaselineCentral: JSX.Prop = "dominant-baseline", "central"
    /// The baseline-identifier for the dominant-baseline is set to be hanging, the derived baseline-table is constructed using the
    /// hanging baseline-table in the font, and the baseline-table font-size is changed to the value of the font-size attribute on
    /// this element.
    static member inline dominantBaselineHanging: JSX.Prop = "dominant-baseline", "hanging"
    /// The baseline-identifier for the dominant-baseline is set to be ideographic, the derived baseline-table is constructed using
    /// the ideographic baseline-table in the font, and the baseline-table font-size is changed to the value of the font-size
    /// attribute on this element.
    static member inline dominantBaselineIdeographic: JSX.Prop = "dominant-baseline", "ideographic"
    /// The baseline-identifier for the dominant-baseline is set to be mathematical, the derived baseline-table is constructed using
    /// the mathematical baseline-table in the font, and the baseline-table font-size is changed to the value of the font-size
    /// attribute on this element.
    static member inline dominantBaselineMathematical: JSX.Prop = "dominant-baseline", "mathematical"
    /// The baseline-identifier for the dominant-baseline is set to be middle. The derived baseline-table is constructed from the
    /// defined baselines in a baseline-table in the font. That font baseline-table is chosen using the following priority order
    /// of baseline-table names: alphabetic, ideographic, hanging, mathematical. The baseline-table font-size is changed to the value
    /// of the font-size attribute on this element.
    static member inline dominantBaselineMiddle: JSX.Prop = "dominant-baseline", "middle"
    /// The baseline-identifier for the dominant-baseline is set to be text-after-edge. The derived baseline-table is constructed
    /// from the defined baselines in a baseline-table in the font. The choice of which font baseline-table to use from the
    /// baseline-tables in the font is browser dependent. The baseline-table font-size is changed to the value of the font-size
    /// attribute on this element.
    static member inline dominantBaselineTextAfterEdge: JSX.Prop = "dominant-baseline", "text-after-edge"
    /// The baseline-identifier for the dominant-baseline is set to be text-before-edge. The derived baseline-table is constructed
    /// from the defined baselines in a baseline-table in the font. The choice of which baseline-table to use from the baseline-tables
    /// in the font is browser dependent. The baseline-table font-size is changed to the value of the font-size attribute on this element.
    static member inline dominantBaselineTextBeforeEdge: JSX.Prop = "dominant-baseline", "text-before-edge"
    /// This value uses the top of the em box as the baseline.
    static member inline dominantBaselineTextTop: JSX.Prop = "dominant-baseline", "text-top"

    // /// This value specifies the length of the simple duration.
    // static member inline clockValue (duration: System.TimeSpan): JSX.Prop =
    //     PropHelpers.createClockValue(duration)
    //     |> Interop.mkAttr "dur"
    /// This value specifies the simple duration as indefinite.
    static member inline durIndefinite: JSX.Prop = "dur", "indefinite"
    /// This value specifies the simple duration as the intrinsic media duration.
    ///
    /// This is only valid for elements that define media.
    static member inline durMedia: JSX.Prop = "dur", "media"

    /// Indicates that the input image is extended along each of its borders as
    /// necessary by duplicating the color values at the given edge of the input image.
    static member inline edgeModeDuplicate: JSX.Prop = "edgeMode", "duplicate"
    /// Indicates that the input image is extended with pixel values of zero for
    /// R, G, B and A.
    static member inline edgeModeNone: JSX.Prop = "edgeMode", "none"
    /// Indicates that the input image is extended by taking the color values
    /// from the opposite edge of the image.
    static member inline edgeModeWrap: JSX.Prop = "edgeMode", "wrap"

    /// The fill attribute has two different meanings. For shapes and text it's a presentation attribute that defines the color
    /// (or any SVG paint servers like gradients or patterns) used to paint the element; for animation it defines the final state of the animation.
    static member inline fill (color: string): JSX.Prop = "fill", color

    /// Keep the state of the last animation frame.
    static member inline fillFreeze: JSX.Prop = "fill", "freeze"
    /// Keep the state of the first animation frame.
    static member inline fillRemove: JSX.Prop = "fill", "remove"

    /// x, y, width and height represent values in the current coordinate system that results from
    /// taking the current user coordinate system in place at the time when the <filter> element is
    /// referenced (i.e., the user coordinate system for the element referencing the <filter> element
    /// via a filter attribute).
    static member inline filterUnitsUserSpaceOnUse: JSX.Prop = "filterUnits", "userSpaceOnUse"
    /// x, y, width and height represent fractions or percentages of the bounding box on the referencing
    /// element.
    static member inline filterUnitsObjectBoundingBox: JSX.Prop = "filterUnits", "objectBoundingBox"

    /// Indicates that the attributes represent values in the coordinate system that results from
    /// taking the current user coordinate system in place at the time when the gradient element
    /// is referenced (i.e., the user coordinate system for the element referencing the gradient
    /// element via a fill or stroke property) and then applying the transform specified by
    /// attribute gradientTransform.
    ///
    /// Percentages represent values relative to the current SVG viewport.
    static member inline gradientUnitsUserSpaceOnUse: JSX.Prop = "gradientUnits", "userSpaceOnUse"
    /// Indicates that the user coordinate system for the attributes is established using the
    /// bounding box of the element to which the gradient is applied and then applying the
    /// transform specified by attribute gradientTransform.
    ///
    /// Percentages represent values relative to the bounding box for the object.
    static member inline gradientUnitsObjectBoundingBox: JSX.Prop = "gradientUnits", "objectBoundingBox"

    /// Allows page authors to define a content policy for the current page.
    ///
    /// Content policies mostly specify allowed server origins and script endpoints which help guard against cross-site
    /// scripting attacks.
    static member inline httpEquivContentSecurityPolicy: JSX.Prop = "http-equiv", "content-security-policy"
    /// If specified, the content attribute must have the value "text/html; charset=utf-8".
    ///
    /// Note: Can only be used in documents served with a text/html MIME type — not in documents served with an XML MIME type.
    static member inline httpEquivContentType: JSX.Prop = "http-equiv", "content-type"
    /// Sets the name of the default CSS style sheet set.
    static member inline httpEquivDefaultStyle: JSX.Prop = "http-equiv", "default-style"
    /// This instruction specifies:
    ///
    /// The number of seconds until the page should be reloaded - only if the content attribute contains a positive integer.
    ///
    /// The number of seconds until the page should redirect to another - only if the content attribute contains a positive integer followed by the string ';url=', and a valid URL.
    static member inline httpEquivRefresh: JSX.Prop = "http-equiv", "refresh"
    /// If specified, the content attribute must have the value "IE=edge". User agents are required to ignore this pragma.
    static member inline httpEquivXUaCompatible: JSX.Prop = "http-equiv", "x-ua-compatible"

    /// Represents an image snapshot of the SVG document under the filter region at the time that the
    /// <filter> element was invoked, except only the alpha channel is used.
    static member inline inBackgroundAlpha: JSX.Prop = "in", "BackgroundAlpha"
    /// Represents an image snapshot of the SVG document under the filter region at the time that the
    /// <filter> element was invoked.
    static member inline inBackgroundImage: JSX.Prop = "in", "BackgroundImage"
    /// An assigned name for the filter primitive.
    ///
    /// If supplied, then graphics that result from processing this filter primitive can be referenced
    /// by an in attribute on a subsequent filter primitive within the same filter element.
    static member inline inCustom (name: string): JSX.Prop = "in", name
    /// Represents the value of the fill property on the target element for the filter effect.
    ///
    /// In many cases, the FillPaint is opaque everywhere, but that might not be the case if a shape is
    /// painted with a gradient or pattern which itself includes transparent or semi-transparent parts.
    static member inline inFillPaint: JSX.Prop = "in", "FillPaint"
    /// Represents the graphics elements that were the original input into the <filter> element, except
    /// that only the alpha channel is used.
    static member inline inSourceAlpha: JSX.Prop = "in", "SourceAlpha"
    /// Represents the graphics elements that were the original input into the <filter> element.
    static member inline inSourceGraphic: JSX.Prop = "in", "SourceGraphic"
    /// Represents the value of the stroke property on the target element for the filter effect.
    ///
    /// In many cases, the StrokePaint is opaque everywhere, but that might not be the case if a shape
    /// is painted with a gradient or pattern which itself includes transparent or semi-transparent parts.
    static member inline inStrokePaint: JSX.Prop = "in", "StrokePaint"

    /// Represents an image snapshot of the SVG document under the filter region at the time that the
    /// <filter> element was invoked, except only the alpha channel is used.
    static member inline in2BackgroundAlpha: JSX.Prop = "in2", "BackgroundAlpha"
    /// Represents an image snapshot of the SVG document under the filter region at the time that the
    /// <filter> element was invoked.
    static member inline in2BackgroundImage: JSX.Prop = "in2", "BackgroundImage"
    /// An assigned name for the filter primitive.
    ///
    /// If supplied, then graphics that result from processing this filter primitive can be referenced
    /// by an in attribute on a subsequent filter primitive within the same filter element.
    static member inline in2Custom (name: string): JSX.Prop = "in2", name
    /// Represents the value of the fill property on the target element for the filter effect.
    ///
    /// In many cases, the FillPaint is opaque everywhere, but that might not be the case if a shape is
    /// painted with a gradient or pattern which itself includes transparent or semi-transparent parts.
    static member inline in2FillPaint: JSX.Prop = "in2", "FillPaint"
    /// Represents the graphics elements that were the original input into the <filter> element, except
    /// that only the alpha channel is used.
    static member inline in2SourceAlpha: JSX.Prop = "in2", "SourceAlpha"
    /// Represents the graphics elements that were the original input into the <filter> element.
    static member inline in2SourceGraphic: JSX.Prop = "in2", "SourceGraphic"
    /// Represents the value of the stroke property on the target element for the filter effect.
    ///
    /// In many cases, the StrokePaint is opaque everywhere, but that might not be the case if a shape
    /// is painted with a gradient or pattern which itself includes transparent or semi-transparent parts.
    static member inline in2StrokePaint: JSX.Prop = "in2", "StrokePaint"

    static member inline inputModeDecimal: JSX.Prop = "inputmode", "decimal"
    static member inline inputModeEmail: JSX.Prop = "inputmode", "email"
    static member inline inputModeNone: JSX.Prop = "inputmode", "none"
    static member inline inputModeNumeric: JSX.Prop = "inputmode", "numeric"
    static member inline inputModeSearch: JSX.Prop = "inputmode", "search"
    static member inline inputModeTel: JSX.Prop = "inputmode", "tel"
    static member inline inputModeUrl: JSX.Prop = "inputmode", "url"

    /// Subtitles provide translation of content that cannot be understood by the viewer. For example dialogue
    /// or text that is not English in an English language film.
    ///
    /// Subtitles may contain additional content, usually extra background information. For example the text
    /// at the beginning of the Star Wars films, or the date, time, and location of a scene.
    static member inline kindSubtitles: JSX.Prop = "kind", "subtitles"
    /// Closed captions provide a transcription and possibly a translation of audio.
    ///
    /// It may include important non-verbal information such as music cues or sound effects.
    /// It may indicate the cue's source (e.g. music, text, character).
    ///
    /// Suitable for users who are deaf or when the sound is muted.
    static member inline kindCaptions: JSX.Prop = "kind", "captions"
    /// Textual description of the video content.
    ///
    /// Suitable for users who are blind or where the video cannot be seen.
    static member inline kindDescriptions: JSX.Prop = "kind", "descriptions"
    /// Chapter titles are intended to be used when the user is navigating the media resource.
    static member inline kindChapters: JSX.Prop = "kind", "chapters"
    /// Tracks used by scripts. Not visible to the user.
    static member inline kindMetadata: JSX.Prop = "kind", "metadata"

    static member inline lengthAdjustSpacing: JSX.Prop = "lengthAdjust", "spacing"
    static member inline lengthAdjustSpacingAndGlyphs: JSX.Prop = "lengthAdjust", "spacingAndGlyphs"

    /// Specifies that the markerWidth and markerUnits attributes and the contents of the <marker> element represent
    /// values in a coordinate system which has a single unit equal the size in user units of the current stroke width
    /// (see the stroke-width attribute) in place for the graphic object referencing the marker.
    static member inline markerUnitsStrokeWidth: JSX.Prop = "markerUnits", "strokeWidth"
    /// Specifies that the markerWidth and markerUnits attributes and the contents of the <marker> element represent
    /// values in the current user coordinate system in place for the graphic object referencing the marker (i.e.,
    /// the user coordinate system for the element referencing the <marker> element via a marker, marker-start,
    /// marker-mid, or marker-end property).
    static member inline markerUnitsUserSpaceOnUse: JSX.Prop = "markerUnits", "userSpaceOnUse"

    /// Indicates that all coordinates inside the <mask> element are relative to the bounding box of the element the
    /// mask is applied to.
    ///
    /// A bounding box could be considered the same as if the content of the <mask> were bound to mk "0 0 1 1" viewbox.
    static member inline maskContentUnitsObjectBoundingBox: JSX.Prop = "maskContentUnits", "strokeWidth"
    /// Indicates that all coordinates inside the <mask> element refer to the user coordinate system as defined
    /// when the mask was created.
    static member inline maskContentUnitsUserSpaceOnUse: JSX.Prop = "maskContentUnits", "userSpaceOnUse"

    /// Indicates that all coordinates for the geometry attributes represent fractions or percentages of the bounding box
    /// of the element to which the mask is applied.
    ///
    /// A bounding box could be considered the same as if the content of the <mask> were bound to mk "0 0 1 1" viewbox.
    static member inline maskUnitsObjectBoundingBox: JSX.Prop = "maskUnits", "strokeWidth"
    /// Indicates that all coordinates for the geometry attributes refer to the user coordinate system as defined
    /// when the mask was created.
    static member inline maskUnitsUserSpaceOnUse: JSX.Prop = "maskUnits", "userSpaceOnUse"

    /// The final color has the hue and saturation of the top color, while using the luminosity of the
    /// bottom color.
    ///
    /// The effect preserves gray levels and can be used to colorize the foreground.
    static member inline modeColor: JSX.Prop = "mode", "color"
    /// The final color is the result of inverting the bottom color, dividing the value by the top
    /// color, and inverting that value.
    ///
    /// A white foreground leads to no change. A foreground with the inverse color of the backdrop
    /// leads to a black final image.
    ///
    /// This blend mode is similar to multiply, but the foreground need only be as dark as the inverse
    /// of the backdrop to make the final image black.
    static member inline modeColorBurn: JSX.Prop = "mode", "color-burn"
    /// The final color is the result of dividing the bottom color by the inverse of the top color.
    ///
    /// A black foreground leads to no change. A foreground with the inverse color of the backdrop
    /// leads to a fully lit color.
    ///
    /// This blend mode is similar to screen, but the foreground need only be as light as the inverse
    /// of the backdrop to create a fully lit color.
    static member inline modeColorDodge: JSX.Prop = "mode", "color-dodge"
    /// The final color is composed of the darkest values of each color channel.
    static member inline modeDarken: JSX.Prop = "mode", "darken"
    /// The final color is the result of subtracting the darker of the two colors from the lighter
    /// one.
    ///
    /// A black layer has no effect, while a white layer inverts the other layer's color.
    static member inline modeDifference: JSX.Prop = "mode", "difference"
    /// The final color is similar to difference, but with less contrast.
    ///
    /// As with difference, a black layer has no effect, while a white layer inverts the other
    /// layer's color.
    static member inline modeExclusion: JSX.Prop = "mode", "exclusion"
    /// The final color is the result of multiply if the top color is darker, or screen if the top
    /// color is lighter.
    ///
    /// This blend mode is equivalent to overlay but with the layers swapped.
    ///
    /// The effect is similar to shining a harsh spotlight on the backdrop.
    static member inline modeHardLight: JSX.Prop = "mode", "hard-light"
    /// The final color has the hue of the top color, while using the saturation and luminosity of the
    /// bottom color.
    static member inline modeHue: JSX.Prop = "mode", "hue"
    /// The final color is composed of the lightest values of each color channel.
    static member inline modeLighten: JSX.Prop = "mode", "lighten"
    /// The final color has the luminosity of the top color, while using the hue and saturation of the
    /// bottom color.
    ///
    /// This blend mode is equivalent to color, but with the layers swapped.
    static member inline modeLuminosity: JSX.Prop = "mode", "luminosity"
    /// The final color is the result of multiplying the top and bottom colors.
    ///
    /// A black layer leads to a black final layer, and a white layer leads to no change.
    ///
    /// The effect is like two images printed on transparent film overlapping.
    static member inline modeMultiply: JSX.Prop = "mode", "multiply"
    /// The final color is the top color, regardless of what the bottom color is.
    ///
    /// The effect is like two opaque pieces of paper overlapping.
    static member inline modeNormal: JSX.Prop = "mode", "normal"
    /// The final color is the result of multiply if the bottom color is darker, or screen if the
    /// bottom color is lighter.
    ///
    /// This blend mode is equivalent to hard-light but with the layers swapped.
    static member inline modeOverlay: JSX.Prop = "mode", "overlay"
    /// The final color has the saturation of the top color, while using the hue and luminosity of the
    /// bottom color.
    ///
    /// A pure gray backdrop, having no saturation, will have no effect.
    static member inline modeSaturation: JSX.Prop = "mode", "saturation"
    /// The final color is the result of inverting the colors, multiplying them, and inverting
    /// that value.
    ///
    /// A black layer leads to no change, and a white layer leads to a white final layer.
    ///
    /// The effect is like two images shone onto a projection screen.
    static member inline modeScreen: JSX.Prop = "mode", "screen"
    /// The final color is similar to hard-light, but softer.
    ///
    /// This blend mode behaves similar to hard-light.
    ///
    /// The effect is similar to shining a diffused spotlight on the backdrop.
    static member inline modeSoftLight: JSX.Prop = "mode", "soft-light"

    /// This value indicates that the source graphic defined in the in attribute and the
    /// destination graphic defined in the in2 attribute are combined using the following
    /// formula:
    ///
    /// result = k1*i1*i2 + k2*i1 + k3*i2 + k4
    ///
    /// where:
    ///
    /// i1 and i2 indicate the corresponding pixel channel values of the input image, which
    /// map to in and in2 respectively, and k1,k2,k3,and k4 indicate the values of the
    /// attributes with the same name.
    ///
    /// Used with <feComposite>
    static member inline operatorArithmetic: JSX.Prop = "operator", "arithmetic"
    /// Indicates that the parts of the source graphic defined in the in attribute, which overlap
    /// the destination graphic defined in the in2 attribute, replace the destination graphic.
    ///
    /// The parts of the destination graphic that do not overlap with the source graphic stay untouched.
    ///
    /// Used with <feComposite>
    static member inline operatorAtop: JSX.Prop = "operator", "atop"
    /// Fattens the source graphic defined in the in attribute.
    ///
    /// Used with <feMorphology>
    static member inline operatorDilate: JSX.Prop = "operator", "dilate"
    /// Thins the source graphic defined in the in attribute.
    ///
    /// Used with <feMorphology>
    static member inline operatorErode: JSX.Prop = "operator", "erode"
    /// Indicates that the parts of the source graphic defined in the in attribute that overlap the
    /// destination graphic defined in the in2 attribute, replace the destination graphic.
    ///
    /// Used with <feComposite>
    static member inline operatorIn': JSX.Prop = "operator", "in"
    /// Indicates that the sum of the source graphic defined in the in attribute and the destination
    /// graphic defined in the in2 attribute is displayed.
    ///
    /// Used with <feComposite>
    static member inline operatorLighter: JSX.Prop = "operator", "lighter"
    /// Indicates that the parts of the source graphic defined in the in attribute that fall outside
    /// the destination graphic defined in the in2 attribute, are displayed.
    ///
    /// Used with <feComposite>
    static member inline operatorOut: JSX.Prop = "operator", "out"
    /// Indicates that the source graphic defined in the in attribute is placed over the destination
    /// graphic defined in the in2 attribute.
    ///
    /// Used with <feComposite>
    static member inline operatorOver: JSX.Prop = "operator", "over"
    /// Indicates that the non-overlapping regions of the source graphic defined in the in attribute
    /// and the destination graphic defined in the in2 attribute are combined.
    ///
    /// Used with <feComposite>
    static member inline operatorXor: JSX.Prop = "operator", "xor"

    /// Indicates that all coordinates inside the <pattern> element are relative to the bounding box of the element
    /// the pattern is applied to.
    ///
    /// A bounding box could be considered the same as if the content of the <pattern> were bound to mk "0 0 1 1"
    /// viewbox for a pattern tile of width and height of 100%.
    static member inline patternContentUnitsObjectBoundingBox: JSX.Prop = "patternContentUnits", "objectBoundingBox"
    /// Indicates that all coordinates inside the <pattern> element refer to the user coordinate system as defined
    /// when the pattern tile was created.
    static member inline patternContentUnitsUserSpaceOnUse: JSX.Prop = "patternContentUnits", "userSpaceOnUse"

    /// Indicates that all coordinates for the geometry properties represent fractions or percentages of the bounding
    /// box of the element to which the mask is applied.
    ///
    /// A bounding box could be considered the same as if the content of the <mask> were bound to mk "0 0 1 1" viewbox.
    static member inline patternUnitsObjectBoundingBox: JSX.Prop = "patternUnits", "objectBoundingBox"
    /// Indicates that all coordinates for the geometry properties refer to the user coordinate system as defined
    /// when the pattern was applied.
    static member inline patternUnitsUserSpaceOnUse: JSX.Prop = "patternUnits", "userSpaceOnUse"

    /// Indicates that the whole video file can be downloaded, even if the user is not expected to use it.
    static member inline preloadAuto: JSX.Prop = "preload", "auto"
    /// Indicates that only video metadata (e.g. length) is fetched.
    static member inline preloadMetadata: JSX.Prop = "preload", "metadata"
    /// Indicates that the video should not be preloaded.
    static member inline preloadNone: JSX.Prop = "preload", "none"

    /// Do not force uniform scaling.
    ///
    /// Scale the graphic content of the given element non-uniformly if necessary such that the element's
    /// bounding box exactly matches the viewport rectangle. Note that if <align> is none, then the optional
    /// <meetOrSlice> value is ignored.
    static member inline preserveAspectRatioNone: JSX.Prop = "preserveAspectRatio", "none"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMinYMinMeet: JSX.Prop = "preserveAspectRatio", "xMinYMin meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMinYMinSlice: JSX.Prop = "preserveAspectRatio", "xMinYMin slice"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMidYMinMeet: JSX.Prop = "preserveAspectRatio", "xMidYMin meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMidYMinSlice: JSX.Prop = "preserveAspectRatio", "xMidYMin slice"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMaxYMinMeet: JSX.Prop = "preserveAspectRatio", "xMaxYMin meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMaxYMinSlice: JSX.Prop = "preserveAspectRatio", "xMaxYMin slice"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMinYMidMeet: JSX.Prop = "preserveAspectRatio", "xMinYMid meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMinYMidSlice: JSX.Prop = "preserveAspectRatio", "xMinYMid slice"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMidYMidMeet: JSX.Prop = "preserveAspectRatio", "xMidYMid meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMidYMidSlice: JSX.Prop = "preserveAspectRatio", "xMidYMid slice"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMaxYMidMeet: JSX.Prop = "preserveAspectRatio", "xMaxYMid meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMaxYMidSlice: JSX.Prop = "preserveAspectRatio", "xMaxYMid slice"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMinYMaxMeet: JSX.Prop = "preserveAspectRatio", "xMinYMax meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMinYMaxSlice: JSX.Prop = "preserveAspectRatio", "xMinYMax slice"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMidYMaxMeet: JSX.Prop = "preserveAspectRatio", "xMidYMax meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMidYMaxSlice: JSX.Prop = "preserveAspectRatio", "xMidYMax slice"

    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewBox is visible within the viewport.
    ///
    /// The viewBox is scaled up as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the graphic does not match the viewport, some of
    /// the viewport will extend beyond the bounds of the viewBox (i.e., the area into which
    /// the viewBox will draw will be smaller than the viewport).
    static member inline preserveAspectRatioXMaxYMaxMeet: JSX.Prop = "preserveAspectRatio", "xMaxYMax meet"
    /// Scale the graphic such that:
    ///
    /// Aspect ratio is preserved.
    ///
    /// The entire viewport is covered by the viewBox.
    ///
    /// The viewBox is scaled down as much as possible, while still meeting the other criteria.
    ///
    /// In this case, if the aspect ratio of the viewBox does not match the viewport, some of the
    /// viewBox will extend beyond the bounds of the viewport (i.e., the area into which the
    /// viewBox will draw is larger than the viewport).
    static member inline preserveAspectRatioXMaxYMaxSlice: JSX.Prop = "preserveAspectRatio", "xMaxYMax slice"

    /// Indicates that any length values within the filter definitions represent fractions or
    /// percentages of the bounding box on the referencing element.
    static member inline primitiveUnitsObjectBoundingBox: JSX.Prop = "primitiveUnits", "objectBoundingBox"
    /// Indicates that any length values within the filter definitions represent values in the current user coordinate
    /// system in place at the time when the <filter> element is referenced (i.e., the user coordinate system for the
    /// element referencing the <filter> element via a filter attribute).
    static member inline primitiveUnitsUserSpaceOnUse: JSX.Prop = "primitiveUnits", "userSpaceOnUse"

    /// The Referer header will not be sent.
    static member inline referrerPolicyNoReferrer: JSX.Prop = "referrerpolicy", "no-referrer"
    /// The Referer header will not be sent to origins without TLS (HTTPS).
    static member inline referrerPolicyNoReferrerWhenDowngrade: JSX.Prop = "referrerpolicy", "no-referrer-when-downgrade"
    /// The sent referrer will be limited to the origin of the referring page: its scheme, host, and port.
    static member inline referrerPolicyOrigin: JSX.Prop = "referrerpolicy", "origin"
    /// The referrer sent to other origins will be limited to the scheme, the host, and the port.
    /// Navigations on the same origin will still include the path.
    static member inline referrerPolicyOriginWhenCrossOrigin: JSX.Prop = "referrerpolicy", "origin-when-cross-origin"
    /// A referrer will be sent for same origin, but cross-origin requests will contain no referrer information.
    static member inline referrerPolicySameOrigin: JSX.Prop = "referrerpolicy", "same-origin"
    /// Only send the origin of the document as the referrer when the protocol security level stays the same
    /// (e.g. HTTPS→HTTPS), but don't send it to a less secure destination (e.g. HTTPS→HTTP).
    static member inline referrerPolicyStrictOrigin: JSX.Prop = "referrerpolicy", "strict-origin"
    /// Send a full URL when performing a same-origin request, but only send the origin when the protocol security
    /// level stays the same (e.g.HTTPS→HTTPS), and send no header to a less secure destination (e.g. HTTPS→HTTP).
    static member inline referrerPolicyStrictOriginWhenCrossOrigin: JSX.Prop = "referrerpolicy", "strict-origin-when-cross-origin"
    /// The referrer will include the origin and the path (but not the fragment, password, or username). This value is unsafe,
    /// because it leaks origins and paths from TLS-protected resources to insecure origins.
    static member inline referrerPolicyUnsafeUrl: JSX.Prop = "referrerpolicy", "unsafe-url"

    /// Lengths are interpreted as being in the coordinate system of the marker contents, after application
    /// of the viewBox and preserveAspectRatio attributes.
    static member inline refXLength (value: ICssUnit): JSX.Prop = "refX", box(Util.asString value)
    /// Numbers are interpreted as being in the coordinate system of the marker contents, after application of the
    /// viewBox and preserveAspectRatio attributes.
    static member inline refXLength (value: int): JSX.Prop = "refX", box(Util.asString value)
    /// The reference point of the marker is placed at the left edge of the shape.
    static member inline refXLeft: JSX.Prop = "refX", "left"
    /// The reference point of the marker is placed at the horizontal center of the shape.
    static member inline refXCenter: JSX.Prop = "refX", "center"
    /// The reference point of the marker is placed at the right edge of the shape.
    static member inline refXRight: JSX.Prop = "refX", "right"

    /// Lengths are interpreted as being in the coordinate system of the marker contents, after application of the
    /// viewBox and preserveAspectRatio attributes.
    ///
    /// Percentage values are interpreted as being a percentage of the viewBox height.
    static member inline refYLength (value: ICssUnit): JSX.Prop = "refY", box(Util.asString value)
    /// Numbers are interpreted as being in the coordinate system of the marker contents, after application of the
    /// viewBox and preserveAspectRatio attributes.
    static member inline refYLength (value: int): JSX.Prop = "refY", box(Util.asString value)
    /// The reference point of the marker is placed at the top edge of the shape.
    static member inline refYTop: JSX.Prop = "refY", "top"
    /// The reference point of the marker is placed at the vertical center of the shape.
    static member inline refYCenter: JSX.Prop = "refY", "center"
    /// The reference point of the marker is placed at the bottom edge of the shape.
    static member inline refYBottom: JSX.Prop = "refY", "bottom"

    /// Provides a link to an alternate version of the document (i.e. print page, translated or mirror).
    ///
    /// Example: <link rel="alternate" type="application/atom+xml" title="W3Schools News" href="/blog/news/atom">
    static member inline relAlternate: JSX.Prop = "rel", "alternate"
    /// Provides a link to the author of the document.
    static member inline relAuthor: JSX.Prop = "rel", "author"
    /// Permalink for the nearest ancestor section.
    static member inline relBookmark: JSX.Prop = "rel", "bookmark"
    /// Preferred URL for the current document.
    static member inline relCanonical: JSX.Prop = "rel", "canonical"
    /// Specifies that the browser should preemptively perform DNS resolution for the target resource's origin.
    static member inline relDnsPrefetch: JSX.Prop = "rel", "dns-prefetch"
    /// The referenced document is not part of the same site as the current document.
    static member inline relExternal: JSX.Prop = "rel", "external"
    /// Provides a link to a help document. Example: <link rel="help" href="/help/">
    static member inline relHelp: JSX.Prop = "rel", "help"
    /// Imports an icon to represent the document.
    ///
    /// Example: <link rel="icon" href="/favicon.ico" type="image/x-icon">
    static member inline relIcon: JSX.Prop = "rel", "icon"
    /// Provides a link to copyright information for the document.
    static member inline relLicense: JSX.Prop = "rel", "license"
    /// Web app manifest.
    static member inline relManifest: JSX.Prop = "rel", "manifest"
    /// Tells to browser to preemptively fetch the script and store it in the document's module map for later
    /// evaluation. Optionally, the module's dependencies can be fetched as well.
    static member inline relModulepreload: JSX.Prop = "rel", "modulepreload"
    /// Provides a link to the next document in the series.
    static member inline relNext: JSX.Prop = "rel", "next"
    /// Indicates that the current document's original author or publisher does not endorse the referenced document.
    static member inline relNofollow: JSX.Prop = "rel", "nofollow"
    /// Creates a top-level browsing context that is not an auxiliary browsing context if the hyperlink would create
    /// either of those, to begin with (i.e., has an appropriate target attribute value).
    static member inline relNoopener: JSX.Prop = "rel", "noopener"
    /// No Referer header will be included. Additionally, has the same effect as noopener.
    static member inline relNoreferrer: JSX.Prop = "rel", "noreferrer"
    /// Creates an auxiliary browsing context if the hyperlink would otherwise create a top-level browsing context
    /// that is not an auxiliary browsing context (i.e., has "_blank" as target attribute value).
    static member inline relOpener: JSX.Prop = "rel", "opener"
    /// Provides the address of the pingback server that handles pingbacks to the current document.
    static member inline relPingback: JSX.Prop = "rel", "pingback"
    /// Specifies that the browser should preemptively connect to the target resource's origin.
    static member inline relPreconnect: JSX.Prop = "rel", "preconnect"
    /// Specifies that the browser should preemptively fetch and cache the target resource as it is likely to be
    /// required for a follow-up navigation.
    static member inline relPrefetch: JSX.Prop = "rel", "prefetch"
    /// Specifies that the browser agent must preemptively fetch and cache the target resource for current navigation
    /// according to the destination given by the "as" attribute (and the priority associated with that destination).
    static member inline relPreload: JSX.Prop = "rel", "preload"
    /// Specifies that the browser should pre-render (load) the specified webpage in the background. So, if the user
    /// navigates to this page, it speeds up the page load (because the page is already loaded).
    ///
    /// Warning! This wastes the user's bandwidth!
    ///
    /// Only use prerender if it is absolutely sure that the webpage is required at some point in the user journey.
    static member inline relPrerender: JSX.Prop = "rel", "prerender"
    /// Indicates that the document is a part of a series, and that the previous document in the series is the referenced document.
    static member inline relPrev: JSX.Prop = "rel", "prev"
    /// Provides a link to a resource that can be used to search through the current document and its related pages.
    static member inline relSearch: JSX.Prop = "rel", "search"
    /// Imports a style sheet.
    static member inline relStylesheet: JSX.Prop = "rel", "stylesheet"
    /// Gives a tag (identified by the given address) that applies to the current document.
    static member inline relTag: JSX.Prop = "rel", "tag"

    /// Specifies the number of iterations.
    ///
    /// It can include partial iterations expressed as fraction values.
    ///
    /// A fractional value describes a portion of the simple duration.
    ///
    /// Values must be greater than 0.
    static member inline repeatCountIterations (value: float): JSX.Prop = "repeatCount", box(Util.asString value)
    /// Specifies the number of iterations.
    ///
    /// It can include partial iterations expressed as fraction values.
    ///
    /// A fractional value describes a portion of the simple duration.
    ///
    /// Values must be greater than 0.
    static member inline repeatCountIterations (value: int): JSX.Prop = "repeatCount", box(Util.asString value)
    /// Indicates that the animation will be repeated indefinitely (i.e. until the document ends).
    static member inline repeatCountIndefinite: JSX.Prop = "repeatCount", "indefinite"

    // /// This value specifies the duration in presentation time to repeat the animation.
    // static member inline clockValue (duration: System.TimeSpan): JSX.Prop =
    //     PropHelpers.createClockValue(duration)
    //     |> Interop.mkAttr "repeatDur"
    /// Indicates that the animation will be repeated indefinitely (i.e. until the document ends).
    static member inline repeatDurIndefinite: JSX.Prop = "repeatDur", "indefinite"

    /// Indicates that the animation can be restarted at any time.
    static member inline restartAlways: JSX.Prop = "restart", "always"
    /// Indicates that the animation cannot be restarted for the time the document is loaded.
    static member inline restartNever: JSX.Prop = "restart", "never"
    /// Indicates that the animation can only be restarted when it is not active (i.e. after the active end).
    ///
    /// Attempts to restart the animation during its active duration are ignored.
    static member inline restartWhenNotActive: JSX.Prop = "restart", "whenNotActive"

    /// A message with important, and usually time-sensitive, information.
    /// See related `alertdialog` and `status`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#alert
    static member inline roleAlert: JSX.Prop = "role", "alert"
    /// A type of dialog that contains an alert message, where initial focus
    /// goes to an element within the dialog. See related `alert` and
    /// `dialog`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#alertdialog
    static member inline roleAlertDialog: JSX.Prop = "role", "alertdialog"
    /// A region declared as a web application, as opposed to a web
    /// `document`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#application
    static member inline roleApplication: JSX.Prop = "role", "application"
    /// A section of a page that consists of a composition that forms an
    /// independent part of a document, page, or site.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#article
    static member inline roleArticle: JSX.Prop = "role", "article"
    /// A region that contains mostly site-oriented content, rather than
    /// page-specific content.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#banner
    static member inline roleBanner: JSX.Prop = "role", "banner"
    /// An input that allows for user-triggered actions when clicked or
    /// pressed. See related `link`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#button
    static member inline roleButton: JSX.Prop = "role", "button"
    /// A checkable input that has three possible values: `true`, `false`,
    /// or `mixed`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#checkbox
    static member inline roleCheckbox: JSX.Prop = "role", "checkbox"
    /// A cell containing header information for a column.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#columnheader
    static member inline roleColumnHeader: JSX.Prop = "role", "columnheader"
    /// A presentation of a `select`; usually similar to a `textbox` where
    /// users can type ahead to select an option, or type to enter arbitrary
    /// text as a new item in the list. See related `listbox`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#combobox
    static member inline roleComboBox: JSX.Prop = "role", "combobox"
    /// A supporting section of the document, designed to be complementary
    /// to the main content at a similar level in the DOM hierarchy, but
    /// remains meaningful when separated from the main content.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#complementary
    static member inline roleComplementary: JSX.Prop = "role", "complementary"
    /// A large perceivable region that contains information about the
    /// parent document.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#contentinfo
    static member inline roleContentInfo: JSX.Prop = "role", "contentinfo"
    /// A definition of a term or concept.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#definition
    static member inline roleDefinition: JSX.Prop = "role", "definition"
    /// A dialog is an application window that is designed to interrupt the
    /// current processing of an application in order to prompt the user to
    /// enter information or require a response. See related `alertdialog`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#dialog
    static member inline roleDialog: JSX.Prop = "role", "dialog"
    /// A list of references to members of a group, such as a static table
    /// of contents.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#directory
    static member inline roleDirectory: JSX.Prop = "role", "directory"
    /// A region containing related information that is declared as document
    /// content, as opposed to a web application.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#document
    static member inline roleDocument: JSX.Prop = "role", "document"
    /// A `landmark` region that contains a collection of items and objects
    /// that, as a whole, combine to create a form. See related search.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#form
    static member inline roleForm: JSX.Prop = "role", "form"
    /// A grid is an interactive control which contains cells of tabular
    /// data arranged in rows and columns, like a table.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#grid
    static member inline roleGrid: JSX.Prop = "role", "grid"
    /// A cell in a grid or treegrid.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#gridcell
    static member inline roleGridCell: JSX.Prop = "role", "gridcell"
    /// A set of user interface objects which are not intended to be
    /// included in a page summary or table of contents by assistive
    /// technologies.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#group
    static member inline roleGroup: JSX.Prop = "role", "group"
    /// A heading for a section of the page.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#heading
    static member inline roleHeading: JSX.Prop = "role", "heading"
    /// A container for a collection of elements that form an image.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#img
    static member inline roleImg: JSX.Prop = "role", "img"
    /// An interactive reference to an internal or external resource that,
    /// when activated, causes the user agent to navigate to that resource.
    /// See related `button`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#link
    static member inline roleLink: JSX.Prop = "role", "link"
    /// A group of non-interactive list items. See related `listbox`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#list
    static member inline roleList: JSX.Prop = "role", "list"
    /// A widget that allows the user to select one or more items from a
    /// list of choices. See related `combobox` and `list`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#listbox
    static member inline roleListBox: JSX.Prop = "role", "listbox"
    /// A single item in a list or directory.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#listitem
    static member inline roleListItem: JSX.Prop = "role", "listitem"
    /// A type of live region where new information is added in meaningful
    /// order and old information may disappear. See related `marquee`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#log
    static member inline roleLog: JSX.Prop = "role", "log"
    /// The main content of a document.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#main
    static member inline roleMain: JSX.Prop = "role", "main"
    /// A type of live region where non-essential information changes
    /// frequently. See related `log`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#marquee
    static member inline roleMarquee: JSX.Prop = "role", "marquee"
    /// Content that represents a mathematical expression.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#math
    static member inline roleMath: JSX.Prop = "role", "math"
    /// A type of widget that offers a list of choices to the user.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#menu
    static member inline roleMenu: JSX.Prop = "role", "menu"
    /// A presentation of `menu` that usually remains visible and is usually
    /// presented horizontally.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#menubar
    static member inline roleMenuBar: JSX.Prop = "role", "menubar"
    /// An option in a set of choices contained by a `menu` or `menubar`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#menuitem
    static member inline roleMenuItem: JSX.Prop = "role", "menuitem"
    /// A `menuitem` with a checkable state whose possible values are
    /// `true`, `false`, or `mixed`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#menuitemcheckbox
    static member inline roleMenuItemCheckbox: JSX.Prop = "role", "menuitemcheckbox"
    /// A checkable menuitem in a set of elements with role `menuitemradio`,
    /// only one of which can be checked at a time.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#menuitemradio
    static member inline roleMenuItemRadio: JSX.Prop = "role", "menuitemradio"
    /// A collection of navigational elements (usually links) for navigating
    /// the document or related documents.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#navigation
    static member inline roleNavigation: JSX.Prop = "role", "navigation"
    /// A section whose content is parenthetic or ancillary to the main
    /// content of the resource.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#note
    static member inline roleNote: JSX.Prop = "role", "note"
    /// A selectable item in a `select` list.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#option
    static member inline roleOption: JSX.Prop = "role", "option"
    /// An element whose implicit native role semantics will not be mapped
    /// to the accessibility API.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#presentation
    static member inline rolePresentation: JSX.Prop = "role", "presentation"
    /// An element that displays the progress status for tasks that take a
    /// long time.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#progressbar
    static member inline roleProgressBar: JSX.Prop = "role", "progressbar"
    /// A checkable input in a group of elements with role radio, only one
    /// of which can be checked at a time.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#radio
    static member inline roleRadio: JSX.Prop = "role", "radio"
    /// A group of radio buttons.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#radiogroup
    static member inline roleRadioGroup: JSX.Prop = "role", "radiogroup"
    /// A large perceivable section of a web page or document, that is
    /// important enough to be included in a page summary or table of
    /// contents, for example, an area of the page containing live sporting
    /// event statistics.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#region
    static member inline roleRegion: JSX.Prop = "role", "region"
    /// A row of cells in a grid.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#row
    static member inline roleRow: JSX.Prop = "role", "row"
    /// A group containing one or more row elements in a grid.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#rowgroup
    static member inline roleRowGroup: JSX.Prop = "role", "rowgroup"
    /// A cell containing header information for a row in a grid.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#rowheader
    static member inline roleRowHeader: JSX.Prop = "role", "rowheader"
    /// A graphical object that controls the scrolling of content within a
    /// viewing area, regardless of whether the content is fully displayed
    /// within the viewing area.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#scrollbar
    static member inline roleScrollBar: JSX.Prop = "role", "scrollbar"
    /// A divider that separates and distinguishes sections of content or
    /// groups of menuitems.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#separator
    static member inline roleSeparator: JSX.Prop = "role", "separator"
    /// A `landmark` region that contains a collection of items and objects
    /// that, as a whole, combine to create a search facility. See related
    /// `form`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#search
    static member inline roleSearch: JSX.Prop = "role", "search"
    /// A user input where the user selects a value from within a given
    /// range.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#slider
    static member inline roleSlider: JSX.Prop = "role", "slider"
    /// A form of `range` that expects the user to select from among
    /// discrete choices.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#spinbutton
    static member inline roleSpinButton: JSX.Prop = "role", "spinbutton"
    /// A container whose content is advisory information for the user but
    /// is not important enough to justify an alert, often but not
    /// necessarily presented as a status bar. See related `alert`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#status
    static member inline roleStatus: JSX.Prop = "role", "status"
    /// A grouping label providing a mechanism for selecting the tab content
    /// that is to be rendered to the user.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#tab
    static member inline roleTab: JSX.Prop = "role", "tab"
    /// A list of `tab` elements, which are references to `tabpanel`
    /// elements.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#tablist
    static member inline roleTabList: JSX.Prop = "role", "tablist"
    /// A container for the resources associated with a `tab`, where each
    /// `tab` is contained in a `tablist`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#tabpanel
    static member inline roleTabPanel: JSX.Prop = "role", "tabpanel"
    /// Input that allows free-form text as its value.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#textbox
    static member inline roleTextBox: JSX.Prop = "role", "textbox"
    /// A type of live region containing a numerical counter which indicates
    /// an amount of elapsed time from a start point, or the time remaining
    /// until an end point.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#timer
    static member inline roleTimer: JSX.Prop = "role", "timer"
    /// A collection of commonly used function buttons or controls
    /// represented in compact visual form.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#toolbar
    static member inline roleToolbar: JSX.Prop = "role", "toolbar"
    /// A contextual popup that displays a description for an element.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#tooltip
    static member inline roleTooltip: JSX.Prop = "role", "tooltip"
    /// A type of `list` that may contain sub-level nested groups that can
    /// be collapsed and expanded.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#tree
    static member inline roleTree: JSX.Prop = "role", "tree"
    /// A `grid` whose rows can be expanded and collapsed in the same manner
    /// as for a `tree`.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#treegrid
    static member inline roleTreeGrid: JSX.Prop = "role", "treegrid"
    /// An option item of a `tree`. This is an element within a tree that
    /// may be expanded or collapsed if it contains a sub-level group of
    /// `treeitem` elements.
    ///
    /// https://www.w3.org/WAI/PF/aria-1.1/roles#treeitem
    static member inline roleTreeItem: JSX.Prop = "role", "treeitem"

    // /// For the opposite direction.
    // static member inline selectionDirectionBackward: JSX.Prop = "selectionDirection", "backward"
    // /// If selection was performed in the start-to-end direction of the current locale.
    // static member inline selectionDirectionForward: JSX.Prop = "selectionDirection", "forward"
    // /// If the direction is unknown.
    // static member inline selectionDirectionNone: JSX.Prop = "selectionDirection", "none"

    static member inline shapeRect: JSX.Prop = "shape", "rect"
    static member inline shapeCircle: JSX.Prop = "shape", "circle"
    static member inline shapePoly: JSX.Prop = "shape", "poly"

    /// Indicates that the user agent should use text-on-a-path layout algorithms to adjust
    /// the spacing between typographic characters in order to achieve visually appealing results.
    static member inline spacingAuto: JSX.Prop = "spacing", "auto"
    /// Indicates that the typographic characters should be rendered exactly according to the
    /// spacing rules as specified by the layout rules for text-on-a-path.
    static member inline spacingExact: JSX.Prop = "spacing", "exact"

    /// Indicates that the final color of the gradient fills the shape beyond the gradient's edges.
    static member inline spreadMethodPad: JSX.Prop = "spreadMethod", "pad"
    /// Indicates that the gradient repeats in reverse beyond its edges.
    static member inline spreadMethodReflect: JSX.Prop = "spreadMethod", "reflect"
    /// Specifies that the gradient repeats in the original order beyond its edges.
    static member inline spreadMethodRepeat: JSX.Prop = "spreadMethod", "repeat"

    /// Indicates that no attempt is made to achieve smooth transitions at the border of tiles which
    /// contain a turbulence function.
    ///
    /// Sometimes the result will show clear discontinuities at the tile borders.
    static member inline stitchTilesNoStitch: JSX.Prop = "stitchTiles", "noStitch"
    /// Indicates that the user agent will automatically adjust the x and y values of the base
    /// frequency such that the <feTurbulence> node’s width and height (i.e., the width and
    /// height of the current subregion) contain an integral number of the tile width and height
    /// for the first octave.
    static member inline stitchTilesStitch: JSX.Prop = "stitchTiles", "stitch"

    /// Opens the linked document in a new window or tab.
    static member inline targetBlank: JSX.Prop = "target", "_blank"
    /// Opens the linked document in the parent frame.
    static member inline targetParent: JSX.Prop = "target", "_parent"
    /// Opens the linked document in the same frame as it was clicked (this is default).
    static member inline targetSelf: JSX.Prop = "target", "_self"
    /// Opens the linked document in the full body of the window.
    static member inline targetTop: JSX.Prop = "target", "_top"

    /// The rendered characters are shifted such that the end of the
    /// resulting rendered text (final current text position before applying
    /// the `text-anchor` property) is at the initial current text position.
    /// For an element with a `direction` property value of `ltr` (typical
    /// for most European languages), the right side of the text is rendered
    /// at the initial text position. For an element with a `direction`
    /// property value of `rtl` (typical for Arabic and Hebrew), the left
    /// side of the text is rendered at the initial text position. For an
    /// element with a vertical primary text direction (often typical for
    /// Asian text), the bottom of the text is rendered at the initial text
    /// position.
    static member inline textAnchorEndOfText: JSX.Prop = "text-anchor", "end"
    /// The rendered characters are aligned such that the middle of the text
    /// string is at the current text position. (For text on a path,
    /// conceptually the text string is first laid out in a straight line.
    /// The midpoint between the start of the text string and the end of the
    /// text string is determined. Then, the text string is mapped onto the
    /// path with this midpoint placed at the current text position.)
    static member inline textAnchorMiddle: JSX.Prop = "text-anchor", "middle"
    /// The rendered characters are aligned such that the start of the text
    /// string is at the initial current text position. For an element with
    /// a `direction` property value of `ltr` (typical for most European
    /// languages), the left side of the text is rendered at the initial
    /// text position. For an element with a `direction` property value of
    /// `rtl` (typical for Arabic and Hebrew), the right side of the text is
    /// rendered at the initial text position. For an element with a
    /// vertical primary text direction (often typical for Asian text), the
    /// top side of the text is rendered at the initial text position.
    static member inline textAnchorStartOfText: JSX.Prop = "text-anchor", "start"

    /// Defines a clickable button (mostly used with a JavaScript code to activate a script)
    static member inline typeButton: JSX.Prop = "type", "button"
    /// Defines a checkbox
    static member inline typeCheckbox: JSX.Prop = "type", "checkbox"
    /// Defines a color picker
    static member inline typeColor: JSX.Prop = "type", "color"
    /// Defines a date control with year, month and day (no time)
    static member inline typeDate: JSX.Prop = "type", "date"
    /// Defines a date and time control (year, month, day, time (no timezone)
    static member inline typeDateTimeLocal: JSX.Prop = "type", "datetime-local"
    /// Defines a field for an e-mail address
    static member inline typeEmail: JSX.Prop = "type", "email"
    /// Defines a file-select field and mk "Browse" button (for file uploads)
    static member inline typeFile: JSX.Prop = "type", "file"
    /// Defines a hidden input field
    static member inline typeHidden: JSX.Prop = "type", "hidden"
    /// Defines an image as the submit button
    static member inline typeImage: JSX.Prop = "type", "image"
    /// Defines a month and year control (no timezone)
    static member inline typeMonth: JSX.Prop = "type", "month"
    /// Defines a field for entering a number
    static member inline typeNumber: JSX.Prop = "type", "number"
    /// Defines a password field
    static member inline typePassword: JSX.Prop = "type", "password"
    /// Defines a radio button
    static member inline typeRadio: JSX.Prop = "type", "radio"
    /// Defines a range control (like a slider control)
    static member inline typeRange: JSX.Prop = "type", "range"
    /// Defines a reset button
    static member inline typeReset: JSX.Prop = "type", "reset"
    /// Defines a text field for entering a search string
    static member inline typeSearch: JSX.Prop = "type", "search"
    /// Defines a submit button
    static member inline typeSubmit: JSX.Prop = "type", "submit"
    /// Defines a field for entering a telephone number
    static member inline typeTel: JSX.Prop = "type", "tel"
    /// Default. Defines a single-line text field
    static member inline typeText: JSX.Prop = "type", "text"
    /// Defines a control for entering a time (no timezone)
    static member inline typeTime: JSX.Prop = "type", "time"
    /// Defines a field for entering a URL
    static member inline typeUrl: JSX.Prop = "type", "url"
    /// Defines a week and year control (no timezone)
    static member inline typeWeek: JSX.Prop = "type", "week"

    /// The browser ensures that all line breaks in the value consist of a CR+LF pair,
    /// but does not insert any additional line breaks.
    static member inline wrapSoft: JSX.Prop = "wrap", "soft"
    /// The browser automatically inserts line breaks (CR+LF)
    /// so that each line has no more than the width of the control;
    /// the cols attribute must also be specified for this to take effect.
    static member inline wrapHard: JSX.Prop = "wrap", "hard"
    /// Like soft but changes appearance to white-space: pre
    /// so line segments exceeding cols are not wrapped and the `<textarea>` becomes horizontally scrollable.
    /// WARNING: This API has not been standardized.
    static member inline wrapOff: JSX.Prop = "wrap", "off"

    /// Specifies that the alpha channel of the input image defined in in2 will be used to displace
    /// the pixels of the input image defined in in along the x-axis.
    static member inline xChannelSelectorA: JSX.Prop = "xChannelSelector", "A"
    /// Specifies that the blue color channel of the input image defined in in2 will be used to
    /// displace the pixels of the input image defined in in along the x-axis.
    static member inline xChannelSelectorB: JSX.Prop = "xChannelSelector", "B"
    /// Specifies that the green color channel of the input image defined in in2 will be used to
    /// displace the pixels of the input image defined in in along the x-axis.
    static member inline xChannelSelectorG: JSX.Prop = "xChannelSelector", "G"
    /// Specifies that the red color channel of the input image defined in in2 will be used to
    /// displace the pixels of the input image defined in in along the x-axis.
    static member inline xChannelSelectorR: JSX.Prop = "xChannelSelector", "R"

    /// Specifies that the alpha channel of the input image defined in in2 will be used to displace
    /// the pixels of the input image defined in in along the y-axis.
    static member inline yChannelSelectorA: JSX.Prop = "yChannelSelector", "A"
    /// Specifies that the blue color channel of the input image defined in in2 will be used to
    /// displace the pixels of the input image defined in in along the y-axis.
    static member inline yChannelSelectorB: JSX.Prop = "yChannelSelector", "B"
    /// Specifies that the green color channel of the input image defined in in2 will be used to
    /// displace the pixels of the input image defined in in along the y-axis.
    static member inline yChannelSelectorG: JSX.Prop = "yChannelSelector", "G"
    /// Specifies that the red color channel of the input image defined in in2 will be used to
    /// displace the pixels of the input image defined in in along the y-axis.
    static member inline yChannelSelectorR: JSX.Prop = "yChannelSelector", "R"

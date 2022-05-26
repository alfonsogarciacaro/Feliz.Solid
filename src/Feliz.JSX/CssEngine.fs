namespace Feliz.JSX

open System
open Fable.Core

open type Util

/// <summary>CSS generator API.</summary>
type Css =
    /// Define a custom property
    static member inline custom(key: string, value: string): JSX.Style = key, value

    /// Specifies that all the element's properties should be changed to their initial values.
    static member inline allInitial: JSX.Style = "all", "initial"
    /// Specifies that all the element's properties should be changed to their inherited values.
    static member inline allInherit: JSX.Style = "all", "inherit"
    /// Specifies that all the element's properties should be changed to their inherited values if they inherit by default, or to their initial values if not.
    static member inline allUnset: JSX.Style = "all", "unset"
    /// Specifies behavior that depends on the stylesheet origin to which the declaration belongs:
    ///
    /// User-agent origin
    ///     Equivalent to unset.
    /// User origin
    ///     Rolls back the cascade to the user-agent level, so that the specified values are calculated as if no author-level or user-level rules were specified for the element.
    /// Author origin
    ///     Rolls back the cascade to the user level, so that the specified values are calculated as if no author-level rules were specified for the element. For purposes of revert, the Author origin includes the Override and Animation origins.
    static member inline allRevert: JSX.Style = "all", "revert"

    static member inline boxShadow(value: string): JSX.Style = "box-shadow", value

    static member inline boxShadow(horizontalOffset: int, verticalOffset: int, color: string): JSX.Style =
        "box-shadow", (
            (asString horizontalOffset) + "px " +
            (asString verticalOffset) + "px " +
            color
        )
    static member inline boxShadow(horizontalOffset: int, verticalOffset: int, blur: int, color: string): JSX.Style =
        "box-shadow", (
            (asString horizontalOffset) + "px " +
            (asString verticalOffset) + "px " +
            (asString blur) + "px " +
            color
        )
    static member inline boxShadow(horizontalOffset: int, verticalOffset: int, blur: int, spread: int, color: string): JSX.Style =
        "box-shadow", (
            (asString horizontalOffset) + "px " +
            (asString verticalOffset) + "px " +
            (asString blur) + "px " +
            (asString spread) + "px " +
            color
        )
    static member inline boxShadowNone: JSX.Style = "box-shadow", "none"
    /// Inherits this property from its parent element.
    static member inline boxShadowInheritFromParent: JSX.Style = "box-shadow", "inherit"

    static member inline height(value: int): JSX.Style = "height", (asString value + "px")
    static member inline height(value: ICssUnit): JSX.Style = "height", (asString value)
    /// Inherits this property from its parent element.
    static member inline heightInheritFromParent: JSX.Style = "height", "inherit"
    /// Sets this property to its default value.
    static member inline heightInitial: JSX.Style = "height", "initial"
    /// The intrinsic preferred height.
    static member inline heightMaxContent: JSX.Style = "height", "max-content"
    /// The intrinsic minimum height.
    static member inline heightMinContent: JSX.Style = "height", "min-content"

    static member inline maxHeight(value: int): JSX.Style = "max-height", (asString value + "px")
    static member inline maxHeight(value: ICssUnit): JSX.Style = "max-height", (asString value)
    /// Inherits this property from its parent element.
    static member inline maxHeightInheritFromParent: JSX.Style = "max-height", "inherit"
    /// Sets this property to its default value.
    static member inline maxHeightInitial: JSX.Style = "max-height", "initial"
    /// The intrinsic preferred height.
    static member inline maxHeightMaxContent: JSX.Style = "height", "max-content"
    /// The intrinsic minimum height.
    static member inline maxHeightMinContent: JSX.Style = "height", "min-content"

    static member inline minHeight(value: int): JSX.Style = "min-height", (asString value + "px")
    static member inline minHeight(value: ICssUnit): JSX.Style = "min-height", (asString value)
    /// Inherits this property from its parent element.
    static member inline minHeightInheritFromParent: JSX.Style = "min-height", "inherit"
    /// Sets this property to its default value.
    static member inline minHeightInitial: JSX.Style = "min-height", "initial"
    /// The intrinsic preferred height.
    static member inline minHeightMaxContent: JSX.Style = "height", "max-content"
    /// The intrinsic minimum height.
    static member inline minHeightMinContent: JSX.Style = "height", "min-content"

    /// The browser determines the justification algorithm
    static member inline textJustifyAuto: JSX.Style = "text-justify", "auto"
    /// Increases/Decreases the space between words
    static member inline textJustifyInterWord: JSX.Style = "text-justify", "inter-word"
    /// Increases/Decreases the space between characters
    static member inline textJustifyInterCharacter: JSX.Style = "text-justify", "inter-character"
    /// Disables justification methods
    static member inline textJustifyNone: JSX.Style = "text-justify", "none"
    static member inline textJustifyInitial: JSX.Style = "text-justify", "initial"
    /// Inherits this property from its parent element.
    static member inline textJustifyInheritFromParent: JSX.Style = "text-justify", "inherit"

    /// Sequences of whitespace will collapse into a single whitespace. Text will wrap when necessary. This is default.
    static member inline  whiteSpaceNormal: JSX.Style = "white-space", "normal"
    /// Sequences of whitespace will collapse into a single whitespace. Text will never wrap to the next line.
    /// The text continues on the same line until a `<br> ` tag is encountered.
    static member inline  whiteSpaceNowrap: JSX.Style = "white-space", "nowrap"
    /// Whitespace is preserved by the browser. Text will only wrap on line breaks. Acts like the <pre> tag in HTML.
    static member inline  whiteSpacePre: JSX.Style = "white-space", "pre"
    /// Sequences of whitespace will collapse into a single whitespace. Text will wrap when necessary, and on line breaks
    static member inline  whiteSpacePreLine: JSX.Style = "white-space", "pre-line"
    /// Whitespace is preserved by the browser. Text will wrap when necessary, and on line breaks
    static member inline  whiteSpacePreWrap: JSX.Style = "white-space", "pre-wrap"
    /// Sets this property to its default value.
    static member inline  whiteSpaceInitial: JSX.Style = "white-space", "initial"
    /// Inherits this property from its parent element.
    static member inline  whiteSpaceInheritFromParent: JSX.Style = "white-space", "inherit"

    /// Default value. Uses default line break rules.
    static member inline wordbreakNormal: JSX.Style = "word-break", "normal"
    /// To prevent overflow, word may be broken at any character
    static member inline wordbreakBreakAll: JSX.Style = "word-break", "break-all"
    /// Word breaks should not be used for Chinese/Japanese/Korean (CJK) text. Non-CJK text behavior is the same as value "normal"
    static member inline wordbreakKeepAll: JSX.Style = "word-break", "keep-all"
    /// To prevent overflow, word may be broken at arbitrary points.
    static member inline wordbreakBreakWord: JSX.Style = "word-break", "break-word"
    /// Sets this property to its default value.
    static member inline wordbreakInitial: JSX.Style = "word-break", "initial"
    /// Inherits this property from its parent element.
    static member inline wordbreakInheritFromParent: JSX.Style = "word-break", "inherit"

    /// Allows a straight jump "scroll effect" between elements within the scrolling box. This is default
    static member inline scrollBehaviorAuto: JSX.Style = "scroll-behavior", "auto"
    /// Allows a smooth animated "scroll effect" between elements within the scrolling box.
    static member inline scrollBehaviorSmooth: JSX.Style = "scroll-behavior", "smooth"
    /// Sets this property to its default value.
    static member inline scrollBehaviorInitial: JSX.Style = "scroll-behavior", "initial"
    /// Inherits this property from its parent element.
    static member inline scrollBehaviorInheritFromParent: JSX.Style = "scroll-behavior", "inherit"

    /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
    static member inline overflowVisible: JSX.Style = "overflow", "visibile"
    /// The content is clipped - and no scrolling mechanism is provided.
    static member inline overflowHidden: JSX.Style = "overflow", "hidden"
    /// The content is clipped and a scrolling mechanism is provided.
    static member inline overflowScroll: JSX.Style = "overflow", "scroll"
    /// Should cause a scrolling mechanism to be provided for overflowing boxes
    static member inline overflowAuto: JSX.Style = "overflow", "auto"
    /// Sets this property to its default value.
    static member inline overflowInitial: JSX.Style = "overflow", "initial"
    /// Inherits this property from its parent element.
    static member inline overflowInheritFromParent: JSX.Style = "overflow", "inherit"

    /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
    static member inline overflowXVisible: JSX.Style = "overflow-x", "visibile"
    /// The content is clipped - and no scrolling mechanism is provided.
    static member inline overflowXHidden: JSX.Style = "overflow-x", "hidden"
    /// The content is clipped and a scrolling mechanism is provided.
    static member inline overflowXScroll: JSX.Style = "overflow-x", "scroll"
    /// Should cause a scrolling mechanism to be provided for overflowing boxes
    static member inline overflowXAuto: JSX.Style = "overflow-x", "auto"
    /// Sets this property to its default value.
    static member inline overflowXInitial: JSX.Style = "overflow-x", "initial"
    /// Inherits this property from its parent element.
    static member inline overflowXInheritFromParent: JSX.Style = "overflow-x", "inherit"

    /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
    static member inline overflowYVisible: JSX.Style = "overflow-y", "visibile"
    /// The content is clipped - and no scrolling mechanism is provided.
    static member inline overflowYHidden: JSX.Style = "overflow-y", "hidden"
    /// The content is clipped and a scrolling mechanism is provided.
    static member inline overflowYScroll: JSX.Style = "overflow-y", "scroll"
    /// Should cause a scrolling mechanism to be provided for overflowing boxes
    static member inline overflowYAuto: JSX.Style = "overflow-y", "auto"
    /// Sets this property to its default value.
    static member inline overflowYInitial: JSX.Style = "overflow-y", "initial"
    /// Inherits this property from its parent element.
    static member inline overflowYInheritFromParent: JSX.Style = "overflow-y", "inherit"

    /// The element is hidden (but still takes up space).
    static member inline visibilityHidden: JSX.Style = "visibility", "hidden"
    /// Default value. The element is visible.
    static member inline visibilityVisible: JSX.Style = "visibility", "visible"
    /// Only for table rows (`<tr> `), row groups (`<tbody> `), columns (`<col> `), column groups
    /// (`<colgroup> `). This value removes a row or column, but it does not affect the table layout.
    /// The space taken up by the row or column will be available for other content.
    ///
    /// If collapse is used on other elements, it renders as "hidden"
    static member inline visibilityCollapse: JSX.Style = "visibility", "collapse"
    /// Sets this property to its default value.
    static member inline visibilityInitial: JSX.Style = "visibility", "initial"
    /// Inherits this property from its parent element.
    static member inline visibilityInheritFromParent: JSX.Style = "visibility", "inherit"

    /// Default value. The length is equal to the length of the flexible item. If the item has
    /// no length specified, the length will be according to its content.
    static member inline flexBasisAuto: JSX.Style = "flex-basis", "auto"
    /// Sets this property to its default value.
    static member inline flexBasisInitial: JSX.Style = "flex-basis", "initial"
    /// Inherits this property from its parent element.
    static member inline flexBasisInheritFromParent: JSX.Style = "flex-basis", "inherit"

    /// Default value. The flexible items are displayed horizontally, as a row
    static member inline flexDirectionRow: JSX.Style = "flex-direction", "row"
    /// Same as row, but in reverse order.
    static member inline flexDirectionRowReverse: JSX.Style = "flex-direction", "row-reverse"
    /// The flexible items are displayed vertically, as a column
    static member inline flexDirectionColumn: JSX.Style = "flex-direction", "column"
    /// Same as column, but in reverse order
    static member inline flexDirectionColumnReverse: JSX.Style = "flex-direction", "column-reverse"
    /// Sets this property to its default value.
    static member inline flexDirectionInitial: JSX.Style = "flex-basis", "initial"
    /// Inherits this property from its parent element.
    static member inline flexDirectionInheritFromParent: JSX.Style = "flex-basis", "inherit"

    /// Default value. Specifies that the flexible items will not wrap.
    static member inline flexWrapNowrap: JSX.Style = "flex-wrap", "nowrap"
    /// Specifies that the flexible items will wrap if necessary
    static member inline flexWrapWrap: JSX.Style = "flex-wrap", "wrap"
    /// Specifies that the flexible items will wrap, if necessary, in reverse order
    static member inline flexWrapWrapReverse: JSX.Style = "flex-wrap", "wrap-reverse"
    /// Sets this property to its default value.
    static member inline flexWrapInitial: JSX.Style = "flex-wrap", "initial"
    /// Inherits this property from its parent element.
    static member inline flexWrapInheritFromParent: JSX.Style = "flex-wrap", "inherit"

    /// The element must float on the left side of its containing block.
    static member inline floatLeft: JSX.Style = "float", "left"
    /// The element must float on the right side of its containing block.
    static member inline floatRight: JSX.Style = "float", "right"
    /// The element must not float.
    static member inline floatNone: JSX.Style = "float", "none"

    /// The font display strategy is defined by the user agent.
    ///
    /// Default value
    static member inline fontDisplayAuto: JSX.Style = "font-display", "auto"
    /// Gives the font face a short block period and an infinite swap period.
    static member inline fontDisplayBlock: JSX.Style = "font-display", "block"
    /// Gives the font face an extremely small block period and an infinite swap period.
    static member inline fontDisplaySwap: JSX.Style = "font-display", "swap"
    /// Gives the font face an extremely small block period and a short swap period.
    static member inline fontDisplayFallback: JSX.Style = "font-display", "fallback"
    /// Gives the font face an extremely small block period and no swap period.
    static member inline fontDisplayOptional: JSX.Style = "font-display", "optional"

    /// Default. The browser determines whether font kerning should be applied or not
    static member inline fontKerningAuto: JSX.Style = "font-kerning", "auto"
    /// Specifies that font kerning is applied
    static member inline fontKerningNormal: JSX.Style = "font-kerning", "normal"
    /// Specifies that font kerning is not applied
    static member inline fontKerningNone: JSX.Style = "font-kerning", "none"

    /// Defines from thin to thick characters. 400 is the same as normal, and 700 is the same as bold.
    /// Possible values are [100, 200, 300, 400, 500, 600, 700, 800, 900]
    static member inline fontWeight(weight: int): JSX.Style = "font-weight", (asString weight)
    /// Defines normal characters. This is default.
    static member inline fontWeightNormal: JSX.Style = "font-weight", "normal"
    /// Defines thick characters.
    static member inline fontWeightBold: JSX.Style = "font-weight", "bold"
    /// Defines thicker characters
    static member inline fontWeightBolder: JSX.Style = "font-weight", "bolder"
    /// Defines lighter characters.
    static member inline fontWeightLighter: JSX.Style = "font-weight", "lighter"
    /// Sets this property to its default value.
    static member inline fontWeightInitial: JSX.Style = "font-weight", "initial"
    /// Inherits this property from its parent element.
    static member inline fontWeightInheritFromParent: JSX.Style = "font-weight", "inherit"

    /// The browser displays a normal font style. This is defaut.
    static member inline fontStyleNormal: JSX.Style = "font-style", "normal"
    /// The browser displays an italic font style.
    static member inline fontStyleItalic: JSX.Style = "font-style", "italic"
    /// The browser displays an oblique font style.
    static member inline fontStyleOblique: JSX.Style = "font-style", "oblique"
    /// Sets this property to its default value.
    static member inline fontStyleInitial: JSX.Style = "font-style", "initial"
    /// Inherits this property from its parent element.
    static member inline fontStyleInheritFromParent: JSX.Style = "font-style", "inherit"

    /// The browser displays a normal font. This is default
    static member inline fontVariantNormal: JSX.Style = "font-variant", "normal"
    /// The browser displays a small-caps font
    static member inline fontVariantSmallCaps: JSX.Style = "font-variant", "small-caps"
    /// Sets this property to its default value.
    static member inline fontVariantInitial: JSX.Style = "font-variant", "initial"
    /// Inherits this property from its parent element.
    static member inline fontVariantInheritFromParent: JSX.Style = "font-variant", "inherit"

    /// Break words only at allowed break points
    static member inline wordWrapNormal: JSX.Style = "word-wrap", "normal"
    /// Allows unbreakable words to be broken
    static member inline wordWrapBreakWord: JSX.Style = "word-wrap", "break-word"
    /// Sets this property to its default value.
    static member inline wordWrapInitial: JSX.Style = "word-wrap", "initial"
    /// Inherits this property from its parent element.
    static member inline wordWrapInheritFromParent: JSX.Style = "word-wrap", "inherit"

    /// Default. The element inherits its parent container's align-items property, or "stretch" if it has no parent container.
    static member inline alignSelfAuto: JSX.Style = "align-self", "auto"
    /// The element is positioned to fit the container (align-self overrides align-items)
    static member inline alignSelfStretch: JSX.Style = "align-self", "stretch"
    /// The element is positioned at the center of the container (align-self overrides align-items)
    static member inline alignSelfCenter: JSX.Style = "align-self", "center"
    /// The element is positioned at the beginning of the container (align-self overrides align-items)
    static member inline alignSelfFlexStart: JSX.Style = "align-self", "flex-start"
    /// The element is positioned at the end of the container (align-self overrides align-items)
    static member inline alignSelfFlexEnd: JSX.Style = "align-self", "flex-end"
    /// The element is positioned at the baseline of the container (align-self overrides align-items)
    static member inline alignSelfBaseline: JSX.Style = "align-self", "baseline"
    /// Sets this property to its default value
    static member inline alignSelfInitial: JSX.Style = "align-self", "initial"
    /// Inherits this property from its parent element
    static member inline alignSelfInheritFromParent: JSX.Style = "align-self", "inherit"

    /// Default. Items are stretched to fit the container along the cross axis
    static member inline alignItemsStretch: JSX.Style = "align-items", "stretch"
    /// Items are positioned at the center of the container along the cross axis
    static member inline alignItemsCenter: JSX.Style = "align-items", "center"
    /// Items are positioned at the beginning of the container along the cross axis
    static member inline alignItemsFlexStart: JSX.Style = "align-items", "flex-start"
    /// Items are positioned at the end of the container along the cross axis
    static member inline alignItemsFlexEnd: JSX.Style = "align-items", "flex-end"
    /// Items are positioned at the baseline of the container along the cross axis
    static member inline alignItemsBaseline: JSX.Style = "align-items", "baseline"
    /// Sets this property to its default value
    static member inline alignItemsInitial: JSX.Style = "align-items", "initial"
    /// Inherits this property from its parent element
    static member inline alignItemsInheritFromParent: JSX.Style = "align-items", "inherit"

    /// Default value. Lines stretch to take up the remaining space.
    static member inline alignContentStretch: JSX.Style = "align-content", "stretch"
    /// Lines are packed toward the center of the flex container.
    static member inline alignContentCenter: JSX.Style = "align-content", "center"
    /// Lines are packed toward the start of the flex container.
    static member inline alignContentFlexStart: JSX.Style = "align-content", "flex-start"
    /// Lines are packed toward the end of the flex container.
    static member inline alignContentFlexEnd: JSX.Style = "align-content", "flex-end"
    /// Lines are evenly distributed in the flex container.
    static member inline alignContentSpaceBetween: JSX.Style = "align-content", "space-between"
    /// Lines are evenly distributed in the flex container, with half-size spaces on either end.
    static member inline alignContentSpaceAround: JSX.Style = "align-content", "space-around"
    static member inline alignContentInitial: JSX.Style = "align-content", "initial"
    static member inline alignContentInheritFromParent: JSX.Style = "align-content", "inherit"

    /// Default value. Items are positioned at the beginning of the container along the main axis.
    static member inline justifyContentFlexStart: JSX.Style = "justify-content", "flex-start"
    /// Items are positioned at the end of the container along the main axis.
    static member inline justifyContentFlexEnd: JSX.Style = "justify-content", "flex-end"
    /// Items are positioned at the center of the containe along the main axis.
    static member inline justifyContentCenter: JSX.Style = "justify-content", "center"
    /// Items are positioned with space between the line along the main axis.
    static member inline justifyContentSpaceBetween: JSX.Style = "justify-content", "space-between"
    /// Items are positioned with space before, between, and after the lines along the main axis.
    static member inline justifyContentSpaceAround: JSX.Style = "justify-content", "space-around"
    /// Sets this property to its default value.
    static member inline justifyContentInitial: JSX.Style = "justify-content", "initial"
    /// Inherits this property from its parent element.
    static member inline justifyContentInheritFromParent: JSX.Style = "justify-content", "inherit"

    static member inline outlineWidth(width: int): JSX.Style = "outline-width", (asString width + "px")
    static member inline outlineWidth(width: ICssUnit): JSX.Style = "outline-width", (asString width)
    /// Specifies a medium outline. This is default.
    static member inline outlineWidthMedium: JSX.Style = "outline-width", "medium"
    /// Specifies a thin outline.
    static member inline outlineWidthThin: JSX.Style = "outline-width", "thin"
    /// Specifies a thick outline.
    static member inline outlineWidthThick: JSX.Style = "outline-width", "thick"
    /// Sets this property to its default value
    static member inline outlineWidthInitial: JSX.Style = "outline-width", "initial"
    /// Inherits this property from its parent element
    static member inline outlineWidthInheritFromParent: JSX.Style = "outline-width", "inherit"

    /// Default value. The marker is a filled circle
    static member inline listStyleTypeDisc: JSX.Style = "list-style-type", "disc"
    /// The marker is traditional Armenian numbering
    static member inline listStyleTypeArmenian: JSX.Style = "list-style-type", "armenian"
    /// The marker is a circle
    static member inline listStyleTypeCircle: JSX.Style = "list-style-type", "circle"
    /// The marker is plain ideographic numbers
    static member inline listStyleTypeCjkIdeographic: JSX.Style = "list-style-type", "cjk-ideographic"
    /// The marker is a number
    static member inline listStyleTypeDecimal: JSX.Style = "list-style-type", "decimal"
    /// The marker is a number with leading zeros (01, 02, 03, etc.)
    static member inline listStyleTypeDecimalLeadingZero: JSX.Style = "list-style-type", "decimal-leading-zero"
    /// The marker is traditional Georgian numbering
    static member inline listStyleTypeGeorgian: JSX.Style = "list-style-type", "georgian"
    /// The marker is traditional Hebrew numbering
    static member inline listStyleTypeHebrew: JSX.Style = "list-style-type", "hebrew"
    /// The marker is traditional Hiragana numbering
    static member inline listStyleTypeHiragana: JSX.Style = "list-style-type", "hiragana"
    /// The marker is traditional Hiragana iroha numbering
    static member inline listStyleTypeHiraganaIroha: JSX.Style = "list-style-type", "hiragana-iroha"
    /// The marker is traditional Katakana numbering
    static member inline listStyleTypeKatakana: JSX.Style = "list-style-type", "katakana"
    /// The marker is traditional Katakana iroha numbering
    static member inline listStyleTypeKatakanaIroha: JSX.Style = "list-style-type", "katakana-iroha"
    /// The marker is lower-alpha (a, b, c, d, e, etc.)
    static member inline listStyleTypeLowerAlpha: JSX.Style = "list-style-type", "lower-alpha"
    /// The marker is lower-greek
    static member inline listStyleTypeLowerGreek: JSX.Style = "list-style-type", "lower-greek"
    /// The marker is lower-latin (a, b, c, d, e, etc.)
    static member inline listStyleTypeLowerLatin: JSX.Style = "list-style-type", "lower-latin"
    /// The marker is lower-roman (i, ii, iii, iv, v, etc.)
    static member inline listStyleTypeLowerRoman: JSX.Style = "list-style-type", "lower-roman"
    /// No marker is shown
    static member inline listStyleTypeNone: JSX.Style = "list-style-type", "none"
    /// The marker is a square
    static member inline listStyleTypeSquare: JSX.Style = "list-style-type", "square"
    /// The marker is upper-alpha (A, B, C, D, E, etc.)
    static member inline listStyleTypeUpperAlpha: JSX.Style = "list-style-type", "upper-alpha"
    /// The marker is upper-greek
    static member inline listStyleTypeUpperGreek: JSX.Style = "list-style-type", "upper-greek"
    /// The marker is upper-latin (A, B, C, D, E, etc.)
    static member inline listStyleTypeUpperLatin: JSX.Style = "list-style-type", "upper-latin"
    /// The marker is upper-roman (I, II, III, IV, V, etc.)
    static member inline listStyleTypeUpperRoman: JSX.Style = "list-style-type", "upper-roman"
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    static member inline listStyleTypeInitial: JSX.Style = "list-style-type", "initial"
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    static member inline listStyleTypeInheritFromParent: JSX.Style = "list-style-type", "inherit"

    static member inline propertyNone: JSX.Style = "list-style-image", "none"
    /// The path to the image to be used as a list-item marker
    static member inline propertyUrl (path: string): JSX.Style = "list-style-image", ("url('" + path + "')")
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    static member inline propertyInitial: JSX.Style = "list-style-image", "initial"
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    static member inline propertyInheritFromParent: JSX.Style = "list-style-image", "inherit"

    /// The bullet points will be inside the list item
    static member inline listStylePositionInside: JSX.Style = "list-style-position", "inside"
    /// The bullet points will be outside the list item. This is default
    static member inline listStylePositionOutside: JSX.Style = "list-style-position", "outside"
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    static member inline listStylePositionInitial: JSX.Style = "list-style-position", "initial"
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    static member inline listStylePositionInheritFromParent: JSX.Style = "list-style-position", "inherit"

    static member inline textDecorationLine(line: ITextDecorationLine): JSX.Style = "text-decoration-line", (asString line)
    static member inline textDecorationLineNone: JSX.Style = "text-decoration-line", "none"
    static member inline textDecorationLineUnderline: JSX.Style = "text-decoration-line", "underline"
    static member inline textDecorationLineOverline: JSX.Style = "text-decoration-line", "overline"
    static member inline textDecorationLineLineThrough: JSX.Style = "text-decoration-line", "line-through"
    static member inline textDecorationLineInitial: JSX.Style = "text-decoration-line", "initial"
    /// Inherits this property from its parent element.
    static member inline textDecorationLineInheritFromParent: JSX.Style = "text-decoration-line", "inherit"

    static member inline textDecoration(line: ITextDecorationLine): JSX.Style = "text-decoration", (asString line)
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine): JSX.Style =
        "text-decoration", (asString bottom + " " + asString top)
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine, style: ITextDecoration): JSX.Style =
        "text-decoration", ((asString bottom) + " " + (asString top) + " " + (asString style))
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine, style: ITextDecoration, color: string): JSX.Style =
        "text-decoration", ((asString bottom) + " " + (asString top) + " " + (asString style) + " " + color)
    static member inline textDecorationNone: JSX.Style = "text-decoration", "none"
    static member inline textDecorationUnderline: JSX.Style = "text-decoration", "underline"
    static member inline textDecorationOverline: JSX.Style = "text-decoration", "overline"
    static member inline textDecorationLineThrough: JSX.Style = "text-decoration", "line-through"
    static member inline textDecorationInitial: JSX.Style = "text-decoration", "initial"
    /// Inherits this property from its parent element.
    static member inline textDecorationInheritFromParent: JSX.Style = "text-decoration", "inherit"

    /// Specifies that child elements will NOT preserve its 3D position. This is default.
    static member inline transformStyleFlat: JSX.Style = "transform-style", "flat"
    /// Specifies that child elements will preserve its 3D position
    static member inline transformStylePreserve3D: JSX.Style = "transform-style", "preserve-3d"
    static member inline transformStyleInitial: JSX.Style = "transform-style", "initial"
    /// Inherits this property from its parent element.
    static member inline transformStyleInheritFromParent: JSX.Style = "transform-style", "inherit"

    /// No capitalization. The text renders as it is. This is default.
    static member inline textTransformNone: JSX.Style = "text-transform", "none"
    /// Transforms the first character of each word to uppercase.
    static member inline textTransformCapitalize: JSX.Style = "text-transform", "capitalize"
    /// Transforms all characters to uppercase.
    static member inline textTransformUppercase: JSX.Style = "text-transform", "uppercase"
    /// Transforms all characters to lowercase.
    static member inline textTransformLowercase: JSX.Style = "text-transform", "lowercase"
    static member inline textTransformInitial: JSX.Style = "text-transform", "initial"
    /// Inherits this property from its parent element.
    static member inline textTransformInheritFromParent: JSX.Style = "text-transform", "inherit"

    /// Default value. The text is clipped and not accessible.
    static member inline textOverflowClip: JSX.Style = "text-overflow", "clip"
    /// Render an ellipsis ("...") to represent the clipped text.
    static member inline textOverflowEllipsis: JSX.Style = "text-overflow", "ellipsis"
    /// Render the given asString to represent the clipped text.
    static member inline textOverflowInitial: JSX.Style = "text-overflow", "initial"
    /// Inherits this property from its parent element.
    static member inline textOverflowInheritFromParent: JSX.Style = "text-overflow", "inherit"

    /// Default value. Specifies no effects.
    static member inline filterNone: JSX.Style = "filter", "none"
    /// Applies a blur effect to the elemeen. A larger value will create more blur.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    static member inline filterBlur(value: int): JSX.Style = "filter", ("blur(" + ((asString value) + "%)"))
    /// Applies a blur effect to the elemeen. A larger value will create more blur.
    ///
    /// This overload takes a floating number that goes from 0 to 1,
    static member inline filterBlur(value: double): JSX.Style = "filter", ("blur(" + ((asString value) + ")"))
    /// Adjusts the brightness of the elemeen
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    ///
    /// Values over 100% will provide brighter results.
    static member inline filterBrightness(value: int): JSX.Style = "filter", ("brightness(" + ((asString value) + "%)"))
    /// Adjusts the brightness of the elemeen. A larger value will create more blur.
    ///
    /// This overload takes a floating number that goes from 0 to 1,
    static member inline filterBrightness(value: double): JSX.Style = "filter", ("brightness(" + ((asString value) + ")"))
    /// Adjusts the contrast of the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    static member inline filterContrast(value: int): JSX.Style = "filter", ("contrast(" + ((asString value) + "%)"))
    /// Adjusts the contrast of the element. A larger value will create more contrast.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    static member inline filterContrast(value: double): JSX.Style = "filter", ("contrast(" + ((asString value) + ")"))
    /// Applies a drop shadow effect.
    static member inline filterDropShadow(horizontalOffset: int, verticalOffset: int, blur: int, spread: int,  color: string): JSX.Style = "filter", ("drop-shadow(" + (asString horizontalOffset) + "px " + (asString verticalOffset) + "px " + (asString blur) + "px " + (asString spread) + "px " + color + ")")
    /// Applies a drop shadow effect.
    static member inline filterDropShadow(horizontalOffset: int, verticalOffset: int, blur: int, color: string): JSX.Style = "filter", ("drop-shadow(" + (asString horizontalOffset) + "px " + (asString verticalOffset) + "px " + (asString blur) + "px " + color + ")")
    /// Applies a drop shadow effect.
    static member inline filterDropShadow(horizontalOffset: int, verticalOffset: int, color: string): JSX.Style = "filter", ("drop-shadow(" + (asString horizontalOffset) + "px " + (asString verticalOffset) + "px " + color + ")")
    /// Converts the image to grayscale
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    static member inline filterGrayscale(value: int): JSX.Style = "filter", ("grayscale(" + ((asString value) + "%)"))
    /// Converts the image to grayscale
    ///
    /// This overload takes a floating number that goes from 0 to 1
    static member inline filterGrayscale(value: double): JSX.Style = "filter", ("grayscale(" + ((asString value) + ")"))
    /// Applies a hue rotation on the image. The value defines the number of degrees around the color circle the image
    /// samples will be adjusted. 0deg is default, and represents the original image.
    ///
    /// **Note**: Maximum value is 360
    static member inline filterHueRotate(degrees: int): JSX.Style = "filter", ("hue-rotate(" + (asString degrees) + "deg)")
    /// Inverts the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    static member inline filterInvert(value: int): JSX.Style = "filter", ("invert(" + ((asString value) + "%)"))
    /// Inverts the element.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    static member inline filterInvert(value: double): JSX.Style = "filter", ("invert(" + ((asString value) + ")"))
    /// Sets the opacity of the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    static member inline filterOpacity(value: int): JSX.Style = "filter", ("opacity(" + ((asString value) + "%)"))
    /// Sets the opacity of the element.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    static member inline filterOpacity(value: double): JSX.Style = "filter", ("opacity(" + ((asString value) + ")"))
    /// Sets the saturation of the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    static member inline filterSaturate(value: int): JSX.Style = "filter", ("saturate(" + ((asString value) + "%)"))
    /// Sets the saturation of the element.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    static member inline filterSaturate(value: double): JSX.Style = "filter", ("saturate(" + ((asString value) + ")"))
    /// Applies Sepia filter to the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    static member inline filterSepia(value: int): JSX.Style = "filter", ("sepia(" + ((asString value) + "%)"))
    /// Applies Sepia filter to the element.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    static member inline filterSepia(value: double): JSX.Style = "filter", ("sepia(" + ((asString value) + ")"))
    /// The url() function takes the location of an XML file that specifies an SVG filter, and may include an anchor to a specific filter element.
    ///
    /// Example: `filter: url(svg-url#element-id)`
    static member inline filterUrl(value: string): JSX.Style = "filter", ("url(" + value + ")")
    /// Sets this property to its default value.
    static member inline filterInitial: JSX.Style = "filter", "initial"
    /// Inherits this property from its parent element.
    static member inline filterInheritFromParent: JSX.Style = "filter", "inherit"

    /// Sets whether table borders should collapse into a single border or be separated as in standard HTML.
    /// Borders are separated; each cell will display its own borders. This is default.
    static member inline borderCollapseSeparate: JSX.Style = "border-collapse", "separate"
    /// Borders are collapsed into a single border when possible (border-spacing and empty-cells properties have no effect)
    static member inline borderCollapseCollapse: JSX.Style = "border-collapse", "collapse"
    /// Sets this property to its default value
    static member inline borderCollapseInitial: JSX.Style = "border-collapse", "initial"
    /// Inherits this property from its parent element.
    static member inline borderCollapseInheritFromParent: JSX.Style = "border-collapse", "inherit"

    /// Sets the distance between the borders of adjacent <table> cells. Applies only when border-collapse is separate.
    static member inline borderSpacing(horizontal: ICssUnit, ?vertical: ICssUnit): JSX.Style =
        "border-spacing", (asString horizontal + " " + asString vertical)
    /// Sets this property to its default value
    static member inline borderSpacingInitial: JSX.Style = "border-spacing", "initial"
    /// Inherits this property from its parent element.
    static member inline borderSpacingInheritFromParent: JSX.Style = "border-spacing", "inherit"

    /// Sets the size of the element's background image.
    ///
    /// The image can be left to its natural size, stretched, or constrained to fit the available space.
    static member inline backgroundSize(value: string): JSX.Style = "background-size", (asString value)
    /// Sets the size of the element's background image.
    ///
    /// The image can be left to its natural size, stretched, or constrained to fit the available space.
    static member inline backgroundSize(value: ICssUnit): JSX.Style = "background-size", (asString value)
    /// Sets the size of the element's background image.
    ///
    /// The image can be left to its natural size, stretched, or constrained to fit the available space.
    static member inline backgroundSize(width: ICssUnit, height: ICssUnit): JSX.Style =
        "background-size", (
            asString width
            + " " +
            asString height
        )
    /// Default value. The background image is displayed in its original size
    ///
    /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=auto)
    static member inline backgroundSizeAuto: JSX.Style = "background-size", "auto"
    /// Resize the background image to cover the entire container, even if it has to stretch the image or cut a little bit off one of the edges.
    ///
    /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=cover)
    static member inline backgroundSizeCover: JSX.Style = "background-size", "cover"
    /// Resize the background image to make sure the image is fully visible
    ///
    /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=contain)
    static member inline backgroundSizeContain: JSX.Style = "background-size", "contain"
    /// Sets this property to its default value.
    static member inline backgroundSizeInitial: JSX.Style = "background-size", "initial"
    /// Inherits this property from its parent element.
    static member inline backgroundSizeInheritFromParent: JSX.Style = "background-size", "inherit"

    /// Default value. The line will display as a single line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=solid
    static member inline textDecorationStyleSolid: JSX.Style = "text-decoration-style", "solid"
    /// The line will display as a double line.
    ///
    /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=double
    static member inline textDecorationStyleDouble: JSX.Style = "text-decoration-style", "double"
    /// The line will display as a dotted line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dotted
    static member inline textDecorationStyleDotted: JSX.Style = "text-decoration-style", "dotted"
    /// The line will display as a dashed line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dashed
    static member inline textDecorationStyleDashed: JSX.Style = "text-decoration-style", "dashed"
    /// The line will display as a wavy line.
    ///
    /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=wavy
    static member inline textDecorationStyleWavy: JSX.Style = "text-decoration-style", "wavy"
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=initial
    static member inline textDecorationStyleInitial: JSX.Style = "text-decoration-style", "initial"
    /// Inherits this property from its parent element.
    static member inline textDecorationStyleInheritFromParent: JSX.Style = "text-decoration-style", "inherit"

    /// Makes the text as narrow as it gets.
    static member inline fontStretchUltraCondensed: JSX.Style = "font-stretch", "ultra-condensed"
    /// Makes the text narrower than condensed, but not as narrow as ultra-condensed
    static member inline fontStretchExtraCondensed: JSX.Style = "font-stretch", "extra-condensed"
    /// Makes the text narrower than semi-condensed, but not as narrow as extra-condensed.
    static member inline fontStretchCondensed: JSX.Style = "font-stretch", "condensed"
    /// Makes the text narrower than normal, but not as narrow as condensed.
    static member inline fontStretchSemiCondensed: JSX.Style = "font-stretch", "semi-condensed"
    /// Default value. No font stretching
    static member inline fontStretchNormal: JSX.Style = "font-stretch", "normal"
    /// Makes the text wider than normal, but not as wide as expanded
    static member inline fontStretchSemiExpanded: JSX.Style = "font-stretch", "semi-expanded"
    /// Makes the text wider than semi-expanded, but not as wide as extra-expanded
    static member inline fontStretchExpanded: JSX.Style = "font-stretch", "expanded"
    /// Makes the text wider than expanded, but not as wide as ultra-expanded
    static member inline fontStretchExtraExpanded: JSX.Style = "font-stretch", "extra-expanded"
    /// Makes the text as wide as it gets.
    static member inline fontStretchUltraExpanded: JSX.Style = "font-stretch", "ultra-expanded"
    /// Sets this property to its default value.
    static member inline fontStretchInitial: JSX.Style = "font-stretch", "initial"
    /// Inherits this property from its parent element.
    static member inline fontStretchInheritFromParent: JSX.Style = "font-stretch", "inherit"

    /// The element does not float, (will be displayed just where it occurs in the text). This is default
    static member inline floatStyleNone: JSX.Style = "float", "none"
    static member inline floatStyleLeft: JSX.Style = "float", "left"
    static member inline floatStyleRight: JSX.Style = "float", "right"
    /// Sets this property to its default value.
    static member inline floatStyleInitial: JSX.Style = "float", "initial"
    /// Inherits this property from its parent element.
    static member inline floatStyleInheritFromParent: JSX.Style = "float", "inherit"

    /// The element is aligned with the baseline of the parent. This is default.
    static member inline verticalAlignBaseline: JSX.Style = "vertical-align", "baseline"
    /// The element is aligned with the subscript baseline of the parent
    static member inline verticalAlignSub: JSX.Style = "vertical-align", "sup"
    /// The element is aligned with the superscript baseline of the parent.
    static member inline verticalAlignSuper: JSX.Style = "vertical-align", "super"
    /// The element is aligned with the top of the tallest element on the line.
    static member inline verticalAlignTop: JSX.Style = "vertical-align", "top"
    /// The element is aligned with the top of the parent element's font.
    static member inline verticalAlignTextTop: JSX.Style = "vertical-align", "text-top"
    /// The element is placed in the middle of the parent element.
    static member inline verticalAlignMiddle: JSX.Style = "vertical-align", "middle"
    /// The element is aligned with the lowest element on the line.
    static member inline verticalAlignBottom: JSX.Style = "vertical-align", "bottom"
    /// The element is aligned with the bottom of the parent element's font
    static member inline verticalAlignTextBottom: JSX.Style = "vertical-align", "text-bottom"
    /// Sets this property to its default value.
    static member inline verticalAlignInitial: JSX.Style = "vertical-align", "initial"
    /// Inherits this property from its parent element.
    static member inline verticalAlignInheritFromParent: JSX.Style = "vertical-align", "inherit"

    /// Let the content flow horizontally from left to right, vertically from top to bottom
    static member inline writingModeHorizontalTopBottom: JSX.Style = "writing-mode", "horizontal-tb"
    /// Let the content flow vertically from top to bottom, horizontally from right to left
    static member inline writingModeVerticalRightLeft: JSX.Style = "writing-mode", "vertical-rl"
    /// Let the content flow vertically from top to bottom, horizontally from left to right
    static member inline writingModeVerticalLeftRight: JSX.Style = "writing-mode", "vertical-lr"
    /// Sets this property to its default value.
    static member inline writingModeInitial: JSX.Style = "writing-mode", "initial"
    /// Inherits this property from its parent element.
    static member inline writingModeInheritFromParent: JSX.Style = "writing-mode", "inherit"

    /// Default value. Specifies a animation effect with a slow start, then fast, then end slowly (equivalent to cubic-bezier(0.25,0.1,0.25,1)).
    static member inline animationTimingFunctionEase: JSX.Style = "animation-timing-function", "ease"
    /// Specifies a animation effect with the same speed from start to end (equivalent to cubic-bezier(0,0,1,1))
    static member inline animationTimingFunctionLinear: JSX.Style = "animation-timing-function", "linear"
    /// Specifies a animation effect with a slow start (equivalent to cubic-bezier(0.42,0,1,1)).
    static member inline animationTimingFunctionEaseIn: JSX.Style = "animation-timing-function", "ease-in"
    /// Specifies a animation effect with a slow end (equivalent to cubic-bezier(0,0,0.58,1)).
    static member inline animationTimingFunctionEaseOut: JSX.Style = "animation-timing-function", "ease-out"
    /// Specifies a animation effect with a slow start and end (equivalent to cubic-bezier(0.42,0,0.58,1))
    static member inline animationTimingFunctionEaseInOut: JSX.Style = "animation-timing-function", "ease-in-out"
    /// Define your own values in the cubic-bezier function. Possible values are numeric values from 0 to 1
    static member inline animationTimingFunctionCubicBezier(n1: float, n2: float, n3: float, n4: float): JSX.Style = "animation-timing-function", ("cubic-bezier(" + (asString n1) + "," + (asString n2) + "," + (asString n3) + ", " + (asString n4) + ")")
    /// Sets this property to its default value
    static member inline animationTimingFunctionInitial: JSX.Style = "animation-timing-function", "initial"
    /// Inherits this property from its parent element.
    static member inline animationTimingFunctionInheritFromParent: JSX.Style = "animation-timing-function", "inherit"

    /// Default value. Specifies a transition effect with a slow start, then fast, then end slowly (equivalent to cubic-bezier(0.25,0.1,0.25,1)).
    static member inline transitionTimingFunctionEase: JSX.Style = "transition-timing-function", "ease"
    /// Specifies a transition effect with the same speed from start to end (equivalent to cubic-bezier(0,0,1,1))
    static member inline transitionTimingFunctionLinear: JSX.Style = "transition-timing-function", "linear"
    /// Specifies a transition effect with a slow start (equivalent to cubic-bezier(0.42,0,1,1)).
    static member inline transitionTimingFunctionEaseIn: JSX.Style = "transition-timing-function", "ease-in"
    /// Specifies a transition effect with a slow end (equivalent to cubic-bezier(0,0,0.58,1)).
    static member inline transitionTimingFunctionEaseOut: JSX.Style = "transition-timing-function", "ease-out"
    /// Specifies a transition effect with a slow start and end (equivalent to cubic-bezier(0.42,0,0.58,1))
    static member inline transitionTimingFunctionEaseInOut: JSX.Style = "transition-timing-function", "ease-in-out"
    /// Equivalent to steps(1, start)
    static member inline transitionTimingFunctionStepStart: JSX.Style = "transition-timing-function", "step-start"
    /// Equivalent to steps(1, end)
    static member inline transitionTimingFunctionStepEnd: JSX.Style = "transition-timing-function", "step-end"
    /// Define your own values in the cubic-bezier function. Possible values are numeric values from 0 to 1
    static member inline transitionTimingFunctionCubicBezier(n1: float, n2: float, n3: float, n4: float): JSX.Style = "transition-timing-function", ("cubic-bezier(" + (asString n1) + "," + (asString n2) + "," + (asString n3) + ", " + (asString n4) + ")")
    /// Sets this property to its default value
    static member inline transitionTimingFunctionInitial: JSX.Style = "transition-timing-function", "initial"
    /// Inherits this property from its parent element.
    static member inline transitionTimingFunctionInheritFromParent: JSX.Style = "transition-timing-function", "inherit"

    /// Default. Text can be selected if the browser allows it.
    static member inline userSelectAuto: JSX.Style = "user-select", "auto"
    /// Prevents text selection.
    static member inline userSelectNone: JSX.Style = "user-select", "none"
    /// The text can be selected by the user.
    static member inline userSelectText: JSX.Style = "user-select", "text"
    /// Text selection is made with one click instead of a double-click.
    static member inline userSelectAll: JSX.Style = "user-select", "all"
    /// Sets this property to its default value.
    static member inline userSelectInitial: JSX.Style = "user-select", "initial"
    /// Inherits this property from its parent element.
    static member inline userSelectInheritFromParent: JSX.Style = "user-select", "inherit"

    /// Sets the line style for all four sides of an element's border.
    static member inline borderStyle(style: IBorderStyle): JSX.Style = "border-style", (asString style)
    /// Sets the line style for all four sides of an element's border.
    static member inline borderStyle(vertical: IBorderStyle, horizontal: IBorderStyle)  =
        "border-style", (asString vertical + " " + asString horizontal)
    /// Sets the line style for all four sides of an element's border.
    static member inline borderStyle(top: IBorderStyle, right: IBorderStyle, bottom: IBorderStyle, left: IBorderStyle): JSX.Style =
        "border-style", ((asString top) + " " + (asString right) + " " + (asString bottom) + " " +  (asString left))
    /// Specifies a dotted border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleDotted: JSX.Style = "border-style", "dotted"
    /// Specifies a dashed border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleDashed: JSX.Style = "border-style", "dashed"
    /// Specifies a solid border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleSolid: JSX.Style = "border-style", "solid"
    /// Specifies a double border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleDouble: JSX.Style = "border-style", "double"
    /// Specifies a 3D grooved border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleGroove: JSX.Style = "border-style", "groove"
    /// Specifies a 3D ridged border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleRidge: JSX.Style = "border-style", "ridge"
    /// Specifies a 3D inset border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleInset: JSX.Style = "border-style", "inset"
    /// Specifies a 3D outset border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleOutset: JSX.Style = "border-style", "outset"
    /// Default value. Specifies no border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline borderStyleNone: JSX.Style = "border-style", "none"
    /// The same as "none", except in border conflict resolution for table elements.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
    static member inline borderStyleHidden: JSX.Style = "border-style", "hidden"
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
    ///
    /// Read about initial value https://www.w3schools.com/cssref/css_initial.asp
    static member inline borderStyleInitial: JSX.Style = "border-style", "initial"
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
    ///
    /// Read about inherit https://www.w3schools.com/cssref/css_inherit.asp
    static member inline borderStyleInheritFromParent: JSX.Style = "border-style", "inherit"

    /// Browsers use an automatic table layout algorithm. The column width is set by the widest unbreakable
    /// content in the cells. The content will dictate the layout
    static member inline tableLayoutAuto: JSX.Style = "table-layout", "auto"
    /// Sets a fixed table layout algorithm. The table and column widths are set by the widths of table and col
    /// or by the width of the first row of cells. Cells in other rows do not affect column widths. If no widths
    /// are present on the first row, the column widths are divided equally across the table, regardless of content
    /// inside the cells
    static member inline tableLayoutFixed': JSX.Style = "table-layout", "fixed"
    /// Sets this property to its default value.
    static member inline tableLayoutInitial: JSX.Style = "table-layout", "initial"
    /// Inherits this property from its parent element.
    static member inline tableLayoutInheritFromParent: JSX.Style = "table-layout", "inherit"

    static member inline cursor(value: string): JSX.Style = "cursor", (asString value)
    /// The User Agent will determine the cursor to display based on the current context. E.g., equivalent to text when hovering text.
    static member inline cursorAuto: JSX.Style = "cursor", "auto"
    /// The cursor indicates an alias of something is to be created
    static member inline cursorAlias: JSX.Style = "cursor", "alias"
    /// The platform-dependent default cursor. Typically an arrow.
    static member inline cursorDefaultCursor: JSX.Style = "cursor", "default"
    /// No cursor is rendered.
    static member inline cursorNone: JSX.Style = "cursor", "none"
    /// A context menu is available.
    static member inline cursorContextMenu: JSX.Style = "cursor", "context-menu"
    /// Help information is available.
    static member inline cursorHelp: JSX.Style = "cursor", "help"
    /// The cursor is a pointer that indicates a link. Typically an image of a pointing hand.
    static member inline cursorPointer: JSX.Style = "cursor", "pointer"
    /// The program is busy in the background, but the user can still interact with the interface (in contrast to `wait`).
    static member inline cursorProgress: JSX.Style = "cursor", "progress"
    /// The program is busy, and the user can't interact with the interface (in contrast to progress). Sometimes an image of an hourglass or a watch.
    static member inline cursorWait: JSX.Style = "cursor", "wait"
    /// The table cell or set of cells can be selected.
    static member inline cursorCell: JSX.Style = "cursor", "cell"
    /// Cross cursor, often used to indicate selection in a bitmap.
    static member inline cursorCrosshair: JSX.Style = "cursor", "crosshair"
    /// The text can be selected. Typically the shape of an I-beam.
    static member inline cursorText: JSX.Style = "cursor", "text"
    /// The vertical text can be selected. Typically the shape of a sideways I-beam.
    static member inline cursorVerticalText: JSX.Style = "cursor", "vertical-text"
    /// Something is to be copied.
    static member inline cursorCopy: JSX.Style = "cursor", "copy"
    /// Something is to be moved.
    static member inline cursorMove: JSX.Style = "cursor", "move"
    /// An item may not be dropped at the current location. On Windows and Mac OS X, `no-drop` is the same as `not-allowed`.
    static member inline cursorNoDrop: JSX.Style = "cursor", "no-drop"
    /// The requested action will not be carried out.
    static member inline cursorNotAllowed: JSX.Style = "cursor", "not-allowed"
    /// Something can be grabbed (dragged to be moved).
    static member inline cursorGrab: JSX.Style = "cursor", "grab"
    /// Something is being grabbed (dragged to be moved).
    static member inline cursorGrabbing: JSX.Style = "cursor", "grabbing"
    /// Something can be scrolled in any direction (panned).
    static member inline cursorAllScroll: JSX.Style = "cursor", "all-scroll"
    /// The item/column can be resized horizontally. Often rendered as arrows pointing left and right with a vertical bar separating them.
    static member inline cursorColumnResize: JSX.Style = "cursor", "col-resize"
    /// The item/row can be resized vertically. Often rendered as arrows pointing up and down with a horizontal bar separating them.
    static member inline cursorRowResize: JSX.Style = "cursor", "row-resize"
    /// Directional resize arrow
    static member inline cursorNorthResize: JSX.Style = "cursor", "n-resize"
    /// Directional resize arrow
    static member inline cursorEastResize: JSX.Style = "cursor", "e-resize"
    /// Directional resize arrow
    static member inline cursorSouthResize: JSX.Style = "cursor", "s-resize"
    /// Directional resize arrow
    static member inline cursorWestResize: JSX.Style = "cursor", "w-resize"
    /// Directional resize arrow
    static member inline cursorNorthEastResize: JSX.Style = "cursor", "ne-resize"
    /// Directional resize arrow
    static member inline cursorNorthWestResize: JSX.Style = "cursor", "nw-resize"
    /// Directional resize arrow
    static member inline cursorSouthEastResize: JSX.Style = "cursor", "se-resize"
    /// Directional resize arrow
    static member inline cursorSouthWestResize: JSX.Style = "cursor", "sw-resize"
    /// Directional resize arrow
    static member inline cursorEastWestResize: JSX.Style = "cursor", "ew-resize"
    /// Directional resize arrow
    static member inline cursorNorthSouthResize: JSX.Style = "cursor", "ns-resize"
    /// Directional resize arrow
    static member inline cursorNorthEastSouthWestResize: JSX.Style = "cursor", "nesw-resize"
    /// Directional resize arrow
    static member inline cursorNorthWestSouthEastResize: JSX.Style = "cursor", "nwse-resize"
    /// Something can be zoomed (magnified) in
    static member inline cursorZoomIn: JSX.Style = "cursor", "zoom-in"
    /// Something can be zoomed out
    static member inline cursorZoomOut: JSX.Style = "cursor", "zoom-out"

    /// Permits the user agent to render a custom outline style.
    static member inline outlineStyleAuto: JSX.Style = "outline-style", "auto"
    /// Specifies no outline. This is default.
    static member inline outlineStyleNone: JSX.Style = "outline-style", "none"
    /// Specifies a hidden outline
    static member inline outlineStyleHidden: JSX.Style = "outline-style", "hidden"
    /// Specifies a dotted outline
    static member inline outlineStyleDotted: JSX.Style = "outline-style", "dotted"
    /// Specifies a dashed outline
    static member inline outlineStyleDashed: JSX.Style = "outline-style", "dashed"
    /// Specifies a solid outline
    static member inline outlineStyleSolid: JSX.Style = "outline-style", "solid"
    /// Specifies a double outliner
    static member inline outlineStyleDouble: JSX.Style = "outline-style", "double"
    /// Specifies a 3D grooved outline. The effect depends on the outline-color value
    static member inline outlineStyleGroove: JSX.Style = "outline-style", "groove"
    /// Specifies a 3D ridged outline. The effect depends on the outline-color value
    static member inline outlineStyleRidge: JSX.Style = "outline-style", "ridge"
    /// Specifies a 3D inset  outline. The effect depends on the outline-color value
    static member inline outlineStyleInset: JSX.Style = "outline-style", "inset"
    /// Specifies a 3D outset outline. The effect depends on the outline-color value
    static member inline outlineStyleOutset: JSX.Style = "outline-style", "outset"
    /// Sets this property to its default value
    static member inline outlineStyleInitial: JSX.Style = "outline-style", "initial"
    /// Inherits this property from its parent element
    static member inline outlineStyleInheritFromParent: JSX.Style = "outline-style", "inherit"

    /// Sets the initial position for each background image.
    ///
    /// The position is relative to the position layer set by background-origin.
    static member inline backgroundPosition(position: string): JSX.Style = "background-position", position
    /// The background image will scroll with the page. This is default.
    static member inline backgroundPositionScroll: JSX.Style = "background-position", "scroll"
    /// The background image will not scroll with the page.
    static member inline backgroundPositionFixedNoScroll: JSX.Style = "background-position", "fixed"
    /// The background image will scroll with the element's contents.
    static member inline backgroundPositionLocal: JSX.Style = "background-position", "local"
    /// Sets this property to its default value.
    static member inline backgroundPositionInitial: JSX.Style = "background-position", "initial"
    /// Inherits this property from its parent element.
    static member inline backgroundPositionInheritFromParent: JSX.Style = "background-position", "inherit"

    /// This is default. Sets the blending mode to normal.
    static member inline backgroundBlendModeNormal: JSX.Style = "background-blend-mode", "normal"
    /// Sets the blending mode to screen
    static member inline backgroundBlendModeScreen: JSX.Style = "background-blend-mode", "screen"
    /// Sets the blending mode to overlay
    static member inline backgroundBlendModeOverlay: JSX.Style = "background-blend-mode", "overlay"
    /// Sets the blending mode to darken
    static member inline backgroundBlendModeDarken: JSX.Style = "background-blend-mode", "darken"
    /// Sets the blending mode to multiply
    static member inline backgroundBlendModeLighten: JSX.Style = "background-blend-mode", "lighten"
    /// Sets the blending mode to color-dodge
    static member inline backgroundBlendModeCollorDodge: JSX.Style = "background-blend-mode", "color-dodge"
    /// Sets the blending mode to saturation
    static member inline backgroundBlendModeSaturation: JSX.Style = "background-blend-mode", "saturation"
    /// Sets the blending mode to color
    static member inline backgroundBlendModeColor: JSX.Style = "background-blend-mode", "color"
    /// Sets the blending mode to luminosity
    static member inline backgroundBlendModeLuminosity: JSX.Style = "background-blend-mode", "luminosity"

    /// Default value. The background extends behind the border.
    static member inline backgroundClipBorderBox: JSX.Style = "background-clip", "border-box"
    /// The background extends to the inside edge of the border.
    static member inline backgroundClipPaddingBox: JSX.Style = "background-clip", "padding-box"
    /// The background extends to the edge of the content box.
    static member inline backgroundClipContentBox: JSX.Style = "background-clip", "content-box"
    /// Sets this property to its default value.
    static member inline backgroundClipInitial: JSX.Style = "background-clip", "initial"
    /// Inherits this property from its parent element.
    static member inline backgroundClipInheritFromParent: JSX.Style = "background-clip", "inherit"

    static member inline transform(transformation: ITransformProperty): JSX.Style =
        "transform", (asString transformation)
    static member inline transform(transformations: ITransformProperty list): JSX.Style =
        "transform", (String.concat " " (transformations |> List.map asString))
    /// Defines that there should be no transformation.
    static member inline transformNone: JSX.Style = "transform", "none"
    /// Defines a 2D transformation, using a matrix of six values.
    static member inline transformMatrix(x1: int, y1: int, z1: int, x2: int, y2: int, z2: int): JSX.Style = "transform", ("matrix(" + (asString x1) + "," + (asString y1) + "," + (asString z1) + "," + (asString x2) + "," + (asString y2) + ", " + (asString z2) + ")")
    /// Defines a 2D translation.
    static member inline transformTranslate(x: int, y: int): JSX.Style = "transform", ("translate(" + (asString x) + "px," + (asString y) + "px)")
    /// Defines a 2D translation.
    static member inline transformTranslate(x: ICssUnit, y: ICssUnit): JSX.Style = "transform", ("translate(" + (asString x) + ", " + (asString y) + ")")
    /// Defines a 3D translation.
    static member inline transformTranslate3D(x: int, y: int, z: int): JSX.Style = "transform", ("translate3d(" + (asString x) + "px," + (asString y) + "px," + (asString z) + "px)")
    /// Defines a 3D translation.
    static member inline transformTranslate3D(x: ICssUnit, y: ICssUnit, z: ICssUnit): JSX.Style = "transform", ("translate3d(" + (asString x) + "," + (asString y) + ", " + (asString z) + ")")
    /// Defines a translation, using only the value for the X-axis.
    static member inline transformTranslateX(x: int): JSX.Style = "transform", ("translateX(" + (asString x) + "px)")
    /// Defines a translation, using only the value for the X-axis.
    static member inline transformTranslateX(x: ICssUnit): JSX.Style = "transform", ("translateX(" + (asString x) + ")")
    /// Defines a translation, using only the value for the Y-axis
    static member inline transformTranslateY(y: int): JSX.Style = "transform", ("translateY(" + (asString y) + "px)")
    /// Defines a translation, using only the value for the Y-axis
    static member inline transformTranslateY(y: ICssUnit): JSX.Style = "transform", ("translateY(" + (asString y) + ")")
    /// Defines a 3D translation, using only the value for the Z-axis
    /// Defines a 3D translation, using only the value for the Z-axis
    static member inline transformTranslateZ(z: ICssUnit): JSX.Style = "transform", ("translateZ(" + (asString z) + ")")
    /// Defines a 2D scale transformation.
    static member inline transformScale(x: int, y: int): JSX.Style = "transform", ("scale(" + (asString x) + ", " + (asString y) + ")")
    /// Defines a scale transformation.
    /// Defines a scale transformation.
    static member inline transformScale(n: float): JSX.Style = "transform", ("scale(" + (asString n) + ")")
    /// Defines a 3D scale transformation
    static member inline transformScale3D(x: int, y: int, z: int): JSX.Style = "transform", ("scale3d(" + (asString x) + "," + (asString y) + ", " + (asString z) + ")")
    /// Defines a scale transformation by giving a value for the X-axis.
    static member inline transformScaleX(x: int): JSX.Style = "transform", ("scaleX(" + (asString x) + ")")
    /// Defines a scale transformation by giving a value for the Y-axis.
    static member inline transformScaleY(y: int): JSX.Style = "transform", ("scaleY(" + (asString y) + ")")
    /// Defines a 3D translation, using only the value for the Z-axis
    static member inline transformScaleZ(z: int): JSX.Style = "transform", ("scaleZ(" + (asString z) + ")")
    /// Defines a 2D rotation, the angle is specified in the parameter.
    static member inline transformRotate(deg: int): JSX.Style = "transform", ("rotate(" + (asString deg) + "deg)")
    /// Defines a 2D rotation, the angle is specified in the parameter.
    static member inline transformRotate(deg: float): JSX.Style = "transform", ("rotate(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the X-axis.
    static member inline transformRotateX(deg: float): JSX.Style = "transform", ("rotateX(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the X-axis.
    static member inline transformRotateX(deg: int): JSX.Style = "transform", ("rotateX(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the Y-axis
    static member inline transformRotateY(deg: float): JSX.Style = "transform", ("rotateY(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the Y-axis
    static member inline transformRotateY(deg: int): JSX.Style = "transform", ("rotateY(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the Z-axis
    static member inline transformRotateZ(deg: float): JSX.Style = "transform", ("rotateZ(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the Z-axis
    static member inline transformRotateZ(deg: int): JSX.Style = "transform", ("rotateZ(" + (asString deg) + "deg)")
    /// Defines a 2D skew transformation along the X- and the Y-axis.
    static member inline transformSkew(xAngle: int, yAngle: int): JSX.Style = "transform", ("skew(" + (asString xAngle) + "deg," + (asString yAngle) + "deg)")
    /// Defines a 2D skew transformation along the X- and the Y-axis.
    static member inline transformSkew(xAngle: float, yAngle: float): JSX.Style = "transform", ("skew(" + (asString xAngle) + "deg," + (asString yAngle) + "deg)")
    /// Defines a 2D skew transformation along the X-axis
    static member inline transformSkewX(xAngle: int): JSX.Style = "transform", ("skewX(" + (asString xAngle) + "deg)")
    /// Defines a 2D skew transformation along the X-axis
    static member inline transformSkewX(xAngle: float): JSX.Style = "transform", ("skewX(" + (asString xAngle) + "deg)")
    /// Defines a 2D skew transformation along the Y-axis
    static member inline transformSkewY(xAngle: int): JSX.Style = "transform", ("skewY(" + (asString xAngle) + "deg)")
    /// Defines a 2D skew transformation along the Y-axis
    static member inline transformSkewY(xAngle: float): JSX.Style = "transform", ("skewY(" + (asString xAngle) + "deg)")
    /// Defines a perspective view for a 3D transformed element
    static member inline transformPerspective(n: int): JSX.Style = "transform", ("perspective(" + (asString n) + ")")
    /// Sets this property to its default value.
    static member inline transformInitial: JSX.Style = "transform", "initial"
    /// Inherits this property from its parent element.
    static member inline transformInheritFromParent: JSX.Style = "transform", "inherit"

    /// Text direction goes from right-to-left
    static member inline directionRightToLeft: JSX.Style = "direction", "rtl"
    /// Text direction goes from left-to-right. This is default
    static member inline directionLeftToRight: JSX.Style = "direction", "ltr"
    /// Sets this property to its default value.
    static member inline directionInitial: JSX.Style = "direction", "initial"
    /// Inherits this property from its parent element.
    static member inline directionInheritFromParent: JSX.Style = "direction", "inherit"

    /// Display borders on empty cells. This is default
    static member inline emptyCellsShow: JSX.Style = "empty-cells", "show"
    /// Hide borders on empty cells
    static member inline emptyCellsHide: JSX.Style = "empty-cells", "hide"
    /// Sets this property to its default value
    static member inline emptyCellsInitial: JSX.Style = "empty-cells", "initial"
    /// Inherits this property from its parent element
    static member inline emptyCellsInheritFromParent: JSX.Style = "empty-cells", "inherit"

    /// Default value. The animation should be played as normal
    static member inline animationDirectionNormal: JSX.Style = "animation-direction", "normal"
    /// The animation should play in reverse direction
    static member inline animationDirectionReverse: JSX.Style = "animation-direction", "reverse"
    /// The animation will be played as normal every odd time (1, 3, 5, etc..) and in reverse direction every even time (2, 4, 6, etc...).
    static member inline animationDirectionAlternate: JSX.Style = "animation-direction", "alternate"
    /// The animation will be played in reverse direction every odd time (1, 3, 5, etc..) and in a normal direction every even time (2,4,6,etc...)
    static member inline animationDirectionAlternateReverse: JSX.Style = "animation-direction", "alternate-reverse"
    /// Sets this property to its default value
    static member inline animationDirectionInitial: JSX.Style = "animation-direction", "initial"
    /// Inherits this property from its parent element.
    static member inline animationDirectionInheritFromParent: JSX.Style = "animation-direction", "inherit"

    /// Default value. Specifies that the animation is running.
    static member inline animationPlayStateRunning: JSX.Style = "animation-play-state", "running"
    /// Specifies that the animation is paused
    static member inline animationPlayStatePaused: JSX.Style = "animation-play-state", "paused"
    /// Sets this property to its default value
    static member inline animationPlayStateInitial: JSX.Style = "animation-play-state", "initial"
    /// Inherits this property from its parent element.
    static member inline animationPlayStateInheritFromParent: JSX.Style = "animation-play-state", "inherit"

    /// Specifies that the animation should be played infinite times (forever)
    static member inline animationIterationCountInfinite: JSX.Style = "animation-iteration-count", "infinite"
    /// Sets this property to its default value
    static member inline animationIterationCountInitial: JSX.Style = "animation-iteration-count", "initial"
    /// Inherits this property from its parent element.
    static member inline animationIterationCountInheritFromParent: JSX.Style = "animation-iteration-count", "inherit"

    /// Default value. Animation will not apply any styles to the element before or after it is executing
    static member inline animationFillModeNone: JSX.Style = "animation-fill-mode", "none"
    /// The element will retain the style values that is set by the last keyframe (depends on animation-direction and animation-iteration-count).
    static member inline animationFillModeForwards: JSX.Style = "animation-fill-mode", "forwards"
    /// The element will get the style values that is set by the first keyframe (depends on animation-direction), and retain this during the animation-delay period
    static member inline animationFillModeBackwards: JSX.Style = "animation-fill-mode", "backwards"
    /// The animation will follow the rules for both forwards and backwards, extending the animation properties in both directions
    static member inline animationFillModeBoth: JSX.Style = "animation-fill-mode", "both"
    /// Sets this property to its default value
    static member inline animationFillModeInitial: JSX.Style = "animation-fill-mode", "initial"
    /// Inherits this property from its parent element
    static member inline animationFillModeInheritFromParent: JSX.Style = "animation-fill-mode", "inherit"

    /// Sets how background images are repeated.
    ///
    /// A background image can be repeated along the horizontal and vertical axes, or not repeated at all.
    static member inline backgroundRepeat(repeat: IBackgroundRepeat): JSX.Style = "background-repeat", (asString repeat)
    /// The background image is repeated both vertically and horizontally. This is default.
    static member inline backgroundRepeatRepeat: JSX.Style = "background-repeat", "repeat"
    /// The background image is only repeated horizontally.
    static member inline backgroundRepeatRepeatX: JSX.Style = "background-repeat", "repeat-x"
    /// The background image is only repeated vertically.
    static member inline backgroundRepeatRepeatY: JSX.Style = "background-repeat", "repeat-y"
    /// The background-image is not repeated.
    static member inline backgroundRepeatNoRepeat: JSX.Style = "background-repeat", "no-repeat"
    /// Sets this property to its default value.
    static member inline backgroundRepeatInitial: JSX.Style = "background-repeat", "initial"
    /// Inherits this property from its parent element.
    static member inline backgroundRepeatInheritFromParent: JSX.Style = "background-repeat", "inherit"

    /// Default value. Elements render in order, as they appear in the document flow.
    static member inline positionDefaultStatic: JSX.Style = "position", "static"
    /// The element is positioned relative to its first positioned (not static) ancestor element.
    static member inline positionAbsolute: JSX.Style = "position", "absolute"
    /// The element is positioned relative to the browser window
    static member inline positionFixed: JSX.Style = "position", "fixed"
    /// The element is positioned relative to its normal position, so "left:20px" adds 20 pixels to the element's LEFT position.
    static member inline positionRelative: JSX.Style = "position", "relative"
    /// The element is positioned based on the user's scroll position
    ///
    /// A sticky element toggles between relative and fixed, depending on the scroll position. It is positioned relative until a given offset position is met in the viewport - then it "sticks" in place (like position:fixed).
    ///
    /// Note: Not supported in IE/Edge 15 or earlier. Supported in Safari from version 6.1 with a -webkit- prefix.
    static member inline positionSticky: JSX.Style = "position", "sticky"
    static member inline positionInitial: JSX.Style = "position", "initial"
    /// Inherits this property from its parent element.
    static member inline positionInheritFromParent: JSX.Style = "position", "inherit"

    /// Default value. The width and height properties include the content, but does not include the padding, border, or margin.
    static member inline boxSizingContentBox: JSX.Style = "box-sizing", "content-box"
    /// The width and height properties include the content, padding, and border, but do not include the margin. Note that padding and border will be inside of the box.
    static member inline boxSizingBorderBox: JSX.Style = "box-sizing", "border-box"
    /// Sets this property to its default value.
    static member inline boxSizingInitial: JSX.Style = "box-sizing", "initial"
    /// Inherits this property from its parent element.
    static member inline boxSizingInheritFromParent: JSX.Style = "box-sizing", "inherit"

    /// Default value. The element offers no user-controllable method for resizing it.
    static member inline resizeNone: JSX.Style = "resize", "none"
    /// The element displays a mechanism for allowing the user to resize it, which may be resized both horizontally and vertically.
    static member inline resizeBoth: JSX.Style = "resize", "both"
    /// The element displays a mechanism for allowing the user to resize it in the horizontal direction.
    static member inline resizeHorizontal: JSX.Style = "resize", "horizontal"
    /// The element displays a mechanism for allowing the user to resize it in the vertical direction.
    static member inline resizeVertical: JSX.Style = "resize", "vertical"
    /// The element displays a mechanism for allowing the user to resize it in the block direction (either horizontally or vertically, depending on the writing-mode and direction value).
    static member inline resizeBlock: JSX.Style = "resize", "block"
    /// The element displays a mechanism for allowing the user to resize it in the inline direction (either horizontally or vertically, depending on the writing-mode and direction value).
    static member inline resizeInline': JSX.Style = "resize", "inline"
    /// Sets this property to its default value.
    static member inline resizeInitial: JSX.Style = "resize", "initial"
    /// Inherits this property from its parent element.
    static member inline resizeInheritFromParent: JSX.Style = "resize", "inherit"

    /// Aligns the text to the left.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align
    static member inline textAlignLeft: JSX.Style = "text-align", "left"
    /// Aligns the text to the right.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=right
    static member inline textAlignRight: JSX.Style = "text-align", "right"
    /// Centers the text.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=center
    static member inline textAlignCenter: JSX.Style = "text-align", "center"
    /// Stretches the lines so that each line has equal width (like in newspapers and magazines).
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=justify
    static member inline textAlignJustify: JSX.Style = "text-align", "justify"
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    static member inline textAlignInitial: JSX.Style = "text-align", "initial"
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    static member inline textAlignInheritFromParent: JSX.Style = "text-align", "inherit"

    /// Displays an element as an inline element (like `<span> `). Any height and width properties will have no effect.
    static member inline displayInlineElement: JSX.Style = "display", "inline"
    /// Displays an element as a block element (like `<p> `). It starts on a new line, and takes up the whole width.
    static member inline displayBlock: JSX.Style = "display", "block"
    /// Makes the container disappear, making the child elements children of the element the next level up in the DOM.
    static member inline displayContents: JSX.Style = "display", "contents"
    /// Displays an element as a block-level flex container.
    static member inline displayFlex: JSX.Style = "display", "flex"
    /// Displays an element as a block container box, and lays out its contents using flow layout.
    ///
    /// It always establishes a new block formatting context for its contents.
    static member inline displayFlowRoot: JSX.Style = "display", "flow-root"
    /// Displays an element as a block-level grid container.
    static member inline displayGrid: JSX.Style = "display", "grid"
    /// Displays an element as an inline-level block container. The element itself is formatted as an inline element, but you can apply height and width values.
    static member inline displayInlineBlock: JSX.Style = "display", "inline-block"
    /// Displays an element as an inline-level flex container.
    static member inline displayInlineFlex: JSX.Style = "display", "inline-flex"
    /// Displays an element as an inline-level grid container
    static member inline displayInlineGrid: JSX.Style = "display", "inline-grid"
    /// The element is displayed as an inline-level table.
    static member inline displayInlineTable: JSX.Style = "display", "inline-table"
    /// Let the element behave like a `<li> ` element
    static member inline displayListItem: JSX.Style = "display", "list-item"
    /// Displays an element as either block or inline, depending on context.
    static member inline displayRunIn: JSX.Style = "display", "run-in"
    /// Let the element behave like a `<table> ` element.
    static member inline displayTable: JSX.Style = "display", "table"
    /// Let the element behave like a <caption> element.
    static member inline displayTableCaption: JSX.Style = "display", "table-caption"
    /// Let the element behave like a <colgroup> element.
    static member inline displayTableColumnGroup: JSX.Style = "display", "table-column-group"
    /// Let the element behave like a <thead> element.
    static member inline displayTableHeaderGroup: JSX.Style = "display", "table-header-group"
    /// Let the element behave like a <tfoot> element.
    static member inline displayTableFooterGroup: JSX.Style = "display", "table-footer-group"
    /// Let the element behave like a <tbody> element.
    static member inline displayTableRowGroup: JSX.Style = "display", "table-row-group"
    /// Let the element behave like a <td> element.
    static member inline displayTableCell: JSX.Style = "display", "table-cell"
    /// Let the element behave like a <col> element.
    static member inline displayTableColumn: JSX.Style = "display", "table-column"
    /// Let the element behave like a <tr> element.
    static member inline displayTableRow: JSX.Style = "display", "table-row"
    /// The element is completely removed.
    static member inline displayNone: JSX.Style = "display", "none"
    /// Sets this property to its default value.
    static member inline displayInitial: JSX.Style = "display", "initial"
    /// Inherits this property from its parent element.
    static member inline displayInheritFromParent: JSX.Style = "display", "inherit"

    /// The zIndex property sets or returns the stack order of a positioned element.
    ///
    /// An element with greater stack order (1) is always in front of another element with lower stack order (0).
    ///
    /// **Tip**: A positioned element is an element with the position property set to: relative, absolute, or fixed.
    ///
    /// **Tip**: This property is useful if you want to create overlapping elements.
    static member inline zIndex(value: int): JSX.Style = "z-index", (asString value)

    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(value: int): JSX.Style = "margin", (asString value + "px")
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(value: ICssUnit): JSX.Style = "margin", (asString value)
    /// Sets the margin area on the vertical and horizontal axis.
    static member inline margin(vertical: int, horizonal: int): JSX.Style =
        "margin", (
            (asString vertical) + "px " +
            (asString horizonal) + "px"
        )
    /// Sets the margin area on the vertical and horizontal axis.
    static member inline margin(vertical: ICssUnit, horizonal: ICssUnit): JSX.Style =
        "margin", (
            (asString vertical) + " " +
            (asString horizonal)
        )
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(top: int, right: int, bottom: int, left: int): JSX.Style =
        "margin", (
            (asString top) + "px " +
            (asString right) + "px " +
            (asString bottom) + "px " +
            (asString left) + "px"
        )
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(top: ICssUnit, right: ICssUnit, bottom: ICssUnit, left: ICssUnit): JSX.Style =
        "margin", (
            (asString top) + " " +
            (asString right) + " " +
            (asString bottom) + " " +
            (asString left)
        )
    /// Sets the margin area on the left side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginLeft(value: int): JSX.Style = "margin-left", (asString value + "px")
    /// Sets the margin area on the left side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginLeft(value: ICssUnit): JSX.Style = "margin-left", (asString value)
    /// sets the margin area on the right side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginRight(value: int): JSX.Style = "margin-right", (asString value + "px")
    /// sets the margin area on the right side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginRight(value: ICssUnit): JSX.Style = "margin-right", (asString value)
    /// Sets the margin area on the top of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginTop(value: int): JSX.Style = "margin-top", (asString value + "px")
    /// Sets the margin area on the top of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginTop(value: ICssUnit): JSX.Style = "margin-top", (asString value)
    /// Sets the margin area on the bottom of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginBottom(value: int): JSX.Style = "margin-bottom", (asString value + "px")
    /// Sets the margin area on the bottom of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginBottom(value: ICssUnit): JSX.Style = "margin-bottom", (asString value)

    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(value: int): JSX.Style = "padding", (asString value + "px")
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(value: ICssUnit): JSX.Style = "padding", (asString value)
    /// Sets the padding area for vertical and horizontal axis.
    static member inline padding(vertical: ICssUnit, horizontal: ICssUnit): JSX.Style =
        "padding", (
            (asString vertical) + " " +
            (asString horizontal)
        )
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(top: ICssUnit, right: ICssUnit, bottom: ICssUnit, left: ICssUnit): JSX.Style =
        "padding", (
            (asString top) + " " +
            (asString right) + " " +
            (asString bottom) + " " +
            (asString left)
        )
    /// Sets the height of the padding area on the bottom of an element.
    static member inline paddingBottom(value: int): JSX.Style = "padding-bottom", (asString value + "px")
    /// Sets the height of the padding area on the bottom of an element.
    static member inline paddingBottom(value: ICssUnit): JSX.Style = "padding-bottom", (asString value)
    /// Sets the width of the padding area to the left of an element.
    static member inline paddingLeft(value: int): JSX.Style = "padding-left", (asString value + "px")
    /// Sets the width of the padding area to the left of an element.
    static member inline paddingLeft(value: ICssUnit): JSX.Style = "padding-left", (asString value)
    /// Sets the width of the padding area on the right of an element.
    static member inline paddingRight(value: int): JSX.Style = "padding-right", (asString value + "px")
    /// Sets the width of the padding area on the right of an element.
    static member inline paddingRight(value: ICssUnit): JSX.Style = "padding-right", (asString value)
    /// Sets the height of the padding area on the top of an element.
    static member inline paddingTop(value: int): JSX.Style = "padding-top", (asString value + "px")
    /// Sets the height of the padding area on the top of an element.
    static member inline paddingTop(value: ICssUnit): JSX.Style = "padding-top", (asString value)

    /// Sets the flex shrink factor of a flex item. If the size of all flex items is larger than
    /// the flex container, items shrink to fit according to flex-shrink.
    static member inline flexShrink(value: int): JSX.Style = "flex-shrink", (asString value)
    /// Sets the initial main size of a flex item. It sets the size of the content box unless
    /// otherwise set with box-sizing.
    static member inline flexBasis (value: int): JSX.Style = "flex-basis", (asString value + "px")
    /// Sets the initial main size of a flex item. It sets the size of the content box unless
    /// otherwise set with box-sizing.
    static member inline flexBasis (value: ICssUnit): JSX.Style = "flex-basis", (asString value)
    /// Sets the flex grow factor of a flex item main size. It specifies how much of the remaining
    /// space in the flex container should be assigned to the item (the flex grow factor).
    static member inline flexGrow (value: int): JSX.Style = "flex-grow", (asString value)
    /// Shorthand of flex-grow, flex-shrink and flex-basis
    static member inline flex (grow: int, ?shrink: int, ?basis: ICssUnit): JSX.Style = "flex", (asString grow + " " + asString shrink + " " + asString basis)
    /// Shorthand of flex-grow, flex-shrink and flex-basis
    static member inline flex (value: string): JSX.Style = "flex", value

    /// Sets the width of each individual grid column in pixels.
    ///
    /// **CSS**
    /// ```css
    /// grid-template-columns: 100px 200px 100px;
    /// ```
    /// **F#**
    /// ```f#
    /// gridTemplateColumns: [100; 200; 100]
    /// ```
    static member inline gridTemplateColumns(value: int seq): JSX.Style =
        let addPixels = fun x -> x + "px"
        "grid-template-columns", (value |> Seq.map (asString >> addPixels) |> String.concat " ")
    /// Sets the width of each individual grid column.
    ///
    /// **CSS**
    /// ```css
    /// grid-template-columns: 1fr 1fr 2fr;
    /// ```
    /// **F#**
    /// ```f#
    /// gridTemplateColumns: [length.fr 1; length.fr 1; length.fr 2]
    /// ```
    static member inline gridTemplateColumns(value: ICssUnit seq): JSX.Style =
        "grid-template-columns", (value |> Seq.map asString |> String.concat " ")
    /// Sets the width of each individual grid column. It can also name the lines between them
    /// There can be multiple names for the same line
    ///
    /// **CSS**
    /// ```css
    /// grid-template-columns: [first-line] auto [first-line-end second-line-start] 100px [second-line-end];
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateColumns [
    ///     grid.namedLine "first-line"
    ///     grid.templateWidth length.auto
    ///     grid.namedLines ["first-line-end second-line-start"]
    ///     grid.templateWidth 100
    ///     grid.namedLine "second-line-end"
    /// ]
    /// ```
    static member inline gridTemplateColumns(value: IGridTemplateItem seq): JSX.Style =
        "grid-template-columns", (value |> Seq.map asString |> String.concat " ")
    /// Sets the width of a number of grid columns to the defined width, as well as naming the lines between them
    ///
    /// **CSS**
    /// ```css
    /// grid-template-columns: repeat(3, 1fr [col-start]);
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateColumns (3, length.fr 1, "col-start")
    /// ```
    static member inline gridTemplateColumns(count: int, size: ICssUnit, ?areaName: string): JSX.Style =
        let areaName = match areaName with Some n -> " [" + n + "]" | None -> ""
        "grid-template-columns", (
            "repeat(" +
            (asString count) + ", " +
            (asString size) + areaName + ")"
        )
    /// Sets the width of a number of grid rows to the defined width
    ///
    /// **CSS**
    /// ```css
    /// grid-template-rows: 100px 200px 100px;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateRows [100, 200, 100]
    /// ```
    static member inline gridTemplateRows(value: int seq): JSX.Style =
        let addPixels = (fun x -> x + "px")
        "grid-template-rows", (value |> Seq.map (asString >> addPixels) |> String.concat " ")
    /// Sets the width of a number of grid rows to the defined width
    ///
    /// **CSS**
    /// ```css
    /// grid-template-rows: 1fr 10% 250px auto;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateRows [length.fr 1; length.percent 10; length.px 250; length.auto]
    /// ```
    static member inline gridTemplateRows(value: ICssUnit seq): JSX.Style =
        "grid-template-rows", (value |> Seq.map asString |> String.concat " ")
    /// Sets the width of a number of grid rows to the defined width as well as naming the spaces between
    ///
    /// **CSS**
    /// ```css
    /// grid-template-rows: [row-1-start] 1fr [row-1-end row-2-start] 1fr [row-2-end];
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateRows [
    ///     grid.namedLine "row-1-start"
    ///     grid.templateWidth (length.fr 1)
    ///     grid.namedLines ["row-1-end"; "row-2-start"]
    ///     grid.templateWidth (length.fr 1)
    ///     grid.namedLine "row-2-end"
    /// ]
    /// ```
    static member inline gridTemplateRows(value: IGridTemplateItem seq): JSX.Style =
        "grid-template-rows", (value |> Seq.map asString |> String.concat " ")
    /// Sets the width of a number of grid rows to the defined width
    ///
    /// **CSS**
    /// ```css
    /// grid-template-rows: repeat(3, 10%);
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateRows (3, length.percent 10)
    /// ```
    static member inline gridTemplateRows(count: int, size: ICssUnit, ?areaName: string): JSX.Style =
        let areaName = match areaName with Some n -> " [" + n + "]" | None -> ""
        "grid-template-rows", (
            "repeat("+
            (asString count) + ", " +
            (asString size) + areaName + ")"
        )
    /// 2D representation of grid layout as blocks with names
    ///
    /// **CSS**
    /// ```css
    /// grid-template-areas:
    ///     'header header header header'
    ///     'nav nav . sidebar'
    ///     'footer footer footer footer';
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateAreas [
    ///     ["header"; "header"; "header"; "header" ]
    ///     ["nav"   ; "nav"   ; "."     ; "sidebar"]
    ///     ["footer"; "footer"; "footer"; "footer" ]
    /// ]
    /// ```
    static member inline gridTemplateAreas(value: string list list): JSX.Style =
        let wrapLine = (fun x -> "'" + x + "'")
        let lines = List.map (String.concat " " >> wrapLine) value
        let block = String.concat "\n" lines
        "grid-template-areas", block
    /// 2D representation of grid layout as blocks with names
    ///
    /// **CSS**
    /// ```css
    /// grid-template-areas:
    ///     'header header header header'
    ///     'nav nav . sidebar'
    ///     'footer footer footer footer';
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateAreas [|
    ///     [|"header"; "header"; "header"; "header" |]
    ///     [|"nav"   ; "nav"   ; "."     ; "sidebar"|]
    ///     [|"footer"; "footer"; "footer"; "footer" |]
    /// |]
    /// ```
    static member inline gridTemplateAreas(value: string[][]): JSX.Style =
        let wrapLine = (fun x -> "'" + x + "'")
        let lines = Array.map (String.concat " " >> wrapLine) value
        let block = String.concat "\n" lines
        "grid-template-areas", block
    /// One-dimensional alternative to the nested list. For column-based layouts
    ///
    /// **CSS**
    /// ```css
    /// grid-template-areas: 'first second third fourth';
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateAreas ["first"; "second"; "third"; "fourth"]
    /// ```
    static member inline gridTemplateAreas(value: string seq): JSX.Style =
        let block = String.concat " " value
        "grid-template-areas", ("'" + block + "'")
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the columns.
    ///
    /// **CSS**
    /// ```css
    /// column-gap: 10px;
    /// ```
    /// **F#**
    /// ```f#
    /// style.columnGap 10
    /// ```
    static member inline columnGap(value: int): JSX.Style =
        "column-gap", (asString value + "px")
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the columns.
    ///
    /// **CSS**
    /// ```css
    /// column-gap: 1em;
    /// ```
    /// **F#**
    /// ```f#
    /// style.columnGap (length.em 1)
    /// ```
    static member inline columnGap(value: ICssUnit): JSX.Style =
        "column-gap", (asString value)
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the rows.
    ///
    /// **CSS**
    /// ```css
    /// row-gap: 10px;
    /// ```
    /// **F#**
    /// ```f#
    /// style.rowGap 10
    /// ```
    static member inline rowGap(value: int): JSX.Style =
        "row-gap", (asString value + "px")
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the rows.
    ///
    /// **CSS**
    /// ```css
    /// row-gap: 1em;
    /// ```
    /// **F#**
    /// ```f#
    /// style.rowGap (length.em 1)
    /// ```
    static member inline rowGap(value: ICssUnit): JSX.Style =
        "row-gap", (asString value)
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the rows/columns.
    ///
    /// _Shorthand for `rowGap` and `columnGap`_
    ///
    /// **CSS**
    /// ```css
    /// gap: 1em 2em;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gap (length.em 1, length.em 2)
    /// ```
    static member inline gap(rowGap: ICssUnit, columnGap: ICssUnit): JSX.Style =
        "gap", (
            (asString rowGap) + " " +
            (asString columnGap)
        )
    static member inline gap(rowColumnGap: ICssUnit): JSX.Style =
        "gap", (
            (asString rowColumnGap) + " " +
            (asString rowColumnGap)
        )
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// When there are multiple named lines with the same name, you can specify which one by count
    ///
    /// **CSS**
    /// ```css
    /// grid-column-start: col 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnStart ("col", 2)
    /// ```
    static member inline gridColumnStart(value: string, ?count: int): JSX.Style =
        "grid-column-start", (asString value + " " + (asString count))
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-column-start: 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnStart 2
    /// ```
    static member inline gridColumnStart(value: int): JSX.Style = "grid-column-start", (asString value)
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-column-start: span odd-col;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnStart (gridColumn.span "odd-col")
    /// ```
    static member inline gridColumnStart(value: IGridSpan): JSX.Style = "grid-column-start", (asString value)
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _When there are multiple named lines with the same name, you can specify which one by count_
    ///
    /// **CSS**
    /// ```css
    /// grid-column-end: odd-col 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnEnd ("odd-col", 2)
    /// ```
    static member inline gridColumnEnd(value: string, ?count: int): JSX.Style =
        "grid-column-end", (asString value + " " + (asString count))
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-column-end: 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnEnd 2
    /// ```
    static member inline gridColumnEnd(value: int): JSX.Style = "grid-column-end", (asString value)
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-column-end: span 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnEnd (gridColumn.span 2)
    /// ```
    static member inline gridColumnEnd(value: IGridSpan): JSX.Style = "grid-column-end", (asString value)
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-start: col 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowStart ("col", 2)
    /// ```
    static member inline gridRowStart(value: string, ?count: int): JSX.Style =
        "grid-row-start", (asString value + " " + (asString count))
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-start: 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowStart 2
    /// ```
    static member inline gridRowStart(value: int): JSX.Style = "grid-row-start", (asString value)
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-start: span odd-col;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowStart (gridRow.span "odd-col")
    /// ```
    static member inline gridRowStart(value: IGridSpan): JSX.Style = "grid-row-start", (asString value)
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _When there are multiple named lines with the same name, you can specify which one by count_
    ///
    /// **CSS**
    /// ```css
    /// grid-row-end: odd-col 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowEnd ("odd-col", 2)
    /// ```
    static member inline gridRowEnd(value: string, ?count: int): JSX.Style =
        "grid-row-end", (asString value + " " + (asString count))
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-end: 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowEnd 2
    /// ```
    static member inline gridRowEnd(value: int): JSX.Style = "grid-row-end", (asString value)
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-end: span 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowEnd (gridRow.span 2)
    /// ```
    static member inline gridRowEnd(value: IGridSpan): JSX.Style = "grid-row-end", (asString value)
    /// Determines a grid item’s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridColumnStart` and `gridColumnEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-column: col-2 / col-4;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumn ("col-2", "col-4")
    /// ```
    static member inline gridColumn(start: string, end': string): JSX.Style =
        "grid-column", (start + " / " + end')
    /// Determines a grid item’s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridColumnStart` and `gridColumnEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-column: 1 / 3;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumn (1, 3)
    /// ```
    static member inline gridColumn(start: int, end': int): JSX.Style =
        "grid-column", (asString start + " / " + asString end')
    /// Determines a grid item’s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridColumnStart` and `gridColumnEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-column: span 2 / span 3;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumn (gridColumn.span 2, gridColumn.span 3)
    /// ```
    static member inline gridColumn(start: IGridSpan, end': IGridSpan): JSX.Style =
        "grid-column", (asString start + " / " + asString end')
    /// Determines a grid item’s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridRowStart` and `gridRowEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-row: row-2 / row-4;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRow ("row-2", "row-4")
    /// ```
    static member inline gridRow(start: string, end': string): JSX.Style =
        "grid-row", (start + " / " + end')
    /// Determines a grid item’s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridRowStart` and `gridRowEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-row: 2 / 4;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRow (2, 4)
    /// ```
    static member inline gridRow(start: int, end': int): JSX.Style =
        "grid-row", (asString start + " / " + asString end')
    /// Determines a grid item’s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridRowStart` and `gridRowEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-row: span 2 / span 3;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRow (gridRow.span 2, gridRow.span 3)
    /// ```
    static member inline gridRow(start: IGridSpan, end': IGridSpan): JSX.Style =
        "grid-row", (asString start + " / " + asString end')
    /// Sets the named grid area the item is placed in
    ///
    /// **CSS**
    /// ```css
    /// grid-area: header;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridArea "header"
    /// ```
    static member inline gridArea(value: string): JSX.Style =
        "grid-area", (asString value)
    /// Shorthand for `grid-template-areas`, `grid-template-columns` and `grid-template-rows`.
    ///
    /// Documentation: https://developer.mozilla.org/en-US/docs/Web/CSS/grid-template
    ///
    /// **CSS**
    /// ```css
    /// grid-template:  [header-top] 'a a a'      [header-bottom]
    ///                   [main-top] 'b b b' 1fr  [main-bottom]
    ///                              / auto 1fr auto;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplate "[header-top] 'a a a'      [header-bottom] " +
    ///                      "[main-top] 'b b b' 1fr  [main-bottom] " +
    ///                                "/ auto 1fr auto"
    /// ```
    static member inline gridTemplate(value: string): JSX.Style =
        "grid-template", (asString value)
    static member inline transition(value: string): JSX.Style =
        "transition", value
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDuration(timespan: TimeSpan): JSX.Style =
        "transition-duration", (asString timespan.TotalMilliseconds + "ms")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDurationSeconds(n: float): JSX.Style =
        "transition-duration", (asString n + "s")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDurationMilliseconds(n: float): JSX.Style =
        "transition-duration", (asString n + "ms")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDurationSeconds(n: int): JSX.Style =
        "transition-duration", (asString n + "s")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDurationMilliseconds(n: int): JSX.Style =
        "transition-duration", (asString n + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelay(timespan: TimeSpan): JSX.Style =
        "transition-delay", (asString timespan.TotalMilliseconds + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelaySeconds(n: float): JSX.Style =
        "transition-delay", (asString n + "s")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelayMilliseconds(n: float): JSX.Style =
        "transition-delay", (asString n + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelaySeconds(n: int): JSX.Style =
        "transition-delay", (asString n + "s")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelayMilliseconds(n: int): JSX.Style =
        "transition-delay", (asString n + "ms")
    /// Sets the CSS properties to which a transition effect should be applied.
    static member inline transitionProperty ([<ParamArray>] properties: ITransitionProperty[]): JSX.Style =
        "transition-property", (String.concat "," (properties |> Array.map asString))
    /// Sets the CSS properties to which a transition effect should be applied.
    static member inline transitionProperty (properties: ITransitionProperty list): JSX.Style =
        "transition-property", (String.concat "," (properties |> List.map asString))
    /// Sets the CSS properties to which a transition effect should be applied.
    static member inline transitionProperty (property: ITransitionProperty): JSX.Style =
        "transition-property", (asString property)
    /// Sets the CSS properties to which a transition effect should be applied.
    static member inline transitionProperty (property: string): JSX.Style =
        "transition-property", property

    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: int): JSX.Style = "font-size", (asString size + "px")
    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: ICssUnit): JSX.Style = "font-size", (asString size)
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: int): JSX.Style = "line-height", (asString size + "px")
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: ICssUnit): JSX.Style = "line-height", (asString size)
    /// Sets the background color of an element.
    static member inline backgroundColor (color: string): JSX.Style = "background-color", color
    /// Sets the color of the insertion caret, the visible marker where the next character typed will be inserted.
    ///
    /// This is sometimes referred to as the text input cursor. The caret appears in elements such as <input> or
    /// those with the contenteditable attribute. The caret is typically a thin vertical line that flashes to
    /// help make it more noticeable. By default, it is black, but its color can be altered with this property.
    static member inline caretColor (color: string): JSX.Style = "caret-color", color
    /// Sets the foreground color value of an element's text and text decorations, and sets the
    /// `currentcolor` value. `currentcolor` may be used as an indirect value on other properties
    /// and is the default for other color properties, such as border-color.
    static member inline color (color: string): JSX.Style = "color", color
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    static member inline top(value: int): JSX.Style = "top", (asString value + "px")
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    static member inline top(value: ICssUnit): JSX.Style = "top", (asString value)
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    static member inline bottom(value: int): JSX.Style = "bottom", (asString value + "px")
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    static member inline bottom(value: ICssUnit): JSX.Style = "bottom", (asString value)
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    static member inline left(value: int): JSX.Style = "left", (asString value + "px")
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    static member inline left(value: ICssUnit): JSX.Style = "left", (asString value)
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    static member inline right(value: int): JSX.Style = "right", (asString value + "px")
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    static member inline right(value: ICssUnit): JSX.Style = "right", (asString value)

    /// Sets an element's bottom border. It sets the values of border-bottom-width,
    /// border-bottom-style and border-bottom-color.
    static member inline borderBottom(width: ICssUnit, style: IBorderStyle, color: string): JSX.Style =
        "border-bottom", (
            (asString width) + " " +
            (asString style) + " " +
            color
        )

    /// The outline-offset property adds space between an outline and the edge or border of an element.
    ///
    /// The space between an element and its outline is transparent.
    ///
    /// Outlines differ from borders in three ways:
    ///
    ///  - An outline is a line drawn around elements, outside the border edge
    ///  - An outline does not take up space
    ///  - An outline may be non-rectangular
    ///
    static member inline outlineOffset (offset:int): JSX.Style =
        "outline-width", (asString offset + "px")

    /// The outline-offset property adds space between an outline and the edge or border of an element.
    ///
    /// The space between an element and its outline is transparent.
    ///
    /// Outlines differ from borders in three ways:
    ///
    ///  - An outline is a line drawn around elements, outside the border edge
    ///  - An outline does not take up space
    ///  - An outline may be non-rectangular
    ///
    static member inline outlineOffset (offset: ICssUnit): JSX.Style =
        "outline-width", (asString offset)

    /// An outline is a line that is drawn around elements (outside the borders) to make the element "stand out".
    ///
    /// The `outline-color` property specifies the color of an outline.

    /// **Note**: Always declare the outline-style property before the outline-color property. An element must have an outline before you change the color of it.
    static member inline outlineColor (color: string): JSX.Style =
        "outline-color", color

    /// Set an element's left border.
    static member inline borderLeft(width: ICssUnit, style: IBorderStyle, color: string): JSX.Style =
        "border-left", (
            (asString width) + " " +
            (asString style) + " " +
            color
        )
    /// Set an element's right border.
    static member inline borderRight(width: ICssUnit, style: IBorderStyle, color: string): JSX.Style =
        "border-right", (
            (asString width) + " " +
            (asString style) + " " +
            color
        )
    /// Set an element's top border.
    static member inline borderTop(width: ICssUnit, style: IBorderStyle, color: string): JSX.Style =
        "border-top", (
            (asString width) + " " +
            (asString style) + " " +
            color
        )
    /// Sets the line style of an element's bottom border.
    static member inline borderBottomStyle(style: IBorderStyle): JSX.Style = "border-bottom-style", (asString style)
    /// Sets the width of the bottom border of an element.
    static member inline borderBottomWidth (width: int): JSX.Style = "border-bottom-width", (asString width + "px")
    /// Sets the width of the bottom border of an element.
    static member inline borderBottomWidth (width: ICssUnit): JSX.Style = "border-bottom-width", (asString width)
    /// Sets the color of an element's bottom border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    static member inline borderBottomColor (color: string): JSX.Style = "border-bottom-color", color
    /// Sets the line style of an element's top border.
    static member inline borderTopStyle(style: IBorderStyle): JSX.Style = "border-top-style", (asString style)
    /// Sets the width of the top border of an element.
    static member inline borderTopWidth (width: int): JSX.Style = "border-top-width", (asString width + "px")
    /// Sets the width of the top border of an element.
    static member inline borderTopWidth (width: ICssUnit): JSX.Style = "border-top-width", (asString width)
    /// Sets the color of an element's top border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    static member inline borderTopColor (color: string): JSX.Style = "border-top-color", color
    /// Sets the line style of an element's right border.
    static member inline borderRightStyle(style: IBorderStyle): JSX.Style = "border-right-style", (asString style)
    /// Sets the width of the right border of an element.
    static member inline borderRightWidth (width: int): JSX.Style = "border-right-width", (asString width + "px")
    /// Sets the width of the right border of an element.
    static member inline borderRightWidth (width: ICssUnit): JSX.Style = "border-right-width", (asString width)
    /// Sets the color of an element's right border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    static member inline borderRightColor (color: string): JSX.Style = "border-right-color", color
    /// Sets the line style of an element's left border.
    static member inline borderLeftStyle(style: IBorderStyle): JSX.Style = "border-left-style", (asString style)
    /// Sets the width of the left border of an element.
    static member inline borderLeftWidth (width: int): JSX.Style = "border-left-width", (asString width + "px")
    /// Sets the width of the left border of an element.
    static member inline borderLeftWidth (width: ICssUnit): JSX.Style = "border-left-width", (asString width)
    /// Sets the color of an element's left border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    static member inline borderLeftColor (color: string): JSX.Style = "border-left-color", color
    /// Sets an element's border.
    ///
    /// It sets the values of border-width, border-style, and border-color.
    static member inline border(width: ICssUnit, style: IBorderStyle, color: string): JSX.Style =
        "border", (
            (asString width) + " " +
            (asString style) + " " +
            color
        )
    /// Sets an element's border.
    ///
    /// It sets the values of border-width, border-style, and border-color.
    static member inline border(width: string, style: IBorderStyle, color: string): JSX.Style =
        "border", (
            width + " " +
            (asString style) + " " +
            color
        )
    /// Sets the color of an element's border.
    static member inline borderColor (color: string): JSX.Style = "border-color", color
    /// Rounds the corners of an element's outer border edge. You can set a single radius to make
    /// circular corners, or two radii to make elliptical corners.
    static member inline borderRadius (radius: int): JSX.Style = "border-radius", (asString radius + "px")
    /// Rounds the corners of an element's outer border edge. You can set a single radius to make
    /// circular corners, or two radii to make elliptical corners.
    static member inline borderRadius (radius: ICssUnit): JSX.Style = "border-radius", (asString radius)
    /// Sets the width of an element's border.
    static member inline borderWidth (width: int): JSX.Style = "border-width", (asString width + "px")
    /// Sets the width of an element's border.
    static member inline borderWidth (top: ICssUnit, ?right: ICssUnit): JSX.Style =
        "border-width", (
            asString top + (match right with Some x -> " " + asString x | None -> ""))
    /// Sets the width of an element's border.
    static member inline borderWidth (top: ICssUnit, right: ICssUnit, bottom: ICssUnit, ?left: ICssUnit): JSX.Style =
        "border-width", (
            (asString top) + " " +
            (asString right) + " " +
            (asString bottom) +
            (match left with Some x -> " " + asString x | None -> ""))
    /// Sets one or more animations to apply to an element. Each name is an @keyframes at-rule that
    /// sets the property values for the animation sequence.
    static member inline animationName(keyframeName: string): JSX.Style = "animation-name", keyframeName
    /// Sets the length of time that an animation takes to complete one cycle.
    static member inline animationDuration(timespan: TimeSpan): JSX.Style = "animation-duration", (asString timespan.TotalMilliseconds + "ms")
    /// Sets the length of time that an animation takes to complete one cycle.
    static member inline animationDuration(seconds: int): JSX.Style = "animation-duration", (asString seconds + "s")
    /// Sets when an animation starts.
    ///
    /// The animation can start later, immediately from its beginning, or immediately and partway through the animation.
    static member inline animationDelay(timespan: TimeSpan): JSX.Style = "animation-delay", (asString timespan.TotalMilliseconds + "ms")
    /// Sets when an animation starts.
    ///
    /// The animation can start later, immediately from its beginning, or immediately and partway through the animation.
    static member inline animationDelay(seconds: int): JSX.Style = "animation-delay", (asString seconds + "s")
    /// The number of times the animation runs.
    static member inline animationDurationCount(count: int): JSX.Style = "animation-duration-count", (asString count)
    /// Sets the font family for the font specified in a @font-face rule.
    static member inline fontFamily (family: string): JSX.Style = "font-family", family
    /// Sets the color of decorations added to text by text-decoration-line.
    static member inline textDecorationColor(color: string): JSX.Style = "text-decoration-color", color
    /// Sets the length of empty space (indentation) that is put before lines of text in a block.
    static member inline textIndent(value: int): JSX.Style = "text-indent", (asString value)
    /// Sets the length of empty space (indentation) that is put before lines of text in a block.
    static member inline textIndent(value: string): JSX.Style = "text-indent", (asString value)
    /// Sets the opacity of an element.
    ///
    /// Opacity is the degree to which content behind an element is hidden, and is the opposite of transparency.
    static member inline opacity(value: double): JSX.Style = "opacity", (asString value)
    /// Sets the minimum width of an element.
    ///
    /// It prevents the used value of the width property from becoming smaller than the value specified for min-width.
    static member inline minWidth (value: int): JSX.Style = "min-width", (asString value + "px")
    /// Sets the minimum width of an element.
    ///
    /// It prevents the used value of the width property from becoming smaller than the value specified for min-width.
    static member inline minWidth (value: ICssUnit): JSX.Style = "min-width", (asString value)
    /// Sets the minimum width of an element.
    ///
    /// It prevents the used value of the width property from becoming smaller than the value specified for min-width.
    static member inline minWidth (value: string): JSX.Style = "min-width", (asString value)
    /// Sets the maximum width of an element.
    ///
    /// It prevents the used value of the width property from becoming larger than the value specified by max-width.
    static member inline maxWidth (value: int): JSX.Style = "max-width", (asString value + "px")
    /// Sets the maximum width of an element.
    ///
    /// It prevents the used value of the width property from becoming larger than the value specified by max-width.
    static member inline maxWidth (value: ICssUnit): JSX.Style = "max-width", (asString value)
    /// Sets the width of an element.
    ///
    /// By default, the property defines the width of the content area.
    static member inline width (value: int): JSX.Style = "width", (asString value + "px")
    /// Sets the width of an element.
    ///
    /// By default, the property defines the width of the content area.
    static member inline width (value: ICssUnit): JSX.Style = "width", (asString value)

    /// Sets one or more background images on an element.
    static member inline backgroundImage (value: string): JSX.Style = "background-image", (asString value)
    /// Short-hand for `style.backgroundImage(sprintf "url('%s')" value)` to set the backround image using a url.
    static member inline backgroundImageUrl (value: string): JSX.Style = "background-image", ("url('" + value + "')")

    /// Sets the color of an SVG shape.
    static member inline fill (color: string): JSX.Style = "fill", color

/// Contains a list of HTML5 colors from https://htmlcolorcodes.com/color-names/
module color =
    /// Creates a color from components [hue](https://en.wikipedia.org/wiki/Hue), [saturation](https://en.wikipedia.org/wiki/Colorfulness) and [lightness](https://en.wikipedia.org/wiki/Lightness) where hue is a number that goes from 0 to 360 and both
    /// the `saturation` and `lightness` go from 0 to 100 as they are percentages.
    let hsl (hue: float, saturation: float, lightness: float) =
        "hsl(" + (string hue) + "," + (string saturation) + "%," + (string lightness) + "%)"
    let rgb (r: int, g: int, b: int) =
        "rgb(" + (string r) + "," + (string g) + "," + (string b) + ")"
    let rgba (r: int, g: int, b: int, a: float) =
        "rgba(" + (string r) + "," + (string g) + "," + (string b) + "," + (string a) + ")"
    let [<Literal>] indianRed = "#CD5C5C"
    let [<Literal>] lightCoral = "#F08080"
    let [<Literal>] salmon = "#FA8072"
    let [<Literal>] darkSalmon = "#E9967A"
    let [<Literal>] lightSalmon = "#FFA07A"
    let [<Literal>] crimson = "#DC143C"
    let [<Literal>] red = "#FF0000"
    let [<Literal>] fireBrick = "#B22222"
    let [<Literal>] darkRed = "#8B0000"
    let [<Literal>] pink = "#FFC0CB"
    let [<Literal>] lightPink = "#FFB6C1"
    let [<Literal>] hotPink = "#FF69B4"
    let [<Literal>] deepPink = "#FF1493"
    let [<Literal>] mediumVioletRed = "#C71585"
    let [<Literal>] paleVioletRed = "#DB7093"
    let [<Literal>] coral = "#FF7F50"
    let [<Literal>] tomato = "#FF6347"
    let [<Literal>] orangeRed = "#FF4500"
    let [<Literal>] darkOrange = "#FF8C00"
    let [<Literal>] orange = "#FFA500"
    let [<Literal>] gold = "#FFD700"
    let [<Literal>] yellow = "#FFFF00"
    let [<Literal>] lightYellow = "#FFFFE0"
    let [<Literal>] limonChiffon = "#FFFACD"
    let [<Literal>] lightGoldenRodYellow = "#FAFAD2"
    let [<Literal>] papayaWhip = "#FFEFD5"
    let [<Literal>] moccasin = "#FFE4B5"
    let [<Literal>] peachPuff = "#FFDAB9"
    let [<Literal>] paleGoldenRod = "#EEE8AA"
    let [<Literal>] khaki = "#F0E68C"
    let [<Literal>] darkKhaki = "#BDB76B"
    let [<Literal>] lavender = "#E6E6FA"
    let [<Literal>] thistle = "#D8BFD8"
    let [<Literal>] plum = "#DDA0DD"
    let [<Literal>] violet = "#EE82EE"
    let [<Literal>] orchid = "#DA70D6"
    let [<Literal>] fuchsia = "#FF00FF"
    let [<Literal>] magenta = "#FF00FF"
    let [<Literal>] mediumOrchid = "#BA55D3"
    let [<Literal>] mediumPurple = "#9370DB"
    let [<Literal>] rebeccaPurple = "#663399"
    let [<Literal>] blueViolet = "#8A2BE2"
    let [<Literal>] darkViolet = "#9400D3"
    let [<Literal>] darkOrchid = "#9932CC"
    let [<Literal>] darkMagenta = "#8B008B"
    let [<Literal>] purple = "#800080"
    let [<Literal>] indigo = "#4B0082"
    let [<Literal>] slateBlue = "#6A5ACD"
    let [<Literal>] darkSlateBlue = "#483D8B"
    let [<Literal>] mediumSlateBlue = "#7B68EE"
    let [<Literal>] greenYellow = "#ADFF2F"
    let [<Literal>] chartreuse = "#7FFF00"
    let [<Literal>] lawnGreen = "#7CFC00"
    let [<Literal>] lime = "#00FF00"
    let [<Literal>] limeGreen = "#32CD32"
    let [<Literal>] paleGreen = "#98FB98"
    let [<Literal>] lightGreen = "#90EE90"
    let [<Literal>] mediumSpringGreen = "#00FA9A"
    let [<Literal>] springGreen = "#00FF7F"
    let [<Literal>] mediumSeaGreen = "#3CB371"
    let [<Literal>] seaGreen = "#2E8B57"
    let [<Literal>] forestGreen = "#228B22"
    let [<Literal>] green = "#008000"
    let [<Literal>] darkGreen = "#006400"
    let [<Literal>] yellowGreen = "#9ACD32"
    let [<Literal>] oliveDrab = "#6B8E23"
    let [<Literal>] olive = "#808000"
    let [<Literal>] darkOliveGreen = "#556B2F"
    let [<Literal>] mediumAquamarine = "#66CDAA"
    let [<Literal>] darkSeaGreen = "#8FBC8B"
    let [<Literal>] lightSeaGreen = "#20B2AA"
    let [<Literal>] darkCyan = "#008B8B"
    let [<Literal>] teal = "#008080"
    let [<Literal>] aqua = "#00FFFF"
    let [<Literal>] cyan = "#00FFFF"
    let [<Literal>] lightCyan = "#E0FFFF"
    let [<Literal>] paleTurqouise = "#AFEEEE"
    let [<Literal>] aquaMarine = "#7FFFD4"
    let [<Literal>] turqouise = "#AFEEEE"
    let [<Literal>] mediumTurqouise = "#48D1CC"
    let [<Literal>] darkTurqouise = "#00CED1"
    let [<Literal>] cadetBlue = "#5F9EA0"
    let [<Literal>] steelBlue = "#4682B4"
    let [<Literal>] lightSteelBlue = "#B0C4DE"
    let [<Literal>] powederBlue = "#B0E0E6"
    let [<Literal>] lightBlue = "#ADD8E6"
    let [<Literal>] skyBlue = "#87CEEB"
    let [<Literal>] lightSkyBlue = "#87CEFA"
    let [<Literal>] deepSkyBlue = "#00BFFF"
    let [<Literal>] dodgerBlue = "#1E90FF"
    let [<Literal>] cornFlowerBlue = "#6495ED"
    let [<Literal>] royalBlue = "#4169E1"
    let [<Literal>] blue = "#0000FF"
    let [<Literal>] mediumBlue = "#0000CD"
    let [<Literal>] darkBlue = "#00008B"
    let [<Literal>] navy = "#000080"
    let [<Literal>] midnightBlue = "#191970"
    let [<Literal>] cornSilk = "#FFF8DC"
    let [<Literal>] blanchedAlmond = "#FFEBCD"
    let [<Literal>] bisque = "#FFE4C4"
    let [<Literal>] navajoWhite = "#FFDEAD"
    let [<Literal>] wheat = "#F5DEB3"
    let [<Literal>] burlyWood = "#DEB887"
    let [<Literal>] tan = "#D2B48C"
    let [<Literal>] rosyBrown = "#BC8F8F"
    let [<Literal>] sandyBrown = "#F4A460"
    let [<Literal>] goldenRod = "#DAA520"
    let [<Literal>] darkGoldenRod = "#B8860B"
    let [<Literal>] peru = "#CD853F"
    let [<Literal>] chocolate = "#D2691E"
    let [<Literal>] saddleBrown = "#8B4513"
    let [<Literal>] sienna = "#A0522D"
    let [<Literal>] brown = "#A52A2A"
    let [<Literal>] maroon = "#A52A2A"
    let [<Literal>] white = "#FFFFFF"
    let [<Literal>] snow = "#FFFAFA"
    let [<Literal>] honeyDew = "#F0FFF0"
    let [<Literal>] mintCream = "#F5FFFA"
    let [<Literal>] azure = "#F0FFFF"
    let [<Literal>] aliceBlue = "#F0F8FF"
    let [<Literal>] ghostWhite = "#F8F8FF"
    let [<Literal>] whiteSmoke = "#F5F5F5"
    let [<Literal>] seaShell = "#FFF5EE"
    let [<Literal>] beige = "#F5F5DC"
    let [<Literal>] oldLace = "#FDF5E6"
    let [<Literal>] floralWhite = "#FFFAF0"
    let [<Literal>] ivory = "#FFFFF0"
    let [<Literal>] antiqueWhite = "#FAEBD7"
    let [<Literal>] linen = "#FAF0E6"
    let [<Literal>] lavenderBlush = "#FFF0F5"
    let [<Literal>] mistyRose = "#FFE4E1"
    let [<Literal>] gainsBoro = "#DCDCDC"
    let [<Literal>] lightGray = "#D3D3D3"
    let [<Literal>] silver = "#C0C0C0"
    let [<Literal>] darkGray = "#A9A9A9"
    let [<Literal>] gray = "#808080"
    let [<Literal>] dimGray = "#696969"
    let [<Literal>] lightSlateGray = "#778899"
    let [<Literal>] slateGray = "#708090"
    let [<Literal>] darkSlateGray = "#2F4F4F"
    let [<Literal>] black = "#000000"
    let [<Literal>] transparent = "transparent"

/// Contains a list of CSS Fonts from https://www.tutorialbrain.com/css_tutorial/css_font_family_list/
module font =
    let [<Literal>] abadiMTCondensedLight = "Abadi MT Condensed Light"
    let [<Literal>] aharoni = "Aharoni"
    let [<Literal>] aharoniBold = "Aharoni Bold"
    let [<Literal>] aldhabi = "Aldhabi"
    let [<Literal>] alternateGothic2BT = "AlternateGothic2 BT"
    let [<Literal>] andaleMono = "Andale Mono"
    let [<Literal>] andalus = "Andalus"
    let [<Literal>] angsanaNew = "Angsana New"
    let [<Literal>] angsanaUPC = "AngsanaUPC"
    let [<Literal>] aparajita = "Aparajita"
    let [<Literal>] appleChancery = "Apple Chancery"
    let [<Literal>] arabicTypesetting = "Arabic Typesetting"
    let [<Literal>] arial = "Arial"
    let [<Literal>] arialBlack = "Arial Black"
    let [<Literal>] arialNarrow = "Arial narrow"
    let [<Literal>] arialNova = "Arial Nova"
    let [<Literal>] arialRoundedMTBold = "Arial Rounded MT Bold"
    let [<Literal>] arnoldboecklin = "Arnoldboecklin"
    let [<Literal>] avantaGarde = "Avanta Garde"
    let [<Literal>] bahnschrift = "Bahnschrift"
    let [<Literal>] bahnschriftLight = "Bahnschrift Light"
    let [<Literal>] bahnschriftSemiBold = "Bahnschrift SemiBold"
    let [<Literal>] bahnschriftSemiLight = "Bahnschrift SemiLight"
    let [<Literal>] baskerville = "Baskerville"
    let [<Literal>] batang = "Batang"
    let [<Literal>] batangChe = "BatangChe"
    let [<Literal>] bigCaslon = "Big Caslon"
    let [<Literal>] bizUDGothic = "BIZ UDGothic"
    let [<Literal>] bizUDMinchoMedium = "BIZ UDMincho Medium"
    let [<Literal>] blippo = "Blippo"
    let [<Literal>] bodoniMT = "Bodoni MT"
    let [<Literal>] bookAntiqua = "Book Antiqua"
    let [<Literal>] Bookman = "Bookman"
    let [<Literal>] bradlyHand = "Bradley Hand"
    let [<Literal>] browalliaNew = "Browallia New"
    let [<Literal>] browalliaUPC = "BrowalliaUPC"
    let [<Literal>] brushScriptMT = "Brush Script MT"
    let [<Literal>] brushScriptStd = "Brush Script Std"
    let [<Literal>] brushStroke = "Brushstroke"
    let [<Literal>] calibri = "Calibri"
    let [<Literal>] calibriLight = "Calibri Light"
    let [<Literal>] calistoMT = "Calisto MT"
    let [<Literal>] cambodian = "Cambodian"
    let [<Literal>] cambria = "Cambria"
    let [<Literal>] cambriaMath = "Cambria Math"
    let [<Literal>] candara = "Candara"
    let [<Literal>] centuryGothic = "Century Gothic"
    let [<Literal>] chalkDuster = "Chalkduster"
    let [<Literal>] cherokee = "Cherokee"
    let [<Literal>] comicSans = "Comic Sans"
    let [<Literal>] comicSansMS = "Comic Sans MS"
    let [<Literal>] consolas = "Consolas"
    let [<Literal>] constantia = "Constantia"
    let [<Literal>] copperPlate = "Copperplate"
    let [<Literal>] copperPlateGothicLight = "Copperplate Gothic Light"
    let [<Literal>] copperPlateGothicBold = "Copperplate Gothic Bold"
    let [<Literal>] corbel = "Corbel"
    let [<Literal>] cordiaNew = "Cordia New"
    let [<Literal>] cordiaUPC = "CordiaUPC"
    let [<Literal>] coronetScript = "Coronet script"
    let [<Literal>] courier = "Courier"
    let [<Literal>] courierNew = "Courier New"
    let [<Literal>] daunPenh = "DaunPenh"
    let [<Literal>] david = "David"
    let [<Literal>] dengXian = "DengXian"
    let [<Literal>] dfKaiSB = "DFKai-SB"
    let [<Literal>] didot = "Didot"
    let [<Literal>] dilleniaUPC = "DilleniaUPC"
    let [<Literal>] dokChampa = "DokChampa"
    let [<Literal>] dotum = "Dotum"
    let [<Literal>] dotumChe = "DotumChe"
    let [<Literal>] ebrima = "Ebrima"
    let [<Literal>] estrangeloEdessa = "Estrangelo Edessa"
    let [<Literal>] eucrosiaUPC = "EucrosiaUPC"
    let [<Literal>] euphemia = "Euphemia"
    let [<Literal>] fangSong = "FangSong"
    let [<Literal>] florence = "Florence"
    let [<Literal>] franklinGothicMedium = "Franklin Gothic Medium"
    let [<Literal>] frankRuehl = "FrankRuehl"
    let [<Literal>] fressiaUPC = "FressiaUPC"
    let [<Literal>] futara = "Futara"
    let [<Literal>] gabriola = "Gabriola"
    let [<Literal>] garamond = "Garamond"
    let [<Literal>] gautami = "Gautami"
    let [<Literal>] geneva = "Geneva"
    let [<Literal>] georgia = "Georgia"
    let [<Literal>] georgiaPro = "Georgia Pro"
    let [<Literal>] gillSans = "Gill Sans"
    let [<Literal>] gillSansNova = "Gill Sans Nova"
    let [<Literal>] gisha = "Gisha"
    let [<Literal>] goudyOldStyle = "Goudy Old Style"
    let [<Literal>] gulim = "Gulim"
    let [<Literal>] gulimChe = "GulimChe"
    let [<Literal>] gungsuh = "Gungsuh"
    let [<Literal>] gungsuhChe = "GungsuhChe"
    let [<Literal>] hebrew = "Hebrew"
    let [<Literal>] helvetica = "Helvetica"
    let [<Literal>] hoeflerText = "Hoefler Text"
    let [<Literal>] holoLensMDL2Assets = "HoloLens MDL2 Assets"
    let [<Literal>] impact = "Impact"
    let [<Literal>] inkFree = "Ink Free"
    let [<Literal>] irisUPC = "IrisUPC"
    let [<Literal>] iskoolaPota = "Iskoola Pota"
    let [<Literal>] japanese = "Japanese"
    let [<Literal>] jasmineUPC = "JasmineUPC"
    let [<Literal>] javaneseText = "Javanese Text"
    let [<Literal>] jazzLET = "Jazz LET"
    let [<Literal>] kaiTi = "KaiTi"
    let [<Literal>] kalinga = "Kalinga"
    let [<Literal>] kartika = "Kartika"
    let [<Literal>] khmerUI = "Khmer UI"
    let [<Literal>] kodchiangUPC = "KodchiangUPC"
    let [<Literal>] kokila = "Kokila"
    let [<Literal>] korean = "Korean"
    let [<Literal>] lao = "Lao"
    let [<Literal>] laoUI = "Lao UI"
    let [<Literal>] latha = "Latha"
    let [<Literal>] leelawadee = "Leelawadee"
    let [<Literal>] leelawadeeUI = "Leelawadee UI"
    let [<Literal>] leelawadeeUISemilight = "Leelawadee UI Semilight"
    let [<Literal>] levenimMT = "Levenim MT"
    let [<Literal>] lilyUPC = "LilyUPC"
    let [<Literal>] lucidaBright = "Lucida Bright"
    let [<Literal>] lucidaConsole = "Lucida Console"
    let [<Literal>] lucidaHandwriting = "Lucida Handwriting"
    let [<Literal>] lucidaSans = "Lucida Sans"
    let [<Literal>] lucidaSansTypewriter = "Lucida Sans Typewriter"
    let [<Literal>] lucidaSansUnicode = "Lucida Sans Unicode"
    let [<Literal>] lucidaTypewriter = "Lucidatypewriter"
    let [<Literal>] luminari = "Luminari"
    let [<Literal>] malgunGothic = "Malgun Gothic"
    let [<Literal>] malgunGothicSemilight = "Malgun Gothic Semilight"
    let [<Literal>] mangal = "Mangal"
    let [<Literal>] markerFelt = "Marker Felt"
    let [<Literal>] marlett = "Marlett"
    let [<Literal>] meiryo = "Meiryo"
    let [<Literal>] meiryoUI = "Meiryo UI"
    let [<Literal>] microsoftHimalaya = "Microsoft Himalaya"
    let [<Literal>] microsoftJhengHei = "Microsoft JhengHei"
    let [<Literal>] microsoftJhengHeiUI = "Microsoft JhengHei UI"
    let [<Literal>] microsoftNewTaiLue = "Microsoft New Tai Lue"
    let [<Literal>] microsoftPhagsPa = "Microsoft PhagsPa"
    let [<Literal>] microsoftSansSerif = "Microsoft Sans Serif"
    let [<Literal>] microsoftTaiLe = "Microsoft Tai Le"
    let [<Literal>] microsoftUighur = "Microsoft Uighur"
    let [<Literal>] microsoftYaHei = "Microsoft YaHei"
    let [<Literal>] microsoftYaHeiUI = "Microsoft YaHei UI"
    let [<Literal>] microsoftYiBaiti = "Microsoft Yi Baiti"
    let [<Literal>] mingLiU = "MingLiU"
    let [<Literal>] mingLiUHKSCS = "MingLiU_HKSCS"
    let [<Literal>] mingLiUHKSCSExtB = "MingLiU_HKSCS-ExtB"
    let [<Literal>] mingLiUExtB = "MingLiU-ExtB"
    let [<Literal>] miriam = "Miriam"
    let [<Literal>] monaco = "Monaco"
    let [<Literal>] mongolianBaiti = "Mongolian Baiti"
    let [<Literal>] moolBoran = "MoolBoran"
    let [<Literal>] msGothic = "MS Gothic"
    let [<Literal>] msMincho = "MS Mincho"
    let [<Literal>] msPGothic = "MS PGothic"
    let [<Literal>] msPMincho = "MS PMincho"
    let [<Literal>] msUIGothic = "MS UI Gothic"
    let [<Literal>] mvBoli = "MV Boli"
    let [<Literal>] myanmarText = "Myanmar Text"
    let [<Literal>] narkisim = "Narkisim"
    let [<Literal>] neueHaasGroteskTextPro = "Neue Haas Grotesk Text Pro"
    let [<Literal>] newCenturySchoolbook = "New Century Schoolbook"
    let [<Literal>] newsGothicMT = "News Gothic MT"
    let [<Literal>] nirmalaUI = "Nirmala UI"
    let [<Literal>] noAutoLanguageAssoc = "No automatic language associations"
    let [<Literal>] noto = "Noto"
    let [<Literal>] nSimSun = "NSimSun"
    let [<Literal>] nyala = "Nyala"
    let [<Literal>] oldTown = "Oldtown"
    let [<Literal>] optima = "Optima"
    let [<Literal>] palatino = "Palatino"
    let [<Literal>] palatinoLinotype = "Palatino Linotype"
    let [<Literal>] papyrus = "papyrus"
    let [<Literal>] parkAvenue = "Parkavenue"
    let [<Literal>] perpetua = "Perpetua"
    let [<Literal>] plantagenetCherokee = "Plantagenet Cherokee"
    let [<Literal>] PMingLiU = "PMingLiU"
    let [<Literal>] raavi = "Raavi"
    let [<Literal>] rockwell = "Rockwell"
    let [<Literal>] rockwellExtraBold = "Rockwell Extra Bold"
    let [<Literal>] rockwellNova = "Rockwell Nova"
    let [<Literal>] rockwellNovaCond = "Rockwell Nova Cond"
    let [<Literal>] rockwellNovaExtraBold = "Rockwell Nova Extra Bold"
    let [<Literal>] rod = "Rod"
    let [<Literal>] sakkalMajalla = "Sakkal Majalla"
    let [<Literal>] sanskritText = "Sanskrit Text"
    let [<Literal>] segoeMDL2Assets = "segoeMDL2Assets"
    let [<Literal>] segoePrint = "Segoe Print"
    let [<Literal>] segoeScript = "Segoe Script"
    let [<Literal>] segoeUI = "Segoe UI"
    let [<Literal>] segoeUIEmoji = "Segoe UI Emoji"
    let [<Literal>] segoeUIHistoric = "Segoe UI Historic"
    let [<Literal>] segoeUISymbol = "Segoe UI Symbol"
    let [<Literal>] shonarBangla = "Shonar Bangla"
    let [<Literal>] shruti = "Shruti"
    let [<Literal>] simHei = "SimHei"
    let [<Literal>] simKai = "SimKai"
    let [<Literal>] simplifiedArabic = "Simplified Arabic"
    let [<Literal>] simplifiedChinese = "Simplified Chinese"
    let [<Literal>] simSun = "SimSun"
    let [<Literal>] simSunExtB = "SimSun-ExtB"
    let [<Literal>] sitka = "Sitka"
    let [<Literal>] snellRoundhan = "Snell Roundhan"
    let [<Literal>] stencilStd = "Stencil Std"
    let [<Literal>] sylfaen = "Sylfaen"
    let [<Literal>] symbol = "Symbol"
    let [<Literal>] tahoma = "Tahoma"
    let [<Literal>] thai = "Thai"
    let [<Literal>] timesNewRoman = "Times New Roman"
    let [<Literal>] traditionalArabic = "Traditional Arabic"
    let [<Literal>] traditionalChinese = "Traditional Chinese"
    let [<Literal>] trattatello = "Trattatello"
    let [<Literal>] trebuchetMS = "Trebuchet MS"
    let [<Literal>] udDigiKyokasho = "UD Digi Kyokasho"
    let [<Literal>] udDigiKyokashoNKR = "UD Digi Kyokasho NK-R"
    let [<Literal>] udDigiKyokashoNPR = "UD Digi Kyokasho NP-R"
    let [<Literal>] udDigiKyokashoNR = "UD Digi Kyokasho N-R"
    let [<Literal>] urduTypesetting = "Urdu Typesetting"
    let [<Literal>] urwChancery = "URW Chancery"
    let [<Literal>] utsaah = "Utsaah"
    let [<Literal>] vani = "Vani"
    let [<Literal>] verdana = "Verdana"
    let [<Literal>] verdanaPro = "Verdana Pro"
    let [<Literal>] vijaya = "Vijaya"
    let [<Literal>] vrinda = "Vrinda"
    let [<Literal>] Webdings = "Webdings"
    let [<Literal>] westminster = "Westminster"
    let [<Literal>] wingdings = "Wingdings"
    let [<Literal>] yuGothic = "Yu Gothic"
    let [<Literal>] yuGothicUI = "Yu Gothic UI"
    let [<Literal>] yuMincho = "Yu Mincho"
    let [<Literal>] zapfChancery = "Zapf Chancery"

/// Specifies a number of specialized CSS units
type length =
    static member inline zero : ICssUnit = newCssUnit "0"
    /// Pixels are (1px = 1/96th of 1in).
    ///
    /// **Note**: Pixels (px) are relative to the viewing device. For low-dpi devices, 1px is one device pixel (dot) of the display. For printers and high resolution screens 1px implies multiple device pixels.
    static member inline px(value: int) : ICssUnit = newCssUnit (string value + "px")
    /// Pixels are (1px = 1/96th of 1in).
    ///
    /// **Note**: Pixels (px) are relative to the viewing device. For low-dpi devices, 1px is one device pixel (dot) of the display. For printers and high resolution screens 1px implies multiple device pixels.
    static member inline px(value: double) : ICssUnit = newCssUnit (string value + "px")
    /// Centimeters
    static member inline cm(value: int) : ICssUnit = newCssUnit (string value + "cm")
    /// Centimeters
    static member inline cm(value: double) : ICssUnit = newCssUnit (string value + "cm")
    /// Millimeters
    static member inline mm(value: int) : ICssUnit = newCssUnit (string value + "mm")
    /// Millimeters
    static member inline mm(value: double) : ICssUnit = newCssUnit (string value + "mm")
    /// Inches (1in = 96px = 2.54cm)
    static member inline inch(value: int) : ICssUnit = newCssUnit (string value + "in")
    /// Inches (1in = 96px = 2.54cm)
    static member inline inch(value: double) : ICssUnit = newCssUnit (string value + "in")
    /// Points (1pt = 1/72 of 1in)
    static member inline pt(value: int) : ICssUnit = newCssUnit (string value + "pt")
    /// Points (1pt = 1/72 of 1in)
    static member inline pt(value: double) : ICssUnit = newCssUnit (string value + "pt")
    /// Picas (1pc = 12 pt)
    static member inline pc(value: int) : ICssUnit = newCssUnit (string value + "pc")
    /// Picas (1pc = 12 pt)
    static member inline pc(value: double) : ICssUnit = newCssUnit (string value + "pc")
    /// Relative to the font-size of the element (2em means 2 times the size of the current font
    static member inline em(value: int) : ICssUnit = newCssUnit (string value + "em")
    /// Relative to the font-size of the element (2em means 2 times the size of the current font
    static member inline em(value: double) : ICssUnit = newCssUnit (string value + "em")
    /// Relative to the x-height of the current font (rarely used)
    static member inline ex(value: int) : ICssUnit = newCssUnit (string value + "ex")
    /// Relative to the x-height of the current font (rarely used)
    static member inline ex(value: double) : ICssUnit = newCssUnit (string value + "ex")
    /// Relative to width of the "0" (zero)
    static member inline ch(value: int) : ICssUnit = newCssUnit (string value + "ch")
    /// Relative to font-size of the root element
    static member inline rem(value: double) : ICssUnit = newCssUnit (string value + "rem")
    /// Relative to font-size of the root element
    static member inline rem(value: int) : ICssUnit = newCssUnit (string value + "rem")
    /// Relative to 1% of the height of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vh(value: int) : ICssUnit = newCssUnit (string value + "vh")
    /// Relative to 1% of the height of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vh(value: double) : ICssUnit = newCssUnit (string value + "vh")
    /// Relative to 1% of the width of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vw(value: int) : ICssUnit = newCssUnit (string value + "vw")
    /// Relative to 1% of the width of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vw(value: double) : ICssUnit = newCssUnit (string value + "vw")
    /// Relative to 1% of viewport's smaller dimension
    static member inline vmin(value: double) : ICssUnit = newCssUnit (string value + "vmin")
    /// Relative to 1% of viewport's smaller dimension
    static member inline vmin(value: int) : ICssUnit = newCssUnit (string value + "vmin")
    /// Relative to 1% of viewport's larger dimension
    static member inline vmax(value: double) : ICssUnit = newCssUnit (string value + "vmax")
    /// Relative to 1% of viewport's* larger dimension
    static member inline vmax(value: int) : ICssUnit = newCssUnit (string value + "vmax")
    /// Percent relative to the parent element
    static member inline perc(value: int) : ICssUnit = newCssUnit (string value + "%")
    /// Percent relative to the parent element
    static member inline perc(value: double) : ICssUnit = newCssUnit (string value + "%")
    /// Percent relative to the parent element
    static member inline percent(value: int) : ICssUnit = newCssUnit (string value + "%")
    /// Percent relative to the parent element
    static member inline percent(value: double) : ICssUnit = newCssUnit (string value + "%")
    /// The browser calculates the length.
    static member inline auto : ICssUnit = newCssUnit "auto"
    /// calculated length, frequency, angle, time, percentage, number or integer
    static member inline calc(value: string) : ICssUnit = newCssUnit ("calc(" + value + ")")
    /// Relative to width of the grid layout in correlation with the other fr's in the grid
    static member inline fr(value: int) : ICssUnit = newCssUnit (string value + "fr")

type borderStyle =
    /// Specifies a dashed border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dashed
    static member inline dashed : IBorderStyle = newBorderStyle "dashed"
    /// Specifies a dotted border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    static member inline dotted : IBorderStyle = newBorderStyle "dotted"
    /// Specifies a double border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=double
    static member inline double : IBorderStyle = newBorderStyle "double"
    /// Specifies a 3D grooved border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=groove
    static member inline groove : IBorderStyle = newBorderStyle "groove"
    /// The same as "none", except in border conflict resolution for table elements.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
    static member inline hidden : IBorderStyle = newBorderStyle "hidden"
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=inherit
    ///
    /// Read about inherit https://www.w3schools.com/cssref/css_inherit.asp
    static member inline inheritFromParent : IBorderStyle = newBorderStyle "inherit"
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=initial
    ///
    /// Read about initial value https://www.w3schools.com/cssref/css_initial.asp
    static member inline initial : IBorderStyle = newBorderStyle "initial"
    /// Specifies a 3D inset border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=inset
    static member inline inset : IBorderStyle = newBorderStyle "inset"
    /// Default value. Specifies no border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=none
    static member inline none : IBorderStyle = newBorderStyle "none"
    /// Specifies a 3D outset border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=outset
    static member inline outset : IBorderStyle = newBorderStyle "outset"
    /// Specifies a 3D ridged border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=ridge
    static member inline ridge : IBorderStyle = newBorderStyle "ridge"
    /// Specifies a solid border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=solid
    static member inline solid : IBorderStyle = newBorderStyle "solid"

type gridColumn =
    static member inline span(value: string) : IGridSpan = newGridSpan("span " + value)
    static member inline span(value: string, count: int) : IGridSpan = newGridSpan("span " + value + " " + (string count))
    static member inline span(value: int) : IGridSpan = newGridSpan("span " + (string value))

type gridRow =
    static member inline span(value: string) : IGridSpan = newGridSpan("span " + value)
    static member inline span(value: string, count: int) : IGridSpan = newGridSpan("span " + value + " " + (string count))
    static member inline span(value: int) : IGridSpan = newGridSpan("span " + (string value))

type grid =
    static member inline ofString(value: string) : IGridTemplateItem = newGridTemplateItem value
    static member inline namedLine(value: string) : IGridTemplateItem = newGridTemplateItem ("[" + value + "]")
    static member inline namedLines(value: string[]) : IGridTemplateItem = newGridTemplateItem ("[" + (String.concat " " value) + "]")
    static member inline namedLines(value: string list) : IGridTemplateItem = newGridTemplateItem ("[" + (String.concat " " value) + "]")
    static member inline templateWidth(value: ICssUnit) : IGridTemplateItem = newGridTemplateItem(asString value)
    static member inline templateWidth(value: int) : IGridTemplateItem = newGridTemplateItem ((string value) + "px")
    static member inline templateWidth(value: float) : IGridTemplateItem = newGridTemplateItem ((string value) + "px")

type textDecorationLine =
    static member inline none : ITextDecorationLine = newTextDecorationLine "none"
    static member inline underline : ITextDecorationLine = newTextDecorationLine "underline"
    static member inline overline : ITextDecorationLine = newTextDecorationLine "overline"
    static member inline lineThrough : ITextDecorationLine = newTextDecorationLine "line-through"
    static member inline initial : ITextDecorationLine = newTextDecorationLine "initial"
    static member inline inheritFromParent : ITextDecorationLine = newTextDecorationLine "inherit"

type textDecorationStyle =
    /// Default value. The line will display as a single line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=solid
    static member inline solid : ITextDecoration = newTextDecoration "solid"
    /// The line will display as a double line.
    ///
    /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=double
    static member inline double : ITextDecoration = newTextDecoration "double"
    /// The line will display as a dotted line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dotted
    static member inline dotted : ITextDecoration = newTextDecoration "dotted"
    /// The line will display as a dashed line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dashed
    static member inline dashed : ITextDecoration = newTextDecoration "dashed"
    /// The line will display as a wavy line.
    ///
    /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=wavy
    static member inline wavy : ITextDecoration = newTextDecoration "wavy"
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=initial
    static member inline initial : ITextDecoration = newTextDecoration "initial"
    /// Inherits this property from its parent element.
    static member inline inheritFromParent : ITextDecoration = newTextDecoration "inherit"

/// The transform CSS property lets you rotate, scale, skew, or translate an element.
/// It modifies the coordinate space of the CSS [visual formatting model](https://developer.mozilla.org/en-US/docs/Web/CSS/Visual_formatting_model)
type transform =
    /// Defines that there should be no transformation.
    static member inline none = newTransformProperty "none"
    /// Defines a 2D transformation, using a matrix of six values.
    static member inline matrix(x1: int, y1: int, z1: int, x2: int, y2: int, z2: int) =
        newTransformProperty (
            "matrix(" +
            (asString x1) + "," +
            (asString y1) + "," +
            (asString z1) + "," +
            (asString x2) + "," +
            (asString y2) + "," +
            (asString z2) + ")"
        )

    /// Defines a 2D translation.
    static member inline translate(x: int, y: int) =
        newTransformProperty (
            "translate(" + (asString x) + "px," + (asString y) + "px)"
        )
    /// Defines a 2D translation.
    static member inline translate(x: ICssUnit, y: ICssUnit) =
        newTransformProperty (
            "translate(" + (asString x) + "," + (asString y) + ")"
        )

    /// Defines a 3D translation.
    static member inline translate3D(x: int, y: int, z: int) =
        newTransformProperty (
            "translate3d(" + (asString x) + "px," + (asString y) + "px," + (asString z) + "px)"
        )
    /// Defines a 3D translation.
    static member inline translate3D(x: ICssUnit, y: ICssUnit, z: ICssUnit) =
        newTransformProperty (
            "translate3d(" + (asString x) + "," + (asString y) + "," + (asString z) + ")"
        )

    /// Defines a translation, using only the value for the X-axis.
    static member inline translateX(x: int) =
        newTransformProperty ("translateX(" + (asString x) + "px)")
    /// Defines a translation, using only the value for the X-axis.
    static member inline translateX(x: ICssUnit) =
        newTransformProperty ("translateX(" + (asString x) + ")")
    /// Defines a translation, using only the value for the Y-axis
    static member inline translateY(y: int) =
        newTransformProperty ("translateY(" + (asString y) + "px)")
    /// Defines a translation, using only the value for the Y-axis
    static member inline translateY(y: ICssUnit) =
        newTransformProperty ("translateY(" + (asString y) + ")")
    /// Defines a 3D translation, using only the value for the Z-axis
    static member inline translateZ(z: int) =
        newTransformProperty ("translateZ(" + (asString z) + "px)")
    /// Defines a 3D translation, using only the value for the Z-axis
    static member inline translateZ(z: ICssUnit) =
        newTransformProperty ("translateZ(" + (asString z) + ")")

    /// Defines a 2D scale transformation.
    static member inline scale(x: int, y: int) =
        newTransformProperty (
            "scale(" + (asString x) + "," + (asString y) + ")"
        )
    /// Defines a 2D scale transformation.
    static member inline scale(x: float, y: float) =
        newTransformProperty (
            "scale(" + (asString x) + "," + (asString y) + ")"
        )

    /// Defines a scale transformation.
    static member inline scale(n: int) =
        newTransformProperty (
            "scale(" + (asString n) + ")"
        )

    /// Defines a scale transformation.
    static member inline scale(n: float) =
        newTransformProperty (
            "scale(" + (asString n) + ")"
        )

    /// Defines a 3D scale transformation
    static member inline scale3D(x: int, y: int, z: int) =
        newTransformProperty (
            "scale3d(" + (asString x) + "," + (asString y) + "," + (asString z) + ")"
        )
    /// Defines a 3D scale transformation
    static member inline scale3D(x: float, y: float, z: float) =
        newTransformProperty (
            "scale3d(" + (asString x) + "," + (asString y) + "," + (asString z) + ")"
        )

    /// Defines a scale transformation by giving a value for the X-axis.
    static member inline scaleX(x: int) =
        newTransformProperty ("scaleX(" + (asString x) + ")")

    /// Defines a scale transformation by giving a value for the X-axis.
    static member inline scaleX(x: float) =
        newTransformProperty ("scaleX(" + (asString x) + ")")
    /// Defines a scale transformation by giving a value for the Y-axis.
    static member inline scaleY(y: int) =
        newTransformProperty ("scaleY(" + (asString y) + ")")
    /// Defines a scale transformation by giving a value for the Y-axis.
    static member inline scaleY(y: float) =
        newTransformProperty ("scaleY(" + (asString y) + ")")
    /// Defines a 3D translation, using only the value for the Z-axis
    static member inline scaleZ(z: int) =
        newTransformProperty ("scaleZ(" + (asString z) + ")")
    /// Defines a 3D translation, using only the value for the Z-axis
    static member inline scaleZ(z: float) =
        newTransformProperty ("scaleZ(" + (asString z) + ")")
    /// Defines a 2D rotation, the angle is specified in the parameter.
    static member inline rotate(deg: int) =
        newTransformProperty ("rotate(" + (asString deg) + "deg)")
    /// Defines a 2D rotation, the angle is specified in the parameter.
    static member inline rotate(deg: float) =
        newTransformProperty ("rotate(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the X-axis.
    static member inline rotateX(deg: float) =
        newTransformProperty ("rotateX(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the X-axis.
    static member inline rotateX(deg: int) =
        newTransformProperty ("rotateX(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the Y-axis
    static member inline rotateY(deg: float) =
        newTransformProperty ("rotateY(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the Y-axis
    static member inline rotateY(deg: int) =
        newTransformProperty ("rotateY(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the Z-axis
    static member inline rotateZ(deg: float) =
        newTransformProperty ("rotateZ(" + (asString deg) + "deg)")
    /// Defines a 3D rotation along the Z-axis
    static member inline rotateZ(deg: int) =
        newTransformProperty ("rotateZ(" + (asString deg) + "deg)")
    /// Defines a 2D skew transformation along the X- and the Y-axis.
    static member inline skew(xAngle: int, yAngle: int) =
        newTransformProperty ("skew(" + (asString xAngle) + "deg," + (asString yAngle) + "deg)")
    /// Defines a 2D skew transformation along the X- and the Y-axis.
    static member inline skew(xAngle: float, yAngle: float) =
        newTransformProperty ("skew(" + (asString xAngle) + "deg," + (asString yAngle) + "deg)")
    /// Defines a 2D skew transformation along the X-axis
    static member inline skewX(xAngle: int) =
        newTransformProperty ("skewX(" + (asString xAngle) + "deg)")
    /// Defines a 2D skew transformation along the X-axis
    static member inline skewX(xAngle: float) =
        newTransformProperty ("skewX(" + (asString xAngle) + "deg)")
    /// Defines a 2D skew transformation along the Y-axis
    static member inline skewY(xAngle: int) =
        newTransformProperty ("skewY(" + (asString xAngle) + "deg)")
    /// Defines a 2D skew transformation along the Y-axis
    static member inline skewY(xAngle: float) =
        newTransformProperty ("skewY(" + (asString xAngle) + "deg)")
    /// Defines a perspective view for a 3D transformed element
    static member inline perspective(n: int) =
        newTransformProperty ("perspective(" + (asString n) + ")")

type transitionProperty =
    static member inline all = newTransitionProperty "all"
    static member inline backdropFilter = newTransitionProperty "backdrop-filter"
    static member inline background = newTransitionProperty "background"
    static member inline backgroundColor = newTransitionProperty "background-color"
    static member inline backgroundPosition = newTransitionProperty "background-position"
    static member inline backgroundSize = newTransitionProperty "background-size"
    static member inline border = newTransitionProperty "border"
    static member inline borderBottom = newTransitionProperty "border-bottom"
    static member inline borderBottomColor = newTransitionProperty "border-bottom-color"
    static member inline borderBottomLeftRadius = newTransitionProperty "border-bottom-left-radius"
    static member inline borderBottomRightRadius = newTransitionProperty "border-bottom-right-radius"
    static member inline borderBottomWidth = newTransitionProperty "border-bottom-width"
    static member inline borderColor = newTransitionProperty "border-color"
    static member inline borderEndEndRadius = newTransitionProperty "border-end-end-radius"
    static member inline borderEndStartRadius = newTransitionProperty "border-end-start-radius"
    static member inline borderLeft = newTransitionProperty "border-left"
    static member inline borderLeftColor = newTransitionProperty "border-left-color"
    static member inline borderLeftWidth = newTransitionProperty "border-left-width"
    static member inline borderRadius = newTransitionProperty "border-radius"
    static member inline borderRight = newTransitionProperty "border-right"
    static member inline borderRightColor = newTransitionProperty "border-right-color"
    static member inline borderRightWidth = newTransitionProperty "border-right-width"
    static member inline borderStartEndRadius = newTransitionProperty "border-start-end-radius"
    static member inline borderStartStartRadius = newTransitionProperty "border-start-start-radius"
    static member inline borderTop = newTransitionProperty "border-top"
    static member inline borderTopColor = newTransitionProperty "border-top-color"
    static member inline borderTopLeftRadius = newTransitionProperty "border-top-left-radius"
    static member inline borderTopRightRadius = newTransitionProperty "border-top-right-radius"
    static member inline borderTopWidth = newTransitionProperty "border-top-width"
    static member inline borderWidth = newTransitionProperty "border-width"
    static member inline bottom = newTransitionProperty "bottom"
    static member inline boxShadow = newTransitionProperty "box-shadow"
    static member inline caretColor = newTransitionProperty "caret-color"
    static member inline clip = newTransitionProperty "clip"
    static member inline clipPath = newTransitionProperty "clip-path"
    static member inline color = newTransitionProperty "color"
    static member inline columnCount = newTransitionProperty "column-count"
    static member inline columnGap = newTransitionProperty "column-gap"
    static member inline columnRule = newTransitionProperty "column-rule"
    static member inline columnRuleColor = newTransitionProperty "column-rule-color"
    static member inline columnRuleWidth = newTransitionProperty "column-rule-width"
    static member inline columnWidth = newTransitionProperty "column-width"
    static member inline columns = newTransitionProperty "columns"
    static member inline filter = newTransitionProperty "filter"
    static member inline flex = newTransitionProperty "flex"
    static member inline flexBasis = newTransitionProperty "flex-basis"
    static member inline flexGrow = newTransitionProperty "flex-grow"
    static member inline flexShrink = newTransitionProperty "flex-shrink"
    static member inline font = newTransitionProperty "font"
    static member inline fontSize = newTransitionProperty "font-size"
    static member inline fontSizeAdjust = newTransitionProperty "font-size-adjust"
    static member inline fontStretch = newTransitionProperty "font-stretch"
    static member inline fontVariationSettings = newTransitionProperty "font-variation-settings"
    static member inline fontWeight = newTransitionProperty "font-weight"
    static member inline gap = newTransitionProperty "gap"
    static member inline gridColumnGap = newTransitionProperty "grid-column-gap"
    static member inline gridGap = newTransitionProperty "grid-gap"
    static member inline gridRowGap = newTransitionProperty "grid-row-gap"
    static member inline gridTemplateColumns = newTransitionProperty "grid-template-columns"
    static member inline gridTemplateRows = newTransitionProperty "grid-template-rows"
    static member inline height = newTransitionProperty "height"
    static member inline inset = newTransitionProperty "inset"
    static member inline insetBlock = newTransitionProperty "inset-block"
    static member inline insetBlockEnd = newTransitionProperty "inset-block-end"
    static member inline insetBlockStart = newTransitionProperty "inset-block-start"
    static member inline insetInline = newTransitionProperty "inset-inline"
    static member inline insetInlineEnd = newTransitionProperty "inset-inline-end"
    static member inline insetInlineStart = newTransitionProperty "inset-inline-start"
    static member inline left = newTransitionProperty "left"
    static member inline letterSpacing = newTransitionProperty "letter-spacing"
    static member inline lineClamp = newTransitionProperty "line-clamp"
    static member inline lineHeight = newTransitionProperty "line-height"
    static member inline margin = newTransitionProperty "margin"
    static member inline marginBottom = newTransitionProperty "margin-bottom"
    static member inline marginLeft = newTransitionProperty "margin-left"
    static member inline marginRight = newTransitionProperty "margin-right"
    static member inline marginTop = newTransitionProperty "margin-top"
    static member inline mask = newTransitionProperty "mask"
    static member inline maskBorder = newTransitionProperty "mask-border"
    static member inline maskPosition = newTransitionProperty "mask-position"
    static member inline maskSize = newTransitionProperty "mask-size"
    static member inline maxHeight = newTransitionProperty "max-height"
    static member inline maxLines = newTransitionProperty "max-lines"
    static member inline maxWidth = newTransitionProperty "max-width"
    static member inline minHeight = newTransitionProperty "min-height"
    static member inline minWidth = newTransitionProperty "min-width"
    static member inline objectPosition = newTransitionProperty "object-position"
    static member inline offset = newTransitionProperty "offset"
    static member inline offsetAnchor = newTransitionProperty "offset-anchor"
    static member inline offsetDistance = newTransitionProperty "offset-distance"
    static member inline offsetPath = newTransitionProperty "offset-path"
    static member inline offsetPosition = newTransitionProperty "offset-position"
    static member inline offsetRotate = newTransitionProperty "offset-rotate"
    static member inline opacity = newTransitionProperty "opacity"
    static member inline order = newTransitionProperty "order"
    static member inline outline = newTransitionProperty "outline"
    static member inline outlineColor = newTransitionProperty "outline-color"
    static member inline outlineOffset = newTransitionProperty "outline-offset"
    static member inline outlineWidth = newTransitionProperty "outline-width"
    static member inline padding = newTransitionProperty "padding"
    static member inline paddingBottom = newTransitionProperty "padding-bottom"
    static member inline paddingLeft = newTransitionProperty "padding-left"
    static member inline paddingRight = newTransitionProperty "padding-right"
    static member inline paddingTop = newTransitionProperty "padding-top"
    static member inline perspective = newTransitionProperty "perspective"
    static member inline perspectiveOrigin = newTransitionProperty "perspective-origin"
    static member inline right = newTransitionProperty "right"
    static member inline rotate = newTransitionProperty "rotate"
    static member inline rowGap = newTransitionProperty "row-gap"
    static member inline scale = newTransitionProperty "scale"
    static member inline scrollMargin = newTransitionProperty "scroll-margin"
    static member inline scrollMarginBlock = newTransitionProperty "scroll-margin-block"
    static member inline scrollMarginBlockEnd = newTransitionProperty "scroll-margin-block-end"
    static member inline scrollMarginBlockStart = newTransitionProperty "scroll-margin-block-start"
    static member inline scrollMarginBottom = newTransitionProperty "scroll-margin-bottom"
    static member inline scrollMarginInline = newTransitionProperty "scroll-margin-inline"
    static member inline scrollMarginInlineEnd = newTransitionProperty "scroll-margin-inline-end"
    static member inline scrollMarginInlineStart = newTransitionProperty "scroll-margin-inline-start"
    static member inline scrollMarginLeft = newTransitionProperty "scroll-margin-left"
    static member inline scrollMarginRight = newTransitionProperty "scroll-margin-right"
    static member inline scrollMarginTop = newTransitionProperty "scroll-margin-top"
    static member inline scrollPadding = newTransitionProperty "scroll-padding"
    static member inline scrollPaddingBlock = newTransitionProperty "scroll-padding-block"
    static member inline scrollPaddingBlockEnd = newTransitionProperty "scroll-padding-block-end"
    static member inline scrollPaddingBlockStart = newTransitionProperty "scroll-padding-block-start"
    static member inline scrollPaddingBottom = newTransitionProperty "scroll-padding-bottom"
    static member inline scrollPaddingInline = newTransitionProperty "scroll-padding-inline"
    static member inline scrollPaddingInlineEnd = newTransitionProperty "scroll-padding-inline-end"
    static member inline scrollPaddingInlineStart = newTransitionProperty "scroll-padding-inline-start"
    static member inline scrollPaddingLeft = newTransitionProperty "scroll-padding-left"
    static member inline scrollPaddingRight = newTransitionProperty "scroll-padding-right"
    static member inline scrollPaddingTop = newTransitionProperty "scroll-padding-top"
    static member inline scrollSnapCoordinate = newTransitionProperty "scroll-snap-coordinate"
    static member inline scrollSnapDestination = newTransitionProperty "scroll-snap-destination"
    static member inline scrollbarColor = newTransitionProperty "scrollbar-color"
    static member inline shapeImageThreshold = newTransitionProperty "shape-image-threshold"
    static member inline shapeMargin = newTransitionProperty "shape-margin"
    static member inline shapeOutside = newTransitionProperty "shape-outside"
    static member inline tabSize = newTransitionProperty "tab-size"
    static member inline textDecoration = newTransitionProperty "text-decoration"
    static member inline textDecorationColor = newTransitionProperty "text-decoration-color"
    static member inline textEmphasis = newTransitionProperty "text-emphasis"
    static member inline textEmphasisColor = newTransitionProperty "text-emphasis-color"
    static member inline textIndent = newTransitionProperty "text-indent"
    static member inline textShadow = newTransitionProperty "text-shadow"
    static member inline top = newTransitionProperty "top"
    static member inline transform = newTransitionProperty "transform"
    static member inline transformOrigin = newTransitionProperty "transform-origin"
    static member inline translate = newTransitionProperty "translate"
    static member inline verticalAlign = newTransitionProperty "vertical-align"
    static member inline visibility = newTransitionProperty "visibility"
    static member inline width = newTransitionProperty "width"
    static member inline wordSpacing = newTransitionProperty "word-spacing"
    static member inline zIndex = newTransitionProperty "z-index"
    static member inline zoom = newTransitionProperty "zoom"
namespace Feliz.JSX

open Fable.Core
open Browser.Types

/// <summary>HTML Event generator API.</summary>
type Ev =
    /// Fires when a media event is aborted.
    static member inline onAbort (handler: Event -> unit): JSX.Prop = "onAbort", handler

    /// Fires when animation is aborted.
    static member inline onAnimationCancel (handler: AnimationEvent -> unit): JSX.Prop = "onAnimationCancel", handler

    /// Fires when animation ends.
    static member inline onAnimationEnd (handler: AnimationEvent -> unit): JSX.Prop = "onAnimationEnd", handler

    /// Fires when animation iterates.
    static member inline onAnimationIteration (handler: AnimationEvent -> unit): JSX.Prop = "onAnimationIteration", handler

    /// Fires when animation starts.
    static member inline onAnimationStart (handler: AnimationEvent -> unit): JSX.Prop = "onAnimationStart", handler

    /// Fires the moment that the element loses focus.
    static member inline onBlur (handler: FocusEvent -> unit): JSX.Prop = "onBlur", handler

    /// Fires when a user dismisses the current open dialog
    static member inline onCancel (handler: Event -> unit): JSX.Prop = "onCancel", handler

    /// Fires when a file is ready to start playing (when it has buffered enough to begin).
    static member inline onCanPlay (handler: Event -> unit): JSX.Prop = "onCanPlay", handler

    /// Fires when a file can be played all the way to the end without pausing for buffering
    static member inline onCanPlayThrough (handler: Event -> unit): JSX.Prop = "onCanPlayThrough", handler

    /// Fires the moment when the value of the element is changed
    static member inline onChange (handler: Event -> unit): JSX.Prop = "onChange",  handler

    /// Same as `onChange` that takes an event as input but instead let's you deal with the `checked` value changed from the `input` element
    /// directly when it is defined as a checkbox with attribute `inputType.checkbox`.
    static member inline onChange (handler: bool -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.``checked``)

    /// Same as `onChange` that takes an event as input but instead lets you deal with the selected file directly from the `input` element when it is defined as a checkbox with `prop.type'.file`.
    static member inline onChange (handler: File -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            let files : FileList = el.files
            if not (isNull files) && files.length > 0 then handler (files.item 0))

    /// Same as `onChange` that takes an event as input but instead lets you deal with the selected files directly from the `input` element when it is defined as a checkbox with `prop.type'.file` and `prop.multiple true`.
    static member inline onChange (handler: File list -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            let fileList : FileList = el.files
            if not (isNull fileList) then handler [ for i in 0 .. fileList.length - 1 -> fileList.item i ])

    /// Same as `onChange` that takes an event as input but instead let's you deal with the text changed from the `input` element directly
    /// instead of extracting it from the event arguments.
    static member inline onChange (handler: string -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.value)

    /// Same as `onChange` but let's you deal with the `checked` value that has changed from the `input` element directly instead of extracting it from the event arguments.
    static member inline onCheckedChange (handler: bool -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.``checked``)

    /// Fires on a mouse click on the element.
    static member inline onClick (handler: MouseEvent -> unit): JSX.Prop = "onClick", handler

    /// Fires when composition ends.
    static member inline onCompositionEnd (handler: CompositionEvent -> unit): JSX.Prop = "onCompositionEnd", handler

    /// Fires when composition starts.
    static member inline onCompositionStart (handler: CompositionEvent -> unit): JSX.Prop = "onCompositionStart", handler

    /// Fires when composition changes.
    static member inline onCompositionUpdate (handler: CompositionEvent -> unit): JSX.Prop = "onCompositionUpdate", handler

    /// Fires when a context menu is triggered.
    static member inline onContextMenu (handler: MouseEvent -> unit): JSX.Prop = "onContextMenu", handler

    /// Fires when a TextTrack has changed the currently displaying cues.
    static member inline onCueChange (handler: Event -> unit): JSX.Prop = "onCueChange", handler

        /// Fires when the user copies the content of an element.
    static member inline onCopy (handler: ClipboardEvent -> unit): JSX.Prop = "onCopy", handler

    /// Fires when the user cuts the content of an element.
    static member inline onCut (handler: ClipboardEvent -> unit): JSX.Prop = "onCut", handler

    /// Fires when a mouse is double clicked on the element.
    static member inline onDblClick (handler: MouseEvent -> unit): JSX.Prop = "onDblClick", handler

    /// Fires when an element is dragged.
    static member inline onDrag (handler: DragEvent -> unit): JSX.Prop = "onDrag", handler

    /// Fires when the a drag operation has ended.
    static member inline onDragEnd (handler: DragEvent -> unit): JSX.Prop = "onDragEnd", handler

    /// Fires when an element has been dragged to a valid drop target.
    static member inline onDragEnter (handler: DragEvent -> unit): JSX.Prop = "onDragEnter", handler

    static member inline onDragExit (handler: DragEvent -> unit): JSX.Prop = "onDragExit", handler

    /// Fires when an element leaves a valid drop target.
    static member inline onDragLeave (handler: DragEvent -> unit): JSX.Prop = "onDragLeave", handler

    /// Fires when an element is being dragged over a valid drop target.
    static member inline onDragOver (handler: DragEvent -> unit): JSX.Prop = "onDragOver", handler

    /// Fires when the a drag operation has begun.
    static member inline onDragStart (handler: DragEvent -> unit): JSX.Prop = "onDragStart", handler

    /// Fires when dragged element is being dropped.
    static member inline onDrop (handler: DragEvent -> unit): JSX.Prop = "onDrop", handler

    /// Fires when the length of the media changes.
    static member inline onDurationChange (handler: Event -> unit): JSX.Prop = "onDurationChange", handler

    /// Fires when something bad happens and the file is suddenly unavailable (like unexpectedly disconnects).
    static member inline onEmptied (handler: Event -> unit): JSX.Prop = "onEmptied", handler

    static member inline onEncrypted (handler: Event -> unit): JSX.Prop = "onEncrypted", handler

    /// Fires when the media has reached the end (a useful event for messages like "thanks for listening").
    static member inline onEnded (handler: Event -> unit): JSX.Prop = "onEnded", handler

    /// Fires when an error occurs.
    static member inline onError (handler: Event -> unit): JSX.Prop = "onError", handler

    /// Fires when an error occurs.
    static member inline onError (handler: UIEvent -> unit): JSX.Prop = "onError", handler

    /// Fires the moment when the element gets focus.
    static member inline onFocus (handler: FocusEvent -> unit): JSX.Prop = "onFocus", handler

    /// Fires when an element captures a pointer.
    static member inline onGotPointerCapture (handler: PointerEvent -> unit): JSX.Prop = "onGotPointerCapture", handler

    /// Fires when an element gets user input.
    static member inline onInput (handler: Event -> unit): JSX.Prop = "onInput", handler

    /// Fires when a submittable element has been checked for validaty and doesn't satisfy its constraints.
    static member inline onInvalid (handler: Event -> unit): JSX.Prop = "onInvalid", handler

    /// Fires when a user presses a key.
    static member inline onKeyDown (handler: KeyboardEvent -> unit): JSX.Prop = "onKeyDown", handler

    // /// Fires when a user presses a key.
    // static member inline onKeyDown (key: IKeyboardKey, handler: KeyboardEvent -> unit) =
    //     PropHelpers.createOnKey(key, handler)
    //     |> h.MakeEvent("keyDown",)

    /// Fires when a user presses a key.
    static member inline onKeyPress (handler: KeyboardEvent -> unit): JSX.Prop = "onKeyPress", handler

    // /// Fires when a user presses a key.
    // static member inline onKeyPress (key: IKeyboardKey, handler: KeyboardEvent -> unit) =
    //     PropHelpers.createOnKey(key, handler)
    //     |> h.MakeEvent("keyPress",)

    /// Fires when a user releases a key.
    static member inline onKeyUp (handler: KeyboardEvent -> unit): JSX.Prop = "onKeyUp", handler

    // /// Fires when a user releases a key.
    // static member inline onKeyUp (key: IKeyboardKey, handler: KeyboardEvent -> unit) =
    //     PropHelpers.createOnKey(key, handler)
    //     |> h.MakeEvent("keyUp",)

    /// Fires after the page is finished loading.
    static member inline onLoad (handler: Event -> unit): JSX.Prop = "onLoad", handler

    /// Fires when media data is loaded.
    static member inline onLoadedData (handler: Event -> unit): JSX.Prop = "onLoadedData", handler

    /// Fires when meta data (like dimensions and duration) are loaded.
    static member inline onLoadedMetadata (handler: Event -> unit): JSX.Prop = "onLoadedMetadata", handler

    /// Fires when a request has completed, irrespective of its success.
    static member inline onLoadEnd (handler: Event -> unit): JSX.Prop = "onLoadEnd", handler

    /// Fires when the file begins to load before anything is actually loaded.
    static member inline onLoadStart (handler: Event -> unit): JSX.Prop = "onLoadStart", handler

    /// Fires when a captured pointer is released.
    static member inline onLostPointerCapture (handler: PointerEvent -> unit): JSX.Prop = "onLostPointerCapture", handler

    /// Fires when a mouse button is pressed down on an element.
    static member inline onMouseDown (handler: MouseEvent -> unit): JSX.Prop = "onMouseDown", handler

    /// Fires when a pointer enters an element.
    static member inline onMouseEnter (handler: MouseEvent -> unit): JSX.Prop = "onMouseEnter", handler

    /// Fires when a pointer leaves an element.
    static member inline onMouseLeave (handler: MouseEvent -> unit): JSX.Prop = "onMouseLeave", handler

    /// Fires when the mouse pointer is moving while it is over an element.
    static member inline onMouseMove (handler: MouseEvent -> unit): JSX.Prop = "onMouseMove", handler

    /// Fires when the mouse pointer moves out of an element.
    static member inline onMouseOut (handler: MouseEvent -> unit): JSX.Prop = "onMouseOut", handler

    /// Fires when the mouse pointer moves over an element.
    static member inline onMouseOver (handler: MouseEvent -> unit): JSX.Prop = "onMouseOver", handler

    /// Fires when a mouse button is released while it is over an element.
    static member inline onMouseUp (handler: MouseEvent -> unit): JSX.Prop = "onMouseUp", handler

    /// Fires when the user pastes some content in an element.
    static member inline onPaste (handler: ClipboardEvent -> unit): JSX.Prop = "onPaste", handler

    /// Fires when the media is paused either by the user or programmatically.
    static member inline onPause (handler: Event -> unit): JSX.Prop = "onPause", handler

    /// Fires when the media is ready to start playing.
    static member inline onPlay (handler: Event -> unit): JSX.Prop = "onPlay", handler

    /// Fires when the media actually has started playing
    static member inline onPlaying (handler: Event -> unit): JSX.Prop = "onPlaying", handler

    /// Fires when there are no more pointer events.
    static member inline onPointerCancel (handler: PointerEvent -> unit): JSX.Prop = "onPointerCancel", handler

    /// Fires when a pointer becomes active.
    static member inline onPointerDown (handler: PointerEvent -> unit): JSX.Prop = "onPointerDown", handler

    /// Fires when a pointer is moved into an elements boundaries or one of its descendants.
    static member inline onPointerEnter (handler: PointerEvent -> unit): JSX.Prop = "onPointerEnter", handler

    /// Fires when a pointer is moved out of an elements boundaries.
    static member inline onPointerLeave (handler: PointerEvent -> unit): JSX.Prop = "onPointerLeave", handler

    /// Fires when a pointer moves.
    static member inline onPointerMove (handler: PointerEvent -> unit): JSX.Prop = "onPointerMove", handler

    /// Fires when a pointer is no longer in an elements boundaries, such as moving it, or after a `pointerUp` or `pointerCancel` event.
    static member inline onPointerOut (handler: PointerEvent -> unit): JSX.Prop = "onPointerOut", handler

    /// Fires when a pointer is moved into an elements boundaries.
    static member inline onPointerOver (handler: PointerEvent -> unit): JSX.Prop = "onPointerOver", handler

    /// Fires when a pointer is no longer active.
    static member inline onPointerUp (handler: PointerEvent -> unit): JSX.Prop = "onPointerUp", handler

    /// Fires when the browser is in the process of getting the media data.
    static member inline onProgress (handler: Event -> unit): JSX.Prop = "onProgress", handler

    /// Fires when the playback rate changes (like when a user switches to a slow motion or fast forward mode).
    static member inline onRateChange (handler: Event -> unit): JSX.Prop = "onRateChange", handler

    /// Fires when the Reset button in a form is clicked.
    static member inline onReset (handler: Event -> unit): JSX.Prop = "onReset", handler

    /// Fires when the window has been resized.
    static member inline onResize (handler: UIEvent -> unit): JSX.Prop = "onResize", handler

    /// Fires when an element's scrollbar is being scrolled.
    static member inline onScroll (handler: Event -> unit): JSX.Prop = "onScroll", handler

    /// Fires when the seeking attribute is set to false indicating that seeking has ended.
    static member inline onSeeked (handler: Event -> unit): JSX.Prop = "onSeeked", handler

    /// Fires when the seeking attribute is set to true indicating that seeking is active.
    static member inline onSeeking (handler: Event -> unit): JSX.Prop = "onSeeking", handler

    /// Fires after some text has been selected in an element.
    static member inline onSelect (handler: Event -> unit): JSX.Prop = "onSelect", handler

    /// Fires after some text has been selected in the user interface.
    static member inline onSelect (handler: UIEvent -> unit): JSX.Prop = "onSelect", handler

    /// Fires when the browser is unable to fetch the media data for whatever reason.
    static member inline onStalled (handler: Event -> unit): JSX.Prop = "onStalled", handler

    /// Fires when fetching the media data is stopped before it is completely loaded for whatever reason.
    static member inline onSuspend (handler: Event -> unit): JSX.Prop = "onSuspend", handler

    /// Fires when a form is submitted.
    static member inline onSubmit (handler: Event -> unit): JSX.Prop = "onSubmit", handler

    /// Same as `onChange` but let's you deal with the text changed from the `input` element directly
    /// instead of extracting it from the event arguments.
    static member inline onTextChange (handler: string -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.value)

    /// Same as `onInput` but let's you deal with the text changed from the `input` element directly
    /// instead of extracting it from the event arguments.
    static member inline onTextInput (handler: string -> unit) =
        "onInput", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.value)

    /// Fires when the playing position has changed (like when the user fast forwards to a different point in the media).
    static member inline onTimeUpdate (handler: Event -> unit): JSX.Prop = "onTimeUpdate", handler

    static member inline onTouchCancel (handler: TouchEvent -> unit): JSX.Prop = "onTouchCancel", handler

    static member inline onTouchEnd (handler: TouchEvent -> unit): JSX.Prop = "onTouchEnd", handler

    static member inline onTouchMove (handler: TouchEvent -> unit): JSX.Prop = "onTouchMove", handler

    static member inline onTouchStart (handler: TouchEvent -> unit): JSX.Prop = "onTouchStart", handler

    static member inline onTransitionEnd (handler: TransitionEvent -> unit): JSX.Prop = "onTransitionEnd", handler

    /// Fires when the volume is changed which (includes setting the volume to "mute").
    static member inline onVolumeChange (handler: Event -> unit): JSX.Prop = "onVolumeChange", handler

    /// Fires when the media has paused but is expected to resume (like when the media pauses to buffer more data).
    static member inline onWaiting (handler: Event -> unit): JSX.Prop = "onWaiting", handler

    /// Fires when the mouse wheel rolls up or down over an element.
    static member inline onWheel (handler: WheelEvent -> unit): JSX.Prop = "onWheel", handler

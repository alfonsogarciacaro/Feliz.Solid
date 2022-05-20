namespace Feliz

open Browser.Types
open Fable.Core

/// <summary>HTML Event generator API.</summary>
type EventEngine() =
    /// Fires when a media event is aborted.
    member inline _.onAbort (handler: Event -> unit): JSX.Prop = "onAbort", handler

    /// Fires when animation is aborted.
    member inline _.onAnimationCancel (handler: AnimationEvent -> unit): JSX.Prop = "onAnimationCancel", handler

    /// Fires when animation ends.
    member inline _.onAnimationEnd (handler: AnimationEvent -> unit): JSX.Prop = "onAnimationEnd", handler

    /// Fires when animation iterates.
    member inline _.onAnimationIteration (handler: AnimationEvent -> unit): JSX.Prop = "onAnimationIteration", handler

    /// Fires when animation starts.
    member inline _.onAnimationStart (handler: AnimationEvent -> unit): JSX.Prop = "onAnimationStart", handler

    /// Fires the moment that the element loses focus.
    member inline _.onBlur (handler: FocusEvent -> unit): JSX.Prop = "onBlur", handler

    /// Fires when a user dismisses the current open dialog
    member inline _.onCancel (handler: Event -> unit): JSX.Prop = "onCancel", handler

    /// Fires when a file is ready to start playing (when it has buffered enough to begin).
    member inline _.onCanPlay (handler: Event -> unit): JSX.Prop = "onCanPlay", handler

    /// Fires when a file can be played all the way to the end without pausing for buffering
    member inline _.onCanPlayThrough (handler: Event -> unit): JSX.Prop = "onCanPlayThrough", handler

    /// Fires the moment when the value of the element is changed
    member inline _.onChange (handler: Event -> unit): JSX.Prop = "onChange",  handler

    /// Same as `onChange` that takes an event as input but instead let's you deal with the `checked` value changed from the `input` element
    /// directly when it is defined as a checkbox with attribute `inputType.checkbox`.
    member inline _.onChange (handler: bool -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.``checked``)

    /// Same as `onChange` that takes an event as input but instead lets you deal with the selected file directly from the `input` element when it is defined as a checkbox with `prop.type'.file`.
    member inline _.onChange (handler: File -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            let files : FileList = el.files
            if not (isNull files) && files.length > 0 then handler (files.item 0))

    /// Same as `onChange` that takes an event as input but instead lets you deal with the selected files directly from the `input` element when it is defined as a checkbox with `prop.type'.file` and `prop.multiple true`.
    member inline _.onChange (handler: File list -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            let fileList : FileList = el.files
            if not (isNull fileList) then handler [ for i in 0 .. fileList.length - 1 -> fileList.item i ])

    /// Same as `onChange` that takes an event as input but instead let's you deal with the text changed from the `input` element directly
    /// instead of extracting it from the event arguments.
    member inline _.onChange (handler: string -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.value)

    /// Same as `onChange` but let's you deal with the `checked` value that has changed from the `input` element directly instead of extracting it from the event arguments.
    member inline _.onCheckedChange (handler: bool -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.``checked``)

    /// Fires on a mouse click on the element.
    member inline _.onClick (handler: MouseEvent -> unit): JSX.Prop = "onClick", handler

    /// Fires when composition ends.
    member inline _.onCompositionEnd (handler: CompositionEvent -> unit): JSX.Prop = "onCompositionEnd", handler

    /// Fires when composition starts.
    member inline _.onCompositionStart (handler: CompositionEvent -> unit): JSX.Prop = "onCompositionStart", handler

    /// Fires when composition changes.
    member inline _.onCompositionUpdate (handler: CompositionEvent -> unit): JSX.Prop = "onCompositionUpdate", handler

    /// Fires when a context menu is triggered.
    member inline _.onContextMenu (handler: MouseEvent -> unit): JSX.Prop = "onContextMenu", handler

    /// Fires when a TextTrack has changed the currently displaying cues.
    member inline _.onCueChange (handler: Event -> unit): JSX.Prop = "onCueChange", handler

        /// Fires when the user copies the content of an element.
    member inline _.onCopy (handler: ClipboardEvent -> unit): JSX.Prop = "onCopy", handler

    /// Fires when the user cuts the content of an element.
    member inline _.onCut (handler: ClipboardEvent -> unit): JSX.Prop = "onCut", handler

    /// Fires when a mouse is double clicked on the element.
    member inline _.onDblClick (handler: MouseEvent -> unit): JSX.Prop = "onDblClick", handler

    /// Fires when an element is dragged.
    member inline _.onDrag (handler: DragEvent -> unit): JSX.Prop = "onDrag", handler

    /// Fires when the a drag operation has ended.
    member inline _.onDragEnd (handler: DragEvent -> unit): JSX.Prop = "onDragEnd", handler

    /// Fires when an element has been dragged to a valid drop target.
    member inline _.onDragEnter (handler: DragEvent -> unit): JSX.Prop = "onDragEnter", handler

    member inline _.onDragExit (handler: DragEvent -> unit): JSX.Prop = "onDragExit", handler

    /// Fires when an element leaves a valid drop target.
    member inline _.onDragLeave (handler: DragEvent -> unit): JSX.Prop = "onDragLeave", handler

    /// Fires when an element is being dragged over a valid drop target.
    member inline _.onDragOver (handler: DragEvent -> unit): JSX.Prop = "onDragOver", handler

    /// Fires when the a drag operation has begun.
    member inline _.onDragStart (handler: DragEvent -> unit): JSX.Prop = "onDragStart", handler

    /// Fires when dragged element is being dropped.
    member inline _.onDrop (handler: DragEvent -> unit): JSX.Prop = "onDrop", handler

    /// Fires when the length of the media changes.
    member inline _.onDurationChange (handler: Event -> unit): JSX.Prop = "onDurationChange", handler

    /// Fires when something bad happens and the file is suddenly unavailable (like unexpectedly disconnects).
    member inline _.onEmptied (handler: Event -> unit): JSX.Prop = "onEmptied", handler

    member inline _.onEncrypted (handler: Event -> unit): JSX.Prop = "onEncrypted", handler

    /// Fires when the media has reached the end (a useful event for messages like "thanks for listening").
    member inline _.onEnded (handler: Event -> unit): JSX.Prop = "onEnded", handler

    /// Fires when an error occurs.
    member inline _.onError (handler: Event -> unit): JSX.Prop = "onError", handler

    /// Fires when an error occurs.
    member inline _.onError (handler: UIEvent -> unit): JSX.Prop = "onError", handler

    /// Fires the moment when the element gets focus.
    member inline _.onFocus (handler: FocusEvent -> unit): JSX.Prop = "onFocus", handler

    /// Fires when an element captures a pointer.
    member inline _.onGotPointerCapture (handler: PointerEvent -> unit): JSX.Prop = "onGotPointerCapture", handler

    /// Fires when an element gets user input.
    member inline _.onInput (handler: Event -> unit): JSX.Prop = "onInput", handler

    /// Fires when a submittable element has been checked for validaty and doesn't satisfy its constraints.
    member inline _.onInvalid (handler: Event -> unit): JSX.Prop = "onInvalid", handler

    /// Fires when a user presses a key.
    member inline _.onKeyDown (handler: KeyboardEvent -> unit): JSX.Prop = "onKeyDown", handler

    // /// Fires when a user presses a key.
    // member inline _.onKeyDown (key: IKeyboardKey, handler: KeyboardEvent -> unit) =
    //     PropHelpers.createOnKey(key, handler)
    //     |> h.MakeEvent("keyDown",)

    /// Fires when a user presses a key.
    member inline _.onKeyPress (handler: KeyboardEvent -> unit): JSX.Prop = "onKeyPress", handler

    // /// Fires when a user presses a key.
    // member inline _.onKeyPress (key: IKeyboardKey, handler: KeyboardEvent -> unit) =
    //     PropHelpers.createOnKey(key, handler)
    //     |> h.MakeEvent("keyPress",)

    /// Fires when a user releases a key.
    member inline _.onKeyUp (handler: KeyboardEvent -> unit): JSX.Prop = "onKeyUp", handler

    // /// Fires when a user releases a key.
    // member inline _.onKeyUp (key: IKeyboardKey, handler: KeyboardEvent -> unit) =
    //     PropHelpers.createOnKey(key, handler)
    //     |> h.MakeEvent("keyUp",)

    /// Fires after the page is finished loading.
    member inline _.onLoad (handler: Event -> unit): JSX.Prop = "onLoad", handler

    /// Fires when media data is loaded.
    member inline _.onLoadedData (handler: Event -> unit): JSX.Prop = "onLoadedData", handler

    /// Fires when meta data (like dimensions and duration) are loaded.
    member inline _.onLoadedMetadata (handler: Event -> unit): JSX.Prop = "onLoadedMetadata", handler

    /// Fires when a request has completed, irrespective of its success.
    member inline _.onLoadEnd (handler: Event -> unit): JSX.Prop = "onLoadEnd", handler

    /// Fires when the file begins to load before anything is actually loaded.
    member inline _.onLoadStart (handler: Event -> unit): JSX.Prop = "onLoadStart", handler

    /// Fires when a captured pointer is released.
    member inline _.onLostPointerCapture (handler: PointerEvent -> unit): JSX.Prop = "onLostPointerCapture", handler

    /// Fires when a mouse button is pressed down on an element.
    member inline _.onMouseDown (handler: MouseEvent -> unit): JSX.Prop = "onMouseDown", handler

    /// Fires when a pointer enters an element.
    member inline _.onMouseEnter (handler: MouseEvent -> unit): JSX.Prop = "onMouseEnter", handler

    /// Fires when a pointer leaves an element.
    member inline _.onMouseLeave (handler: MouseEvent -> unit): JSX.Prop = "onMouseLeave", handler

    /// Fires when the mouse pointer is moving while it is over an element.
    member inline _.onMouseMove (handler: MouseEvent -> unit): JSX.Prop = "onMouseMove", handler

    /// Fires when the mouse pointer moves out of an element.
    member inline _.onMouseOut (handler: MouseEvent -> unit): JSX.Prop = "onMouseOut", handler

    /// Fires when the mouse pointer moves over an element.
    member inline _.onMouseOver (handler: MouseEvent -> unit): JSX.Prop = "onMouseOver", handler

    /// Fires when a mouse button is released while it is over an element.
    member inline _.onMouseUp (handler: MouseEvent -> unit): JSX.Prop = "onMouseUp", handler

    /// Fires when the user pastes some content in an element.
    member inline _.onPaste (handler: ClipboardEvent -> unit): JSX.Prop = "onPaste", handler

    /// Fires when the media is paused either by the user or programmatically.
    member inline _.onPause (handler: Event -> unit): JSX.Prop = "onPause", handler

    /// Fires when the media is ready to start playing.
    member inline _.onPlay (handler: Event -> unit): JSX.Prop = "onPlay", handler

    /// Fires when the media actually has started playing
    member inline _.onPlaying (handler: Event -> unit): JSX.Prop = "onPlaying", handler

    /// Fires when there are no more pointer events.
    member inline _.onPointerCancel (handler: PointerEvent -> unit): JSX.Prop = "onPointerCancel", handler

    /// Fires when a pointer becomes active.
    member inline _.onPointerDown (handler: PointerEvent -> unit): JSX.Prop = "onPointerDown", handler

    /// Fires when a pointer is moved into an elements boundaries or one of its descendants.
    member inline _.onPointerEnter (handler: PointerEvent -> unit): JSX.Prop = "onPointerEnter", handler

    /// Fires when a pointer is moved out of an elements boundaries.
    member inline _.onPointerLeave (handler: PointerEvent -> unit): JSX.Prop = "onPointerLeave", handler

    /// Fires when a pointer moves.
    member inline _.onPointerMove (handler: PointerEvent -> unit): JSX.Prop = "onPointerMove", handler

    /// Fires when a pointer is no longer in an elements boundaries, such as moving it, or after a `pointerUp` or `pointerCancel` event.
    member inline _.onPointerOut (handler: PointerEvent -> unit): JSX.Prop = "onPointerOut", handler

    /// Fires when a pointer is moved into an elements boundaries.
    member inline _.onPointerOver (handler: PointerEvent -> unit): JSX.Prop = "onPointerOver", handler

    /// Fires when a pointer is no longer active.
    member inline _.onPointerUp (handler: PointerEvent -> unit): JSX.Prop = "onPointerUp", handler

    /// Fires when the browser is in the process of getting the media data.
    member inline _.onProgress (handler: Event -> unit): JSX.Prop = "onProgress", handler

    /// Fires when the playback rate changes (like when a user switches to a slow motion or fast forward mode).
    member inline _.onRateChange (handler: Event -> unit): JSX.Prop = "onRateChange", handler

    /// Fires when the Reset button in a form is clicked.
    member inline _.onReset (handler: Event -> unit): JSX.Prop = "onReset", handler

    /// Fires when the window has been resized.
    member inline _.onResize (handler: UIEvent -> unit): JSX.Prop = "onResize", handler

    /// Fires when an element's scrollbar is being scrolled.
    member inline _.onScroll (handler: Event -> unit): JSX.Prop = "onScroll", handler

    /// Fires when the seeking attribute is set to false indicating that seeking has ended.
    member inline _.onSeeked (handler: Event -> unit): JSX.Prop = "onSeeked", handler

    /// Fires when the seeking attribute is set to true indicating that seeking is active.
    member inline _.onSeeking (handler: Event -> unit): JSX.Prop = "onSeeking", handler

    /// Fires after some text has been selected in an element.
    member inline _.onSelect (handler: Event -> unit): JSX.Prop = "onSelect", handler

    /// Fires after some text has been selected in the user interface.
    member inline _.onSelect (handler: UIEvent -> unit): JSX.Prop = "onSelect", handler

    /// Fires when the browser is unable to fetch the media data for whatever reason.
    member inline _.onStalled (handler: Event -> unit): JSX.Prop = "onStalled", handler

    /// Fires when fetching the media data is stopped before it is completely loaded for whatever reason.
    member inline _.onSuspend (handler: Event -> unit): JSX.Prop = "onSuspend", handler

    /// Fires when a form is submitted.
    member inline _.onSubmit (handler: Event -> unit): JSX.Prop = "onSubmit", handler

    /// Same as `onChange` but let's you deal with the text changed from the `input` element directly
    /// instead of extracting it from the event arguments.
    member inline _.onTextChange (handler: string -> unit) =
        "onChange", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.value)

    /// Same as `onInput` but let's you deal with the text changed from the `input` element directly
    /// instead of extracting it from the event arguments.
    member inline _.onTextInput (handler: string -> unit) =
        "onInput", box(fun (ev: Event) ->
            let el = ev.target :?> HTMLInputElement
            handler el.value)

    /// Fires when the playing position has changed (like when the user fast forwards to a different point in the media).
    member inline _.onTimeUpdate (handler: Event -> unit): JSX.Prop = "onTimeUpdate", handler

    member inline _.onTouchCancel (handler: TouchEvent -> unit): JSX.Prop = "onTouchCancel", handler

    member inline _.onTouchEnd (handler: TouchEvent -> unit): JSX.Prop = "onTouchEnd", handler

    member inline _.onTouchMove (handler: TouchEvent -> unit): JSX.Prop = "onTouchMove", handler

    member inline _.onTouchStart (handler: TouchEvent -> unit): JSX.Prop = "onTouchStart", handler

    member inline _.onTransitionEnd (handler: TransitionEvent -> unit): JSX.Prop = "onTransitionEnd", handler

    /// Fires when the volume is changed which (includes setting the volume to "mute").
    member inline _.onVolumeChange (handler: Event -> unit): JSX.Prop = "onVolumeChange", handler

    /// Fires when the media has paused but is expected to resume (like when the media pauses to buffer more data).
    member inline _.onWaiting (handler: Event -> unit): JSX.Prop = "onWaiting", handler

    /// Fires when the mouse wheel rolls up or down over an element.
    member inline _.onWheel (handler: WheelEvent -> unit): JSX.Prop = "onWheel", handler

/* AutoComplete Module Options */
//      elementType:            What we are adding to the DOM for each result
//      domClass:               Class given to each element we are adding
//      container:              <div> that wraps the resulting dropdown
//      dataSource:             Source of autocomplete options
//      getInputBox:            Function to access state input box
//      callbackFunction:       Handler for returned data

const AutoCompleteModule = function () {
    let options, currentFocus, index;

    const init = function (autoCompleteOptions) {
        options = autoCompleteOptions;
        setValues();
    };

    const setValues = function () {
        let box = options.getInputBox();
        box.on("keyup", function (e) {
            if (!checkNavigationButton(this, e)) {
                searchData(box.val());
            }
        });
    };

    const checkNavigationButton = function (caller, e) {
        let isNavigationButton = true;

        switch (e.keyCode) {
            case 38:    // Up
            case 40:    // Down
                handleArrowPressed(e.keyCode - 39);
                break
            case 13:    // Enter
                e.preventDefault();
                handleEnterPressed();
                break;
            default:
                isNavigationButton = false;
        }
        return isNavigationButton;
    }

    const handleArrowPressed = function (key) {
        currentFocus += key;
        if (currentFocus >= index - 1) currentFocus = index - 1;
        if (currentFocus < 0) currentFocus = 0;
        $(`.${options.domClass}-${currentFocus}`)
            .addClass("autocomplete-active");
        $(`.${options.domClass}-${currentFocus - key}`)
            .removeClass("autocomplete-active");
    }

    const handleEnterPressed = function () {
        // If item highlighted, select it
        if (currentFocus > -1) {
            $(`.${options.domClass}-${currentFocus}`).click();
        // Otherwise, select the first item in the list
        } else if (currentFocus === -1 && index > 0) {
            $(`.${options.domClass}-0`)
                .addClass("autocomplete-active");
            $(`.${options.domClass}-0`)
                .click();
        }
    }

    const searchData = function (text) {
        text = text.toLowerCase().replace(/[^a-zA-Z]/g, "")
        clearDropdown();
        if (options.getInputBox().val()) {
            index = 0;
            options.dataSource.forEach(function (value, key) {
                if (key.includes(text)) {
                    appendListItem(key, value);
                    attachEventToListItem(key, value);
                    index++;
                }
            });
        }
    };

    const clearDropdown = function () {
        currentFocus = -1;
        $(`.${options.domClass}`).remove();
    };

    const appendListItem = function (id, value) {
        $(`#${options.container}`)
            .append(`<${options.elementType} 
                class="${options.domClass} ${options.domClass}-${index}" id="${id}">
                        ${value}
                    </${options.elementType}>`);
    };

    const attachEventToListItem = function (id, value) {
        $(`#${id}`).click(function () {
            options.callbackFunction(value);
        });
    };

    return { init };
}();
/* AutoComplete Module Options */
//      elementType:            What we are adding to the DOM for each result - for example, <li>
//      domClass:               Class given to each element we are adding
//      dataSource:             Source of autocomplete options
//      callbackFunction:       Handler for returned data
//      inputBox:               Input element that is being written into by user
//      container:              <div> that wraps the resulting dropdown

const AutoCompleteModule = function () {
    let options, currentFocus, index;

    const init = function (autoCompleteOptions) {
        options = autoCompleteOptions;
        setValues();
    };

    const setValues = function () {
        let box = options.getInputBox();
        box.on("keyup", function (e) {
            if (!checkNavigationButton(this, e))
                searchData(box.val()
                    .toLowerCase()
                    .replace(/[^a-zA-Z]/g, ""));
        });
    };

    const checkNavigationButton = function (caller, e) {
        // If arrow up or arrow down
        if (e.keyCode === 38 || e.keyCode === 40) {
            return addActive(e.keyCode - 39);
        // If enter
        } else if (e.keyCode === 13) {
            e.preventDefault();
            // If the user has something in the list highlighted, 'enter' selects that state/region
            if (currentFocus > -1) {
                $(`.${options.domClass}-${currentFocus}`).click();
                return true;
            // Otherwise, select the first item in the list
            } else if (currentFocus === -1 && index > 0) {
                $(`.${options.domClass}-0`).addClass("autocomplete-active");
                $(`.${options.domClass}-0`).click();
            }
        }
        return false;
    }

    const addActive = function (key) {
        // key will either be -1 or 1 and is used to set bounds on highlighting the list
        currentFocus += key;
        if (currentFocus >= index - 1) currentFocus = index - 1;
        if (currentFocus < 0) currentFocus = 0;
        $(`.${options.domClass}-${currentFocus}`).addClass("autocomplete-active");
        $(`.${options.domClass}-${currentFocus - key}`).removeClass("autocomplete-active");
        return true;
    }

    const searchData = function (text) {
        // Repopulating the autcomplete list based on the value in the text box
        clearDropdown();
        if (!options.getInputBox().val()) {
            return;
        }

        index = 0;
        options.dataSource.forEach(function (value, key) {
            let newKey = key.replace(/ /g, "");
            if (key.includes(text)) {
                appendListItem(newKey, value);
                attachEventToListItem(newKey, value);
                index++;
            }
        });
    };

    const clearDropdown = function () {
        currentFocus = -1;
        $(`.${options.domClass}`).remove();
    };

    const appendListItem = function (id, value) {
        $(`#${options.container}`)
            .append(`<${options.elementType} class="${options.domClass} ${options.domClass}-${index}" id="${id}">
                        ${value}
                    </${options.elementType}>`);
    };

    const attachEventToListItem = function (id, value) {
        $(`#${id}`).click(function () {
            options.callbackFunction(value);
        });
    };

    return {
        init: init
    };
}();
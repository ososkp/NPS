/* AutoComplete Module */
//      elementType:            What we are adding to the DOM for each result - for example, <li>
//      domClass:               Class given to each element we are adding
//      dataSource:             Source of autocomplete options
//      callbackFunction:       Handler for returned data
//      inputBox:               Input element that is being written into by user
//      container:              <div> that wraps the resulting dropdown

var AutoCompleteModule = function () {
    var options, currentFocus, index;

    var init = function (autoCompleteOptions) {
        options = autoCompleteOptions;
        setValues();
    };

    var setValues = function () {
        let box = options.getInputBox();
        box.on("keyup", function (e) {
            if (!checkNavigationButton(this, e))
                searchData(box.val());
        });
    };

    var checkNavigationButton = function (caller, e) {
        if (e.keyCode === 38 || e.keyCode === 40) {
            return addActive(e.keyCode - 39);
        } else if (e.keyCode === 13) {
            e.preventDefault();
            if (currentFocus > -1) {
                $(`.${options.domClass}-${currentFocus}`).click();
                return true;
            } else if (currentFocus === -1 && index > 0) {
                $(`.${options.domClass}-0`).addClass("autocomplete-active");
                $(`.${options.domClass}-0`).click();
            }
        }
        return false;
    }

    var addActive = function (key) {
        currentFocus += key;
        if (currentFocus >= index - 1) currentFocus = index - 1;
        if (currentFocus < 0) currentFocus = 0;
        $(`.${options.domClass}-${currentFocus}`).addClass("autocomplete-active");
        $(`.${options.domClass}-${currentFocus - key}`).removeClass("autocomplete-active");
        return true;
    }

    var searchData = function (text) {
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

    var clearDropdown = function () {
        currentFocus = -1;
        $(`.${options.domClass}`).remove();
    };

    var appendListItem = function (id, value) {
        $(`#${options.container}`)
            .append(`<${options.elementType} class="${options.domClass} ${options.domClass}-${index}" id="${id}">${value}</${options.type}>`);  //
    };

    var attachEventToListItem = function (id, value) {
        $(`#${id}`).click(function () {
            options.callbackFunction(value);
        });
    };

    return {
        init: init
    };
}();
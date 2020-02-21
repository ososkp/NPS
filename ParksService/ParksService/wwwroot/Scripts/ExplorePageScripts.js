$(document).ready(function () {
    const searchBoxDivOffset = 75;
    const slideSpeed = 150;

    const DIV_AUTOCOMPLETE = "#autocomplete"
    const DIV_DESIGNATION_SEARCH_RESULTS = ".designation-search-results";
    const DIV_EXPLORE_DESIGNATION = ".explore-designation";
    const DIV_EXPLORE_STATE = ".explore-state";
    const DIV_SEARCH_RESULTS = ".search-results";
    const DIV_VISITOR_DETAILS = ".visitor-details";
    const BUTTON_CLEAR_RESULTS = "#clear-results-button";
    const BUTTON_LINK = ".btn-link";
    const CLASS_MATCH = ".match";
    const STATES_BOX = ".states-box";
    const BODY = "body";
    const CLICK = "click";

    /* AutoComplete Module Options */
    //      elementType:            What we are adding to the DOM for each result
    //      domClass:               Class given to each element we are adding
    //      container:              <div> that wraps the resulting dropdown
    //      dataSource:             Source of autocomplete options
    //      getInputBox:            Function to access state input box
    //      callbackFunction:       Handler for returned data
    const myOptions = {
        elementType: "li",
        domClass: "match",
        container: "autocomplete-container",
        dataSource: states.parksLocations,
        getInputBox: function () {
            return $(DIV_AUTOCOMPLETE);
        },
        callbackFunction: function (data) {
            populateStateSearchResults(data);
        },
    };
    AutoCompleteModule.init(myOptions);

    const populateStateSearchResults = function (state) {
        $(DIV_DESIGNATION_SEARCH_RESULTS).empty();
        $(DIV_EXPLORE_DESIGNATION).slideUp(slideSpeed);
        $(BUTTON_CLEAR_RESULTS).show();

        $(DIV_AUTOCOMPLETE).val("");
        $(CLASS_MATCH).remove();

        $.ajax({
            url: "/Explore/GetParksByState/",
            type: "GET",
            dataType: "JSON",
            data: { state },
            success: function (data) {
                writeSearchResults(data.viewModel,
                    state, $(DIV_SEARCH_RESULTS));
            }
        });
    }

    const writeSearchResults = function (parks, searchPredicate, divParameter) {
        let div = divParameter;
        div.empty();
        div.append(`<h2>${searchPredicate}</h2>`);

        parks.forEach(function (park) {
            // Only show state if searching by designation
            let nameLine = div[0].className.includes("designation-search-results")
                ? `<h3>${park.fullName}</h3> <p class="state-listing">${park.fullState}</p>`
                : `<h3>${park.fullName}</h3>`;

            let line2Holder = park.address.line2
                ? park.address.line2 + "<br />"
                : "";
            let line3Holder = park.address.line3
                ? park.address.line3 + "<br />"
                : "";

            div.append(
                `<div class="result">
                        ${nameLine}
                        <div class="description">${park.description}</div>
                    <hr>
                    <div class="container">
                        <div class="row">
                            <div class="col-md-6 text-center">
                                <h4>Office Address:</h4>
                                <p>${park.address.line1}<br />
                                ${line2Holder} ${line3Holder}
                                ${park.address.city}  ${park.address.stateCode} ${park.address.postalCode}</p>
                            </div>
                            <div class="links col-md-6 text-center">
                                <h4>Information:</h4>
                                <input type="button" id="${park.id}" 
                                    class="btn btn-primary btn-lg visitor-details" value="Visitors"></input><br />
                                <a href="${park.url}" target="_blank" class="web-link table-link">Website</a>
                            </div>
                        </div>
                    </div>
                </div>`
            );
        });

        $("html,body").animate({
            scrollTop: div.offset().top - searchBoxDivOffset
        }, "medium");

        $(STATES_BOX).val("");
    }

    $(BODY).on(CLICK,
        DIV_VISITOR_DETAILS,
        function (button) {
            const id = button.target.id
            const url = `/Explore/VisitorDetails/${id}`;
            $.get(url,
                function (data) {
                    bootBoxModal(data); // BootBoxHelper.bootBoxModal
                }
            );
        }
    );

    $(BUTTON_LINK).on(CLICK,
        { button: $(this) },
        function (button) {
            $(DIV_SEARCH_RESULTS).empty();
            $(DIV_EXPLORE_STATE).slideUp(slideSpeed);
            $(BUTTON_CLEAR_RESULTS).show();

            const designation = button.target.id.replace("-", " ");
            $.ajax({
                url: "/Explore/GetParksByDesignation/",
                type: "GET",
                dataType: "JSON",
                data: {
                    designation: designation
                },
                success: function (data) {
                    writeSearchResults(data.viewModel,
                        `${designation}s`, $(DIV_DESIGNATION_SEARCH_RESULTS));
                }
            });
        }
    );

    $(BUTTON_CLEAR_RESULTS).on(CLICK,
        function () {
            $(BUTTON_CLEAR_RESULTS).hide();
            $(DIV_EXPLORE_DESIGNATION).slideDown(slideSpeed);
            $(DIV_EXPLORE_STATE).slideDown(slideSpeed);
            $(DIV_SEARCH_RESULTS).empty();
            $(DIV_DESIGNATION_SEARCH_RESULTS).empty();
        });
});
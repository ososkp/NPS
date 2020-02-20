$(document).ready(function () {
    const searchBoxDivOffset = 75;
    const slideSpeed = 150;

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
            return $(`#autocomplete`);
        },
        callbackFunction: function (data) {
            populateStateSearchResults(data);
        },
    };
    AutoCompleteModule.init(myOptions);

    const populateStateSearchResults = function (state) {
        $(".designation-search-results").empty();
        $(".explore-designation").slideUp(slideSpeed);
        $("#clear-results-button").show();

        $("#autocomplete").val("");
        $(".match").remove();

        $.ajax({
            url: "/Explore/GetParksByState/",
            type: "GET",
            dataType: "JSON",
            data: { state },
            success: function (data) {
                writeSearchResults(data.viewModel,
                    state, $(".search-results"));
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

        $(".states-box").val("");
    }

    $("body").on("click",
        ".visitor-details",
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

    $(".btn-link").on("click",
        { button: $(this) },
        function (button) {
            $(".search-results").empty();
            $(".explore-state").slideUp(slideSpeed);
            $("#clear-results-button").show();

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
                        `${designation}s`, $(".designation-search-results"));
                }
            });
        }
    );

    $("#clear-results-button").on("click",
        function () {
            $("#clear-results-button").hide();
            $(".explore-designation").slideDown(slideSpeed);
            $(".explore-state").slideDown(slideSpeed);
            $(".search-results").empty();
            $(".designation-search-results").empty();
        });
});
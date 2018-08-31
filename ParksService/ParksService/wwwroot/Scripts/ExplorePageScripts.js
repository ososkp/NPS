$(document).ready(function () {
    let searchBoxDivOffset;

    var myOptions = {
        elementType: "li",
        domClass: "match",
        dataSource: states.parksLocations,
        callbackFunction: function(data) {
            populateStateSearchResults(data);
        },
        inputBox: "autocomplete",
        container: "autocomplete-container",
        getInputBox: function() {
            return $(`#${this.inputBox}`);
        }
    };
    AutoCompleteModule.init(myOptions);

    var writeSearchResults = function(parks, searchPredicate, divParameter) {
        var div = divParameter;
        div.empty();
        div.append(`<h2>${searchPredicate}</h2>`);

        parks.forEach(function(park) {
//            If we're listing by designation, we want to show the state for each park
//            If sorting by state it's unnecessary
            var nameLine = div[0].className.includes("designation-search-results")
                ? `<h3>${park.fullName}</h3> <p class="state-listing">${park.fullState}</p>`
                : `<h3>${park.fullName}</h3>`;

            var line2Holder = park.address.line2
                ? park.address.line2 + "<br />"
                : "";
            var line3Holder = park.address.line3
                ? park.address.line3 + "<br />"
                : "";

            div.append(
                `<div class="result">
                        ${nameLine}
                        <div class="description">${park.description}</div>
                    <hr>
                    <div class="container">
                        <div class="row">
                            <div class="col-md-4 text-center">
                                <h4>Office Address:</h4>
                                <p>${park.address.line1}<br />
                                ${line2Holder} ${line3Holder}
                                ${park.address.city}  ${park.address.stateCode} ${park.address.postalCode}</p>
                            </div>
                            <div class="links col-md-4 text-center">
                                <h4>More Information:</h4>
                                <a href="${park.url}" target="_blank" class="table-link">Website</a><br />
                                <a href="${getUrl(park.latLong)}" target="_blank">Map</a><br />
                                <a href="/Home/ViewDetails/${park.id}" target="_blank">Details</a> <br />
                            </div>
                            <div class="col-md-4 text-center">
                                <h4>Visitors:</h4>
                                    <input type="button" class="btn btn-primary btn-lg visitor-details" value="Info"></input>
                            </div>
                        </div>
                    </div>
                </div>`
            );
        });

        $("html,body").animate({
                scrollTop: div.offset().top - searchBoxDivOffset
            },
            "medium");

        $(".states-box").val("");
    }

    $("body").on("click",
        ".visitor-details",
        function () {
            var url = `/Explore/VisitorDetails`;

            $.get(url,
                { id: this.id },
                function (data) {
                    bootbox.dialog({
                        title: null,
                        message: data,
                        buttons: {
                            main: {
                                label: "Okay",
                                className: "btn-primary",
                                callback: function () { }
                            }
                        },
                        className: "modal-large"
                    });
                }
            );
    });

    var populateStateSearchResults = function (state) {
        searchBoxDivOffset = 75;
        $(".designation-search-results").empty();
        $(".explore-designation").slideUp(150);
        $("#clear-results-button").show();

        $("#autocomplete").val("");
        $(".match").remove();

        $.ajax({
            url: "/Explore/GetParksByState/",
            type: "GET",
            dataType: "JSON",
            data: {
                state: state
            },
            success: function(data) {
                writeSearchResults(data.viewModel, state, $(".search-results"));
            }
        });
    }

    $(".btn-link").on("click", { button: $(this) }, function (button) {
        searchBoxDivOffset = 75;
        $(".search-results").empty();
        $(".explore-state").slideUp(150);
        $("#clear-results-button").show();

        var designation = button.target.id.replace("-", " ");
        $.ajax({
            url: "/Explore/GetParksByDesignation/",
            type: "GET",
            dataType: "JSON",
            data: {
                designation: designation
            },
            success: function(data) {
                writeSearchResults(data.viewModel, `${designation}s`, $(".designation-search-results"));
            }
        });
    });

    $("#clear-results-button").on("click",
        function () {
            $("#clear-results-button").hide();
            $(".explore-designation").slideDown(150);
            $(".explore-state").slideDown(150);
            $(".search-results").empty();
            $(".designation-search-results").empty();
        });
});
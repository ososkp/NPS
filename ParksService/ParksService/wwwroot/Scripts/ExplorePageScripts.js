$(document).ready(function () {
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

    var writeSearchResults = function (parks, searchPredicate, divParameter) {
        var div = divParameter;
        div.empty();
        div.append(`<h2>${searchPredicate}</h2>`);

        parks.forEach(function (park) {
//            If we're listing by designation, we want to show the state for each park
//            If sorting by state it's unnecessary
            var nameLine = div[0].className.includes("designation-search-results") ?
                `<h3>${park.fullName}</h3> <p class="hang-right">${park.fullState}</p>`
                : `<h3>${park.fullName}</h3>`;

            div.append(
                `<div class="result">
                        ${nameLine}
                                        <ul>
                        <li>${park.description}</li>
                        <li class="indented-li"><a href="${park.url}" target="_blank" class="table-link">Website</a></li>
                        <li class="indented-li"><a href="${getUrl(park.latLong)}" 
                            target="_blank">Map</a></li>
                    </ul>
                    <div class="address">
                        <h4>Office Address:</h4>
                        <p>${park.address.line1}</ p>
                        <p>${park.address.line2}</ p>
                        <p>${park.address.line3}</ p>
                        <p>${park.address.city}  ${park.address.stateCode} ${park.address.postalCode} <br />
                    </ div>
                </div>`
            );
        });
        $(".states-box").val("");
    }

    var populateStateSearchResults = function (state) {
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
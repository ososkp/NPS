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

    var writeStateSearchResults = function (parks, state) {
        var div = $(".search-results");
        div.empty();
        div.append(`<h2>${state}</h2>`);
        parks.forEach(function (park) {
            div.append(
                `<div class="result">
                    <h3>${park.fullName}</h3>
                                        <ul>
                        <li>${park.description}</li>
                        <li class="indented-li"><a href="${park.url}" target="_blank" class="table-link">Website</a></li>
                        <li class="indented-li"><a href="${getUrl(park.latLong)}" 
                            target="_blank">Map</a></li>
                    </ul>
                    <div class="address">
                        <h4>Address:</h4>
                        <p>${park.address.line1}</ p>
                        <p>${park.address.line2}</ p>
                        <p>${park.address.line3}</ p>
                        <p>${park.address.city}, ${park.address.stateCode} ${park.address.postalCode} <br />
                    </ div>
                </div>`
            );
        });
        $(".states-box").val("");
    }

    var populateStateSearchResults = function (state) {
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
                writeStateSearchResults(data.viewModel, state);
            }
        });
    }

    $("#clear-results-button").on("click",
        function() {
            $(".search-results").empty();
        });
});
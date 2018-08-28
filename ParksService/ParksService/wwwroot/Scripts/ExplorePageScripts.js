$(document).ready(function () {
        var myOptions = {
            elementType: "li",
            domClass: "match",
            dataSource: states.parksLocations,
            callbackFunction: function(value) {
                populateStateSearchResults(value);
            },
            inputBox: "autocomplete",
            container: "autocomplete-container",
            getInputBox: function() {
                return $(`#${this.inputBox}`);
            }
    };
    AutoCompleteModule.init(myOptions);

    var writeStateSearchResults = function(parks, state) {
        var div = $(".search-results");
        div.empty();
        div.append(`<h2>${state}</h2>`);
        parks.forEach(function(park) {
            div.append(
                `<div class="result">
                    <h3>${park.fullName}</h3>
                    <ul>
                        <li>${park.description}</li>
                        <li class="indented-li"><a href="${park.url}" target="_blank" class="table-link">Website</a></li>
                        <li class="indented-li"><a href="http://maps.google.com/maps?q=${park.latitude},${park.longitude}" 
                            target="_blank">Map</a></li>
                    </ul>
                </div>`
            );
        });
        $(".states-box").val("");
    }

    var populateStateSearchResults = function(state) {
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
            var div = $(".search-results");
            div.empty();
        });

});

var states = function () {
    const statesData = new Map(
        [
            ["alabama", "Alabama"],
            ["alaska", "Alaska"],
            ["arizona", "Arizona"],
            ["arkansas", "Arkansas"],
            ["california", "California"],
            ["colorado", "Colorado"],
            ["connecticut", "Connecticut"],
            ["delaware", "Delaware"],
            ["florida", "Florida"],
            ["georgia", "Georgia"],
            ["hawaii", "Hawaii"],
            ["idaho", "Idaho"],
            ["illinois", "Illinois"],
            ["indiana", "Indiana"],
            ["iowa", "Iowa"],
            ["kansas", "Kansas"],
            ["kentucky", "Kentucky"],
            ["louisiana", "Louisiana"],
            ["maine", "Maine"],
            ["maryland", "Maryland"],
            ["massachusetts", "Massachusetts"],
            ["michigan", "Michigan"],
            ["minnesota", "Minnesota"],
            ["mississippi", "Mississippi"],
            ["missouri", "Missouri"],
            ["montana", "Montana"],
            ["nebraska", "Nebraska"],
            ["nevada", "Nevada"],
            ["new hampshire", "New Hampshire"],
            ["new jersey", "New Jersey"],
            ["new mexico", "New Mexico"],
            ["new york", "New York"],
            ["north carolina", "North Carolina"],
            ["north dakota", "North Dakota"],
            ["ohio", "Ohio"],
            ["oklahoma", "Oklahoma"],
            ["oregon", "Oregon"],
            ["pennsylvania", "Pennsylvania"],
            ["rhode island", "Rhode Island"],
            ["south carolina", "South Carolina"],
            ["south dakota", "South Dakota"],
            ["tennessee", "Tennessee"],
            ["texas", "Texas"],
            ["utah", "Utah"],
            ["vermont", "Vermont"],
            ["virgina", "Virgina"],
            ["washington", "Washington"],
            ["west virgina", "West Virgina"],
            ["wisconsin", "Wisconsin"],
            ["wyoming", "Wyoming"],
            ["washington dc", "Washington, D.C."],
            ["us virgin islands", "U.S. Virgin Islands"]
        ]);

    return {
        parksLocations: statesData
    };
}();
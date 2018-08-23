$(document).ready(function () {
    var states = new Map(
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
    
    var writeStateSearchResults = function (parks, state) {
        var div = $(".search-results");
        div.empty();
        div.append(`<h2>${state}</h2>`);
        parks.forEach(function(park) {
            div.append(
                `<h3>${park.fullName}</h3>
                <ul>
                    <li>${park.description}</li>
                    <li class="indented-li"><a href="${park.url}" target="_blank" class="table-link">Website</a></li>
                    <li class="indented-li"><a href="http://maps.google.com/maps?q=${park.latitude},${park.longitude}" target="_blank">Map</a></li>
                </ul>`
            );
        });
        $(".states-box").val("");
    }

    var populateStateSearchResults = function (state) {
        $.ajax({
            url: "/Explore/GetParksByState/",
            type: "GET",
            dataType: "JSON",
            data: {
                state: state
            },
            success: function (data) {
                writeStateSearchResults(data.viewModel, state);
            }
        });
    }

    function toSimpleString(string) {
        string = string.toLowerCase();
        string = string.replace(/[^\w^\s]/g, "");
        var RegExpression = /^[a-zA-Z\s]*$/;
        return string.match(RegExpression)[0];
    }

    $(".search-button").on("click",
        function() {
            var state = $(".states-box").val();
            populateStateSearchResults(state);
        });

    $(".states-box").bind("input",
        function () {
            var state = toSimpleString($(".states-box").val());
            if (states.has(state))
                populateStateSearchResults(states.get(state));
        });

// Populate states selection list - this will invoke immediately on page load
    void function () {
        var options = "";

        states.forEach(function(value) {
                options += `<option value="${value}" \>`;
            });

        document.getElementById("states-list").innerHTML = options;
    }();
})

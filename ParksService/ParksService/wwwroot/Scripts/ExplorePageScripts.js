$(document).ready(function () {











// Populate states selection list - this will invoke immediately on page load
    void function () {
        var states =
        [
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virgina",
            "Washington",
            "West Virgina",
            "Wisconsin",
            "Wyoming",
            "Washington DC"
        ];

        var options = "";

        for (var i = 0; i < states.length; i++) {
            options += `<option value="${states[i]}" \>`;
        }

        console.dir(options);

        document.getElementById("states-list").innerHTML = options;
    }();
})

import { NPS_API } from './Helpers/APIKeys.js';

var url = "https://developer.nps.gov/api/v1/parks";
var key = NPS_API;

$(document).ready(function () {
    var parks = [];

    $.ajax({
        type: "GET",
        url: url,
        data: {
            api_key: key
        },
        success: function (result) {
            return handleSuccess(result);
        }
    });

    let handleSuccess = function (result) {
        result.data.forEach(function (park) {
            parks.push(park);
        });
        console.log(parks);
    };
});
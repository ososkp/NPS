import { NPS_API } from './Helpers/APIKeys.js';

const url = "https://developer.nps.gov/api/v1/parks";
const key = NPS_API;

$(document).ready(function () {
    let parks = [];

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
// https://developer.nps.gov/api/v1/parks?limit=498&fields=addresses,entranceFees&api_key=5hCAzcru81QKEg1bDSyJz6KlMaFYTa3HTWmACBBs
import { NPS_API } from './Helpers/APIKeys.js';

$(document).ready(function () {
    // Refresh local parks.json from API source
    var refreshParks = function () {
        $("#parks-button").text("Loading...");
        $.ajax({
            url: "https://developer.nps.gov/api/v1/parks",
            data: {
                limit: 382,
                fields: "addresses,entranceFees",
                api_key: NPS_API,
                sort: "-name"
            },
            type: "GET",
            dataType: "JSON",
            success: function (data) {
                console.log(data);
                var parks = JSON.stringify(data.data);
                $.ajax({
                    type: "POST",
                    url: "/Home/PopulateParks",
                    data: parks,
                    dataType: "JSON",
                    contentType: "application/json; charset=utf-8",
                    complete: function () {
                        $("#parks-table").DataTable().ajax.reload();
                        $("#parks-button").text("Refresh Parks List");
                        $("#parks-button").blur();
                    }
                });
            },
            error: function (error) {
                console.log(error)
            }
        });
    };

    // Button press from view to call refresh
    $("#parks-button").click(function () {
        refreshParks();
    });

    // Build table from LOCAL .json file
    // This table is also refreshed to read new .json file when refreshParks() is called
    var table = $("#parks-table").DataTable({
        ajax: {
            url: "/Home/GetParks",
            method: "GET",
            dataType: "JSON",
            dataSrc: "viewModel"
        },
        processing: true,
        language: {
            processing: '<i class="fa fa-cog fa-spin fa-4x fa-fw"></i>'
        },
        rowId: "Id",
        select: "single",
        columns: [
            { data: "fullName" },
            { data: "states" },
            { data: "designation" },
            {
                "data": "latLong",
                "render": function (data, type, row, meta) {
                    data = `<a href="${getUrl(data)}" target="_blank" class="table-link">View on Map</a>`;
                    return data;
                }
            },
            {
                "data": "url",
                "render": function (data, type, row, meta) {
                    data = `<a href="${data}" target="_blank" class="table-link">Visit</a>`;
                    return data;
                }
            },
            {
                "defaultContent": "<button class=\"btn btn-primary\">View Details</button>"
            }
        ],
        pageLength: 50
    });

    // When a user clicks on "View Details" button, show partial view popup with details
    $("#parks-table tbody").on("click",
        "button",
        function () {
            var data = table.row($(this).parents("tr")).data();
            var id = data["id"];

            var url = `/Home/ViewDetails/${id}`;

            $.get(url,
                function (data) {
                    bootBoxModal(data);
                });
        });
});
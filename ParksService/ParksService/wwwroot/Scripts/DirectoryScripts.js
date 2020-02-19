import { NPS_API } from './Helpers/APIKeys.js';

$(document).ready(function () {
    // Refresh local parks.json from API source IF user presses "Refresh List" button
    const refreshParks = function () {
        $("#parks-button").text("Loading...");
        $.ajax({
            url: "https://developer.nps.gov/api/v1/parks",
            data: {
                limit: 496,
                fields: "addresses,entranceFees",
                api_key: NPS_API,
                sort: "-name"
            },
            type: "GET",
            dataType: "JSON",
            success: function (data) {
                const parks = JSON.stringify(data.data);
                $.ajax({
                    type: "POST",
                    url: "/Park/PopulateParks",
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

    const table = $("#parks-table").DataTable({
        ajax: {
            url: "/Park/GetParks",
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
            const data = table.row($(this).parents("tr")).data();
            const id = data["id"];

            const url = `/Park/ViewDetails/${id}`;

            $.get(url,
                function (data) {
                    bootBoxModal(data);
                });
        });
});
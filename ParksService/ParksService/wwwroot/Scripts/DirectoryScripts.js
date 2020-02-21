import { NPS_API } from './Helpers/APIKeys.js';

$(document).ready(function () {
    const PARKS_BUTTON = "#parks-button";
    const PARKS_TABLE = "#parks-table";
    const API_URL = "https://developer.nps.gov/api/v1/parks";
    const API_FIELDS = "addresses,entranceFees";
    const API_LIMIT = 496;
    const API_SORT = "-name";

    // Refresh local parks.json from API source IF user presses "Refresh List" button
    const refreshParks = function () {
        $(PARKS_BUTTON).text("Loading...");
        $.ajax({
            url: API_URL,
            data: {
                limit: API_LIMIT,
                fields: API_FIELDS,
                api_key: NPS_API,
                sort: API_SORT
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
                        $(PARKS_TABLE).DataTable().ajax.reload();
                        $(PARKS_BUTTON).text("Refresh Parks List");
                        $(PARKS_BUTTON).blur();
                    }
                });
            },
            error: function (error) {
                handleRefreshParksError(error);
            }
        });
    };

    const handleRefreshParksError = function (error) {
        console.log(error);
    }

    // This button is currently hidden as the API is broken
    $(PARKS_BUTTON).click(function () {
        refreshParks();
    });

    // Build table from LOCAL .json file
    // This table is also refreshed to read new .json file when refreshParks() is called
    const table = $(PARKS_TABLE).DataTable({
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
        pageLength: 25
    });

    $(PARKS_TABLE + " tbody").on("click",
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
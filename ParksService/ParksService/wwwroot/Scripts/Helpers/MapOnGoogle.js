// Google Maps' search requires format "1.111111,2.222222" for coordinates
const getUrl = function (coords) {
    const url = "http://maps.google.com/maps?q=";
    return url + coords.replace(/[a-zA-Z]|:|\s/g, "");
};
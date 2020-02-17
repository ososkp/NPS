const bootBoxModal = function(data) {
    bootbox.dialog({
        title: null,
        message: data,
        buttons: {
            main: {
                label: "Okay",
                className: "btn-primary",
                callback: function () { }
            }
        },
        className: "modal-large"
    });
}
var bootBoxModal = function(data) {
    bootbox.dialog({
        title: null,
        message: data,
        buttons: {
            main: {
                label: "Hiya",
                className: "btn-primary",
                callback: function () { }
            }
        },
        className: "modal-large"
    });
}
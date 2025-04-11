﻿window.showToastr = function (type, message) {
    if (type == "success") {
        toastr.success(message);
    }

    if (type == "error") {
        toastr.error(message);
    }
}

window.showSweetalert = function (type, message) {
    if (type == "success") {
        Swal.fire({
            title: "Success",
            text: message,
            icon: "question"
        });
    }

    if (type == "error") {
        Swal.fire({
            title: "Error",
            text: message,
            icon: "error"
        });
    }
}


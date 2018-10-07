﻿$(function () {
    var swapedId = null;

    $(".swap").on("click", function (event) {
        let target = event.target;

        if (swapedId === null) {
            swapedId = target.id;
            $(target).parent("li").addClass("list-group-item-warning");
        } else {
            let parent = $(`#${swapedId}`).parent("li");
            let swap1 = parent.children("select");
            let swap2 = $(target).parent("li").children("select");

            let swapValue = swap1.val();
            swap1.val(swap2.val());
            swap2.val(swapValue);

            parent.removeClass("list-group-item-warning");
            swapedId = null;
        }
    });
});
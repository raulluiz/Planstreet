$(function () {
    var toolbar = new dhx.Toolbar("toolbar_container");

    var data = [
        {
            type: "button",
            icon: "dxi-plus",
            value: "new"
        },
        {
            type: "button",
            icon: "dxi-folder-open",
            value: "open"
        },
        {
            type: "button",
            icon: "dxi-vault",
            value: "save"
        },
        {
            type: "button",
            icon: "dxi-delete",
            value: "delete"
        }
    ]

    toolbar.data.parse(data);
});


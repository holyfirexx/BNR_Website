export class testing {
    constructor() {
        this.users = [];
        this.href = "/user/getusers";
    }
    activate() {
        var currentContext = this;
        $.ajax(this.href, {
            type: 'POST',
            success: function (data) {
                currentContext.users = data;
            },
            error: function () {
                $('#notification-bar').text('An error occurred');
            }
        });
    }
}
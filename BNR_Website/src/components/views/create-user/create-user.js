import {user} from 'models/user'
export class CreateUser {
    vm = {
        success: false
    };
    constructor(){
        this.user = new user();
    }

    createUser(){
        let currentContext = this;
        this.href = "user/create"
        let request = {
            "Name":this.user.username,
            "Credentials": this.user.password,
            "Email": this.user.email,
            "Description": this.user.description,
            "Games": this.user.games
        }
        $.ajax(this.href, {
            type: 'POST',
            data: request,
            success: function (data) {
                this.vm.success = true;
            },
            error: function () {
                $('#notification-bar').text('An error occurred');
            }
        });
    }
}
import { Component } from '@angular/core';

@Component({
    selector: 'binding-element',
    templateUrl: './binding.component.html'
})
export class BindingComponent {
    username: string = '';
    status: string = '';
    userNames: string[] = [''];

    constructor() {
        this.status = 'away';
    }

    onbuttonClick() {
        this.username = "";
    }

    onAddUser() {

        this.userNames.push(this.username);
        this.username = "";

    }

    getColor() {
        return this.status === 'online' ? 'green' : 'red'
    }

    getStatus() {
        this.status = Math.random() > 0.5 ? 'online' : 'away';
    }
}
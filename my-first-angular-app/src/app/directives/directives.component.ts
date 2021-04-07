import { Component } from '@angular/core'

@Component({
    selector: 'directives-component',
    templateUrl: './directives.component.html',
    styles: []
})
export class DirectivesComponent {
    displayParagraph: boolean = false;
    ids: number[] = [];
    i: number = 0;

    constructor() {
        this.i = 0;
    }

    showHideDetails() {
        // var currentdate = new Date();
        /*   var datetime = currentdate.getDate() + "/"
               + (currentdate.getMonth() + 1) + "/"
               + currentdate.getFullYear() + " @ "
               + currentdate.getHours() + ":"
               + currentdate.getMinutes() + ":"
               + currentdate.getSeconds();*/
        this.i++;

        this.ids.push(this.i);

        this.displayParagraph = !this.displayParagraph;
    }

    getBgColor(id: number) {
        return id >= 5 ? 'blue' : '';
    }
}
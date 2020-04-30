import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  templateUrl: 'template.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Hector';
  imagePath = 'https://about.canva.com/wp-content/uploads/sites/3/2016/08/logos-1.png';
  detailsImagePath = 'https://1000logos.net/wp-content/uploads/2017/06/Target-Logo.png';
  isDisabled = true;
  pageHeader = 'What Is In the Name';
  classesToApply = 'paddingClass';
  applyPinkClass = true;
  applyPaddingClass = true;
  isBold = false;
  fontSize = 30;

  addClasses() {
    const classes = {
      pinkClass: this.applyPinkClass,
      paddingClass: this.applyPaddingClass
    };
    return classes;
  }

  changeBold() {
    this.isBold = !this.isBold;
  }
  constructor() { }
}

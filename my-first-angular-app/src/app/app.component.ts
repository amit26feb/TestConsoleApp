import { Component } from '@angular/core';
import { OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  isSuccess = false;
  message = "";

  ngOnInit() { }

  onChange() {
    this.isSuccess = !this.isSuccess;
    if (this.isSuccess)
    { this.message = "Hello" }
    else
    { this.message = "Hi!" }
  }

  onTextChange(event: any) {
    this.message = (<HTMLInputElement>event.target).value;
  }
}

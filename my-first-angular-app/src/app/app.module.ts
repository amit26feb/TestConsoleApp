import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { SuccessComponent } from './success/success.component';
import { FailureComponent } from './failure/failure.component';
import { FormsModule } from '@angular/forms';
import {BindingComponent} from './binding/binding.component';
import {DirectivesComponent} from './directives/directives.component'

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    SuccessComponent,
    FailureComponent,
    BindingComponent,
    DirectivesComponent
  ],
  imports: [
    BrowserModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

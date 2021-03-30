import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ChappComponent } from 'src/chapp/chapp.component';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    ChappComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

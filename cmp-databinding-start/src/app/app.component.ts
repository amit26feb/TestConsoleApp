import { Component, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  serverElements = [{ type: 'server', name: 'myServer', content: 'hula babula' }];

  constructor() {
  }

  onServerAdded(serverData: { type: string, name: string, content: string }) {
    console.log('onServerAdded');
    this.serverElements.push({
      type: 'server',
      name: serverData.name,
      content: serverData.content
    });
  }

  onBluePrintAdded(serverData: { type: string, name: string, content: string }) {
    this.serverElements.push({
      type: 'blueprint',
      name: serverData.name,
      content: serverData.content
    });
  }

  onCount(eve: number) {
    console.log(eve);
  }
}

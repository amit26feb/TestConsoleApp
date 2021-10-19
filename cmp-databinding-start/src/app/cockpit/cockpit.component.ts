import { Component, OnInit, Input, EventEmitter, Output, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-cockpit',
  templateUrl: './cockpit.component.html',
  styleUrls: ['./cockpit.component.css']
})
export class CockpitComponent implements OnInit {
  newServerName = '';
  @Output() serverCreated = new EventEmitter<{ type: string, name: string, content: string }>();
  @Output() bluePrintCreated = new EventEmitter<{ type: string, name: string, content: string }>();
  @Output() count :  EventEmitter<number> = new EventEmitter();

  @ViewChild('serverContent') serverContent : ElementRef

  constructor() { }

  ngOnInit(): void {
    this.count.emit(1002);
  }

  onAddServer() {
    this.serverCreated.emit({ type: 'server', name: this.newServerName, content: this.serverContent.nativeElement.value });
    this.count.emit(1001);
  }

  onAddBlueprint() {
    this.bluePrintCreated.emit({ type: 'blueprint', name: this.newServerName, content: this.serverContent.nativeElement.value });
  }
}

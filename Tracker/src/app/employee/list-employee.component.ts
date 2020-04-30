import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-list-employee',
  templateUrl: './list-employee.component.html',
  styleUrls: ['./list-employee.component.scss']
})
export class ListEmployeeComponent implements OnInit {
  firstName: string = 'Amit';
  lastName: string = 'Kumar';
  gender: string = 'Male';
  age: number = 32;
  colSpan: number = 2;
  constructor() { }

  ngOnInit() {
  }

}

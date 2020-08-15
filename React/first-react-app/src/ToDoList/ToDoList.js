import React, { Component } from "react";
import ToDoItem from "./ToDoItem";
import todosData from "./todosData";
import DoneItem from "../DoneItem/DoneItem";

class ToDoList extends Component {
  constructor() {
    //debugger;
    super();

    this.state = { todos: todosData };

    this.handleClick = this.handleClick.bind(this);
  }

  componentDidMount() {
    //decide and do
    setTimeout(() => this.state.doneList, 5000);
  }

  componentDidUpdate() {
    console.log("Did Update");
  }

  componentWillReceiveProps(newProp) {
    console.log("new Props");
  }

  handleClick(id) {
    console.log(this.state.todos.find((x) => x.id === 1));
    const newToDo = this.state.todos.map((x) => {
      if (x.id === id) {
        return {
          ...x,
          completed: !x.completed,
          highlight: true,
        };
      } else {
        return {
          ...x,
          highlight: false,
        };
      }
    });
    console.log(newToDo);
    this.setState({ todos: newToDo });
  }

  render() {
    const newToDo = this.state.todos.map((x) => (
      <ToDoItem key={x.id} toDoItem={x} checkChanged={this.handleClick} />
    ));

    //let doneList = ;

    let newDoneList = this.state.todos.map((x) => (
      <DoneItem key={x.id} doneItem={x} />
    ));

    return (
      <div>
        <div className="todo-list">{newToDo}</div>
        <div className="todo-list">{newDoneList}</div>
      </div>
    );
  }
}

/*function ToDoList() {
  return (
    <div className="todo-list">
      
      <ToDoItemm />
      <ToDoItemm />
    </div>
  );
}*/

export default ToDoList;

import React from "react";

function ToDoItem(props) {
  return (
    <div className="todo-item">
      <input
        type="checkbox"
        onChange={() => props.checkChanged(props.toDoItem.id)}
        checked={props.toDoItem.completed}
      />
      <p>{props.toDoItem.text} </p>
    </div>
  );
}

//function checkChanged() {
//  console.log("Checked");
//}

export default ToDoItem;

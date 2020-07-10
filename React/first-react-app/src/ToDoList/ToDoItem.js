import React from "react";

function ToDoItem() {
  return (
    <div className="todo-item">
      <input type="checkbox" onChange={checkChanged} />
      <p>Learn DS in Details </p>
    </div>
  );
}

function checkChanged() {
  console.log("Checked");
}

export default ToDoItem;

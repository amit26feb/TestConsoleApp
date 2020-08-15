import React from "react";

function DoneItem(props) {
  return (
    <div
      className={props.doneItem.highlight ? "todo-item-highlight" : "todo-item"}
    >
      <input type="checkbox" checked={props.doneItem.completed} />
      <p>{props.doneItem.text} </p>
    </div>
  );
}

export default DoneItem;

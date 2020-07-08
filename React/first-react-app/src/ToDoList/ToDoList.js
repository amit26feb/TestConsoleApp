import React from "react"
import ToDoItemm from "./ToDoItem"

function ToDoList() {   
    return (
        <div className="todo-list">
            <ToDoItemm />
            <ToDoItemm />
            <ToDoItemm />
        </div>
    )
}

export default ToDoList
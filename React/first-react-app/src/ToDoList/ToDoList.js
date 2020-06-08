import React from "react"

function ToDoList() {
    return (
        <div>
            <ul>
                <li><input type="checkbox" checked='true' /><p>Learn React Js </p></li>
                <li><input type="checkbox" /><p>Learn DS in Details </p></li>
                <li><input type="checkbox" /><p>Learn Language </p></li>
            </ul>
        </div>
    )
}

export default ToDoList
import React from "react";

function AllJokes(props) {
  return (
    <div className="blurred-box">
      <p style={{ display: props.jokes.question ? "block" : "none" }}>
        Question: {props.jokes.question}
      </p>
      <p style={{ display: !props.question && "#32CD32" }}>
        Pun:
        {props.jokes.punchLine
          ? props.jokes.punchLine
          : "This page has " + props.productOfId + " jokes! Lol"}
      </p>
    </div>
  );
}

export default AllJokes;

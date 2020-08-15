import React from "react";
import "./App.css";
import AllJokes from "./Jokes/AllJokes";
import { getData, setData, addJoke } from "./Util/Utils";

function App() {
  localStorage.clear();

  //Filter
  let top3Jokes;

  if (top3Jokes === undefined || top3Jokes.length === 0) {
    //LocalStorage set
    setData();
    // LocalStorage get
    top3Jokes = getData();

    //every
    const amIaJoke = top3Jokes.every(x => x.id > 10);
    addJoke(String(amIaJoke));
  }

  //filter
  top3Jokes = getData().filter(x => x.id <= 9);

  //reduce
  const productOfIds = top3Jokes.reduce((accumulator, currentValue) => ({
    id: accumulator.id * currentValue.id
  }));

  // let message =

  //mapping
  const jokesJson = top3Jokes.map(x => (
    <AllJokes
      key={x.id}
      jokes={x}
      productOfId={productOfIds.id}
      onPointerEnter={mouseEntered}
      onPointerLeave={mouseLeave}
    />
  ));

  return (
    <div>
      <h1>Joke of the day!</h1>
      <div className="App">{jokesJson}</div>
    </div>
  );
}

function mouseEntered() {
  console.log("Mouse Entered");
}

function mouseLeave() {
  console.log("Mouse Left");
}

export default App;

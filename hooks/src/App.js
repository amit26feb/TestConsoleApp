import {useEffect, useState} from 'react'
import randomColor from 'randomcolor'

function App() {
    const [count, setCount] = useState(0);
    const [color, setcolor] = useState(randomColor);

    function decrement() {
        setCount(prevCount => prevCount - 100000)
    }

    function increment() {
        setCount(prevCount => prevCount + 100000);

    }

    useEffect(() => {
        var intervalId = setInterval(() => {
            setcolor(randomColor());
            setCount(prevCount => prevCount + 1);
        }, 1000);
        return() => clearInterval(intervalId)
    }, []);

    return (
        <div>
            <h1 style={
                {color: color}
            }>
                {count}</h1>
            <button onClick={increment}>Increase!</button>
            <button onClick={decrement}>Decrease!</button>
            <input type='text'
                style={
                    {backgroundColor: color}
            }></input>
        </div>
    )
}


/* class App extends React.Component {
  constructor() {
      super()
      this.state = {
          count: 0
      }
  }
  
  render() {
      return (
          <div>
              <h1>{this.state.count}</h1>
              <button>Change!</button>
          </div>
      )
  }
} */


export default App;

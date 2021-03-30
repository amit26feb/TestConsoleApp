import React, {Component} from "react";

class MemeGenerator extends Component {
    constructor() {
        super();
        this.state = {
            topText: '',
            bottomText: '',
            memeImg: 'http://i.imgflip.com/1bij.jpg',
            allMemeImgs: []
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    componentDidMount() {
        fetch('https://api.imgflip.com/get_memes').then(response => response.json()).then(response => {
            const meme = response.data;
            this.setState({allMemeImgs: response.data})
        })
    }

    handleChange(event) {
        const {name, value} = event.target;
        this.setState({[name]: value});
    }

    handleSubmit(event) {
        event.preventDefault()
        const randNum = Math.floor(Math.random() * this.state.allMemeImgs.length)
        console.log(this.state.allMemeImgs);
        const randMemeImg = this.state.allMemeImgs[randNum].url
        this.setState({ memeImg: randMemeImg })
    }

    render() {
        return (
            <div>
                <form className='meme-form' onSubmit={this.handleSubmit}>
                    <input type='text' name='topText' placeholder='Enter top text'
                        value={
                            this.state.topText
                        }
                        onChange={
                            this.handleChange
                    }></input>
                    <input type='text' name='bottomText' placeholder='Enter bottom text'
                        value={
                            this.state.bottomText
                        }
                        onChange={
                            this.handleChange
                    }></input>

                    <button>Gen</button>

                    <div className='meme'>
                        <img src={
                            this.state.memeImg
                        }></img>
                        <h2 className='top'>
                            {
                            this.state.topText
                        }</h2>
                        <h2 className='bottom'>
                            {
                            this.state.bottomText
                        }</h2>
                    </div>

                </form>
            </div>
        );
    }
}

export default MemeGenerator

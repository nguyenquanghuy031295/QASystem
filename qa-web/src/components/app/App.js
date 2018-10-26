import React, { Component } from 'react';
import { Header } from '../header';
import { Footer } from '../footer';
import './App.css';

class App extends Component {
    render() {
        return (
            <div className="App">
                <div id="header">
                    <Header />
                </div>
                <div id="body">
                </div>
                <div id="footer" className="categories">
                    <Footer />
                </div>
            </div>
        );
    }
}

export default App;

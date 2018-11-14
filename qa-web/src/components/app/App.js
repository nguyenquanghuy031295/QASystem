import React, { Component } from 'react';
import { Header } from '../header';
import { Footer } from '../footer';
import AppRouter from './App.router';
import './App.css';

class App extends Component {
    render() {
        return (
            <div>
                <div className="App">
                    <div id="header">
                        <Header />
                    </div>
                    <AppRouter />
                    <div id="footer" className="categories">
                        <Footer />
                    </div>
                </div>
            </div>
        );
    }
}

export default App;

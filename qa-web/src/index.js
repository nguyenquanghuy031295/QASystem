import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import { App } from './components';
import * as serviceWorker from './serviceWorker';
import { Switch, Route, BrowserRouter } from "react-router-dom";
import { LoginPage } from './components';
ReactDOM.render(
    <BrowserRouter>
        <Switch>
            <Route path="/" exact component={App} />
            <Route path="/login" component={LoginPage} />
        </Switch>
    </BrowserRouter>, document.getElementById('root'));

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: http://bit.ly/CRA-PWA
serviceWorker.unregister();

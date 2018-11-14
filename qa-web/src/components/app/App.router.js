import React from 'react';
import { Route } from 'react-router-dom';
import { HomePage } from '../homepage';
import { UserProfile } from '../userProfile';
const AppRouter = () => {
    return (
        <span>
            <Route exact path="/" component={HomePage} />
            <Route path="/userProfile" component={UserProfile} />
        </span>
    );
};

export default AppRouter;
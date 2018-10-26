import React from 'react';

const Header = () => {
    return (
        <nav id="mainNav" className="navbar navbar-expand-lg navbar-dark" style={{ backgroundColor: "black", marginTop: 0 }}>
            <div className="container">
                <div className="navbar-header">
                    <a className="navbar-brand page-scroll" href="/qasystem">Q & A</a>
                    <form style={{ display: "inline-block" }} role="form" method="POST" action="/qasystem/question/search">
                        <input style={{ display: "inline-block", position: "relative" }} name="keyword" className="form-control" placeholder="Search for questions" />
                        <button style={{ display: "none", marginTop: "10px" }} className="btn btn-primary" type="submit">
                            <span className="glyphicon glyphicon-search" />
                        </button>
                    </form>
                </div>
                <div className="navbar-collapse" id="navbarSupportedContent">
                    <ul className="navbar-nav">
                        <li className="nav-item">
                            <a className="nav-link" id="unansweredHeader" href="/qasystem/question/unanswered">Unanswered</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" id="askHeader" href="/qasystem/question">Ask question</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" id="memberHeader" href="/qasystem/users">User</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" id="tagHeader" href="/qasystem/tag">Tag</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" id="loginHeader" href="/qasystem/login">Login</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" id="logoutHeader" style={{ display: "none" }} href="#">Log out</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav >
    );
};

export default Header;
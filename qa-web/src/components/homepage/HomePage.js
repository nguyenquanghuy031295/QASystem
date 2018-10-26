import React from 'react';

export class HomePage extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <header>
                <div class="container">
                    <div class="row">
                        <div class="col-sm-8">
                            <div class="header-content">
                                <div class="header-content-inner">
                                    <h1>Let us solve your coding problems</h1>
                                    <form role="form" method="POST">
                                        <input name="keyword" required="required" class="form-control" placeholder="Come and find it out" />
                                        <button style={{ marginTop: "10px" }} class="btn btn-primary" type="submit">Search</button>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </header >
        );
    }
}

export default HomePage;
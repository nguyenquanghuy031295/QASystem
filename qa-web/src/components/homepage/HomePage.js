import React from 'react';
import Background from '../../images/background.jpg'
export class HomePage extends React.Component {
    render() {
        var style = {
            backgroundImage: `url(${Background})`,
            height: "785px"
        }
        return (
            <div style={style}>
                <div class="container">
                    <div class="row">
                        <div class="col-sm-8">
                            <div class="header-content">
                                <div class="header-content-inner">
                                    <h1>Let us solve your coding problems</h1>
                                    <form method="POST">
                                        <input name="keyword" required="required" class="form-control" placeholder="Come and find it out" />
                                        <button style={{ marginTop: "10px" }} class="btn btn-primary" type="submit">Search</button>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default HomePage;
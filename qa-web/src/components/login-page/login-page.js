import React from 'react';
import Background from './../../images/bg-01.jpg';
import googleIcon from '../../images/icons/icon-google.png';
import './main.css';
import './util.css';

export class LoginPage extends React.Component {
    render() {
        return (
            <div class="container-login100" style={{ backgroundImage: `url(${Background})` }}>
                <div class="wrap-login100 p-l-110 p-r-110 p-t-62 p-b-33">
                    <form class="login100-form validate-form flex-sb flex-w">
                        <span class="login100-form-title p-b-53">
                            Sign In With
					    </span>

                        <a class="btn-face m-b-20">
                            <i class="fa fa-facebook-official"></i>
                            Facebook
					    </a>

                        <a class="btn-google m-b-20">
                            <img src={googleIcon} alt="GOOGLE" />
                            Googles
					    </a>

                        <div class="p-t-31 p-b-9">
                            <span class="txt1">
                                Username
                            </span>
                        </div>

                        <div class="wrap-input100 validate-input" data-validate="Username is required">
                            <input class="input100" type="text" name="username" />
                            <span class="focus-input100"></span>
                        </div>

                        <div class="p-t-13 p-b-9">
                            <span class="txt1">
                                Password
						    </span>

                            <a class="txt2 bo1 m-l-5">
                                Forgot?
						    </a>
                        </div>

                        <div class="wrap-input100 validate-input" data-validate="Password is required">
                            <input class="input100" type="password" name="pass" />
                            <span class="focus-input100"></span>
                        </div>

                        <div class="container-login100-form-btn m-t-17">
                            <button class="login100-form-btn">
                                Sign In
						    </button>
                        </div>

                        <div class="w-full text-center p-t-55">
                            <span class="txt2">
                                Not a member?
						    </span>

                            <a class="txt2 bo1">
                                Sign up now
						    </a>
                        </div>
                    </form>
                </div>
            </div>
        )
    }
}

export default LoginPage
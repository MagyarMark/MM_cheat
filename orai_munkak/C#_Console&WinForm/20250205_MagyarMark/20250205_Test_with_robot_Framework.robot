*** Settings ***
Library           Selenium2Library

*** Test Cases ***
login_with_valid_credentions_test
    Open Browser    https://www.saucedemo.com    firefox
    Input Text    //*[@id="user-name"]    standard_user
    Input Text    //*[@id="password"]    secret_sauce
    Click Button    //*[@id="login-button"]\n
    Close Browser

login_with_empty_password
    Open Browser    https://www.saucedemo.com    firefox
    Input Text    //*[@id="user-name"]    standard_user
    Input Password    //*[@id="password"]    ${EMPTY}
    Click Button    //*[@id="login-button"]\n
    Element Should Contain    //*[@id="login_button_container"]/div/form/div[3]/h3    Epic sadface: Password is required
    Close Browser

Login_with_empty_Username
    Open Browser    https://www.saucedemo.com    firefox
    Input Text    //*[@id="user-name"]    ${EMPTY}
    Input Password    //*[@id="password"]    secret_sauce
    Click Button    //*[@id="login-button"]\n
    Element Should Contain    //*[@id="login_button_container"]/div/form/div[3]/h3    Epic sadface: Username is required
    Close Browser

*** Settings ***
Library           Selenium2Library

*** Test Cases ***
valid_login
    Open Browser    https://keprendeles.optikart.hu/login/?redirect_to=https%3A%2F%2Fkeprendeles.optikart.hu%2Fpquery%2F    FireFox
    Selenium2Library.Input Text    //*[@id="username-5474"]    butty.mate.laszlo@diak.szbi-pg.hu
    Selenium2Library.Input Text    //*[@id="user_password-5474"]    ASDfgh789
    Selenium2Library.Click Element    //*[@id="um-submit-btn"]
    Selenium2Library.Click Element    //*[@id="ast-desktop-header"]/div/div/div/div/div[3]/div[3]/div/div/a/img
    Element Should Contain    //*[@id="post-99"]/div/div/div/p[1]/strong[1]    ASD ASD
    Close Browser

Login_with_empty_password
    Open Browser    https://keprendeles.optikart.hu/login/?redirect_to=https%3A%2F%2Fkeprendeles.optikart.hu%2Fpquery%2F    FireFox
    Selenium2Library.Input Text    //*[@id="username-5474"]    butty.mate.laszlo@diak.szbi-pg.hu
    Selenium2Library.Input Text    //*[@id="user_password-5474"]    ${EMPTY}
    Selenium2Library.Click Element    //*[@id="um-submit-btn"]
    Element Should Contain    //*[@id="um-error-for-user_password-5474"]    Please enter your password
    Close Browser

Login_with_empty_username
    Open Browser    https://keprendeles.optikart.hu/login/?redirect_to=https%3A%2F%2Fkeprendeles.optikart.hu%2Fpquery%2F    FireFox
    Selenium2Library.Input Text    //*[@id="username-5474"]    ${EMPTY}
    Selenium2Library.Input Text    //*[@id="user_password-5474"]    ASDfgh789
    Selenium2Library.Click Element    //*[@id="um-submit-btn"]
    Element Should Contain    //*[@id="um-error-for-username-5474"]    Please enter your username or email
    Close Browser

Login_with_empty_credentials
    Open Browser    https://keprendeles.optikart.hu/login/?redirect_to=https%3A%2F%2Fkeprendeles.optikart.hu%2Fpquery%2F    FireFox
    Selenium2Library.Input Text    //*[@id="username-5474"]    ${EMPTY}
    Selenium2Library.Input Text    //*[@id="user_password-5474"]    ${EMPTY}
    Selenium2Library.Click Element    //*[@id="um-submit-btn"]
    Element Should Contain    //*[@id="um-error-for-username-5474"]    Please enter your username or email
    Element Should Contain    //*[@id="um-error-for-user_password-5474"]    Please enter your password
    Close Browser

Login_with_wrong_username
    Open Browser    https://keprendeles.optikart.hu/login/?redirect_to=https%3A%2F%2Fkeprendeles.optikart.hu%2Fpquery%2F    FireFox
    Selenium2Library.Input Text    //*[@id="username-5474"]    wrong_user
    Selenium2Library.Input Text    //*[@id="user_password-5474"]    ASDfgh789
    Selenium2Library.Click Element    //*[@id="um-submit-btn"]
    Element Should Contain    //*[@id="um-error-for-user_password-5474"]    Password is incorrect. Please try again.
    Close Browser

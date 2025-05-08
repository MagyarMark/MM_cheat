*** Settings ***
Library           Selenium2Library

*** Test Cases ***
automata_register
    Open Browser    https://www.mikrosat.hu/shop_reg.php?no_reg=0    FireFox
    Maximize Browser Window
    Selenium2Library.Click Element    //*[@id="div_out_email"]/div/div/label
    Selenium2Library.Input Text    //*[@id="emai"]    magyar.mark.jozsef@diak.szbi-pg.hu
    Selenium2Library.Click Element    //*[@id="div_out_passwd"]/div/div/label
    Selenium2Library.Input Text    //*[@id="passwd1"]    ASDfgh789
    Selenium2Library.Click Element    //*[@id="div_out_passwd_again"]/div/div/label
    Selenium2Library.Input Text    //*[@id="passwd2"]    ASDfgh789
    Selenium2Library.Click Element    //*[@id="div_out_company_choose"]/div/div[2]/label
    Selenium2Library.Click Element    //*[@id="newcust_contact"]/div[2]/div/div/div[1]/div[2]/label
    Selenium2Library.Input Text    //*[@id="kap_mobile_sub"]    06209000840
    Selenium2Library.Click Element    //*[@id="newcust_default_mod"]/div[2]/div[1]/div/div/label
    Selenium2Library.Input Text    //*[@id="default_nev"]    Magyar Márk
    Selenium2Library.Click Element    //*[@id="newcust_default_mod"]/div[2]/div[3]/div/div/label
    Selenium2Library.Input Text    //*[@id="default_irany"]    6100
    Selenium2Library.Click Element    //*[@id="newcust_default_mod"]/div[2]/div[4]/div/div/label
    Selenium2Library.Input Text    //*[@id="default_varos"]    Kiskunfélegyháza
    Selenium2Library.Click Element    //*[@id="newcust_default_mod"]/div[2]/div[5]/div/div/label
    Selenium2Library.Input Text    //*[@id="default_utca"]    Kossuth Lajos utca 24.
    Selenium2Library.Click Element    //*[@id="div_out_newsletter"]/div/label
    Wait Until Element Is Visible    //*[@id="button_reg"]    5s
    Scroll Element Into View    //*[@id="button_reg"]
    Wait Until Element Is Enabled    //*[@id="button_reg"]    5s
    Selenium2Library.Click Element    //*[@id="button_reg"]
    Sleep    3s
    Close Browser

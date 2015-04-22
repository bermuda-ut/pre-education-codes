//facebook login
    fblogin();
    if(facebook_status()="AUTHORISED")
    {
        ini_open("android.ini");
        ini_write_real("Settings","usefb",true);
        ini_close();
        global.usefacebook = true;
        }
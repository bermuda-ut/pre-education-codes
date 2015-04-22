if (wave3cleared>=5 && unlocked1==false)//5
{
    menu_unlock(3);
    unlocked1=true;
    global.totalrate = 80;
    unlocknotify(1);
}

if (wave3cleared>=16 && unlocked2==false)//16
{
    //changetofour();
    global.boxslot=4;
    unlocked2=true;
    global.totalrate = 90;
    unlocknotify(2);
}

if (wave4cleared>=5 && unlocked3==false)
{
    menu_unlock(4);
    unlocked3=true;
    unlocknotify(3);
}

if (wave4cleared>=11 && unlocked4==false)
{
    unlocked4=true;
    global.totalrate = 105;
    unlocknotify(4);
}

if (wave4cleared>=17 && unlocked5==false)
{
    unlocked5=true;
    global.totalrate = 120;
    unlocknotify(4);
}
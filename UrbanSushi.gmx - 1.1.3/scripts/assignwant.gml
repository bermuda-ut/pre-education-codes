///assignwant(choca, slot)
randomize();
//var spr;
//var roll;
    
if(argument0 = "milk")
{
    //rollmilk
    /*roll = irandom_range(1,6);
    spr = sprite29_milk1;
    switch(roll)
    {
        case 1: spr = sprite29_milk1; break;
        case 2: spr = sprite30_milk2; break;
        case 3: spr = sprite31_milk3; break;
        case 4: spr = sprite32_milk4; break;
        case 5: spr = sprite33_milk5; break;
    }*/

    switch(argument1)
    {
        case 1: sprite_assign(wantslot1_sprite, salmon);
                global.want[1] = "Milk";
                break;
        case 2: sprite_assign(wantslot2_sprite, salmon);
                global.want[2] = "Milk";
                break;
        case 3: sprite_assign(wantslot3_sprite, salmon);
                global.want[3] = "Milk";
                break;
        case 4: sprite_assign(wantslot4_sprite, salmon);
                global.want[4] = "Milk";
                break;
    }
}

if(argument0 = "white")
{
    //rollmilk
    /*roll = irandom_range(1,6);
    wspr = sprite34_white1;
    switch(roll)
    {
        case 1: wspr = sprite34_white1; break;
        case 2: wspr = sprite35_white2; break;
        case 3: wspr = sprite36_white3; break;
        case 4: wspr = sprite37_white4; break;
        case 5: wspr = sprite38_white5; break;
    }*/

    switch(argument1)
    {
        case 1: sprite_assign(wantslot1_sprite, fish);
                global.want[1] = "White";
                break;
        case 2: sprite_assign(wantslot2_sprite, fish);
                global.want[2] = "White";
                break;
        case 3: sprite_assign(wantslot3_sprite, fish);
                global.want[3] = "White";
                break;
        case 4: sprite_assign(wantslot4_sprite, fish);
                global.want[4] = "White";
                break;
    }
}

if(argument0 = "dark")
{
    //rollmilk
    /*roll = irandom_range(1,6);
    dspr = sprite25_dark1;
    switch(roll)
    {
        case 1: dspr = sprite25_dark1; break;
        case 2: dspr = sprite26_dark2; break;
        case 3: dspr = sprite27_dark3; break;
        case 4: dspr = sprite28_dark4; break;
        case 5: dspr = sprite29_dark5; break;
    }*/

    switch(argument1)
    {
        case 1: sprite_assign(wantslot1_sprite, unagi);
                global.want[1] = "Dark";
                break;
        case 2: sprite_assign(wantslot2_sprite, unagi);
                global.want[2] = "Dark";
                break;
        case 3: sprite_assign(wantslot3_sprite, unagi);
                global.want[3] = "Dark";
                break;
        case 4: sprite_assign(wantslot4_sprite, unagi);
                global.want[4] = "Dark";
                break;
    }
}

if(argument0 = "special")
{
    //rollmilk
    /*roll = irandom_range(1,6);
    dspr = sprite25_dark1;
    switch(roll)
    {
        case 1: dspr = sprite25_dark1; break;
        case 2: dspr = sprite26_dark2; break;
        case 3: dspr = sprite27_dark3; break;
        case 4: dspr = sprite28_dark4; break;
        case 5: dspr = sprite29_dark5; break;
    }*/

    switch(argument1)
    {
        case 1: sprite_assign(wantslot1_sprite, special);
                global.want[1] = "Special";
                break;
        case 2: sprite_assign(wantslot2_sprite, special);
                global.want[2] = "Special";
                break;
        case 3: sprite_assign(wantslot3_sprite, special);
                global.want[3] = "Special";
                break;
        case 4: sprite_assign(wantslot4_sprite, special);
                global.want[4] = "Special";
                break;
    }
}
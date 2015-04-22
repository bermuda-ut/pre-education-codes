///matchwants(slot)

if (global.slot[argument0] != global.want[argument0])
{
    catsys(5);
    clearwants();
    generate_wants();
    
    clearslots();
    
    ref_arrow_pos(1);
    global.currentslot = 1;
    
    unepic();
    
    global.combo = 0;
    global.time=100;
    global.life-=15;
    
    audio_play_sound(barrel_break_3, 1, false)
}
else if(global.boxslot = 3 && argument0 = 3)
{
    catsys(1);
    
    //score +=100;
    addscore();
    
    global.wave3cleared++;
    audio_play_sound(coin_get, 1, false)
    
    checkforunlocks();
    //boxslot=4
    
    clearwants();
    generate_wants();
    clearslots();
    
    global.time=100;
    ref_arrow_pos(1);
    global.currentslot = 1;
    
    /*if(global.combo > global.instancemaxcombo)
{
    global.instancemaxcombo = global.combo;
}*/

}
else if(global.boxslot = 4 && argument0 = 4)
{
    global.life+=3;
    
    catsys(1);
    //score +=150;
    addscore();
    global.wave4cleared++;
    audio_play_sound(coin_get, 1, false)
    
    checkforunlocks();
    
    clearwants();
    generate_wants();
    clearslots();
    
    global.time=100;
    ref_arrow_pos(1);
    global.currentslot = 1;
    
    /*if(global.combo > global.instancemaxcombo)
{
    global.instancemaxcombo = global.combo;
}*/
    
}

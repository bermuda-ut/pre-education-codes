if(global.vibrate==true) immersion_play_effect(2);
ref_arrow_pos(1);
with(shakecam_placer) { 
global.life+=10;
if(global.life > 100) global.life = 100;

var todo = combo_check();
if (todo = 1)
{
    if(global.shake==true) path_start(mediumshake,20,0,false); 
    x=1344/2;
    y=800/2;
    alarm[3]=10;
}

}
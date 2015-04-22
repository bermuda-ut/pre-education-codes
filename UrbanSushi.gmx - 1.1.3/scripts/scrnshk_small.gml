if(global.vibrate==true) immersion_play_effect(2);

global.currentslot++;
ref_arrow_pos(global.currentslot);

with(shakecam_placer) { 
global.life++;
if(global.life > 100) global.life = 100;

var todo = combo_check();
if (todo = 1)
{
    if(global.shake==true) path_start(smallshake,20,0,false); 
    x=1344/2;
    y=800/2;
    alarm[3]=10;
}

}
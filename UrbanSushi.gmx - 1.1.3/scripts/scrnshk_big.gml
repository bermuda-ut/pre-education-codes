if(global.vibrate==true) immersion_play_effect(3);
with(shakecam_placer) { 
global.life+=5;
var todo = combo_check();
if (todo = 1)
{
    if(global.shake==true) path_start(bigshake,20,0,false);
    x=1344/2;
    y=800/2;
    alarm[3]=10;
}

}
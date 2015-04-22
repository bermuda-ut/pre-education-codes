///selected(item)
heartbeat();
combotwitch();
audio_play_sound(btn121, 1, false)
if(global.boxslot==3)
{
    switch(global.currentslot)
    {
        case 1:
            global.slot[1] = argument0;
            
            if(global.slot[1] = global.want[1])
            {
                with(wantslot1){image_alpha = 1};
                scrnshk_small();
                catsys(0);
                create_particle(global.want[1],1);
            }
            matchwants(1);
            break;
            
        case 2:
            global.slot[2] = argument0;

            if(global.slot[2] = global.want[2])
            {
                with(wantslot2){image_alpha = 1};
                scrnshk_small();
                catsys(0);
                create_particle(global.want[2],2);
            }
            
            matchwants(2);
            break;
            
        case 3:
            global.slot[3] = argument0;
   
            if(global.slot[3] = global.want[3])
            {
                with(wantslot3){image_alpha = 1};
                scrnshk_med();
                catsys(0);
                create_particle(global.want[3],3);
            }     
               
            matchwants(3); 
            break;
    }
}
else
{
    switch(global.currentslot)
    {
        case 1:
            global.slot[1] = argument0;
            
            if(global.slot[1] = global.want[1])
            {
                with(wantslot1){image_alpha = 1};
                scrnshk_small();
                catsys(0);
                create_particle(global.want[1],1);
            }
            matchwants(1);
            break;

        case 2:
            global.slot[2] = argument0;

            if(global.slot[2] = global.want[2])
            {
                with(wantslot2){image_alpha = 1};
                scrnshk_small();
                catsys(0);
                create_particle(global.want[2],2);
            }
            matchwants(2);
            break;
            
        case 3:
            global.slot[3] = argument0;


            if(global.slot[3] = global.want[3])
            {
                with(wantslot3){image_alpha = 1};
                scrnshk_small();
                catsys(0);
                create_particle(global.want[3],3);
            }
            matchwants(3);
            break;
            
        case 4:
            global.slot[4] = argument0;

            if(global.slot[4] = global.want[4])
            {
                with(wantslot4){image_alpha = 1};
                scrnshk_med();
                catsys(0);
                create_particle(global.want[4],4);
            }
            matchwants(4); 
            break;
    }
}
image_index = 1;
alarm[3] = 3;

if(global.combo > global.instancemaxcombo)
{
    global.instancemaxcombo = global.combo;
}
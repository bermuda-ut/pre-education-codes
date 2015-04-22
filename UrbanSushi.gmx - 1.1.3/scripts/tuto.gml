///tuto(phase)
switch(argument0)
{
    case 0 : with(tuto_message){instance_destroy();};
             sprite_assign(tuto_speech, c2);
             break;
             
    case 1 : sprite_assign(tuto_speech, c3);
             break;
             
    case 2 : sprite_assign(tuto_speech, c4);
             break;
             
    case 4 : sprite_assign(tuto_speech, c5);
             break;
             
    case 5 : sprite_assign(tuto_speech, c6);
             break;
             
    case 6 : sprite_assign(tuto_speech, c7);
             sprite_assign(tuto_shadow, s2);
             break;
             
    case 7 : sprite_assign(tuto_speech, c8);
             break;
             
    case 8 : sprite_assign(tuto_speech, c9);
             sprite_assign(tuto_shadow, s3);
             instance_create(tutoshadow.x,tutoshadow.y,tutoshadow2);
             with(tutoshadow){instance_destroy();}
             global.tutomenu = 1;
             break;
             
    case 9 : sprite_assign(tuto_speech, c10);
             sprite_assign(tuto_shadow, s1);
             break;

    case 10: sprite_assign(tuto_speech, c11);
             catsys(5);
             sprite_assign(tuto_shadow, s6);
             break;
             
    case 11: sprite_assign(tuto_speech, blanksprite);
             sprite_assign(tuto_shadow, s7);
             sprite_assign(tuto_speech2, c12);
             break;
             
    case 12: sprite_assign(tuto_speech2, c13);
             break;
             
    case 13: sprite_assign(tuto_speech2, c14);
             break;

    case 14: sprite_assign(tuto_speech2, c15);
             sprite_assign(tuto_shadow, s8);
             break;
             
    case 15: sprite_assign(tuto_speech2, c16);
             break;
             
    case 16: sprite_assign(tuto_speech2, c17);
             break;
             
    case 17: sprite_assign(tuto_speech2, c18);
             break;
             
    case 18: sprite_assign(tuto_speech2, c19);
             break;
             
    case 19: sprite_assign(tuto_speech2, c20);
             break;
             
    case 20: sprite_assign(tuto_speech, c21);
             sprite_assign(tuto_speech2, blanksprite);
             sprite_assign(tuto_shadow, s9);
             break;
             
    case 21: sprite_assign(tuto_speech, c22);
             sprite_assign(tuto_shadow, s1);
             break;
             
    case 22: sprite_assign(tuto_speech, c23);
             break;
             
    case 23: ini_open("android.ini");
             ini_write_real("Settings","tutocomp",true);
             ini_close();
             
             global.tutocomp = true;
             audio_stop_all();
             doorsclose();
             with(tutospeech){alarm[0]=30};
             
             if achievement_available() achievement_post("CgkItNmFt-AcEAIQEw", 100);
             
             break;
}

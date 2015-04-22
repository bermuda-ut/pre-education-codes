// Clean Menu

with(preay){path_start(topmenu_move,35,0,false)};
with(optiondesu){path_start(topmenu_move,35,0,false)};
with(quitdesu){path_start(topmenu_move,35,0,false);alarm[0]=60};
with(credits_desu){path_start(topmenu_move,35,0,false);alarm[0]=60};

with(topscore){path_start(topmenu_move,35,0,false)};
with(drawtopscore){path_start(topmenu_move,35,0,false)};

with(ShareFB){instance_destroy()};
with(twitter){instance_destroy()};
with(ldr){instance_destroy()};
with(ach){instance_destroy()};

with(title1){image_alpha = 0};
with(title2){image_alpha = 0};
with(title3){image_alpha = 0};
with(title4){image_alpha = 0};
with(title5){image_alpha = 0};

with(title_follow){path_start(menucammove,20,0,false); alarm[0]=90; alarm[1]=60};

audio_sound_gain(sushaemain_title, 0, 1000);

audio_sound_gain(phase1, 0.55*global.bgmvolume, 1000);
audio_sound_gain(phase3, 0.65*global.bgmvolume, 1000);
audio_sound_gain(phase2, 0.45*global.bgmvolume, 1000);
audio_sound_gain(techno_loop, 0.4*global.bgmvolume, 1000);
audio_sound_gain(btn121, 0.8*global.fxvolume, 1000);
audio_sound_gain(click, global.fxvolume, 1000);
audio_sound_gain(pushbuttonon, 0.6*global.fxvolume, 1000);
audio_sound_gain(barrel_break_3, 0.55*global.fxvolume, 1000);
//audio_sound_gain(pop, global.fxvolume, 1000);
audio_sound_gain(coin_get, 0.1*global.fxvolume, 1000);
audio_sound_gain(game_over, 0.6*global.fxvolume, 1000);
audio_sound_gain(scratch, 0.2*global.fxvolume, 1);
audio_sound_gain(smallsnare, 0.2*global.fxvolume, 1);
audio_sound_gain(bigsnare, 0.35*global.fxvolume, 1);

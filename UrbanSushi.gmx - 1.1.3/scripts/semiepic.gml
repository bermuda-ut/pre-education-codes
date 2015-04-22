background_assign(oribg, sushibg2)
global.timeforsemi = true;
with(skybg){speed=30};
global.bpm = 60;
global.fevermode = true;
catsys(3);

audio_stop_all();
//audio_sound_pitch(phase1, 0.7);
audio_play_sound(scratch,10,false);
audio_play_sound(phase2,10,true);
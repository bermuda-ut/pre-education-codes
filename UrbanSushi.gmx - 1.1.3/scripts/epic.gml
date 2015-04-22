background_assign(oribg, sushibg3);
global.timeforepic = true;
global.timeforsemi = true;
with(skybg){speed=60};
global.bpm = 30;
global.fevermode = true;
catsys(3);

audio_stop_all();
//audio_sound_pitch(phase1, 0.7);
audio_play_sound(scratch,10,false);
audio_play_sound(phase3,10,true);
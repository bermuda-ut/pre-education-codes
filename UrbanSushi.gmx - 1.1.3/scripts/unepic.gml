background_assign(oribg, sushibg1)
global.timeforepic = false;
global.timeforsemi = false;
with(skybg){speed=1};
global.fevermode = false;
catsys(5);

//audio_sound_pitch(phase1, 0.7);
if(audio_is_playing(phase1) = false)
{
audio_stop_all();
audio_play_sound(scratch,10,false);
audio_sound_gain(phase1, 0.4*global.bgmvolume, 1000);
audio_play_sound(phase1,10,true);
}
instance_deactivate_all(0);
doorsclose();
instance_create(672,-20,option_bg);
instance_create(0,0,option_title);
instance_create(0,0,option_stuff);
instance_create(672,400,option_ok);

instance_create(1000,230,chckbox_vibration);
instance_create(1000,300,chckbox_shake);
instance_create(1000,370,chckbox_usefb);
instance_create(600,370,chckbox_glgplay);
instance_create(1000,440,chckbox_tuto);//re-tuto

instance_create(950,510,bgm_dec);
instance_create(1060,510,bgm_inc);

instance_create(950,580,fx_dec);//fxvolume
instance_create(1060,580,fx_inc);//fxvolume

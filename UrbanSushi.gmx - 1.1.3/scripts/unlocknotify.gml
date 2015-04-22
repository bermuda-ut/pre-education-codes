///unlocknotify(item)

switch(argument0)
{
    case 1 : sprite_assign(powerup_spr, funlocked); break;
    case 2 : sprite_assign(powerup_spr, unlocked44); break;
    case 3 : sprite_assign(powerup_spr, uunlocked); break;
    case 4 : sprite_assign(powerup_spr, speedup); break;
}

with(powerup){path_start(unlock_path,15,0,false);alarm[0]=180};
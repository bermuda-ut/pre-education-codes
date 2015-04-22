///catsys(expression)

switch(argument0)
{
    case 0 : 
    if(global.fevermode=false)
    {
    sprite_assign(cat_spr, catsmile);
    //with(cat){alarm[0]=30};
    }
    else
    {
    sprite_assign(cat_spr, catsmilef);
    //with(cat){alarm[1]=30};
    }
    break;
    
    case 1 :
    if(global.fevermode=false)
    {
    sprite_assign(cat_spr, catyay);
    //with(cat){alarm[0]=30};
    }
    else
    {
    sprite_assign(cat_spr, catyayf);
    //with(cat){alarm[1]=30};
    }
    break;
    
    case 2 : sprite_assign(cat_spr, catnormalf); break;
    case 3 : sprite_assign(cat_spr, catsmilef); with(cat){alarm[1]=30}; break;
    
    case 4 : sprite_assign(cat_spr, catyayf); with(cat){alarm[1]=30}; break;
    case 5 : sprite_assign(cat_spr, catnormal); break;
}
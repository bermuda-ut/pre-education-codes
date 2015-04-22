///menu_unlock(menu_number)

switch (argument0)
{
    case 3: global.unlocked = 3;
            instance_create(menu2.x, menu2.y, White2)
            with(menu2){instance_destroy();}
            break;
    case 4: global.unlocked = 4; 
            instance_create(menu3.x, menu3.y, Dark2)
            with(menu3){instance_destroy();}
            break;
}
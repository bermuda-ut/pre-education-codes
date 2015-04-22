///ref_arrow_pos(position)
//refresh arrow position
switch(argument0)
{
    case 1: with(arrow_obj){instance_destroy()};
            instance_create(wantslot1.x, wantslot1.y-106, arrow_obj)
            break;
    case 2: with(arrow_obj){instance_destroy()};
            instance_create(wantslot2.x, wantslot2.y-106, arrow_obj)
            break;
    case 3: with(arrow_obj){instance_destroy()};
            instance_create(wantslot3.x, wantslot3.y-106, arrow_obj)
            break;
    case 4: with(arrow_obj){instance_destroy()};
            instance_create(wantslot4.x, wantslot4.y-106, arrow_obj)
            break;
}
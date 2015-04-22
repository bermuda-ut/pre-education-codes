///create_particle(type, slot)

switch(argument1)
{
    case 1 : switch(argument0)
             {
                case "Milk" : repeat(5){instance_create(wantslot1.x,wantslot1.y,particle_salmon)} break;
                case "White" : repeat(5){instance_create(wantslot1.x,wantslot1.y,particle_fish)} break;
                case "Dark" : repeat(5){instance_create(wantslot1.x,wantslot1.y,particle_unagi)} break;
                case "Special" : repeat(5){instance_create(wantslot1.x,wantslot1.y,particle_special)} break;
             }
             break;
             
    case 2 : switch(argument0)
             {
                case "Milk" : repeat(5){instance_create(wantslot2.x,wantslot2.y,particle_salmon)} break;
                case "White" : repeat(5){instance_create(wantslot2.x,wantslot2.y,particle_fish)} break;
                case "Dark" : repeat(5){instance_create(wantslot2.x,wantslot2.y,particle_unagi)} break;
                case "Special" : repeat(5){instance_create(wantslot2.x,wantslot2.y,particle_special)} break;
             }
             break;
             
    case 3 : switch(argument0)
             {
                case "Milk" : repeat(5){instance_create(wantslot3.x,wantslot3.y,particle_salmon)} break;
                case "White" : repeat(5){instance_create(wantslot3.x,wantslot3.y,particle_fish)} break;
                case "Dark" : repeat(5){instance_create(wantslot3.x,wantslot3.y,particle_unagi)} break;
                case "Special" : repeat(5){instance_create(wantslot3.x,wantslot3.y,particle_special)} break;
             }
             break;
             
    case 4 : switch(argument0)
             {
                case "Milk" : repeat(5){instance_create(wantslot4.x,wantslot4.y,particle_salmon)} break;
                case "White" : repeat(5){instance_create(wantslot4.x,wantslot4.y,particle_fish)} break;
                case "Dark" : repeat(5){instance_create(wantslot4.x,wantslot4.y,particle_unagi)} break;
                case "Special" : repeat(5){instance_create(wantslot4.x,wantslot4.y,particle_special)} break;
             }
             break;
}
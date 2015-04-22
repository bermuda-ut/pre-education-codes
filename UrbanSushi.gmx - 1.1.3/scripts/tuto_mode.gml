//tuto_mode
menu_unlock(3);
menu_unlock(4);

instance_create(Milk.x, Milk.y, tuto_menu1)
with(Milk){instance_destroy();}
instance_create(White2.x, White2.y, tuto_menu2)
with(White2){instance_destroy();}
instance_create(Dark2.x, Dark2.y, tuto_menu3)
with(Dark2){instance_destroy();}
instance_create(Special2.x, Special2.y, tuto_menu4)
with(Special2){instance_destroy();}

assignwant("milk",1);
assignwant("special",2);
assignwant("white",3);

instance_create(0,0,tuto_message);
with(pausebtn){instance_destroy();};

global.tutophase = 0;
global.tutomenu = 0;
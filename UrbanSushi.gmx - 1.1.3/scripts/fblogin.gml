//facebook login
facebook_init();
instance_create(672,400, logingbg);

var permissions = ds_list_create();
ds_list_add(permissions,"public_profile");

facebook_login(permissions,fb_login_default);
ds_list_destroy(permissions);

//loadad-initial only

//initalize ads
GoogleMobileAds_Init("ca-app-pub-5503917585559307/7948839278");
AdColony_Init("app76d56d4782aa4594b6", "vz9b048f1c5fd94b4bbe", "");
//GoogleMobileAds_Init("ca-app-pub-5503917585559307/9425572479"); //insert
//GoogleMobileAds_LoadInterstitial();
//global.interLoaded = false;
//global.interLoading = true;
//global.triedtoload = true;

//usetestads
//GoogleMobileAds_UseTestAds(1,"E8E7639CD1714954C312BDB16A980EE8");


//ads_enable(0,0,0);
//ads_move(display_get_gui_width() - ads_get_display_width(0), 0, 0);
//global.bannerexsists = true;
//global.adseen=2;
GoogleMobileAds_AddBannerAt("ca-app-pub-5503917585559307/7948839278", GoogleMobileAds_Banner, 0, 630);
GoogleMobileAds_MoveBanner(0, display_get_height()-GoogleMobileAds_BannerGetHeight());

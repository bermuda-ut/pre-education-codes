//
//  Released by YoYo Games Ltd. on 17/04/2014. Intended for use with GM: S EA97 and above ONLY.
//  Copyright YoYo Games Ltd., 2014.
//  For support please submit a ticket at help.yoyogames.com
//
//


package ${YYAndroidPackageName};



import ${YYAndroidPackageName}.RunnerActivity;
import com.yoyogames.runner.RunnerJNILib;
import com.jirbo.adcolony.*;
import android.util.Log;
import com.yoyogames.runner.RunnerJNILib;

public class AdColonyExt implements AdColonyAdListener, AdColonyAdAvailabilityListener,AdColonyV4VCListener
{
	AdColonyV4VCAd v4vc_ad;
	int EVENT_OTHER_SOCIAL = 70;
	
	public void AdColony_Init(String _app_id,String zone_id,String c)
	{
		final String app_id = _app_id;
		final String [] Zones = new String[2];
		Zones[0] = zone_id;
		Zones[1] = c;
	//og.i("yoyo","Initialising AdColony with activity "+RunnerActivity.CurrentActivity);
	RunnerActivity.ViewHandler.post( new Runnable() {
			public void run() {
			AdColony.configure(RunnerActivity.CurrentActivity,"version:1.0,store:google",app_id,Zones);
			AdColony.addAdAvailabilityListener( AdColonyExt.this );
			AdColony.addV4VCListener( AdColonyExt.this );
		 }
		 });
	}
	
	public void AdColony_ShowVideo(String _a)
	{
		final String a = _a;
		Log.i("yoyo","Show Video with key "+a);
		
		RunnerActivity.ViewHandler.post( new Runnable() {
			public void run() {
				AdColonyVideoAd ad = new AdColonyVideoAd( a ).withListener(AdColonyExt.this );
				ad.show();
			}
		});
		
		
	}
	
	public void AdColony_ShowVideoForV4VC(String _a)
	{
		final String a = _a;
		Log.i("yoyo","Show Video for V4VC for key "+a);
		RunnerActivity.ViewHandler.post( new Runnable() {
			public void run() {
				v4vc_ad = new AdColonyV4VCAd( a ).withListener( AdColonyExt.this ).withConfirmationDialog().withResultsDialog();
				v4vc_ad.show();
			}
		});
	}
	
	private void sendAdStartedEvent()
	{
		int dsMapIndex = RunnerJNILib.jCreateDsMap(null, null, null);
		RunnerJNILib.DsMapAddString( dsMapIndex, "type", "adcolony_started" );
		RunnerJNILib.CreateAsynEventWithDSMap(dsMapIndex,EVENT_OTHER_SOCIAL);
	}
	
	private void sendAdFinishedEvent(boolean bShown)
	{
		int dsMapIndex = RunnerJNILib.jCreateDsMap(null, null, null);
		RunnerJNILib.DsMapAddString( dsMapIndex, "type", "adcolony_finished" );
		double shown = (bShown) ? 1 : 0;
		RunnerJNILib.DsMapAddDouble(dsMapIndex,"shown",shown);
		RunnerJNILib.CreateAsynEventWithDSMap(dsMapIndex,EVENT_OTHER_SOCIAL);
	}
	
	 //Ad Started Callback - called only when an ad successfully starts playing
	  public void onAdColonyAdStarted( AdColonyAd ad )
	  {
		Log.i("yoyo", "onAdColonyAdStarted");
		sendAdStartedEvent();
	  }

	  //Ad Attempt Finished Callback - called at the end of any ad attempt - successful or not.
	  public void onAdColonyAdAttemptFinished( AdColonyAd ad )
	  {
		// You can ping the AdColonyAd object here for more information:
		// ad.shown() - returns true if the ad was successfully shown.
		// ad.notShown() - returns true if the ad was not shown at all (i.e. if onAdColonyAdStarted was never triggered)
		// ad.skipped() - returns true if the ad was skipped due to an interval play setting
		// ad.canceled() - returns true if the ad was cancelled (either programmatically or by the user)
		// ad.noFill() - returns true if the ad was not shown due to no ad fill.
		Log.i("yoyo", "onAdColonyAdAttemptFinished");
		sendAdFinishedEvent( ad.shown() );
	  }
	
	  
	public void onAdColonyV4VCReward( AdColonyV4VCReward reward )
	{
		if (reward.success())
		{
		  //string vc_name = reward.name();
			Log.i("yoyo","Awarding " +reward.amount() + " of " + reward.name()); 
		  

			int dsmapindex = RunnerJNILib.jCreateDsMap(null,null,null);
			
		
			RunnerJNILib.DsMapAddString(dsmapindex,"type","adcolony_reward" );
			RunnerJNILib.DsMapAddString(dsmapindex,"currname", reward.name());
			RunnerJNILib.DsMapAddDouble(dsmapindex,"curramount",reward.amount());
			
			RunnerJNILib.CreateAsynEventWithDSMap(dsmapindex,EVENT_OTHER_SOCIAL);
		}
		else
		{
			Log.i("yoyo","onAdColonyV4VCReward called but without reward success");
		}
	}
  
 
  

  // Ad Availability Change Callback - update button text
  public void onAdColonyAdAvailabilityChange(boolean available, String zone_id) 
  {
	Log.i("yoyo","onAdColonyAdAvailabilityChange " + available + " in zone " + zone_id);
	//if (available) button_text_handler.post(button_text_runnable);
  }
	
}



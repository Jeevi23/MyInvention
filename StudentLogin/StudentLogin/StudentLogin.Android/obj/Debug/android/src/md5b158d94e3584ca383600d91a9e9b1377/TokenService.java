package md5b158d94e3584ca383600d91a9e9b1377;


public class TokenService
	extends com.microsoft.appcenter.push.TokenService
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Microsoft.AppCenter.Push.TokenService, Microsoft.AppCenter.Push.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", TokenService.class, __md_methods);
	}


	public TokenService ()
	{
		super ();
		if (getClass () == TokenService.class)
			mono.android.TypeManager.Activate ("Microsoft.AppCenter.Push.TokenService, Microsoft.AppCenter.Push.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

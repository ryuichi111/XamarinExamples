package md57f63aa049cbb756e6d25b078a3df0746;


public class CustomAutoCompleteAdapter
	extends com.syncfusion.autocomplete.AutoCompleteAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getView:(Lcom/syncfusion/autocomplete/SfAutoComplete;Ljava/lang/String;I)Landroid/view/View;:GetGetView_Lcom_syncfusion_autocomplete_SfAutoComplete_Ljava_lang_String_IHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfAutoComplete.XForms.Droid.CustomAutoCompleteAdapter, Syncfusion.SfAutoComplete.XForms.Android, Version=15.1451.0.33, Culture=neutral, PublicKeyToken=null", CustomAutoCompleteAdapter.class, __md_methods);
	}


	public CustomAutoCompleteAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CustomAutoCompleteAdapter.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfAutoComplete.XForms.Droid.CustomAutoCompleteAdapter, Syncfusion.SfAutoComplete.XForms.Android, Version=15.1451.0.33, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View getView (com.syncfusion.autocomplete.SfAutoComplete p0, java.lang.String p1, int p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (com.syncfusion.autocomplete.SfAutoComplete p0, java.lang.String p1, int p2);

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

package mono.com.syncfusion.autocomplete;


public class SfAutoComplete_SelectionChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.autocomplete.SfAutoComplete.SelectionChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_ItemChanged:(Ljava/lang/Object;Ljava/lang/String;)V:GetItemChanged_Ljava_lang_Object_Ljava_lang_String_Handler:Com.Syncfusion.Autocomplete.SfAutoComplete/ISelectionChangedListenerInvoker, Syncfusion.SfAutoComplete.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Autocomplete.SfAutoComplete+ISelectionChangedListenerImplementor, Syncfusion.SfAutoComplete.Android, Version=15.1451.0.33, Culture=neutral, PublicKeyToken=null", SfAutoComplete_SelectionChangedListenerImplementor.class, __md_methods);
	}


	public SfAutoComplete_SelectionChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfAutoComplete_SelectionChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Autocomplete.SfAutoComplete+ISelectionChangedListenerImplementor, Syncfusion.SfAutoComplete.Android, Version=15.1451.0.33, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void ItemChanged (java.lang.Object p0, java.lang.String p1)
	{
		n_ItemChanged (p0, p1);
	}

	private native void n_ItemChanged (java.lang.Object p0, java.lang.String p1);

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

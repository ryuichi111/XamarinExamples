package mono.com.syncfusion.autocomplete;


public class SfAutoComplete_TextChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.autocomplete.SfAutoComplete.TextChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_TextChanged:(Ljava/lang/Object;Ljava/lang/String;)V:GetTextChanged_Ljava_lang_Object_Ljava_lang_String_Handler:Com.Syncfusion.Autocomplete.SfAutoComplete/ITextChangedListenerInvoker, Syncfusion.SfAutoComplete.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Autocomplete.SfAutoComplete+ITextChangedListenerImplementor, Syncfusion.SfAutoComplete.Android, Version=15.1451.0.33, Culture=neutral, PublicKeyToken=null", SfAutoComplete_TextChangedListenerImplementor.class, __md_methods);
	}


	public SfAutoComplete_TextChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfAutoComplete_TextChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Autocomplete.SfAutoComplete+ITextChangedListenerImplementor, Syncfusion.SfAutoComplete.Android, Version=15.1451.0.33, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void TextChanged (java.lang.Object p0, java.lang.String p1)
	{
		n_TextChanged (p0, p1);
	}

	private native void n_TextChanged (java.lang.Object p0, java.lang.String p1);

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

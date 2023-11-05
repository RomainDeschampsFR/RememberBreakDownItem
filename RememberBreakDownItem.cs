using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;

namespace RememberBreakDownItem
{
	public class RememberBreakDownItem : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
        }
    }
}
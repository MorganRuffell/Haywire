//////////////////////////////////////////////////////////////////////////
////    Haywire (c) Team 2 - Games Production, UCA
////	Programmer: Morgan Ruffell
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISoundSystem 
{

	public void PlayGameSounds(List<AudioSource> SoundList);

	public void StopGameSounds(List<AudioSource> SoundList);
	
}

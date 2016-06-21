﻿using UnityEngine;
using System.Collections;

public class Elevator_move : StateMachineBehaviour {

	private Transform _plate = null;
	private Transform _collider = null;
	private AudioSource _audio_src = null;

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if (_plate == null) { _plate = animator.transform.parent.Find("Plate"); }
		if (_collider == null) { _collider = animator.transform.parent.Find ("E_Collider"); }
		if (_audio_src == null) { _audio_src = animator.transform.parent.Find ("Elevator_sound").GetComponent<AudioSource>(); }
		if (_audio_src != null) {
			_audio_src.Play ();
		}
	}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if ((_plate != null)&&(_collider != null)) {
			Vector3 _pos = _plate.localPosition;
			_collider.gameObject.SetActive(_pos.y > 1);
		}
	}


}
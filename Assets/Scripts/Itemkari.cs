using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Itemkari : MonoBehaviour
{
	public AudioSource audioSource;
	public AudioClip soundgauge;
	public Material ItemMaterial;
	public Texture KokeOnItemTex;
	public Texture KokeOFFItemTex;
	public ParticleSystem nparticle;
	public ParticleSystem particle;
	float a;
	private void Start()
    {
		ItemMaterial.SetTexture("_MainTex", KokeOnItemTex);
		ItemMaterial.SetVector("_EmissionColor", new Vector4(0.2f, 0.5f, 0.1f) * 1.5f);
	}
    void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.name);
		if (other.name == "Snali")
		{
			a += 1;
            if(a == 1)
            {
				ItemMaterial.SetTexture("_MainTex", KokeOFFItemTex);    //�e�N�X�`���؂�ւ�
				ItemMaterial.SetVector("_EmissionColor", new Vector4(0.2f, 0.5f, 0.1f) * 0.0f);
				audioSource.PlayOneShot(soundgauge);
				particle.Play();
				nparticle.Stop();

				GameObject scoreTextGo = GameObject.Find("ScoreText");  //�X�R�A�̃Q�[���I�u�W�F�N�g���擾����
				scoreTextGo.SendMessage("OnScore", 1);
			}
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public float score;
    public Color color;
    private Color colorChange;

    public AudioManager audioManager;
    public ScoreManager scoreManager;
    public VFXManager vfxManager;

    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        renderer.material.color = color;
        colorChange = Color.red;
        
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //Animasi
            animator.SetTrigger("Hit");

            //playsfx
            audioManager.PlaySFX(collision.transform.position);

            //playvfx
            vfxManager.PlayVFX(collision.transform.position);

            //score add
            scoreManager.AddScore(score);

            //warna berubah jika hit
            StartCoroutine(ChangeColor());
            

        }
    }

    private IEnumerator ChangeColor()
    {
        while (renderer.material.color != colorChange)
        {
            //berubah menjadi warna merah secara perlahan
            renderer.material.color = Color.Lerp(renderer.material.color, colorChange, 0.4f);
            yield return new WaitForEndOfFrame();
        }

        while (renderer.material.color != color)
        {
            //berubah menjadi warna semula secara perlahan
            renderer.material.color = Color.Lerp(renderer.material.color, color, 0.4f);
            yield return new WaitForEndOfFrame();
        }

    }
}

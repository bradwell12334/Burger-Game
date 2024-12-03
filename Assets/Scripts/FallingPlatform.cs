using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class FallingPlatform : MonoBehaviour
{
    private float fallDelay = 1f;
    private float destroyDelay = 2f;


    [SerializeField] private Rigidbody2D rb;



    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        yield return new WaitForSeconds(destroyDelay);
        yield return new WaitForSeconds(fallDelay);
        yield return new WaitForSeconds(destroyDelay);
        yield return new WaitForSeconds(fallDelay);
        Destroy(gameObject, destroyDelay);
        destroyDelay = 0f;
    }


}

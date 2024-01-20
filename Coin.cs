using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerCoin.CoinCount++;
        Destroy(this.gameObject);
    }


}

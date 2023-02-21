using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BatteryCollector : MonoBehaviour
{


    private void Update()
    {
        transform.Rotate(0, 0, 20 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            PlayerManager.CoinNum += 1;
            Debug.Log("coins:" + PlayerManager.CoinNum);
            Destroy(gameObject);
        }
    }
    //public float respawnTime = 5f;
    //private Vector3 initialPosition;
    //public int batteryCount = 0;
    //[SerializeField] TextMeshProUGUI battCountText;

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("player"))
    //    {

    //        batteryCount++;
    //        UpdateBattCount();
    //        StartCoroutine(RespawnCoin());
    //    }
    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("yew");
    //        batteryCount++;
    //        UpdateBattCount();
    //        StartCoroutine(RespawnCoin());
    //    }
    //}
    //private IEnumerator RespawnCoin()
    //{
    //    // Remove the coin from the scene.
    //    gameObject.SetActive(false);

    //    // Wait for the respawn time.
    //    yield return new WaitForSeconds(respawnTime);

    //    // Respawn the coin at its initial position.
    //    transform.position = initialPosition;
    //    gameObject.SetActive(true);
    //}
    //private void UpdateBattCount()
    //{
    //    // Update the text to display the current coin count.
    //    battCountText.text = "Batteries: " + batteryCount.ToString();
    //}
}

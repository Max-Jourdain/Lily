using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class PlayModeTestGame
{
    bool clicked = false;

    [SetUp]
    public void SetUp()
    {     
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gym");
    }

    [UnityTest]
    public IEnumerator TestMenu()
    {
        var gameObject = new GameObject();
        string name = "Canvas";
        GameObject startButton = GameObject.Find(name);
        Assert.NotNull(startButton);
        var setupButton = startButton.GetComponentInChildren<Button>();
        setupButton.onClick.AddListener(Clicked);
        setupButton.onClick.Invoke();
        Assert.IsTrue(clicked);
        yield return new WaitForSeconds(2);
    }
    
    private void Clicked()
    {
        clicked = true;
    }
}

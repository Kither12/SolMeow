using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class query{
    public int minLevel;
    public List<QueryType> queries;
}
public class CustomerManager : MonoBehaviour
{
    public List<query> queryPerLevel;
    public List<Customer> preCustomer;
    public GameObject customer_prefabs;
    public Transform customerList;
    public int numPreorderCustomer;
    private string[] customerName = {
        "Mariah",
        "Evelyn",
        "Mylee",
        "Mara",
        "Emilee",
        "Marina",
        "Akira",
        "Dixie",
        "Carly",
        "Krystal",
        "Patience",
        "Azaria",
        "Scarlett",
        "Lola",
        "Vivian",
        "Kara",
        "Skyla",
        "Sydney",
        "Reina",
        "Mckenzi",
        "Nina",
        "Amaya",
        "Janiyah",
        "Tamia",
        "Kamari",
        "Tabitha",
        "Lillianna",
        "Sherlyn",
        "Juliet",
        "Arielle",
        "Diamond",
        "Gracie",
        "Margaret",
        "Kamora",
        "Angeliqu",
        "Mckayla",
        "Rylie",
        "Peyton",
        "Angela",
        "Mallory",
        "Karlee",
        "Deja",
        "Luna",
        "Bella",
        "Gianna",
        "Charlotte",
        "Haleigh",
        "Monique",
        "Alejandra",
        "Amira",
    };
    private void Start() {
        GetPreCustomer();
    }
    public void GetPreCustomer(){
        for(int i = 0; i < numPreorderCustomer; ++i){
            GameObject customer = Instantiate(customer_prefabs, customerList);
            preCustomer.Add(customer.AddComponent<Customer>());
            CustomerData data = ScriptableObject.CreateInstance("CustomerData") as CustomerData;
            data.handle = customerName[Random.Range(0, customerName.Length)];
            customer.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = data.handle;

            var qu = queryPerLevel[Random.Range(0, queryPerLevel.Count)];
            var types = qu.queries[Random.Range(0, qu.queries.Count)];
            string temp = "";

            //eight query types
            for(int j = 0; j < 8; ++j){
                if((1 & ((int)types >> j)) > 0){
                    var t = (QueryType)(1 << j);
                    temp += t.ToString() + " ";
                }
            }
            customer.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = temp;
            customer.transform.GetComponent<Button>().onClick.AddListener(delegate {changeToStoryMode();});
        }
    }
    public void changeToStoryMode(){
        SceneManager.LoadScene(2);
    }
}

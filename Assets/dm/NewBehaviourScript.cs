using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject gameModel;  
    public float x_value;         
    public float y_value;         
    public Vector3 sizeChange;    

    
    public void MoveLeft()
    {
        x_value = x_value - 0.5f;  
        gameModel.transform.position = new Vector3(x_value, y_value, -2.35f);  
    }

    
    public void MoveRight()
    {
        x_value = x_value + 0.5f;  
        gameModel.transform.position = new Vector3(x_value, y_value, -2.35f);  
    }

    
    public void RotateLeft()
    {
        gameModel.transform.Rotate(0, 0, -10f);  
    }

    
    public void RotateRight()
    {
        gameModel.transform.Rotate(0, 0, -10f);  
    }

    
    public void ScaleUp()
    {
        gameModel.transform.localScale += sizeChange;  
    }

   
    public void ScaleDown()
    {
        gameModel.transform.localScale -= sizeChange;  
    }
    public void Reselt()
    {
        gameModel.transform.localScale = new Vector3(1f, 1f, 1f);
        gameModel.transform.rotation = Quaternion.Euler(90f, -90f, 0);
        gameModel.transform.position = new Vector3(0, 1.01f, -3.394f);
        x_value = 0;
        y_value = 1.01f;
    }
    void Start()
    {
       
    }
    
   
    void Update()
    {
       
        
    }

}

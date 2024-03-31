using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsManager : MonoBehaviour
{
    Dictionary<PointType, int> levelPoints;

    public Text[] uiPoints;
    public bool azul = false;
    public bool rojo = false;
    public bool amarillo = false;
    public bool verde = false;
    public bool negro = false;
    public bool blanco = false;
    public bool naranja = false;
    

    static int gamePoints;

    private PointsManager() { }
     public  static PointsManager _instance;

    public static PointsManager GetInstance()
    {
        if (_instance == null) _instance = new PointsManager();

        return _instance;
    }

    private void Start()
    {
       
        _instance = this;
        levelPoints = new Dictionary<PointType, int>();
    }

    public void UpdatePoints(PointType pointType, int points, int levelGoal)
    {
        if (levelPoints.ContainsKey(pointType))
        {
            levelPoints[pointType] += points;
        } else
        {
            levelPoints.Add(pointType, points);
        }
        if (pointType == PointType.Black)//0
        {
            if (levelPoints[pointType] >= levelGoal)
            {
                uiPoints[0].text = "Done";
                negro = true;
            }
            else uiPoints[0].text = levelPoints[pointType].ToString() + "/" + levelGoal.ToString();
        }
        if (pointType == PointType.Blue)//1
        {
            if (levelPoints[pointType] >= levelGoal)
            {
                uiPoints[1].text = "Done";
                azul = true;
            } 
            else uiPoints[1].text = levelPoints[pointType].ToString() + "/" + levelGoal.ToString();
        }
        if (pointType == PointType.Red)//2
        {
            if (levelPoints[pointType] >= levelGoal)
            {
                uiPoints[2].text = "Done";
                rojo = true;
            }
            else uiPoints[2].text = levelPoints[pointType].ToString() + "/" + levelGoal.ToString();
        }
        if (pointType == PointType.Yellow)//3
        {
            if (levelPoints[pointType] >= levelGoal)
            {
                uiPoints[3].text = "Done";
                amarillo = true;
            }
            else uiPoints[3].text = levelPoints[pointType].ToString() + "/" + levelGoal.ToString();
        }
        if (pointType == PointType.Green)//4
        {
            if (levelPoints[pointType] >= levelGoal)
            {
                uiPoints[4].text = "Done";
                verde = true;
            }
            else uiPoints[4].text = levelPoints[pointType].ToString() + "/" + levelGoal.ToString();
        }
        if (pointType == PointType.Orange)//5
        {
            if (levelPoints[pointType] >= levelGoal)
            {
                uiPoints[5].text = "Done";
                naranja = true;
            }
            else uiPoints[5].text = levelPoints[pointType].ToString() + "/" + levelGoal.ToString();
        }
        if (pointType == PointType.While)//6
        {
            if (levelPoints[pointType] >= levelGoal)
            {
                uiPoints[6].text = "Done";
                blanco = true;
            }
            else uiPoints[6].text = levelPoints[pointType].ToString() + "/" + levelGoal.ToString();
        }

        if (verde  == true && amarillo == true && verde == true && negro == true && blanco == true && naranja == true)
        {
            
            GameManager.instance.DetenerTiempo();
            SceneManager.LoadScene(2);
        }
    }

    

}

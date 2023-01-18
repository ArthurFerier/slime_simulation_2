using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class world : MonoBehaviour
{
    public Camera mainCam;
    
    public int nSquareX;
    private int _nSquareY;
    private float _squareLength;
    
    private float _minX, _minY, _maxX, _maxY;
    private int _maxCoordX, _maxCoordY;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {

        // world edges
        _minX = -8.88889f;
        _minY = -5.0f;
        _maxX = 8.88889f;
        _maxY = 5.0f;

        _squareLength = _maxX * 2 / nSquareX;
        _nSquareY = (int) Math.Round(_maxY * 2 / _squareLength);
        
        // assumes the (0,0) of the world is the center of the camera
        _maxCoordX = nSquareX / 2;
        _maxCoordY = _nSquareY / 2;

    }


    // getters

    public float GetMinX()
    {
        return _minX;
    }
    
    public float GetMinY()
    {
        return _minY;
    }
    
    public float GetMaxX()
    {
        return _maxX;
    }
    
    public float GetMaxY()
    {
        return _maxY;
    }

    public float GetSquareLength()
    {
        return _squareLength;
    }

    public int GetNSquareY()
    {
        return _nSquareY;
    }
    
    public int GetMaxCoordX()
    {
        return _maxCoordX;
    }
    
    public int GetMaxCoordY()
    {
        return _maxCoordY;
    }
    
}

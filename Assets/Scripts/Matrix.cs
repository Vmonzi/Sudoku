using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Matrix<T> : IEnumerable<T>
{
    //IMPLEMENTAR: ESTRUCTURA INTERNA- DONDE GUARDO LOS DATOS?
    T[,] myMatrix;
    [SerializeField] int _myWidth;
    [SerializeField] int _myHeight;
    public Matrix(int width, int height)
    {
        //IMPLEMENTAR: constructor

        myMatrix = new T[width, height];

        _myWidth = width;
        _myHeight = height;
    }

    public Matrix(T[,] copyFrom)
    {
        int width = copyFrom.GetLength(0);
        int height = copyFrom.GetLength(1);
        myMatrix = new T[width, height];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                myMatrix[i, j] = copyFrom[i, j];
            }
        }
        _myWidth = width;
        _myHeight = height;
    }

    public Matrix<T> Clone()
    {
        Matrix<T> aux = new Matrix<T>(Width, Height);
        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                aux[i, j] = myMatrix[i, j];
            }
        }
        return aux;


    }


    public void SetRangeTo(int x0, int y0, int x1, int y1, T item)
    {
        //IMPLEMENTAR: iguala todo el rango pasado por parámetro a item
        for (int i = x0; i <= x1; i++)
        {
            for (int j = y0; j <= y1; j++)
            {
                myMatrix[i, j] = item;
            }
        }
    }

    //Todos los parametros son INCLUYENTES
    public List<T> GetRange(int x0, int y0, int x1, int y1)
    {
        List<T> l = new List<T>();
        for (int i = x0; i <= x1; i++)
        {
            for (int j = y0; j <= y1; j++)
            {
                l.Add(myMatrix[i, j]);
            }
        }
        return l;
    }

    //Para poder igualar valores en la matrix a algo
    public T this[int x, int y]
    {
        get { return myMatrix[x, y]; }
        set { myMatrix[x, y] = value; }
    }

    // aca iria el getLenght total
    public int Width { get { return _myWidth; } }

    //aca por posicion
    public int Height { get { return _myHeight; } }

    //aca seria el count
    public int Capacity { get { return _myWidth * _myHeight; } }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _myWidth; i++)
        {
            for (int j = 0; j < _myHeight; j++)
            {
                yield return myMatrix[i, j];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

﻿using UnityEngine;
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
    }

    public Matrix(T[,] copyFrom)
    {
        //IMPLEMENTAR: crea una version de Matrix a partir de una matriz básica de C#
    }

    public Matrix<T> Clone()
    {
        Matrix<T> aux = new Matrix<T>(Width, Height);
        //IMPLEMENTAR
        return aux;
    }

    public void SetRangeTo(int x0, int y0, int x1, int y1, T item)
    {
        //IMPLEMENTAR: iguala todo el rango pasado por parámetro a item
    }

    //Todos los parametros son INCLUYENTES
    public List<T> GetRange(int x0, int y0, int x1, int y1)
    {
        List<T> l = new List<T>();
        //IMPLEMENTAR
        return l;
    }

    //Para poder igualar valores en la matrix a algo
    public T this[int x, int y]
    {
        get
        {
            //IMPLEMENTAR
            return default(T);
        }
        set
        {
            //IMPLEMENTAR
        }
    }

    // aca iria el getLenght total
    public int Width { get; private set; }

    //aca por posicion
    public int Height { get; private set; }

    //aca seria el count
    public int Capacity { get; private set; }

    public IEnumerator<T> GetEnumerator()
    {
        //IMPLEMENTAR
        yield return default(T);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(1); i++)
            {
                yield return myMatrix[i, j];
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> //T = int
    {
        //Global Member Variables
        private int count;
        private int capacity;
        private int index;
        private T[] items;

        //Properties

        //Count
        public int Count
        {
            get
            {
                return count;
            }
        }

        //Capacity
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        //Indexer
        //make sure to address accessing index outside of the size of array
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }


        //Constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
        }


        //Methods
        public void Add(T item)
        {
            //logic to "add" to my items array//what are the steps to add item? increase capacity?
            //1. add item to list at next available index
            //2. if nextIndex > Capacity, Capacity doubles
            items[count] = item;
            count++;
            if (count >= Capacity)
            {
                capacity *= 2;
                //T[] temporary = new T[capacity];
                //items += temporary;
                T[] temporary = items;
                items = new T[capacity];
                items = temporary;
            }

        }

        public void Remove(T item)
        {
            //1. 
        }
    }
}

//array loops if statements only
//indexer??
//ToString

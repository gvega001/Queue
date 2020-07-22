﻿using System;
using static System.Console;

namespace QueueDemo
{
	public class Queue
	{
		private int maxSize;
		private long[] myQueue;
		private int front;
		private int rear;
		private int items;
		public Queue(int size)
		{
			maxSize = size;
			myQueue = new long[size];
			front = 0;
			rear = -1;
			items = 0;
		}
		public void insert(long j)
		{
			if (isFull())
			{
				WriteLine("Queue is full");
			}
			else
			{
				if (rear == maxSize - 1)
				{
					rear = -1;
				}
				rear++;
				myQueue[rear] = j;
				items++;
			}

		}
		public long remove()
		{
			long temp = myQueue[front];
			front++;
			if (front == maxSize)
			{
				front = 0;
			}
			return temp;
		}

		public long peek()
		{
			return myQueue[front];
		}
		public bool isEmpty()
		{
			return (items == 0);
		}

		private bool isFull()
		{
			return (items == maxSize);
		}
		public void view()
		{
			Write("[");
			WriteLine("]");
			for (int i = 0; i < myQueue.Length; i++)
			{
				Write(myQueue[i] + " ");
			}
		}
	}
}
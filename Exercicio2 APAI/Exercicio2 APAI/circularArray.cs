using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_APAI
{
    class circularArray
    {
        public class CircularArray<T>
        {
            public class CircularArray<T>
            {
                private T[] array;

                private int head, tail, capacity;

                public int Length
                {
                    get { return capacity; }
                }

                public bool Empty
                {
                    get { return head == tail; }
                }

                public bool Full
                {
                    get { return (tail + 1) % capacity == head; }
                }

                public IEnumerable<T> Items
                {
                    get
                    {
                        int i = head;

                        do
                        {
                            yield return array[i];

                        } while ((i = (i + 1) % capacity) != (tail + 1) % capacity);
                    }
                }

                public CircularArray(int capacity = 8)
                {
                    head = 0;
                    tail = 0;

                    this.capacity = capacity;

                    array = new T[capacity];
                }

                /// <summary>
                /// Add Item to collection
                /// </summary>
                /// <param name="item">Item.</param>
                public void Add(T item)
                {
                    Console.WriteLine("Tail :" + tail);
                    // Check if collection is full
                    if (!Full)
                    {
                        array[tail] = item;
                        tail = (tail + 1) % capacity;
                    }
                }

                /// <summary>
                /// Remove the first item in collection
                /// </summary>
                public T Remove()
                {
                    // Check if collection is empty
                    if (!Empty)
                    {
                        T t = array[head];
                        // default the value from that position
                        array[head] = default(T);
                        // Ignores the current position for future values and increase one
                        head = (head + 1) % capacity;

                        return t;
                    }

                    throw new ArgumentException("Erro ao retornar");
                }

            }
        }
    }


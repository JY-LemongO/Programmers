using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int time = 1;
            int remainingTrucks = truck_weights.Length;

            Queue<int> truckWaitQueue = new Queue<int>();
            List<int> truckPassingTimerList = new List<int>();
            Queue<int> truckPassingWeightQueue = new Queue<int>();
            foreach (int truck in truck_weights)
                truckWaitQueue.Enqueue(truck);

            int currentRemainWeight = weight;
            while (remainingTrucks > 0)
            {
                if (truckWaitQueue.Count > 0)
                {
                    int nextTruckWeight = truckWaitQueue.Peek();

                    if(nextTruckWeight <= currentRemainWeight)
                    {
                        truckWaitQueue.Dequeue();
                        truckPassingTimerList.Add(1);
                        truckPassingWeightQueue.Enqueue(nextTruckWeight);
                        currentRemainWeight -= nextTruckWeight;
                    }                    
                }

                for (int i = 0; i < truckPassingTimerList.Count; i++)
                {
                    if (truckPassingTimerList[i] == -1)
                        continue;
                    else if (truckPassingTimerList[i] >= bridge_length)
                    {
                        truckPassingTimerList[i] = -1;
                        currentRemainWeight += truckPassingWeightQueue.Dequeue();
                        remainingTrucks--;
                    }
                    else
                        truckPassingTimerList[i]++;
                }

                time++;
            }

            return time;
        }
}
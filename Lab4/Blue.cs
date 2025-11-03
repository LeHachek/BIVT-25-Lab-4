using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int n = array.Length;
            int a, ai = -1;
            int max = array[0];
            for (int i = 0; i < n; i++)
            {

                if (array[i] < 0)
                {
                    a = array[i];
                    ai = i;
                    break;
                }

            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == max)
                {
                    max = i;

                    break;
                }
            }
            int sum = 0;
            for (int i = max + 1; i < n; i++)
            {
                sum = sum + array[i];
            }
            if (ai >= 0)
            {
                array[ai] = sum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int pos;
            int posi = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    pos = array[i];
                    posi = i;
                }
            }
            if (posi != -1)
            {
                answer = new int[n+1];
                int t = 0;
                for (int i = 0; i < n; i++)
                {
                    answer[t] = array[i];
                    if (i == posi)
                    {
                        t++;
                        answer[t] = P;
                    }
                    t++;

                }
            }
            else
            {
                answer = new int[n];
                for (int i = 0; i < n; i++)
                {
                    answer[i] = array[i];
                }
            }
            
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int found = 0;
            int n = array.Length;
            int min = -1, mini = 0;
            int t=0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    min = array[i];
                    mini = i;
                    found = 1;
                    break;
                }
            }

            if (found == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (min > array[i] && array[i]>0)
                    {
                        min = array[i];
                        mini = i;
                    }
                    
                }
                
                answer = new int[n - 1];
                for (int i = 0; i < n; i++)
                {
                    if (i==mini)
                    {
                        i++;
                        if (i == n)
                        {
                            break;
                        }
                    }
                    answer[t] = array[i];
                    t++;
                }
            }
            else
            {
                answer = new int[n];
                for (int i = 0; i < n; i++)
                {
                    answer[i] = array[i];
                }
            }
            

            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            int n = array.Length;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            double sr = sum / n;
            for (int i = 0; i < n; i++)
            {
                array[i] = array[i] - sr;
            }

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            int n = A.Length;
            int k = B.Length;
            if (n == k)
            {
                for (int i = 0; i < n; i++)
                {
                    sum = sum + B[i] * A[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            int n = array.Length;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            double sr = sum / n;
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < sr)
                {
                    t++;
                }
            }
            indexes = new int[t];
            int m=0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < sr)
                {
                    indexes[m] = i;
                    m++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;
            // code here
            if (array.Length > 1)
            {
                int n = array.Length;
                int[] A = new int[n - 1];
                for (int i = 0; i < n - 1; i++)
                {
                    A[i] = array[i] - array[i + 1];
                    A[i] = Math.Sign(A[i]);
                }
                int m = 0;
                int t = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (A[i] == 0)
                    {
                        t++;
                        if (i==n-2 && t > count)
                        {
                            count = t;
                        }
                    }
                    else
                    {
                        if (A[i] == 1)
                        {
                            m = t;
                            while (A[i] == 0 || A[i] == 1)
                            {
                                m++;
                                if (A[i] == 0)
                                {
                                    t++;
                                }
                                else
                                {
                                    t = 0;
                                }
                                i++;
                                if (i == n - 1)
                                {
                                    break;
                                }
                            }
                            i--;
                            if (m > count)
                            {
                                count = m;
                            }
                        }
                        else //A[i] == -1
                        {
                            m = t;
                            while (A[i] == 0 || A[i] == -1)
                            {
                                m++;
                                if (A[i] == 0)
                                {
                                    t++;
                                }
                                else
                                {
                                    t = 0;
                                }
                                i++;
                                if (i == n - 1)
                                {
                                    break;
                                }
                            }
                            i--;
                            if (m > count)
                            {
                                count = m;
                            }
                        }
                    }
                }
            }
            else
            {
                if (array.Length == 0 || array == null)
                {
                    count = -1;
                }
                else
                    count = 0;
            }
            count++;
            
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            answer = new int[2*n];
            int t = 0;
            for (int i=0;i<2*n; i+=2)
            {
                answer[i] = array[t];
                answer[i+1] = array[t];
                t++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int n = array.Length;
            double min, max;
            if (array.Length == 0 || array == null)
            {
                normalized = null;
            }
            else
            {
                min = array[0];
                max = array[0];
                for (int i = 0; i < n; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                if (min == max)
                {
                    normalized = null;
                }
                else
                {
                    normalized = new double[n];
                    for (int i = 0; i < n; i++) {
                        normalized[i] = (array[i] - min) / (max - min);
                    }
                }
            }
            
            

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
            int min = 0, max = n-1;
            int mid = min + (max - min) / 2;
            int t=0;
            
            while (min <=max)
            {
                if (P > array[mid])
                {
                    min = mid+1;
                    mid = min + (max - min) / 2;
                }
                else
                {
                    if (P < array[mid])
                    {
                        max = mid-1;
                        mid = min + (max - min) / 2;
                    }
                    else
                    {
                        index = mid; t = 1; break;
                    }
                }
            }
            if (t == 0)
            {
                index = -1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;
            // code here
            int n;
            
            n = (c - a) / b+1;
            if (a + (n - 1) * b > c)
            {
                n--;
            }
            if (c < a)
            {
                n = 0;
            }
            if (b>0)
            {
                array = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = a + i * b;
            }
            if (b <= 0)
            {
                array = null;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            int n = magazine.Length;
            
            // code here

            if (n>=3){
                int[] A = new int[n - 2];
                for (int i = 0; i < n - 2; i++)
                {
                    A[i] = magazine[i] + magazine[i + 1] + magazine[i + 2];
                }
                int max = A[0];
                int maxi = 0;
                for (int i = 0; i < n-2; i++)
                {
                    if (A[i] > max)
                    {
                        max = A[i];
                    }
                }
                for (int i = 0; i < n - 2; i++)
                {
                    if (A[i] == max)
                    {
                        maxi = i;
                        break;
                    }
                }

                indexes = new int[3];
                indexes[0] = maxi;
                indexes[1] = maxi+1;
                indexes[2] = maxi+2;
            }
            else
            {
                if (n > 0)
                {
                    indexes = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        indexes[i] = i;
                    }
                }
                else
                {
                    indexes = null;
                }
            }


            // end

            return indexes;
        }
    }
}
reminder (%)
-10%4 = 2

reminder = dividend - quitent * divisor (maxmum multiple of divisor <= dividend)

que: find -40 % 7 

using formula reminder = diviend -quotient * divisor 

quotient * divisor is noting but maximum multiple of divisor <= dividend

in our case 
 - dividend => -40
 - divisor = 7
 maximum multiple of 7 wihch is <= -40 is -7*6 == -42

 =>  -40 - (-42) => -40 + 42 => 2
hence ans for -40 % 7 is 2 

-------------------------

forlumas 
1. (a + b)%M = (a%m + b%m) %m
2. a%m = (a+m)%m proof is added
3. (a*b)%m = (a%m * b%m) %m
4. (a-b)%m  = (a%m - b%m)%m



Question: 1 Given A&B, A>B, find no of M such that A%M = B%M also, M>1

Solution => A%M = B%M
=> A%M = B%M
=> A%M - B%M = 0
=> A%M - B%M + M = M (Add M both side)
=> (A%M - B%M + M) % M = M%M (Take Mod M both side)
=> (A%M - B%M + M) % M = 0 
   => (Scince M%M == 0  and (A + M) % M => A%M  )
=> (A - B) %M = 0;
    => M is all factors of (A-B) except 1
    => to get factors loop till sqrt(A-B) and get all the factors which gives (A-B)*factor == 0 and return the resule
=> Time Complexity (sqrt(A-B))

Code in short in c#


-----

Question 2: Given N array elements calculte no. of pairs(i,j) such that {[arr[i] + arr[j]]%M == 0} M is given.


- breute force 
  - try all pairs

- using identity => (a+b)%m = (A%M + B%M)%M
  - we were asked to find the count ot total pairs so no need to intrate throgh each pairs and store them 

  - we can identity how may pairs is can be formed using multiplcatin -> let say if we have 3 pairs whose remider is 2 and 2 pairs whose remider is 4 and mod m is given as 6
  so 4+2 will form result divisible by 6 
  hence we can multiply the number of pairs 3*2 will give 6 pairs hence we got the count without intrating 6 times.

   - steps 
      - create reminder count array of Count[Arr[i] % M]++;
      - calculate the total possible pairs by multiplication 

- code
 ``` csharp 

public int solve(List<int> A, int B)
    {
        int M = 1000000007;

        int[] arr = new int[B];

        foreach(int n in A) arr[n % B]++;

        long ans = ((long)arr[0] * (arr[0] - 1) / 2) % M;
        ans = ans % M;

        int i=1; int j = B-1;

        while(i<=j){
            if(i==j){
                ans = (ans + ((long)arr[i] * (arr[i] - 1) / 2) % M) % M;
            }else{
                ans = (ans + ((long)arr[i] * arr[j]) % M) % M;
            }
            i++; j--;
        }
        
        return (int)ans;
    }
 ```


Question: 3
Given an array of distinct integers in the range of {0< = arr[i] <= N-1} N is the size of array. replace arr[i] with arr[arr[i]];

Solution
Approach 1 : Using Auxilary array
Approach 2: without extra space => saving two infoarion in single number (old value and new value) 
Steps
  - 





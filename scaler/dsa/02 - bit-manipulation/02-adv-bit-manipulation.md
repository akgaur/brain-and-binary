
- Binary number in the power of 2 is in the gp series, we can find the sum of first n terms using gp series
    GP => 2^0,2^1,2^2,2^3,2^4,2^5,2^6,2^7,2^8,2^9,2^10
    gp sum => a((r^N) - 1)/r-1;
    a= 1, n = 5, r = 2
    (1*((2^5)-1))/2-1 => 2^5-1 = > 31
    => 1+2+4+8+16=31


- ranges of 8 bit, 16 bit, N Bit signed and unsigned numbers

- bit wise operator and truth table with properties of 
  - and &
  - or |
  - xor ^
  - negative ~
  - left shift <<
  - right shift >>

-  all properties of xor used in dsa questions 
 - Gives Zero if same number => is used to find the unique in list
 - 


 Questions
 - Check if set bit
 - count number of set bits => using loops form 0 tll 31 =>TC: O(N)



 -----------------------------
 Bit Manipulation 2
 --------------------------

 Question: Given an array of N elements and every element repeats twice except find the unique element find that element.

- frequency hashmap
- sort and check and compare i with i+1,
 - best solution use xor


 Question 2: Given arr[N] there are two unique element, and every other element is repeating twice find those two unique elements

 Approach : Frequency hashmap
 Approach 2: sort and check 
 Approach 3: xor of all elements and create set
   => find xor of all elents and store into elementsXor and pick any bit that is set
   => based on that create two set form the array 
      - set 1 all numbers has i(picked bit) is set
      - set 2 all numbers has i(picked bit) is unset

      - then take xor or both sets 
      -set 1 will give 1 value, and set 2 wll give 1 value

property
- itx bit of the resultent value is set because there is 100% possibility that the other element its bit was unset 
  and => xor of 0^1 gives 1

- if we devide in two set two exule element will be in same set that will result 0 and give the unique value


Question: Given Arr[N], contains all elemtns from 1 to N+2, except two missing elements, find the missing element. 
 Note: Not sure if dublicate will be there in the arryr or not

 Approach : sort and find
 Approach : Using extra space
Approach : using formula S1 and S2 
Approach : YTD


Question: Given N Element, Calculate sum of xor of all pairs 

Appraoch : Take all pairs 
Using contributation technique





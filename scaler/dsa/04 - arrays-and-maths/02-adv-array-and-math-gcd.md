GCD (Greatest Common Divisor)

The GCD of two numbers is the largest number that divides both of them without leaving a remainder.

Example:
If gcd(a, b) = x, then:

a % x == 0 and

b % x == 0
And x is the greatest such number.

Special Case: GCD involving 0

Any number is a divisor of 0 because 0 % n == 0 for any non-zero integer n.

Example:
gcd(0, 18)

Factors of 18: 1, 2, 3, 6, 9, 18

Factors of 0: all integers (since 0 is divisible by any number)

So, the GCD is 18, as it is the greatest number that divides both.

Note on Negative Numbers

Even if the input numbers are negative, the GCD is always returned as a positive value.

This is because both -x and x are divisors, but the positive value is considered the greatest.

Example:
Factors of -5: -5, 5
→ GCD is 5, not -5.



Question: Given A,B find Gcd(A,B)

A = Abs(A),
B = Abs(B);

for(i = min(A,B); i>=1; i--){
    if(A%i ==0 && A%i == 0) return i;
}

reduce time complexiy => loop till sqrt of n


better: using euclid algorithm (recursion)

Euclid Algorithm: if two number a, b and (a > b)
then gcd(a,b) = gcd(a-b,b);

=> so gcd(a+b,b) also same?? =>  gcd(a,b) = gcd(a+b,b);

=> to find gcd using  gcd(a,b) = gcd(a-b,b)

 - first swap if a < b
 - the find return gcd(a-b, b)
 - base condition if b is == 0 return a;
 time complexity is O(max(a,b))

Why this as we already have lesser time complexity better then this in previous solution 
- because when b if b is not small number then it is very quick 
 let say gcd(400, 300)
  = gcd(400, 300) => gcd(100, 300) 
  => gcd(200, 100) => gcd(100, 100) => gcd(0,100) return ans
    we got ans in just 4 calls but squrt will take around 17 itration




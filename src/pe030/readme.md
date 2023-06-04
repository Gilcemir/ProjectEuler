 ## Explanation

We gotta find out the size of the maximum size of number.
max size is : (10^n) -1,
For example, if n = 2, then
max size = 99.
the Maximum value for N size will be
n*(9^5), for example:

 (9^5) + (9^5) = > from 99.
 
so max size = mSize = (10^n) -1;

max value = mValue = n*(9^5);

we need to find out the upper bound, which depends on n value.

n is the first integer which satisfies:
mSize > mValue;

(10^n) - 1 > n*(9^5)
 
n = 6 (wolfram alpha)

max value = 6 * 9^5
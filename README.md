# F# Mutability Bug

This example demonstrates a common issue in F# related to mutable variables. The `add` function calculates the sum of `x` and `y` only once, not reflecting later changes to their values.

## How to Reproduce

1. Compile and run the code in `bug.fs`.
2. Observe the output. The first output will be 30 as expected, but the second output will also be 30 instead of 70, highlighting that the function does not recalculate the sum when x and y are changed.

## Solution

Refer to `bugSolution.fs` for a possible solution using immutability or a function that recalculates the sum based on current values of x and y.

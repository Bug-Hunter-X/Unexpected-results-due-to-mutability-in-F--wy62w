let x = 10
let y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

// Recalculate z using updated values
let x2 = 30
let y2 = 40
let z2 = add x2 y2
printf "%d\n" z2

//Alternative solution using a function that takes in the updated values
let add2 () = x + y
printf "%d\n" (add2())
x <- 30
y <- 40
printf "%d\n" (add2())
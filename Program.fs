// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

// Defining List and mapping and filtering through it
let sal = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

// Filter through the list to find high-income salaries
let highIncomeSal = List.filter (fun sal -> sal > 100000) sal

// Use the map function to calculate tax for all salaries based on the table provided
let calculateTax sal =
    match sal with
    | sal when sal < 49020 -> sal + 20000
    | sal when sal >= 50000 && sal <= 100000 -> sal
    | _ -> sal * 0.85 // Assuming 15% tax for salaries above $100,000

let taxedSal = List.map calculateTax sal

// Sum salaries between $50,000 and $100,000 using reduce/fold function
let totalSal = List.reduce (+) (List.filter (fun sal -> sal >= 50000 && sal <= 100000) sal)

// Tail Recursion
let rec sumMultiplesOfThree n acc =
    if n = 0 then acc
    else sumMultiplesOfThree (n - 3) (acc + n)

let calculateSumOfMultiplesOfThree n =
    sumMultiplesOfThree n 0

// Example usage
let exampleResult = calculateSumOfMultiplesOfThree 27


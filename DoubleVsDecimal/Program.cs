﻿// Simulating a financial operation where we're adding 
// a small amount multiple times
const int iterations = 10000;
const decimal decimalValue = 0.01M; // M suffix denotes a decimal
const double doubleValue = 0.01;

decimal totalDecimal = 0M;
double totalDouble = 0.0;

for (int i = 0; i < iterations; i++)
{
    totalDecimal += decimalValue;
    totalDouble += doubleValue;
}

Console.WriteLine($"Using decimal after {iterations} iterations: {totalDecimal}");
Console.WriteLine($"Using double after {iterations} iterations: {totalDouble}");
// Using decimal after 10000 iterations: 100,00
// Using double after 10000 iterations: 100,00000000001425

if ((double)totalDecimal != totalDouble)
{
    Console.WriteLine("The values are not the same!");
}
else
{
    Console.WriteLine("The values are the same.");
}
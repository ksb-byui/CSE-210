//Kole S. Bauer
// 4/29/2024
// CSE-210
// W02: Abstraction Part 1 Intro


//if STATEMENTS


// PYTHON

// x = 0
// if x ==0:
//     print("Howdy World!")

// We have to initialize the variable: "x gets 0"
int x = 0;

// Check if x has 0
if (x == 0)

// Console.WriteLine is similar to Python's print(). We have to end with a semi-colon ;
{
    Console.WriteLine("Howdy World!");
}




// LOOPS //


// PYTHON

// x = 0
// while x < 3:
//     print("Howdy World!")
//     x = x + 1 OR x += 1


// C# 

int x = 0;

while (x < 3)
{
    Console.WriteLine("Howdy World!");
    x += 1; //or x++1
}

// add to the variable and return the value += OR x++  (Incrementor)
// subtract -= OR x--  (Decrementor)
// multiply *=  
// divide /=  
// divide return remainder %=    
// all of these work in C#  


// for LOOPS

//PYTHON

// x = 0

// for x in range(9):
//     print("Howdy World!")



// C# 


// "foreach" C# is close to  "for" Python
// 3 expressions in the parenthesis. Separate with semi-colons ;
// first expression is initializer - give the variable something - int x = 0;
// second is logical test - true false - x < 9;
// 3rd is modifier - however loop variable should change depending on logic test - x++ (adds 1 to x each time the loop happens)

foreach ( int x = 0; x < 9; x++)
{
    Console.WriteLine("Howdy World!")
}


//Name space
using System;

// class called Program
class Program

// Program must have a function - Main
{
    static void Main(string[] args)
    {
        for (int x = 0;  x < 9;  x++)
        {
            Console.WriteLine("Howdy World!");
        }
    }
}


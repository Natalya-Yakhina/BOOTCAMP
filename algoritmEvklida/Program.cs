// НОД (Алгоритм Евклида)
// НОД (14, 21) = 7 // наибольший общий делитель 

// int n = 140;
// int m = 175;
// while (n != m)
// { 
//     if (n > m) n = n - m; 
//     else m = m - n; 
//     Console.WriteLine(n); 
//     Console.WriteLine(m); 
//     Console.WriteLine();
// }


// НОК
int n = 140;
int m = 175;
int count = n * m;
while (n != m)
{
    if (n > m)
        n = n - m;
    else
        m = m - n;
}
Console.WriteLine(count / n);
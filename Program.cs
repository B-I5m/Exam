//Task1
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// int count = 0;
// for (int i = 1; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
//     if (arr[i] != arr[i - 1])
//         count++;
// }

// Console.WriteLine(count);

//Task#3
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// int mx = -99999;
// int mn = 99999;
// for (int i = 1; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
//     if (arr[i] != arr[i - 1])
//         mx = Math.Max(mx, arr[i]);
//     mn = Math.Min(mn, arr[i]);
// }
// System.Console.WriteLine(mn + " " + arr[2] + " " + mx);

//Task5
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a + 1];
// int cnt = 0;
// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int k = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < a; i++)
// {
//     if (k == arr[i])
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);

//Task#7
// int Sm(int n)
// {
//     if (n == 0) return 0;             
//     return (n % 10) + Sm(n / 10);
// }
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = Sm(n);
// System.Console.WriteLine(sum);

//Task#8
// void Swp(int a, int b)
// {
//     Console.WriteLine($"x = {b}");
//     Console.WriteLine($"y = {a}");
// }
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Swp(a,b);


//Task#10
//  void Even(int start, int end)
// {
//     if (start > end)
//     {
//         return;
//     }
//     if (start % 2 == 0)
//     {
//         Console.Write(start + " ");
//     }
//     Even(start + 1, end);
// }
// void Odd(int start, int end)
// {
//     if (start > end)
//     {
//         return;
//     }
//     else if (start % 2 != 0)
//     {
//         Console.Write(start + " ");
//     }
//     Odd(start + 1, end);
// }
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Even(a,b);
// System.Console.WriteLine();
// Odd(a, b);

// Task#2
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a+1];
// int cnt=0;
// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int k = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < a; i++)
// {
//     if (k == i)
//     {
//      continue;
//     }
//     System.Console.Write(arr[i] + " ");
// }
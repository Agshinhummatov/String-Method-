

#region Heap-stack


//int a = 5;
//int b = 10;
//b = 10;

//Console.WriteLine(a);
//Console.WriteLine(b);


//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = arr1;

//arr2[0] = 100;
//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);

//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5,7 };

//arr2[0] = arr1[0];

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);


//int n = 5;

//Test(n);

//Console.WriteLine(n);
//static void Test(int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}



//int[] arr = { 2, 6, 9, 15, 20 };

//Test2(arr);

//Console.WriteLine(arr[0]);

//static void Test2(int[] arr)
//{
//    arr[0] = 200;

//    Console.WriteLine(arr[0]);

//}


//int n = 5;

//Test(ref n);

//Console.WriteLine(n);
//static void Test(ref int n)
//{

//    Console.WriteLine(n);
//}





//int n = 5;

//Test(out n);

//Console.WriteLine(n);
//static void Test(out int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}
#endregion


#region Homework 1





//}

//string name = "Aqsin";

//string name2 = name;

//Console.WriteLine(name);
//Console.WriteLine(name2);



//string address = "Ehmedli";

//Console.WriteLine(address.Length);


//string address = "Xirdalan";

//Console.WriteLine(address.StartsWith("X"));


//string address = "Baku";

//Console.WriteLine(address.StartsWith("e"));


//string address = "Baku";

//Console.WriteLine(address.EndsWith("u"));

//if (address.EndsWith("i"))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}





//string address = "Baku";

//Console.WriteLine(address.Contains("u"));






//string address = "Baku,Azeribaijan,Tovuz";

//var res = address.Split(",");
//Console.WriteLine(address);




//string address = "Baku,Azeribaijan,Tovuz";

//var res = address.Split(",");
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}





//string address = "Tovuz";

//Console.WriteLine(address.ToLower());



//string address = "Baku";

//Console.WriteLine(address.ToUpper());




//string address = "Sumqayit";

//Console.WriteLine(address.ToCharArray());




//string address = "tovuz";


//var letter = address[0].ToString().ToUpper();



//var arr = address.ToCharArray();


//arr[0] = char.Parse(letter);

//string result = "";



//foreach (var item in arr)
//{
//    result+= item;
//}





//string address = "Baku";

//Console.WriteLine(address.Substring(2));


//string address = "  Tovuz";

//Console.WriteLine(address.Trim());



//string name = "Lale";

//Console.WriteLine(name.Replace("L","J"));



//string name = "Aqsin";

//if (string.IsNullOrEmpty(name))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}



//string name = "Hummatov";

//if (!string.IsNullOrEmpty(name))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}



//string name = "Hummatov";

//if (!string.IsNullOrWhiteSpace(name))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}




#endregion




#region Homework 2

//2) Parametr olaraq string qebul eden metod yazmalisiz. 
//Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. (Cavid gelirse , ekranda divaC gorsensin).





//static string Reverse(string Name)
//{
//    char[] charArray = Name.ToCharArray();

//    string reversedString = string.Empty;

//    for (int i = charArray.Length - 1; i > -1; i--)
//    {
//        reversedString += charArray[i];
//    }


//    return reversedString;
//}

//Console.WriteLine(Reverse("Aqsin"));


#endregion






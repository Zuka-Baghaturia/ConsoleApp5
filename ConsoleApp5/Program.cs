
var a = ReturnNumbers(10);

//foreach (var item in ReturnNumbers(10))
//{
//    Console.WriteLine(item);
//}
IEnumerable<int> ReturnNumbers(int n)
{
    for (int i = 0; i < n; i++)
    {
       yield return i+1;
    }

}

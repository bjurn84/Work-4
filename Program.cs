Console.Write ("Введите целые числа через пробел: ");
string data = Console.ReadLine();

string[] dataList = data.Split(" ");
Console.WriteLine(data);
int[] intList = new int[dataList.Length];

for (int i=0; i<dataList.Length; i += 1){
    intList [i] = (Convert.ToInt32(dataList[i]));
    Console.WriteLine(dataList[i]);
}
int max = intList[0];
for (int i=0; i<dataList.Length; i +=1)
    if (max < intList[i]) max = intList[i];


Console.WriteLine ("Максимальное число из {0} будет - {max}");
Console.WriteLine ("Максимальное число из {0} будет - {1}", data, max);
Console.WriteLine ("Максимальное число из " + data + " будет - " + max);

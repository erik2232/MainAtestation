string[] Array = {"Moscow","Yerevan","5","Paris"};
int newArrayLength = 0;

for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length>=3)
    {
      newArrayLength++;

    }
    
}
string[] NewArray = new string[newArrayLength];
int newArrayIndex = 0;
for (int i = 0; i <Array.Length; i++)
{
    if(Array[i].Length>=3)
    {
      NewArray[newArrayIndex] = Array[i];
      newArrayIndex++;
    }
    

}
Console.WriteLine(string.Join(',',NewArray));
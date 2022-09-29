string [] array1 = new string[] {"2","hello","git","name","756"};
string [] array2 = new string[5];
int index = 0;
//Console.WriteLine("Введите элементы массива: ");
for(int i=0; i<5; i++)
{
      if(array1[i].Length<=3)
        {
            array2[index]=array1[i];
            index+=1;
        }
}
for(int i=0; i<5; i++)
{
    Console.Write(" " + array2[i]);
}
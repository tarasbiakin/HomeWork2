 int Max(int arg1, int arg2,int arg3){
     int result = arg1;
     if(arg2 >result) result = arg2;
     if(arg3 >result) result= arg3;
     return result;
}

System.Console.WriteLine("Введите числа, которые необходимо сравнивать");
int[]array = new int[9];
for(int i = 0; i <array.Length; i++ ){
    array[i] = Convert.ToInt16(Console.ReadLine());
}

 int result = Max(
    Max(array[0],array[1],array[2]),
     Max(array[3],array[4],array[5]),
     Max(array[6],array[7],array[8]));
     System.Console.WriteLine(result);

 int max = Max(Max(array[0],array[1],array[2]),Max(array[3],array[4],array[5]),Max(array[6],array[7],array[8]));

Console.WriteLine($"max  " + max);    
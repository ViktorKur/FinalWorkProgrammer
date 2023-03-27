using static ZapolnenieMassiva;
using static PreobrazovanArr;
Console.Clear();
string[] strArr = ZapolnenieArray(); // Запрос через функцию ZapolnenieArray ономерного строковаго массива 
string[] arrayDOThreeChar = strArr.PreobrazovanArrTOThreeChar(); // Присвоение массиву rrayDOThreeChar
//  результата выполнения функции PreobrazovanArrTOThreeChar
Console.WriteLine($"Заданный строковый массив: [" + string.Join(", ", strArr) + "]"); // Вывод исходного массива
Console.WriteLine($"Массив после выборки из заданного массива с длиной символов не больше 3х: [" 
+ string.Join(", ", arrayDOThreeChar)  + "]"); // Вывод массива после выборки
Console.WriteLine();
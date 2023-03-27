public static class PreobrazovanArr
{
  // Функция формирует массив строк длина которых меньше или равна 3 из входящего массива,
  // через временную строковую переменную
  public static string[] PreobrazovanArrTOThreeChar(this string[] arreyStr)
  {
    string tempDOThreeChar = string.Empty; // Инициирование пустой временной строковой переменной 
    for (int i = 0; i < arreyStr.Length; i++) // Цикл for для перебора всех элементов массива 
    {
      if (arreyStr[i].Length > 0 && arreyStr[i].Length <= 3) //Проверка строк на длину >0< = 3 из входящего массива  
      {
        // Заполнение временной переменной строк на длину >0< = 3 с разделителем ","
        tempDOThreeChar = tempDOThreeChar + arreyStr[i] + ",";
      }
    }
    // Заполнение массива arrayDOThreeChar из временной переменной строки с разделителем "," 
    // и удалением пустых значений после разделителя
    string[] arrayDOThreeChar = tempDOThreeChar.Split(',', StringSplitOptions.RemoveEmptyEntries);
    return arrayDOThreeChar; // Возвращаем массив arrayDOThreeChar обратно функции вызова 
  }
}
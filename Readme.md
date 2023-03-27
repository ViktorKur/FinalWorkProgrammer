# Это итоговая проверочная работа.
## Данная работа необходима для проверки наших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Что-бы убедиться, что базовое знакомство с it прошло успешно.
## Для полценного выполнения проверочной работы необходимо:
>1.	Создать репозиторий на GitHub
>2.	Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
>3.	Снабдить репозиторий оформленным текстовым описанием >решения (файл README.md)
>4.	Написать программу, решающую поставленную задачу
>5.	Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)


__Задача:__ Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
**************************************************************

## Выполнение итоговой работы

Входе выполнения итоговой работы был применен алгоритм, который в ходе выполнения программы:
1. загружал уже заданный массив стороковых данных (взятых и объединенных мной в один массив из 3х примеров итогового задания) **{ "hello", "2", "world", ":)", "1234", "1567", "-2", "computer science", "KAZAN", "DENMARK", "Russian"}** с помощью вызываемой функции **ZapolnenieArray** находящейся в отдельном файле подпрограммы __ZapolnenieMassiva__
2. далее загруженный массив строковых данных отправляется, через ввызываемую функцию **PreobrazovanArrTOThreeChar** находящейся в отдельном файле подпрограммы __PreobrazovanArr__, где сначала задается промежуточна пустая строковая переменная __tempDOThreeChar__. И далее по циклу перебераем все элементы строкового массива __arreyStr__, проверяем будут ли они отвечать условию (количество символов должно быть больше нуля и меньше либо равно трем).
Все элементы отвечающие условию записываются в промежуточную строковую переменную  __tempDOThreeChar__, если условие не выполняется переходим к следующей переменной. После прохода по всем элемента массива (окончания цикла) переходим в функцию преобразования из получившейся промежуточную строковую переменную с разделителем *Split (",")* __tempDOThreeChar__ в созданный  массив строковых данных **arrayDOThreeChar** с отсеканием пустых строк функцией *StringSplitOptions.RemoveEmptyEntries*. И затем возвращаем получившийся строковый массив **arrayDOThreeChar** обратно в **MainAndPrint**
3. Выводим получившийся массив после выборки.


## __Задание и Блок схема программы__
![Блок схема программы](BlocShema_ItogZadan.png)

## **Ссылка на репозиторий с исходниками кода итоговой проверочной работы**
![Ссылка на репозиторий с исходниками кода итоговой проверочной работы] (https://github.com/ViktorKur/FinalWorkProgrammer.git)

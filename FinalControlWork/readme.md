
**Задача:**  

Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  

**Алгоритм решения:**
 - Объявляется первоначальный массив, заданный на старте алгоритма.
 - Объявляется пустой финальный массив, размер финального массива равен размеру начального массива. 
 
- Создаём метод, в котором цикл равен длине начального массива.
- Заводим переменную ***count***.
- Внутри цикла проверка условия, если строка мемее или равна 3м символам, то элемент первого массива заносится в элемент второго массива. 
- После переменная ***count*** увеличивается на 1, возвращается к циклу ***for*** в котором ***i*** увеличивается на 1. 
- Число циклов равно колличеству индексов начального массива.
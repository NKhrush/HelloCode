﻿// Характеристики строк
// Строка - неизменяемый тип данных
//  - элементы строки не могут быть изменены
//  - размер существующей строки не может быть изменен

// Создание строк:
string s1 = "hello";

char[] ch_array = { 'w', 'o', 'r', 'l', 'd' };
string s2 = new String(ch_array); // конструкктор это метод, который создает объект

string s3 = new String('a', 6); // результатом будет строка "аааааа"
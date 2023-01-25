# Итоговая практическая работа

Репозиторий с решением итоговой практической работой.

## 1. Решение 

```
string[] strings = new string[4]{"hello","my","world",";-)"};
List<string> output = new List<string>();

for(int i = 0; i < strings.Count(); i++){
    if(strings[i].Length > 3) continue;
    output.Add(strings[i]);
}

foreach(string str in output){
    Console.WriteLine(str);
}
```


## 2. Блок-схема

Блок-схема алгоритма 

![Блок-схема](https://github.com/Pianer190/examWork2022/blob/master/scheme.png?raw=true)

## 4. Описание практического задания

<table>
	<tr>
	    <th>Задание</th>
	    <th>Пример</th>  
	</tr>
    <tr>
	    <td rowspan="3" width="70%">Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.</td>
	    <td>["hello", "2", "world", ":-)"] -> ["2", ":-)"]</td>  
	</tr>
    <tr>
	    <td>["1234", "1567", "-2", "computer science"] -> ["-2"]</td>  
    </tr>
        <tr>
	    <td>["Russia", "Denmark", "Kazan"] -> []</td>  
    </tr>
</table>
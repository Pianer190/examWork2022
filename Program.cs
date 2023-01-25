// See https://aka.ms/new-console-template for more information

string[] strings = new string[4]{"hello","my","world",";-)"};
List<string> output = new List<string>();

for(int i = 0; i < strings.Count(); i++){
    if(strings[i].Length > 3) continue;
    output.Add(strings[i]);
}

foreach(string str in output){
    Console.WriteLine(str);
}
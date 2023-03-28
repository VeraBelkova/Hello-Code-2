// /Группа Методов 1 (Не принимает значений и не выдает)*************************************************************************************

void Method1()
{
  Console.WriteLine("Автор ...");
}
Method1();

// Группа Методов 2 (принимает, но не выдает) **********************************************************************************************

//Пример 1
void Method2(string msg)
{
  Console.WriteLine(msg);
}
Method2("Текст сообщения");

//Пример 2
void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
Method21("Текст", 4);

//Группа Методов 2 (Не принимает, выдает) **********************************************************************************************

int Method3()
{
  return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Группа Методов 4 (принимает, выдает) **********************************************************************************************

string Method4(int count, string text)
{
  int i =0;
  string result = String.Empty;

  while (i < count)
  {
    result = result + text;
    i++;
  }
  return result;
}

String res = Method4(10, "Love");
Console.WriteLine(res);

//*********************************************  For For  For For  ****************************
string Method4(int count, string text)
{
  string result = String.Empty;
  for (int i = 0; i < count; i++)
  {
    result = result + text;
  }
  return result;
}

String res = Method4(10, "Love");
Console.WriteLine(res);


// Цикл в цикле
for (int i = 2; i <= 10; i++)
{
  for (int j = 2; j <= 10; j++)
  {
    Console.WriteLine($"{i} * {j} = {i * j}");
  }
  Console.WriteLine();
}
//*******************************   ЗАМЕНА ТЕКСТА    **************************************************

string text = "Привет, я смогу позвонить завтра";

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;

  int length = text.Length;
  for (int i = 0; i < length; i++ )
  {
    if(text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
  }
  return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

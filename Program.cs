string[] str_array01 = { "hello", "2", "world", ":-)" };
int j = 0;

for (int i = 0; i < str_array01.Length; i++)   //считаем количество строк с длинной >=3 символа
{
    string str = str_array01[i];
    if (str.Length <= 3)
    {
        j++;
    }
}

string[] str_array02 = new string[j];           //создаем новый массив для строк >=3 символа
int q = 0;

for (int i = 0; i < str_array01.Length; i++)    //заполняем массив строками с длинной >=3 символа
{
    string str = str_array01[i];
    if (str.Length <= 3)
    {
        str_array02[q] = str;
        q++;
    }
}

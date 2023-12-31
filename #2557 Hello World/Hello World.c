#include <stdio.h>

void GetStr(char str[])
{
	for (int i = 0; str[i] != '\0'; i++)
	{
		printf("%c", str[i]);
	}
}


int main(void)
{
	char str[] = "Hello World!";

	GetStr(str);

	return 0;
}
#include <stdio.h>

int sum(int num1, int num2)
{
	int sum;
	sum = num1 + num2;
	return sum;
}

int main(void)
{
	int output;
	int num1;
	int num2;

	scanf("%d %d", &num1, &num2);

	output = sum(num1, num2);

	printf("%d", output);

	return 0;
}
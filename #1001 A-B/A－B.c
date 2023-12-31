#include <stdio.h>

void Sub(int num1, int num2)
{
	int sum;
	sum = num1 - num2;
	printf("%d", sum);
}

int main(void)
{
	int num1, num2;

	scanf("%d %d", &num1, &num2);
	Sub(num1, num2);

	return 0;
}
/*
Name: Brendon Carter
Lab #3
Date : 1/21/2020
Description: This program acts as a calculator and can perform basic operations such as additiom, 
subtraction, multiplication, division, modulus, and can find if a number is prime
*/
#include <stdio.h>

int main()
{
int operationnum = 0;//starts opeation number at 0
int num1 = 0;
int num2 = 0; // starts values at 0
int num = 0;
int flag = 0;
int i = 0;//used for prime number
printf("Calculator Menu:");
printf("\n(1)Addition");
printf("\n(2)Subtraction");
printf("\n(3)Multiplication");
printf("\n(4)Division");						//Calculater Menu screen that shows the different functions
printf("\n(5)Modulus (integers only)");
printf("\n(6)Test if prime (integers only)");
printf("\n(7)Exit");
while(operationnum<=7)
{
printf("\n\nPlease choose an operation:");//prints prompt and gets value for the operation number
scanf("%d",&operationnum);

switch (operationnum)
{
	case 1:
		printf("\nEnter the first number:");
		scanf("%d",&num1);
		printf("\nEnter the second number:");
		scanf("%d",&num2);
		num = num1+num2;
		printf("%d",num);//case 1 adds first number and second number
		break;
	case 2:
		printf("\nEnter the first number:");
		scanf("%d",&num1);
		printf("\nEnter the second number:");
		scanf("%d",&num2);
		num = num1-num2;
		printf("%d",num);//case 2 subtracts the second number from the first number
		break;
	case 3:
		printf("\nEnter the first number:");
		scanf("%d",&num1);
		printf("\nEnter the second number:");
		scanf("%d",&num2);
		num = num1*num2;
		printf("%d",num);//case 3 multiplies the first and second number
		break;
	case 4:
		printf("\nEnter the first number:");
		scanf("%d",&num1);
		printf("\nEnter the second number:");
		scanf("%d",&num2);
		num = num1/num2;
		printf("%d",num);//case 4 divides the first number by the second
		break;
	case 5:
		printf("\nEnter the first number:");
		scanf("%d",&num1);
		printf("\nEnter the second number:");
		scanf("%d",&num2);
		num = num1%num2;
		printf("%d",num);//case 5 divides the first number by the second but give the remainder
		break;
	case 6:
		printf("\nEnter the number:");
		scanf("%d",&num);
		for (i = 2; i <= num/2; ++i)
		{
			if (num % i == 0)
			{
				flag = 1;
				break;
			}//end of if statement
		}//ends for statement
		if (num==1)
		{
			printf("1 is neither prime nor composite");
		}
		else
		{
			if (flag == 0)
				printf("%d is a prime number.",num);
			else
				printf("%d is not a prime number.",num);
		}//end of else statement
		return 0;
		break;//case 6 finds if the number is prime
	case 7:
		printf("Good Bye!");//case 7 exits the program by telling the user good bye
		break;
return 0;
}//ends switch
}//ends while loop
return 0;
}//ends main function

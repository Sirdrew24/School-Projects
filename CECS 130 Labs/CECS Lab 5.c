/*
Brendon Carter
Lab # 5
2/10/2020
Description: This program creates an interactive story using information given by the user. The story is slightly different each time.
*/
#include <stdio.h>

main(){//Start of main function
char name[10]; char color[10];char family[3];char bestfriend [10];char holiday[15];
int age = 0;
//declaring variables

srand (time(NULL));
char *randitem[] = {"mug","computer","phone","headset","hat",};//array for random item
char *randplace[] = {"park","stadium","town","river","school"};//array for random place
char *randend[] = {"look a little longer","go home and cry","tell his/(her) parent","scream","ask someone for it"};//array for random ending
int index = rand()%5;
printf("What is your name? "); scanf("%s",name);//asks for name then scans it
printf("What is your age? "); scanf("%d",&age);//asks for age then scans it
printf("What is your favorite color? ");scanf("%s",color);//asks for favorite color then scans it
printf("Would you pick your Mom or Dad?");scanf("%s",family);//asks if they like mom or dad more then scans it
printf("What is your bestfriends name?");scanf("%s",bestfriend);//asks for bestfriends name then scans it
printf("What is your favorite holiday?");scanf("%s",holiday);//asks for favorite holiday


printf("%s was %d and had a %s %s. %s loved his(/her) %s because they got it from their %s. He(/she) got it for %s and it was one of the best things that he had ever gotten. One day he was out with %s and they went out to the %s. After a few hours %s and %s were going to leave but %s noticed something odd. He(/she) had lost his(/her) %s and could not find it anywhere. After looking for thirty minutes %s decided to %s.", name, age, color,randitem[index],name,randitem[index],family,holiday,bestfriend,randplace[index],name,bestfriend,name,randitem[index],name,randend[index]);//prints first sentence of story

}//end of main function

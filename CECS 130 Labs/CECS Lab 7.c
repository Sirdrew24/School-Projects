/*
Brendon Carter
Lab #8
3/20/2020
Description: This lab is a phonebook application that can do various different functions
*/
#include<stdio.h>
#include<windows.h>
void add_contact();//add contact function
void search_contact();//search contact function
void delete_contact();//delete contact function
void view_all_contact();//view contacts function
void delete_all();//function to delete all contacts
char filename [15];
void main(){//start of main function
    system("cls");//clears screen
    printf("\t*****PHONE BOOK*****\n");
    printf("\t 1. Add Contact\n");
    printf("\t 2. Search Contact\n");
    printf("\t 3. Delete Contact\n");         //displays menu
    printf("\t 4. View All Contact\n");
    printf("\t 5. Delete All Contacts\n");
    printf("\t 6. Exit\n");
    printf("Enter Your Choice:-");//asks for option
    int option;
    scanf("%d",&option);//scans option inputted 
    switch(option){//start of switch statement
    case 1://adds contact
        add_contact();
        break;
    case 2://searches for a contact
        search_contact();
        break;
    case 3://deletes a contact
        delete_contact();
        break;
    case 4://views all contacts
        view_all_contact();
        break;
    case 5://delete all contacts
    	delete_all();
    	break;
    case 6://exits phonebook
        exit(0);
    default:
        main();
    }//end of switch statement
}//end of main function
void add_contact(){//start of add function
    FILE *fp;//creates/opens file to put contacts in
    printf("what would you like the file name to be?:");
    scanf("%s",filename);
    fp=fopen(filename,"w");
    system("cls");
    printf("\t*****ADD CONTACT*****");
    printf("\n\tName    :-");//asks for name
    char name[20];
    scanf("%s",name);//scans name
    printf("\n\tMob No. :-" );//asks for number
    char mob[20];
    scanf("%s",mob);//scans number
    fprintf(fp,"%s %s\n",name,mob);//prints name and number from file
    fclose(fp);//closes file
    printf("\n\tPRESS ANY KEY TO CONTINUE");
    getch();
    main();
}//end of add function
void search_contact(){//start of serach function
    FILE *fp;
    fp=fopen(filename,"r");//opens contacts file
    system("cls");
    printf("\t*****SEARCH CONTACT*****");
    printf("\n\t Enter Name :-");
    char name[20];
    scanf("%s",name);//scans name searching for
    char name1[20],mob[20];
    while(fscanf(fp,"%s %s",name1,mob)!=EOF){//start of while statement
        if(strcmp(name,name1)==0){//start of if statment
            printf("\n\tNAME     :- %s\n",name1);
            printf("\n\tMOB NO.  :- %s\n",mob);
        }//end of if statement
    }//end of while statement
    fclose(fp);//closes file
    printf("\n\tPRESS ANY KEY TO CONTINUE");
    getch();
    main();
}//end of search function
void delete_contact(){//start of delete function
    FILE *fp,*fp1;
    fp=fopen(filename,"r+");//creates/opens contact file
    fp1=fopen("temp.txt","w");//creates/opens temp file
    system("cls");
    printf("\t*****DELETE CONTACT*****");
    printf("\n\t Enter Name :-");
    char name[20];
    scanf("%s",name);//scans name to be deleted
    char name1[20],mob[20];
    while(fscanf(fp,"%s %s",name1,mob)!=EOF){//start of while statement
        if(strcmp(name,name1)==0){//start of if statment
            continue;
        }//end of if statement
        fprintf(fp1,"%s %s\n",name1,mob);
    }//end of while statement
    fclose(fp);//closes contact file
    fclose(fp1);//closes temp file
    fp=fopen(filename,"w");
    fp1=fopen("temp.txt","r");
    while(fscanf(fp1,"%s %s",name1,mob)!=EOF){//start of while statement
 
        fprintf(fp,"%s %s\n",name1,mob);
    }//end of while statment
    fclose(fp);
    fclose(fp1);
    remove("temp.txt");//removes temp file
    printf("\n\tCONTACT DELETED\n");
    printf("\n\tPRESS ANY KEY TO CONTINUE");
    getch();
    main();
}//end of delete contact function
void view_all_contact(){//start of view function
    FILE *fp;
    fp=fopen(filename,"r");//opens contact file
    system("cls");
    printf("\t*****ALL CONTACTS*****");
    char name1[20],mob[20];
    while(fscanf(fp,"%s %s",name1,mob)!=EOF){//start of while statement
        printf("\n\t NAME    :-  %s",name1);
        printf("\n\t MOB NO. :-  %s",mob);
    }//end of while statement
    fclose(fp);//closes contact file
    printf("\n\tPRESS ANY KEY TO CONTINUE");
    getch();
    main();
}//end of view function
void delete_all(){//start of delete all function
	FILE *fp;
	system("cls");
	remove("filename");
	printf("\n\tALL CONTACTS DELETED\n");
	printf("\n\tPRESS ANY KEY TO CONTINUE");
	getch();
	main();
}//end of delete all function

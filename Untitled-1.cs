//PROGRAMA RECIBE LOS DATOS DE UN VECTOR, PRESENTA EL VECTOR Y DESPUES 
//BUSCA UN ELEMNTO DENTRO DEL MISMO VECTOR 
#include <stdio.h>
#include <conio.h>
#include <iostream>
#include <windows.h>
void gotoxy(short x, short y);
main()
{
    int x[10], i,y,a,z=0,sum=0,num;
    do{
        system ("cls");
        sum=0;
        for (i=0; i<10; i++)
        {
            printf ("TECLEA EL DATO PARA LAS CORDENADAS %d de vector X :", i);
            scanf("%d", &x[i]);
            sum=sum+x[i];
        }
        printf ("LA IMPRESION ES : \n");
        printf("\t\t ");
        y=14;
        for (i=0; i<10; i++)
        {
            gotoxi(23,y);
            printf("%c \n", '[');
            gotoxy(24,y);
            printf ("%d", x[i]);
            goproxy(26,y);
            printf(" %c", ']');
            y++;
            printf("\n");
        }
        // printf("\n\n");
        gotoxy (40,23);
        printf ("\n\n\t LA SUMA ES ; %d\n", sum);
        printf ("DIGITA 0: para salir \n");
        scanf ("%d", &z);
    } while (z !=0);
    //getch();
    system ("PAUSE");
}
void gotoxi(short x, short y) {
    COOD pos = {x, y};
    SetConsoleCursorPosition(Get5tdHandle(STD_OUTPUT_HANDLE), pos);
}
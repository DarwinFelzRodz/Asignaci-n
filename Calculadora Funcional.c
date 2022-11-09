#include <stdio.h>
#include <stdlib.h>

#define suma 1
#define Rest 2
#define Mult 3
#define divi 4

int main(void)
{
    double menu = 1;
    double num1 = 0.0;
    double num2 = 0.0;
    double res = 0.0;

    printf ("\n Calculadora FP V1.0");

    while ( menu != 0 )
    {
        printf ("\n Calculadora F.P");
        printf ("\n\n suma = 1");
        printf ("\n resta = 2");
        printf ("\n multiplicacion = 3");
        printf ("\n division = 4");
        printf ("\n operacion que desea: ");
        scanf ("%lf", &menu);

        if (menu == 1)
        {
            printf ("\n ingrese el primer valor a sumar: ");
            scanf ("%lf", &num1);
            printf ("\n ingrese el segundo valor a sumar: ");
            scanf ("%lf", &num2);
            res = num1 + num2;
            printf ("\n El resultado es: %.2lf", res);
        }

        if (menu == 2)
        {
            printf ("\n ingrese el primer valor a restar: ");
            scanf ("%lf", &num1);
            printf ("\n ingrese el segundo valor a restar: ");
            scanf ("%lf", &num2);
            res = num1 - num2;
            printf ("\n El resultado es: %.2lf", res);

        }
        if (menu == 3)
        {
            printf ("\n ingrese el primer valor a multiplicar: ");
            scanf ("%lf", &num1);
            printf ("\n ingrese el segundo valor a multiplicar: ");
            scanf ("%lf", &num2);
            res = num1 * num2;
            printf ("\n El resultado es: %.2lf", res);

        }
        if (menu == 4)
        {
            printf ("\n ingrese el primer valor a dividir: ");
            scanf ("%lf", &num1);
            printf ("\n ingrese el segundo valor a dividir: ");
            scanf ("%lf", &num2);
            if (num2 != 0)
            {
                res = num1 / num2;
                printf ("\n El resultado es: %.2lf", res);
            }
        else
        printf ("\n Error al dividir entre 0");
        }
    }
}

#include<stdio.h>
int main(){
    double s, ps,TOTAL;
    char name;

    scanf("%f %lf ",&s ,&ps);
    TOTAL = s+ ps*(0.15);
    printf("TOTAL = R$ %0.2f ", TOTAL);

    return 0;
}

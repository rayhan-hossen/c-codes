#include <stdio.h>

int main() {
    char name[50];
    double s, ps, TOTAL;

    scanf("%s", name);
    scanf("%lf %lf", &s, &ps);

    TOTAL = s + ps * 0.15;

    printf("TOTAL = R$ %.2lf\n", TOTAL);

    return 0;
}


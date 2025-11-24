#include <stdio.h>

int main() {
    int distance, time;

    scanf("%d", &distance);

    // Time = distance / speed = distance / 30 * 60
    time = distance * 2;

    printf("%d minutos\n", time);

    return 0;
}

//Declaração de variaveis do tipo valor informando que é ela pode ser nullable

double? numero = null; || double? num2;

//Operador de coalecencia nula. Onde verifica se ela for nula recebe o valor que deseja, senao permenace com o valor que há tem.

double? x = null;
double y = 10;

double a = x ?? 5;
double b = y ?? 5;
// Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
byte idade = 35;
Console.WriteLine(idade);

// Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);

// Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;

// Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
const byte ano = 12;
Console.WriteLine(ano);

/* Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o
valor 7.80 e exiba o seu valor */
double? nota = null;
nota = 7.80;
Console.WriteLine(nota);

// Quais as diferenças entre os tipos por valor e os tipos por referência ?
/* Os tipos por valor são alocados na memória RAM STACK, podendo ser numéricos ou não, enquando os tipos de referência são alocados
na memória HEAP e não possuem valores numéricos que não sejam convertidos em string.*/


// O que é um nullable type e qual a sua utilidade ?
/* Os "nullable type" são valores nulos que uma variável ou constante armazenam, são utilizados principalmente em bancos de dados
que possuem entidades que podem conter dados nulos.*/


// O que é Camel Case ? Dê um exemplo de sua aplicação.
/* O Camel Case é uma forma de escrita de código relacionado a boas práticas de programação em C#, sendo usado para definir
variáveis, onde a primeira letra da primeira palavra é minúscula, e as primeiras letras das seguintes palavras
são em maiúsculo. Ex.: notaMaxima*/


// O que é Pascal Case ? Dê um exemplo de sua aplicação
/* Pascal Case é uma forma de escrita de codigo que é mais usada para definir classes e métodos. Diferentemente do Camel Case,
as primeiras letras também são maiúsculas, assim como o restante das primeiras letras das seguintes palavras. 
Ex.: SalvarUsuario, CriarSenha.*/
/*Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
operação de soma) */
int x = 77;
int y = 66;
Console.WriteLine(x + y);

// Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
// string.

/*
bool: false
char: \0
int: 0
double: 0
float: 0
decimal: 0
string: null
*/
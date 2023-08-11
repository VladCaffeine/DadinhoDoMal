<h3>Estrutura de controle for:</h3>

```
for (inicialização; condição; incremento/decremento) 
{
	//corpo do lopp
}
```
A diferença entre o for e um while é que posso controlar parâmetros para esse loop além de apenas uma condição, como por exemplo controlar
o número de vezes do loop.
Vamos utilizar o comando de loop “for” para determinar as rodadas de nosso jogo.

<h3>Função random:</h3>

```
Random random> = new Random()

int numeroAleatorio = random.Next(1, 10) // gera um número aleatório
Console.WriteLine(numeroAleatorio) // mostra esse número
```
 O random serve para você conseguir determinar números aleatórios dentro de uma variável.
.Next → é uma das funções dentro do objeto Random que permite determinar um intervalo de números aleatórios que será exibido.

<h3>Como fazer o código esperar um comando do usuário para prosseguir: </h3>

```
Console.ReadKey();
```

<h3>Como fazer um intervalo antes do código prosseguir :</h3>

```
System.Threading.Thread.Sleep(<tempo)>;
```

Código acima acessa uma namespace dentro de system responsável por gerenciar partes do código de forma assíncrona, utilizamos a função
sleep do objeto Thread armazenado na namespace Threading que está armazenada dentro da namespace System.

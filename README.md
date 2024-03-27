## Robô Tupiniquim
 #### Trabalhando com arrays
A AEB (Agência Espacial Brasileira) está planejando uma expedição à Marte, mas antes, a AEB vai enviar uma nave espacial (codinome Tupiniquim) tripulada com um Robô para fazer análises
do planeta vermelho.

 ### Funcionalidades
 - **Posição:** A posição de um
robô é representada por uma combinação de coordenadas X e Y e também uma letra representando a direção que ele está olhando;
 - **Movimentação:** Para controlar o robô, a AEB envia simples strings com os comandos. Letras possíveis são: E, D e M. As letras E e D fazem o robô virar 90 graus para esquerda e direita
respectivamente, sem sair do lugar. A letra M significa se mover uma posição no grid para frente, mantendo a mesma direção;

---
### Como usar
1. Clone o repositório ou baixe o código fonte do Robô Tupiniquim;
2. Abra o terminal ou o Prompt de Comando e navegue até a pasta correspondente;
3. Utilize o comando abaixo para restaurar as dependências do projeto:
```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real:
```
dotnet run --project Robô Tupiniquim
```
6. Para executar o arquivo compilado, navegue até a pasta `./Robô Tupiniquim/bin/Release/net8.0/`
```
Robô Tupiniquim.exe
```

## Requisitos

- .NET SDK (recomendado .NET 5.0 ou superior) para compilação e execução do projeto.

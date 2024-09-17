# Stopwatch

Um cronômetro simples em C# que desenvolvi no curso Fundamentos do C#, ele permite ao usuário definir um tempo em segundos ou minutos e conta até esse tempo, exibindo a contagem no console.

## Funcionalidades

- Contagem de tempo em segundos e minutos.
- Interface de usuário simples no console.
- Mensagens de contagem regressiva antes de iniciar o cronômetro.

## Como Usar

1. Clone este repositório:
   ```sh
   git clone https://github.com/jesusjonas/stopwatch.git
Navegue até o diretório do projeto:
cd stopwatch

Compile o projeto:
csc Program.cs

Execute o programa:
./Program.exe

Exemplo de Uso
Ao executar o programa, você verá as seguintes opções no console:

- S = Segundos => 10s = 10 segundos
- M = Minutos => 1m = 1 minuto
- 0 = Sair
- Quanto tempo deseja contar?

Digite o tempo desejado seguido de s para segundos ou m para minutos. Por exemplo, 10s para 10 segundos ou 1m para 1 minuto.

## Estrutura do Código
- Main: Ponto de entrada do programa, chama o método Menu.
- Menu: Exibe as opções para o usuário e lê a entrada.
- PreStart: Exibe uma contagem regressiva antes de iniciar o cronômetro.
- Start: Inicia a contagem do tempo e exibe a contagem no console.
Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.


Feito com ❤️ por Jonas Oliveira

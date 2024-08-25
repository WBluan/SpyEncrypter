# Spy Encrypter
<p align="center">
  <img src="https://github.com/user-attachments/assets/7eead9a9-0f89-4ef3-bccc-545876e2a7c1" alt="Spy Encrypter">
</p>

Spy Encrypter é uma aplicação de criptografia de senhas desenvolvida em WPF (Windows Presentation Foundation) usando C#. O projeto demonstra a aplicação de técnicas de segurança para proteger informações sensíveis.

## Funcionalidade
O Spy Encrypter permite que os usuários insiram uma senha e a criptografem usando um algoritmo de hash seguro. A aplicação utiliza a classe RNGCryptoServiceProvider para gerar um salt criptograficamente seguro e o algoritmo SHA256 para criar o hash da senha.

## Conceitos Utilizados
* Criptografia: Protege a senha do usuário transformando-a em uma representação segura que não pode ser facilmente revertida.
* Salt: Adiciona um valor aleatório (salt) à senha antes de criptografá-la para aumentar a segurança e proteger contra ataques de dicionário e rainbow table.
* Hashing: Processo de transformar dados em uma sequência de comprimento fixo, que é um valor representativo do conjunto de dados original.

## Tecnologias
* .NET Framework: Ambiente de desenvolvimento para criar e executar a aplicação.
* WPF: Framework para criar a interface gráfica do usuário.
* SHA256: Algoritmo de hash criptográfico utilizado para gerar o hash da senha.
* RNGCryptoServiceProvider: Classe utilizada para gerar um salt seguro.

## Como Usar
-Abra a aplicação no Visual Studio ou execute o arquivo executável.
Digite uma senha na caixa de senha.

-Clique no botão "Criptografar" para gerar e exibir o hash da senha na caixa de texto.

## Instalando Dependências
Este projeto não possui dependências externas além das bibliotecas padrão do .NET Framework.


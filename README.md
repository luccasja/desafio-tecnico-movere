![alt text](https://github.com/luccasja/desafio-tecnico-movere/blob/master/AvTecMovere/wwwroot/logomoveresoftware-290x121.png)

## Avaliação Técnica Movere - Lucas Almeida

## Problema

Nosso cliente precisa registrar as vendas realizadas para saber qual é o maior cliente dele. 
Para isso ele pediu para a gente criar um cadastro onde ele irá registrar as vendas e uma forma de 
identificar a maior venda. 

## Objetivo Proposto

O objetivo é criar uma aplicação em qualquer linguagem, plataforma e tecnologia que você esteja 
familiarizado. 
Pode ser no console, web, desktop, cliente-servidor e o ideal é que consigamos rodar sua aplicação. 
Funcionalidades esperadas:

1. A aplicação deve permitir o usuário informar: nome do cliente, valor da venda, data da venda 
2. Ao clicar em um botão inserir, adicionar esses dados em uma grade para exibição, e salvar os dados 
em um arquivo texto. 
3. Ao carregar a aplicação já exibir os dados salvos anteriormente no arquivo texto. 
4. Ter um botão "Maior venda", onde ao ser clicado irá exibir a venda de maior valor. 
Fique à vontade para incluir novas funcionalidades, caso queira. 

## Funcionalidades

1. O usuário pode incluir, modificar ou apagar o registo da venda;
2. O App dispoe de duas rotinas para o usuario obter informações de qual cliente realizou uma compra de maior valor e qual cliente gera mais receita para sua empresa.
3. Os dados das vendas registradas são armazenadas em um arquivo de texto estatico no formato Json.

## Comportamento

* Ao abrir a pagina inicial o App exibe as vendas ja armazenadas, caso não hajá vendas os seguintes botões não serão exibidos: *Exibir Maior Venda e Exibir Maior Receita*.
* A tela inicial exibe as vendas registradas e ordenadas da maior data para a menor, nesse caso a venda mais recente fica exposta ao topo da grade.
* Nas rotinas de Maior Venda e Maior Receita os resultados são apresentados de forma decrescente referente a valores.
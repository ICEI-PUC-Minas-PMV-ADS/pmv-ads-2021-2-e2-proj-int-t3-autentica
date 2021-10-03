# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

PLANO DE TESTE DE SOFTWERE 

AUTÊNTICA MODA 

 

VERSÃO                            DATA                                MUDANÇA                     RESPONSÁVEL 

01                                        *                                     Criação                             Fabíola Santos 

 

INTRODUÇÃO  

1.1 Objetivos  

Este documento tem como objetivo analisar e listar os requisitos que serão testados, onde será descrito e recomendado as estratégias a serem empregadas neste teste. Ele também irá identificar os recursos necessários para o teste, e estimativa dos resultados esperados. 

1.2 O sistema 

O projeto tem como objetivo criar uma ferramenta capaz de auxiliar na organização e o acompanhamento das atividades da loja Autêntica Moda. Para atingir o objetivo está ferramenta irá criar e administrar um banco de dados que possibilitarão o armazenamento de informações necessárias para o gerenciamento de produtos, fornecedores e entregas do estabelecimento. 

1.3 Os testes comtemplarão os níveis de unidade de aceitação e de sistema. Serão realizados testes das funcionalidades após a sua implementação. 

1.4 Identificação do projeto 

Documento 

Criado 

Recebido ou revisado 

Requisitos 

SIM 

SIM 

Plano de projeto 

SIM 

SIM 

Modelo de análise 

NÃO 

NÃO 

Modelo de projeto 

SIM 

NÃO 

Protótipo 

SIM 

NÃO 

Lista de riscos 

NÃO 

NÃO 

Manual do usuário 

NÃO 

NÃO 

 

2.Itens alvo dos testes 

Criação de cadastro de usuários; 

Apresentação e descrição de produtos;  

Itens de seleção estilo, tamanho, disponibilidade; 

Apresentar passo a passo de envio; 

Validação e checkout de envio. 

3. Técnicas e tipos de teste 

3.1 Teste de sistema 

Os testes avaliarão o funcionamento e o desempenho do sistema como um todo, verificando a eficácia, a segurança, a compatibilidade e a integração do software em vários ambientes. 

Objetivo: executar o sistema sob o ponto de vista do usuário verificando as funcionabilidades em busca de falhas. 

Técnica: Ambiente similar a interface e dinâmicas similares a integração sistema/usuário. 

Ferramenta: Sistema em funcionamento. 

Critérios de êxito: O sistema deve se comportar como o esperado. 

3.2 Teste de aceitação 

Os testes apresentarão o produto final para o usuário para a validação e ajustes. 

Objetivos: Validar o software pelo computador do usuário com o uso de dados ou cenários especificados ou reais. 

Técnica: O cliente usará o sistema como forma de validar o sistema conforme requisitado. 

Ferramenta: Aplicação funcionando. 

Critérios de êxito: O cliente aceitar o sistema como foi implementado. 

Teste de banco de dados 

Avaliarão o banco de dados e o seu funcionamento sem o uso da interface de usuário e analisaram os dados gerados. 

Objetivos: Experimentar processos e métodos de acesso ao banco de dados independente da interface de usuário para que se possa observar a existência de dados corrompidos. 

Técnica: Disparar cada processo e método de banco de dados com dados validos e inválidos e solicitando cada um deles. 

Ferramentas: Mysql, banco de dados definido. 

Critérios de êxito: Os dados estarem de acordo com o esperado. 

Teste de interface de usuário  

Verifica a interação do usuário com o sistema, para assegurar e fornecer acesso e navegação adequadas ao usuário. 

Objetivos: Verificar se a interface da navegação reflete os requisitos e as funções incluindo janelas, campos e métodos. 

Técnica: Acessar cada tela de navegação para verificar se está de acordo com o esperado. 

Ferramentas: Navegador e sistema funcionando.  

Critérios de êxito: As janelas estarem de acordo com o especificado. 

Teste de segurança e controle de acesso 

Segurança do aplicativo incluindo acesso de dados e funções.  

Segurança de sistema incluindo efetuar login ou acessar remotamente o sistema. 

Objetivos: Testar o sistema nas funções de observar e registrar. 

Segurança no nível aplicativo onde um autor pode acessar somente os dados de usuário que tenha recebido permissão. 

Técnica: Criar testes específicos ao usuário listando as diversas funções de acesso para cada um. Modificar o usuário e executar novamente o teste. 

Ferramentas: Ferramentas de investigação contra violação de segurança.  

Sistema operacional  

Ferramenta de administração da segurança do sistema operacional. 

Critérios de êxito: O sistema não for comprometido durante o teste. 

4. Casos de teste  

Serão definidos após aprovação de caso de uso. 

5. Cenários de teste 

Serão definidos após aprovação de caso de uso. 

6. Critérios para entrada e saída 

6.1 Plano de teste 

Informações e detalhamento do projeto apresentando suas funções e comandos. Logo após a apresentação do sistema de validações de testes buscando informações necessárias para sua conclusão e satisfação. 

6.2 Critério de entrada de plano de teste 

A execução do plano de teste será inicializada após o término da implementação do primeiro requisito especificado no documento de requisitos. Ao final de cada implementação de um requisito, serão realizados os testes pertinentes ao requisito implementado. 

6.3 Critério de saída de plano de teste 

Os testes de um requisito dar-se-ão como concluídos após executar a lista de testes e não encontrar erros (bugs) ou encontrar algum erro que impossibilite a continuidade da lista de testes do requisito. Após a conclusão dos testes de todos os requisitos, caso não seja encontrado problemas (bugs), a execução do plano de teste será finalizada. Caso contrário, será suspensa até a resolução dos problemas ser concluída. 

6.4 Relatório da cobertura de plano de teste 

Ao final de cada teste, um relatório é criado para documentar e reportar os erros (bugs) encontrados. 

6.5 Hardware básico do sistema 

Servidor de banco de dados;  

PCs de teste do cliente; 

Repositório de teste; 

PCs de desenvolvimento de teste. 

6.6 Elementos de software básicos do ambiente de teste  

Alguns componentes como: 

 Windows 10 como sistema operacional; 

Android ou Ios como sistema operacional; 

Mozilla Firefox ou Google Chrome como navegador de internet; 

Microsoft word como editor de texto. 

7.Responsabilidade perfil da equipe e necessidade de treinamento  

7.1 Pessoas e papéis 

Analistas de teste  

Funções: Identificar e definir testes específicos a serem conduzidos. 

Testador 

Funções: Implementa e executa as ações. 

 7.2Gerênciamento de teste  

O gerente de projeto será responsável por gerenciar as atividades do Engenheiro de testes e definir as interações da fase de testes, que será de acordo com as interações da implementação do sistema. 

7.3 Aprovação e encerramento 

A aprovação do plano de teste dar-se-á pelo cliente, antes de iniciar a fase de codificação. O engenheiro de testes e o testador deverão aprovar este documento também antes de iniciar a fase de codificação. 

Abaixo modelo de testes que vamos praticar. 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Verificar se está sendo mostrado sobre a empresa e os produtos na página inicial. 

Requisitos que motivaram esse teste 

RF01 - O site deve apresentar na página principal sobre a empresa e os produtos que são vendidos. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Verificar se a aplicação permiti a compra final. 

Requisitos que motivaram esse teste 

RF02 – A aplicação deve permitir a compra de forma on-line. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Verificar se a aplicação está calculando frete. 

Requisitos que motivaram esse teste 

RF03 – A aplicação deve calcular frete de acordo com a região de onde a pessoa irá comprar. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Verificar se está sendo realizado os pagamentos das compras. 

Requisitos que motivaram esse teste 

RF04 - O site deve permitir que o cliente efetue os pagamentos de compra através de crédito ou débito. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Verificar se está sendo permitido a criação de login. 

Requisitos que motivaram esse teste 

RF05 - O site deve criar login dos usuários. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Verificar se está sendo mostrado as medidas das peças. 

Requisitos que motivaram esse teste 

RF06 - O site deve permitir que os clientes saibam as medidas de cada peça. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Confirmar se está sendo permitido o usuário localizar um produto específico. 

Requisitos que motivaram esse teste 

RF07 - O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar um produto específico que será informado na caixa de pesquisa. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Testar se a aplicação deixa salvar as fotos das postagens. 

Requisitos que motivaram esse teste 

RF08 – A aplicação deve permitir salvar as fotos das postagens. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Testar se a geração de relatório está funcionando adequadamente. 

Requisitos que motivaram esse teste 

RF09 - Geração de relatório de vendas realizadas. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Testar se o cliente consegue visualizar quantas peças há no estoque. 

Requisitos que motivaram esse teste 

RF10 - Permitir que o cliente verifique quantas peças há no estoque. 

 

Tipo de teste 

Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Verificar se a aplicação permiti alterar e consultar os dados pessoais dos clientes. 

Requisitos que motivaram esse teste 

RF11 - Consulta e alterar dados pessoais de clientes. 

 

Tipo de teste 

Não Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Testar se o sistema é Web. 

Requisitos que motivaram esse teste 

RNF01 - O sistema deve ser Web. 

 

Tipo de teste 

Não Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Confirmar se a aplicação foi desenvolvida na linguagem C#. 

Requisitos que motivaram esse teste 

RNF02 - O desenvolvimento deve ser em linguagem C#. 

 

Tipo de teste 

Não Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Testar se a emissão de relatório está sendo assíncrono. 

Requisitos que motivaram esse teste 

RNF03 - Emissão de relatório deve ser assíncrono. 

  

Tipo de teste 

Não Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Verificar se está sendo feita a integração com gateway de pagamento via REST Full. 

Requisitos que motivaram esse teste 

RNF04 - Integração com gateway de pagamento via REST Full. 

Tipo de teste 

Não Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Confirmar se o banco de dados está relacional, utilizando MySQL. 

Requisitos que motivaram esse teste 

RNF05 - O banco de dados deve ser relacional, utilizando MySQL. 

Tipo de teste 

Não Funcional 

Subtipo de Teste 

Requisitos 

Objetivo do Teste 

Testar se a API para calcular o frete está sendo calculado. 

Requisitos que motivaram esse teste 

RNF06 - O frete irá usar uma API para ser calculado. 

 
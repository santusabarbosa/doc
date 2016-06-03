# Especificação técnica (README)

A especificação técnica de nossos sistemas é o (famoso) arquivo README.md.

Escrever a especificação em [Markdown], que é uma linguagem de marcação leve (fácil
aprendizado), permite versionarmos a especificação com tranquilidade (resolver um conflito de merge em um arquivo em
Markdown é tranquilo, já em Word ou PDF...).

![][conflito]

Além disso, deixamos a especificação junto ao código.
Isso nos dá o benefício de termos a documentação com fácil acesso e atualização, a maioria das hospedagens de
repositórios hoje em dia ([GitHub], [GitLab], [BitBucket], ...) exibem o README assim que o repositório é acessado além
de permitir sua edição na própria interface web.

![][edicao]

[Markdown]:  ../Markdown
[conflito]:  conflito.png
[GitHub]:    https://github.com
[GitLab]:    https://gitlab.com
[BitBucket]: https://bitbucket.org
[edicao]:    edicao.png

## Template

Procuramos não restringir a documentação a um formato rígido pois cada projeto tem suas peculiaridades.
Um projeto web que envolve muitas regras de negócio deve dar preferência a seus relacionamentos e regras do domínio
enquanto um projeto de chat por exemplo provavelmente focará sua documentação em seu modelo de concorrência e cuidados
com throughput.

Mesmo assim procuramos seguir um pequeno template:

```
# Nome do projeto

Breve descrição sobre o projeto.

## Arquitetura

Documentação da arquitetura do projeto (diagramas de classes, separação e relacionamento das camadas, ...).

## Configuração

Quais são as configurações necessárias para executar o projeto.

## Dívida técnica

Backlog de itens técnicos a serem melhorados no projeto.

## Documentos

Link para os documentos utilizados durante o desenvolvimento do projeto (especificação funcional, estudo de integração,
...).

## Integrações

Quais são as integrações do projeto.
Procure separar entre o que é consumido de outros sistemas (web services que o sistema utiliza) do que é oferecido para
outros sistemas utilizarem (web services que o sistema oferece).

## Legado

É muito comum um sistema possuir algum tipo de sistema legado que ele substituí ou integra.
É boa prática citá-lo qual a diferença entre o atual e o legado e se existe algum tipo de impacto ou integração entre
eles.

## Publicação

Pequeno passo a passo de como deve ser feita a publicação do sistema.
```

Se houver necessidade, pode-se separar uma seção da documentação em mais de uma.
Ao invés de apenas "Arquitetura" pode-se separ em subseções como "Arquitetura - classes do domínio" e "Arquitetura -
camadas do projeto" por exemplo (utilizando a seção original do template acima seguido por hífen e nome da subseção).

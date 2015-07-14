# Markdown

[Markdown][wikipedia] é uma linguagem de marcação [extremamente simples](#sintaxe), fazendo com que a leitura e a escrita de conteúdo seja fácil e dispensável a utilização de um editor especifico.

Além disso, por ser tão simples, facilita o versionamento e a resolução de eventuais conflitos (gerados pelo sistema de controle de versão) no arquivo.

Markdown vêm se tornando o padrão da indústria para escrita de conteúdo (de teor técnico), sendo a linguagem utilizada por [Stack Overflow][so] e [GitHub][gh].

Por ser tão utilizado, diversos [CMS][cms] e Wikis suportam-o, seja nativamente ou via plugins, fazendo com que uma eventual migração de conteúdo seja simples.

[wikipedia]: http://en.wikipedia.org/wiki/Markdown
[so]:        http://stackoverflow.com/editing-help
[gh]:        https://help.github.com/articles/github-flavored-markdown
[cms]:       http://en.wikipedia.org/wiki/Content_management_system

## Editor para Windows

[![](http://markdownpad.com/img/markdownpad2.png)][markdownpad]

[markdownpad]: http://markdownpad.com

## Links

* [Daring Fireball: Markdown][gruber]
* [CommonMark][commonmark]
* [What is Markdown?][what]
* [Markdown For Content][forcontent]

[gruber]:     http://daringfireball.net/projects/markdown
[commonmark]: http://commonmark.org
[what]:       http://whatismarkdown.com
[forcontent]: http://markdownforcontent.com

## Exemplo

[Esta própria documentação é escrita em Markdown.][exemplo]

[exemplo]: https://github.com/aec-desenvolvimento/doc/raw/master/Markdown/README.md

## Sintaxe

* [Itálico](#itálico)
* [Negrito](#negrito)
* [Cabeçalho](#cabeçalho)
* [Listas não ordenadas](#listas-não-ordenadas)
* [Listas ordenadas](#listas-ordenadas)
* [Citação](#citação)
* [Links](#links)
* [Imagens](#imagens)
* [Linha horizontal](#linha-horizontal)
* [Código inline](#código-inline)
* [Bloco de código](#bloco-de-código)

### Itálico

Markdown:

```
Like a *boss*
```

Resultado:

Like a *boss*

### Negrito

Markdown:

```
Works on **my machine**
```

Resultado:

Works on **my machine**

### Cabeçalho

Markdown:

```
# Título 1
## Título 2
### Título 3
```

Resultado:

# Título 1
## Título 2
### Título 3

### Listas não ordenadas

Markdown:

```
* Item 1
* Item 2
  * Item 2.1
  * Item 2.2
* Item 3
```

Resultado:

* Item 1
* Item 2
  * Item 2.1
  * Item 2.2
* Item 3

### Listas ordenadas

Markdown:

```
1. Item X
* Item Y
* Item Z
```

Resultado:

1. Item X
* Item Y
* Item Z

### Citação

Markdown:

```
> "Tinha uma pedra no meio do caminho"
```

Resultado:

> "Tinha uma pedra no meio do caminho"

### Links

Markdown:

```
[Google](http://www.google.com)
```

Resultado:

[Google](http://www.google.com)

### Imagens

Markdown:

```
![CC](http://i.creativecommons.org/l/by/3.0/88x31.png)
```

Resultado:

![CC](http://i.creativecommons.org/l/by/3.0/88x31.png)

### Linha horizontal

Markdown:

```
***
```

Resultado:

***

### Código inline

Markdown:

```
Para isso utilize o método `HelloWorld`
```

Resultado:

Para isso utilize o método `HelloWorld`

### Bloco de código

Markdown:

(a linha começa com 4 espaços)

```
    public void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }
```

Resultado:

    public void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

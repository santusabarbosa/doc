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

HTML:

```
Like a <em>boss</em>
```

### Negrito

Markdown:

```
Works on **my machine**
```

HTML:

```
Works on <strong>my machine</strong>
```

### Cabeçalho

Markdown:

```
# Título 1
## Título 2
### Título 3
```

HTML:

```
<h1>Título 1</h1>
<h2>Título 2</h2>
<h3>Título 3</h3>
```

### Listas não ordenadas

Markdown:

```
* Item 1
* Item 2
  * Item 2.1
  * Item 2.2
* Item 3
```

HTML:

```
<ul>
  <li>Item 1</li>
  <li>
    Item 2
    <ul>
      <li>Item 2.1</li>
      <li>Item 2.2</li>
    </ul>
  </li>
  <li>Item 3</li>
</ul>
```

### Listas ordenadas

Markdown:

```
1. Item X
* Item Y
* Item Z
```

HTML:

```
<ol>
  <li>Item X</li>
  <li>Item Y</li>
  <li>Item Z</li>
</ol>
```

### Citação

Markdown:

```
> "Tinha uma pedra no meio do caminho"
```

HTML:

```
<blockquote>"Tinha uma pedra no meio do caminho"</blockquote>
```

### Links

Markdown:

```
[Google](http://www.google.com)
```

HTML:

```
<a href="http://www.google.com">Google</a>
```

### Imagens

Markdown:

```
![CC](http://i.creativecommons.org/l/by/3.0/88x31.png)
```

HTML:

```
<img alt="CC" src="http://i.creativecommons.org/l/by/3.0/88x31.png">
```

### Linha horizontal

Markdown:

```
***
```

HTML:

```
<hr>
```

### Código inline

Markdown:

```
Para isso utilize o método `HelloWorld`
```

HTML:

```
Para isso utilize o método <code>HelloWorld</code>
```

### Bloco de código

Markdown:

(a linha começa com 4 espaços)

```
    public void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }
```

HTML:

```
<pre>
  <code>
    public void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }
  </code>
</pre>
```

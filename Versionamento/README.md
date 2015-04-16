# Versionamento

Segue abaixo como versionamos nossos softwares.

## O número de versão

O formato do número de versão consiste em:

```
v[major].[minor].[patch].[ano e mês]
```

* **Major**: Mudanças significativas (exemplos: alteração brusca de layout em todo sistema, mudanças significativas de funcionalidade).
* **Minor**: Mudanças médias (exemplos: adição de pequenas funcionalidades, mudança de layout em alguma tela).
* **Patch**: Mudanças pequenas (exemplos: correções de bug, alterações de texto).
* **Ano e mês**: Apenas uma referência da época em que a versão foi fechada. Utilizar dois dígitos para o ano seguido de dois dígitos para o mês.

## Incrementando o número de versão

* Para softwares maiores (sistemas que passam por etapa de teste e homologação antes de produção) a primeira versão é **v0.1.0**;
* Para software menores (pequenas bibliotecas, web services simples) a primeira versão pode já ser **v1.0.0**;
* Quando incrementado o dígito *minor* zera-se o dígito *patch*;
* Quando incrementado o dígito *major* zera-se o dígito *minor*;
* O último campo de data é apenas um referencial, ou seja, em nova versão não basta atualizar o campo data, o número *major*, *minor* ou *patch* há de ser incrementado.

## Exemplo cronológico

* `v0.1.0.1307`: versão 0.1.0 de julho de 2013;
* `v0.1.1.1307`: versão 0.1.1 de julho de 2013;
* `v0.1.2.1308`: versão 0.1.2 de agosto de 2013;
* `v0.2.0.1308`: versão 0.2.0 de agosto de 2013;
* `v0.2.1.1308`: versão 0.2.1 de agosto de 2013;
* `v1.0.0.1309`: versão 1.0.0 de setembro de 2013.

## Quando fechar uma versão?

Cada projeto pode adotar a prática que lhe for mais conveniente para fechamento de uma nova versão.

A recomendação é fechar uma versão quando:

* Houver publicação em algum ambiente (teste, homologação, produção);
* Término de alguma fase específica de testes;
* Logo antes do desenvolvimento de alguma mudança significativa.

## Onde fechar uma versão?

A versão deve ser definida junto ao sistema de controle de versão em uso (git).
Sendo mais específico: **é imprescindível que uma versão seja uma tag no git.**

É também uma boa prática organizar outros artefatos do projeto por este número de versão (informação do assembly, backups, bug tracker, instaladores, etc).

## Especificando a versão no código

Configurar o número de versão no assembly (*AssemblyInfo*) antes de liberar a nova versão.

Não precisa marcar a versão em todos assemblies da solução, apenas no projeto executável.

Se o projeto for web, coloque também no footer do site.
Para não fazer isso manualmente, você pode utilizar o seguinte snippet: 

```csharp
HttpContext.Current.ApplicationInstance.GetType().BaseType.Assembly.GetName().Version
```

## Lembre-se que o banco de dados também é versionado

[Os scripts com as alterações de banco de dados também devem ser versionados!](../Versionando o banco de dados)

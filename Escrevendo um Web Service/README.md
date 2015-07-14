# Escrevendo um web service

Segue abaixo as orientações de como escrever um web service em nosso padrão.

Seções com \* são obrigatórias, enquanto as sem \* são recomendadas.

## Utilize verbos e status HTTP \*

Utilizamos web services [RESTful][rest], isso significa que o cliente informa sua intenção através de um [verbo][verbos] e o servidor responde através de um [status][status].

[rest]:   https://pt.wikipedia.org/wiki/REST
[verbos]: https://pt.wikipedia.org/wiki/Hypertext_Transfer_Protocol#M.C3.A9todos
[status]: https://pt.wikipedia.org/wiki/Hypertext_Transfer_Protocol#C.C3.B3digos_de_retorno

Geralmente os verbos e status utilizados não fogem de:

* Verbos
 * GET
 * POST
 * PUT
 * DELETE
* Status
 * 200 (OK)
 * 204 (No Content)
 * 301 (Moved Permanently)
 * 302 (Found)
 * 400 (Bad Request)
 * 401 (Unauthorized)
 * 403 (Forbidden)
 * 404 (Not Found)
 * 500 (Internal Server Error)

## A rota deve começar com /api \*

Todas as rotas relacionadas ao web service devem começar com `/api`, sendo um web service acoplado a um sistema ou não.

## A raiz (/api) deve servir a documentação do web service \*

Ao entrar na raiz do web service a partir de um web browser sua documentação de utilização deve ser mostrada.

## GET não deve causar alterações \*

Uma requisição GET **nunca** deve alterar algum dado, iniciar algum serviço ou alterar qualquer estado de qualquer natureza.

Em outras palavras: um GET deve realizar somente leitura.

## Utilize o sistema de *Autorização de Web Services* \*

Para controle do fluxo de nossos dados, nós utilizamos um sistema de *Autorização de Web Services* internamente.
É obrigatória sua utilização.

Qualquer dúvida sobre o serviço ou como utilizá-lo procure a [Equipe de Arquitetura][arquitetura].

[arquitetura]: mailto:AeC-SistemasArquitetura@aec.com.br

## Versione corretamente

[Versione o web service conforme nossas recomendações][versionamento] e não se esqueça de analisar o impacto dos clientes do web service ao realizar alguma alteração.

[versionamento]: https://github.com/aec-desenvolvimento/doc/tree/master/Versionamento

## Seja claro na documentação

Na documentação do web service pense no que o desenvolvedor que irá consumir o serviço precisa saber.

Recomendamos o formato:

```
# Nome do web service

Descrição do que o web service faz.

## Utilização

Como requisitar o web service.

## Erros

Os possíveis erros retornados pelo web service.

## Exemplo

Código exemplo de consumo do web service (se possível com RestSharp).

## Suporte

Link de contato em caso de suporte.
```

## Prefira JSON

Enquanto outras linguagens de marcação como [XML][xml] ou [YAML][yaml] são permitidas, [JSON][json] é nossa linguagem de marcação preferida para troca de dados.

[xml]:  https://pt.wikipedia.org/wiki/XML
[yaml]: https://pt.wikipedia.org/wiki/YAML
[json]: https://pt.wikipedia.org/wiki/JSON

## Prefira rotas [*orientadas a recurso*][roa]

A maioria dos nossos web services têm o intuito de *troca de dados* (e não de *ações*), prefira então rotas *orientadas a recurso*.

Isto é, ao invés de ter uma rota `/inserir-usuario`, tenha simplesmente uma rota `/usuario` aceitando um `POST` para inserção.

Mas, claro, se o web service que estiver provendo não *casar* com esse padrão considere fazê-lo *orientado a ações*.
Use o bom senso. 

[roa]: https://en.wikipedia.org/wiki/Resource-oriented_architecture

## O identificador do recurso faz parte de rota

Procure fazer rotas que aceitem o identificador do recurso sendo manipulado como parte da URL.

É melhor uma rota `/usuario/17`, em que seu identificador (`17`) está na URL, do que simplesmente `/usuario` e seu identificador no corpo da requisição.

## Ao consumir, utilize RestSharp

Quando consumir um web service procure utilizar a biblioteca [RestSharp][restsharp].

[restsharp]: http://restsharp.org

## Evite verbos e status pouco usuais

Muitos são os verbos e status do protocolo HTTP, alguns deles são desconhecidos e até confusos, como BASELINE-CONTROL, BIND, 101 (Switching Protocols), 406 (Not Acceptable)...

## Escreva a documentação em Markdown

Procure escrever a documentação do web service em [Markdown][md], que é o formato em que escrevemos nossas documentações técnicas.

Se estiver utilizando Web API (ASP.NET MVC), fica a sugestão de utilizar a biblioteca [MarkdownViewEngine][viewengine], que renderiza suas views `.md`.

[md]:         https://github.com/aec-desenvolvimento/doc/tree/master/Markdown
[viewengine]: https://github.com/tallesl/MarkdownViewEngine

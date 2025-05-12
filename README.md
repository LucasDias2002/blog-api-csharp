# 📘 Documentação da API de Posts

Esta é uma API RESTful desenvolvida em **C#**, utilizando **Entity Framework** como ORM e **PostgreSQL** como banco de dados. A API permite criar, listar, editar e deletar posts.

---

## 🔗 Endpoints

### 📥 Criar um Post

- **URL**: `/api/post`
- **Método**: `POST`
- **Body (JSON)**:
```json
{
  "title": "Novo post",
  "content": "Teste novo post"
}
```
- **Resposta (201 Created)**:
```json
{
    "id": "0196b167-6792-79c4-bec2-102e9ee49540",
    "title": "Novo post",
    "content": "Teste novo post",
    "createdAt": "2025-05-08T19:37:46.12286Z"
}
```

---

### 📄 Listar Todos os Posts

- **URL**: `/api/post`
- **Método**: `GET`
- **Resposta (200 OK)**:
```json
[
  {
    "id": "0196b167-6792-79c4-bec2-102e9ee49540",
    "title": "Como vai vai",
    "content": "string dsadlksajdsajlkdas",
    "createdAt": "2025-05-08T19:37:46.12286Z"
  },
  {
    "id": "0196b17b-1291-7f42-88c7-8c5253ec09eb",
    "title": "stringasdsad",
    "content": "stringdasdasfsafa",
    "createdAt": "2025-05-08T19:59:15.069941Z"
  }
]
```

---

### 🔍 Buscar Post por ID

- **URL**: `/api/post/{id}`
- **Método**: `GET`
- **Resposta (200 OK)**:
```json
{
    "id": "0196b17b-1291-7f42-88c7-8c5253ec09eb",
    "title": "stringasdsad",
    "content": "stringdasdasfsafa",
    "createdAt": "2025-05-08T19:59:15.069941Z"
}
```

- **Resposta (404 Not Found)**:
```json
{
  "status": 404,
  "mensagem": "Post não encontrado!"
}
```

---

### ✏️ Atualizar um Post

- **URL**: `/api/post/{id}`
- **Método**: `PUT`
- **Body (JSON)**:
```json
{
  "titulo": "Novo título",
  "conteudo": "Novo conteúdo"
}
```
- **Resposta (204 No Content)**:


---

### ❌ Deletar um Post

- **URL**: `/api/post/{id}`
- **Método**: `DELETE`
- **Resposta (204 No Content)**

---

## 🧱 Estrutura do Post

| Campo        | Tipo       | Descrição               |
|--------------|------------|-------------------------|
| `id`         | `int`      | Identificador único     |
| `title`     | `string`   | Título do post          |
| `content`   | `string`   | Conteúdo do post        |
| `createdAt`| `DateTime` | Data de criação do post |
| `updatedAt`| `DateTime` | Data de atualização do post |

---

## 🛠️ Tecnologias Utilizadas

- C# .NET
- Entity Framework Core
- PostgreSQL
- ASP.NET Core Web API

---

## 📦 Como Executar Localmente

1. Clone o repositório
2. Abra a sua IDE
3. Rode o repositório com a IDE

OBS: A string de conexão já esta configurada, caso queira pode muda-la para um db local.

---

## ❓ Dúvidas ou Contribuições

Sinta-se à vontade para abrir uma *issue* ou enviar um *pull request*.

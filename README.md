# UserApp API

Esta é uma API para gerenciamento de usuários, empresas, perfis, módulos e submódulos.

## Endpoints

### Auth

- **POST** `/api/auth/login`
  - Autenticar o usuário

- **POST** `/api/auth/forgot-password`
  - Recuperar senha de acesso do usuário

- **POST** `/api/auth/reset-password`
  - Reiniciar senha de acesso do usuário

### Company

- **POST** `/api/company/add`
  - Criar conta para uma Nova Empresa

- **PUT** `/api/company/edit`
  - Editar a conta de uma Empresa

- **DELETE** `/api/company/delete`
  - Excluir a conta de uma Empresa

- **GET** `/api/company/get`
  - Consultar os dados de uma Empresa

### Role

- **POST** `/api/role/role/add`
  - Criar conta para um Perfil

- **PUT** `/api/role/role/edit`
  - Editar a conta de um Perfil

- **DELETE** `/api/role/role/delete`
  - Excluir a conta de um Perfil

- **GET** `/api/role/role/get`
  - Consultar os dados da conta de um Perfil

- **POST** `/api/role/module/add`
  - Criar conta para um Módulo

- **PUT** `/api/role/module/edit`
  - Editar a conta de um Módulo

- **DELETE** `/api/role/module/delete`
  - Excluir a conta de um Módulo

- **GET** `/api/role/module/get`
  - Consultar os dados da conta de um Módulo

- **POST** `/api/role/child-module/add`
  - Criar conta para um Submódulo

- **PUT** `/api/role/child-module/edit`
  - Editar a conta de um Submódulo

- **DELETE** `/api/role/child-module/delete`
  - Excluir a conta de um Submódulo

- **GET** `/api/role/child-module/get`
  - Consultar os dados da conta de um Submódulo

- **POST** `/api/role/associate-child-module`
  - Associar um Submódulo a um Módulo

- **POST** `/api/role/associate-role-permission`
  - Associar um Perfil a uma Regra de Permissão

### User

- **POST** `/api/user/add`
  - Criar conta para um Novo Usuário

- **PUT** `/api/user/edit`
  - Editar a conta de um Usuário

- **DELETE** `/api/user/delete`
  - Excluir a conta de um Usuário

- **GET** `/api/user/get`
  - Consultar os dados da conta do Usuário

- **POST** `/api/user/associate-user-role`
  - Associar um Usuário a um Perfil

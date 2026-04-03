# 💻 TerminalSuporte.ConsoleApp

## 📌 Descrição

Este projeto consiste em um **Terminal de Suporte Proativo**, desenvolvido em C# (.NET Console), com foco em **Experiência do Usuário (UX)** e **Prevenção de Erros**.

O sistema simula um console de diagnóstico de rede, oferecendo comandos simples, mensagens claras e feedback visual através de cores.

---

## 🎯 Objetivo

Melhorar a usabilidade de um sistema de suporte técnico, evitando erros do usuário e facilitando a execução de comandos.

---

## 🧠 Heurísticas de UX Aplicadas

### ✔ Heurística #5 – Prevenção de Erros

* Confirmação obrigatória antes de ações críticas
* Exemplo: Reiniciar servidor e formatar unidade

### ✔ Heurística #6 – Reconhecimento em vez de Recordação

* Menu de comandos visível na tela
* Usuário não precisa memorizar comandos

### ✔ Heurística #10 – Ajuda e Documentação

* Comando `help` ou `?`
* Exibe instruções diretamente no terminal

---

## 🖥️ Funcionalidades

* 🔹 Ping de IP com validação
* 🔹 Reinício de servidor com confirmação
* 🔹 Formatação de unidade com alerta crítico
* 🔹 Sistema de ajuda integrado
* 🔹 Interface com cores para melhor feedback

---

## 🎨 Uso de Cores

* 🟢 Verde → Sucesso
* 🟡 Amarelo → Atenção
* 🔴 Vermelho → Erro / Perigo

---

## 🛡️ Resiliência

O sistema trata entradas inválidas, como:

* IPs incorretos
* Comandos inexistentes

Evita falhas e melhora a experiência do usuário.

---

## ▶️ Como Executar

1. Abrir o projeto no Visual Studio
2. Executar o arquivo `Program.cs`
3. Interagir com o menu exibido no terminal

---

## 📷 Exemplo de Uso

```
=== TERMINAL DE SUPORTE PROATIVO ===

[1] Pingar IP
[2] Reiniciar Servidor
[3] Formatar Unidade
[help/?] Ajuda
[0] Sair
```

---

## 👩‍💻 Tecnologias Utilizadas

* C#
* .NET Console

---

## 📎 Entrega

Este projeto foi desenvolvido como atividade da disciplina de **Interação Humano-Computador e UX**.

---


# Smart Layered System in .NET – Education, Flexibility, Real-World Architecture

## Project Summary

This project is a fully modular, layered .NET application designed to simulate real-world system architecture. It showcases professional separation of concerns, scalable infrastructure, and flexible data access strategies – all built from scratch using raw C# and XML, without relying on frameworks like EF Core.

>  Purpose: Demonstrate deep understanding of enterprise application architecture, including DI principles, custom DAL switching, and full-stack logic encapsulation.

---

## What Makes This Project Stand Out

- **Domain-Oriented Logic:** Business rules are fully decoupled from data access and UI, reflecting Clean Architecture patterns.
- **Plug-and-Play Data Layer:** Easily switch between in-memory (`DALList`) and persistent storage (`DALXml`) by modifying a single config.
- **No Framework Shortcutting:** No Entity Framework or scaffolding – everything is handwritten to show full command of abstraction and infrastructure.
- **Extensibility-First:** Architecture is intentionally built to support adding more DAL backends (e.g., database, API) with zero change to business logic.

---

## Key Features

-  **Interchangeable DAL Backends** – switch between `List` and `XML` implementations in seconds.
- **Strong Encapsulation** – strict access control between layers using interfaces and factories.
-  **XML Storage Engine** – no external database, yet fully persistent via structured XML files.
- **UI Layer (WinForms/WPF)** – actual usable interface, not just console proof-of-concept.
- **Manual Dependency Injection** – no containers; dependencies are resolved explicitly for learning purposes.

---

## Architecture Overview

```txt
UI ──► BL ──► DALFacade ──► DALList / DALXml
         ▲                     ▲
       Tests                Config
```

## Requirements

- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio 2022 or later (with .NET Desktop Development workload)

## Setup & Run
Open DotNet2025_1357_7977.sln in Visual Studio.

Set UI as the startup project.

Run the application.

Use dotnet test for executing all unit tests.

## Configuration
To change data storage strategy (XML/List), modify the DAL factory class under DALFacade. No changes to BL or UI are required.

## Target Audience
Employers seeking candidates with solid understanding of software architecture.

Reviewers evaluating ability to work across abstraction layers.

Engineers looking for a reference implementation of Clean Architecture in .NET (without libraries).

## Skills Demonstrated
.NET Core ecosystem

Layered architecture & abstraction

OOP & interfaces in C#

Manual factory patterns

XML serialization

Windows UI development

## Author
Sarah Gershuni & Rachel Shtrochlitz
Educational full-stack developers with deep interest in architecture, correctness, and building real solutions from the ground up.

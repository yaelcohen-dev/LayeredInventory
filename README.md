# Smart Layered Inventory System (.NET)

A modular, layered .NET application designed to demonstrate professional software architecture, separation of concerns, and scalable infrastructure.

## Project Summary
This project showcases a clean separation of business logic from data access and UI. Built from scratch using C# and XML, it emphasizes architectural principles without relying on external frameworks like EF Core, providing a transparent view of the underlying system mechanics and enterprise patterns.

## Key Technical Features
* **Interchangeable DAL Backends:** Seamlessly switch between in-memory storage (DALList) and persistent storage (DALXml) by modifying a single configuration.
* **Domain-Oriented Logic:** Business rules are fully decoupled from data access and UI layers, reflecting Clean Architecture patterns.
* **Strong Encapsulation:** Strict access control between layers implemented through interfaces and factories to ensure system integrity.
* **XML Storage Engine:** Full persistence achieved via structured XML files, demonstrating manual serialization and custom data management.
* **Infrastructure Mastery:** Everything is handwritten—from dependency resolution to data abstraction—to show full command over software infrastructure.

## Architecture Overview
The system follows a strict layered flow:
**UI ──► Business Logic (BL) ──► DALFacade ──► DALList / DALXml**

## Technologies & Skills
* **Language & Ecosystem:** C# / .NET
* **Architecture:** N-Tier / Clean Architecture / Separation of Concerns
* **Patterns:** Manual Factory Patterns, Dependency Injection (DI) principles, Interface-based Programming
* **Data Management:** XML Serialization, Data Access Objects (DAO)

## Setup & Execution
1. **Open the Solution:** Load the `.sln` file in Visual Studio 2022.
2. **Startup Project:** Set the UI project (WinForms/WPF) as the Startup Project.
3. **Run:** Press F5 to build and run the application.

---

## Authors
**Yael Cohen & Tammar Medan**
Educational full-stack developers with deep interest in architecture, correctness, and building real solutions from the ground up.

---
*Developed as a comprehensive project to demonstrate advanced software engineering principles and architectural integrity.*

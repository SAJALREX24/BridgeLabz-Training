Backend Refresher Training — BridgeLabz
Day 1 | DB Programming Basics
📌 Progress Overview

Day 1 Topic: RDBMS Fundamentals & SQL Setup | Status: ✅ Done

💡 Topics Covered

DBMS vs. RDBMS: Understanding relational vs. non-relational database models and their ideal use cases.

Tools of the Trade: Introduction to MS SQL Server and T-SQL.

RDBMS Fundamentals: Core concepts behind structuring and managing databases.

🛠️ Tasks Completed

Environment Setup: Successfully installed and configured MS SQL Server.

Database Design: Sketched an ER Diagram for a Health Clinic Application (modeling Patients, Doctors, and Appointments).

Implementation: Wrote and pushed the initial SQL scripts to create the database schema.

Day 2 | DB Programming & Indexing
📌 Progress Overview

Day 2 Topic: Advanced RDBMS & Query Optimization | Status: ✅ Done

💡 Topics Covered

Database Concepts: Deep dive into Entities, Attributes, Relationships, Cardinality, and Primary/Foreign Keys.

Indexes: The mechanics of Clustered, Non-Clustered, Unique, and Composite Indexes.

Normalization: Database normalization rules (1NF, 2NF, 3NF, and BCNF) to reduce redundancy.

🛠️ Tasks Completed

Schema Extension: Expanded the database by adding a rooms table and a doctor_room mapping table.

Query Optimization: Executed performance analysis on appointment queries (comparing No Index, Single-Column, and Composite Indexes) to measure row execution metrics.

Normalization Audit: Evaluated the patient_phones structure against 1NF, 2NF, and 3NF, documenting the justification for each structural change.

Covering Index: Created and verified a covering index for doctor_id, appointment_date, and status.

Day 3 | DB Programming – Joins, Stored Procedures & Triggers
📌 Progress Overview

Day 3 Topic: Joins, Procedures & Database Automation | Status: ✅ Done

💡 Topics Covered

SQL Joins: Mastering Inner, Left, Right, and Full Outer Joins for data retrieval.

Stored Procedures: Writing modular, parameterized SQL scripts for routine operations.

Database Triggers: Automating database actions using DML triggers (INSERT, UPDATE, DELETE).

Audit Logging: Best practices for tracking data modifications over time.

🛠️ Tasks Completed

Joins Practice: Wrote complex join queries to retrieve connected data across the Health Clinic database.

Stored Procedures: Authored procedures to manage CRUD actions for Patients, Doctors, Appointments, Billing, and VisitHistory.

Audit System: Designed an AuditLog table and implemented triggers on critical tables to automatically record historical changes.

Day 4 | ADO.NET & Health Clinic App Completion
📌 Progress Overview

Day 4 Topic: C# Database Connectivity (ADO.NET) | Status: ✅ Done

💡 Topics Covered

ADO.NET Architecture: Understanding the differences between Connected and Disconnected states.

SQL Server Connectivity: Bridging a .NET application with an MS SQL Server database.

CRUD Execution: Utilizing SqlConnection, SqlCommand, SqlDataReader, and SqlDataAdapter for data manipulation.

🛠️ Tasks Completed

App Integration: Successfully connected the Health Clinic console application to the local MS SQL Server.

Backend Logic: Implemented complete CRUD capabilities for all major entities (Patients, Doctors, Appointments, etc.).

Architecture Mapping: Ensured the finalized SQL ER diagram accurately reflected the C# application's data models.

Day 5 | Backend Basics – ASP.NET Core Web API
📌 Progress Overview

Day 5 Topic: Web APIs & RESTful Services | Status: ✅ Done

💡 Topics Covered

ASP.NET Core: Introduction to the modern .NET framework, dependency injection, and middleware.

Web APIs: How APIs facilitate client-server communication.

REST Architecture: REST principles, HTTP request methods (GET, POST, PUT, DELETE), and standard status codes.

Project Structure: Organizing controllers, routes, and application startup configurations.

🛠️ Tasks Completed

Scaffolding: Set up a brand new ASP.NET Core Web API project.

Controllers & Routing: Built API controllers featuring standard RESTful endpoint routing.

In-Memory CRUD: Created foundational GET and POST endpoints using temporary in-memory data storage to test request/response handling.

Day 6 | MVC Pattern & REST Request Handling
📌 Progress Overview

Day 6 Topic: Full-Stack Integration via MVC Architecture | Status: ✅ Done

💡 Topics Covered

Model-View-Controller (MVC): Organizing code logically into Models (data), Views (UI), and Controllers (routing/logic).

C# REST API Calls: Handling HTTP GET and POST requests dynamically based on user input.

Static File Serving: Configuring a .NET backend to host and serve a custom HTML/CSS/JS frontend.

Client-Server Communication: Using the JavaScript fetch API to send data to the backend and receive JSON responses.

🛠️ Tasks Completed

Built 'My Greetings App': Created a full-stack web application using ASP.NET Core Web API.

Architectural Setup: Structured the project with dedicated Controllers, Models, and Views folders to strictly adhere to the MVC pattern.

Frontend Integration: Developed a custom UI (index.html, greeting.css, greeting.js) and configured Program.cs to serve these static files using UseDefaultFiles() and UseStaticFiles().

API Endpoints: Wrote a HomeController that handles a POST request to save a user's name to a repository, and a GET request to return a personalized greeting directly to the browser popup.

Day 7 | Minimal APIs
📌 Progress Overview

Day 7 Topic: Minimal APIs | Status: ✅ Done

💡 Topics Covered

Core Concepts: Minimal APIs in ASP.NET Core.

REST Architecture: RESTful endpoints and HTTP methods.

Data Flow: Request and response handling.

🛠️ Tasks Completed

Backend Initialization: Created a Contacts App backend using Minimal APIs.

Endpoint Logic: Implemented basic CRUD endpoints.

Day 8 | Swagger & API Testing
📌 Progress Overview

Day 8 Topic: Swagger & API Testing | Status: ✅ Done

💡 Topics Covered

OpenAPI Specs: Swagger / OpenAPI documentation.

Quality Assurance: API endpoint testing and response handling.

System Design: Introduction to distributed architecture.

🛠️ Tasks Completed

Swagger Integration: Integrated Swagger into the Contacts App.

API Verification: Tested and documented API endpoints using Swagger UI.

Day 9 | Entity Framework Core
📌 Progress Overview

Day 9 Topic: Entity Framework Core | Status: ✅ Done

💡 Topics Covered

ORM Fundamentals: ORM and Entity Framework Core.

EF Architecture: Entities, DbContext, and database operations.

Service Registration: Dependency Injection in ASP.NET Core.

🛠️ Tasks Completed

Backend Conversion: Converted the Contacts App to use Entity Framework Core.

Data Operations: Implemented database-based CRUD operations.

Day 10 | Entity Framework & N-Tier Architecture
📌 Progress Overview

Day 10 Topic: Entity Framework & N-Tier Architecture | Status: ✅ Done

💡 Topics Covered

Data Queries: LINQ to Entities.

EF Core Integration: Entity Framework Core with REST APIs.

Enterprise Patterns: N-Tier / layered architecture.

🛠️ Tasks Completed

Project Scaffold: Created AddressBookWebApp using Entity Framework Core.

Structural Design: Implemented the application using N-Tier Architecture.

Query Execution: Used LINQ for database querying and CRUD operations.

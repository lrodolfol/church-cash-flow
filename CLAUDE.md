# ChurchCashFlow .NET
Project folder: ./Registration

**This is a .NET project. All code must be written in C# with strong typing and in English, including variable names, methods, and classes. Use modern language features (C# 12+). Avoid comments whenever possible. The code should be self-explanatory.**
**WRITE THIS COMMENT ON FIRST LINE INTO NEW .cs FILES (IGNORE OLDER FILES): //created by: rodolfojesus - tinosnegocios.com.br - rodolfo0ti@gmail.com - linkedin: rodolfojesus**

## Commands
- Build: `dotnet build`
- Testes: `dotnet test`
- Lint: `dotnet format --verify-no-changes`
- Run: `dotnet run --project src/MeuProjeto.API`

## Stack
- .NET 8, C# 12
- ASP.NET Core (minimal APIs)
- Entity Framework Core (PostgreSQL)
- xUnit para testes

## RULES
- All classes must use primary constructors.
- All string properties from classes must use `string.Equals` by default.
- All list properties must be instantiated in the declaration line.
- Use the `dotnet CLI` as the standard package manager and execution tool.
- Before finishing a task, validate build and typing.
- Use `var` only when the type is obvious; avoid `dynamic` unless justified.
- Methods/functions must represent one clear action and start with a verb.
- Avoid passing more than 3 parameters; prefer parameter objects.
- Class fields must be `private` or `private readonly`.
- Never nest more than two `if/else` levels; prefer early returns.
- Never use flag parameters to switch behavior.
- Prefer LINQ over `for`/`while` for collection manipulation.
- Always use `async/await` for asynchronous operations; avoid `.Result` and `.Wait()`.
- Never use `object` or `dynamic` where a concrete type can be defined.
- Use file-scoped namespaces and keep `using` directives organized.
- Keep one public type per file.
- Use dependency injection and avoid circular dependencies.
- Remenber: High-level layers do not depend on low-level layers.
- Never instantiate services manually when DI is available.
- Use generics/records/utility types to reduce duplication.
- Never return `null` and never pass `null` to methods; always apply default values and validate properties before calling dependent methods.
- Do not install unnecessary dependencies in projects. For example, the web-api project does not need the Dapper library; only the Repository project needs this library.
- ** NEVE PUT `System.Console.WriteLine()` INTO THE CODE. USE THE Microsoft.Extensions.Logging LIBRARY FOR LOGS. **
- **Avoid exceptions, Prefer ResultPatterns**

## Architecture
@./Registration/.claude/rules/rules.architecture.md

## Naming rules
@./Registration/.claude/rules/rules.naming.md`

## Code Style
@./Registration/.claude/rules/rules.style.md`

## Plataform and build rules
@./Registration/.claude/rules/rules.platform.md`

## Git
- Branchs: `feat/<ticket>-descricao-curta`
- Always run `dotnet test && dotnet format` before the commits
- Never commit with `Console.WriteLine` in the production code

## project structure
Project folder: ./Registration
sln file: 
    `./Registration/Registration.sln`
projects: 
    `./Registration/Application/Registration.API` - Controlles, endpoints and api rules
    `./Registration/Domain/Registration.CentralPackages` - Central packages used in this project
    `./Registration/Domain/Registration.DomainBase` - The project core with entities, enums and aggregates
    `./Registration/Domain/Registration.DomainCore` - The core system abstractions used in this project
    `./Registration/Infrastructure/Registration.Infrastructure` - Used by `./Registration./Application/Registration.API` for api configurations registers and inject dependencies
    `./Registration/Infrastructure/Registration.Resources` - .resx and .resources files for keep database queries
    `./Registration/Infrastructure/Registration.StaticEnviroments` - Reading and inject json files from project for create IConfiguration
    `./Registration/Respository/Registration.Respository` - Database configurations, database mapping, database implementations and efcore context
    `./Registration/Service/CloudServices` - Implementations for cloudServices
    `./Registration/Service/CloudServices` - Implementations for cloudServices and cache aside pattern
    `./Registration/Service/CloudServices` - Implementations for message-brocker services (rabbitq, sqs) and models for Event-Oriented Architecture (EDA)
    `./Registration/Service/Registration.DependencyInjection` - ILogger inject dependencies
    `./Registration/Service/Registration.Handlers` - API middlewares, API handlers and API model for result pattern
    `./Registration/Service/Registration.Mapper` - DTO mapping and DTO profiles for `auto-mapper library`
    `./Registration/Test/HandlerTest` - Unit tests
files from project:
    `./Registration/.dockerignore` - docker ignore
    `./Registration/church-cluster.yml` - yml file for create a cluster deployment
    `./Registration/docker-compose.dev.yml` - yml file for container docker
    `./Registration/Dockerfile` - docker files
    `./Registration/Dockerfile` - .gitignore
    `./Registration/README.md` - readme file

## Auto-aprendizado
When you correct something or identify a recurring pattern in the project,
log it in ~/.claude/projects/memory/ for future sessions.

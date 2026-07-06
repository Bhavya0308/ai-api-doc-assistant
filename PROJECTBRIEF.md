Problem Statement:
    Teams building or consuming REST APIs spend significant time on documentation that goes stale the moment the API changes. Writing docs, code examples in multiple languages, and test suites is manual, repetitive work that engineers deprioritize under deadline pressure — resulting in APIs that are hard to adopt, slow to onboard against, and poorly tested. This project builds a platform that ingests any REST API definition (OpenAPI spec or Postman collection) and uses AI to automatically generate accurate documentation, ready-to-use SDK examples in multiple languages, a conversational Q&A assistant grounded in the actual API, and AI-generated test suites — turning a raw spec into a fully documented, explorable, testable API in minutes instead of days.
Target Users:
    1. Backend/API teams who need to document internal or public-facing APIs without dedicating engineering time to writing docs manually
    2. Developers integrating a new API who want quick, working code examples instead of parsing raw spec files
    3. QA/API teams who want a fast way to generate a baseline test suite for an API without writing every test case by hand
    4. (Portfolio angle) Interviewers/hiring managers evaluating full-stack + applied-AI engineering ability
Core Features:
    1. Spec Ingestion — Upload an OpenAPI (JSON/YAML) spec or Postman collection; the system parses, validates, and stores every endpoint, parameter, and schema.
    2. AI-Generated Documentation — For each endpoint, generate human-readable docs: description, parameters table, example requests/responses, and possible errors.
    3. Multi-Language SDK Examples — Auto-generate runnable code snippets (cURL, Python, JavaScript, C#) per endpoint, correctly reflecting auth and request bodies.
    4. AI Chat Assistant (RAG) — Ask natural-language questions about the API ("How do I authenticate?") and get answers grounded in the actual generated documentation, with source citations.
    5. AI-Generated API Testing — Automatically generate test cases (happy path, edge cases, invalid input, auth failures) and run them against the live API, validating responses against the schema.
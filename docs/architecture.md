# Architecture Overview

Cora Agent uses a plugin-plus-backend architecture.

## Runtime Components

- Revit Plugin (C#): user interface, local Revit execution, backend communication
- FastAPI Backend (Python): intent handling, tool orchestration, streaming responses
- Optional MCP Servers: external tool interoperability

## Core Flow

1. User sends a natural language request from the Revit sidebar.
2. Plugin forwards request to backend endpoint `/api/agentic-stream`.
3. Backend emits SSE events (`text/event-stream`) with status and final output.
4. Selected tools execute BIM actions (for example wall creation).
5. Plugin renders progress and final result.

## Compatibility Variable

The plugin uses `BIMAGENT_API_BASE` to resolve backend base URL.
Fallback default is local backend (`http://127.0.0.1:8000`).

## Design Principles

- Keep production internals private.
- Expose only safe, educational contracts in this public repository.
- Make demos runnable in minutes.

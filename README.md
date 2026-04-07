# Cora Agent Public Showcase

AI-Powered BIM Automation for Revit.

[Join Waitlist](https://www.coraagent.xyz/) | [Watch Demo](https://www.coraagent.xyz/#demo) | [Pricing](https://www.coraagent.xyz/#pricing) | [Docs](https://docs.coraagent.xyz/)

![Cora Agent Hero](assets/hero/hero-main.png)

Natural language to real BIM actions in Revit. Public showcase only; production core stays private.

## Architecture

```mermaid
flowchart LR
  U[Revit User] --> P[Revit Plugin C#]
  P -->|HTTP| B[Local Bridge]
  P -->|POST /api/agentic-stream SSE| A[FastAPI Backend]
  A --> T[Tool Router]
  T --> R[Revit API Actions]
  A --> L[LLM Providers]
  A <--> M[MCP Servers Optional]
```

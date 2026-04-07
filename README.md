# Cora Agent Public Showcase

AI-Powered BIM Automation for Revit.

Public showcase repository for Cora Agent. This repo demonstrates product value and architecture.

[Join Waitlist](https://www.coraagent.xyz/) | [Watch Demo](https://www.coraagent.xyz/#demo) | [Pricing](https://www.coraagent.xyz/#pricing) | [Docs](https://docs.coraagent.xyz/)

![Cora Agent Hero](assets/hero/hero-main.png)

## Why Cora Agent

Cora Agent turns natural language into real BIM actions inside Revit.

- 30+ BIM tools
- 10x faster modeling workflows
- 100% Revit-native integration

## Quick Summary (ES)

Cora Agent converts natural language into real-world actions within Revit.
This repository is a public showcase with a demo, architecture, and minimal samples.

## Product Highlights

- AI-powered automation for repetitive BIM tasks.
- Native Revit workflow via plugin.
- Streaming UX for fast feedback loops.
- MCP-ready extensibility for tool integrations.

## Demo Assets

- Hero: `assets/hero/hero-main.png`
- Thumbnail: `assets/thumbnails/demo-thumbnail.png`
- Gallery: `assets/screenshots/`
- Full videos: external links only (not stored in git)

![Demo Thumbnail](assets/thumbnails/demo-thumbnail.png)

## Feature Gallery

| Screenshot | Description |
|---|---|
| ![Screenshot 1](assets/screenshots/screenshot-01.png) | Natural language command flow |
| ![Screenshot 2](assets/screenshots/screenshot-02.png) | Revit-native sidebar UX |
| ![Screenshot 3](assets/screenshots/screenshot-03.png) | Intelligent model operations |
| ![Screenshot 4](assets/screenshots/screenshot-04.png) | Documentation and automation |

## How It Works

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
## Pricing (Brief)

Currently presents three plans (as shown on April 7, 2026):

- Basic (On Demand): free beta credits + pay as you go
- Regular: USD 20/month
- Enterprise: USD 50/month

For latest and official pricing details: https://www.coraagent.xyz/#pricing

## Brand

Cora Agent name and brand assets remain reserved by the owner. See `NOTICE`.

## Contact

- Website: https://www.coraagent.xyz/
- Docs: https://docs.coraagent.xyz/
- Email: hello@coraagent.xyz

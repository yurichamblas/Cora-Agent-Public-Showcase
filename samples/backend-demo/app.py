from __future__ import annotations

import asyncio
import json
from typing import Any

from fastapi import FastAPI, Request
from fastapi.responses import StreamingResponse

app = FastAPI(title="Cora Agent Showcase Demo API")


@app.get("/health")
async def health() -> dict[str, str]:
    return {"status": "ok"}


@app.post("/api/agentic-stream")
async def agentic_stream(payload: dict[str, Any], request: Request) -> StreamingResponse:
    user_message = (payload or {}).get("user_message", "")
    history = (payload or {}).get("history", [])

    async def event_generator():
        steps = [
            {"type": "status", "message": "Analyzing intent"},
            {"type": "status", "message": "Planning tool call"},
            {
                "type": "tool_call",
                "tool": "create_line_based_element",
                "args": {"intent": user_message, "history_items": len(history)},
            },
            {
                "type": "final",
                "message": f"Demo action simulated for: {user_message}",
                "next": "Connect this contract to your real plugin/backend stack.",
            },
        ]

        for event in steps:
            if await request.is_disconnected():
                return
            yield f"data: {json.dumps(event, ensure_ascii=False)}\\n\\n"
            await asyncio.sleep(0.35)

    return StreamingResponse(event_generator(), media_type="text/event-stream")

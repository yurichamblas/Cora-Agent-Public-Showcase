# Security Policy

## Reporting a Vulnerability

Please do not open public issues for security reports.

Contact: hello@coraagent.xyz
Subject: [Security] Cora Agent Public Showcase

Include:

- Description of the issue
- Reproduction steps
- Potential impact
- Suggested mitigation (optional)

## Secret Handling Rules

- Keep real credentials out of git
- Use `.env.example` as template only
- Store real values in `.env.local` or a secret manager
- Run gitleaks before pushing

## Scope Note

This repository is a public showcase. Production systems and credentials are not part of this codebase.

# Sanitization Checklist

Use this checklist before each public push.

## Secrets and Credentials

- [ ] No API keys, tokens, passwords, or private URLs in tracked files
- [ ] `.env.local` and runtime secret files are ignored
- [ ] `.env.example` contains placeholders only

## Sensitive Product IP

- [ ] No production prompts
- [ ] No private orchestration policies or billing internals
- [ ] No incident runbooks or internal operational data

## Assets and Media

- [ ] No heavy source files (`.psd`, `.af`, `.dwg`, `.3dm`, `.zip`)
- [ ] No large videos committed unless explicitly approved
- [ ] Public assets have stable filenames under `assets/`

## Automated Scans

- [ ] `pre-commit run --all-files` passes
- [ ] GitHub Action `Secret Scan` passes

## Final Validation

- [ ] README links are valid
- [ ] Quickstart works from a fresh clone
- [ ] Repository size remains lean for public onboarding

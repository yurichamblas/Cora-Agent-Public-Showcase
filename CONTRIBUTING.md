# Contributing

Thanks for contributing to Cora Agent Public Showcase.

## What We Accept

- README and docs improvements
- Safe sample enhancements
- Bug fixes in showcase scripts
- Visual or onboarding improvements

## Contribution Flow

1. Fork the repository
2. Create a branch (`feature/my-change`)
3. Run local checks
4. Open a pull request

## Local Checks

```bash
pre-commit run --all-files
python -m pip install -r samples/backend-demo/requirements.txt
uvicorn app:app --app-dir samples/backend-demo --port 8000
```

## PR Checklist

- [ ] No secrets in changed files
- [ ] Docs updated when behavior changes
- [ ] Demo quickstart still works
- [ ] Files remain within public-safe scope

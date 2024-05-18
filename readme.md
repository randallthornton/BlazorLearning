# Blazor Learning

## Production

[Link in GCP](https://blazor-learning-hzq2w5dm3q-uc.a.run.app/MeowFacts)

## Build with Podman

Substitude `podman` with `docker` if you use Docker instead.

Use your own container registry as well, with your own login

```powershell
podman build . -t blazor-learning
```

```powershell
podman push blazor-learning docker://docker.io/randongg/blazor-learning:latest
```
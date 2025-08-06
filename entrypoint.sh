#!/bin/bash
set -e

export PATH="$PATH:/root/.dotnet/tools"

echo "==> RUNNING MIGRATIONS"
dotnet ef database update

echo "==> STARTING APP"
dotnet BokmalensWebbshop.dll

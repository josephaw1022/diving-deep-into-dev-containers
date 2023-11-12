#!/bin/bash
set -a # automatically export all variables
source .env
set +a

# Now you can use the environment variables in your script
pg_dump -U "$DB_USER" -h "$DB_HOST" -f "./db-backups/dev-container-db-$(date +\%Y\%m\%d\%H\%M).sql" "$DB_NAME"

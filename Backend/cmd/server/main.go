package main

import (
	"context"
	"localhost/junction-server/internal/database"
	"localhost/junction-server/internal/server"
	"os"
	"time"
)

func main() {
	ctx, cancel := context.WithTimeout(context.Background(), 10*time.Second)
	defer cancel()

	database.ConnectDB(ctx, os.Getenv("DATABASE_URI"))
	server.Start()
}

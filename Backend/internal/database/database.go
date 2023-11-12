package database

import (
	"context"
	"log"

	"go.mongodb.org/mongo-driver/bson"
	"go.mongodb.org/mongo-driver/mongo"
	"go.mongodb.org/mongo-driver/mongo/options"
)

var db *mongo.Client

func ConnectDB(ctx context.Context, connectURI string) {
	client, err := mongo.Connect(ctx, options.Client().ApplyURI(connectURI))
	if err != nil {
		log.Fatal(err)
	}

	err = client.Ping(ctx, nil)
	if err != nil {
		log.Fatal(err)
	}
	log.Print("Connected to mongodb at")

	db = client
}

func getCollection(collectionName collection) *mongo.Collection {
	collection := db.Database("Junction").Collection(string(collectionName))
	return collection
}

func E(s string, i interface{}) bson.E {
	return bson.E{Key: s, Value: i}
}

type collection string

const (
	usersCollection collection = "users"
)

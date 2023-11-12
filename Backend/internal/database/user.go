package database

import (
	"context"
	"localhost/junction-server/internal/model"
	"time"

	"go.mongodb.org/mongo-driver/bson/primitive"
)

type User struct {
	Id       primitive.ObjectID `bson:"_id,omitempty"`
	Username string             `bson:"username"`
}

func CreateUser(u model.User) (string, error) {
	userDAO := User{
		Username: u.Username,
	}

	ctx, cancel := context.WithTimeout(context.Background(), 10*time.Second)
	defer cancel()

	result, err := getCollection(usersCollection).InsertOne(ctx, userDAO)
	if err != nil {
		return "", err
	}

	return result.InsertedID.(primitive.ObjectID).Hex(), nil
}

package service

import (
	"localhost/junction-server/internal/database"
	"localhost/junction-server/internal/model"
)

func CreateUser(u model.User) (string, error) {
	id, err := database.CreateUser(u)
	if err != nil {
		return "", err
	}

	return id, nil
}

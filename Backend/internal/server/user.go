package server

import (
	"fmt"
	"localhost/junction-server/internal/model"
	"localhost/junction-server/internal/service"
	"net/http"

	"github.com/go-chi/render"
	"github.com/go-playground/validator/v10"
)

var validate = validator.New()

type CreateUserRequest struct {
	Username string `json:"username" validate:""`
}

func (req *CreateUserRequest) Bind(r *http.Request) error {
	if err := validate.Struct(req); err != nil {
		return fmt.Errorf("could not bind request body: %w", err)
	}

	return nil
}

type UserResponse struct {
	ID string `json:"id"`
}

func PostUserHandler(w http.ResponseWriter, r *http.Request) {
	requestData := CreateUserRequest{}
	if err := render.Bind(r, &requestData); err != nil {
		render.Render(w, r, ErrInvalidRequest(err))
		return
	}

	user := model.User{
		Username: requestData.Username,
	}

	service.CreateUser(user)
}

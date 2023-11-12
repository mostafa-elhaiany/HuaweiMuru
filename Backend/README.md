## **User** Resource

```json
{
    "username": "string",
}
```

- POST /users - registers a new user

    request: 
    ```json
    {
        "username": "string"
    }
    ```

    response: 
    - 201 Created 
    ```json
    {
        "id": "UUID"
    }
    ```
    - 403 Bad Request

- GET /user/{id} - get user's status

    response: 
    - 200 OK 
    ```json
    {
        "id": "UUID",
        "username": "string",
    }
    ```

- PUT /user/{id} - update a user

    request: 
    ```json
    {
        "username": "string"
    }
    ```

    response: 
    - 200 OK 

## **Pet** Resource

```json
{
    "name": "string",
    "hydrationRate": "integer: 1(very bad)-5(very good)",
    "hungerRate": "integer: 1(very hungry)-5(not hungry)",
    "sleepRate": "integer: 1(very sleepy)-5(not sleepy)",
    "boredomRate": "integer 1(very bored)-5(satisfied)",
    "health": "integer: 1(unhealthy) - 5(very healty)",
    "happyness": "integer: 1(unhappy) - 5(very happy)"
}
```

- GET /user/{id}/pet - get user's pet status

    response: 
    - 200 OK 
    ```json
    {
        "name": "string",
        "hydrationRate": "integer: 1(very bad)-5(very good)",
        "hungerRate": "integer: 1(very hungry)-5(not hungry)",
        "sleepRate": "integer: 1(very sleepy)-5(not sleepy)",
        "boredomRate": "integer 1(very bored)-5(satisfied)",
        "health": "integer: 1(unhealthy) - 5(very healty)",
        "happyness": "integer: 1(unhappy) - 5(very happy)"
    }
    ```

- POST /users/{id}/pet/drink - record drinking water

    request: 
    ```json
    {
        "amountInMl": "integer: amout of water in milliliters"
    }
    ```

    response: 
    - 200 OK 
    - 404 Bad request4

- POST /users/{id}/pet/walk - record taking a walk

    request: 
    ```json
    {
        "stepsAmount": "integer: amout of steps walked"
    }
    ```

    response: 
    - 200 OK 
    - 404 Bad request

- POST /users/{id}/pet/play - record doing a general sport activity

    request: 
    ```json
    {
        "durationMinutes": "integer: duration in minutes",
        "caloriesBurned": "integer: how many calories were burned"
    }
    ```

    response:
    - 200 OK
    - 404 Bad request

- POST /users/{id}/pet/sleep - record a sleeping session

    request: 
    ```json
    {
        "durationMinutes": "integer: duration in minutes"
    }
    ```

    response:
    - 200 OK
    - 404 Bad request
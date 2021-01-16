package EndPoints

import (
	"encoding/json"
	"fmt"
	"net/http"
)

func HealthCheck(w http.ResponseWriter, r *http.Request) {
	fmt.Println("Endpoint Hit: HealthCheck")
	json.NewEncoder(w).Encode("Success")
}

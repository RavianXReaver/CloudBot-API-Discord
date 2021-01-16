package main

import (
	ep "CloudBotAPI/EndPoints"
	"log"
	"net/http"

	"github.com/gorilla/mux"
)

func handleRequests() {

	//Initialize Router
	router := mux.NewRouter().StrictSlash(true)

	//Health Check Endpoint
	router.HandleFunc("/health", ep.HealthCheck)

	log.Fatal(http.ListenAndServe(":10000", router))
}

func main() {
	handleRequests()
}

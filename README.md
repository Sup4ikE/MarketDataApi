# 🚀 MarketDataApi

API service for retrieving real-time and historical market data using Fintacharts platform.

---

## 📌 Overview

MarketDataApi is a RESTful service built with ASP.NET Core that allows clients to:

* 📊 Retrieve a list of supported market assets
* ⚡ Get real-time price data via WebSocket
* 🕒 Access price update timestamps
* 🗄️ Work with assets stored in a database

---

## 🛠 Tech Stack

* **.NET 9 / ASP.NET Core Web API**
* **WebSockets (real-time data)**
* **REST API (HTTP endpoints)**
* **Entity Framework Core**
* **Docker & Docker Compose**
* **JSON формат даних**

---

## 📡 API Endpoints

### 🔹 Get all assets

```http
GET /api/assets
```

📥 Response:

```json
[
  {
    "symbol": "EURUSD",
    "kind": "currency"
  }
]
```

---

### 🔹 Get prices for assets

```http
GET /api/prices?symbols=EURUSD
```

📥 Response:

```json
[
  {
    "symbol": "EURUSD",
    "price": 1.0823,
    "updatedAt": "2026-03-27T12:00:00Z"
  }
]
```

---

## ⚙️ Configuration

All required configuration is included in the project.

### `appsettings.Development.json`

```json
{
  "Fintacharts": {
    "Token": "your-token"
  }
}
```

> 🔐 You can replace the token with your own from Fintacharts environment.

---

## ▶️ Running the Application

### 🧑‍💻 Run Locally

```bash
git clone https://github.com/your-username/MarketDataApi.git
cd MarketDataApi
dotnet restore
dotnet run
```

Then open:

```
http://localhost:5000/swagger
```

### ⚠️ Local Run Notes

For local execution, PostgreSQL must be running.

You can either:
- run database via Docker (`docker-compose up`)
- or install PostgreSQL locally and update connection string

---

### 🐳 Run with Docker

Make sure Docker is installed.

```bash
docker-compose up --build
```

Then open:

```
http://localhost:5001/swagger
```

---

## 🧱 Project Structure

```
MarketDataApi/
│
├── Api/
│   └── Controllers/
│
├── Application/
│   ├── Interfaces/
│   ├── Services/
│   ├── DTOs/
│   └── Settings/
│
├── Infrastructure/
│   └── Repositories/
│
├── docker-compose.yml
├── Dockerfile
└── appsettings.json
```

---

## ⚡ How it Works

1. Client sends request to REST API
2. API retrieves asset info from database
3. Service opens WebSocket connection to Fintacharts
4. Subscribes to real-time price updates
5. Returns first received price (ask/bid/last)

---

## ⏱ Timeout Handling

* Each WebSocket request has a **5-second timeout**
* If no data is received → request fails with error

---

## ⚠️ Notes

* WebSocket connection is created per request (simplified approach)
* Suitable for demo / test task purposes
* Can be optimized for production (connection pooling, caching)

---

## 🧠 Design Decisions

- WebSocket connection is created per request for simplicity
- No caching is used to keep real-time accuracy
- Service is designed for clarity and test task requirements, not high-load production

---

## 🧪 Testing

You can test endpoints using:

* Swagger UI
* Postman
* curl

---

## 📦 Docker Support

The entire application can be run via Docker:

```bash
docker-compose up --build
```

No additional setup required.

---

## 📬 Author

Developed as a recruitment task implementation.

---

## ✅ Status

✔️ Fully working
✔️ Meets all requirements from the task
✔️ Ready for review

---

## 💡 Future Improvements

* Add caching layer (Redis)
* Reuse WebSocket connections
* Add retry policies
* Improve error handling
* Add unit/integration tests

---

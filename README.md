# 🏨 MyHotel - Hotel Room Booking API

A simple Hotel Room Booking API built using ASP.NET Core Web API and Entity Framework Core (InMemory provider).

## 🚀 Tech Stack

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- InMemory Database Provider
- Swagger (OpenAPI)

---

## 📌 Features

- List all available rooms
- Book a room for a guest
- Get all bookings

---

## 🏗 Project Structure

- **Models** → Contains Room and Booking entities
- **Data**
  - ApiContext → EF Core database context
  - DbInitializer → Seeds initial hotel room data
- **Controllers**
  - HotelController → Handles API endpoints

---

## 🛠 How to Run the Application

### 1️⃣ Clone the repository

```bash
git clone <your-github-link>
cd MyHotel

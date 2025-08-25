# Think Store App

Application that uses Vue.js, .NET and Pinia... that allows you to store information about things, the objective of this is to be part of the personal portfolio of some of the technologies that I currently master.

## 🚀 Quick Start

### Prerequisites
- [Node.js](https://nodejs.org/) (v20.19.0 or higher)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [Git](https://git-scm.com/)

## 📁 Project Structure
```
think-store-app/
├── backend/ThinkApp.Api/     # .NET 8 Web API
├── dockerized-db/            # MySQL Docker configuration
└── frontend/                 # Vue.js 3 + Tailwind CSS
```

## 🗄️ Database Setup (MySQL)

### 1. Start MySQL Database
```bash
cd dockerized-db
docker-compose up -d
```

### 2. Verify Database is Running
```bash
docker ps
```
You should see:
- `think-app-mysql` container running
- `myapp-adminer` container running

### 3. Access Database (Optional)
- **Adminer**: http://localhost:8080
  - System: MySQL
  - Server: mysql
  - Username: appuser
  - Password: apppass
  - Database: appdb

## 🔧 Backend Setup (.NET API)

### 1. Navigate to Backend
```bash
cd backend/ThinkApp.Api
```

### 2. Restore Dependencies
```bash
dotnet restore
```

### 3. Apply Database Migrations
```bash
dotnet ef database update
```

### 4. Run the API
```bash
dotnet run
```

### 5. Verify Backend is Running
- **API**: http://localhost:5000
- **Swagger UI**: http://localhost:5000/swagger
- **Test Endpoint**: http://localhost:5000/api/test

## 🎨 Frontend Setup (Vue.js)

### 1. Navigate to Frontend
```bash
cd frontend
```

### 2. Install Dependencies
```bash
npm install
```

### 3. Run Development Server
```bash
npm run dev
```

### 4. Verify Frontend is Running
- **Frontend**: http://localhost:3000 (or the port shown in terminal)
- You should see the Tailwind CSS styled page

## 🔄 Complete Startup Sequence

### Option 1: Manual Startup
```bash
# 1. Start Database
cd dockerized-db
docker-compose up -d

# 2. Start Backend (in new terminal)
cd backend/ThinkApp.Api
dotnet run

# 3. Start Frontend (in new terminal)
cd frontend
npm run dev
```

### Option 2: Using Scripts (if available)
```bash
# Start everything at once
npm run start:all
```

## 🛠️ Available Commands

### Backend Commands
```bash
cd backend/ThinkApp.Api

# Development
dotnet run

# Build
dotnet build

# Database
dotnet ef database update
dotnet ef migrations add MigrationName
dotnet ef migrations remove
```

### Frontend Commands
```bash
cd frontend

# Development
npm run dev

# Build
npm run build

# Preview build
npm run preview

# Linting
npm run lint

# Type checking
npm run type-check
```

### Database Commands
```bash
cd dockerized-db

# Start database
docker-compose up -d

# Stop database
docker-compose down

# View logs
docker logs think-app-mysql

# Reset database (delete all data)
docker-compose down -v
docker volume rm think-store-app_mysql_data
docker-compose up -d
```

## 🌐 API Endpoints

### Test Endpoints
- `GET /api/test` - Basic test endpoint
- `GET /api/test/health` - Health check

### Thinks CRUD
- `GET /api/thinks` - Get all thinks
- `GET /api/thinks/{id}` - Get specific think
- `POST /api/thinks` - Create new think
- `PUT /api/thinks/{id}` - Update think
- `DELETE /api/thinks/{id}` - Delete think

## 🛑 Stopping the Application

### Stop Frontend
```bash
# In frontend terminal: Ctrl+C
```

### Stop Backend
```bash
# In backend terminal: Ctrl+C
```

### Stop Database
```bash
cd dockerized-db
docker-compose down
```

## 🔧 Troubleshooting

### Database Issues
```bash
# Check if containers are running
docker ps

# View database logs
docker logs think-app-mysql

# Reset database completely
cd dockerized-db
docker-compose down -v
docker volume rm think-store-app_mysql_data
docker-compose up -d
```

### Backend Issues
```bash
# Check if port 5000 is available
netstat -ano | findstr :5000

# Kill process using port 5000
taskkill /PID <PID> /F

# Rebuild project
dotnet clean
dotnet build
```

### Frontend Issues
```bash
# Clear npm cache
npm cache clean --force

# Reinstall dependencies
rm -rf node_modules package-lock.json
npm install
```

## 📝 Environment Variables

### Backend (.NET)
- Connection string is in `backend/ThinkApp.Api/appsettings.json`
- Database: `Server=localhost;Port=3306;Database=appdb;User=appuser;Password=apppass;`

### Frontend (Vue.js)
- API base URL: `http://localhost:5000/api`
- Configured in `frontend/src/services/api.ts`

## 🎯 Technologies Used

- **Backend**: .NET 8, Entity Framework Core, MySQL
- **Frontend**: Vue.js 3, TypeScript, Tailwind CSS, Pinia
- **Database**: MySQL 8.0 (Docker)
- **API**: RESTful with Swagger documentation

## 📄 License

This project is part of a personal portfolio showcasing various technologies.

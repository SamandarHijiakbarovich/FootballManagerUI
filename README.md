# ⚽ FootballManagerUI

`FootballManagerUI` is the Blazor WebAssembly front-end application for managing football teams, players, matches, and goals. It connects to the RESTful API provided by [FootballManagerApi](https://github.com/SamandarHijiakbarovich/FootballManagerApi) and provides a clean, responsive user interface for interacting with football data.

---

## 🚀 Features

- ✅ Player creation, editing, and deletion
- ✅ Match result and goal tracking
- ✅ Team listing and management
- ✅ Login & registration using JWT tokens
- ✅ Responsive and modern UI using Blazor + Tailwind CSS

---

## 🖥 UI Screenshots

> 📸 You can replace these with real screenshots once you run the app.

### 🏠 Home Page
![Home Page](./screenshots/home-page.png)

### 👥 Player Management
![Players Page](./screenshots/players-page.png)

### 🏆 Match Results
![Matches Page](./screenshots/matches-page.png)

---

## 🛠️ Technologies Used

| Tech | Description |
|------|-------------|
| 🔵 Blazor WebAssembly | UI framework for C# web frontend |
| 🎨 Tailwind CSS | Styling framework |
| 🔐 JWT Authentication | Secure login and API access |
| 🌐 RESTful API | Data provided by ASP.NET Core backend |
| 🖼 AutoMapper | For DTO to model mapping |

---

## 🧪 Getting Started

### 1️⃣ Clone the repository:

```bash
git clone https://github.com/SamandarHijiakbarovich/FootballManagerUI.git
cd FootballManagerUI
```

### 2️⃣ Run the UI:

```bash
dotnet restore
dotnet run
```

The app will launch at: [http://localhost:5000](http://localhost:5000)

Make sure the **FootballManagerApi** is also running and accessible.

---

## 🔗 Related Projects

- ✅ [FootballManagerApi (Backend)](https://github.com/SamandarHijiakbarovich/FootballManagerApi)

---

## 📦 Project Structure

```
FootballManagerUI/
├── wwwroot/
├── Pages/
│   ├── Players.razor
│   ├── Teams.razor
│   └── Matches.razor
├── Services/
├── Models/
└── Program.cs
```

---

## 🤝 Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

---

## 🧑‍💻 Author

**Samandar Hijiakbarovich**

GitHub: [@SamandarHijiakbarovich](https://github.com/SamandarHijiakbarovich)

---

## 📄 License

This project is licensed under the MIT License.

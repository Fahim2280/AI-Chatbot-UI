
# AI Chatbot UI – Blazor Server (ASP.NET Core 8)

This is the frontend UI for the AI Chatbot platform, built with **Blazor Server** (.NET 8). It integrates seamlessly with the [AI-Chatbot backend](https://github.com/Fahim2280/AI-Chatbot), providing real-time AI-powered conversations using **SignalR** and **Tavily AI**.

## ✨ Features

- User Authentication (Login/Register) with JWT
- Real-Time Chat Interface using SignalR
- Session-Based Chat History
- Edit, Delete, and Approve Messages
- Responsive and Centered UI Design
- Integrated with Tavily AI for AI Responses


## 🛠️ Technologies Used

- Blazor Server (.NET 8)
- SignalR
- Entity Framework Core
- Tavily AI Integration
- Blazored.LocalStorage
- Custom CSS for Styling

## 📁 Project Structure

```
AI_ChatBot_UI/
├── Pages/                 # Razor components (Login, Register, Chat)
├── Shared/                # Shared components (NavMenu, Layout)
├── wwwroot/
│   ├── css/               # Custom CSS files
│   └── js/                # JavaScript files
├── DTOs/                  # Data Transfer Objects
├── Program.cs             # Application entry point
└── AI_ChatBot_UI.csproj   # Project file
```

## 🚀 Getting Started

### Prerequisites

- .NET 8 SDK
- Visual Studio 2022 or later / VS Code
- Node.js (for managing frontend assets, if necessary)

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/AI_ChatBot_UI.git
   cd AI_ChatBot_UI
   ```

2. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

3. **Update API Base URL**
   Ensure the frontend points to the correct backend API URL. Update the `appsettings.json` or relevant configuration files.

4. **Run the Application**
   ```bash
   dotnet run
   ```

   Navigate to `https://localhost:5001` in your browser.

## 🔐 Authentication

The application uses JWT for authentication. Upon successful login or registration, the JWT token is stored in the browser's local storage using `Blazored.LocalStorage`. This token is then attached to subsequent API requests for authorization.

## 💬 Chat Functionality

- **Real-Time Communication**: Implemented using SignalR to facilitate instant messaging between the user and the AI.
- **Message Operations**: Users can edit, delete, and approve messages.
- **Typing Indicator**: Displays when the AI is formulating a response.

## 🎨 UI Enhancements

- **Responsive Design**: Ensures optimal viewing across devices.
- **Centered Layout**: All primary components are centered for better aesthetics.
- **Validation Feedback**: Real-time feedback on form inputs, such as email and password fields.
- **Password Visibility Toggle**: Allows users to view or hide their password input.

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## 🤝 Acknowledgements

- [Fahim2280/AI-Chatbot](https://github.com/Fahim2280/AI-Chatbot) for the backend implementation.
- [Blazored.LocalStorage](https://github.com/Blazored/LocalStorage) for local storage management in Blazor.
- [Tavily AI](https://www.tavily.com/) for AI-powered responses.

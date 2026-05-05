# 🎨 Artisan Core v3.0

**Artisan Core** is an intelligent Decision Support System (DSS) developed using **ASP.NET Core MVC**. It provides strategic roadmaps and predictive analytics for creators across multiple domains, including Fine Arts, Web Development, Fashion, and Handmade Crafts.

---

## 🚀 Overview
The application is designed to bridge the gap between creative vision and technical execution. By analyzing user input, the system generates a tailored 3-phase roadmap, suggests primary mediums, and estimates project timelines.

## ✨ Key Features
*   **Universal Art Intelligence:** Intelligent logic that identifies categories like Painting, Web Design, Crochet, and Fashion.
*   **Dynamic Visual Roadmaps:** Generates a professional step-by-step strategy (Concept, Execution, Precision) for each project.
*   **Aesthetic Glassmorphism UI:** A premium dark-themed interface built with Bootstrap 5 and Animate.css for a modern, professional look.
*   **Contextual Image Switching:** Automatically updates the interface with high-quality visual references based on the analyzed art type.
*   **Docker Integration:** Includes a production-ready `Dockerfile` for seamless deployment in containerized environments.

---

## 🛠️ Technology Stack
*   **Backend:** .NET 10 (C#)
*   **Frontend:** Razor Pages, Bootstrap 5, CSS3 (Glassmorphism)
*   **Architecture:** Model-View-Controller (MVC)
*   **Deployment:** Docker

---

## 📂 Project Structure
*   **Controllers/**: Contains `HomeController.cs` with the analysis and roadmap logic.
*   **Models/**: Includes `CraftAI.cs` which defines the data structure for project insights.
*   **Views/**: Features the aesthetic Razor-based interface in `Index.cshtml`.
*   **wwwroot/**: Hosts static assets like custom CSS and design elements.

---

## 🚦 How to Run

### Local Environment
1. Clone the repository:
   ```bash
   git init
   git remote add origin <your-github-link>
   git pull origin main

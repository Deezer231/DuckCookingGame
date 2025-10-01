# DuckCookingGame 

## Overview
DuckCookingGame  is a Unity-based kitchen simulation game project.  
Players control a Duck chef in a busy kitchen, preparing and delivering recipes by interacting with counters, collecting ingredients, cooking, and managing orders.  

This project demonstrates advanced Unity concepts, including:
- Event-driven architecture  
- ScriptableObjects  
- Custom input handling  
- A modular counter system  

---


<img width="1235" height="602" alt="Screenshot 2025-10-01 221740" src="https://github.com/user-attachments/assets/101f098a-0754-4ba8-876b-7c333e470c3c" />




## Features

### Player Movement & Input
- WASD or arrow key movement  
- Interaction with kitchen objects and counters  

### Recipe System
- Recipes defined with ScriptableObjects  
- Dynamic ingredient lists  

### Counters
- Multiple counter types, including:  
  - Cutting  
  - Stove  
  - Delivery  
  - Trash  
  - Container  
  - Plate  

### Cooking & Progress
- Frying, burning, and cutting mechanics  
- Progress bars and state machines  

### Order Management
- DeliveryManager spawns, tracks, and completes customer orders  

### Sound & Visual Feedback
- Footstep, pickup/drop, cutting, delivery, and failure sounds  
- Visual cues for selected counters, plate icons, and recipe UI  

### Event-Driven Architecture
- Custom events for interactions, recipe completion, and state changes  

### User Interface
- Dynamic recipe and plate icons  
- Progress bars and order lists  

---

## How It Works

### Core Gameplay Loop
1. Player moves around the kitchen using keyboard input.  
2. Interacts with counters to pick up, drop, cut, cook, or deliver kitchen objects.  
3. Collects ingredients, assembles plates, and delivers completed recipes.  
4. DeliveryManager spawns and tracks orders, marking them as complete or failed.  
5. Sounds and UI update in response to player actions and events.  

---

## Tech Stack
- Engine: Unity (2022+ recommended)  
- Language: C#  
- Input: Unity Input System  
- UI: Unity UI, TextMeshPro  
- Assets: ScriptableObjects for recipes and kitchen objects  

---

## Prerequisites
- Unity Hub and Unity Editor (2022+)  
- TextMeshPro and Unity Input System packages installed  
- Git for version control  

---

## Setup Instructions
1. **Clone the Repository**  
   ```bash
git clone <your-repo-url>
cd KitchenChaos

2. Open in Unity
- Launch Unity Hub and open the project folder.
- 
3. Install Required Packages
- Open Window > Package Manager and ensure TextMeshPro and Input System are installed.
- 
4. Assign ScriptableObjects
- In the Unity Editor, create and assign RecipeSO and KitchenObjectSO assets in the appropriate folders.
- Assign references in the Inspector for managers and counters.
- 
5. Play the Game
Press Play in the Unity Editor to start the simulation.

Folder Structure
KitchenChaos/
├── Assets/
│   ├── Scripts/                # All C# scripts (Player, Counters, Managers, UI, etc.)
│   ├── ScriptableObjects/      # RecipeSO, KitchenObjectSO, RecipeListSO
│   ├── Animations/             # Animation clips for counters
│   ├── Prefabs/                # GameObject prefabs for counters, plates, etc.
│   ├── UI/                     # UI scripts and prefabs
│   └── ...                     # Other assets
├── ProjectSettings/
├── .gitignore
└── README.md

AI & Gameplay Disclaimer
This project was based off Learn Unity Beginner/Intermediate 2025 (FREE COMPLETE Course - Unity Tutorial) and all assets were created by Code Monkey and his team.

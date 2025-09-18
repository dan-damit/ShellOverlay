# ShellOverlay

**Author:** Dan Damit  
**Email:** dan@thedamits.com  
**Platform:** Windows  
**Tech Stack:** C#, .NET 8.0, WPF, WiX
---
A modular, branded shell companion for Windows—designed to streamline file navigation, workspace awareness, and system interaction without replacing the taskbar.

## 🚀 Overview

ShellOverlay is a WPF-based overlay tool that enhances the Windows desktop experience with:
- Custom launchers and workspace indicators
- Real-time system status with emoji-enhanced feedback
- Safe file operations and OneDrive-aware logic
- Deployment-grade logging and error diagnostics

## 🧱 Project Structure

- `ShellOverlay.UI` — WPF overlay interface with docked layout and branding
- `ShellOverlay.Core` — File system logic, hotkeys, virtual desktop hooks
- `ShellOverlay.Interop` — Win32 interop for taskbar control and shell APIs
- `ShellOverlay.Common` — Shared models, config, and emoji-enhanced logging
- `ShellOverlay.Tests` — Unit tests for core and interop modules

## ⚙️ Features (Planned)

- 📁 File browser with sync-aware OneDrive support
- 🖥️ Workspace bar with virtual desktop indicators
- 🔧 Global hotkeys for quick access and layout switching
- 📊 Status bar with CPU, disk, and network feedback
- 🧠 Smart logging with transcript capture and emoji status

## 🛠️ Getting Started

1. Clone the repo
2. Open `ShellOverlay.sln` in Visual Studio
3. Build and run `ShellOverlay.UI`
4. Customize layout and pinned apps via `config.json`

## 📦 Deployment Goals

- Hands-off reliability for techs and power users
- Branded UI polish with safe fallback modes
- Modular architecture for future plugins and shell extensions

---

Crafted for engineers who value clarity, control, and a touch of flair.

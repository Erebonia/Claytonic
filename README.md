# Claytonic – Systems Operations Automation Suite

**Claytonic** is a centralized tool launcher and diagnostics suite built in C# using Windows Forms. Designed for IT support technicians, it streamlines access to over 18 scripts and utilities used across citywide and enterprise systems, replacing manual lookup workflows with a professional, interactive interface.

---

## ⚙️ Core Features

### 🛠 Script Execution Hub
- Launches 19+ IT tools and scripts directly from shared network drives.
- Eliminates redundant navigation and manual script execution.

### 🔁 Data Migration Module
- Automates backup and restoration of:
  - User profiles
  - Printers
  - Desktop/Documents/Favorites/Downloads folders
- Designed to accelerate PC replacements and minimize user downtime.

### 🖥 System Diagnostics Panel
- One-click execution of diagnostic commands:
  - `sfc /scannow`
  - `DISM`
  - `ping`
  - `net user`, and others

### 🖨 Peripheral Setup & Repair
- Pre-bundled fixes and installers for:
  - ImageRetriever (scanner)
  - Networked printer drivers
  - Legacy terminals (e.g., VistaTN3270, Extra!)

### 📧 Office Troubleshooting
- Tools to resolve Outlook form issues and registry corruption:
  - Outlook cache clear
  - PST repair support
  - Add-in fixes

### 🔐 Security & Credential Access
- Run scripts to:
  - Disable firewalls
  - Reset ACID credentials
  - Manage blank login policies

---

## 👮 Security & Permission Handling

- **Admin Verification**: Sensitive operations require elevation or domain-level access.
- **Run-As Detection**: Prevents execution under mismatched credentials (compares console vs process identity).

---

## 🧩 Software Architecture

- **Modular Design**: Organized into class components such as `AudioPlayer`, `NPCDialogue`, and `CategoryNavigator` for clean extensibility.
- **Dynamic Script Mapping**: All scripts launched from live network shares, allowing centralized updates without client-side changes.

---

## 🧠 Interactive Dialogue & UX Enhancements

- Simulated NPC textbox that types dialogue one character at a time.
- Dialogues randomly rotate on app launch for a dynamic UI touch.

---

## 🔉 Audio Integration

- Custom toggle buttons (play/pause) using embedded assets.
- Volume control via integrated trackbar with real-time adjustment.

---

## 🖼 Application Preview

### 🏠 Home
<img width="1020" height="593" alt="image" src="https://github.com/user-attachments/assets/76670873-1034-4788-a30e-6261da454555" />

### 💾 Data Recovery
<img width="1021" height="597" alt="data" src="https://github.com/user-attachments/assets/0071a0e7-096a-415e-abaf-8d0cf50b1ab3" />

### 🧪 Diagnostics
<img width="1019" height="598" alt="diagnostics" src="https://github.com/user-attachments/assets/bf9ccefa-79eb-4072-afbc-fd0d909bf74c" />

### 🛠 System Setup
<img width="1021" height="600" alt="system-setup" src="https://github.com/user-attachments/assets/db30db9c-9dc7-4277-aa29-ab3047916eed" />

### 🖥 Mainframe Tools
<img width="1021" height="592" alt="mainframe" src="https://github.com/user-attachments/assets/99812fc6-4164-4da7-a2e5-974790fc7801" />

---

> Designed to empower support teams. Built with scalability and speed in mind.

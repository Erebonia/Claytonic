<img width="1172" height="615" alt="{673132B2-5ABF-479C-85C2-31ABCD297A28}" src="https://github.com/user-attachments/assets/ffad3977-4212-4086-8873-75ac11ee4762" /># Claytonic – Systems Operations Automation Suite

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
<img width="885" height="467" alt="{673132B2-5ABF-479C-85C2-31ABCD297A28}" src="https://github.com/user-attachments/assets/eb0fa4be-c0e2-486a-8d47-11505ab1adc9" />

### 💾 Data Recovery
<img width="1173" height="613" alt="{92541C22-2ECC-49DD-91BF-EB8EAAB7035B}" src="https://github.com/user-attachments/assets/c8cf788b-b17a-4c93-b8b9-d3c03e3c91a5" />

### 🧪 Diagnostics
<img width="1177" height="622" alt="{91E8AC04-A33D-44DD-A6A4-A6C0DEAF23F0}" src="https://github.com/user-attachments/assets/4c0299f6-a636-4ee8-aaeb-20a8b9fe7664" />

### 🛠 System Setup
<img width="1177" height="620" alt="{13561587-D52F-4807-AA3F-24EB1A9C2121}" src="https://github.com/user-attachments/assets/d2df0e13-892f-4ebf-abd0-cce7d75b377a" />

### 🖥 Mainframe Tools
<img width="1180" height="624" alt="{43212393-A75D-47C5-A090-766A824B0582}" src="https://github.com/user-attachments/assets/ab3ef555-6bf1-4126-ac84-bed486ebbb78" />


---

> Designed to empower support teams. Built with scalability and speed in mind.

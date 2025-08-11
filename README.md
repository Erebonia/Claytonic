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
<img width="885" height="467" alt="{F3CA3FB9-104B-45CE-9F5B-49836399562B}" src="https://github.com/user-attachments/assets/b28aad8e-471e-46b2-97b3-2800ccbed0f7" />

### 💾 Data Recovery
<img width="884" height="468" alt="{0F421FB4-560A-4F1A-94DE-7CC5C0E8CC5C}" src="https://github.com/user-attachments/assets/8870574c-c9f6-45ff-9208-b62c2c64ac5c" />

### 🧪 Diagnostics
<img width="884" height="466" alt="{391B8A05-7E9F-4607-A640-878F0889A7BC}" src="https://github.com/user-attachments/assets/76018761-5133-4e2c-a0ac-636f0c139d06" />

### 🛠 System Setup
<img width="882" height="467" alt="{E7D76BE4-D1F5-42D3-8D67-106D1B317181}" src="https://github.com/user-attachments/assets/92943912-c050-4d96-94dd-9de5af92af81" />

### 🖥 Mainframe Tools
<img width="885" height="463" alt="{591EA0A1-B3A9-48FA-AFF5-341180B68C57}" src="https://github.com/user-attachments/assets/acef81fe-37f8-45ee-a1ec-268d18c27a91" />

---

> Designed to empower support teams. Built with scalability and speed in mind.

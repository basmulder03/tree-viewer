# TreeView CLI

[![Latest Release](https://img.shields.io/github/v/release/basmulder03/tree-viewer?label=download&style=flat-square)](https://github.com/basmulder03/tree-viewer/releases/latest)

A cross-platform CLI tool to print a visual tree view of any directory, built with [.NET 9](https://dotnet.microsoft.com) and [Spectre.Console](https://spectreconsole.net/).

---

## 📦 Features

- ✅ Pretty, colorized output
- ✅ Works on Windows, macOS, and Linux
- ✅ Customizable max depth
- ✅ Standalone `.exe` download available from the [Releases](https://github.com/basmulder03/tree-viewer/releases) page

---

## 🚀 Installation

### Option 1: Download Prebuilt Binary

Grab the latest release from the [releases page](https://github.com/basmulder03/tree-viewer/releases/latest).

Rename and move to a folder in your `PATH`, e.g., `treeview.exe`.

### Option 2: Build from Source

```bash
git clone https://github.com/basmulder03/tree-viewer.git
cd tree-viewer
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true

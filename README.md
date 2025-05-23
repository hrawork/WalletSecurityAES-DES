# WalletSecurity AES & DES Encryption

A Windows Forms application developed in C# that provides encryption and decryption functionality for wallet security using **AES** and **DES** algorithms. 
The app also supports multiple text format conversions including binary, decimal, hexadecimal, and Base64.

---

## Features

- **AES Encryption & Decryption**
  - Uses a 16-character key (128-bit) for AES operations.
  - Input plaintext and get Base64 encoded encrypted text.
  - Decrypt Base64 cipher text back to plaintext.

- **DES Encryption & Decryption**
  - Uses an 8-character key (64-bit) for DES operations.
  - Input plaintext and get Base64 encoded encrypted text.
  - Decrypt Base64 cipher text back to plaintext.

- **Text Format Conversions**
  - Convert any input text to:
    - Binary
    - Decimal
    - Hexadecimal
    - Base64 (for encrypted text)

- **Simple UI**
  - Multiple forms for key entry and encryption/decryption.
  - Process log showing each step/result.

---

## Getting Started

### Prerequisites

- Windows OS
- [.NET Framework 4.x](https://dotnet.microsoft.com/download/dotnet-framework)
- Visual Studio (recommended) or any compatible C# IDE

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/hrawork/WalletSecurityAES-DES.git
   Open the solution file (WalletSecurityAES.sln) in Visual Studio.
2. Build the solution.
3. Run the project.
   
### Usage
Start the app: Enter your AES or DES key when prompted.
Enter plaintext to encrypt.
Click Encrypt to get encrypted output.
Use the Decrypt button to verify the decrypted text matches the original.
Use conversion buttons to convert text between binary, decimal, and hex.

### AES Key and DES Key Requirements
AES key must be exactly 16 characters.
DES key must be exactly 8 characters.

### Sample Test Data
AES Key: Thats my Kung Fu
Plaintext: Two One Nine Two

DES Key: DesKey99
Plaintext: This is a DES test message.

### Login Credentials:
Username: admin
password: 1234



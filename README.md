# Bank Account Management System

This project is a **Bank Account Management System** developed in C# to practice object-oriented programming and data handling. The system allows users to create and manage bank accounts, deposit and withdraw money, transfer funds, and view transaction history.

## Features

- **Create a New Bank Account:** Users can create a new bank account with a unique account number and account holder's name.
- **Check Account Balance:** Users can view the current balance of an account.
- **Deposit Money:** Users can deposit money into an account and view the updated balance.
- **Withdraw Money:** Users can withdraw money from an account, with balance validation.
- **Transfer Money:** Users can transfer funds between two accounts.
- **View Transaction History:** Users can view the complete transaction history of any account.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.

### Running the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/bank-account-management.git
   cd bank-account-management

2. Run the project:

    ```bash
    dotnet run

3. Follow the on-screen menu to interact with the system.

## Project Structure
* Program.cs: Contains the main program with the user menu and functionality implementations.
* ContaBancaria.cs: Defines the ContaBancaria class, which includes properties and methods for account management, such as depositing, withdrawing, and transferring funds.

## Class Details
### ContaBancaria Class
The ContaBancaria class manages individual accounts. Key features include:

* Properties: NumeroConta, NomeTitular, Saldo, and HistoricoTransacoes.
* Methods:
    * Depositar(double valor): Adds funds to the account balance.
    * Sacar(double valor): Withdraws funds from the account if there is sufficient balance.
    * Transferir(double valor, ContaBancaria contaDestino): Transfers funds from one account to another.

### Program Class

The main program provides a user-friendly menu that allows users to interact with the system by performing different operations.

## Usage
Upon running the project, you’ll see a menu with options to create an account, check balance, deposit, withdraw, transfer money, and view transaction history. Here’s a quick guide on each option:

    1. Create a New Account: Enter the account holder’s name to create a new account.
    2. Check Balance: Enter the account number to view the balance.
    3. Deposit Money: Enter the account number and amount to deposit.
    4. Withdraw Money: Enter the account number and amount to withdraw, with a check for sufficient funds.
    5. Transfer Money: Enter the source and destination account numbers and the amount to transfer.
    6. View Transaction History: Enter the account number to view all transactions related to that account.
### Example
    
    ===== Bank Account Management System =====
    1. Create a New Bank Account
    2. View Account Balance
    3. Deposit Money
    4. Withdraw Money
    5. Transfer Money Between Accounts
    6. View Transaction History
    0. Exit
    Select an option:

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License
This project is open-source and available under the MIT License.

# FinApp
FinApp is a fintech application designed to simplify financial management for users. It offers tools for account management, money transfers, monthly budgeting, and online purchases, all in one place. The application is built with a strong emphasis on clean architecture, following best practices for maintainability and scalability.

Note: This project is currently a work in progress. Features are being actively developed and refined, and future updates will bring additional functionalities and improvements.

Features
Account Management: Easily manage multiple accounts, track balances, and monitor transactions.
Money Transfers: Securely transfer money between accounts or to other users.
Monthly Budgeting: Set and manage a monthly budget to track your spending.
Online Purchases: Conveniently make online purchases directly within the app.
Architecture
Clean Architecture
The FinApp project is developed using the Clean Architecture pattern, ensuring that the application is:

Independent of frameworks: The core logic of the application is isolated from external dependencies.
Testable: Each component of the application can be independently tested.
Maintainable: The architecture encourages separation of concerns, making the codebase easier to maintain and extend.
Scalable: The modular structure allows for easy scaling as the application grows.
CQRS and Mediator Design Pattern
FinApp implements the CQRS (Command Query Responsibility Segregation) pattern, which separates the reading and writing of data to ensure optimized performance and scalability.

Commands: Handle the operations that modify the state of the application (e.g., money transfers, budgeting).
Queries: Handle the retrieval of data without altering the state of the application.
The Mediator Design Pattern is used to decouple the request handlers from the rest of the application, promoting a clean, organized, and scalable codebase.

Exception Handling
The application has robust exception handling mechanisms to ensure that errors are properly managed and do not cause unexpected behavior. Custom exceptions are used to provide meaningful error messages, and global exception handling ensures that the application remains stable.
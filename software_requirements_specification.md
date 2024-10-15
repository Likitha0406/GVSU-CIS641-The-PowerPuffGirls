# Software Requirements Specification (SRS)

## Overview
This document describes the functional and non-functional requirements for the **Password Store Manager Project**. The purpose of this document is to outline the key features and performance expectations of the application, ensuring a clear understanding of the system's capabilities.

## Functional Requirements

1. **Password Retrieval**
   - **FR1:** The system shall allow users to retrieve stored passwords by entering a unique master password.
   

2. **Password Generation**
   - **FR2:** The application shall provide a password generator that can generate secure passwords based on user-specified criteria, such as length and character types.
   - **FR3:** The system shall allow the users to customize their password generation by adding or removing the special characters, number, and upper-case letters.
   - **FR4:** The system shall ensure the user to save them before allowing the newly generated passwords that meet the minimum-security criteria including the length and special 
              characters

3. **Password Storage**
   - **FR5:** The system shall store encrypted passwords in an SQLite database to ensure data security.

4. **Password Deletion**
   - **FR6:** The application shall allow users to delete stored passwords and delete the application securely when required.


## Non-Functional Requirements

1. **Data Encryption**
   - **NFR7:** The system shall encrypt all stored passwords using a minimum of AES-256 encryption.

2. **Performance**
   - **NFR8:** The application shall ensure that the password retrieval process takes less than 2 seconds under normal load conditions.
   - **NFR9:** The application shall ensure that for all operations it should complete with in 2 seconds on average including password generation, password retrieval, password 
                deletion.

3. **Compatibility**
   - **NFR10:** The system shall be compatible with Mac operating systems and require minimal installation time.

4. **Usability**
   - **NFR11:** The application shall support a user-friendly interface, making it easy to navigate and perform password-related tasks with minimal training.

5. **Availability**
   -**NFR12:** The system shall ensure that it will be available 99% of the time by ensuring continuous access to saved passwords with minimal downtime.

6. **Reliability**
   -**NFR13:** The application shall ensure that it maintains 99.9% uptime to ensure that the users can always access their saved passwords.

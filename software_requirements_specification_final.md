# Software Requirements Specification (SRS)

## Overview
This document describes the **functional** and **non-functional** requirements for the **Password Store Manager Project**. The system allows users to securely store, generate, and manage passwords, ensuring high security and usability. The application features a master password-based access, password generation, and secure password storage functionalities.

---

## Software Requirements

### Functional Requirements

#### Home Page
| ID   | Requirement |
|------|-------------|
| FR1  | The system shall prompt the user to set a **master password** upon first-time use. |
| FR2  | The user SHALL need to enter the master password on the **Home Page** to access the stored passwords and application functionalities. |
| FR3  | The system SHALL validate the entered master password against the encrypted database record. |
| FR4  | After successful entry of the master password, the application SHALL redirect the user to the **Password Store** page. |

#### Random Password Generator
| ID   | Requirement |
|------|-------------|
| FR5  | The application SHALL provide a **Random Password Generator** page for users to generate secure passwords. |
| FR6  | The Random Password Generator SHALL allow users to specify password length, character types (letters, numbers, symbols), and strength. |
| FR7  | The generated password SHALL be displayed to the user with an option to copy it to the clipboard. |
| FR8  | The application SHALL ensure that generated passwords meet predefined complexity requirements (e.g., minimum length, inclusion of uppercase, lowercase, numbers, and symbols). |
| FR9  | The generated password SHALL be encrypted before being stored in the database if the user opts to save it. |

#### Password Storage
| ID   | Requirement |
|------|-------------|
| FR10 | The system SHALL store all passwords in an encrypted **SQLite database**. |
| FR11 | Users SHALL be able to view and manage stored passwords after entering the correct master password. |
| FR12 | The system SHALL allow users to securely add, edit, and delete passwords from the database. |
| FR13 | The application SHALL store each password entry with the associated **application/service name** for easy identification. |

#### Password Deletion
| ID   | Requirement |
|------|-------------|
| FR14 | The application SHALL allow users to delete individual stored passwords securely. |
| FR15 | The system SHALL prompt for confirmation before deleting any password. |
| FR16 | Deleted passwords SHALL be permanently removed from the database, ensuring they cannot be recovered. |

#### About Page
| ID   | Requirement |
|------|-------------|
| FR17 | The application SHALL include an **About Page** that provides information about the development team and project details. |
| FR18 | The About Page SHALL include contact information for support and a link to the project’s repository (e.g., GitHub). |

---

### Non-Functional Requirements

#### Security
| ID   | Requirement |
|------|-------------|
| NFR1 | The system SHALL encrypt all stored passwords using a minimum of **AES-256 encryption**. |
| NFR2 | The system SHALL store passwords using salted hashes to protect against unauthorized access. |
| NFR3 | Passwords SHALL never be stored in plaintext at any point. |
| NFR4 | The application SHALL employ **HTTPS** to ensure secure communication between the client and server. |

#### Performance
| ID   | Requirement |
|------|-------------|
| NFR5 | The password retrieval process SHALL take less than **2 seconds** under normal load conditions. |
| NFR6 | The application SHALL load the **Home Page** within **1 second** of the user's request. |
| NFR7 | The **Random Password Generator** SHALL generate a new password in less than **1 second**. |

#### Usability
| ID   | Requirement |
|------|-------------|
| NFR8 | The application SHALL have an **intuitive user interface** that allows users to easily navigate between pages. |
| NFR9 | The application SHALL provide **clear feedback** to the user for actions such as successful login, password generation, and deletion. |
| NFR10 | The system SHALL support basic accessibility features such as **high-contrast mode** and **keyboard navigation**. |

#### Compatibility
| ID   | Requirement |
|------|-------------|
| NFR11 | The application SHALL be compatible with **Windows**, **macOS**, and **Linux** operating systems. |
| NFR12 | The system SHALL run on the latest stable versions of **Chrome**, **Firefox**, and **Safari** browsers. |
| NFR13 | The application SHALL be designed to scale and function properly on various screen sizes, including mobile devices. |

#### Availability
| ID   | Requirement |
|------|-------------|
| NFR14 | The system SHALL be available **99%** of the time, ensuring users can access their passwords with minimal downtime. |
| NFR15 | The system SHALL include automated **backup mechanisms** to recover stored passwords in case of system failure. |

#### Reliability
| ID   | Requirement |
|------|-------------|
| NFR16 | The application SHALL provide an **error log** for system failures, with automatic reporting for critical issues. |
| NFR17 | The system SHALL be able to **recover from crashes** without losing data. |

---

# Change Management Plan for the **Password Store Manager** Application

Introducing the **Password Store Manager** within a corporate environment requires careful planning and consideration. The objective is to ensure that employees are not only able to use the application effectively but also feel confident in integrating it into their daily tasks. This plan outlines the steps we will take to achieve smooth adoption, support integration into existing systems, and address any issues as they arise.

---

### 1. **Training Users**

Training is essential to ensure that employees are comfortable using the **Password Store Manager** application and understand its value in simplifying password management. Our approach will involve several key elements:

#### a. **Comprehensive Onboarding Resources**
We will create a set of clear, easy-to-understand materials that will guide users through the process of using the application from start to finish:
- **User Manual**: A well-organized user manual will be available in both digital and printable formats. It will explain everything from setting up the master password to using the **Password Store** page, generating secure passwords, and managing stored credentials.
- **Video Tutorials**: Short, informative videos will be created for employees to watch at their own pace. These will cover all the basic functions, such as setting up the master password, using the password generator, and adding passwords to the store. 
- **Step-by-Step Guides**: These guides will provide detailed instructions with screenshots to show users exactly how to navigate through the application.

#### b. **Interactive Live Training**
While written documentation and videos are useful, some employees may benefit from a more hands-on approach. We will organize:
- **Live Webinars**: These sessions will give employees an opportunity to ask questions in real-time and get an introduction to the software’s features. The sessions will cover basic to advanced functionalities, such as generating strong passwords and managing stored entries.
- **In-Person or Virtual Workshops**: Smaller group sessions will be set up where employees can work directly with the application. These workshops will provide an opportunity for users to practice using the software in a supportive, guided environment.

#### c. **Ongoing Support and Resources**
Training shouldn’t end after the initial onboarding. We will offer:
- **A Support Team**: A dedicated team will be available to help with any user questions or issues. Whether through email, chat, or phone support, we’ll be accessible to ensure that any challenges are quickly resolved.
- **FAQs and Troubleshooting Guides**: An internal FAQ page will be set up, and will be updated frequently as new questions or issues arise. This will allow employees to find quick solutions without needing to contact support directly.

---

### 2. **Integration with Their Ecosystem / Software**

For the **Password Store Manager** to be adopted successfully, it must seamlessly fit into the company’s existing systems and work well with the tools employees already use. Here’s how we plan to integrate the application:

#### a. **Cross-Platform Compatibility**
Employees may use a variety of operating systems, so the application will be compatible with **Windows**, **macOS**, and **Linux**. This means users across different departments can access the software, whether they use desktop computers, laptops, or company-issued devices.

#### b. **Database and Security**
The **Password Store Manager** will use **SQLite**, a lightweight, serverless database that stores all passwords locally. Since there is no need for an external server, this simplifies deployment. The data will be encrypted using **AES-256** to ensure security. The application will also meet the company’s security requirements by ensuring that passwords are stored securely, and never in plain text.

#### c. **Seamless Integration with Existing Security Infrastructure**
To ensure a smooth fit with the company’s overall security infrastructure, we will:
- **Support Single Sign-On (SSO)**: If necessary, the app will be able to integrate with existing **SSO** tools, so users don’t need to remember yet another set of credentials.
- **Enable Two-Factor Authentication (2FA)**: For added security, **2FA** will be supported, requiring users to verify their identity with an additional authentication step when accessing the application.

#### d. **Deployment Process**
The application will be simple to deploy across the organization. To make this process as seamless as possible, we will:
- **Provide Easy Installation Packages**: The app will be available through **MSI installers** or **Docker containers**, making it easy to deploy on different devices.
- **Automatic Updates**: Once installed, the software will automatically check for updates and install them without requiring user intervention. This ensures that everyone is always using the latest version without any manual effort.

---

### 3. **How to Ensure Discovered Issues Are Resolved**

Despite careful planning, issues will likely arise as users begin interacting with the application. To ensure any discovered issues are quickly addressed and resolved, we’ll establish a clear process for identifying, tracking, and fixing problems.

#### a. **Issue Reporting and Tracking**
Employees will be able to report any issues they encounter directly through an **issue tracking system** (e.g., **Jira** or **GitHub Issues**). When issues are reported, the development team will:
- **Categorize the Issues**: Issues will be prioritized based on severity and impact on users. Critical issues such as security flaws or data corruption will be addressed immediately.
- **Track Progress**: The issue tracker will allow the team to monitor the progress of each reported problem, from identification through resolution.

#### b. **Regular Updates and Hotfixes**
- **Patches for Minor Issues**: For minor bugs or improvements, patches will be included in the regular software updates. These will be rolled out regularly to keep the application running smoothly.
- **Critical Bug Fixes**: In the case of critical issues (e.g., security vulnerabilities), **hotfixes** will be developed and deployed immediately. Users will be notified of the fix and prompted to update their software as soon as the patch is available.

#### c. **User Feedback Loop**
Continuous improvement is key to ensuring long-term success. We will:
- **Collect Feedback**: Regular **surveys** and **feedback forms** will be made available to users so they can report issues or suggest improvements. This will help us identify features that may need refinement.
- **Monitor Usage**: We will gather **usage analytics** to see how employees are using the application. If certain features are underutilized or causing problems, we will consider adjustments in future versions.

#### d. **Proactive Error Monitoring**
- **Built-in Error Reporting**: The application will have an error reporting system that automatically collects crash data and logs. This helps the development team resolve issues before they become widespread.
- **Monitoring Tools**: Performance and usability monitoring tools will be used to track how well the application is running across the organization. This will allow us to identify potential problems and address them before they affect many users.

  
## Traceability Links

This section explains the link between the **class diagrams**, **use case diagrams**, and **activity diagrams** to the requirements.

### Use Case Diagram

| Artifact ID | Artifact Name         | Requirement ID |
|-------------|-----------------------|----------------|
| UC1         | Set Master Password   | FR1            |
| UC2         | Generate Password     | FR5, FR6       |
| UC3         | Store Password        | FR10, FR11     |
| UC4         | Delete Password       | FR14, FR15     |

### Activity Diagram

| Artifact ID | Artifact Name          | Requirement ID |
|-------------|------------------------|----------------|
| AD1         | Generate Secure Password| FR5, FR6       |
| AD2         | Store New Password      | FR10, FR11     |
| AD3         | Update Existing Password| FR12, FR13     |
| AD4         | Delete Password         | FR14, FR15     |

### Class Diagram

| Artifact Name      | Requirement ID  |
|--------------------|-----------------|
| Class User         | FR1-FR6         |
| Class Password     | FR10, FR11      |
| Class PasswordManager | FR5, FR6, FR12 |
| Class SQLiteHelper | FR10, FR11, FR12|
| Class UI           | FR1, FR10, FR12 |
| Class Settings     | FR21, FR22      |

### Software Artifacts

This section describes the artifacts developed during the creation of the **Online Password Manager** application. We will also align the functional and non-functional requirements with the respective artifacts.

Below are the links to refer to each artifact for the application:

* [CRC+Class+Object](https://github.com/Likitha0406/GVSU-CIS641-The-PowerPuffGirls/blob/main/docs/Document%20CRC%2BClass%2BObject.pdf)
* [Class Diagram](https://github.com/Likitha0406/GVSU-CIS641-The-PowerPuffGirls/blob/main/docs/Document%20Class%20Diagram.pdf)
* [Sequence+State](https://github.com/Likitha0406/GVSU-CIS641-The-PowerPuffGirls/blob/main/docs/Document%20Sequence%2BState.pdf)
* [Use Case+Activity Diagram](https://github.com/Likitha0406/GVSU-CIS641-The-PowerPuffGirls/blob/main/docs/DocumentUseCase%2BActivity%20Diagram.pdf)
* [Screenshots for the Code](https://github.com/Likitha0406/GVSU-CIS641-The-PowerPuffGirls/blob/main/docs/Document1.pdf)

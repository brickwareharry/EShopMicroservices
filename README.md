# EShopMicroservices
This document contains the notes and a draft documentation which includes some empty sections to be filled. It will gradually evolve into a further comprehensive documentation with a table of contents.


## Note 1. References for design basic
Useful design basic: https://www.se.rit.edu/~swen-262/schedule/2238-2per.html

## Note 2. Draft of Table of Contents for overall documentation

reference: https://chatgpt.com/share/865f6b93-e5c7-4094-8c04-44a58319364d

# Draft Documentation

## 1. Project Overview
- 1.1 Purpose and Scope
- 1.2 Technology Stack
- 1.3 Architecture Diagram

## 2. Functional Requirements Document
- 2.1 User Stories
  - 2.1.1 As a user, I want to list products
  - 2.1.2 As a user, I want to filter products by brand and category
  - 2.1.3 As a user, I want to see the supplier of a product in the product detail screen with all characteristics
  - 2.1.4 As a user, I want to add products to the shopping cart for checkout
  - 2.1.5 As a user, I want to see the total cost for all items in my cart to check affordability
  - 2.1.6 As a user, I want to see the total cost of each item in the shopping cart for price verification
  - 2.1.7 As a user, I want to specify the delivery address for all products
  - 2.1.8 As a user, I want to add a note to the delivery address for special instructions
  - 2.1.9 As a user, I want to specify my credit card information during checkout to pay for items
  - 2.1.10 As a user, I want the system to indicate how many items are in stock
  - 2.1.11 As a user, I want to receive an order confirmation email with an order number
  - 2.1.12 As a user, I want to view my old orders and order history
  - 2.1.13 As a user, I want to log into the system and have the system remember my shopping cart items
- 2.2 Domain Analysis
  - 2.2.1 Nouns Analysis (Identifying Domain Entities)
    - **User**: Represents the person interacting with the system.
    - **Product**: Items available for purchase in the e-shop.
    - **Brand**: The manufacturer or company associated with a product.
    - **Category**: Different types or classifications of products.
    - **Supplier**: The entity providing the products to the e-shop.
    - **Product Detail Screen**: The interface where product information is displayed.
    - **Characteristics**: Features or attributes of a product.
    - **Shopping Cart**: A virtual cart where selected products are stored before checkout.
    - **Item**: Individual products in the shopping cart.
    - **Total Cost**: The sum price of all products or a single product in the cart.
    - **Address**: The delivery location specified by the user.
    - **Note**: Additional instructions related to delivery.
    - **Credit Card Information**: Payment details provided by the user for transactions.
    - **Checkout**: The process of finalizing a purchase.
    - **Stock**: The available quantity of products.
    - **Order Confirmation Email**: An email sent to the user confirming their order.
    - **Order Number**: A unique identifier for the user's order.
    - **Old Orders**: Previous orders placed by the user.
    - **Order Items History**: The history of items purchased in past orders.
    - **System**: The e-shop application platform itself.
  - 2.2.2 Verbs Analysis (Identifying Domain Actions)
    - **List**: Display a collection of products or orders.
    - **Filter**: Apply criteria to narrow down the displayed products.
    - **See**: View information, such as product details, supplier, and cost.
    - **Put**: Add products to the shopping cart.
    - **Check Out**: Complete the purchase of products in the shopping cart.
    - **Specify**: Provide details, such as a delivery address or payment information.
    - **Add**: Include additional information, such as a note to the delivery address.
    - **Pay**: Complete a transaction using credit card information.
    - **Tell**: Provide information to the user, such as stock levels.
    - **Receive**: Get confirmation, such as an order confirmation email.
    - **Log In**: Authenticate as a user in the system.
    - **Remember**: Store information, such as shopping cart items for a user session.
  - 2.2.3 Entity-Action Mapping
    | **Entity**               | **Actions**                                                                                             |
    |--------------------------|---------------------------------------------------------------------------------------------------------|
    | **User**                 | List, filter, see, put, specify, add, pay, receive, log in, remember                                     |
    | **Products**             | List, filter, see                                                                                       |
    | **Brand**                | Filter                                                                                                  |
    | **Categories**           | Filter                                                                                                  |
    | **Supplier**             | See                                                                                                     |
    | **Product Detail Screen**| See                                                                                                     |
    | **Characteristics**      | See                                                                                                     |
    | **Shopping Cart**        | Put, see, check out, remember                                                                           |
    | **Items**                | See, put                                                                                                |
    | **Total Cost**           | See                                                                                                     |
    | **Address**              | Specify                                                                                                 |
    | **Note**                 | Add                                                                                                     |
    | **Credit Card Information** | Specify, pay                                                                                         |
    | **Checkout**             | Check out                                                                                               |
    | **Stock**                | Tell                                                                                                    |
    | **Order Confirmation Email** | Receive                                                                                            |
    | **Order Number**         | Receive                                                                                                 |
    | **Old Orders**           | List                                                                                                    |
    | **Order Items History**  | List                                                                                                    |
    | **System**               | Tell, remember                                                                                          |

## 3. Non-Functional Requirements
- 3.1 Performance Requirements
- 3.2 Security Requirements
- 3.3 Usability Requirements
- 3.4 Scalability Requirements
- 3.5 Compliance Requirements

## 4. Architecture and Design
- 4.1 System Overview
- 4.2 Component Diagrams
- 4.3 Data Flow Diagrams
- 4.4 UML Class Diagrams
- 4.5 Entity-Relationship (ER) Diagrams
- 4.6 Sequence Diagrams
- 4.7 Inheritance and Interface Documentation
- 4.8 Class Responsibility Collaborator (CRC) Cards

## 5. Class Design Document
- 5.1 Class Overview
  - 5.1.1 Class Name
  - 5.1.2 Purpose
- 5.2 Attributes
- 5.3 Methods
- 5.4 Relationships

## 6. Method Specifications
- 6.1 Method Name
- 6.2 Purpose
- 6.3 Parameters
- 6.4 Return Type
- 6.5 Exceptions
- 6.6 Behavior

## 7. Attribute Specifications
- 7.1 Attribute Name
- 7.2 Data Type
- 7.3 Default Value
- 7.4 Constraints
- 7.5 Description

## 8. Database Schema
- 8.1 ER Diagram
- 8.2 Data Dictionary
- 8.3 Normalization Details
- 8.4 Sample Data

## 9. User Interface (UI) Design Document
- 9.1 Wireframes
- 9.2 Mockups
- 9.3 Style Guide
- 9.4 Component Library

## 10. User Experience (UX) Design Document
- 10.1 User Personas
- 10.2 User Journey Maps
- 10.3 Interaction Flows
- 10.4 Usability Testing Reports

## 11. API Design Document
- 11.1 Endpoint List
- 11.2 Request/Response Formats
- 11.3 Authentication and Authorization
- 11.4 Error Handling

## 12. Setup and Installation
- 12.1 Environment Setup
- 12.2 Installation Guide

## 13. Codebase Documentation
- 13.1 Directory Structure
- 13.2 Code Comments
- 13.3 Automated Documentation Tools

## 14. Security Design Document
- 14.1 Authentication Mechanisms
- 14.2 Authorization Strategies
- 14.3 Data Encryption
- 14.4 Vulnerability Mitigation

## 15. Performance and Scalability Design Document
- 15.1 Performance Benchmarks
- 15.2 Scaling Strategies
- 15.3 Caching Strategies
- 15.4 Load Balancing

## 16. Accessibility Design Document
- 16.1 Accessibility Guidelines
- 16.2 Accessible Components
- 16.3 Testing Procedures

## 17. Data Privacy Document
- 17.1 Data Collection
- 17.2 Data Storage
- 17.3 Compliance

## 18. Testing Documentation
- 18.1 Test Cases
- 18.2 Testing Strategy

## 19. Deployment Guide
- 19.1 Production Setup
- 19.2 CI/CD Pipeline

## 20. Change Log and Versioning
- 20.1 Change Log
- 20.2 Versioning

## 21. Contributing Guide
- 21.1 Contribution Guidelines

## 22. Future Roadmap
- 22.1 Planned Features
- 22.2 Technical Debt

## 23. Automated Documentation Tools
- 23.1 Tools for Code Documentation
- 23.2 Benefits of Automated Documentation

## 24. Procedures for Documenting Classes, Attributes, and Methods
- 24.1 Use Descriptive Naming Conventions
- 24.2 Follow a Consistent Documentation Template
- 24.3 Keep Documentation Updated
- 24.4 Review and Approve Documentation
- 24.5 Automate Where Possible
- 24.6 Version Control
